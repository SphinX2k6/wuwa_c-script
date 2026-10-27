using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA4 RID: 2980
	public struct CoopRoleLevel : IFlatbufferObject
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x002008B0 File Offset: 0x001FEAB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x002008BD File Offset: 0x001FEABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x002008C4 File Offset: 0x001FEAC4
		public static CoopRoleLevel GetRootAsCoopRoleLevel(ByteBuffer _bb)
		{
			return CoopRoleLevel.GetRootAsCoopRoleLevel(_bb, default(CoopRoleLevel));
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x002008E0 File Offset: 0x001FEAE0
		public static CoopRoleLevel GetRootAsCoopRoleLevel(ByteBuffer _bb, CoopRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x002008FD File Offset: 0x001FEAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x0020090C File Offset: 0x001FEB0C
		public CoopRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x0020091C File Offset: 0x001FEB1C
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060059D3 RID: 22995 RVA: 0x00200958 File Offset: 0x001FEB58
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

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x00200994 File Offset: 0x001FEB94
		public int CoopRoleId
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

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x002009D0 File Offset: 0x001FEBD0
		public int CoopLevel
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

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x00200A10 File Offset: 0x001FEC10
		public int TaskGroupId
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060059D7 RID: 22999 RVA: 0x00200A50 File Offset: 0x001FEC50
		public int PreUnLockCondition
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00200A90 File Offset: 0x001FEC90
		public int UnLockCondition
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060059D9 RID: 23001 RVA: 0x00200AD0 File Offset: 0x001FECD0
		public int Reward
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x00200B10 File Offset: 0x001FED10
		public string EventTitle
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00200B48 File Offset: 0x001FED48
		public Span<byte> GetEventTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00200B58 File Offset: 0x001FED58
		public byte[] GetEventTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x00200B70 File Offset: 0x001FED70
		public string LevelUpTitleText
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

		// Token: 0x060059DE RID: 23006 RVA: 0x00200BA8 File Offset: 0x001FEDA8
		public Span<byte> GetLevelUpTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00200BB8 File Offset: 0x001FEDB8
		public byte[] GetLevelUpTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x00200BD0 File Offset: 0x001FEDD0
		public string LevelUpText
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

		// Token: 0x060059E1 RID: 23009 RVA: 0x00200C08 File Offset: 0x001FEE08
		public Span<byte> GetLevelUpTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x00200C18 File Offset: 0x001FEE18
		public byte[] GetLevelUpTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x00200C30 File Offset: 0x001FEE30
		public int JumpId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060059E4 RID: 23012 RVA: 0x00200C70 File Offset: 0x001FEE70
		public int JumpIdLength
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

		// Token: 0x060059E5 RID: 23013 RVA: 0x00200C9C File Offset: 0x001FEE9C
		public Span<int> GetJumpIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00200CAC File Offset: 0x001FEEAC
		public int[] GetJumpIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060059E7 RID: 23015 RVA: 0x00200CC4 File Offset: 0x001FEEC4
		public int JumpMessageId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060059E8 RID: 23016 RVA: 0x00200D04 File Offset: 0x001FEF04
		public string GuideText1
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00200D3C File Offset: 0x001FEF3C
		public Span<byte> GetGuideText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x00200D4C File Offset: 0x001FEF4C
		public byte[] GetGuideText1Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060059EB RID: 23019 RVA: 0x00200D64 File Offset: 0x001FEF64
		public string FinishGuideTextCondition1
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x00200D9C File Offset: 0x001FEF9C
		public Span<byte> GetFinishGuideTextCondition1Bytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x00200DAC File Offset: 0x001FEFAC
		public byte[] GetFinishGuideTextCondition1Array()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x00200DC4 File Offset: 0x001FEFC4
		public int FinishGuideTextConditionValue1
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x00200E04 File Offset: 0x001FF004
		public string FinishGuideText1
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x00200E3C File Offset: 0x001FF03C
		public Span<byte> GetFinishGuideText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x00200E4C File Offset: 0x001FF04C
		public byte[] GetFinishGuideText1Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x00200E64 File Offset: 0x001FF064
		public string FinishGuideTextCondition2
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x00200E9C File Offset: 0x001FF09C
		public Span<byte> GetFinishGuideTextCondition2Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x00200EAC File Offset: 0x001FF0AC
		public byte[] GetFinishGuideTextCondition2Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x00200EC4 File Offset: 0x001FF0C4
		public int FinishGuideTextConditionValue2
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060059F6 RID: 23030 RVA: 0x00200F04 File Offset: 0x001FF104
		public string FinishGuideText2
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00200F3C File Offset: 0x001FF13C
		public Span<byte> GetFinishGuideText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x00200F4C File Offset: 0x001FF14C
		public byte[] GetFinishGuideText2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x00200F64 File Offset: 0x001FF164
		public string FinishGuideTextCondition3
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x00200F9C File Offset: 0x001FF19C
		public Span<byte> GetFinishGuideTextCondition3Bytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00200FAC File Offset: 0x001FF1AC
		public byte[] GetFinishGuideTextCondition3Array()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060059FC RID: 23036 RVA: 0x00200FC4 File Offset: 0x001FF1C4
		public int FinishGuideTextConditionValue3
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x00201004 File Offset: 0x001FF204
		public string FinishGuideText3
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x0020103C File Offset: 0x001FF23C
		public Span<byte> GetFinishGuideText3Bytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0020104C File Offset: 0x001FF24C
		public byte[] GetFinishGuideText3Array()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x00201064 File Offset: 0x001FF264
		public string InterRewardText
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0020109C File Offset: 0x001FF29C
		public Span<byte> GetInterRewardTextBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x002010AC File Offset: 0x001FF2AC
		public byte[] GetInterRewardTextArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06005A03 RID: 23043 RVA: 0x002010C4 File Offset: 0x001FF2C4
		public string GuideText2
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x002010FC File Offset: 0x001FF2FC
		public Span<byte> GetGuideText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x0020110C File Offset: 0x001FF30C
		public byte[] GetGuideText2Array()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x00201124 File Offset: 0x001FF324
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用JumpIdIter()或GetJumpIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] JumpId()
		{
			CoopRoleLevel coopRoleLevel = this;
			return coopRoleLevel.GetJumpIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x00201148 File Offset: 0x001FF348
		[NullableContext(1)]
		public readonly IEnumerable<int> JumpIdIter()
		{
			CoopRoleLevel.<JumpIdIter>d__86 <JumpIdIter>d__ = new CoopRoleLevel.<JumpIdIter>d__86(-2);
			<JumpIdIter>d__.<>3__<>4__this = this;
			return <JumpIdIter>d__;
		}

		// Token: 0x04004BC7 RID: 19399
		private Table __p;
	}
}
