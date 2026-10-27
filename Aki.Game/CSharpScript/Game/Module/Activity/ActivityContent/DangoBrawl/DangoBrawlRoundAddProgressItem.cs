using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006836 RID: 26678
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRoundAddProgressItem : GridProxyAbstract<DangoBrawlProgressItemData>
	{
		// Token: 0x0604296F RID: 272751 RVA: 0x0102FD78 File Offset: 0x0102DF78
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

		// Token: 0x06042970 RID: 272752 RVA: 0x0102FDE1 File Offset: 0x0102DFE1
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06042971 RID: 272753 RVA: 0x0102FDF4 File Offset: 0x0102DFF4
		[NullableContext(1)]
		public override void Refresh(DangoBrawlProgressItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetItem(0).SetUIActive(!data.IsWin);
			base.GetItem(1).SetUIActive(data.IsWin && !data.NeedAnim);
		}

		// Token: 0x06042972 RID: 272754 RVA: 0x0102FE34 File Offset: 0x0102E034
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

		// Token: 0x04022B05 RID: 142085
		public DangoBrawlProgressItemData Data;

		// Token: 0x04022B06 RID: 142086
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200C9F6 RID: 51702
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D057 RID: 249943
			PnlAddOff,
			// Token: 0x0403D058 RID: 249944
			PnlAddOn
		}
	}
}
