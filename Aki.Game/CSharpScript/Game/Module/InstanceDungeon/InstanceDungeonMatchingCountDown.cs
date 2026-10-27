using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587A RID: 22650
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMatchingCountDown : UiPanelBase
	{
		// Token: 0x06039A1D RID: 236061 RVA: 0x00DB1FE0 File Offset: 0x00DB01E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnCancel));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039A1E RID: 236062 RVA: 0x00DB2174 File Offset: 0x00DB0374
		private void OnClickBtnCancel()
		{
			if ("Close" == this.CurrentAnimation)
			{
				return;
			}
			EInstanceMatchState matchingState = InstanceDungeonEntranceModel.Instance.GetMatchingState();
			if (matchingState == EInstanceMatchState.Waiting || matchingState == EInstanceMatchState.MatchConfirm)
			{
				return;
			}
			this.PlayAnimation("Close");
			if (this.OnClickBtnCancelMatching != null)
			{
				this.OnClickBtnCancelMatching();
			}
		}

		// Token: 0x06039A1F RID: 236063 RVA: 0x00DB21C8 File Offset: 0x00DB03C8
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(13);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(14);
			if (item5 != null)
			{
				item5.SetUIActive(true);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.RefreshButtonActivity();
		}

		// Token: 0x06039A20 RID: 236064 RVA: 0x00DB2288 File Offset: 0x00DB0488
		protected void RefreshButtonActivity()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				base.GetButton(8).RootUIComp.Get().SetUIActive(true);
				return;
			}
			base.GetButton(8).RootUIComp.Get().SetUIActive(OnlineModel.Instance.GetIsMyTeam());
		}

		// Token: 0x06039A21 RID: 236065 RVA: 0x00DB22E0 File Offset: 0x00DB04E0
		public void PlayAnimation(string animation)
		{
			if (this.CurrentAnimation == animation)
			{
				return;
			}
			base.SetUiActive(true);
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName(animation, false, null, false);
			this.CurrentAnimation = animation;
		}

		// Token: 0x06039A22 RID: 236066 RVA: 0x00DB232E File Offset: 0x00DB052E
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.SetUiActive(false);
			}
			else if (sequenceName == "Finish")
			{
				base.SetUiActive(false);
			}
			Action<string> onAfterCloseAnimation = this.OnAfterCloseAnimation;
			if (onAfterCloseAnimation == null)
			{
				return;
			}
			onAfterCloseAnimation(sequenceName);
		}

		// Token: 0x06039A23 RID: 236067 RVA: 0x00DB236B File Offset: 0x00DB056B
		protected override void OnBeforeDestroy()
		{
			this.OnClickBtnCancelMatching = null;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06039A24 RID: 236068 RVA: 0x00DB238C File Offset: 0x00DB058C
		public void StartTimer()
		{
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			UUIText text = base.GetText(5);
			text.SetText(TimeUtil.Instance.GetTimeString((double)instance.MatchingTime), true);
			text.SetUIActive(true);
			base.GetText(7).ShowTextNew(InstanceDungeonConfig.Instance.GetConfig(instance.GetMatchingId()).Value.MapName);
			InstanceDungeonEntranceController.Instance.StartMatchTimer(new Action(this.RefreshMatchingTime));
			if (this.LevelSequencePlayer.GetCurrentSequence() == "AutoLoop")
			{
				this.LevelSequencePlayer.ReplaySequenceByKey("AutoLoop");
			}
			else
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
			}
			this.RefreshButtonActivity();
		}

		// Token: 0x06039A25 RID: 236069 RVA: 0x00DB2450 File Offset: 0x00DB0650
		public void BindOnStopTimer(Func<bool> onStopTimer)
		{
			InstanceDungeonEntranceModel.Instance.OnStopTimer = onStopTimer;
		}

		// Token: 0x06039A26 RID: 236070 RVA: 0x00DB245D File Offset: 0x00DB065D
		public void BindOnClickBtnCancelMatching(Action onClickBtnCancelMatching)
		{
			this.OnClickBtnCancelMatching = onClickBtnCancelMatching;
		}

		// Token: 0x06039A27 RID: 236071 RVA: 0x00DB2466 File Offset: 0x00DB0666
		public void BindOnAfterCloseAnimation(Action<string> onAfterCloseAnimation)
		{
			this.OnAfterCloseAnimation = onAfterCloseAnimation;
		}

		// Token: 0x06039A28 RID: 236072 RVA: 0x00DB246F File Offset: 0x00DB066F
		public void BindOnStopHandle(Action onStopHandle)
		{
			InstanceDungeonEntranceModel.Instance.OnStopHandle = onStopHandle;
		}

		// Token: 0x06039A29 RID: 236073 RVA: 0x00DB247C File Offset: 0x00DB067C
		public void SetMatchingTime(int time)
		{
			InstanceDungeonEntranceModel.Instance.MatchingTime = time;
		}

		// Token: 0x06039A2A RID: 236074 RVA: 0x00DB248C File Offset: 0x00DB068C
		private void RefreshMatchingTime()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.InstanceDungeonEntranceView) && !UiManager.Instance.IsViewShow(EUiViewName.OnlineWorldHallView) && !UiManager.Instance.IsViewShow(EUiViewName.BattleTeam2DView) && !UiManager.Instance.IsViewShow(EUiViewName.DangoAbyssInsSelectView) && !UiManager.Instance.IsViewShow(EUiViewName.MultiMotorChoseLevelView) && !UiManager.Instance.IsViewShow(EUiViewName.TowerDefenseLevelView))
			{
				return;
			}
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(TimeUtil.Instance.GetTimeString((double)InstanceDungeonEntranceModel.Instance.MatchingTime), true);
		}

		// Token: 0x0401E1F5 RID: 123381
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E1F6 RID: 123382
		[Nullable(2)]
		private Action OnClickBtnCancelMatching;

		// Token: 0x0401E1F7 RID: 123383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> OnAfterCloseAnimation;

		// Token: 0x0401E1F8 RID: 123384
		[Nullable(2)]
		private string CurrentAnimation;

		// Token: 0x0200BAD4 RID: 47828
		[NullableContext(0)]
		private static class EInstanceDungeonMatchingCountDownComponent
		{
			// Token: 0x04038754 RID: 231252
			public const int OtherButton = 2;

			// Token: 0x04038755 RID: 231253
			public const int TextTime = 5;

			// Token: 0x04038756 RID: 231254
			public const int TextName = 7;

			// Token: 0x04038757 RID: 231255
			public const int BtnCancel = 8;

			// Token: 0x04038758 RID: 231256
			public const int RoleItem = 10;

			// Token: 0x04038759 RID: 231257
			public const int ProcessItem = 11;

			// Token: 0x0403875A RID: 231258
			public const int MatchingItem = 12;

			// Token: 0x0403875B RID: 231259
			public const int MatchingDownItem = 13;

			// Token: 0x0403875C RID: 231260
			public const int MatchingWaitItem = 14;
		}
	}
}
