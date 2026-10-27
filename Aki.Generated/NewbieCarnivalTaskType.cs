using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7F RID: 3711
	public struct NewbieCarnivalTaskType : IFlatbufferObject
	{
		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0029BD35 File Offset: 0x00299F35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x0029BD42 File Offset: 0x00299F42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x0029BD4C File Offset: 0x00299F4C
		public static NewbieCarnivalTaskType GetRootAsNewbieCarnivalTaskType(ByteBuffer _bb)
		{
			return NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(_bb, default(NewbieCarnivalTaskType));
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x0029BD68 File Offset: 0x00299F68
		public static NewbieCarnivalTaskType GetRootAsNewbieCarnivalTaskType(ByteBuffer _bb, NewbieCarnivalTaskType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x0029BD85 File Offset: 0x00299F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x0029BD94 File Offset: 0x00299F94
		public NewbieCarnivalTaskType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06009E47 RID: 40519 RVA: 0x0029BDA4 File Offset: 0x00299FA4
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

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06009E48 RID: 40520 RVA: 0x0029BDE0 File Offset: 0x00299FE0
		public string IconTexture
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

		// Token: 0x06009E49 RID: 40521 RVA: 0x0029BE17 File Offset: 0x0029A017
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x0029BE26 File Offset: 0x0029A026
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x0029BE40 File Offset: 0x0029A040
		public string LeftTexture
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

		// Token: 0x06009E4C RID: 40524 RVA: 0x0029BE77 File Offset: 0x0029A077
		public Span<byte> GetLeftTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x0029BE86 File Offset: 0x0029A086
		public byte[] GetLeftTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06009E4E RID: 40526 RVA: 0x0029BEA0 File Offset: 0x0029A0A0
		public string Title
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

		// Token: 0x06009E4F RID: 40527 RVA: 0x0029BED8 File Offset: 0x0029A0D8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x0029BEE8 File Offset: 0x0029A0E8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F2D RID: 20269
		private Table __p;
	}
}
