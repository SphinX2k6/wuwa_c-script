using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C86 RID: 3206
	public struct CoopRoleLevel : IFlatbufferObject
	{
		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x00220610 File Offset: 0x0021E810
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x0022061D File Offset: 0x0021E81D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00220624 File Offset: 0x0021E824
		public static CoopRoleLevel GetRootAsCoopRoleLevel(ByteBuffer _bb)
		{
			return CoopRoleLevel.GetRootAsCoopRoleLevel(_bb, default(CoopRoleLevel));
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00220640 File Offset: 0x0021E840
		public static CoopRoleLevel GetRootAsCoopRoleLevel(ByteBuffer _bb, CoopRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x0022065D File Offset: 0x0021E85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x0022066C File Offset: 0x0021E86C
		public CoopRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x0022067C File Offset: 0x0021E87C
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x002206B8 File Offset: 0x0021E8B8
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06005FAD RID: 24493 RVA: 0x002206F4 File Offset: 0x0021E8F4
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x00220730 File Offset: 0x0021E930
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06005FAF RID: 24495 RVA: 0x00220770 File Offset: 0x0021E970
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x002207B0 File Offset: 0x0021E9B0
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x002207F0 File Offset: 0x0021E9F0
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x00220830 File Offset: 0x0021EA30
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x00220870 File Offset: 0x0021EA70
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

		// Token: 0x06005FB4 RID: 24500 RVA: 0x002208A8 File Offset: 0x0021EAA8
		public Span<byte> GetEventTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x002208B8 File Offset: 0x0021EAB8
		public byte[] GetEventTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x002208D0 File Offset: 0x0021EAD0
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

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00220908 File Offset: 0x0021EB08
		public Span<byte> GetLevelUpTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00220918 File Offset: 0x0021EB18
		public byte[] GetLevelUpTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x00220930 File Offset: 0x0021EB30
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

		// Token: 0x06005FBA RID: 24506 RVA: 0x00220968 File Offset: 0x0021EB68
		public Span<byte> GetLevelUpTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00220978 File Offset: 0x0021EB78
		public byte[] GetLevelUpTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x00220990 File Offset: 0x0021EB90
		public int JumpId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06005FBD RID: 24509 RVA: 0x002209D0 File Offset: 0x0021EBD0
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

		// Token: 0x06005FBE RID: 24510 RVA: 0x002209FC File Offset: 0x0021EBFC
		public Span<int> GetJumpIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00220A0C File Offset: 0x0021EC0C
		public int[] GetJumpIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x00220A24 File Offset: 0x0021EC24
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x00220A64 File Offset: 0x0021EC64
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

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00220A9C File Offset: 0x0021EC9C
		public Span<byte> GetGuideText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x00220AAC File Offset: 0x0021ECAC
		public byte[] GetGuideText1Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x00220AC4 File Offset: 0x0021ECC4
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

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00220AFC File Offset: 0x0021ECFC
		public Span<byte> GetFinishGuideTextCondition1Bytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00220B0C File Offset: 0x0021ED0C
		public byte[] GetFinishGuideTextCondition1Array()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x00220B24 File Offset: 0x0021ED24
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x00220B64 File Offset: 0x0021ED64
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

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00220B9C File Offset: 0x0021ED9C
		public Span<byte> GetFinishGuideText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00220BAC File Offset: 0x0021EDAC
		public byte[] GetFinishGuideText1Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06005FCB RID: 24523 RVA: 0x00220BC4 File Offset: 0x0021EDC4
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

		// Token: 0x06005FCC RID: 24524 RVA: 0x00220BFC File Offset: 0x0021EDFC
		public Span<byte> GetFinishGuideTextCondition2Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00220C0C File Offset: 0x0021EE0C
		public byte[] GetFinishGuideTextCondition2Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06005FCE RID: 24526 RVA: 0x00220C24 File Offset: 0x0021EE24
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06005FCF RID: 24527 RVA: 0x00220C64 File Offset: 0x0021EE64
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

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00220C9C File Offset: 0x0021EE9C
		public Span<byte> GetFinishGuideText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00220CAC File Offset: 0x0021EEAC
		public byte[] GetFinishGuideText2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x00220CC4 File Offset: 0x0021EEC4
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

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00220CFC File Offset: 0x0021EEFC
		public Span<byte> GetFinishGuideTextCondition3Bytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00220D0C File Offset: 0x0021EF0C
		public byte[] GetFinishGuideTextCondition3Array()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06005FD5 RID: 24533 RVA: 0x00220D24 File Offset: 0x0021EF24
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06005FD6 RID: 24534 RVA: 0x00220D64 File Offset: 0x0021EF64
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

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00220D9C File Offset: 0x0021EF9C
		public Span<byte> GetFinishGuideText3Bytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x00220DAC File Offset: 0x0021EFAC
		public byte[] GetFinishGuideText3Array()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x00220DC4 File Offset: 0x0021EFC4
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

		// Token: 0x06005FDA RID: 24538 RVA: 0x00220DFC File Offset: 0x0021EFFC
		public Span<byte> GetInterRewardTextBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x00220E0C File Offset: 0x0021F00C
		public byte[] GetInterRewardTextArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06005FDC RID: 24540 RVA: 0x00220E24 File Offset: 0x0021F024
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

		// Token: 0x06005FDD RID: 24541 RVA: 0x00220E5C File Offset: 0x0021F05C
		public Span<byte> GetGuideText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x00220E6C File Offset: 0x0021F06C
		public byte[] GetGuideText2Array()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x00220E84 File Offset: 0x0021F084
		[NullableContext(1)]
		public int[] JumpId()
		{
			return this.GetJumpIdArray();
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00220E8C File Offset: 0x0021F08C
		[NullableContext(1)]
		public IEnumerable<int> JumpIdIter()
		{
			CoopRoleLevel.<JumpIdIter>d__86 <JumpIdIter>d__ = new CoopRoleLevel.<JumpIdIter>d__86(-2);
			<JumpIdIter>d__.<>3__<>4__this = this;
			return <JumpIdIter>d__;
		}

		// Token: 0x040051A9 RID: 20905
		private Table __p;
	}
}
