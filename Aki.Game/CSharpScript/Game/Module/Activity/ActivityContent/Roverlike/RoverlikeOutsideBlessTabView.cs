using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200612C RID: 24876
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideBlessTabView : RoverlikeOutsideTabViewBase
	{
		// Token: 0x17009190 RID: 37264
		// (get) Token: 0x0603EE3C RID: 257596 RVA: 0x00F30E37 File Offset: 0x00F2F037
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

		// Token: 0x0603EE3D RID: 257597 RVA: 0x00F30E40 File Offset: 0x00F2F040
		protected override UniTask CreateDetailCardAsync()
		{
			RoverlikeOutsideBlessTabView.<CreateDetailCardAsync>d__3 <CreateDetailCardAsync>d__;
			<CreateDetailCardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailCardAsync>d__.<>4__this = this;
			<CreateDetailCardAsync>d__.<>1__state = -1;
			<CreateDetailCardAsync>d__.<>t__builder.Start<RoverlikeOutsideBlessTabView.<CreateDetailCardAsync>d__3>(ref <CreateDetailCardAsync>d__);
			return <CreateDetailCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE3E RID: 257598 RVA: 0x00F30E83 File Offset: 0x00F2F083
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

		// Token: 0x0603EE3F RID: 257599 RVA: 0x00F30E9B File Offset: 0x00F2F09B
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

		// Token: 0x0603EE40 RID: 257600 RVA: 0x00F30EB3 File Offset: 0x00F2F0B3
		protected override void OnBeforeDestroy()
		{
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData != null)
			{
				activityData.ClearNewUnlockedBlessIds();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603EE41 RID: 257601 RVA: 0x00F30ECC File Offset: 0x00F2F0CC
		[NullableContext(2)]
		protected override UUIItem GetDetailItemComponent()
		{
			return base.GetSlotItem(EOutsideSlot.ItemBlessDetail);
		}

		// Token: 0x0603EE42 RID: 257602 RVA: 0x00F30ED8 File Offset: 0x00F2F0D8
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

		// Token: 0x0603EE43 RID: 257603 RVA: 0x00F30F16 File Offset: 0x00F2F116
		protected override bool ShouldShowRoleList()
		{
			return true;
		}

		// Token: 0x0603EE44 RID: 257604 RVA: 0x00F30F19 File Offset: 0x00F2F119
		protected override void OnRoleSelected()
		{
			base.PlaySequence("Switch01");
		}

		// Token: 0x0603EE45 RID: 257605 RVA: 0x00F30F28 File Offset: 0x00F2F128
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

		// Token: 0x0603EE46 RID: 257606 RVA: 0x00F30F66 File Offset: 0x00F2F166
		protected override bool ShouldShowToggle()
		{
			return true;
		}

		// Token: 0x0603EE47 RID: 257607 RVA: 0x00F30F6C File Offset: 0x00F2F16C
		protected override List<RoverlikeOutsideRoleData> BuildRoleDataList()
		{
			RoverlikeActivityData activityData = base.ActivityData;
			int num = (activityData != null) ? activityData.Id : 0;
			List<RoverRogueBlessRole> list = RoverlikeConfig.Instance.GetBlessRoleConfigList().ToList<RoverRogueBlessRole>();
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

		// Token: 0x0603EE48 RID: 257608 RVA: 0x00F31078 File Offset: 0x00F2F278
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

		// Token: 0x0603EE49 RID: 257609 RVA: 0x00F31100 File Offset: 0x00F2F300
		protected override bool IsRoleRedDotVisible(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return this.RoleHasNewUnlockedBless(data.RoleId);
		}

		// Token: 0x0603EE4A RID: 257610 RVA: 0x00F31110 File Offset: 0x00F2F310
		protected override void OnRoleRedDotClear(int roleId)
		{
			RoverlikeActivityData activityData = base.ActivityData;
			if (activityData == null)
			{
				return;
			}
			foreach (int num in activityData.GetNewUnlockedBlessIds().ToList<int>())
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

		// Token: 0x0603EE4B RID: 257611 RVA: 0x00F311BC File Offset: 0x00F2F3BC
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

		// Token: 0x0603EE4C RID: 257612 RVA: 0x00F31388 File Offset: 0x00F2F588
		protected override bool IsEntryLocked(RoverlikeGainEntry entry)
		{
			RoverlikeActivityData activityData = base.ActivityData;
			return activityData == null || !activityData.IsBlessUnlocked(entry.ConfigId);
		}

		// Token: 0x0603EE4D RID: 257613 RVA: 0x00F313A8 File Offset: 0x00F2F5A8
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

		// Token: 0x0603EE4E RID: 257614 RVA: 0x00F313F7 File Offset: 0x00F2F5F7
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

		// Token: 0x04020D56 RID: 134486
		[Nullable(2)]
		private RoverlikeBlessingCardItem DetailCard;
	}
}
