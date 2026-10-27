using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E52 RID: 3666
	public struct MotorFightWave : IFlatbufferObject
	{
		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x00291B75 File Offset: 0x0028FD75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x00291B82 File Offset: 0x0028FD82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x00291B8C File Offset: 0x0028FD8C
		public static MotorFightWave GetRootAsMotorFightWave(ByteBuffer _bb)
		{
			return MotorFightWave.GetRootAsMotorFightWave(_bb, default(MotorFightWave));
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x00291BA8 File Offset: 0x0028FDA8
		public static MotorFightWave GetRootAsMotorFightWave(ByteBuffer _bb, MotorFightWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00291BC5 File Offset: 0x0028FDC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00291BD4 File Offset: 0x0028FDD4
		public MotorFightWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x060099A5 RID: 39333 RVA: 0x00291BE4 File Offset: 0x0028FDE4
		public int WaveId
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

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x00291C20 File Offset: 0x0028FE20
		public int RefreshType
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

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x060099A7 RID: 39335 RVA: 0x00291C5C File Offset: 0x0028FE5C
		public int RefreshGroupId
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

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00291C98 File Offset: 0x0028FE98
		public int BuffGateBornGroup
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

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x060099A9 RID: 39337 RVA: 0x00291CD8 File Offset: 0x0028FED8
		public int ConditionId
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

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x00291D18 File Offset: 0x0028FF18
		public int Weight
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

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x060099AB RID: 39339 RVA: 0x00291D58 File Offset: 0x0028FF58
		public int BornTrack
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

		// Token: 0x060099AC RID: 39340 RVA: 0x00291D98 File Offset: 0x0028FF98
		public int BornDistance(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x060099AD RID: 39341 RVA: 0x00291DD8 File Offset: 0x0028FFD8
		public int BornDistanceLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x00291E04 File Offset: 0x00290004
		public Span<int> GetBornDistanceBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x00291E14 File Offset: 0x00290014
		public int[] GetBornDistanceArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x00291E2C File Offset: 0x0029002C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornDistanceIter()或GetBornDistanceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornDistance()
		{
			MotorFightWave motorFightWave = this;
			return motorFightWave.GetBornDistanceArray() ?? Array.Empty<int>();
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x00291E50 File Offset: 0x00290050
		[NullableContext(1)]
		public readonly IEnumerable<int> BornDistanceIter()
		{
			MotorFightWave.<BornDistanceIter>d__28 <BornDistanceIter>d__ = new MotorFightWave.<BornDistanceIter>d__28(-2);
			<BornDistanceIter>d__.<>3__<>4__this = this;
			return <BornDistanceIter>d__;
		}

		// Token: 0x04004EFB RID: 20219
		private Table __p;
	}
}
