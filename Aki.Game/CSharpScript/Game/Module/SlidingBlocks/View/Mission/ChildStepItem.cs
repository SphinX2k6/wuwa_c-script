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
	// Token: 0x02004B98 RID: 19352
	[NullableContext(2)]
	[Nullable(0)]
	public class ChildStepItem : UiPanelBase
	{
		// Token: 0x06032255 RID: 205397 RVA: 0x00BA68A0 File Offset: 0x00BA4AA0
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

		// Token: 0x06032256 RID: 205398 RVA: 0x00BA69D0 File Offset: 0x00BA4BD0
		protected override UniTask OnBeforeStartAsync()
		{
			ChildStepItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChildStepItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032257 RID: 205399 RVA: 0x00BA6A14 File Offset: 0x00BA4C14
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

		// Token: 0x06032258 RID: 205400 RVA: 0x00BA6A60 File Offset: 0x00BA4C60
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

		// Token: 0x06032259 RID: 205401 RVA: 0x00BA6AA6 File Offset: 0x00BA4CA6
		public void OnTick(float delta)
		{
			this.CheckScoreAndPlaySuccessAnim();
		}

		// Token: 0x0603225A RID: 205402 RVA: 0x00BA6AAE File Offset: 0x00BA4CAE
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

		// Token: 0x0603225B RID: 205403 RVA: 0x00BA6AD8 File Offset: 0x00BA4CD8
		[NullableContext(1)]
		public void SetTextKey(string textKey)
		{
			this.TextKey = textKey;
		}

		// Token: 0x0603225C RID: 205404 RVA: 0x00BA6AE4 File Offset: 0x00BA4CE4
		private UniTask PlaySuccessAnim()
		{
			ChildStepItem.<PlaySuccessAnim>d__17 <PlaySuccessAnim>d__;
			<PlaySuccessAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySuccessAnim>d__.<>4__this = this;
			<PlaySuccessAnim>d__.<>1__state = -1;
			<PlaySuccessAnim>d__.<>t__builder.Start<ChildStepItem.<PlaySuccessAnim>d__17>(ref <PlaySuccessAnim>d__);
			return <PlaySuccessAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603225D RID: 205405 RVA: 0x00BA6B28 File Offset: 0x00BA4D28
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

		// Token: 0x0401AB61 RID: 109409
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AB62 RID: 109410
		private string TextKey;

		// Token: 0x0401AB63 RID: 109411
		private int RewardId;

		// Token: 0x0401AB64 RID: 109412
		private readonly FColor WhiteColor = FColor.FromHex("ECE5D8FF");

		// Token: 0x0401AB65 RID: 109413
		private readonly FColor GreenColor = FColor.FromHex("C9F797FF");

		// Token: 0x0401AB66 RID: 109414
		private bool IsPlaySuccessAnim;

		// Token: 0x0401AB67 RID: 109415
		private bool IsComplete;

		// Token: 0x0401AB68 RID: 109416
		private int TargetScore;

		// Token: 0x0401AB69 RID: 109417
		private double LastScore;

		// Token: 0x0200ADB5 RID: 44469
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034C23 RID: 216099
			StepDescribeText,
			// Token: 0x04034C24 RID: 216100
			StepDistanceText,
			// Token: 0x04034C25 RID: 216101
			StepSuccess,
			// Token: 0x04034C26 RID: 216102
			StepLose,
			// Token: 0x04034C27 RID: 216103
			StepStatusNode,
			// Token: 0x04034C28 RID: 216104
			Root,
			// Token: 0x04034C29 RID: 216105
			LockIcon,
			// Token: 0x04034C2A RID: 216106
			ProgressBar
		}
	}
}
