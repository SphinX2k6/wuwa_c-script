using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005786 RID: 22406
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRoundAddProgressItem : GridProxyAbstract<DangoBrawlProgressItemData>
	{
		// Token: 0x060374C3 RID: 226499 RVA: 0x00F71284 File Offset: 0x00F6F484
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

		// Token: 0x060374C4 RID: 226500 RVA: 0x00F712ED File Offset: 0x00F6F4ED
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060374C5 RID: 226501 RVA: 0x00F71300 File Offset: 0x00F6F500
		[NullableContext(1)]
		public override void Refresh(DangoBrawlProgressItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetItem(0).SetUIActive(!data.IsWin);
			base.GetItem(1).SetUIActive(data.IsWin && !data.NeedAnim);
		}

		// Token: 0x060374C6 RID: 226502 RVA: 0x00F71340 File Offset: 0x00F6F540
		public void PlayAnim()
		{
			if (this.Data == null || !this.Data.NeedAnim)
			{
				return;
			}
			base.GetItem(1).SetUIActive(true);
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

		// Token: 0x0401D362 RID: 119650
		public DangoBrawlProgressItemData Data;

		// Token: 0x0401D363 RID: 119651
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200B3C2 RID: 46018
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037940 RID: 227648
			PnlAddOff,
			// Token: 0x04037941 RID: 227649
			PnlAddOn
		}
	}
}
