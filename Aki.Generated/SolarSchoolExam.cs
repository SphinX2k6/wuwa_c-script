using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E2 RID: 4578
	public struct SolarSchoolExam : IFlatbufferObject
	{
		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600E0F0 RID: 57584 RVA: 0x0033FE05 File Offset: 0x0033E005
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0F1 RID: 57585 RVA: 0x0033FE12 File Offset: 0x0033E012
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0F2 RID: 57586 RVA: 0x0033FE1C File Offset: 0x0033E01C
		public static SolarSchoolExam GetRootAsSolarSchoolExam(ByteBuffer _bb)
		{
			return SolarSchoolExam.GetRootAsSolarSchoolExam(_bb, default(SolarSchoolExam));
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x0033FE38 File Offset: 0x0033E038
		public static SolarSchoolExam GetRootAsSolarSchoolExam(ByteBuffer _bb, SolarSchoolExam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x0033FE55 File Offset: 0x0033E055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x0033FE64 File Offset: 0x0033E064
		public SolarSchoolExam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600E0F6 RID: 57590 RVA: 0x0033FE74 File Offset: 0x0033E074
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

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x0033FEB0 File Offset: 0x0033E0B0
		public int InstanceId
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

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x0033FEEC File Offset: 0x0033E0EC
		public int ActivityId
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

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600E0F9 RID: 57593 RVA: 0x0033FF28 File Offset: 0x0033E128
		public int ExamType
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

		// Token: 0x0600E0FA RID: 57594 RVA: 0x0033FF68 File Offset: 0x0033E168
		public int AttrMax(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600E0FB RID: 57595 RVA: 0x0033FFA8 File Offset: 0x0033E1A8
		public int AttrMaxLength
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

		// Token: 0x0600E0FC RID: 57596 RVA: 0x0033FFD4 File Offset: 0x0033E1D4
		public Span<int> GetAttrMaxBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E0FD RID: 57597 RVA: 0x0033FFE4 File Offset: 0x0033E1E4
		public int[] GetAttrMaxArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x0033FFFC File Offset: 0x0033E1FC
		public int AttrWeight(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600E0FF RID: 57599 RVA: 0x0034003C File Offset: 0x0033E23C
		public int AttrWeightLength
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

		// Token: 0x0600E100 RID: 57600 RVA: 0x00340068 File Offset: 0x0033E268
		public Span<int> GetAttrWeightBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E101 RID: 57601 RVA: 0x00340078 File Offset: 0x0033E278
		public int[] GetAttrWeightArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x00340090 File Offset: 0x0033E290
		public int ScoreMin
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

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600E103 RID: 57603 RVA: 0x003400D0 File Offset: 0x0033E2D0
		public int ScoreMax
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

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600E104 RID: 57604 RVA: 0x00340110 File Offset: 0x0033E310
		public int ScoreRankGroupId
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

		// Token: 0x0600E105 RID: 57605 RVA: 0x0034014D File Offset: 0x0033E34D
		[NullableContext(1)]
		public int[] AttrMax()
		{
			return this.GetAttrMaxArray();
		}

		// Token: 0x0600E106 RID: 57606 RVA: 0x00340155 File Offset: 0x0033E355
		[NullableContext(1)]
		public IEnumerable<int> AttrMaxIter()
		{
			SolarSchoolExam.<AttrMaxIter>d__33 <AttrMaxIter>d__ = new SolarSchoolExam.<AttrMaxIter>d__33(-2);
			<AttrMaxIter>d__.<>3__<>4__this = this;
			return <AttrMaxIter>d__;
		}

		// Token: 0x0600E107 RID: 57607 RVA: 0x0034016A File Offset: 0x0033E36A
		[NullableContext(1)]
		public int[] AttrWeight()
		{
			return this.GetAttrWeightArray();
		}

		// Token: 0x0600E108 RID: 57608 RVA: 0x00340172 File Offset: 0x0033E372
		[NullableContext(1)]
		public IEnumerable<int> AttrWeightIter()
		{
			SolarSchoolExam.<AttrWeightIter>d__35 <AttrWeightIter>d__ = new SolarSchoolExam.<AttrWeightIter>d__35(-2);
			<AttrWeightIter>d__.<>3__<>4__this = this;
			return <AttrWeightIter>d__;
		}

		// Token: 0x0400581F RID: 22559
		private Table __p;
	}
}
