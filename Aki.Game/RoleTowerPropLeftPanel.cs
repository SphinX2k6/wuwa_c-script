using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF0 RID: 7408
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerPropLeftPanel : UiPanelBase
{
	// Token: 0x06012560 RID: 75104 RVA: 0x00568D84 File Offset: 0x00566F84
	[NullableContext(1)]
	public void SetCallbacks(Action<ERoleTowerStarEchoTab> onSwitchTab, Action<int> onSwitchRole)
	{
		this.OnSwitchTab = onSwitchTab;
		this.OnSwitchRole = onSwitchRole;
	}

	// Token: 0x06012561 RID: 75105 RVA: 0x00568D94 File Offset: 0x00566F94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleTabStar)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleTabEcho))
		};
	}

	// Token: 0x06012562 RID: 75106 RVA: 0x00568E6C File Offset: 0x0056706C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerPropLeftPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerPropLeftPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012563 RID: 75107 RVA: 0x00568EAF File Offset: 0x005670AF
	protected override void OnStart()
	{
		this.AvatarLayout = new GenericLayout<RoleTowerPropAvatarItem, RoleTowerPropAvatarData>(base.GetVerticalLayout(2), new Func<RoleTowerPropAvatarItem>(this.CreateAvatarItem), null, false, true);
	}

	// Token: 0x06012564 RID: 75108 RVA: 0x00568ED4 File Offset: 0x005670D4
	public void Refresh(ERoleTowerStarEchoTab tab, int roleId)
	{
		this.CurTab = tab;
		this.CurRoleId = roleId;
		bool flag = tab == ERoleTowerStarEchoTab.Star;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
		if (extendToggle2 != null)
		{
			extendToggle2.SetToggleStateForce(flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		this.RefreshAvatarList();
		if (flag)
		{
			this.RefreshTeamProperty();
			return;
		}
		this.RefreshVisionProperty();
	}

	// Token: 0x06012565 RID: 75109 RVA: 0x00568F6B File Offset: 0x0056716B
	[NullableContext(1)]
	[return: TupleElementNames(new string[]
	{
		"Desc",
		"DescParams"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private static ValueTuple<string, string[]> PickDesc([Nullable(2)] string brief, [Nullable(2)] string detail, string[] briefParams, string[] detailParams)
	{
		if (!RoleTowerModel.Instance.IsShowBriefDesc && !string.IsNullOrEmpty(detail))
		{
			return new ValueTuple<string, string[]>(detail, detailParams);
		}
		return new ValueTuple<string, string[]>(brief ?? string.Empty, briefParams);
	}

	// Token: 0x06012566 RID: 75110 RVA: 0x00568F99 File Offset: 0x00567199
	[NullableContext(1)]
	private RoleTowerPropAvatarItem CreateAvatarItem()
	{
		RoleTowerPropAvatarItem roleTowerPropAvatarItem = new RoleTowerPropAvatarItem();
		roleTowerPropAvatarItem.SetClickCallback(delegate(int roleId)
		{
			Action<int> onSwitchRole = this.OnSwitchRole;
			if (onSwitchRole == null)
			{
				return;
			}
			onSwitchRole(roleId);
		});
		return roleTowerPropAvatarItem;
	}

	// Token: 0x06012567 RID: 75111 RVA: 0x00568FB4 File Offset: 0x005671B4
	private void RefreshAvatarList()
	{
		List<RoleTowerPropAvatarData> list = new List<RoleTowerPropAvatarData>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				list.Add(new RoleTowerPropAvatarData
				{
					RoleId = slotRoleId,
					Slot = slot,
					IsTrial = RoleTowerModel.Instance.GetSlotIsTrial(slot),
					IsSelected = (slotRoleId == this.CurRoleId)
				});
			}
		}
		GenericLayout<RoleTowerPropAvatarItem, RoleTowerPropAvatarData> avatarLayout = this.AvatarLayout;
		if (avatarLayout == null)
		{
			return;
		}
		avatarLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06012568 RID: 75112 RVA: 0x00569048 File Offset: 0x00567248
	private void RefreshTeamProperty()
	{
		int curTeamStar = RoleTowerModel.Instance.GetCurTeamStar();
		IReadOnlyList<RoleTowerStar> starCfgListByRole = RoleTowerModel.Instance.GetStarCfgListByRole(this.CurRoleId);
		List<RoleTowerPropBuffData> list = new List<RoleTowerPropBuffData>();
		foreach (RoleTowerStar roleTowerStar in starCfgListByRole)
		{
			if (roleTowerStar.StarIndex > 0)
			{
				ValueTuple<string, string[]> valueTuple = RoleTowerPropLeftPanel.PickDesc(roleTowerStar.Desc, roleTowerStar.DetailDesc, roleTowerStar.DescParam(), roleTowerStar.DetailDescParam());
				string item = valueTuple.Item1;
				string[] item2 = valueTuple.Item2;
				list.Add(new RoleTowerPropBuffData
				{
					Title = roleTowerStar.Name,
					Desc = item,
					DescParams = item2,
					IsActive = (roleTowerStar.StarIndex <= curTeamStar)
				});
			}
		}
		RoleTowerPropTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel == null)
		{
			return;
		}
		teamPanel.Refresh(curTeamStar, starCfgListByRole.Count, list);
	}

	// Token: 0x06012569 RID: 75113 RVA: 0x0056913C File Offset: 0x0056733C
	private void RefreshVisionProperty()
	{
		int curEchoLevel = RoleTowerModel.Instance.GetCurEchoLevel();
		int curEchoExp = RoleTowerModel.Instance.GetCurEchoExp();
		IEnumerable<RoleTowerEchoLevel> echoLevelCfgList = RoleTowerModel.Instance.GetEchoLevelCfgList();
		List<RoleTowerPropBuffData> list = new List<RoleTowerPropBuffData>();
		int needExp = 0;
		foreach (RoleTowerEchoLevel roleTowerEchoLevel in echoLevelCfgList)
		{
			ValueTuple<string, string[]> valueTuple = RoleTowerPropLeftPanel.PickDesc(roleTowerEchoLevel.Desc, roleTowerEchoLevel.DetailDesc, roleTowerEchoLevel.DescParam(), Array.Empty<string>());
			string item = valueTuple.Item1;
			string[] item2 = valueTuple.Item2;
			list.Add(new RoleTowerPropBuffData
			{
				Title = roleTowerEchoLevel.Name,
				Desc = item,
				DescParams = item2,
				IsActive = (roleTowerEchoLevel.LevelIndex <= curEchoLevel)
			});
			if (roleTowerEchoLevel.LevelIndex == curEchoLevel)
			{
				needExp = roleTowerEchoLevel.Exp;
			}
		}
		RoleTowerPropVisionPanel visionPanel = this.VisionPanel;
		if (visionPanel == null)
		{
			return;
		}
		visionPanel.Refresh(curEchoLevel, curEchoExp, needExp, list);
	}

	// Token: 0x0601256A RID: 75114 RVA: 0x00569240 File Offset: 0x00567440
	private void OnToggleTabStar(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<ERoleTowerStarEchoTab> onSwitchTab = this.OnSwitchTab;
			if (onSwitchTab == null)
			{
				return;
			}
			onSwitchTab(ERoleTowerStarEchoTab.Star);
		}
	}

	// Token: 0x0601256B RID: 75115 RVA: 0x00569257 File Offset: 0x00567457
	private void OnToggleTabEcho(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<ERoleTowerStarEchoTab> onSwitchTab = this.OnSwitchTab;
			if (onSwitchTab == null)
			{
				return;
			}
			onSwitchTab(ERoleTowerStarEchoTab.Echo);
		}
	}

	// Token: 0x04009FE5 RID: 40933
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerPropAvatarItem, RoleTowerPropAvatarData> AvatarLayout;

	// Token: 0x04009FE6 RID: 40934
	private RoleTowerPropVisionPanel VisionPanel;

	// Token: 0x04009FE7 RID: 40935
	private RoleTowerPropTeamPanel TeamPanel;

	// Token: 0x04009FE8 RID: 40936
	private Action<ERoleTowerStarEchoTab> OnSwitchTab;

	// Token: 0x04009FE9 RID: 40937
	private Action<int> OnSwitchRole;

	// Token: 0x04009FEA RID: 40938
	private ERoleTowerStarEchoTab CurTab;

	// Token: 0x04009FEB RID: 40939
	private int CurRoleId;

	// Token: 0x02007FFD RID: 32765
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402967C RID: 169596
		public const int TogTopTabItemA = 0;

		// Token: 0x0402967D RID: 169597
		public const int TogTopTabItemB = 1;

		// Token: 0x0402967E RID: 169598
		public const int PnlRoleAvatar = 2;

		// Token: 0x0402967F RID: 169599
		public const int TogAvatar = 3;

		// Token: 0x04029680 RID: 169600
		public const int PnlVisionProperty = 4;

		// Token: 0x04029681 RID: 169601
		public const int PnlTeamProperty = 5;
	}
}
