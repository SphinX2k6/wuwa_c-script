using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEC RID: 3564
	public struct MapFog : IFlatbufferObject
	{
		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x060090DD RID: 37085 RVA: 0x0027DDF6 File Offset: 0x0027BFF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x0027DE03 File Offset: 0x0027C003
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x0027DE0C File Offset: 0x0027C00C
		public static MapFog GetRootAsMapFog(ByteBuffer _bb)
		{
			return MapFog.GetRootAsMapFog(_bb, default(MapFog));
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x0027DE28 File Offset: 0x0027C028
		public static MapFog GetRootAsMapFog(ByteBuffer _bb, MapFog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0027DE45 File Offset: 0x0027C045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x0027DE54 File Offset: 0x0027C054
		public MapFog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x060090E3 RID: 37091 RVA: 0x0027DE64 File Offset: 0x0027C064
		public int Fog
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

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x060090E4 RID: 37092 RVA: 0x0027DEA0 File Offset: 0x0027C0A0
		public int MapId
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

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x060090E5 RID: 37093 RVA: 0x0027DEDC File Offset: 0x0027C0DC
		public int AreaId
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

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x060090E6 RID: 37094 RVA: 0x0027DF18 File Offset: 0x0027C118
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x060090E7 RID: 37095 RVA: 0x0027DF58 File Offset: 0x0027C158
		public int UnlockCondition
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

		// Token: 0x060090E8 RID: 37096 RVA: 0x0027DF98 File Offset: 0x0027C198
		public int FogUnlockPosition(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x060090E9 RID: 37097 RVA: 0x0027DFD8 File Offset: 0x0027C1D8
		public int FogUnlockPositionLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x0027E004 File Offset: 0x0027C204
		public Span<int> GetFogUnlockPositionBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060090EB RID: 37099 RVA: 0x0027E014 File Offset: 0x0027C214
		public int[] GetFogUnlockPositionArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x0027E02C File Offset: 0x0027C22C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FogUnlockPositionIter()或GetFogUnlockPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FogUnlockPosition()
		{
			MapFog mapFog = this;
			return mapFog.GetFogUnlockPositionArray() ?? Array.Empty<int>();
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x0027E050 File Offset: 0x0027C250
		[NullableContext(1)]
		public readonly IEnumerable<int> FogUnlockPositionIter()
		{
			MapFog.<FogUnlockPositionIter>d__24 <FogUnlockPositionIter>d__ = new MapFog.<FogUnlockPositionIter>d__24(-2);
			<FogUnlockPositionIter>d__.<>3__<>4__this = this;
			return <FogUnlockPositionIter>d__;
		}

		// Token: 0x04004E88 RID: 20104
		private Table __p;
	}
}
