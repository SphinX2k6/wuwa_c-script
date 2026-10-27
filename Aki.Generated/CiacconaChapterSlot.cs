using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B76 RID: 2934
	public struct CiacconaChapterSlot : IFlatbufferObject
	{
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x001F511C File Offset: 0x001F331C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x001F5129 File Offset: 0x001F3329
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x001F5130 File Offset: 0x001F3330
		public static CiacconaChapterSlot GetRootAsCiacconaChapterSlot(ByteBuffer _bb)
		{
			return CiacconaChapterSlot.GetRootAsCiacconaChapterSlot(_bb, default(CiacconaChapterSlot));
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x001F514C File Offset: 0x001F334C
		public static CiacconaChapterSlot GetRootAsCiacconaChapterSlot(ByteBuffer _bb, CiacconaChapterSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x001F5169 File Offset: 0x001F3369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x001F5178 File Offset: 0x001F3378
		public CiacconaChapterSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x001F5188 File Offset: 0x001F3388
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x001F51C4 File Offset: 0x001F33C4
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

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x001F5200 File Offset: 0x001F3400
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

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x001F523C File Offset: 0x001F343C
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

		// Token: 0x0600551F RID: 21791 RVA: 0x001F5274 File Offset: 0x001F3474
		public Span<byte> GetSlotImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x001F5284 File Offset: 0x001F3484
		public byte[] GetSlotImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x001F529C File Offset: 0x001F349C
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

		// Token: 0x06005522 RID: 21794 RVA: 0x001F52D4 File Offset: 0x001F34D4
		public Span<byte> GetSlotLockImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x001F52E4 File Offset: 0x001F34E4
		public byte[] GetSlotLockImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06005524 RID: 21796 RVA: 0x001F52FC File Offset: 0x001F34FC
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

		// Token: 0x06005525 RID: 21797 RVA: 0x001F5334 File Offset: 0x001F3534
		public Span<byte> GetRomanNumberIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x001F5344 File Offset: 0x001F3544
		public byte[] GetRomanNumberIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B7A RID: 19322
		private Table __p;
	}
}
