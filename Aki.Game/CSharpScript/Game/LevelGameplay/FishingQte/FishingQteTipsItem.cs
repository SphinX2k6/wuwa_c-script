using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FBB RID: 24507
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteTipsItem : UiPanelBase
	{
		// Token: 0x0603AE41 RID: 241217 RVA: 0x010A43AC File Offset: 0x010A25AC
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

		// Token: 0x0603AE42 RID: 241218 RVA: 0x010A43F4 File Offset: 0x010A25F4
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603AE43 RID: 241219 RVA: 0x010A441F File Offset: 0x010A261F
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603AE44 RID: 241220 RVA: 0x010A4421 File Offset: 0x010A2621
		protected override void OnBeforeHide()
		{
			this.InProgressType = EFishingTipsType.None;
		}

		// Token: 0x0603AE45 RID: 241221 RVA: 0x010A442A File Offset: 0x010A262A
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603AE46 RID: 241222 RVA: 0x010A4444 File Offset: 0x010A2644
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

		// Token: 0x0603AE47 RID: 241223 RVA: 0x010A44A0 File Offset: 0x010A26A0
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

		// Token: 0x0603AE48 RID: 241224 RVA: 0x010A4508 File Offset: 0x010A2708
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

		// Token: 0x0603AE49 RID: 241225 RVA: 0x010A4588 File Offset: 0x010A2788
		private void SetTipMiss()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Miss", Array.Empty<object>());
		}

		// Token: 0x0603AE4A RID: 241226 RVA: 0x010A45A5 File Offset: 0x010A27A5
		private void SetTipSuccess()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Success", Array.Empty<object>());
		}

		// Token: 0x0603AE4B RID: 241227 RVA: 0x010A45C2 File Offset: 0x010A27C2
		private void SetTipGetFish(string count)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Catch", new <>z__ReadOnlySingleElementList<object>(count));
		}

		// Token: 0x0401EF61 RID: 126817
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EF62 RID: 126818
		protected EFishingTipsType InProgressType;

		// Token: 0x0401EF63 RID: 126819
		[Nullable(2)]
		protected Action SequenceCallback;

		// Token: 0x0200B8DC RID: 47324
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040390E8 RID: 233704
			public const int TxtTips = 0;
		}
	}
}
