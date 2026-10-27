using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB7 RID: 3767
	public struct PerformanceCondition : IFlatbufferObject
	{
		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x002A799C File Offset: 0x002A5B9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A393 RID: 41875 RVA: 0x002A79A9 File Offset: 0x002A5BA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x002A79B0 File Offset: 0x002A5BB0
		public static PerformanceCondition GetRootAsPerformanceCondition(ByteBuffer _bb)
		{
			return PerformanceCondition.GetRootAsPerformanceCondition(_bb, default(PerformanceCondition));
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x002A79CC File Offset: 0x002A5BCC
		public static PerformanceCondition GetRootAsPerformanceCondition(ByteBuffer _bb, PerformanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x002A79E9 File Offset: 0x002A5BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x002A79F8 File Offset: 0x002A5BF8
		public PerformanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600A398 RID: 41880 RVA: 0x002A7A08 File Offset: 0x002A5C08
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

		// Token: 0x0600A399 RID: 41881 RVA: 0x002A7A44 File Offset: 0x002A5C44
		public float WaterHeight(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600A39A RID: 41882 RVA: 0x002A7A88 File Offset: 0x002A5C88
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

		// Token: 0x0600A39B RID: 41883 RVA: 0x002A7AB3 File Offset: 0x002A5CB3
		public Span<float> GetWaterHeightBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x002A7AC2 File Offset: 0x002A5CC2
		public float[] GetWaterHeightArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x002A7ADC File Offset: 0x002A5CDC
		public float StandingNormalZ(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600A39E RID: 41886 RVA: 0x002A7B20 File Offset: 0x002A5D20
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

		// Token: 0x0600A39F RID: 41887 RVA: 0x002A7B4B File Offset: 0x002A5D4B
		public Span<float> GetStandingNormalZBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x002A7B5A File Offset: 0x002A5D5A
		public float[] GetStandingNormalZArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x002A7B74 File Offset: 0x002A5D74
		public GameplayTagArray? DisableTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new GameplayTagArray?(default(GameplayTagArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600A3A2 RID: 41890 RVA: 0x002A7BD8 File Offset: 0x002A5DD8
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

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x002A7C04 File Offset: 0x002A5E04
		public float Radius(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x0600A3A4 RID: 41892 RVA: 0x002A7C48 File Offset: 0x002A5E48
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

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x002A7C74 File Offset: 0x002A5E74
		public Span<float> GetRadiusBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x002A7C84 File Offset: 0x002A5E84
		public float[] GetRadiusArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x002A7C9C File Offset: 0x002A5E9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly GameplayTagArray[] DisableTags()
		{
			return this.DisableTagsIter().ToArray<GameplayTagArray>();
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x002A7CA9 File Offset: 0x002A5EA9
		[NullableContext(1)]
		public readonly IEnumerable<GameplayTagArray> DisableTagsIter()
		{
			PerformanceCondition.<DisableTagsIter>d__29 <DisableTagsIter>d__ = new PerformanceCondition.<DisableTagsIter>d__29(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x002A7CC0 File Offset: 0x002A5EC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RadiusIter()或GetRadiusBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Radius()
		{
			PerformanceCondition performanceCondition = this;
			return performanceCondition.GetRadiusArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x002A7CE4 File Offset: 0x002A5EE4
		[NullableContext(1)]
		public readonly IEnumerable<float> RadiusIter()
		{
			PerformanceCondition.<RadiusIter>d__31 <RadiusIter>d__ = new PerformanceCondition.<RadiusIter>d__31(-2);
			<RadiusIter>d__.<>3__<>4__this = this;
			return <RadiusIter>d__;
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x002A7CFC File Offset: 0x002A5EFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StandingNormalZIter()或GetStandingNormalZBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] StandingNormalZ()
		{
			PerformanceCondition performanceCondition = this;
			return performanceCondition.GetStandingNormalZArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x002A7D20 File Offset: 0x002A5F20
		[NullableContext(1)]
		public readonly IEnumerable<float> StandingNormalZIter()
		{
			PerformanceCondition.<StandingNormalZIter>d__33 <StandingNormalZIter>d__ = new PerformanceCondition.<StandingNormalZIter>d__33(-2);
			<StandingNormalZIter>d__.<>3__<>4__this = this;
			return <StandingNormalZIter>d__;
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x002A7D38 File Offset: 0x002A5F38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaterHeightIter()或GetWaterHeightBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] WaterHeight()
		{
			PerformanceCondition performanceCondition = this;
			return performanceCondition.GetWaterHeightArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A3AE RID: 41902 RVA: 0x002A7D5C File Offset: 0x002A5F5C
		[NullableContext(1)]
		public readonly IEnumerable<float> WaterHeightIter()
		{
			PerformanceCondition.<WaterHeightIter>d__35 <WaterHeightIter>d__ = new PerformanceCondition.<WaterHeightIter>d__35(-2);
			<WaterHeightIter>d__.<>3__<>4__this = this;
			return <WaterHeightIter>d__;
		}

		// Token: 0x04004F6D RID: 20333
		private Table __p;
	}
}
