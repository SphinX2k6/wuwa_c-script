using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEE RID: 3054
	public struct AvgCg : IFlatbufferObject
	{
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x001FA248 File Offset: 0x001F8448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x001FA255 File Offset: 0x001F8455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x001FA25C File Offset: 0x001F845C
		public static AvgCg GetRootAsAvgCg(ByteBuffer _bb)
		{
			return AvgCg.GetRootAsAvgCg(_bb, default(AvgCg));
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x001FA278 File Offset: 0x001F8478
		public static AvgCg GetRootAsAvgCg(ByteBuffer _bb, AvgCg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x001FA295 File Offset: 0x001F8495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x001FA2A4 File Offset: 0x001F84A4
		public AvgCg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06004F2E RID: 20270 RVA: 0x001FA2B4 File Offset: 0x001F84B4
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x001FA2F0 File Offset: 0x001F84F0
		public string Description
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

		// Token: 0x06004F30 RID: 20272 RVA: 0x001FA327 File Offset: 0x001F8527
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x001FA336 File Offset: 0x001F8536
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x001FA350 File Offset: 0x001F8550
		public string Level
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

		// Token: 0x06004F33 RID: 20275 RVA: 0x001FA387 File Offset: 0x001F8587
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x001FA396 File Offset: 0x001F8596
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x001FA3B0 File Offset: 0x001F85B0
		public string Data
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

		// Token: 0x06004F36 RID: 20278 RVA: 0x001FA3E8 File Offset: 0x001F85E8
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x001FA3F8 File Offset: 0x001F85F8
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D6 RID: 20694
		private Table __p;
	}
}
