using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED9 RID: 3801
	public struct MapRange : IFlatbufferObject
	{
		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x060097E6 RID: 38886 RVA: 0x0029E470 File Offset: 0x0029C670
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0029E47D File Offset: 0x0029C67D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0029E484 File Offset: 0x0029C684
		public static MapRange GetRootAsMapRange(ByteBuffer _bb)
		{
			return MapRange.GetRootAsMapRange(_bb, default(MapRange));
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x0029E4A0 File Offset: 0x0029C6A0
		public static MapRange GetRootAsMapRange(ByteBuffer _bb, MapRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x0029E4BD File Offset: 0x0029C6BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x0029E4CC File Offset: 0x0029C6CC
		public MapRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x060097EC RID: 38892 RVA: 0x0029E4DC File Offset: 0x0029C6DC
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x060097ED RID: 38893 RVA: 0x0029E518 File Offset: 0x0029C718
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x060097EE RID: 38894 RVA: 0x0029E554 File Offset: 0x0029C754
		public string MapName
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

		// Token: 0x060097EF RID: 38895 RVA: 0x0029E58B File Offset: 0x0029C78B
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x0029E59A File Offset: 0x0029C79A
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x0029E5B4 File Offset: 0x0029C7B4
		public int AreaRange(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x060097F2 RID: 38898 RVA: 0x0029E5F4 File Offset: 0x0029C7F4
		public int AreaRangeLength
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

		// Token: 0x060097F3 RID: 38899 RVA: 0x0029E620 File Offset: 0x0029C820
		public Span<int> GetAreaRangeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x0029E630 File Offset: 0x0029C830
		public int[] GetAreaRangeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x0029E648 File Offset: 0x0029C848
		[NullableContext(1)]
		public int[] AreaRange()
		{
			return this.GetAreaRangeArray();
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x0029E650 File Offset: 0x0029C850
		[NullableContext(1)]
		public IEnumerable<int> AreaRangeIter()
		{
			MapRange.<AreaRangeIter>d__22 <AreaRangeIter>d__ = new MapRange.<AreaRangeIter>d__22(-2);
			<AreaRangeIter>d__.<>3__<>4__this = this;
			return <AreaRangeIter>d__;
		}

		// Token: 0x04005477 RID: 21623
		private Table __p;
	}
}
