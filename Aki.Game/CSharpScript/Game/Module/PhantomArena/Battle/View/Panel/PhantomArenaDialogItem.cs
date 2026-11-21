using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004228 RID: 16936
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDialogItem : UiPanelBase
	{
		// Token: 0x0602ACF8 RID: 175352 RVA: 0x00C0D47F File Offset: 0x00C0B67F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602ACF9 RID: 175353 RVA: 0x00C0D4A2 File Offset: 0x00C0B6A2
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602ACFA RID: 175354 RVA: 0x00C0D4CC File Offset: 0x00C0B6CC
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602ACFB RID: 175355 RVA: 0x00C0D4D9 File Offset: 0x00C0B6D9
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602ACFC RID: 175356 RVA: 0x00C0D4EF File Offset: 0x00C0B6EF
		public UUIText GetDialog()
		{
			return base.GetText(0);
		}

		// Token: 0x0602ACFD RID: 175357 RVA: 0x00C0D4F8 File Offset: 0x00C0B6F8
		public void SetDialogActive(bool active)
		{
			if (active)
			{
				this.SetActive(true);
				this.Sequence.StopPrevSequence(false, true);
				this.Sequence.PlaySequencePurely("Start", false, false);
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x04017304 RID: 94980
		protected UiSequencePlayer Sequence;

		// Token: 0x02009E4E RID: 40526
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031369 RID: 201577
			public const int DialogText = 0;
		}
	}
}
