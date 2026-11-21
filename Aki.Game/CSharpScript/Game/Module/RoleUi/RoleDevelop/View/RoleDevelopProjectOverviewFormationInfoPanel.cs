using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D07 RID: 15623
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectOverviewFormationInfoPanel : RoleDevelopProjectOverviewBaseInfoPanel
	{
		// Token: 0x06027FD4 RID: 163796 RVA: 0x00B30858 File Offset: 0x00B2EA58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027FD5 RID: 163797 RVA: 0x00B30A10 File Offset: 0x00B2EC10
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectOverviewFormationInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectOverviewFormationInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FD6 RID: 163798 RVA: 0x00B30A54 File Offset: 0x00B2EC54
		private RoleDevelopProjectOverviewFormationItem CreateFormationItem(int slot, List<UniTask> promiseList)
		{
			RoleDevelopProjectOverviewFormationItem roleDevelopProjectOverviewFormationItem = new RoleDevelopProjectOverviewFormationItem();
			promiseList.Add(roleDevelopProjectOverviewFormationItem.CreateThenShowByActorAsync(base.GetItem(slot).GetOwner(), null, false));
			return roleDevelopProjectOverviewFormationItem;
		}

		// Token: 0x06027FD7 RID: 163799 RVA: 0x00B30A84 File Offset: 0x00B2EC84
		protected override void OnRefreshPanel(bool forceRefresh)
		{
			List<RoleDevelopTeamRecommendInfo> teamRecommendData = RoleDevelopModel.Instance.GetTeamRecommendData(this.Data.GetId());
			RoleDevelopTeamRecommendInfo roleDevelopTeamRecommendInfo = (teamRecommendData != null && teamRecommendData.Count > 0) ? teamRecommendData[0] : null;
			base.GetItem(9).SetUIActive(roleDevelopTeamRecommendInfo != null);
			base.GetItem(10).SetUIActive(roleDevelopTeamRecommendInfo == null);
			if (roleDevelopTeamRecommendInfo == null)
			{
				return;
			}
			this.FirstRoleItem.Refresh(this.Data.GetId(), false);
			this.RefreshTeammate(0, this.SecondRoleItem, 2, this.SecondBackupItems, roleDevelopTeamRecommendInfo);
			this.RefreshTeammate(1, this.ThirdRoleItem, 6, this.ThirdBackupItems, roleDevelopTeamRecommendInfo);
		}

		// Token: 0x06027FD8 RID: 163800 RVA: 0x00B30B28 File Offset: 0x00B2ED28
		private void RefreshTeammate(int teammateIndex, RoleDevelopProjectOverviewFormationItem mainItem, int backupPanelSlot, List<RoleDevelopProjectOverviewFormationItem> backupItems, RoleDevelopTeamRecommendInfo teamInfo)
		{
			RoleDevelopTeamRecommendTeammate roleDevelopTeamRecommendTeammate = (teammateIndex < teamInfo.Teammates.Count) ? teamInfo.Teammates[teammateIndex] : null;
			int? num;
			if (roleDevelopTeamRecommendTeammate == null)
			{
				num = null;
			}
			else
			{
				RoleDevelopTeamRecommendRoleInfo main = roleDevelopTeamRecommendTeammate.Main;
				num = ((main != null) ? new int?(main.RoleId) : null);
			}
			int? num2 = num;
			mainItem.Refresh(num2.GetValueOrDefault(), false);
			List<RoleDevelopTeamRecommendRoleInfo> list = (roleDevelopTeamRecommendTeammate != null) ? roleDevelopTeamRecommendTeammate.Spares : null;
			int num3 = (list != null) ? list.Count : 0;
			base.GetItem(backupPanelSlot).SetUIActive(num3 > 0);
			for (int i = 0; i < backupItems.Count; i++)
			{
				backupItems[i].Refresh((i < num3) ? list[i].RoleId : 0, true);
			}
		}

		// Token: 0x04015C64 RID: 89188
		private RoleDevelopProjectOverviewFormationItem FirstRoleItem;

		// Token: 0x04015C65 RID: 89189
		private RoleDevelopProjectOverviewFormationItem SecondRoleItem;

		// Token: 0x04015C66 RID: 89190
		private RoleDevelopProjectOverviewFormationItem ThirdRoleItem;

		// Token: 0x04015C67 RID: 89191
		private readonly List<RoleDevelopProjectOverviewFormationItem> SecondBackupItems = new List<RoleDevelopProjectOverviewFormationItem>();

		// Token: 0x04015C68 RID: 89192
		private readonly List<RoleDevelopProjectOverviewFormationItem> ThirdBackupItems = new List<RoleDevelopProjectOverviewFormationItem>();

		// Token: 0x020098CF RID: 39119
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FA6C RID: 195180
			FirstPositionItem,
			// Token: 0x0402FA6D RID: 195181
			SecondPositionItem,
			// Token: 0x0402FA6E RID: 195182
			SecondPositionBackupPanel,
			// Token: 0x0402FA6F RID: 195183
			SecondPositionBackupItem1,
			// Token: 0x0402FA70 RID: 195184
			SecondPositionBackupItem2,
			// Token: 0x0402FA71 RID: 195185
			ThirdPositionItem,
			// Token: 0x0402FA72 RID: 195186
			ThirdPositionBackupPanel,
			// Token: 0x0402FA73 RID: 195187
			ThirdPositionBackupItem1,
			// Token: 0x0402FA74 RID: 195188
			ThirdPositionBackupItem2,
			// Token: 0x0402FA75 RID: 195189
			RecommendPanel,
			// Token: 0x0402FA76 RID: 195190
			EmptyPanel,
			// Token: 0x0402FA77 RID: 195191
			JumpButton
		}
	}
}
