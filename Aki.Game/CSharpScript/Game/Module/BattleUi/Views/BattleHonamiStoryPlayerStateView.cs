using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D54 RID: 23892
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleHonamiStoryPlayerStateView : BattleVisibleChildView
	{
		// Token: 0x0603CA85 RID: 248453 RVA: 0x00E8F064 File Offset: 0x00E8D264
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CA86 RID: 248454 RVA: 0x00E8F174 File Offset: 0x00E8D374
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryPlayerStateView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryPlayerStateView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA87 RID: 248455 RVA: 0x00E8F1B8 File Offset: 0x00E8D3B8
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			int powerLevel = HonamiStoryModel.Instance.PlayerData.PowerLevel;
			BattleHonamiStoryPlayerLevelView levelView = this.LevelView;
			if (levelView != null)
			{
				levelView.RefreshLevel(0, powerLevel, true);
			}
			this.RefreshPlayerRank(powerLevel, true);
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			base.GetItem(6).SetUIActive(true);
			this.PlayRolePanelSequence(false);
			this.AddEvents();
		}

		// Token: 0x0603CA88 RID: 248456 RVA: 0x00E8F22A File Offset: 0x00E8D42A
		public override void Reset()
		{
			this.RemoveEvents();
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			base.Reset();
		}

		// Token: 0x0603CA89 RID: 248457 RVA: 0x00E8F250 File Offset: 0x00E8D450
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshLevel));
			EventSystem.Instance.Add(EEventName.OnHonamiStoryPickUpAutoEquip, new Action<int>(this.OnPickUpAutoEquip));
		}

		// Token: 0x0603CA8A RID: 248458 RVA: 0x00E8F28A File Offset: 0x00E8D48A
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshLevel));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPickUpAutoEquip, new Action<int>(this.OnPickUpAutoEquip));
		}

		// Token: 0x0603CA8B RID: 248459 RVA: 0x00E8F2C4 File Offset: 0x00E8D4C4
		private void OnRefreshLevel(int oldValue, int newValue)
		{
			BattleHonamiStoryPlayerLevelView levelView = this.LevelView;
			if (levelView != null)
			{
				levelView.RefreshLevel(oldValue, newValue, false);
			}
			this.RefreshPlayerRank(newValue, false);
		}

		// Token: 0x0603CA8C RID: 248460 RVA: 0x00E8F2E4 File Offset: 0x00E8D4E4
		private unsafe void RefreshPlayerRank(int newLevel, bool isInit = false)
		{
			int num = -1;
			for (int i = 0; i < this.RankLevelList.Count; i++)
			{
				int num2 = this.RankLevelList[i];
				if (newLevel < num2)
				{
					break;
				}
				num = i;
			}
			if (!isInit && num == this.CurrentRank)
			{
				return;
			}
			this.CurrentRank = num;
			<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType> <>y__InlineArray = default(<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType>, BattleHonamiStoryPlayerStateView.EComponentType>(ref <>y__InlineArray, 0) = BattleHonamiStoryPlayerStateView.EComponentType.RankPointB;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType>, BattleHonamiStoryPlayerStateView.EComponentType>(ref <>y__InlineArray, 1) = BattleHonamiStoryPlayerStateView.EComponentType.RankPointA;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType>, BattleHonamiStoryPlayerStateView.EComponentType>(ref <>y__InlineArray, 2) = BattleHonamiStoryPlayerStateView.EComponentType.RankPointC;
			Span<BattleHonamiStoryPlayerStateView.EComponentType> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray3<BattleHonamiStoryPlayerStateView.EComponentType>, BattleHonamiStoryPlayerStateView.EComponentType>(ref <>y__InlineArray, 3);
			for (int j = 0; j < span.Length; j++)
			{
				base.GetItem((int)(*span[j])).SetUIActive(num >= j);
			}
		}

		// Token: 0x0603CA8D RID: 248461 RVA: 0x00E8F394 File Offset: 0x00E8D594
		private void OnPickUpAutoEquip(int position)
		{
			HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(position);
			if (roleItemDataByPosition == null)
			{
				return;
			}
			HonamiStoryEquipItemData itemDataByPosition = roleItemDataByPosition.GetItemDataByPosition(position);
			if (itemDataByPosition == null)
			{
				return;
			}
			List<int> list = null;
			List<HonamiStoryWeaponSuitActiveData> list2 = null;
			HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(roleItemDataByPosition.GetWeaponId());
			if (weaponData != null)
			{
				list = new List<int>();
				list2 = new List<HonamiStoryWeaponSuitActiveData>();
				foreach (int num in weaponData.Config.Value.SuitIdIter())
				{
					list.Add(num);
					list2.Add(roleItemDataByPosition.IsSuitActivate(num, null));
				}
			}
			HonamiStoryRoleItemData element = new HonamiStoryRoleItemData
			{
				RoleId = roleItemDataByPosition.GetRoleId(),
				ItemSubType = itemDataByPosition.GetSubType(),
				BuffActive = roleItemDataByPosition.CheckItemBuffIsActive(itemDataByPosition),
				SuitIdList = list,
				SuitDataList = list2
			};
			this.RoleItemDataQueue.Push(element);
			this.TryShowRoleItem();
		}

		// Token: 0x0603CA8E RID: 248462 RVA: 0x00E8F49C File Offset: 0x00E8D69C
		private void TryShowRoleItem()
		{
			if (this.RoleItemDataQueue.Size == 0)
			{
				if (this.WaitingRoleItems.Count == this.RoleItems.Count)
				{
					this.PlayRolePanelSequence(false);
				}
				return;
			}
			if (this.WaitingRoleItems.Count <= 0)
			{
				int index;
				if (this.ShowingRoleItemQueue.TryGetFront(out index))
				{
					this.RoleItems[index].HideRoleItem();
				}
				return;
			}
			int num;
			if (!this.WaitingRoleItems.TryPop(out num))
			{
				return;
			}
			if (this.ShowingRoleItemQueue.Size == 0)
			{
				this.PlayRolePanelSequence(true);
			}
			HonamiStoryRoleItemData honamiStoryRoleItemData = this.RoleItemDataQueue.Pop();
			if (honamiStoryRoleItemData == null)
			{
				return;
			}
			this.RoleItems[num].ShowRoleItem(honamiStoryRoleItemData, this.RoleTipsDuration);
			this.ShowingRoleItemQueue.Push(num);
			int num2 = 0;
			foreach (int index2 in this.ShowingRoleItemQueue)
			{
				this.RoleItems[index2].GetRootItem().SetHierarchyIndex(num2++);
			}
		}

		// Token: 0x0603CA8F RID: 248463 RVA: 0x00E8F5BC File Offset: 0x00E8D7BC
		private void OnRoleItemAfterHide()
		{
			int item;
			if (this.ShowingRoleItemQueue.TryPop(out item))
			{
				this.WaitingRoleItems.Add(item);
			}
			this.TryShowRoleItem();
		}

		// Token: 0x0603CA90 RID: 248464 RVA: 0x00E8F5EA File Offset: 0x00E8D7EA
		private void PlayRolePanelSequence(bool isExtended)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPrevSequence(false, true);
			}
			UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlaySequencePurely(isExtended ? "Extended" : "Basics", false, false);
		}

		// Token: 0x0401F988 RID: 129416
		private int CurrentRank = -1;

		// Token: 0x0401F989 RID: 129417
		private readonly List<int> RankLevelList = new List<int>();

		// Token: 0x0401F98A RID: 129418
		[Nullable(2)]
		private BattleHonamiStoryPlayerLevelView LevelView;

		// Token: 0x0401F98B RID: 129419
		private int RoleTipsDuration;

		// Token: 0x0401F98C RID: 129420
		private readonly List<BattleHonamiStoryRoleItem> RoleItems = new List<BattleHonamiStoryRoleItem>();

		// Token: 0x0401F98D RID: 129421
		private readonly Queue<HonamiStoryRoleItemData> RoleItemDataQueue = new Queue<HonamiStoryRoleItemData>(4);

		// Token: 0x0401F98E RID: 129422
		private readonly List<int> WaitingRoleItems = new List<int>();

		// Token: 0x0401F98F RID: 129423
		private readonly Queue<int> ShowingRoleItemQueue = new Queue<int>(4);

		// Token: 0x0401F990 RID: 129424
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C002 RID: 49154
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039F03 RID: 237315
			LevelItem,
			// Token: 0x04039F04 RID: 237316
			RolePanel,
			// Token: 0x04039F05 RID: 237317
			RoleItem,
			// Token: 0x04039F06 RID: 237318
			RankPointA,
			// Token: 0x04039F07 RID: 237319
			RankPointB,
			// Token: 0x04039F08 RID: 237320
			RankPointC,
			// Token: 0x04039F09 RID: 237321
			RoleItemPanel
		}
	}
}
