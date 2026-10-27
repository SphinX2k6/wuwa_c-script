using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4E RID: 3662
	public struct MotorFightSubLevel : IFlatbufferObject
	{
		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06009949 RID: 39241 RVA: 0x00290EC6 File Offset: 0x0028F0C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x00290ED3 File Offset: 0x0028F0D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00290EDC File Offset: 0x0028F0DC
		public static MotorFightSubLevel GetRootAsMotorFightSubLevel(ByteBuffer _bb)
		{
			return MotorFightSubLevel.GetRootAsMotorFightSubLevel(_bb, default(MotorFightSubLevel));
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00290EF8 File Offset: 0x0028F0F8
		public static MotorFightSubLevel GetRootAsMotorFightSubLevel(ByteBuffer _bb, MotorFightSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00290F15 File Offset: 0x0028F115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x00290F24 File Offset: 0x0028F124
		public MotorFightSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600994F RID: 39247 RVA: 0x00290F34 File Offset: 0x0028F134
		public int SubLevelId
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

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x00290F70 File Offset: 0x0028F170
		public int SubLevelType
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

		// Token: 0x06009951 RID: 39249 RVA: 0x00290FAC File Offset: 0x0028F1AC
		public int WaveGroupIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x00290FEC File Offset: 0x0028F1EC
		public int WaveGroupIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x00291017 File Offset: 0x0028F217
		public Span<int> GetWaveGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x00291026 File Offset: 0x0028F226
		public int[] GetWaveGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06009955 RID: 39253 RVA: 0x00291040 File Offset: 0x0028F240
		public int PreSegmentId
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

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x00291080 File Offset: 0x0028F280
		public int MobilePreSegmentId
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

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06009957 RID: 39255 RVA: 0x002910C0 File Offset: 0x0028F2C0
		public int PreSegmentLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x00291100 File Offset: 0x0028F300
		public int SegmentId
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

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06009959 RID: 39257 RVA: 0x00291140 File Offset: 0x0028F340
		public int MobileSegmentId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x00291180 File Offset: 0x0028F380
		public float WorldSpeedMultiply
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600995B RID: 39259 RVA: 0x002911C4 File Offset: 0x0028F3C4
		public float BornDistance
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x00291208 File Offset: 0x0028F408
		public float DistanceToNext
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x0029124C File Offset: 0x0028F44C
		public int LevelAttrRate(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x0029128C File Offset: 0x0028F48C
		public int LevelAttrRateLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x002912B8 File Offset: 0x0028F4B8
		public Span<int> GetLevelAttrRateBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x002912C8 File Offset: 0x0028F4C8
		public int[] GetLevelAttrRateArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06009961 RID: 39265 RVA: 0x002912E0 File Offset: 0x0028F4E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelAttrRateIter()或GetLevelAttrRateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelAttrRate()
		{
			MotorFightSubLevel motorFightSubLevel = this;
			return motorFightSubLevel.GetLevelAttrRateArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009962 RID: 39266 RVA: 0x00291304 File Offset: 0x0028F504
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelAttrRateIter()
		{
			MotorFightSubLevel.<LevelAttrRateIter>d__39 <LevelAttrRateIter>d__ = new MotorFightSubLevel.<LevelAttrRateIter>d__39(-2);
			<LevelAttrRateIter>d__.<>3__<>4__this = this;
			return <LevelAttrRateIter>d__;
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x0029131C File Offset: 0x0028F51C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveGroupIdsIter()或GetWaveGroupIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveGroupIds()
		{
			MotorFightSubLevel motorFightSubLevel = this;
			return motorFightSubLevel.GetWaveGroupIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00291340 File Offset: 0x0028F540
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveGroupIdsIter()
		{
			MotorFightSubLevel.<WaveGroupIdsIter>d__41 <WaveGroupIdsIter>d__ = new MotorFightSubLevel.<WaveGroupIdsIter>d__41(-2);
			<WaveGroupIdsIter>d__.<>3__<>4__this = this;
			return <WaveGroupIdsIter>d__;
		}

		// Token: 0x04004EF7 RID: 20215
		private Table __p;
	}
}
