using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200574E RID: 22350
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRetryCountItem : GridProxyAbstract<DangoBrawlRetryCountInfo>
	{
		// Token: 0x060371C6 RID: 225734 RVA: 0x00F61438 File Offset: 0x00F5F638
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060371C7 RID: 225735 RVA: 0x00F614A1 File Offset: 0x00F5F6A1
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060371C8 RID: 225736 RVA: 0x00F614B4 File Offset: 0x00F5F6B4
		[NullableContext(1)]
		public override void Refresh(DangoBrawlRetryCountInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool hasRetry = data.HasRetry;
			base.GetSprite(0).SetUIActive(hasRetry && !data.NeedAnim);
			base.GetSprite(1).SetUIActive(!hasRetry || data.NeedAnim);
		}

		// Token: 0x060371C9 RID: 225737 RVA: 0x00F61504 File Offset: 0x00F5F704
		public void PlayAnim()
		{
			if (this.Data == null || !this.Data.NeedAnim)
			{
				return;
			}
			base.GetSprite(0).SetUIActive(true);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.PlayLevelSequenceByName("Lose", false, null, false);
		}

		// Token: 0x0401D221 RID: 119329
		private DangoBrawlRetryCountInfo Data;

		// Token: 0x0401D222 RID: 119330
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200B33C RID: 45884
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x04037629 RID: 226857
			SprHeartEmpty,
			// Token: 0x0403762A RID: 226858
			SprHeartFull
		}
	}
}
