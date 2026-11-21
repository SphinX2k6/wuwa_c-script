using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F24 RID: 7972
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerDescTeamItem : GridProxyAbstract<ShipTowerTeamData>
{
	// Token: 0x06013BC4 RID: 80836 RVA: 0x005C20FC File Offset: 0x005C02FC
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

	// Token: 0x06013BC5 RID: 80837 RVA: 0x005C22E8 File Offset: 0x005C04E8
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescTeamItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescTeamItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BC6 RID: 80838 RVA: 0x005C232B File Offset: 0x005C052B
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06013BC7 RID: 80839 RVA: 0x005C232D File Offset: 0x005C052D
	protected override void OnStart()
	{
	}

	// Token: 0x06013BC8 RID: 80840 RVA: 0x005C232F File Offset: 0x005C052F
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06013BC9 RID: 80841 RVA: 0x005C2331 File Offset: 0x005C0531
	public override void Refresh(ShipTowerTeamData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013BCA RID: 80842 RVA: 0x005C233C File Offset: 0x005C053C
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

	// Token: 0x06013BCB RID: 80843 RVA: 0x005C24E7 File Offset: 0x005C06E7
	private void OnClickMechanismDetail()
	{
		Action<ShipTowerTeamData> mechanismClickCallBack = this.MechanismClickCallBack;
		if (mechanismClickCallBack == null)
		{
			return;
		}
		mechanismClickCallBack(this.ItemData);
	}

	// Token: 0x06013BCC RID: 80844 RVA: 0x005C24FF File Offset: 0x005C06FF
	private void OnClickTeamRoot(EToggleState toggleState)
	{
		Action<ShipTowerTeamData> roleClickCallBack = this.RoleClickCallBack;
		if (roleClickCallBack == null)
		{
			return;
		}
		roleClickCallBack(this.ItemData);
	}

	// Token: 0x06013BCD RID: 80845 RVA: 0x005C2518 File Offset: 0x005C0718
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

	// Token: 0x06013BCE RID: 80846 RVA: 0x005C2544 File Offset: 0x005C0744
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

	// Token: 0x06013BCF RID: 80847 RVA: 0x005C25B2 File Offset: 0x005C07B2
	public void UpdateRoleList()
	{
		this.RoleLayout.RefreshByData(this.ItemData.GetUseRoleList(), null, false);
	}

	// Token: 0x06013BD0 RID: 80848 RVA: 0x005C25CC File Offset: 0x005C07CC
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

	// Token: 0x06013BD1 RID: 80849 RVA: 0x005C2630 File Offset: 0x005C0830
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

	// Token: 0x06013BD2 RID: 80850 RVA: 0x005C2655 File Offset: 0x005C0855
	private ShipTowerRoleItem CreateRoleItem()
	{
		return new ShipTowerRoleItem();
	}

	// Token: 0x06013BD3 RID: 80851 RVA: 0x005C265C File Offset: 0x005C085C
	private ShipTowerWordItem CreateWordItem()
	{
		return new ShipTowerWordItem();
	}

	// Token: 0x06013BD4 RID: 80852 RVA: 0x005C2664 File Offset: 0x005C0864
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

	// Token: 0x0400A8B1 RID: 43185
	[Nullable(2)]
	private ShipTowerTeamData ItemData;

	// Token: 0x0400A8B2 RID: 43186
	private GenericLayout<ShipTowerRoleItem, ShipTowerRoleData> RoleLayout;

	// Token: 0x0400A8B3 RID: 43187
	private GenericLayout<ShipTowerWordItem, ShipTowerWordItemData> WordLayout;

	// Token: 0x0400A8B4 RID: 43188
	private SmallItemGrid BuffItem;

	// Token: 0x0400A8B5 RID: 43189
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> RoleClickCallBack;

	// Token: 0x0400A8B6 RID: 43190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> BuffClickCallBack;

	// Token: 0x0400A8B7 RID: 43191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamData> MechanismClickCallBack;

	// Token: 0x02008203 RID: 33283
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029FC4 RID: 171972
		public const int TxtTitle = 0;

		// Token: 0x04029FC5 RID: 171973
		public const int TxtScore = 1;

		// Token: 0x04029FC6 RID: 171974
		public const int TxtWord = 2;

		// Token: 0x04029FC7 RID: 171975
		public const int TxtMechanismTitle = 3;

		// Token: 0x04029FC8 RID: 171976
		public const int BtnMechanismDetail = 4;

		// Token: 0x04029FC9 RID: 171977
		public const int VLayoutMechanismList = 5;

		// Token: 0x04029FCA RID: 171978
		public const int SpriteTeamBg = 6;

		// Token: 0x04029FCB RID: 171979
		public const int SpriteTeamSelect = 7;

		// Token: 0x04029FCC RID: 171980
		public const int TextureTeamIndex = 8;

		// Token: 0x04029FCD RID: 171981
		public const int TxtTeamRecommendLv = 9;

		// Token: 0x04029FCE RID: 171982
		public const int HLayoutRoleList = 10;

		// Token: 0x04029FCF RID: 171983
		public const int ItemBuff = 11;

		// Token: 0x04029FD0 RID: 171984
		public const int ToggleTeamRoot = 12;

		// Token: 0x04029FD1 RID: 171985
		public const int TxtMechanismDesc = 13;

		// Token: 0x04029FD2 RID: 171986
		public const int MLayout = 14;

		// Token: 0x04029FD3 RID: 171987
		public const int ItemWord = 15;

		// Token: 0x04029FD4 RID: 171988
		public const int TxtTeamName = 16;

		// Token: 0x04029FD5 RID: 171989
		public const int QuickPassItem = 17;
	}
}
