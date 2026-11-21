using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008EA RID: 2282
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressAdventureView : ActivityRegressMainSubViewBase
{
	// Token: 0x060065C1 RID: 26049 RVA: 0x001FC6B8 File Offset: 0x001FA8B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x060065C2 RID: 26050 RVA: 0x001FC76C File Offset: 0x001FA96C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressAdventureView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressAdventureView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060065C3 RID: 26051 RVA: 0x001FC7A8 File Offset: 0x001FA9A8
	protected override void OnStart()
	{
		base.OnStart();
		this.RoleLayout = new GenericLayout<ActivityRegressAdventureRoleItem, int>(base.GetHorizontalLayout(0), new Func<ActivityRegressAdventureRoleItem>(this.InitRoleItem), null, false, true);
		this.AdventureLayout = new GenericLayout<ActivityRegressAdventureAdventureItem, int>(base.GetVerticalLayout(2), new Func<ActivityRegressAdventureAdventureItem>(this.InitAdventureItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.AdventureLayout2 = new GenericLayout<ActivityRegressAdventureAdventureItem, int>(base.GetVerticalLayout(4), new Func<ActivityRegressAdventureAdventureItem>(this.InitAdventureItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.RefreshRolePanelState();
	}

	// Token: 0x060065C4 RID: 26052 RVA: 0x001FC844 File Offset: 0x001FAA44
	private void RefreshRolePanelState()
	{
		List<int> roleList = ActivityRegressModel.Instance.GetGachaPoolUpRole();
		bool flag = roleList.Count > 0;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		if (!flag)
		{
			this.CurrentSelectRoleId = 0;
			this.CurrentSelectToggle = null;
			GenericLayout<ActivityRegressAdventureAdventureItem, int> adventureLayout = this.AdventureLayout;
			if (adventureLayout != null)
			{
				adventureLayout.RefreshByData(new List<int>(), null, true);
			}
			GenericLayout<ActivityRegressAdventureAdventureItem, int> adventureLayout2 = this.AdventureLayout2;
			if (adventureLayout2 == null)
			{
				return;
			}
			adventureLayout2.RefreshByData(new List<int>(), null, true);
			return;
		}
		else
		{
			GenericLayout<ActivityRegressAdventureRoleItem, int> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshByData(roleList, delegate
			{
				int num = (this.CurrentSelectRoleId != 0) ? roleList.IndexOf(this.CurrentSelectRoleId) : 0;
				GenericLayout<ActivityRegressAdventureRoleItem, int> roleLayout2 = this.RoleLayout;
				if (roleLayout2 == null)
				{
					return;
				}
				ActivityRegressAdventureRoleItem layoutItemByIndex = roleLayout2.GetLayoutItemByIndex((num >= 0) ? num : 0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SelectToggle();
			}, false);
			return;
		}
	}

	// Token: 0x060065C5 RID: 26053 RVA: 0x001FC8FE File Offset: 0x001FAAFE
	private ActivityRegressAdventureRoleItem InitRoleItem()
	{
		return new ActivityRegressAdventureRoleItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickRoleToggleCallBack)
		};
	}

	// Token: 0x060065C6 RID: 26054 RVA: 0x001FC917 File Offset: 0x001FAB17
	private ActivityRegressAdventureAdventureItem InitAdventureItem()
	{
		return new ActivityRegressAdventureAdventureItem
		{
			OnClickJumpToCallBack = new Action(this.RefreshRolePanelState)
		};
	}

	// Token: 0x060065C7 RID: 26055 RVA: 0x001FC930 File Offset: 0x001FAB30
	private void OnClickRoleToggleCallBack(int roleId, UUIExtendToggle toggle)
	{
		this.RefreshRolePanelState();
		if (this.CurrentSelectRoleId == roleId)
		{
			return;
		}
		this.CurrentSelectRoleId = roleId;
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		IReadOnlyList<GachaRoleDevelopIns> gachaRoleDevelopInsByRoleId = ActivityRegressConfig.Instance.GetGachaRoleDevelopInsByRoleId(roleId);
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (gachaRoleDevelopInsByRoleId != null)
		{
			for (int i = 0; i < gachaRoleDevelopInsByRoleId.Count; i++)
			{
				GachaRoleDevelopIns gachaRoleDevelopIns = gachaRoleDevelopInsByRoleId[i];
				if (gachaRoleDevelopIns.Type == 1)
				{
					list.Add(gachaRoleDevelopIns.Id);
				}
				if (gachaRoleDevelopIns.Type == 2)
				{
					list2.Add(gachaRoleDevelopIns.Id);
				}
			}
		}
		GenericLayout<ActivityRegressAdventureAdventureItem, int> adventureLayout = this.AdventureLayout;
		if (adventureLayout != null)
		{
			adventureLayout.RefreshByData(list, null, true);
		}
		GenericLayout<ActivityRegressAdventureAdventureItem, int> adventureLayout2 = this.AdventureLayout2;
		if (adventureLayout2 == null)
		{
			return;
		}
		adventureLayout2.RefreshByData(list2, null, true);
	}

	// Token: 0x04004143 RID: 16707
	private int CurrentSelectRoleId;

	// Token: 0x04004144 RID: 16708
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04004145 RID: 16709
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRegressAdventureRoleItem, int> RoleLayout;

	// Token: 0x04004146 RID: 16710
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRegressAdventureAdventureItem, int> AdventureLayout;

	// Token: 0x04004147 RID: 16711
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRegressAdventureAdventureItem, int> AdventureLayout2;

	// Token: 0x02006BEA RID: 27626
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402378B RID: 145291
		public const int RoleLayout = 0;

		// Token: 0x0402378C RID: 145292
		public const int RoleItem = 1;

		// Token: 0x0402378D RID: 145293
		public const int AdventureItemLayout = 2;

		// Token: 0x0402378E RID: 145294
		public const int AdventureItem = 3;

		// Token: 0x0402378F RID: 145295
		public const int AdventureItemLayout2 = 4;

		// Token: 0x04023790 RID: 145296
		public const int RoleLayoutItem = 5;

		// Token: 0x04023791 RID: 145297
		public const int LockTipsItem = 6;
	}
}
