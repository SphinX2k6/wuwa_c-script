using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FF RID: 26623
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlGeneralStar : UiPanelBase
	{
		// Token: 0x06042676 RID: 271990 RVA: 0x0102002C File Offset: 0x0101E22C
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

		// Token: 0x06042677 RID: 271991 RVA: 0x01020095 File Offset: 0x0101E295
		protected override void OnStart()
		{
			this.CreateSequencePlayer();
		}

		// Token: 0x06042678 RID: 271992 RVA: 0x0102009D File Offset: 0x0101E29D
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x06042679 RID: 271993 RVA: 0x010200A8 File Offset: 0x0101E2A8
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

		// Token: 0x0604267A RID: 271994 RVA: 0x010200E9 File Offset: 0x0101E2E9
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

		// Token: 0x0604267B RID: 271995 RVA: 0x0102010A File Offset: 0x0101E30A
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

		// Token: 0x0604267C RID: 271996 RVA: 0x01020134 File Offset: 0x0101E334
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

		// Token: 0x0604267D RID: 271997 RVA: 0x01020174 File Offset: 0x0101E374
		public void SetUiRelativeLocation(FVector2D val)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIRelativeLocation(new FVector(val.X, val.Y, 0f));
		}

		// Token: 0x0604267E RID: 271998 RVA: 0x0102019C File Offset: 0x0101E39C
		public void SetStarVisible(bool val)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x040229C6 RID: 141766
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040229C7 RID: 141767
		private Action OnActiveSeqEnd;

		// Token: 0x0200C970 RID: 51568
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CD3F RID: 249151
			SprStarBag,
			// Token: 0x0403CD40 RID: 249152
			SprStar
		}
	}
}
