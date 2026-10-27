using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC9 RID: 3785
	public struct PhantomBattleChallenge : IFlatbufferObject
	{
		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x0600A637 RID: 42551 RVA: 0x002ADD49 File Offset: 0x002ABF49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x002ADD56 File Offset: 0x002ABF56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x002ADD60 File Offset: 0x002ABF60
		public static PhantomBattleChallenge GetRootAsPhantomBattleChallenge(ByteBuffer _bb)
		{
			return PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(_bb, default(PhantomBattleChallenge));
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x002ADD7C File Offset: 0x002ABF7C
		public static PhantomBattleChallenge GetRootAsPhantomBattleChallenge(ByteBuffer _bb, PhantomBattleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x002ADD99 File Offset: 0x002ABF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x002ADDA8 File Offset: 0x002ABFA8
		public PhantomBattleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x002ADDB8 File Offset: 0x002ABFB8
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

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0600A63E RID: 42558 RVA: 0x002ADDF4 File Offset: 0x002ABFF4
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

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x002ADE30 File Offset: 0x002AC030
		public int GymId
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

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600A640 RID: 42560 RVA: 0x002ADE6C File Offset: 0x002AC06C
		public int MarkId
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

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x0600A641 RID: 42561 RVA: 0x002ADEAC File Offset: 0x002AC0AC
		public int MapId
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

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600A642 RID: 42562 RVA: 0x002ADEEC File Offset: 0x002AC0EC
		public bool IsRecord
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600A643 RID: 42563 RVA: 0x002ADF2C File Offset: 0x002AC12C
		public bool EnableSkip
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x002ADF6C File Offset: 0x002AC16C
		public int QuestId
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

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600A645 RID: 42565 RVA: 0x002ADFAC File Offset: 0x002AC1AC
		public int InstId
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

		// Token: 0x0600A646 RID: 42566 RVA: 0x002ADFEC File Offset: 0x002AC1EC
		public DicIntInt? DialogMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0600A647 RID: 42567 RVA: 0x002AE050 File Offset: 0x002AC250
		public int DialogMapLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600A648 RID: 42568 RVA: 0x002AE07C File Offset: 0x002AC27C
		public int OpenConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600A649 RID: 42569 RVA: 0x002AE0BC File Offset: 0x002AC2BC
		public int ShowConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x002AE0FC File Offset: 0x002AC2FC
		public int UncoverConditionGroupId
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

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x0600A64B RID: 42571 RVA: 0x002AE13C File Offset: 0x002AC33C
		public int FirstPassDropId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x002AE17C File Offset: 0x002AC37C
		public DicIntInt? PassDropId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x0600A64D RID: 42573 RVA: 0x002AE1E0 File Offset: 0x002AC3E0
		public int PassDropIdLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x002AE20C File Offset: 0x002AC40C
		public int CardRoleId
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

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x0600A64F RID: 42575 RVA: 0x002AE24C File Offset: 0x002AC44C
		public int CardGroupId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x002AE28C File Offset: 0x002AC48C
		public bool IsReChallenge
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x002AE2CC File Offset: 0x002AC4CC
		public bool EnableCheckReChallengeFunc
		{
			get
			{
				int num = this.__p.__offset(40);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x0600A652 RID: 42578 RVA: 0x002AE30C File Offset: 0x002AC50C
		public int Difficult
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600A653 RID: 42579 RVA: 0x002AE34C File Offset: 0x002AC54C
		public int NpcGroupId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x002AE38C File Offset: 0x002AC58C
		public int MaxRoundNum
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

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600A655 RID: 42581 RVA: 0x002AE3CC File Offset: 0x002AC5CC
		public int RecoverCostPoint
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x002AE40C File Offset: 0x002AC60C
		public int NpcChallengeSkillId(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600A657 RID: 42583 RVA: 0x002AE44C File Offset: 0x002AC64C
		public int NpcChallengeSkillIdLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x002AE478 File Offset: 0x002AC678
		public Span<int> GetNpcChallengeSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x002AE488 File Offset: 0x002AC688
		public int[] GetNpcChallengeSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x002AE4A0 File Offset: 0x002AC6A0
		public string NpcSkillIconList(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x002AE4DC File Offset: 0x002AC6DC
		public int NpcSkillIconListLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x002AE508 File Offset: 0x002AC708
		public string NpcSkillNameList(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x002AE544 File Offset: 0x002AC744
		public int NpcSkillNameListLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x002AE570 File Offset: 0x002AC770
		public string NpcSkillDescList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x002AE5AC File Offset: 0x002AC7AC
		public int NpcSkillDescListLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x002AE5D8 File Offset: 0x002AC7D8
		public StringArray? NpcSkillDescParamsList(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x002AE63C File Offset: 0x002AC83C
		public int NpcSkillDescParamsListLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x002AE668 File Offset: 0x002AC868
		public string ChallengeName
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x002AE6A0 File Offset: 0x002AC8A0
		public Span<byte> GetChallengeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x002AE6B0 File Offset: 0x002AC8B0
		public byte[] GetChallengeNameArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x002AE6C8 File Offset: 0x002AC8C8
		public string NpcName
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x002AE700 File Offset: 0x002AC900
		public Span<byte> GetNpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x002AE710 File Offset: 0x002AC910
		public byte[] GetNpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x002AE728 File Offset: 0x002AC928
		public int Elements(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x0600A669 RID: 42601 RVA: 0x002AE768 File Offset: 0x002AC968
		public int ElementsLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x002AE794 File Offset: 0x002AC994
		public Span<int> GetElementsBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x002AE7A4 File Offset: 0x002AC9A4
		public int[] GetElementsArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x0600A66C RID: 42604 RVA: 0x002AE7BC File Offset: 0x002AC9BC
		public string NpcTitle
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x002AE7F4 File Offset: 0x002AC9F4
		public Span<byte> GetNpcTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x002AE804 File Offset: 0x002ACA04
		public byte[] GetNpcTitleArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x002AE81C File Offset: 0x002ACA1C
		public int NpcLevel
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x002AE85C File Offset: 0x002ACA5C
		public string NpcChallengeIcon
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x002AE894 File Offset: 0x002ACA94
		public Span<byte> GetNpcChallengeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x002AE8A4 File Offset: 0x002ACAA4
		public byte[] GetNpcChallengeIconArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x002AE8BC File Offset: 0x002ACABC
		public string NpcLevelIcon
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x002AE8F4 File Offset: 0x002ACAF4
		public Span<byte> GetNpcLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x002AE904 File Offset: 0x002ACB04
		public byte[] GetNpcLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x002AE91C File Offset: 0x002ACB1C
		public string NpcLevelBgIcon
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x002AE954 File Offset: 0x002ACB54
		public Span<byte> GetNpcLevelBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x002AE964 File Offset: 0x002ACB64
		public byte[] GetNpcLevelBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x0600A679 RID: 42617 RVA: 0x002AE97C File Offset: 0x002ACB7C
		public string NpcDesc
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x002AE9B4 File Offset: 0x002ACBB4
		public Span<byte> GetNpcDescBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x002AE9C4 File Offset: 0x002ACBC4
		public byte[] GetNpcDescArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x0600A67C RID: 42620 RVA: 0x002AE9DC File Offset: 0x002ACBDC
		public string NpcIcon
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x002AEA14 File Offset: 0x002ACC14
		public Span<byte> GetNpcIconBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x002AEA24 File Offset: 0x002ACC24
		public byte[] GetNpcIconArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x002AEA3C File Offset: 0x002ACC3C
		public string NpcHead
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x002AEA74 File Offset: 0x002ACC74
		public Span<byte> GetNpcHeadBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600A681 RID: 42625 RVA: 0x002AEA84 File Offset: 0x002ACC84
		public byte[] GetNpcHeadArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x002AEA9C File Offset: 0x002ACC9C
		public string NpcNumber
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x002AEAD4 File Offset: 0x002ACCD4
		public Span<byte> GetNpcNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x002AEAE4 File Offset: 0x002ACCE4
		public byte[] GetNpcNumberArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x0600A685 RID: 42629 RVA: 0x002AEAFC File Offset: 0x002ACCFC
		public int TeleporterId
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x0600A686 RID: 42630 RVA: 0x002AEB3C File Offset: 0x002ACD3C
		public string PassConditionDesc
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x002AEB74 File Offset: 0x002ACD74
		public Span<byte> GetPassConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x002AEB84 File Offset: 0x002ACD84
		public byte[] GetPassConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x002AEB9C File Offset: 0x002ACD9C
		public bool DeckCoreCardLocked
		{
			get
			{
				int num = this.__p.__offset(88);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x0600A68A RID: 42634 RVA: 0x002AEBDC File Offset: 0x002ACDDC
		public string BvbBattleLoadingBg
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x002AEC14 File Offset: 0x002ACE14
		public Span<byte> GetBvbBattleLoadingBgBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x002AEC24 File Offset: 0x002ACE24
		public byte[] GetBvbBattleLoadingBgArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x002AEC3C File Offset: 0x002ACE3C
		public string BvbLoadingBg
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x002AEC74 File Offset: 0x002ACE74
		public Span<byte> GetBvbLoadingBgBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x002AEC84 File Offset: 0x002ACE84
		public byte[] GetBvbLoadingBgArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x0600A690 RID: 42640 RVA: 0x002AEC9C File Offset: 0x002ACE9C
		public string BvbLoadingTriangleBg
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x002AECD4 File Offset: 0x002ACED4
		public Span<byte> GetBvbLoadingTriangleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x002AECE4 File Offset: 0x002ACEE4
		public byte[] GetBvbLoadingTriangleBgArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x002AECFC File Offset: 0x002ACEFC
		public string BvbLoadingLeftHand
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x002AED34 File Offset: 0x002ACF34
		public Span<byte> GetBvbLoadingLeftHandBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x002AED44 File Offset: 0x002ACF44
		public byte[] GetBvbLoadingLeftHandArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0600A696 RID: 42646 RVA: 0x002AED5C File Offset: 0x002ACF5C
		public string BvbLoadingRightHand
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x002AED94 File Offset: 0x002ACF94
		public Span<byte> GetBvbLoadingRightHandBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x002AEDA4 File Offset: 0x002ACFA4
		public byte[] GetBvbLoadingRightHandArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0600A699 RID: 42649 RVA: 0x002AEDBC File Offset: 0x002ACFBC
		public string BvbLoadingHandShadow
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A69A RID: 42650 RVA: 0x002AEDF4 File Offset: 0x002ACFF4
		public Span<byte> GetBvbLoadingHandShadowBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x002AEE04 File Offset: 0x002AD004
		public byte[] GetBvbLoadingHandShadowArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x002AEE1C File Offset: 0x002AD01C
		public string FieldInfoDesc
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A69D RID: 42653 RVA: 0x002AEE54 File Offset: 0x002AD054
		public Span<byte> GetFieldInfoDescBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x002AEE64 File Offset: 0x002AD064
		public byte[] GetFieldInfoDescArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0600A69F RID: 42655 RVA: 0x002AEE7C File Offset: 0x002AD07C
		public int RecommendCardGroupId
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x002AEEBC File Offset: 0x002AD0BC
		public bool IsShowEntrance
		{
			get
			{
				int num = this.__p.__offset(106);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x002AEEFC File Offset: 0x002AD0FC
		public int ReChallengeQuestId
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600A6A2 RID: 42658 RVA: 0x002AEF3C File Offset: 0x002AD13C
		public string NpcMapHead
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x002AEF74 File Offset: 0x002AD174
		public Span<byte> GetNpcMapHeadBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x002AEF84 File Offset: 0x002AD184
		public byte[] GetNpcMapHeadArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x002AEF9C File Offset: 0x002AD19C
		public int PreGuideQuest(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600A6A6 RID: 42662 RVA: 0x002AEFDC File Offset: 0x002AD1DC
		public int PreGuideQuestLength
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x002AF008 File Offset: 0x002AD208
		public Span<int> GetPreGuideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(112, 4);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x002AF018 File Offset: 0x002AD218
		public int[] GetPreGuideQuestArray()
		{
			return this.__p.__vector_as_array<int>(112) ?? Array.Empty<int>();
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600A6A9 RID: 42665 RVA: 0x002AF030 File Offset: 0x002AD230
		public bool IsWorldMapShowMark
		{
			get
			{
				int num = this.__p.__offset(114);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x002AF070 File Offset: 0x002AD270
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DialogMapFrozenDict()缓存字典，遍历请使用DialogMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DialogMap()
		{
			return this.DialogMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x002AF0C6 File Offset: 0x002AD2C6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DialogMapIter()
		{
			PhantomBattleChallenge.<DialogMapIter>d__174 <DialogMapIter>d__ = new PhantomBattleChallenge.<DialogMapIter>d__174(-2);
			<DialogMapIter>d__.<>3__<>4__this = this;
			return <DialogMapIter>d__;
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x002AF0DC File Offset: 0x002AD2DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementsIter()或GetElementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Elements()
		{
			PhantomBattleChallenge phantomBattleChallenge = this;
			return phantomBattleChallenge.GetElementsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x002AF100 File Offset: 0x002AD300
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementsIter()
		{
			PhantomBattleChallenge.<ElementsIter>d__176 <ElementsIter>d__ = new PhantomBattleChallenge.<ElementsIter>d__176(-2);
			<ElementsIter>d__.<>3__<>4__this = this;
			return <ElementsIter>d__;
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x002AF118 File Offset: 0x002AD318
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NpcChallengeSkillIdIter()或GetNpcChallengeSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NpcChallengeSkillId()
		{
			PhantomBattleChallenge phantomBattleChallenge = this;
			return phantomBattleChallenge.GetNpcChallengeSkillIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x002AF13C File Offset: 0x002AD33C
		[NullableContext(1)]
		public readonly IEnumerable<int> NpcChallengeSkillIdIter()
		{
			PhantomBattleChallenge.<NpcChallengeSkillIdIter>d__178 <NpcChallengeSkillIdIter>d__ = new PhantomBattleChallenge.<NpcChallengeSkillIdIter>d__178(-2);
			<NpcChallengeSkillIdIter>d__.<>3__<>4__this = this;
			return <NpcChallengeSkillIdIter>d__;
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x002AF151 File Offset: 0x002AD351
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NpcSkillDescListIter()或GetNpcSkillDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NpcSkillDescList()
		{
			return this.NpcSkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x002AF15E File Offset: 0x002AD35E
		[NullableContext(1)]
		public readonly IEnumerable<string> NpcSkillDescListIter()
		{
			PhantomBattleChallenge.<NpcSkillDescListIter>d__180 <NpcSkillDescListIter>d__ = new PhantomBattleChallenge.<NpcSkillDescListIter>d__180(-2);
			<NpcSkillDescListIter>d__.<>3__<>4__this = this;
			return <NpcSkillDescListIter>d__;
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x002AF173 File Offset: 0x002AD373
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NpcSkillDescParamsListIter()或GetNpcSkillDescParamsListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] NpcSkillDescParamsList()
		{
			return this.NpcSkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x002AF180 File Offset: 0x002AD380
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> NpcSkillDescParamsListIter()
		{
			PhantomBattleChallenge.<NpcSkillDescParamsListIter>d__182 <NpcSkillDescParamsListIter>d__ = new PhantomBattleChallenge.<NpcSkillDescParamsListIter>d__182(-2);
			<NpcSkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <NpcSkillDescParamsListIter>d__;
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x002AF195 File Offset: 0x002AD395
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NpcSkillIconListIter()或GetNpcSkillIconListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NpcSkillIconList()
		{
			return this.NpcSkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x002AF1A2 File Offset: 0x002AD3A2
		[NullableContext(1)]
		public readonly IEnumerable<string> NpcSkillIconListIter()
		{
			PhantomBattleChallenge.<NpcSkillIconListIter>d__184 <NpcSkillIconListIter>d__ = new PhantomBattleChallenge.<NpcSkillIconListIter>d__184(-2);
			<NpcSkillIconListIter>d__.<>3__<>4__this = this;
			return <NpcSkillIconListIter>d__;
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x002AF1B7 File Offset: 0x002AD3B7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NpcSkillNameListIter()或GetNpcSkillNameListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NpcSkillNameList()
		{
			return this.NpcSkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x002AF1C4 File Offset: 0x002AD3C4
		[NullableContext(1)]
		public readonly IEnumerable<string> NpcSkillNameListIter()
		{
			PhantomBattleChallenge.<NpcSkillNameListIter>d__186 <NpcSkillNameListIter>d__ = new PhantomBattleChallenge.<NpcSkillNameListIter>d__186(-2);
			<NpcSkillNameListIter>d__.<>3__<>4__this = this;
			return <NpcSkillNameListIter>d__;
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x002AF1DC File Offset: 0x002AD3DC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PassDropIdFrozenDict()缓存字典，遍历请使用PassDropIdIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PassDropId()
		{
			return this.PassDropIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x002AF232 File Offset: 0x002AD432
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PassDropIdIter()
		{
			PhantomBattleChallenge.<PassDropIdIter>d__188 <PassDropIdIter>d__ = new PhantomBattleChallenge.<PassDropIdIter>d__188(-2);
			<PassDropIdIter>d__.<>3__<>4__this = this;
			return <PassDropIdIter>d__;
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x002AF248 File Offset: 0x002AD448
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreGuideQuestIter()或GetPreGuideQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreGuideQuest()
		{
			PhantomBattleChallenge phantomBattleChallenge = this;
			return phantomBattleChallenge.GetPreGuideQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x002AF26C File Offset: 0x002AD46C
		[NullableContext(1)]
		public readonly IEnumerable<int> PreGuideQuestIter()
		{
			PhantomBattleChallenge.<PreGuideQuestIter>d__190 <PreGuideQuestIter>d__ = new PhantomBattleChallenge.<PreGuideQuestIter>d__190(-2);
			<PreGuideQuestIter>d__.<>3__<>4__this = this;
			return <PreGuideQuestIter>d__;
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x002AF284 File Offset: 0x002AD484
		public int? GetDialogMap(int key)
		{
			this.EnsureDialogMapCacheIfNeeded();
			int value;
			if (!this.DialogMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x002AF2B8 File Offset: 0x002AD4B8
		public int? GetPassDropId(int key)
		{
			this.EnsurePassDropIdCacheIfNeeded();
			int value;
			if (!this.PassDropIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x002AF2EC File Offset: 0x002AD4EC
		private void EnsureDialogMapCacheIfNeeded()
		{
			if (this.DialogMapCache != null)
			{
				return;
			}
			this.DialogMapCache = this.DialogMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x002AF354 File Offset: 0x002AD554
		private void EnsurePassDropIdCacheIfNeeded()
		{
			if (this.PassDropIdCache != null)
			{
				return;
			}
			this.PassDropIdCache = this.PassDropIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x002AF3BA File Offset: 0x002AD5BA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDialogMapFrozenDict(int key)
		{
			this.EnsureDialogMapCacheIfNeeded();
			return this.DialogMapCache;
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x002AF3C8 File Offset: 0x002AD5C8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPassDropIdFrozenDict(int key)
		{
			this.EnsurePassDropIdCacheIfNeeded();
			return this.PassDropIdCache;
		}

		// Token: 0x04004F85 RID: 20357
		private Table __p;

		// Token: 0x04004F86 RID: 20358
		[Nullable(2)]
		private FrozenDictionary<int, int> DialogMapCache;

		// Token: 0x04004F87 RID: 20359
		[Nullable(2)]
		private FrozenDictionary<int, int> PassDropIdCache;
	}
}
