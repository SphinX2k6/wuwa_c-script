using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004852 RID: 18514
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMatchingCountDown : UiPanelBase
	{
		// Token: 0x0602E93F RID: 190783 RVA: 0x00D00EEC File Offset: 0x00CFF0EC
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

		// Token: 0x0602E940 RID: 190784 RVA: 0x00D01080 File Offset: 0x00CFF280
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

		// Token: 0x0602E941 RID: 190785 RVA: 0x00D010D4 File Offset: 0x00CFF2D4
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

		// Token: 0x0602E942 RID: 190786 RVA: 0x00D01194 File Offset: 0x00CFF394
		protected void RefreshButtonActivity()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				base.GetButton(8).RootUIComp.Get().SetUIActive(true);
				return;
			}
			base.GetButton(8).RootUIComp.Get().SetUIActive(OnlineModel.Instance.GetIsMyTeam());
		}

		// Token: 0x0602E943 RID: 190787 RVA: 0x00D011EC File Offset: 0x00CFF3EC
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

		// Token: 0x0602E944 RID: 190788 RVA: 0x00D0123A File Offset: 0x00CFF43A
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

		// Token: 0x0602E945 RID: 190789 RVA: 0x00D01277 File Offset: 0x00CFF477
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

		// Token: 0x0602E946 RID: 190790 RVA: 0x00D01298 File Offset: 0x00CFF498
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

		// Token: 0x0602E947 RID: 190791 RVA: 0x00D0135C File Offset: 0x00CFF55C
		public void BindOnStopTimer(Func<bool> onStopTimer)
		{
			InstanceDungeonEntranceModel.Instance.OnStopTimer = onStopTimer;
		}

		// Token: 0x0602E948 RID: 190792 RVA: 0x00D01369 File Offset: 0x00CFF569
		public void BindOnClickBtnCancelMatching(Action onClickBtnCancelMatching)
		{
			this.OnClickBtnCancelMatching = onClickBtnCancelMatching;
		}

		// Token: 0x0602E949 RID: 190793 RVA: 0x00D01372 File Offset: 0x00CFF572
		public void BindOnAfterCloseAnimation(Action<string> onAfterCloseAnimation)
		{
			this.OnAfterCloseAnimation = onAfterCloseAnimation;
		}

		// Token: 0x0602E94A RID: 190794 RVA: 0x00D0137B File Offset: 0x00CFF57B
		public void BindOnStopHandle(Action onStopHandle)
		{
			InstanceDungeonEntranceModel.Instance.OnStopHandle = onStopHandle;
		}

		// Token: 0x0602E94B RID: 190795 RVA: 0x00D01388 File Offset: 0x00CFF588
		public void SetMatchingTime(int time)
		{
			InstanceDungeonEntranceModel.Instance.MatchingTime = time;
		}

		// Token: 0x0602E94C RID: 190796 RVA: 0x00D01398 File Offset: 0x00CFF598
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

		// Token: 0x04018C92 RID: 101522
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018C93 RID: 101523
		[Nullable(2)]
		private Action OnClickBtnCancelMatching;

		// Token: 0x04018C94 RID: 101524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> OnAfterCloseAnimation;

		// Token: 0x04018C95 RID: 101525
		[Nullable(2)]
		private string CurrentAnimation;

		// Token: 0x0200A4ED RID: 42221
		[NullableContext(0)]
		private static class EInstanceDungeonMatchingCountDownComponent
		{
			// Token: 0x04033155 RID: 209237
			public const int OtherButton = 2;

			// Token: 0x04033156 RID: 209238
			public const int TextTime = 5;

			// Token: 0x04033157 RID: 209239
			public const int TextName = 7;

			// Token: 0x04033158 RID: 209240
			public const int BtnCancel = 8;

			// Token: 0x04033159 RID: 209241
			public const int RoleItem = 10;

			// Token: 0x0403315A RID: 209242
			public const int ProcessItem = 11;

			// Token: 0x0403315B RID: 209243
			public const int MatchingItem = 12;

			// Token: 0x0403315C RID: 209244
			public const int MatchingDownItem = 13;

			// Token: 0x0403315D RID: 209245
			public const int MatchingWaitItem = 14;
		}
	}
}
