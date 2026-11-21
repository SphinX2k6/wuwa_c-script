using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F66 RID: 24422
	public class AstrologyDotView : UiPanelBase
	{
		// Token: 0x0603AB8F RID: 240527 RVA: 0x0109A6BE File Offset: 0x010988BE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603AB90 RID: 240528 RVA: 0x0109A6F7 File Offset: 0x010988F7
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0603AB91 RID: 240529 RVA: 0x0109A721 File Offset: 0x01098921
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603AB92 RID: 240530 RVA: 0x0109A73B File Offset: 0x0109893B
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603AB93 RID: 240531 RVA: 0x0109A754 File Offset: 0x01098954
		public void SetDotActive(bool isActive, int? pointTagId = null)
		{
			if (isActive == this.IsActive)
			{
				return;
			}
			this.IsActive = isActive;
			this.PointTagId = pointTagId;
			this.SequencePlayer.StopPrevSequence(false, true);
			if (isActive)
			{
				this.SetActive(true);
				this.SequencePlayer.PlaySequencePurely("Start", false, false);
				this.SequencePlayer.PlaySequencePurely("Loop", false, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x0603AB94 RID: 240532 RVA: 0x0109A7C7 File Offset: 0x010989C7
		public void SetChecked(bool isChecked)
		{
			base.GetItem(0).SetUIActive(!isChecked);
			base.GetItem(1).SetUIActive(isChecked);
		}

		// Token: 0x0603AB95 RID: 240533 RVA: 0x0109A7E6 File Offset: 0x010989E6
		public int? GetPointTagId()
		{
			return this.PointTagId;
		}

		// Token: 0x0401EDE1 RID: 126433
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401EDE2 RID: 126434
		private bool IsActive;

		// Token: 0x0401EDE3 RID: 126435
		private int? PointTagId;

		// Token: 0x0200B8AC RID: 47276
		private class EComponentType
		{
			// Token: 0x0403901F RID: 233503
			public const int YellowItem = 0;

			// Token: 0x04039020 RID: 233504
			public const int WhiteItem = 1;
		}
	}
}
