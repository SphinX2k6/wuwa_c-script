using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF6 RID: 2806
	public struct AiTeamLevelNew : IFlatbufferObject
	{
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x001D4899 File Offset: 0x001D2A99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x001D48A6 File Offset: 0x001D2AA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x001D48B0 File Offset: 0x001D2AB0
		public static AiTeamLevelNew GetRootAsAiTeamLevelNew(ByteBuffer _bb)
		{
			return AiTeamLevelNew.GetRootAsAiTeamLevelNew(_bb, default(AiTeamLevelNew));
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x001D48CC File Offset: 0x001D2ACC
		public static AiTeamLevelNew GetRootAsAiTeamLevelNew(ByteBuffer _bb, AiTeamLevelNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x001D48E9 File Offset: 0x001D2AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x001D48F8 File Offset: 0x001D2AF8
		public AiTeamLevelNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x001D4908 File Offset: 0x001D2B08
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x001D4944 File Offset: 0x001D2B44
		public int PositionId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x001D4984 File Offset: 0x001D2B84
		public int PositionIdLength
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

		// Token: 0x0600473D RID: 18237 RVA: 0x001D49AF File Offset: 0x001D2BAF
		public Span<int> GetPositionIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x001D49BE File Offset: 0x001D2BBE
		public int[] GetPositionIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x001D49D8 File Offset: 0x001D2BD8
		public FloatRange? AllocationPeriodic
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x001D4A38 File Offset: 0x001D2C38
		public int AttackerNum
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x001D4A78 File Offset: 0x001D2C78
		public FloatRange? AttackCountDown
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x001D4AD8 File Offset: 0x001D2CD8
		public FloatRange? NoAttackCountDown
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x001D4B38 File Offset: 0x001D2D38
		public FloatRange? BeAttackCountDown
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x001D4B98 File Offset: 0x001D2D98
		public float EliteRatio(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x001D4BDC File Offset: 0x001D2DDC
		public int EliteRatioLength
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

		// Token: 0x06004746 RID: 18246 RVA: 0x001D4C08 File Offset: 0x001D2E08
		public Span<float> GetEliteRatioBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x001D4C18 File Offset: 0x001D2E18
		public float[] GetEliteRatioArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x001D4C30 File Offset: 0x001D2E30
		public float RangeRatio(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x001D4C74 File Offset: 0x001D2E74
		public int RangeRatioLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x001D4CA0 File Offset: 0x001D2EA0
		public Span<float> GetRangeRatioBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x001D4CB0 File Offset: 0x001D2EB0
		public float[] GetRangeRatioArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x001D4CC8 File Offset: 0x001D2EC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EliteRatioIter()或GetEliteRatioBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] EliteRatio()
		{
			AiTeamLevelNew aiTeamLevelNew = this;
			return aiTeamLevelNew.GetEliteRatioArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x001D4CEC File Offset: 0x001D2EEC
		[NullableContext(1)]
		public readonly IEnumerable<float> EliteRatioIter()
		{
			AiTeamLevelNew.<EliteRatioIter>d__36 <EliteRatioIter>d__ = new AiTeamLevelNew.<EliteRatioIter>d__36(-2);
			<EliteRatioIter>d__.<>3__<>4__this = this;
			return <EliteRatioIter>d__;
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x001D4D04 File Offset: 0x001D2F04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionIdIter()或GetPositionIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PositionId()
		{
			AiTeamLevelNew aiTeamLevelNew = this;
			return aiTeamLevelNew.GetPositionIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x001D4D28 File Offset: 0x001D2F28
		[NullableContext(1)]
		public readonly IEnumerable<int> PositionIdIter()
		{
			AiTeamLevelNew.<PositionIdIter>d__38 <PositionIdIter>d__ = new AiTeamLevelNew.<PositionIdIter>d__38(-2);
			<PositionIdIter>d__.<>3__<>4__this = this;
			return <PositionIdIter>d__;
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x001D4D40 File Offset: 0x001D2F40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RangeRatioIter()或GetRangeRatioBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] RangeRatio()
		{
			AiTeamLevelNew aiTeamLevelNew = this;
			return aiTeamLevelNew.GetRangeRatioArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x001D4D64 File Offset: 0x001D2F64
		[NullableContext(1)]
		public readonly IEnumerable<float> RangeRatioIter()
		{
			AiTeamLevelNew.<RangeRatioIter>d__40 <RangeRatioIter>d__ = new AiTeamLevelNew.<RangeRatioIter>d__40(-2);
			<RangeRatioIter>d__.<>3__<>4__this = this;
			return <RangeRatioIter>d__;
		}

		// Token: 0x04004AD7 RID: 19159
		private Table __p;
	}
}
