using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B13 RID: 2835
	public struct AvgTalkerConfig : IFlatbufferObject
	{
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x001DA968 File Offset: 0x001D8B68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x001DA975 File Offset: 0x001D8B75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x001DA97C File Offset: 0x001D8B7C
		public static AvgTalkerConfig GetRootAsAvgTalkerConfig(ByteBuffer _bb)
		{
			return AvgTalkerConfig.GetRootAsAvgTalkerConfig(_bb, default(AvgTalkerConfig));
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x001DA998 File Offset: 0x001D8B98
		public static AvgTalkerConfig GetRootAsAvgTalkerConfig(ByteBuffer _bb, AvgTalkerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x001DA9B5 File Offset: 0x001D8BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x001DA9C4 File Offset: 0x001D8BC4
		public AvgTalkerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x001DA9D4 File Offset: 0x001D8BD4
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x001DAA10 File Offset: 0x001D8C10
		public string Name
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

		// Token: 0x060049D9 RID: 18905 RVA: 0x001DAA47 File Offset: 0x001D8C47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x001DAA56 File Offset: 0x001D8C56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060049DB RID: 18907 RVA: 0x001DAA70 File Offset: 0x001D8C70
		public bool IsGroup
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x001DAAB0 File Offset: 0x001D8CB0
		public string SpineAtlas
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

		// Token: 0x060049DD RID: 18909 RVA: 0x001DAAE8 File Offset: 0x001D8CE8
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001DAAF8 File Offset: 0x001D8CF8
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060049DF RID: 18911 RVA: 0x001DAB10 File Offset: 0x001D8D10
		public string SpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x001DAB48 File Offset: 0x001D8D48
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x001DAB58 File Offset: 0x001D8D58
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AFB RID: 19195
		private Table __p;
	}
}
