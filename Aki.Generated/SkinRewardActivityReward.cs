using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CA RID: 4298
	public struct SkinRewardActivityReward : IFlatbufferObject
	{
		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600D63D RID: 54845 RVA: 0x0031A490 File Offset: 0x00318690
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D63E RID: 54846 RVA: 0x0031A49D File Offset: 0x0031869D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x0031A4A4 File Offset: 0x003186A4
		public static SkinRewardActivityReward GetRootAsSkinRewardActivityReward(ByteBuffer _bb)
		{
			return SkinRewardActivityReward.GetRootAsSkinRewardActivityReward(_bb, default(SkinRewardActivityReward));
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x0031A4C0 File Offset: 0x003186C0
		public static SkinRewardActivityReward GetRootAsSkinRewardActivityReward(ByteBuffer _bb, SkinRewardActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x0031A4DD File Offset: 0x003186DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x0031A4EC File Offset: 0x003186EC
		public SkinRewardActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600D643 RID: 54851 RVA: 0x0031A4FC File Offset: 0x003186FC
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

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600D644 RID: 54852 RVA: 0x0031A538 File Offset: 0x00318738
		public int ActivityId
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

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600D645 RID: 54853 RVA: 0x0031A574 File Offset: 0x00318774
		public int ConditionGroup
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

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600D646 RID: 54854 RVA: 0x0031A5B0 File Offset: 0x003187B0
		public int TargetQuestID
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

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600D647 RID: 54855 RVA: 0x0031A5F0 File Offset: 0x003187F0
		public int DirectTrainActivityId
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

		// Token: 0x0600D648 RID: 54856 RVA: 0x0031A630 File Offset: 0x00318830
		public int PathQuestArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600D649 RID: 54857 RVA: 0x0031A670 File Offset: 0x00318870
		public int PathQuestArrayLength
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

		// Token: 0x0600D64A RID: 54858 RVA: 0x0031A69C File Offset: 0x0031889C
		public Span<int> GetPathQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x0031A6AC File Offset: 0x003188AC
		public int[] GetPathQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600D64C RID: 54860 RVA: 0x0031A6C4 File Offset: 0x003188C4
		public int MaleSkinId
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

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600D64D RID: 54861 RVA: 0x0031A704 File Offset: 0x00318904
		public int FemaleSkinId
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

		// Token: 0x0600D64E RID: 54862 RVA: 0x0031A744 File Offset: 0x00318944
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PathQuestArrayIter()或GetPathQuestArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PathQuestArray()
		{
			SkinRewardActivityReward skinRewardActivityReward = this;
			return skinRewardActivityReward.GetPathQuestArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x0031A768 File Offset: 0x00318968
		[NullableContext(1)]
		public readonly IEnumerable<int> PathQuestArrayIter()
		{
			SkinRewardActivityReward.<PathQuestArrayIter>d__28 <PathQuestArrayIter>d__ = new SkinRewardActivityReward.<PathQuestArrayIter>d__28(-2);
			<PathQuestArrayIter>d__.<>3__<>4__this = this;
			return <PathQuestArrayIter>d__;
		}

		// Token: 0x040051FC RID: 20988
		private Table __p;
	}
}
