using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C57 RID: 3159
	public struct CiacconaChapterSlot : IFlatbufferObject
	{
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06005AE3 RID: 23267 RVA: 0x00214F2C File Offset: 0x0021312C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00214F39 File Offset: 0x00213139
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00214F40 File Offset: 0x00213140
		public static CiacconaChapterSlot GetRootAsCiacconaChapterSlot(ByteBuffer _bb)
		{
			return CiacconaChapterSlot.GetRootAsCiacconaChapterSlot(_bb, default(CiacconaChapterSlot));
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00214F5C File Offset: 0x0021315C
		public static CiacconaChapterSlot GetRootAsCiacconaChapterSlot(ByteBuffer _bb, CiacconaChapterSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00214F79 File Offset: 0x00213179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00214F88 File Offset: 0x00213188
		public CiacconaChapterSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06005AE9 RID: 23273 RVA: 0x00214F98 File Offset: 0x00213198
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

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x00214FD4 File Offset: 0x002131D4
		public int ChapterId
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

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x00215010 File Offset: 0x00213210
		public int UnlockCondition
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06005AEC RID: 23276 RVA: 0x0021504C File Offset: 0x0021324C
		public string SlotImage
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

		// Token: 0x06005AED RID: 23277 RVA: 0x00215084 File Offset: 0x00213284
		public Span<byte> GetSlotImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00215094 File Offset: 0x00213294
		public byte[] GetSlotImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x002150AC File Offset: 0x002132AC
		public string SlotLockImage
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

		// Token: 0x06005AF0 RID: 23280 RVA: 0x002150E4 File Offset: 0x002132E4
		public Span<byte> GetSlotLockImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x002150F4 File Offset: 0x002132F4
		public byte[] GetSlotLockImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x0021510C File Offset: 0x0021330C
		public string RomanNumberIcon
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

		// Token: 0x06005AF3 RID: 23283 RVA: 0x00215144 File Offset: 0x00213344
		public Span<byte> GetRomanNumberIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x00215154 File Offset: 0x00213354
		public byte[] GetRomanNumberIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400515B RID: 20827
		private Table __p;
	}
}
