using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF3 RID: 3059
	public struct AvgTalkerConfig : IFlatbufferObject
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x001FAC68 File Offset: 0x001F8E68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x001FAC75 File Offset: 0x001F8E75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x001FAC7C File Offset: 0x001F8E7C
		public static AvgTalkerConfig GetRootAsAvgTalkerConfig(ByteBuffer _bb)
		{
			return AvgTalkerConfig.GetRootAsAvgTalkerConfig(_bb, default(AvgTalkerConfig));
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x001FAC98 File Offset: 0x001F8E98
		public static AvgTalkerConfig GetRootAsAvgTalkerConfig(ByteBuffer _bb, AvgTalkerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x001FACB5 File Offset: 0x001F8EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x001FACC4 File Offset: 0x001F8EC4
		public AvgTalkerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x001FACD4 File Offset: 0x001F8ED4
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x001FAD10 File Offset: 0x001F8F10
		public string Name
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

		// Token: 0x06004F88 RID: 20360 RVA: 0x001FAD47 File Offset: 0x001F8F47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x001FAD56 File Offset: 0x001F8F56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x001FAD70 File Offset: 0x001F8F70
		public bool IsGroup
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x001FADB0 File Offset: 0x001F8FB0
		public string Interjections
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

		// Token: 0x06004F8C RID: 20364 RVA: 0x001FADE8 File Offset: 0x001F8FE8
		public Span<byte> GetInterjectionsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x001FADF8 File Offset: 0x001F8FF8
		public byte[] GetInterjectionsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x001FAE10 File Offset: 0x001F9010
		public string SpineAtlas
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

		// Token: 0x06004F8F RID: 20367 RVA: 0x001FAE48 File Offset: 0x001F9048
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x001FAE58 File Offset: 0x001F9058
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x001FAE70 File Offset: 0x001F9070
		public string SpineSkeletonData
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

		// Token: 0x06004F92 RID: 20370 RVA: 0x001FAEA8 File Offset: 0x001F90A8
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x001FAEB8 File Offset: 0x001F90B8
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x001FAED0 File Offset: 0x001F90D0
		public string SolarSchoolSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x001FAF08 File Offset: 0x001F9108
		public Span<byte> GetSolarSchoolSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x001FAF18 File Offset: 0x001F9118
		public byte[] GetSolarSchoolSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06004F97 RID: 20375 RVA: 0x001FAF30 File Offset: 0x001F9130
		public string SolarSchoolSpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x001FAF68 File Offset: 0x001F9168
		public Span<byte> GetSolarSchoolSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x001FAF78 File Offset: 0x001F9178
		public byte[] GetSolarSchoolSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x001FAF90 File Offset: 0x001F9190
		public int SolarSchoolDefaultExpressionId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x001FAFD0 File Offset: 0x001F91D0
		public string SolarSchoolPortraitTexture
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x001FB008 File Offset: 0x001F9208
		public Span<byte> GetSolarSchoolPortraitTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x001FB018 File Offset: 0x001F9218
		public byte[] GetSolarSchoolPortraitTextureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x001FB030 File Offset: 0x001F9230
		public string SolarSchoolPortraitTransform
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x001FB068 File Offset: 0x001F9268
		public Span<byte> GetSolarSchoolPortraitTransformBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x001FB078 File Offset: 0x001F9278
		public byte[] GetSolarSchoolPortraitTransformArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x001FB090 File Offset: 0x001F9290
		public string SolarSchoolHeadIconTransform
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x001FB0C8 File Offset: 0x001F92C8
		public Span<byte> GetSolarSchoolHeadIconTransformBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x001FB0D8 File Offset: 0x001F92D8
		public byte[] GetSolarSchoolHeadIconTransformArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x040050DB RID: 20699
		private Table __p;
	}
}
