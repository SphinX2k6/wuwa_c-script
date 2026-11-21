using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047DA RID: 18394
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRecord : UiPanelBase
	{
		// Token: 0x0602E38B RID: 189323 RVA: 0x00CE4724 File Offset: 0x00CE2924
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602E38C RID: 189324 RVA: 0x00CE47B9 File Offset: 0x00CE29B9
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.DisposeTweener();
			this.DisposeSeqPlayer();
		}

		// Token: 0x0602E38D RID: 189325 RVA: 0x00CE47D0 File Offset: 0x00CE29D0
		public void Refresh(IRewardExploreRecord record)
		{
			string titleTextId = record.TitleTextId;
			bool flag = !StringUtils.IsEmpty(titleTextId);
			if (flag)
			{
				this.SetTitleText(titleTextId);
			}
			this.SetTitleTextVisible(flag);
			this.SetNewRecordItemVisible(record.IsNewRecord);
			if (record.RecordRollingTo != null)
			{
				this.SetRollingScore(record.RecordRollingTo.Value);
				return;
			}
			this.SetRecordText(record.Record);
		}

		// Token: 0x0602E38E RID: 189326 RVA: 0x00CE483C File Offset: 0x00CE2A3C
		private void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(0);
			if (StringUtils.IsEmpty(titleTextId))
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x0602E38F RID: 189327 RVA: 0x00CE486B File Offset: 0x00CE2A6B
		private void SetTitleTextVisible(bool bVisible)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(bVisible);
		}

		// Token: 0x0602E390 RID: 189328 RVA: 0x00CE487F File Offset: 0x00CE2A7F
		private void SetRecordText(string record)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(record, true);
		}

		// Token: 0x0602E391 RID: 189329 RVA: 0x00CE4894 File Offset: 0x00CE2A94
		private void SetNewRecordItemVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			if (bVisible)
			{
				if (this.SeqPlayer == null)
				{
					this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
				}
				this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0602E392 RID: 189330 RVA: 0x00CE48EC File Offset: 0x00CE2AEC
		private void SetRollingScore(int recordTo)
		{
			this.ScoreTweener = ULTweenBPLibrary.IntTo(this.RootActor, DelegateUtils.ToManualReleaseDelegate<FLTweenIntSetterDynamic>(new Action<int>(this.ShowRecordInTween)), 0, recordTo, 2f, 0f, LTweenEase.OutQuad);
			ULTweener scoreTweener = this.ScoreTweener;
			if (scoreTweener == null)
			{
				return;
			}
			scoreTweener.OnCompleteCallBack.Bind(new Action(this.DisposeTweener));
		}

		// Token: 0x0602E393 RID: 189331 RVA: 0x00CE4949 File Offset: 0x00CE2B49
		private void ShowRecordInTween(int value)
		{
			this.SetRecordText(value.ToString());
		}

		// Token: 0x0602E394 RID: 189332 RVA: 0x00CE4958 File Offset: 0x00CE2B58
		private void DisposeTweener()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.ShowRecordInTween));
			ULTweener scoreTweener = this.ScoreTweener;
			if (scoreTweener != null)
			{
				scoreTweener.Kill(false);
			}
			this.ScoreTweener = null;
		}

		// Token: 0x0602E395 RID: 189333 RVA: 0x00CE4984 File Offset: 0x00CE2B84
		private void DisposeSeqPlayer()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			this.SeqPlayer = null;
		}

		// Token: 0x040189E4 RID: 100836
		private const float ROLLING_DURATION = 2f;

		// Token: 0x040189E5 RID: 100837
		[Nullable(2)]
		private ULTweener ScoreTweener;

		// Token: 0x040189E6 RID: 100838
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A414 RID: 42004
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D86 RID: 208262
			public const int TitleText = 0;

			// Token: 0x04032D87 RID: 208263
			public const int RecordText = 1;

			// Token: 0x04032D88 RID: 208264
			public const int NewRecordItem = 2;
		}
	}
}
