using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E3A RID: 28218
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteTipsItem : UiPanelBase
	{
		// Token: 0x06044CB4 RID: 281780 RVA: 0x010F9E2C File Offset: 0x010F802C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044CB5 RID: 281781 RVA: 0x010F9E74 File Offset: 0x010F8074
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06044CB6 RID: 281782 RVA: 0x010F9E9F File Offset: 0x010F809F
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06044CB7 RID: 281783 RVA: 0x010F9EA1 File Offset: 0x010F80A1
		protected override void OnBeforeHide()
		{
			this.InProgressType = EFishingTipsType.None;
		}

		// Token: 0x06044CB8 RID: 281784 RVA: 0x010F9EAA File Offset: 0x010F80AA
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06044CB9 RID: 281785 RVA: 0x010F9EC4 File Offset: 0x010F80C4
		private void ShowTips(string sequenceName)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.LevelSequencePlayer.ReplaySequenceByKey(sequenceName);
			}
			else
			{
				this.LevelSequencePlayer.StopPlayingSequence(false, true);
				this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
			this.SetActive(true);
		}

		// Token: 0x06044CBA RID: 281786 RVA: 0x010F9F20 File Offset: 0x010F8120
		private void OnSequenceClose(string sequenceName)
		{
			EFishingTipsType efishingTipsType = EFishingTipsType.None;
			if (sequenceName == "Fail")
			{
				efishingTipsType = EFishingTipsType.Miss;
			}
			else if (sequenceName == "QteSuccess")
			{
				efishingTipsType = EFishingTipsType.QteOn;
			}
			else if (sequenceName == "Success")
			{
				efishingTipsType = EFishingTipsType.GetFish;
			}
			if (efishingTipsType == this.InProgressType)
			{
				Action sequenceCallback = this.SequenceCallback;
				if (sequenceCallback != null)
				{
					sequenceCallback();
				}
				this.SequenceCallback = null;
				this.SetActive(false);
			}
		}

		// Token: 0x06044CBB RID: 281787 RVA: 0x010F9F88 File Offset: 0x010F8188
		public void ShowTip(EFishingTipsType tipsType, string extraParam, [Nullable(2)] Action callback = null)
		{
			string sequenceName = "Success";
			switch (tipsType)
			{
			case EFishingTipsType.Miss:
				this.SetTipMiss();
				sequenceName = "Fail";
				break;
			case EFishingTipsType.QteOn:
				this.SetTipSuccess();
				sequenceName = "QteSuccess";
				break;
			case EFishingTipsType.GetFish:
				this.SetTipGetFish(extraParam);
				sequenceName = "Success";
				break;
			}
			if (this.SequenceCallback != null)
			{
				Action sequenceCallback = this.SequenceCallback;
				if (sequenceCallback != null)
				{
					sequenceCallback();
				}
			}
			this.SequenceCallback = callback;
			this.InProgressType = tipsType;
			this.ShowTips(sequenceName);
		}

		// Token: 0x06044CBC RID: 281788 RVA: 0x010FA008 File Offset: 0x010F8208
		private void SetTipMiss()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Miss", Array.Empty<object>());
		}

		// Token: 0x06044CBD RID: 281789 RVA: 0x010FA025 File Offset: 0x010F8225
		private void SetTipSuccess()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Success", Array.Empty<object>());
		}

		// Token: 0x06044CBE RID: 281790 RVA: 0x010FA042 File Offset: 0x010F8242
		private void SetTipGetFish(string count)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Catch", new <>z__ReadOnlySingleElementList<object>(count));
		}

		// Token: 0x04023CAC RID: 146604
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023CAD RID: 146605
		protected EFishingTipsType InProgressType;

		// Token: 0x04023CAE RID: 146606
		[Nullable(2)]
		protected Action SequenceCallback;

		// Token: 0x0200CCEC RID: 52460
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DCC6 RID: 253126
			public const int TxtTips = 0;
		}
	}
}
