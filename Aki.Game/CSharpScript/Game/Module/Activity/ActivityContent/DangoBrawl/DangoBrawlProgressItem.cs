using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005780 RID: 22400
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlProgressItem : GridProxyAbstract<DangoBrawlProgressItemData>
	{
		// Token: 0x06037457 RID: 226391 RVA: 0x00F6EA8C File Offset: 0x00F6CC8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037458 RID: 226392 RVA: 0x00F6EB79 File Offset: 0x00F6CD79
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06037459 RID: 226393 RVA: 0x00F6EB8C File Offset: 0x00F6CD8C
		[NullableContext(1)]
		public override void Refresh(DangoBrawlProgressItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetItem(0).SetUIActive(!data.IsLast);
			base.GetItem(3).SetUIActive(data.IsLast);
			base.GetItem(1).SetUIActive(!data.IsWin);
			base.GetItem(2).SetUIActive(data.IsWin && !data.NeedAnim);
			base.GetItem(4).SetUIActive(!data.IsWin);
			base.GetItem(5).SetUIActive(data.IsWin && !data.NeedAnim);
		}

		// Token: 0x0603745A RID: 226394 RVA: 0x00F6EC34 File Offset: 0x00F6CE34
		public void PlayAnim()
		{
			if (this.Data == null || !this.Data.NeedAnim)
			{
				return;
			}
			base.GetItem(2).SetUIActive(this.Data.IsWin && !this.Data.IsLast);
			base.GetItem(5).SetUIActive(this.Data.IsWin && this.Data.IsLast);
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
			seqPlayer2.PlayLevelSequenceByName("TrophyStart", false, null, false);
		}

		// Token: 0x0401D338 RID: 119608
		public DangoBrawlProgressItemData Data;

		// Token: 0x0401D339 RID: 119609
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200B3A9 RID: 45993
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040378B0 RID: 227504
			PnlNor,
			// Token: 0x040378B1 RID: 227505
			PnlNorLose,
			// Token: 0x040378B2 RID: 227506
			PnlNorWin,
			// Token: 0x040378B3 RID: 227507
			PnlLast,
			// Token: 0x040378B4 RID: 227508
			PnlLastLose,
			// Token: 0x040378B5 RID: 227509
			PnlLastWin
		}
	}
}
