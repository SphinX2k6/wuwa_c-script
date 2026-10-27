using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB8 RID: 2744
	public struct AbyssRoute : IFlatbufferObject
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x001C8D10 File Offset: 0x001C6F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x001C8D1D File Offset: 0x001C6F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x001C8D24 File Offset: 0x001C6F24
		public static AbyssRoute GetRootAsAbyssRoute(ByteBuffer _bb)
		{
			return AbyssRoute.GetRootAsAbyssRoute(_bb, default(AbyssRoute));
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x001C8D40 File Offset: 0x001C6F40
		public static AbyssRoute GetRootAsAbyssRoute(ByteBuffer _bb, AbyssRoute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x001C8D5D File Offset: 0x001C6F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x001C8D6C File Offset: 0x001C6F6C
		public AbyssRoute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x001C8D7C File Offset: 0x001C6F7C
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x001C8DB8 File Offset: 0x001C6FB8
		public int RouteId
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x001C8DF4 File Offset: 0x001C6FF4
		public int Floor
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x001C8E30 File Offset: 0x001C7030
		public int MonsterRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x001C8E70 File Offset: 0x001C7070
		public string Desc
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

		// Token: 0x06004202 RID: 16898 RVA: 0x001C8EA8 File Offset: 0x001C70A8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x001C8EB8 File Offset: 0x001C70B8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A8F RID: 19087
		private Table __p;
	}
}
