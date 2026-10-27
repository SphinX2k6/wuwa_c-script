using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106C RID: 4204
	public struct RougeMiraclecreationColor : IFlatbufferObject
	{
		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600CC34 RID: 52276 RVA: 0x003026ED File Offset: 0x003008ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x003026FA File Offset: 0x003008FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x00302704 File Offset: 0x00300904
		public static RougeMiraclecreationColor GetRootAsRougeMiraclecreationColor(ByteBuffer _bb)
		{
			return RougeMiraclecreationColor.GetRootAsRougeMiraclecreationColor(_bb, default(RougeMiraclecreationColor));
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x00302720 File Offset: 0x00300920
		public static RougeMiraclecreationColor GetRootAsRougeMiraclecreationColor(ByteBuffer _bb, RougeMiraclecreationColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x0030273D File Offset: 0x0030093D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x0030274C File Offset: 0x0030094C
		public RougeMiraclecreationColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600CC3A RID: 52282 RVA: 0x0030275C File Offset: 0x0030095C
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

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600CC3B RID: 52283 RVA: 0x00302798 File Offset: 0x00300998
		public string NiaColor
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

		// Token: 0x0600CC3C RID: 52284 RVA: 0x003027CF File Offset: 0x003009CF
		public Span<byte> GetNiaColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x003027DE File Offset: 0x003009DE
		public byte[] GetNiaColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x003027F8 File Offset: 0x003009F8
		public string NiaNorColor
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

		// Token: 0x0600CC3F RID: 52287 RVA: 0x0030282F File Offset: 0x00300A2F
		public Span<byte> GetNiaNorColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x0030283E File Offset: 0x00300A3E
		public byte[] GetNiaNorColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600CC41 RID: 52289 RVA: 0x00302858 File Offset: 0x00300A58
		public string NiaSelectColor
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

		// Token: 0x0600CC42 RID: 52290 RVA: 0x00302890 File Offset: 0x00300A90
		public Span<byte> GetNiaSelectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CC43 RID: 52291 RVA: 0x003028A0 File Offset: 0x00300AA0
		public byte[] GetNiaSelectColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x003028B8 File Offset: 0x00300AB8
		public string NiaSelect1Color
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

		// Token: 0x0600CC45 RID: 52293 RVA: 0x003028F0 File Offset: 0x00300AF0
		public Span<byte> GetNiaSelect1ColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x00302900 File Offset: 0x00300B00
		public byte[] GetNiaSelect1ColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600CC47 RID: 52295 RVA: 0x00302918 File Offset: 0x00300B18
		public string SmallBg
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

		// Token: 0x0600CC48 RID: 52296 RVA: 0x00302950 File Offset: 0x00300B50
		public Span<byte> GetSmallBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x00302960 File Offset: 0x00300B60
		public byte[] GetSmallBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00302978 File Offset: 0x00300B78
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005171 RID: 20849
		private Table __p;
	}
}
