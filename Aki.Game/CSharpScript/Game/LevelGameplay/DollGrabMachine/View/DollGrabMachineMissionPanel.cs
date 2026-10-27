using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EFC RID: 28412
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineMissionPanel : UiPanelBase
	{
		// Token: 0x060452BF RID: 283327 RVA: 0x0111C0C4 File Offset: 0x0111A2C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060452C0 RID: 283328 RVA: 0x0111C150 File Offset: 0x0111A350
		protected override void OnBeforeCreate()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				this.MissionTitle = base.GetText(1);
				LguiUtil.Instance.SetLocalTextNew(this.MissionTitle, "KClaw_Total_Score_Title", Array.Empty<object>());
				this.MissionInfo = base.GetText(2);
				EventSystem.Instance.Add<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, new Action<int, int>(this.OnDollGrabMachineEndlessScoreChanged));
				EventSystem.Instance.Add(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
				return;
			}
			this.MissionTitle = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(this.MissionTitle, "KClaw_Gameplay_Name", Array.Empty<object>());
			this.MissionInfo = base.GetText(2);
			EventSystem.Instance.Add<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, new Action<int, List<IGrabItemData>>(this.OnDollGrabMachineGrabDoll));
		}

		// Token: 0x060452C1 RID: 283329 RVA: 0x0111C238 File Offset: 0x0111A438
		protected override void OnBeforeDestroy()
		{
			if (EventSystem.Instance.Has<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, new Action<int, List<IGrabItemData>>(this.OnDollGrabMachineGrabDoll)))
			{
				EventSystem.Instance.Remove<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, new Action<int, List<IGrabItemData>>(this.OnDollGrabMachineGrabDoll));
			}
			if (EventSystem.Instance.Has<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, new Action<int, int>(this.OnDollGrabMachineEndlessScoreChanged)))
			{
				EventSystem.Instance.Remove<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, new Action<int, int>(this.OnDollGrabMachineEndlessScoreChanged));
			}
			if (EventSystem.Instance.Has(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart)))
			{
				EventSystem.Instance.Remove(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
			}
		}

		// Token: 0x060452C2 RID: 283330 RVA: 0x0111C2F0 File Offset: 0x0111A4F0
		public void RefreshPanel()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				this.OnDollGrabMachineGrabDoll(DollGrabMachineController.Instance.LeaveDollCount, new List<IGrabItemData>());
				return;
			}
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			this.OnDollGrabMachineEndlessScoreChanged((endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore : 0, (endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore : 0);
		}

		// Token: 0x060452C3 RID: 283331 RVA: 0x0111C35A File Offset: 0x0111A55A
		[NullableContext(1)]
		private void OnDollGrabMachineGrabDoll(int count, List<IGrabItemData> grabItemDataList)
		{
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Remaining_Prize_Count", new <>z__ReadOnlySingleElementList<object>(count));
		}

		// Token: 0x060452C4 RID: 283332 RVA: 0x0111C37C File Offset: 0x0111A57C
		private void OnDollGrabMachineEndlessScoreChanged(int newScore, int addScore)
		{
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Total_Score_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				((endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore.ToString() : null) ?? "0",
				((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore.ToString() : null) ?? "0"
			}));
		}

		// Token: 0x060452C5 RID: 283333 RVA: 0x0111C3F4 File Offset: 0x0111A5F4
		private void OnDollGrabMachineRestart()
		{
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Total_Score_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				((endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore.ToString() : null) ?? "0",
				((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore.ToString() : null) ?? "0"
			}));
		}

		// Token: 0x0402409B RID: 147611
		private UUIText MissionTitle;

		// Token: 0x0402409C RID: 147612
		private UUIText MissionInfo;
	}
}
