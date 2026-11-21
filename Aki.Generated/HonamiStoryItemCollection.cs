using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1D RID: 3613
	public struct HonamiStoryItemCollection : IFlatbufferObject
	{
		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x060085D4 RID: 34260 RVA: 0x00275891 File Offset: 0x00273A91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x0027589E File Offset: 0x00273A9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x002758A8 File Offset: 0x00273AA8
		public static HonamiStoryItemCollection GetRootAsHonamiStoryItemCollection(ByteBuffer _bb)
		{
			return HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(_bb, default(HonamiStoryItemCollection));
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x002758C4 File Offset: 0x00273AC4
		public static HonamiStoryItemCollection GetRootAsHonamiStoryItemCollection(ByteBuffer _bb, HonamiStoryItemCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x002758E1 File Offset: 0x00273AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x002758F0 File Offset: 0x00273AF0
		public HonamiStoryItemCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x060085DA RID: 34266 RVA: 0x00275900 File Offset: 0x00273B00
		public int ItemId
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

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x060085DB RID: 34267 RVA: 0x0027593C File Offset: 0x00273B3C
		public int ActivityId
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

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x00275978 File Offset: 0x00273B78
		public int DropId
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

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x002759B4 File Offset: 0x00273BB4
		public string DropNum
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

		// Token: 0x060085DE RID: 34270 RVA: 0x002759EC File Offset: 0x00273BEC
		public Span<byte> GetDropNumBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x002759FC File Offset: 0x00273BFC
		public byte[] GetDropNumArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x060085E0 RID: 34272 RVA: 0x00275A14 File Offset: 0x00273C14
		public string Name
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

		// Token: 0x060085E1 RID: 34273 RVA: 0x00275A4C File Offset: 0x00273C4C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x00275A5C File Offset: 0x00273C5C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x00275A74 File Offset: 0x00273C74
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085E4 RID: 34276 RVA: 0x00275AAC File Offset: 0x00273CAC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x00275ABC File Offset: 0x00273CBC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x00275AD4 File Offset: 0x00273CD4
		public string Access
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

		// Token: 0x060085E7 RID: 34279 RVA: 0x00275B0C File Offset: 0x00273D0C
		public Span<byte> GetAccessBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00275B1C File Offset: 0x00273D1C
		public byte[] GetAccessArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x060085E9 RID: 34281 RVA: 0x00275B34 File Offset: 0x00273D34
		public string Icon
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

		// Token: 0x060085EA RID: 34282 RVA: 0x00275B6C File Offset: 0x00273D6C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x00275B7C File Offset: 0x00273D7C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005397 RID: 21399
		private Table __p;
	}
}
