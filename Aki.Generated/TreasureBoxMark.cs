using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AC RID: 4780
	public struct TreasureBoxMark : IFlatbufferObject
	{
		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x0600F2AD RID: 62125 RVA: 0x0036734A File Offset: 0x0036554A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F2AE RID: 62126 RVA: 0x00367357 File Offset: 0x00365557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x00367360 File Offset: 0x00365560
		public static TreasureBoxMark GetRootAsTreasureBoxMark(ByteBuffer _bb)
		{
			return TreasureBoxMark.GetRootAsTreasureBoxMark(_bb, default(TreasureBoxMark));
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x0036737C File Offset: 0x0036557C
		public static TreasureBoxMark GetRootAsTreasureBoxMark(ByteBuffer _bb, TreasureBoxMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x00367399 File Offset: 0x00365599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x003673A8 File Offset: 0x003655A8
		public TreasureBoxMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x0600F2B3 RID: 62131 RVA: 0x003673B8 File Offset: 0x003655B8
		public int MarkId
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

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x0600F2B4 RID: 62132 RVA: 0x003673F4 File Offset: 0x003655F4
		public string MarkPic
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x0036742B File Offset: 0x0036562B
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x0036743A File Offset: 0x0036563A
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x0600F2B7 RID: 62135 RVA: 0x00367454 File Offset: 0x00365654
		public string MarkTitle
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

		// Token: 0x0600F2B8 RID: 62136 RVA: 0x0036748B File Offset: 0x0036568B
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F2B9 RID: 62137 RVA: 0x0036749A File Offset: 0x0036569A
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x003674B4 File Offset: 0x003656B4
		public string MarkDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F2BB RID: 62139 RVA: 0x003674EC File Offset: 0x003656EC
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F2BC RID: 62140 RVA: 0x003674FC File Offset: 0x003656FC
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x0600F2BD RID: 62141 RVA: 0x00367514 File Offset: 0x00365714
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x00367554 File Offset: 0x00365754
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0600F2BF RID: 62143 RVA: 0x00367594 File Offset: 0x00365794
		public int ShowRangeLength
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

		// Token: 0x0600F2C0 RID: 62144 RVA: 0x003675C0 File Offset: 0x003657C0
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600F2C1 RID: 62145 RVA: 0x003675D0 File Offset: 0x003657D0
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x0600F2C2 RID: 62146 RVA: 0x003675E8 File Offset: 0x003657E8
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F2C3 RID: 62147 RVA: 0x00367629 File Offset: 0x00365829
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600F2C4 RID: 62148 RVA: 0x00367631 File Offset: 0x00365831
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			TreasureBoxMark.<ShowRangeIter>d__32 <ShowRangeIter>d__ = new TreasureBoxMark.<ShowRangeIter>d__32(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x040058FF RID: 22783
		private Table __p;
	}
}
