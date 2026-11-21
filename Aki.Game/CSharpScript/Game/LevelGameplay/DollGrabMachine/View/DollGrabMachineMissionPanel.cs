using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x0200607C RID: 24700
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineMissionPanel : UiPanelBase
	{
		// Token: 0x0603B468 RID: 242792 RVA: 0x010C5E54 File Offset: 0x010C4054
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

		// Token: 0x0603B469 RID: 242793 RVA: 0x010C5EE0 File Offset: 0x010C40E0
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

		// Token: 0x0603B46A RID: 242794 RVA: 0x010C5FC8 File Offset: 0x010C41C8
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

		// Token: 0x0603B46B RID: 242795 RVA: 0x010C6080 File Offset: 0x010C4280
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

		// Token: 0x0603B46C RID: 242796 RVA: 0x010C60EA File Offset: 0x010C42EA
		[NullableContext(1)]
		private void OnDollGrabMachineGrabDoll(int count, List<IGrabItemData> grabItemDataList)
		{
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Remaining_Prize_Count", new <>z__ReadOnlySingleElementList<object>(count));
		}

		// Token: 0x0603B46D RID: 242797 RVA: 0x010C610C File Offset: 0x010C430C
		private void OnDollGrabMachineEndlessScoreChanged(int newScore, int addScore)
		{
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Total_Score_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				((endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore.ToString() : null) ?? "0",
				((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore.ToString() : null) ?? "0"
			}));
		}

		// Token: 0x0603B46E RID: 242798 RVA: 0x010C6184 File Offset: 0x010C4384
		private void OnDollGrabMachineRestart()
		{
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			LguiUtil.Instance.SetLocalTextNew(this.MissionInfo, "KClaw_Total_Score_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				((endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore.ToString() : null) ?? "0",
				((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore.ToString() : null) ?? "0"
			}));
		}

		// Token: 0x0401F34E RID: 127822
		private UUIText MissionTitle;

		// Token: 0x0401F34F RID: 127823
		private UUIText MissionInfo;
	}
}
