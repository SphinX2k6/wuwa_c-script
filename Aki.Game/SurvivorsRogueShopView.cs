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

// Token: 0x020020F8 RID: 8440
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueShopView : UiViewBase, ISurvivorsRogueCommandView
{
	// Token: 0x17001F1C RID: 7964
	// (get) Token: 0x06014B11 RID: 84753 RVA: 0x0060728B File Offset: 0x0060548B
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x17001F1D RID: 7965
	// (get) Token: 0x06014B12 RID: 84754 RVA: 0x00607293 File Offset: 0x00605493
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x06014B13 RID: 84755 RVA: 0x0060729B File Offset: 0x0060549B
	public SurvivorsRogueShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014B14 RID: 84756 RVA: 0x006072AC File Offset: 0x006054AC
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

	// Token: 0x06014B15 RID: 84757 RVA: 0x00607399 File Offset: 0x00605599
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014B16 RID: 84758 RVA: 0x006073A4 File Offset: 0x006055A4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.RefreshRoleGain));
		EventSystem.Instance.Add<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.RefreshWeaponGain));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshCurrency));
	}

	// Token: 0x06014B17 RID: 84759 RVA: 0x00607410 File Offset: 0x00605610
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.RefreshRoleGain));
		EventSystem.Instance.Remove<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.RefreshWeaponGain));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshCurrency));
	}

	// Token: 0x06014B18 RID: 84760 RVA: 0x0060747B File Offset: 0x0060567B
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

	// Token: 0x06014B19 RID: 84761 RVA: 0x006074AC File Offset: 0x006056AC
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

	// Token: 0x06014B1A RID: 84762 RVA: 0x00607504 File Offset: 0x00605704
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

	// Token: 0x06014B1B RID: 84763 RVA: 0x0060756C File Offset: 0x0060576C
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

	// Token: 0x06014B1C RID: 84764 RVA: 0x00607604 File Offset: 0x00605804
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueShopView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueShopView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B1D RID: 84765 RVA: 0x00607647 File Offset: 0x00605847
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandShop command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x06014B1E RID: 84766 RVA: 0x0060765A File Offset: 0x0060585A
	private SurvivorsRogueCardShopItem CreateCardItem()
	{
		return new SurvivorsRogueCardShopItem
		{
			OnPurchaseBtnClickCallback = new Action<GoodsDetail>(this.OnPurchase),
			OnClickLockCallback = new Action<GoodsDetail, bool>(this.OnLock),
			OnStateChangeCallback = new Action<GoodsDetail, bool>(this.OnStateChangeCallback)
		};
	}

	// Token: 0x06014B1F RID: 84767 RVA: 0x00607697 File Offset: 0x00605897
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

	// Token: 0x06014B20 RID: 84768 RVA: 0x006076D0 File Offset: 0x006058D0
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

	// Token: 0x06014B21 RID: 84769 RVA: 0x00607700 File Offset: 0x00605900
	private UniTask RefreshAsync()
	{
		SurvivorsRogueShopView.<RefreshAsync>d__25 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueShopView.<RefreshAsync>d__25>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B22 RID: 84770 RVA: 0x00607743 File Offset: 0x00605943
	private void RefreshCurrency(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshCurrency();
	}

	// Token: 0x06014B23 RID: 84771 RVA: 0x0060774C File Offset: 0x0060594C
	private void RefreshCurrency()
	{
		bool flag = SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount() >= this.RefreshCurrencyCount;
		UUIText text = base.GetText(6);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x06014B24 RID: 84772 RVA: 0x00607794 File Offset: 0x00605994
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

	// Token: 0x06014B25 RID: 84773 RVA: 0x00607887 File Offset: 0x00605A87
	private void RefreshRoleGain(int roleId)
	{
		SurvivorsRogueRoleInfoGrid roleGrid = this.BaseItem.RoleStatePanel.RoleGrid;
		if (roleGrid == null)
		{
			return;
		}
		roleGrid.SetLevelUp();
	}

	// Token: 0x06014B26 RID: 84774 RVA: 0x006078A3 File Offset: 0x00605AA3
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

	// Token: 0x06014B27 RID: 84775 RVA: 0x006078C4 File Offset: 0x00605AC4
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

	// Token: 0x0400B09F RID: 45215
	public int CommandIncId;

	// Token: 0x0400B0A0 RID: 45216
	public SurvivorsRogueCommandShop Command;

	// Token: 0x0400B0A1 RID: 45217
	[Nullable(2)]
	private SurvivorsRogueViewBase BaseItem;

	// Token: 0x0400B0A2 RID: 45218
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueCardShopItem, GoodsDetail> CardList;

	// Token: 0x0400B0A3 RID: 45219
	private bool RefreshDirty = true;

	// Token: 0x0400B0A4 RID: 45220
	[Nullable(2)]
	private GoodsDetail CurrentSelectGoodsInfo;

	// Token: 0x0400B0A5 RID: 45221
	private int RefreshCurrencyCount;
}
