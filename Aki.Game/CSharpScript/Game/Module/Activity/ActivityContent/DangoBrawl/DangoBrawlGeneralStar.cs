using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200574F RID: 22351
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlGeneralStar : UiPanelBase
	{
		// Token: 0x060371CB RID: 225739 RVA: 0x00F61570 File Offset: 0x00F5F770
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060371CC RID: 225740 RVA: 0x00F615D9 File Offset: 0x00F5F7D9
		protected override void OnStart()
		{
			this.CreateSequencePlayer();
		}

		// Token: 0x060371CD RID: 225741 RVA: 0x00F615E1 File Offset: 0x00F5F7E1
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x060371CE RID: 225742 RVA: 0x00F615EC File Offset: 0x00F5F7EC
		private void CreateSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x060371CF RID: 225743 RVA: 0x00F6162D File Offset: 0x00F5F82D
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.OnActiveSeqEnd = null;
		}

		// Token: 0x060371D0 RID: 225744 RVA: 0x00F6164E File Offset: 0x00F5F84E
		[NullableContext(1)]
		private void OnSequenceEnd(string seqKey)
		{
			if (seqKey == "Activate")
			{
				Action onActiveSeqEnd = this.OnActiveSeqEnd;
				if (onActiveSeqEnd != null)
				{
					onActiveSeqEnd();
				}
				this.OnActiveSeqEnd = null;
			}
		}

		// Token: 0x060371D1 RID: 225745 RVA: 0x00F61678 File Offset: 0x00F5F878
		public void PlayActiveSeq(Action onEnd = null)
		{
			if (this.SequencePlayer == null)
			{
				if (onEnd != null)
				{
					onEnd();
				}
				return;
			}
			this.OnActiveSeqEnd = onEnd;
			this.SequencePlayer.PlaySequence("Activate", false, null);
		}

		// Token: 0x060371D2 RID: 225746 RVA: 0x00F616B8 File Offset: 0x00F5F8B8
		public void SetUiRelativeLocation(FVector2D val)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIRelativeLocation(new FVector(val.X, val.Y, 0f));
		}

		// Token: 0x060371D3 RID: 225747 RVA: 0x00F616E0 File Offset: 0x00F5F8E0
		public void SetStarVisible(bool val)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x0401D223 RID: 119331
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401D224 RID: 119332
		private Action OnActiveSeqEnd;

		// Token: 0x0200B33D RID: 45885
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403762C RID: 226860
			SprStarBag,
			// Token: 0x0403762D RID: 226861
			SprStar
		}
	}
}
