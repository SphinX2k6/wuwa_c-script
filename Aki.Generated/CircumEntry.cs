using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C60 RID: 3168
	public struct CircumEntry : IFlatbufferObject
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06005BA7 RID: 23463 RVA: 0x00216835 File Offset: 0x00214A35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x00216842 File Offset: 0x00214A42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0021684C File Offset: 0x00214A4C
		public static CircumEntry GetRootAsCircumEntry(ByteBuffer _bb)
		{
			return CircumEntry.GetRootAsCircumEntry(_bb, default(CircumEntry));
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00216868 File Offset: 0x00214A68
		public static CircumEntry GetRootAsCircumEntry(ByteBuffer _bb, CircumEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00216885 File Offset: 0x00214A85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00216894 File Offset: 0x00214A94
		public CircumEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x002168A4 File Offset: 0x00214AA4
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x002168E0 File Offset: 0x00214AE0
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x0021691C File Offset: 0x00214B1C
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

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00216953 File Offset: 0x00214B53
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00216962 File Offset: 0x00214B62
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x0021697C File Offset: 0x00214B7C
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

		// Token: 0x06005BB3 RID: 23475 RVA: 0x002169B4 File Offset: 0x00214BB4
		public Span<byte> GetIconPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x002169C4 File Offset: 0x00214BC4
		public byte[] GetIconPathFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06005BB5 RID: 23477 RVA: 0x002169DC File Offset: 0x00214BDC
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

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00216A14 File Offset: 0x00214C14
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00216A24 File Offset: 0x00214C24
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x00216A3C File Offset: 0x00214C3C
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

		// Token: 0x04005164 RID: 20836
		private Table __p;
	}
}
