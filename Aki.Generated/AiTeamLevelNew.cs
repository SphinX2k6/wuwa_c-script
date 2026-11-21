using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD0 RID: 3024
	public struct AiTeamLevelNew : IFlatbufferObject
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x001F4239 File Offset: 0x001F2439
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x001F4246 File Offset: 0x001F2446
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x001F4250 File Offset: 0x001F2450
		public static AiTeamLevelNew GetRootAsAiTeamLevelNew(ByteBuffer _bb)
		{
			return AiTeamLevelNew.GetRootAsAiTeamLevelNew(_bb, default(AiTeamLevelNew));
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x001F426C File Offset: 0x001F246C
		public static AiTeamLevelNew GetRootAsAiTeamLevelNew(ByteBuffer _bb, AiTeamLevelNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x001F4289 File Offset: 0x001F2489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x001F4298 File Offset: 0x001F2498
		public AiTeamLevelNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x001F42A8 File Offset: 0x001F24A8
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

		// Token: 0x06004C82 RID: 19586 RVA: 0x001F42E4 File Offset: 0x001F24E4
		public int PositionId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x001F4324 File Offset: 0x001F2524
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

		// Token: 0x06004C84 RID: 19588 RVA: 0x001F434F File Offset: 0x001F254F
		public Span<int> GetPositionIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x001F435E File Offset: 0x001F255E
		public int[] GetPositionIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06004C86 RID: 19590 RVA: 0x001F4378 File Offset: 0x001F2578
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x001F43D8 File Offset: 0x001F25D8
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x001F4418 File Offset: 0x001F2618
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x001F4478 File Offset: 0x001F2678
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x001F44D8 File Offset: 0x001F26D8
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

		// Token: 0x06004C8B RID: 19595 RVA: 0x001F4538 File Offset: 0x001F2738
		public float EliteRatio(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x001F457C File Offset: 0x001F277C
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

		// Token: 0x06004C8D RID: 19597 RVA: 0x001F45A8 File Offset: 0x001F27A8
		public Span<float> GetEliteRatioBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x001F45B8 File Offset: 0x001F27B8
		public float[] GetEliteRatioArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x001F45D0 File Offset: 0x001F27D0
		public float RangeRatio(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x001F4614 File Offset: 0x001F2814
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

		// Token: 0x06004C91 RID: 19601 RVA: 0x001F4640 File Offset: 0x001F2840
		public Span<float> GetRangeRatioBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x001F4650 File Offset: 0x001F2850
		public float[] GetRangeRatioArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x001F4668 File Offset: 0x001F2868
		[NullableContext(1)]
		public float[] EliteRatio()
		{
			return this.GetEliteRatioArray();
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x001F4670 File Offset: 0x001F2870
		[NullableContext(1)]
		public IEnumerable<float> EliteRatioIter()
		{
			AiTeamLevelNew.<EliteRatioIter>d__36 <EliteRatioIter>d__ = new AiTeamLevelNew.<EliteRatioIter>d__36(-2);
			<EliteRatioIter>d__.<>3__<>4__this = this;
			return <EliteRatioIter>d__;
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x001F4685 File Offset: 0x001F2885
		[NullableContext(1)]
		public int[] PositionId()
		{
			return this.GetPositionIdArray();
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x001F468D File Offset: 0x001F288D
		[NullableContext(1)]
		public IEnumerable<int> PositionIdIter()
		{
			AiTeamLevelNew.<PositionIdIter>d__38 <PositionIdIter>d__ = new AiTeamLevelNew.<PositionIdIter>d__38(-2);
			<PositionIdIter>d__.<>3__<>4__this = this;
			return <PositionIdIter>d__;
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x001F46A2 File Offset: 0x001F28A2
		[NullableContext(1)]
		public float[] RangeRatio()
		{
			return this.GetRangeRatioArray();
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x001F46AA File Offset: 0x001F28AA
		[NullableContext(1)]
		public IEnumerable<float> RangeRatioIter()
		{
			AiTeamLevelNew.<RangeRatioIter>d__40 <RangeRatioIter>d__ = new AiTeamLevelNew.<RangeRatioIter>d__40(-2);
			<RangeRatioIter>d__.<>3__<>4__this = this;
			return <RangeRatioIter>d__;
		}

		// Token: 0x040050B1 RID: 20657
		private Table __p;
	}
}
