using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8D RID: 2957
	public struct AbyssRoute : IFlatbufferObject
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x001E7F70 File Offset: 0x001E6170
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x001E7F7D File Offset: 0x001E617D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x001E7F84 File Offset: 0x001E6184
		public static AbyssRoute GetRootAsAbyssRoute(ByteBuffer _bb)
		{
			return AbyssRoute.GetRootAsAbyssRoute(_bb, default(AbyssRoute));
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x001E7FA0 File Offset: 0x001E61A0
		public static AbyssRoute GetRootAsAbyssRoute(ByteBuffer _bb, AbyssRoute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x001E7FBD File Offset: 0x001E61BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001E7FCC File Offset: 0x001E61CC
		public AbyssRoute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x001E7FDC File Offset: 0x001E61DC
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
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x001E8018 File Offset: 0x001E6218
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
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x001E8054 File Offset: 0x001E6254
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
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x001E8090 File Offset: 0x001E6290
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
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x001E80D0 File Offset: 0x001E62D0
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

		// Token: 0x06004700 RID: 18176 RVA: 0x001E8108 File Offset: 0x001E6308
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x001E8118 File Offset: 0x001E6318
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005062 RID: 20578
		private Table __p;
	}
}
