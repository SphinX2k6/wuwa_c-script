using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FE RID: 26622
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRetryCountItem : GridProxyAbstract<DangoBrawlRetryCountInfo>
	{
		// Token: 0x06042671 RID: 271985 RVA: 0x0101FEF4 File Offset: 0x0101E0F4
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

		// Token: 0x06042672 RID: 271986 RVA: 0x0101FF5D File Offset: 0x0101E15D
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06042673 RID: 271987 RVA: 0x0101FF70 File Offset: 0x0101E170
		[NullableContext(1)]
		public override void Refresh(DangoBrawlRetryCountInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool hasRetry = data.HasRetry;
			base.GetSprite(0).SetUIActive(hasRetry && !data.NeedAnim);
			base.GetSprite(1).SetUIActive(!hasRetry || data.NeedAnim);
		}

		// Token: 0x06042674 RID: 271988 RVA: 0x0101FFC0 File Offset: 0x0101E1C0
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

		// Token: 0x040229C4 RID: 141764
		private DangoBrawlRetryCountInfo Data;

		// Token: 0x040229C5 RID: 141765
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200C96F RID: 51567
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403CD3C RID: 249148
			SprHeartEmpty,
			// Token: 0x0403CD3D RID: 249149
			SprHeartFull
		}
	}
}
