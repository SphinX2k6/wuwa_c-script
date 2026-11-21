using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001073 RID: 4211
	public struct RacingBetsMatch : IFlatbufferObject
	{
		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600BE8E RID: 48782 RVA: 0x002F256C File Offset: 0x002F076C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x002F2579 File Offset: 0x002F0779
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x002F2580 File Offset: 0x002F0780
		public static RacingBetsMatch GetRootAsRacingBetsMatch(ByteBuffer _bb)
		{
			return RacingBetsMatch.GetRootAsRacingBetsMatch(_bb, default(RacingBetsMatch));
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x002F259C File Offset: 0x002F079C
		public static RacingBetsMatch GetRootAsRacingBetsMatch(ByteBuffer _bb, RacingBetsMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE92 RID: 48786 RVA: 0x002F25B9 File Offset: 0x002F07B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x002F25C8 File Offset: 0x002F07C8
		public RacingBetsMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600BE94 RID: 48788 RVA: 0x002F25D8 File Offset: 0x002F07D8
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

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600BE95 RID: 48789 RVA: 0x002F2614 File Offset: 0x002F0814
		public int SeasonId
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

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x002F2650 File Offset: 0x002F0850
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE97 RID: 48791 RVA: 0x002F2687 File Offset: 0x002F0887
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x002F2696 File Offset: 0x002F0896
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x002F26B0 File Offset: 0x002F08B0
		public int GroupMatchList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x002F26F0 File Offset: 0x002F08F0
		public int GroupMatchListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x002F271C File Offset: 0x002F091C
		public Span<int> GetGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x002F272C File Offset: 0x002F092C
		public int[] GetGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x002F2744 File Offset: 0x002F0944
		public int AdvancedDangoIdSourceGroupMatchList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0600BE9E RID: 48798 RVA: 0x002F2784 File Offset: 0x002F0984
		public int AdvancedDangoIdSourceGroupMatchListLength
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

		// Token: 0x0600BE9F RID: 48799 RVA: 0x002F27B0 File Offset: 0x002F09B0
		public Span<int> GetAdvancedDangoIdSourceGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x002F27C0 File Offset: 0x002F09C0
		public int[] GetAdvancedDangoIdSourceGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x002F27D8 File Offset: 0x002F09D8
		public int AdvancedDangoIdTargetGroupMatchList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600BEA2 RID: 48802 RVA: 0x002F2818 File Offset: 0x002F0A18
		public int AdvancedDangoIdTargetGroupMatchListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x002F2844 File Offset: 0x002F0A44
		public Span<int> GetAdvancedDangoIdTargetGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x002F2854 File Offset: 0x002F0A54
		public int[] GetAdvancedDangoIdTargetGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600BEA5 RID: 48805 RVA: 0x002F286C File Offset: 0x002F0A6C
		public int FarewellMatchId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x002F28A9 File Offset: 0x002F0AA9
		[NullableContext(1)]
		public int[] AdvancedDangoIdSourceGroupMatchList()
		{
			return this.GetAdvancedDangoIdSourceGroupMatchListArray();
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x002F28B1 File Offset: 0x002F0AB1
		[NullableContext(1)]
		public IEnumerable<int> AdvancedDangoIdSourceGroupMatchListIter()
		{
			RacingBetsMatch.<AdvancedDangoIdSourceGroupMatchListIter>d__34 <AdvancedDangoIdSourceGroupMatchListIter>d__ = new RacingBetsMatch.<AdvancedDangoIdSourceGroupMatchListIter>d__34(-2);
			<AdvancedDangoIdSourceGroupMatchListIter>d__.<>3__<>4__this = this;
			return <AdvancedDangoIdSourceGroupMatchListIter>d__;
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x002F28C6 File Offset: 0x002F0AC6
		[NullableContext(1)]
		public int[] AdvancedDangoIdTargetGroupMatchList()
		{
			return this.GetAdvancedDangoIdTargetGroupMatchListArray();
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x002F28CE File Offset: 0x002F0ACE
		[NullableContext(1)]
		public IEnumerable<int> AdvancedDangoIdTargetGroupMatchListIter()
		{
			RacingBetsMatch.<AdvancedDangoIdTargetGroupMatchListIter>d__36 <AdvancedDangoIdTargetGroupMatchListIter>d__ = new RacingBetsMatch.<AdvancedDangoIdTargetGroupMatchListIter>d__36(-2);
			<AdvancedDangoIdTargetGroupMatchListIter>d__.<>3__<>4__this = this;
			return <AdvancedDangoIdTargetGroupMatchListIter>d__;
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x002F28E3 File Offset: 0x002F0AE3
		[NullableContext(1)]
		public int[] GroupMatchList()
		{
			return this.GetGroupMatchListArray();
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x002F28EB File Offset: 0x002F0AEB
		[NullableContext(1)]
		public IEnumerable<int> GroupMatchListIter()
		{
			RacingBetsMatch.<GroupMatchListIter>d__38 <GroupMatchListIter>d__ = new RacingBetsMatch.<GroupMatchListIter>d__38(-2);
			<GroupMatchListIter>d__.<>3__<>4__this = this;
			return <GroupMatchListIter>d__;
		}

		// Token: 0x04005642 RID: 22082
		private Table __p;
	}
}
