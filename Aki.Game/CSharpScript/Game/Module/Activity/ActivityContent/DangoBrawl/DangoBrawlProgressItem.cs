using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006830 RID: 26672
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlProgressItem : GridProxyAbstract<DangoBrawlProgressItemData>
	{
		// Token: 0x06042903 RID: 272643 RVA: 0x0102D550 File Offset: 0x0102B750
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

		// Token: 0x06042904 RID: 272644 RVA: 0x0102D63D File Offset: 0x0102B83D
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06042905 RID: 272645 RVA: 0x0102D650 File Offset: 0x0102B850
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

		// Token: 0x06042906 RID: 272646 RVA: 0x0102D6F8 File Offset: 0x0102B8F8
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

		// Token: 0x04022ADB RID: 142043
		public DangoBrawlProgressItemData Data;

		// Token: 0x04022ADC RID: 142044
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200C9DD RID: 51677
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CFC6 RID: 249798
			PnlNor,
			// Token: 0x0403CFC7 RID: 249799
			PnlNorLose,
			// Token: 0x0403CFC8 RID: 249800
			PnlNorWin,
			// Token: 0x0403CFC9 RID: 249801
			PnlLast,
			// Token: 0x0403CFCA RID: 249802
			PnlLastLose,
			// Token: 0x0403CFCB RID: 249803
			PnlLastWin
		}
	}
}
