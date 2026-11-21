using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Mission
{
	// Token: 0x02003B42 RID: 15170
	[NullableContext(2)]
	[Nullable(0)]
	public class ChildStepItem : UiPanelBase
	{
		// Token: 0x06026FE5 RID: 159717 RVA: 0x00AEA9EC File Offset: 0x00AE8BEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026FE6 RID: 159718 RVA: 0x00AEAB1C File Offset: 0x00AE8D1C
		protected override UniTask OnBeforeStartAsync()
		{
			ChildStepItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChildStepItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026FE7 RID: 159719 RVA: 0x00AEAB60 File Offset: 0x00AE8D60
		protected override void OnBeforeShow()
		{
			UUIText text = base.GetText(0);
			if (string.IsNullOrEmpty(this.TextKey) || StringUtils.IsBlank(this.TextKey))
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			text.ShowTextNew(this.TextKey);
		}

		// Token: 0x06026FE8 RID: 159720 RVA: 0x00AEABAC File Offset: 0x00AE8DAC
		protected override void OnAfterShow()
		{
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			if (gameData.PlayMode != ETetrisPlayMode.Endless)
			{
				return;
			}
			if (gameData.ServerData.HistoryReceivedRewardIds.IndexOf(this.RewardId) >= 0)
			{
				this.PlaySuccessAnim().Forget();
			}
		}

		// Token: 0x06026FE9 RID: 159721 RVA: 0x00AEABF2 File Offset: 0x00AE8DF2
		public void OnTick(float delta)
		{
			this.CheckScoreAndPlaySuccessAnim();
		}

		// Token: 0x06026FEA RID: 159722 RVA: 0x00AEABFA File Offset: 0x00AE8DFA
		public void InitByOpenParam(ITargetDescribeAndScore target)
		{
			if (target == null)
			{
				return;
			}
			this.SetTextKey(target.DescribeTextKey);
			this.TargetScore = target.Score;
			this.RewardId = target.RewardId;
		}

		// Token: 0x06026FEB RID: 159723 RVA: 0x00AEAC24 File Offset: 0x00AE8E24
		[NullableContext(1)]
		public void SetTextKey(string textKey)
		{
			this.TextKey = textKey;
		}

		// Token: 0x06026FEC RID: 159724 RVA: 0x00AEAC30 File Offset: 0x00AE8E30
		private UniTask PlaySuccessAnim()
		{
			ChildStepItem.<PlaySuccessAnim>d__17 <PlaySuccessAnim>d__;
			<PlaySuccessAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySuccessAnim>d__.<>4__this = this;
			<PlaySuccessAnim>d__.<>1__state = -1;
			<PlaySuccessAnim>d__.<>t__builder.Start<ChildStepItem.<PlaySuccessAnim>d__17>(ref <PlaySuccessAnim>d__);
			return <PlaySuccessAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06026FED RID: 159725 RVA: 0x00AEAC74 File Offset: 0x00AE8E74
		private void CheckScoreAndPlaySuccessAnim()
		{
			CustomPromise<bool> currentStopPromise = this.LevelSequencePlayer.GetCurrentStopPromise("Success");
			if (this.IsComplete || (currentStopPromise != null && currentStopPromise.IsPending))
			{
				return;
			}
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			ETetrisPlayMode playMode = gameData.PlayMode;
			if (playMode != ETetrisPlayMode.Normal)
			{
				if (playMode != ETetrisPlayMode.Endless)
				{
					return;
				}
				double score = gameData.Score;
				if (score >= (double)this.TargetScore && this.LastScore < (double)this.TargetScore)
				{
					this.PlaySuccessAnim().Forget();
				}
				this.LastScore = score;
			}
			else if (gameData.Time <= 0.0)
			{
				this.PlaySuccessAnim().Forget();
				return;
			}
		}

		// Token: 0x040154B5 RID: 87221
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040154B6 RID: 87222
		private string TextKey;

		// Token: 0x040154B7 RID: 87223
		private int RewardId;

		// Token: 0x040154B8 RID: 87224
		private readonly FColor WhiteColor = FColor.FromHex("ECE5D8FF");

		// Token: 0x040154B9 RID: 87225
		private readonly FColor GreenColor = FColor.FromHex("C9F797FF");

		// Token: 0x040154BA RID: 87226
		private bool IsPlaySuccessAnim;

		// Token: 0x040154BB RID: 87227
		private bool IsComplete;

		// Token: 0x040154BC RID: 87228
		private int TargetScore;

		// Token: 0x040154BD RID: 87229
		private double LastScore;

		// Token: 0x020097D4 RID: 38868
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x0402F5CA RID: 193994
			StepDescribeText,
			// Token: 0x0402F5CB RID: 193995
			StepDistanceText,
			// Token: 0x0402F5CC RID: 193996
			StepSuccess,
			// Token: 0x0402F5CD RID: 193997
			StepLose,
			// Token: 0x0402F5CE RID: 193998
			StepStatusNode,
			// Token: 0x0402F5CF RID: 193999
			Root,
			// Token: 0x0402F5D0 RID: 194000
			LockIcon,
			// Token: 0x0402F5D1 RID: 194001
			ProgressBar
		}
	}
}
