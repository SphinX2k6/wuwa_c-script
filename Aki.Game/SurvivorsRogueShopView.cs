using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B7C RID: 11132
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueShopView : UiViewBase, ISurvivorsRogueCommandView
{
	// Token: 0x17001EC4 RID: 7876
	// (get) Token: 0x060170E0 RID: 94432 RVA: 0x005DA71B File Offset: 0x005D891B
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x17001EC5 RID: 7877
	// (get) Token: 0x060170E1 RID: 94433 RVA: 0x005DA723 File Offset: 0x005D8923
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x060170E2 RID: 94434 RVA: 0x005DA72B File Offset: 0x005D892B
	public SurvivorsRogueShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060170E3 RID: 94435 RVA: 0x005DA73C File Offset: 0x005D893C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnRefresh)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnConfirm))
		};
	}

	// Token: 0x060170E4 RID: 94436 RVA: 0x005DA829 File Offset: 0x005D8A29
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060170E5 RID: 94437 RVA: 0x005DA834 File Offset: 0x005D8A34
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.RefreshRoleGain));
		EventSystem.Instance.Add<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.RefreshWeaponGain));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshCurrency));
	}

	// Token: 0x060170E6 RID: 94438 RVA: 0x005DA8A0 File Offset: 0x005D8AA0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.RefreshRoleGain));
		EventSystem.Instance.Remove<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.RefreshWeaponGain));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshCurrency));
	}

	// Token: 0x060170E7 RID: 94439 RVA: 0x005DA90B File Offset: 0x005D8B0B
	private void OnPurchase(GoodsDetail data)
	{
		if (this.Command.IsFinished)
		{
			return;
		}
		this.Command.RequestCommand(new int[]
		{
			data.SurvivorsGainData.IncId
		}, null);
	}

	// Token: 0x060170E8 RID: 94440 RVA: 0x005DA93C File Offset: 0x005D8B3C
	private void OnLock(GoodsDetail data, bool bLock)
	{
		this.Command.RequestLock(data.SurvivorsGainData.IncId, bLock, delegate(bool success)
		{
			if (!success)
			{
				return;
			}
			data.IsLock = bLock;
			GenericLayout<SurvivorsRogueCardShopItem, GoodsDetail> cardList = this.CardList;
			if (cardList == null)
			{
				return;
			}
			SurvivorsRogueCardShopItem layoutItemByKey = cardList.GetLayoutItemByKey(data.SurvivorsGainData.IncId);
			if (layoutItemByKey == null)
			{
				return;
			}
			SurvivorsRogueCardBase cardItem = layoutItemByKey.CardItem;
			if (cardItem == null)
			{
				return;
			}
			cardItem.SetLock(bLock);
		});
	}

	// Token: 0x060170E9 RID: 94441 RVA: 0x005DA994 File Offset: 0x005D8B94
	private void OnClickBtnRefresh()
	{
		ISurvivorsShopViewInfo viewInfo = this.Command.GetViewInfo();
		if (SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount() < viewInfo.RefreshCost)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsStore_InsufficientCurrencyTips", Array.Empty<object>());
			return;
		}
		this.RefreshDirty = true;
		this.Command.RequestCommand(new int[]
		{
			-1
		}, null);
	}

	// Token: 0x060170EA RID: 94442 RVA: 0x005DA9FC File Offset: 0x005D8BFC
	private void OnClickBtnConfirm()
	{
		if (!SurvivorsRogueModel.Instance.NotTipsShopPurchaseAvailable && this.Command.IsShopPurchaseAvailable())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShopPurchaseAvailableConfirm);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleTextKey = "SurvivorsShopConfirmationDialog_PrompText";
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.Command.Execute();
			};
			confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
			{
				SurvivorsRogueModel.Instance.NotTipsShopPurchaseAvailable = isSelectOn;
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.Command.Execute();
	}

	// Token: 0x060170EB RID: 94443 RVA: 0x005DAA94 File Offset: 0x005D8C94
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueShopView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueShopView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170EC RID: 94444 RVA: 0x005DAAD7 File Offset: 0x005D8CD7
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandShop command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x060170ED RID: 94445 RVA: 0x005DAAEA File Offset: 0x005D8CEA
	private SurvivorsRogueCardShopItem CreateCardItem()
	{
		return new SurvivorsRogueCardShopItem
		{
			OnPurchaseBtnClickCallback = new Action<GoodsDetail>(this.OnPurchase),
			OnClickLockCallback = new Action<GoodsDetail, bool>(this.OnLock),
			OnStateChangeCallback = new Action<GoodsDetail, bool>(this.OnStateChangeCallback)
		};
	}

	// Token: 0x060170EE RID: 94446 RVA: 0x005DAB27 File Offset: 0x005D8D27
	private void OnStateChangeCallback(GoodsDetail data, bool bChosen)
	{
		this.CardList.DeselectCurrentGridProxy();
		this.OnCurrentSelectGoodsStateChange(false);
		if (bChosen)
		{
			this.CardList.SelectGridProxy(data.Index, false);
			this.CurrentSelectGoodsInfo = data;
			this.OnCurrentSelectGoodsStateChange(true);
		}
	}

	// Token: 0x060170EF RID: 94447 RVA: 0x005DAB60 File Offset: 0x005D8D60
	public void Refresh()
	{
		UiAsyncTask task = new UiAsyncTask("SurvivorsRogueShopView.Refresh", delegate()
		{
			SurvivorsRogueShopView.<<Refresh>b__24_0>d <<Refresh>b__24_0>d;
			<<Refresh>b__24_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Refresh>b__24_0>d.<>4__this = this;
			<<Refresh>b__24_0>d.<>1__state = -1;
			<<Refresh>b__24_0>d.<>t__builder.Start<SurvivorsRogueShopView.<<Refresh>b__24_0>d>(ref <<Refresh>b__24_0>d);
			return <<Refresh>b__24_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060170F0 RID: 94448 RVA: 0x005DAB90 File Offset: 0x005D8D90
	private UniTask RefreshAsync()
	{
		SurvivorsRogueShopView.<RefreshAsync>d__25 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueShopView.<RefreshAsync>d__25>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170F1 RID: 94449 RVA: 0x005DABD3 File Offset: 0x005D8DD3
	private void RefreshCurrency(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshCurrency();
	}

	// Token: 0x060170F2 RID: 94450 RVA: 0x005DABDC File Offset: 0x005D8DDC
	private void RefreshCurrency()
	{
		bool flag = SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount() >= this.RefreshCurrencyCount;
		UUIText text = base.GetText(6);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x060170F3 RID: 94451 RVA: 0x005DAC24 File Offset: 0x005D8E24
	private void OnCurrentSelectGoodsStateChange(bool bSelected)
	{
		if (this.CurrentSelectGoodsInfo != null)
		{
			Aki.Protocol.SurvivorsGainData survivorsGainData = this.CurrentSelectGoodsInfo.SurvivorsGainData;
			string a = survivorsGainData.DataCase.ToString();
			if (!(a == "Proto_SurvivorsRoleLv"))
			{
				if (!(a == "Proto_SurvivorsWeaponLv"))
				{
					return;
				}
				int weaponId = survivorsGainData.SurvivorsWeaponLv.WeaponId;
				SurvivorsWeapon survivorsWeapon = survivorsGainData.SurvivorsWeaponLv.SurvivorsWeapon;
				if (bSelected && (survivorsWeapon.Level == survivorsWeapon.MaxLevel || this.CurrentSelectGoodsInfo.IsSell))
				{
					return;
				}
				SurvivorsRogueWeaponStateGrid weaponGrid = this.BaseItem.RoleStatePanel.GetWeaponGrid(weaponId);
				if (weaponGrid == null)
				{
					return;
				}
				weaponGrid.SetSelectOn(bSelected);
			}
			else
			{
				SurvivorsRole survivorsRole = survivorsGainData.SurvivorsRoleLv.SurvivorsRole;
				if (bSelected && (survivorsRole.Level == survivorsRole.MaxLevel || this.CurrentSelectGoodsInfo.IsSell))
				{
					return;
				}
				SurvivorsRogueRoleInfoGrid roleGrid = this.BaseItem.RoleStatePanel.RoleGrid;
				if (roleGrid == null)
				{
					return;
				}
				roleGrid.SetSelectOn(bSelected);
				return;
			}
		}
	}

	// Token: 0x060170F4 RID: 94452 RVA: 0x005DAD17 File Offset: 0x005D8F17
	private void RefreshRoleGain(int roleId)
	{
		SurvivorsRogueRoleInfoGrid roleGrid = this.BaseItem.RoleStatePanel.RoleGrid;
		if (roleGrid == null)
		{
			return;
		}
		roleGrid.SetLevelUp();
	}

	// Token: 0x060170F5 RID: 94453 RVA: 0x005DAD33 File Offset: 0x005D8F33
	private void RefreshWeaponGain(int weaponId, bool isLevelUp)
	{
		if (!isLevelUp)
		{
			return;
		}
		SurvivorsRogueWeaponStateGrid weaponGrid = this.BaseItem.RoleStatePanel.GetWeaponGrid(weaponId);
		if (weaponGrid == null)
		{
			return;
		}
		weaponGrid.SetLevelUp();
	}

	// Token: 0x060170F6 RID: 94454 RVA: 0x005DAD54 File Offset: 0x005D8F54
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "ShopCardLock")
		{
			GenericLayout<SurvivorsRogueCardShopItem, GoodsDetail> cardList = this.CardList;
			SurvivorsRogueCardShopItem survivorsRogueCardShopItem = (cardList != null) ? cardList.GetLayoutItemByIndex(0) : null;
			UUIItem uuiitem;
			if (survivorsRogueCardShopItem == null)
			{
				uuiitem = null;
			}
			else
			{
				SurvivorsRogueCardBase cardItem = survivorsRogueCardShopItem.CardItem;
				uuiitem = ((cardItem != null) ? cardItem.GetGuideUiItem("0") : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		else
		{
			if (a == "SurvivorFightInfo")
			{
				if (configParams.Length < 3)
				{
					return null;
				}
				string a2 = configParams[2];
				if (a2 == "FirstWeapon")
				{
					SurvivorsRogueViewBase baseItem = this.BaseItem;
					if (baseItem == null)
					{
						return null;
					}
					SurvivorsRogueRoleStatePanel roleStatePanel = baseItem.RoleStatePanel;
					if (roleStatePanel == null)
					{
						return null;
					}
					return roleStatePanel.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				else if (a2 == "FirstTwoWeapon")
				{
					UUIItem guideUiItem = base.GetGuideUiItem("3");
					if (guideUiItem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						guideUiItem,
						guideUiItem
					};
				}
			}
			if (!(a == "EvolveBar"))
			{
				return null;
			}
			GenericLayout<SurvivorsRogueCardShopItem, GoodsDetail> cardList2 = this.CardList;
			SurvivorsRogueCardShopItem survivorsRogueCardShopItem2 = (cardList2 != null) ? cardList2.GetLayoutItemByIndex(0) : null;
			if (survivorsRogueCardShopItem2 == null)
			{
				return null;
			}
			return survivorsRogueCardShopItem2.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x0400AC99 RID: 44185
	public int CommandIncId;

	// Token: 0x0400AC9A RID: 44186
	public SurvivorsRogueCommandShop Command;

	// Token: 0x0400AC9B RID: 44187
	[Nullable(2)]
	private SurvivorsRogueViewBase BaseItem;

	// Token: 0x0400AC9C RID: 44188
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueCardShopItem, GoodsDetail> CardList;

	// Token: 0x0400AC9D RID: 44189
	private bool RefreshDirty = true;

	// Token: 0x0400AC9E RID: 44190
	[Nullable(2)]
	private GoodsDetail CurrentSelectGoodsInfo;

	// Token: 0x0400AC9F RID: 44191
	private int RefreshCurrencyCount;
}
