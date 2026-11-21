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
	// Token: 0x02004D36 RID: 19766
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleHonamiStoryPlayerStateView : BattleVisibleChildView
	{
		// Token: 0x060319DE RID: 203230 RVA: 0x00DDF818 File Offset: 0x00DDDA18
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

		// Token: 0x060319DF RID: 203231 RVA: 0x00DDF928 File Offset: 0x00DDDB28
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryPlayerStateView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryPlayerStateView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319E0 RID: 203232 RVA: 0x00DDF96C File Offset: 0x00DDDB6C
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

		// Token: 0x060319E1 RID: 203233 RVA: 0x00DDF9DE File Offset: 0x00DDDBDE
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

		// Token: 0x060319E2 RID: 203234 RVA: 0x00DDFA04 File Offset: 0x00DDDC04
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshLevel));
			EventSystem.Instance.Add(EEventName.OnHonamiStoryPickUpAutoEquip, new Action<int>(this.OnPickUpAutoEquip));
		}

		// Token: 0x060319E3 RID: 203235 RVA: 0x00DDFA3E File Offset: 0x00DDDC3E
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshLevel));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPickUpAutoEquip, new Action<int>(this.OnPickUpAutoEquip));
		}

		// Token: 0x060319E4 RID: 203236 RVA: 0x00DDFA78 File Offset: 0x00DDDC78
		private void OnRefreshLevel(int oldValue, int newValue)
		{
			BattleHonamiStoryPlayerLevelView levelView = this.LevelView;
			if (levelView != null)
			{
				levelView.RefreshLevel(oldValue, newValue, false);
			}
			this.RefreshPlayerRank(newValue, false);
		}

		// Token: 0x060319E5 RID: 203237 RVA: 0x00DDFA98 File Offset: 0x00DDDC98
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

		// Token: 0x060319E6 RID: 203238 RVA: 0x00DDFB48 File Offset: 0x00DDDD48
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

		// Token: 0x060319E7 RID: 203239 RVA: 0x00DDFC50 File Offset: 0x00DDDE50
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

		// Token: 0x060319E8 RID: 203240 RVA: 0x00DDFD70 File Offset: 0x00DDDF70
		private void OnRoleItemAfterHide()
		{
			int item;
			if (this.ShowingRoleItemQueue.TryPop(out item))
			{
				this.WaitingRoleItems.Add(item);
			}
			this.TryShowRoleItem();
		}

		// Token: 0x060319E9 RID: 203241 RVA: 0x00DDFD9E File Offset: 0x00DDDF9E
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

		// Token: 0x0401A441 RID: 107585
		private int CurrentRank = -1;

		// Token: 0x0401A442 RID: 107586
		private readonly List<int> RankLevelList = new List<int>();

		// Token: 0x0401A443 RID: 107587
		[Nullable(2)]
		private BattleHonamiStoryPlayerLevelView LevelView;

		// Token: 0x0401A444 RID: 107588
		private int RoleTipsDuration;

		// Token: 0x0401A445 RID: 107589
		private readonly List<BattleHonamiStoryRoleItem> RoleItems = new List<BattleHonamiStoryRoleItem>();

		// Token: 0x0401A446 RID: 107590
		private readonly Queue<HonamiStoryRoleItemData> RoleItemDataQueue = new Queue<HonamiStoryRoleItemData>(4);

		// Token: 0x0401A447 RID: 107591
		private readonly List<int> WaitingRoleItems = new List<int>();

		// Token: 0x0401A448 RID: 107592
		private readonly Queue<int> ShowingRoleItemQueue = new Queue<int>(4);

		// Token: 0x0401A449 RID: 107593
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200AA08 RID: 43528
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x040348C5 RID: 215237
			LevelItem,
			// Token: 0x040348C6 RID: 215238
			RolePanel,
			// Token: 0x040348C7 RID: 215239
			RoleItem,
			// Token: 0x040348C8 RID: 215240
			RankPointA,
			// Token: 0x040348C9 RID: 215241
			RankPointB,
			// Token: 0x040348CA RID: 215242
			RankPointC,
			// Token: 0x040348CB RID: 215243
			RoleItemPanel
		}
	}
}
