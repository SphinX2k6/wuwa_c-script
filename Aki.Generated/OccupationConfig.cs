using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9F RID: 3743
	public struct OccupationConfig : IFlatbufferObject
	{
		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600A10F RID: 41231 RVA: 0x002A1FF5 File Offset: 0x002A01F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x002A2002 File Offset: 0x002A0202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x002A200C File Offset: 0x002A020C
		public static OccupationConfig GetRootAsOccupationConfig(ByteBuffer _bb)
		{
			return OccupationConfig.GetRootAsOccupationConfig(_bb, default(OccupationConfig));
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x002A2028 File Offset: 0x002A0228
		public static OccupationConfig GetRootAsOccupationConfig(ByteBuffer _bb, OccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x002A2045 File Offset: 0x002A0245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x002A2054 File Offset: 0x002A0254
		public OccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600A115 RID: 41237 RVA: 0x002A2064 File Offset: 0x002A0264
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x002A209B File Offset: 0x002A029B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x002A20AA File Offset: 0x002A02AA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x002A20C4 File Offset: 0x002A02C4
		public string OccupationType
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

		// Token: 0x0600A119 RID: 41241 RVA: 0x002A20FB File Offset: 0x002A02FB
		public Span<byte> GetOccupationTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x002A210A File Offset: 0x002A030A
		public byte[] GetOccupationTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600A11B RID: 41243 RVA: 0x002A2124 File Offset: 0x002A0324
		public int NameStringKey
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

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x002A2160 File Offset: 0x002A0360
		public int Name
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

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600A11D RID: 41245 RVA: 0x002A21A0 File Offset: 0x002A03A0
		public string OccupationData
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

		// Token: 0x0600A11E RID: 41246 RVA: 0x002A21D8 File Offset: 0x002A03D8
		public Span<byte> GetOccupationDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x002A21E8 File Offset: 0x002A03E8
		public byte[] GetOccupationDataArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F53 RID: 20307
		private Table __p;
	}
}
