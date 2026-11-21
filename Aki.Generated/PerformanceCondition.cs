using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9C RID: 3996
	public struct PerformanceCondition : IFlatbufferObject
	{
		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x002C4D38 File Offset: 0x002C2F38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9B4 RID: 43444 RVA: 0x002C4D45 File Offset: 0x002C2F45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9B5 RID: 43445 RVA: 0x002C4D4C File Offset: 0x002C2F4C
		public static PerformanceCondition GetRootAsPerformanceCondition(ByteBuffer _bb)
		{
			return PerformanceCondition.GetRootAsPerformanceCondition(_bb, default(PerformanceCondition));
		}

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x002C4D68 File Offset: 0x002C2F68
		public static PerformanceCondition GetRootAsPerformanceCondition(ByteBuffer _bb, PerformanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x002C4D85 File Offset: 0x002C2F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9B8 RID: 43448 RVA: 0x002C4D94 File Offset: 0x002C2F94
		public PerformanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x002C4DA4 File Offset: 0x002C2FA4
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

		// Token: 0x0600A9BA RID: 43450 RVA: 0x002C4DE0 File Offset: 0x002C2FE0
		public float WaterHeight(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x002C4E24 File Offset: 0x002C3024
		public int WaterHeightLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A9BC RID: 43452 RVA: 0x002C4E4F File Offset: 0x002C304F
		public Span<float> GetWaterHeightBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x0600A9BD RID: 43453 RVA: 0x002C4E5E File Offset: 0x002C305E
		public float[] GetWaterHeightArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x002C4E78 File Offset: 0x002C3078
		public float StandingNormalZ(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x002C4EBC File Offset: 0x002C30BC
		public int StandingNormalZLength
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

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x002C4EE7 File Offset: 0x002C30E7
		public Span<float> GetStandingNormalZBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600A9C1 RID: 43457 RVA: 0x002C4EF6 File Offset: 0x002C30F6
		public float[] GetStandingNormalZArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600A9C2 RID: 43458 RVA: 0x002C4F10 File Offset: 0x002C3110
		public GameplayTagArray? DisableTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new GameplayTagArray?(default(GameplayTagArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x002C4F74 File Offset: 0x002C3174
		public int DisableTagsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A9C4 RID: 43460 RVA: 0x002C4FA0 File Offset: 0x002C31A0
		public float Radius(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x002C4FE4 File Offset: 0x002C31E4
		public int RadiusLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x002C5010 File Offset: 0x002C3210
		public Span<float> GetRadiusBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x002C5020 File Offset: 0x002C3220
		public float[] GetRadiusArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x002C5038 File Offset: 0x002C3238
		[NullableContext(1)]
		public GameplayTagArray[] DisableTags()
		{
			return this.DisableTagsIter().ToArray<GameplayTagArray>();
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x002C5045 File Offset: 0x002C3245
		[NullableContext(1)]
		public IEnumerable<GameplayTagArray> DisableTagsIter()
		{
			PerformanceCondition.<DisableTagsIter>d__29 <DisableTagsIter>d__ = new PerformanceCondition.<DisableTagsIter>d__29(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x002C505A File Offset: 0x002C325A
		[NullableContext(1)]
		public float[] Radius()
		{
			return this.GetRadiusArray();
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x002C5062 File Offset: 0x002C3262
		[NullableContext(1)]
		public IEnumerable<float> RadiusIter()
		{
			PerformanceCondition.<RadiusIter>d__31 <RadiusIter>d__ = new PerformanceCondition.<RadiusIter>d__31(-2);
			<RadiusIter>d__.<>3__<>4__this = this;
			return <RadiusIter>d__;
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x002C5077 File Offset: 0x002C3277
		[NullableContext(1)]
		public float[] StandingNormalZ()
		{
			return this.GetStandingNormalZArray();
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x002C507F File Offset: 0x002C327F
		[NullableContext(1)]
		public IEnumerable<float> StandingNormalZIter()
		{
			PerformanceCondition.<StandingNormalZIter>d__33 <StandingNormalZIter>d__ = new PerformanceCondition.<StandingNormalZIter>d__33(-2);
			<StandingNormalZIter>d__.<>3__<>4__this = this;
			return <StandingNormalZIter>d__;
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x002C5094 File Offset: 0x002C3294
		[NullableContext(1)]
		public float[] WaterHeight()
		{
			return this.GetWaterHeightArray();
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x002C509C File Offset: 0x002C329C
		[NullableContext(1)]
		public IEnumerable<float> WaterHeightIter()
		{
			PerformanceCondition.<WaterHeightIter>d__35 <WaterHeightIter>d__ = new PerformanceCondition.<WaterHeightIter>d__35(-2);
			<WaterHeightIter>d__.<>3__<>4__this = this;
			return <WaterHeightIter>d__;
		}

		// Token: 0x04005552 RID: 21842
		private Table __p;
	}
}
