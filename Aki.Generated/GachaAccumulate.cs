using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC1 RID: 3521
	public struct GachaAccumulate : IFlatbufferObject
	{
		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x00264341 File Offset: 0x00262541
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x0026434E File Offset: 0x0026254E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x00264358 File Offset: 0x00262558
		public static GachaAccumulate GetRootAsGachaAccumulate(ByteBuffer _bb)
		{
			return GachaAccumulate.GetRootAsGachaAccumulate(_bb, default(GachaAccumulate));
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00264374 File Offset: 0x00262574
		public static GachaAccumulate GetRootAsGachaAccumulate(ByteBuffer _bb, GachaAccumulate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x00264391 File Offset: 0x00262591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x002643A0 File Offset: 0x002625A0
		public GachaAccumulate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x002643B0 File Offset: 0x002625B0
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

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x002643EC File Offset: 0x002625EC
		public string TipsPrefabPath
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

		// Token: 0x06007E05 RID: 32261 RVA: 0x00264423 File Offset: 0x00262623
		public Span<byte> GetTipsPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x00264432 File Offset: 0x00262632
		public byte[] GetTipsPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x0026444C File Offset: 0x0026264C
		public string GachaAccumulatePrefabPath
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

		// Token: 0x06007E08 RID: 32264 RVA: 0x00264483 File Offset: 0x00262683
		public Span<byte> GetGachaAccumulatePrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x00264492 File Offset: 0x00262692
		public byte[] GetGachaAccumulatePrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06007E0A RID: 32266 RVA: 0x002644AC File Offset: 0x002626AC
		public int ShowType
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

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x002644EC File Offset: 0x002626EC
		public int HelpId
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

		// Token: 0x04005332 RID: 21298
		private Table __p;
	}
}
