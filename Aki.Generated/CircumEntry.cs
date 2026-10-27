using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7F RID: 2943
	public struct CircumEntry : IFlatbufferObject
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x001F6A7D File Offset: 0x001F4C7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x001F6A8A File Offset: 0x001F4C8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x001F6A94 File Offset: 0x001F4C94
		public static CircumEntry GetRootAsCircumEntry(ByteBuffer _bb)
		{
			return CircumEntry.GetRootAsCircumEntry(_bb, default(CircumEntry));
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x001F6AB0 File Offset: 0x001F4CB0
		public static CircumEntry GetRootAsCircumEntry(ByteBuffer _bb, CircumEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x001F6ACD File Offset: 0x001F4CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x001F6ADC File Offset: 0x001F4CDC
		public CircumEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x001F6AEC File Offset: 0x001F4CEC
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x001F6B28 File Offset: 0x001F4D28
		public int EntryType
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060055E1 RID: 21985 RVA: 0x001F6B64 File Offset: 0x001F4D64
		public string Title
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

		// Token: 0x060055E2 RID: 21986 RVA: 0x001F6B9B File Offset: 0x001F4D9B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x001F6BAA File Offset: 0x001F4DAA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x001F6BC4 File Offset: 0x001F4DC4
		public string IconPathF
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

		// Token: 0x060055E5 RID: 21989 RVA: 0x001F6BFC File Offset: 0x001F4DFC
		public Span<byte> GetIconPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x001F6C0C File Offset: 0x001F4E0C
		public byte[] GetIconPathFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060055E7 RID: 21991 RVA: 0x001F6C24 File Offset: 0x001F4E24
		public string IconPath
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

		// Token: 0x060055E8 RID: 21992 RVA: 0x001F6C5C File Offset: 0x001F4E5C
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x001F6C6C File Offset: 0x001F4E6C
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060055EA RID: 21994 RVA: 0x001F6C84 File Offset: 0x001F4E84
		public int GachaId
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

		// Token: 0x04004B83 RID: 19331
		private Table __p;
	}
}
