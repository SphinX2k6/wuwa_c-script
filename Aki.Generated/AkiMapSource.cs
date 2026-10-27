using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFA RID: 2810
	public struct AkiMapSource : IFlatbufferObject
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060047A0 RID: 18336 RVA: 0x001D58ED File Offset: 0x001D3AED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x001D58FA File Offset: 0x001D3AFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x001D5904 File Offset: 0x001D3B04
		public static AkiMapSource GetRootAsAkiMapSource(ByteBuffer _bb)
		{
			return AkiMapSource.GetRootAsAkiMapSource(_bb, default(AkiMapSource));
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x001D5920 File Offset: 0x001D3B20
		public static AkiMapSource GetRootAsAkiMapSource(ByteBuffer _bb, AkiMapSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x001D593D File Offset: 0x001D3B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x001D594C File Offset: 0x001D3B4C
		public AkiMapSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x001D595C File Offset: 0x001D3B5C
		public int MapId
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x001D5998 File Offset: 0x001D3B98
		public int PakRule
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x001D59D4 File Offset: 0x001D3BD4
		public string MapPath
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

		// Token: 0x060047A9 RID: 18345 RVA: 0x001D5A0B File Offset: 0x001D3C0B
		public Span<byte> GetMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x001D5A1A File Offset: 0x001D3C1A
		public byte[] GetMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x001D5A34 File Offset: 0x001D3C34
		public int LoadMapMode
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x001D5A74 File Offset: 0x001D3C74
		public int IgnoreWorldOrigin
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004ADB RID: 19163
		private Table __p;
	}
}
