using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A9 RID: 10665
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerDescTeamItem : GridProxyAbstract<ShipTowerTeamData>
{
	// Token: 0x060161BE RID: 90558 RVA: 0x0059713C File Offset: 0x0059533C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(14, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickMechanismDetail)),
			new ValueTuple<int, Delegate>(12, new Action<EToggleState>(this.OnClickTeamRoot))
		};
	}

	// Token: 0x060161BF RID: 90559 RVA: 0x00597328 File Offset: 0x00595528
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescTeamItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescTeamItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060161C0 RID: 90560 RVA: 0x0059736B File Offset: 0x0059556B
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x060161C1 RID: 90561 RVA: 0x0059736D File Offset: 0x0059556D
	protected override void OnStart()
	{
	}

	// Token: 0x060161C2 RID: 90562 RVA: 0x0059736F File Offset: 0x0059556F
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060161C3 RID: 90563 RVA: 0x00597371 File Offset: 0x00595571
	public override void Refresh(ShipTowerTeamData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x060161C4 RID: 90564 RVA: 0x0059737C File Offset: 0x0059557C
	public void Refresh(ShipTowerTeamData data)
	{
		this.ItemData = data;
		InstanceDungeon? instanceDungeonCfg = data.GetInstanceDungeonCfg(null);
		SlashTowerStageInfo? shipTowerStageCfg = data.GetShipTowerStageCfg();
		int recommendLevelByInstId = ShipTowerModel.Instance.GetRecommendLevelByInstId(data.InstId);
		base.GetText(0).ShowTextNew(data.TeamInstName);
		base.GetText(16).ShowTextNew(data.TeamName);
		base.GetText(1).SetText(data.CurrentScore.ToString(), true);
		List<int> list;
		if (shipTowerStageCfg == null)
		{
			list = new List<int>();
		}
		else
		{
			list = new List<int>();
			for (int i = 0; i < shipTowerStageCfg.Value.BuffIdLength; i++)
			{
				list.Add(shipTowerStageCfg.Value.BuffId(i));
			}
		}
		this.UpdateWords(list);
		base.GetText(3).ShowTextNew("GhostShipMonster_Text1");
		base.GetText(13).ShowTextNew(((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().DungeonDesc : null) ?? "");
		base.SetTextureByPath(((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().DifficultyIcon : null) ?? "", base.GetTexture(8), null, null);
		UUIText text = base.GetText(9);
		LguiUtil.Instance.SetLocalTextNew(text, "GhostShipTeamRecommendLv_Text", new <>z__ReadOnlySingleElementList<object>(recommendLevelByInstId));
		int stageId = data.StageId;
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(stageId);
		base.GetItem(17).SetUIActive(stageDataById.IsQuickPass);
		this.UpdateRoleList();
		this.UpdateBuff();
	}

	// Token: 0x060161C5 RID: 90565 RVA: 0x00597527 File Offset: 0x00595727
	private void OnClickMechanismDetail()
	{
		Action<ShipTowerTeamData> mechanismClickCallBack = this.MechanismClickCallBack;
		if (mechanismClickCallBack == null)
		{
			return;
		}
		mechanismClickCallBack(this.ItemData);
	}

	// Token: 0x060161C6 RID: 90566 RVA: 0x0059753F File Offset: 0x0059573F
	private void OnClickTeamRoot(EToggleState toggleState)
	{
		Action<ShipTowerTeamData> roleClickCallBack = this.RoleClickCallBack;
		if (roleClickCallBack == null)
		{
			return;
		}
		roleClickCallBack(this.ItemData);
	}

	// Token: 0x060161C7 RID: 90567 RVA: 0x00597558 File Offset: 0x00595758
	public void SetTeamToggleIsSelect(bool isSelect)
	{
		EToggleState state = isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(12);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x060161C8 RID: 90568 RVA: 0x00597584 File Offset: 0x00595784
	private void UpdateWords(List<int> buffIdList)
	{
		string text = "GhostShipMonster_Text2";
		string text2 = TextConfig.Instance.GetMultiTextByKey(text, text);
		if (buffIdList.Count == 0)
		{
			string text3 = "GhostShipMonsterNull_Text";
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(text3, text3);
			text2 = text2 + "  " + multiTextByKey;
		}
		base.GetText(2).SetText(text2, true);
		this.WordLayout.RefreshByData(this.ItemData.GetWordInfoList(), null, false);
	}

	// Token: 0x060161C9 RID: 90569 RVA: 0x005975F2 File Offset: 0x005957F2
	public void UpdateRoleList()
	{
		this.RoleLayout.RefreshByData(this.ItemData.GetUseRoleList(), null, false);
	}

	// Token: 0x060161CA RID: 90570 RVA: 0x0059760C File Offset: 0x0059580C
	public void UpdateBuff()
	{
		ShipTowerBuffData buffDataEdit = this.ItemData.BuffDataEdit;
		int num = (buffDataEdit != null) ? buffDataEdit.ItemId : 0;
		if (num > 0)
		{
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = this.ItemData,
				ItemConfigId = new int?(num)
			};
			this.BuffItem.Apply<PropSmallItemGrid>(parameters);
			return;
		}
		this.BuffItem.Apply<EmptySmallItemGrid>(new EmptySmallItemGrid());
	}

	// Token: 0x060161CB RID: 90571 RVA: 0x00597670 File Offset: 0x00595870
	[NullableContext(2)]
	private void OnClickBuff(MediumItemGridExtendCallback _)
	{
		this.BuffItem.SetSelected(false, true);
		Action<ShipTowerTeamData> buffClickCallBack = this.BuffClickCallBack;
		if (buffClickCallBack == null)
		{
			return;
		}
		buffClickCallBack(this.ItemData);
	}

	// Token: 0x060161CC RID: 90572 RVA: 0x00597695 File Offset: 0x00595895
	private ShipTowerRoleItem CreateRoleItem()
	{
		return new ShipTowerRoleItem();
	}

	// Token: 0x060161CD RID: 90573 RVA: 0x0059769C File Offset: 0x0059589C
	private ShipTowerWordItem CreateWordItem()
	{
		return new ShipTowerWordItem();
	}

	// Token: 0x060161CE RID: 90574 RVA: 0x005976A4 File Offset: 0x005958A4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		string a = configParams[0];
		UUIItem uuiitem = null;
		if (!(a == "Desc"))
		{
			if (!(a == "Item"))
			{
				if (!(a == "TeamAndItem"))
				{
					if (a == "TeamAndItemOuter")
					{
						UUIExtendToggle extendToggle = base.GetExtendToggle(12);
						uuiitem = ((extendToggle != null) ? extendToggle.GetRootComponent() : null);
					}
				}
				else
				{
					uuiitem = base.GetGuideUiItem("1");
				}
			}
			else
			{
				uuiitem = this.BuffItem.GetRootItem();
			}
		}
		else
		{
			UUIText text = base.GetText(13);
			uuiitem = ((text != null) ? text.GetParentAsUIItem() : null);
		}
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0400A4C7 RID: 42183
	[Nullable(2)]
	private ShipTowerTeamData ItemData;

	// Token: 0x0400A4C8 RID: 42184
	private GenericLayout<ShipTowerRoleItem, ShipTowerRoleData> RoleLayout;

	// Token: 0x0400A4C9 RID: 42185
	private GenericLayout<ShipTowerWordItem, ShipTowerWordItemData> WordLayout;

	// Token: 0x0400A4CA RID: 42186
	private SmallItemGrid BuffItem;

	// Token: 0x0400A4CB RID: 42187
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> RoleClickCallBack;

	// Token: 0x0400A4CC RID: 42188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> BuffClickCallBack;

	// Token: 0x0400A4CD RID: 42189
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> MechanismClickCallBack;

	// Token: 0x02008FBA RID: 36794
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E8C5 RID: 190661
		public const int TxtTitle = 0;

		// Token: 0x0402E8C6 RID: 190662
		public const int TxtScore = 1;

		// Token: 0x0402E8C7 RID: 190663
		public const int TxtWord = 2;

		// Token: 0x0402E8C8 RID: 190664
		public const int TxtMechanismTitle = 3;

		// Token: 0x0402E8C9 RID: 190665
		public const int BtnMechanismDetail = 4;

		// Token: 0x0402E8CA RID: 190666
		public const int VLayoutMechanismList = 5;

		// Token: 0x0402E8CB RID: 190667
		public const int SpriteTeamBg = 6;

		// Token: 0x0402E8CC RID: 190668
		public const int SpriteTeamSelect = 7;

		// Token: 0x0402E8CD RID: 190669
		public const int TextureTeamIndex = 8;

		// Token: 0x0402E8CE RID: 190670
		public const int TxtTeamRecommendLv = 9;

		// Token: 0x0402E8CF RID: 190671
		public const int HLayoutRoleList = 10;

		// Token: 0x0402E8D0 RID: 190672
		public const int ItemBuff = 11;

		// Token: 0x0402E8D1 RID: 190673
		public const int ToggleTeamRoot = 12;

		// Token: 0x0402E8D2 RID: 190674
		public const int TxtMechanismDesc = 13;

		// Token: 0x0402E8D3 RID: 190675
		public const int MLayout = 14;

		// Token: 0x0402E8D4 RID: 190676
		public const int ItemWord = 15;

		// Token: 0x0402E8D5 RID: 190677
		public const int TxtTeamName = 16;

		// Token: 0x0402E8D6 RID: 190678
		public const int QuickPassItem = 17;
	}
}
