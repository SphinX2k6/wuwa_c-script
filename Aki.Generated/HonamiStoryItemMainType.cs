using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1E RID: 3614
	public struct HonamiStoryItemMainType : IFlatbufferObject
	{
		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x060085EC RID: 34284 RVA: 0x00275B94 File Offset: 0x00273D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x00275BA1 File Offset: 0x00273DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x00275BA8 File Offset: 0x00273DA8
		public static HonamiStoryItemMainType GetRootAsHonamiStoryItemMainType(ByteBuffer _bb)
		{
			return HonamiStoryItemMainType.GetRootAsHonamiStoryItemMainType(_bb, default(HonamiStoryItemMainType));
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x00275BC4 File Offset: 0x00273DC4
		public static HonamiStoryItemMainType GetRootAsHonamiStoryItemMainType(ByteBuffer _bb, HonamiStoryItemMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x00275BE1 File Offset: 0x00273DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x00275BF0 File Offset: 0x00273DF0
		public HonamiStoryItemMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x060085F2 RID: 34290 RVA: 0x00275C00 File Offset: 0x00273E00
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

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x060085F3 RID: 34291 RVA: 0x00275C3C File Offset: 0x00273E3C
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

		// Token: 0x060085F4 RID: 34292 RVA: 0x00275C73 File Offset: 0x00273E73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x00275C82 File Offset: 0x00273E82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005398 RID: 21400
		private Table __p;
	}
}
