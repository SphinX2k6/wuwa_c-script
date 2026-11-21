using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC6 RID: 3782
	public struct LordGymEntranceSet : IFlatbufferObject
	{
		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06009644 RID: 38468 RVA: 0x0029A940 File Offset: 0x00298B40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0029A94D File Offset: 0x00298B4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0029A954 File Offset: 0x00298B54
		public static LordGymEntranceSet GetRootAsLordGymEntranceSet(ByteBuffer _bb)
		{
			return LordGymEntranceSet.GetRootAsLordGymEntranceSet(_bb, default(LordGymEntranceSet));
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0029A970 File Offset: 0x00298B70
		public static LordGymEntranceSet GetRootAsLordGymEntranceSet(ByteBuffer _bb, LordGymEntranceSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x0029A98D File Offset: 0x00298B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x0029A99C File Offset: 0x00298B9C
		public LordGymEntranceSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600964A RID: 38474 RVA: 0x0029A9AC File Offset: 0x00298BAC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600964B RID: 38475 RVA: 0x0029A9E8 File Offset: 0x00298BE8
		public int PreviewRewardId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x0029AA24 File Offset: 0x00298C24
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x0600964D RID: 38477 RVA: 0x0029AA60 File Offset: 0x00298C60
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x0029AAA0 File Offset: 0x00298CA0
		public int LordEntranceList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600964F RID: 38479 RVA: 0x0029AAE0 File Offset: 0x00298CE0
		public int LordEntranceListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x0029AB0C File Offset: 0x00298D0C
		public Span<int> GetLordEntranceListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x0029AB1C File Offset: 0x00298D1C
		public int[] GetLordEntranceListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06009652 RID: 38482 RVA: 0x0029AB34 File Offset: 0x00298D34
		public int MapNoteUnlockCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x0029AB74 File Offset: 0x00298D74
		public string Title
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x0029ABAC File Offset: 0x00298DAC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x0029ABBC File Offset: 0x00298DBC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x0029ABD4 File Offset: 0x00298DD4
		public string Description
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009657 RID: 38487 RVA: 0x0029AC0C File Offset: 0x00298E0C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x0029AC1C File Offset: 0x00298E1C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06009659 RID: 38489 RVA: 0x0029AC34 File Offset: 0x00298E34
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x0029AC71 File Offset: 0x00298E71
		[NullableContext(1)]
		public int[] LordEntranceList()
		{
			return this.GetLordEntranceListArray();
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0029AC79 File Offset: 0x00298E79
		[NullableContext(1)]
		public IEnumerable<int> LordEntranceListIter()
		{
			LordGymEntranceSet.<LordEntranceListIter>d__34 <LordEntranceListIter>d__ = new LordGymEntranceSet.<LordEntranceListIter>d__34(-2);
			<LordEntranceListIter>d__.<>3__<>4__this = this;
			return <LordEntranceListIter>d__;
		}

		// Token: 0x04005462 RID: 21602
		private Table __p;
	}
}
