using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050AA RID: 20650
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideBlessTabView : RoverlikeOutsideTabViewBase
	{
		// Token: 0x170064F2 RID: 25842
		// (get) Token: 0x06033AFE RID: 211710 RVA: 0x00E77C4B File Offset: 0x00E75E4B
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected override IReadOnlyList<ValueTuple<EOutsideSlot, Type>> Layout
		{
			[return: TupleElementNames(new string[]
			{
				"Slot",
				"Type"
			})]
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				return RoverlikeOutsideLayout.WithRole;
			}
		}

		// Token: 0x06033AFF RID: 211711 RVA: 0x00E77C54 File Offset: 0x00E75E54
		protected override UniTask CreateDetailCardAsync()
		{
			RoverlikeOutsideBlessTabView.<CreateDetailCardAsync>d__3 <CreateDetailCardAsync>d__;
			<CreateDetailCardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailCardAsync>d__.<>4__this = this;
			<CreateDetailCardAsync>d__.<>1__state = -1;
			<CreateDetailCardAsync>d__.<>t__builder.Start<RoverlikeOutsideBlessTabView.<CreateDetailCardAsync>d__3>(ref <CreateDetailCardAsync>d__);
			return <CreateDetailCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B00 RID: 211712 RVA: 0x00E77C97 File Offset: 0x00E75E97
		protected override void OnStart()
		{
			base.OnStart();
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.MarkBlessUnlockRedDotRead();
		}

		// Token: 0x06033B01 RID: 211713 RVA: 0x00E77CAF File Offset: 0x00E75EAF
		protected override void OnShowUiTabViewFromToggle()
		{
			base.OnShowUiTabViewFromToggle();
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.MarkBlessUnlockRedDotRead();
		}

		// Token: 0x06033B02 RID: 211714 RVA: 0x00E77CC7 File Offset: 0x00E75EC7
		protected override void OnBeforeDestroy()
		{
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData != null)
			{
				activityData.ClearNewUnlockedBlessIds();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06033B03 RID: 211715 RVA: 0x00E77CE0 File Offset: 0x00E75EE0
		[NullableContext(2)]
		protected override UUIItem GetDetailItemComponent()
		{
			return base.GetSlotItem(EOutsideSlot.ItemBlessDetail);
		}

		// Token: 0x06033B04 RID: 211716 RVA: 0x00E77CEC File Offset: 0x00E75EEC
		protected override void RefreshDetailCard(RoverlikeGainEntry entry)
		{
			RoverlikeBlessingItemData data = new RoverlikeBlessingItemData
			{
				BlessId = entry.ConfigId,
				AllowToggleInteract = new bool?(false)
			};
			RoverlikeBlessingCardItem detailCard = this.DetailCard;
			if (detailCard == null)
			{
				return;
			}
			detailCard.Refresh(data, false, 0);
		}

		// Token: 0x06033B05 RID: 211717 RVA: 0x00E77D2A File Offset: 0x00E75F2A
		protected override bool ShouldShowRoleList()
		{
			return true;
		}

		// Token: 0x06033B06 RID: 211718 RVA: 0x00E77D2D File Offset: 0x00E75F2D
		protected override void OnRoleSelected()
		{
			base.PlaySequence("Switch01");
		}

		// Token: 0x06033B07 RID: 211719 RVA: 0x00E77D3C File Offset: 0x00E75F3C
		protected override void OnRefreshRoleLockedDesc(string unlockDesc)
		{
			UUIText roleEmptyText = this.GetRoleEmptyText();
			if (roleEmptyText == null)
			{
				return;
			}
			if (StringUtils.IsEmpty(unlockDesc))
			{
				roleEmptyText.SetText("", true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(roleEmptyText, unlockDesc, Array.Empty<object>());
		}

		// Token: 0x06033B08 RID: 211720 RVA: 0x00E77D7A File Offset: 0x00E75F7A
		protected override bool ShouldShowToggle()
		{
			return true;
		}

		// Token: 0x06033B09 RID: 211721 RVA: 0x00E77D80 File Offset: 0x00E75F80
		protected override List<RoverlikeOutsideRoleData> BuildRoleDataList()
		{
			RoverlikeActivityData activityData = base.ActivityData;
			int num = (activityData != null) ? activityData.Id : 0;
			List<RoverRogueBlessRole> list = new List<RoverRogueBlessRole>(RoverlikeConfig.Instance.GetBlessRoleConfigList());
			list.Sort((RoverRogueBlessRole a, RoverRogueBlessRole b) => a.SortId - b.SortId);
			List<RoverlikeOutsideRoleData> list2 = new List<RoverlikeOutsideRoleData>();
			foreach (RoverRogueBlessRole roverRogueBlessRole in list)
			{
				if (num <= 0 || roverRogueBlessRole.ActivityId == num)
				{
					List<RoverlikeOutsideRoleData> list3 = list2;
					RoverlikeOutsideRoleData roverlikeOutsideRoleData = new RoverlikeOutsideRoleData();
					roverlikeOutsideRoleData.RoleId = roverRogueBlessRole.Id;
					roverlikeOutsideRoleData.IconPath = roverRogueBlessRole.RoleIcon;
					RoverlikeActivityData activityData2 = base.ActivityData;
					roverlikeOutsideRoleData.Unlocked = (activityData2 != null && activityData2.IsBlessRoleUnlocked(roverRogueBlessRole.Id));
					roverlikeOutsideRoleData.UnlockDesc = roverRogueBlessRole.UnlockDesc;
					roverlikeOutsideRoleData.HasRedDot = this.RoleHasNewUnlockedBless(roverRogueBlessRole.Id);
					list3.Add(roverlikeOutsideRoleData);
				}
			}
			return list2;
		}

		// Token: 0x06033B0A RID: 211722 RVA: 0x00E77E8C File Offset: 0x00E7608C
		private bool RoleHasNewUnlockedBless(int blessRoleId)
		{
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData == null)
			{
				return false;
			}
			foreach (int id in activityData.GetNewUnlockedBlessIds())
			{
				RoverRogueBless? roverRogueBless;
				if (RoverlikeConfig.Instance.GetBlessConfig(id) != null && roverRogueBless.GetValueOrDefault().BlessRoleId == blessRoleId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033B0B RID: 211723 RVA: 0x00E77F14 File Offset: 0x00E76114
		protected override bool IsRoleRedDotVisible(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return this.RoleHasNewUnlockedBless(data.RoleId);
		}

		// Token: 0x06033B0C RID: 211724 RVA: 0x00E77F24 File Offset: 0x00E76124
		protected override void OnRoleRedDotClear(int roleId)
		{
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData == null)
			{
				return;
			}
			foreach (int num in activityData.GetNewUnlockedBlessIds())
			{
				RoverRogueBless? roverRogueBless;
				if (RoverlikeConfig.Instance.GetBlessConfig(num) != null && roverRogueBless.GetValueOrDefault().BlessRoleId == roleId)
				{
					activityData.MarkBlessNewUnlockedRead(num);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			base.RefreshRoleGrids();
		}

		// Token: 0x06033B0D RID: 211725 RVA: 0x00E77FC8 File Offset: 0x00E761C8
		protected override int BuildScrollDataList()
		{
			int selectedRoleId = base.GetSelectedRoleId();
			bool flag = base.IsShowAllChecked();
			RoverlikeActivityData activityData = base.ActivityData;
			RoverRogueActivity? roverRogueActivity;
			HashSet<int> hashSet = new HashSet<int>(((activityData != null) ? ((activityData.GetParamConfig() != null) ? roverRogueActivity.GetValueOrDefault().SlotList() : null) : null) ?? new int[0]);
			List<RoverlikeGainEntry> list = new List<RoverlikeGainEntry>();
			List<RoverlikeGainEntry> list2 = new List<RoverlikeGainEntry>();
			foreach (RoverRogueBless roverRogueBless in RoverlikeConfig.Instance.GetBlessConfigList())
			{
				if ((selectedRoleId <= 0 || roverRogueBless.BlessRoleId == selectedRoleId) && (flag || roverRogueBless.Level == 1))
				{
					RoverlikeGainEntry item = RoverlikeGainEntry.Create(RoverRogueGainDataType.RoverRogueGainBless, roverRogueBless.Id);
					if (hashSet.Contains(roverRogueBless.SlotId))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
			this.SortGroup(list);
			this.SortGroup(list2);
			int num = -1;
			if (list.Count > 0)
			{
				base.PushTitle("RoverRogue_SystemShow_CoreBlessing");
				foreach (RoverlikeGainEntry entry in list)
				{
					int num2 = base.PushGrid(entry);
					if (num < 0)
					{
						num = num2;
					}
				}
			}
			if (list2.Count > 0)
			{
				base.PushTitle("RoverRogue_SystemShow_NormalBlessing");
				foreach (RoverlikeGainEntry entry2 in list2)
				{
					int num3 = base.PushGrid(entry2);
					if (num < 0)
					{
						num = num3;
					}
				}
			}
			return num;
		}

		// Token: 0x06033B0E RID: 211726 RVA: 0x00E78194 File Offset: 0x00E76394
		protected override bool IsEntryLocked(RoverlikeGainEntry entry)
		{
			RoverlikeActivityData activityData = base.ActivityData;
			return activityData == null || !activityData.IsBlessUnlocked(entry.ConfigId);
		}

		// Token: 0x06033B0F RID: 211727 RVA: 0x00E781B4 File Offset: 0x00E763B4
		[NullableContext(2)]
		private UUIText GetRoleEmptyText()
		{
			UUIItem slotItem = base.GetSlotItem(EOutsideSlot.PnlRoleEmpty);
			AActor aactor = (slotItem != null) ? slotItem.GetOwner() : null;
			if (aactor == null)
			{
				return null;
			}
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(aactor, UUIText.StaticClass(), true);
			if (componentsInChildren.Num() <= 0)
			{
				return null;
			}
			return componentsInChildren.Get(0) as UUIText;
		}

		// Token: 0x06033B10 RID: 211728 RVA: 0x00E78203 File Offset: 0x00E76403
		private void SortGroup(List<RoverlikeGainEntry> group)
		{
			group.Sort(delegate(RoverlikeGainEntry a, RoverlikeGainEntry b)
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(a.ConfigId);
				int num = (blessConfig != null) ? blessConfig.GetValueOrDefault().Quality : 0;
				blessConfig = RoverlikeConfig.Instance.GetBlessConfig(b.ConfigId);
				int num2 = (blessConfig != null) ? blessConfig.GetValueOrDefault().Quality : 0;
				if (num != num2)
				{
					return num2 - num;
				}
				return a.ConfigId - b.ConfigId;
			});
		}

		// Token: 0x0401B683 RID: 112259
		[Nullable(2)]
		private RoverlikeBlessingCardItem DetailCard;
	}
}
