using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005803 RID: 22531
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRecord : UiPanelBase
	{
		// Token: 0x06039477 RID: 234615 RVA: 0x00D958BC File Offset: 0x00D93ABC
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

		// Token: 0x06039478 RID: 234616 RVA: 0x00D95951 File Offset: 0x00D93B51
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.DisposeTweener();
			this.DisposeSeqPlayer();
		}

		// Token: 0x06039479 RID: 234617 RVA: 0x00D95968 File Offset: 0x00D93B68
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

		// Token: 0x0603947A RID: 234618 RVA: 0x00D959D4 File Offset: 0x00D93BD4
		private void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(0);
			if (StringUtils.IsEmpty(titleTextId))
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x0603947B RID: 234619 RVA: 0x00D95A03 File Offset: 0x00D93C03
		private void SetTitleTextVisible(bool bVisible)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(bVisible);
		}

		// Token: 0x0603947C RID: 234620 RVA: 0x00D95A17 File Offset: 0x00D93C17
		private void SetRecordText(string record)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(record, true);
		}

		// Token: 0x0603947D RID: 234621 RVA: 0x00D95A2C File Offset: 0x00D93C2C
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

		// Token: 0x0603947E RID: 234622 RVA: 0x00D95A84 File Offset: 0x00D93C84
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

		// Token: 0x0603947F RID: 234623 RVA: 0x00D95AE1 File Offset: 0x00D93CE1
		private void ShowRecordInTween(int value)
		{
			this.SetRecordText(value.ToString());
		}

		// Token: 0x06039480 RID: 234624 RVA: 0x00D95AF0 File Offset: 0x00D93CF0
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

		// Token: 0x06039481 RID: 234625 RVA: 0x00D95B1C File Offset: 0x00D93D1C
		private void DisposeSeqPlayer()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			this.SeqPlayer = null;
		}

		// Token: 0x0401DF4D RID: 122701
		private const float ROLLING_DURATION = 2f;

		// Token: 0x0401DF4E RID: 122702
		[Nullable(2)]
		private ULTweener ScoreTweener;

		// Token: 0x0401DF4F RID: 122703
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200B9FE RID: 47614
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038399 RID: 230297
			public const int TitleText = 0;

			// Token: 0x0403839A RID: 230298
			public const int RecordText = 1;

			// Token: 0x0403839B RID: 230299
			public const int NewRecordItem = 2;
		}
	}
}
