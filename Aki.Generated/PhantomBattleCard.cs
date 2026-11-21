using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA5 RID: 4005
	public struct PhantomBattleCard : IFlatbufferObject
	{
		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x002C762C File Offset: 0x002C582C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x002C7639 File Offset: 0x002C5839
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x002C7640 File Offset: 0x002C5840
		public static PhantomBattleCard GetRootAsPhantomBattleCard(ByteBuffer _bb)
		{
			return PhantomBattleCard.GetRootAsPhantomBattleCard(_bb, default(PhantomBattleCard));
		}

		// Token: 0x0600AABF RID: 43711 RVA: 0x002C765C File Offset: 0x002C585C
		public static PhantomBattleCard GetRootAsPhantomBattleCard(ByteBuffer _bb, PhantomBattleCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAC0 RID: 43712 RVA: 0x002C7679 File Offset: 0x002C5879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAC1 RID: 43713 RVA: 0x002C7688 File Offset: 0x002C5888
		public PhantomBattleCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x002C7698 File Offset: 0x002C5898
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

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x0600AAC3 RID: 43715 RVA: 0x002C76D4 File Offset: 0x002C58D4
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

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x002C7710 File Offset: 0x002C5910
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x002C774C File Offset: 0x002C594C
		public int ItemType
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

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x002C778C File Offset: 0x002C598C
		public int DealDurabilityEmptyType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x0600AAC7 RID: 43719 RVA: 0x002C77CC File Offset: 0x002C59CC
		public int CopyLifeRound
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x002C780C File Offset: 0x002C5A0C
		public int SkillDelay
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

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x002C784C File Offset: 0x002C5A4C
		public OneItemConfig? UnlockConsumeItems(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x0600AACA RID: 43722 RVA: 0x002C78B0 File Offset: 0x002C5AB0
		public int UnlockConsumeItemsLength
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

		// Token: 0x0600AACB RID: 43723 RVA: 0x002C78DC File Offset: 0x002C5ADC
		public OneItemConfig? UpOutLookConsumeItems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x0600AACC RID: 43724 RVA: 0x002C7940 File Offset: 0x002C5B40
		public int UpOutLookConsumeItemsLength
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

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x0600AACD RID: 43725 RVA: 0x002C796C File Offset: 0x002C5B6C
		public string Name
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

		// Token: 0x0600AACE RID: 43726 RVA: 0x002C79A4 File Offset: 0x002C5BA4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AACF RID: 43727 RVA: 0x002C79B4 File Offset: 0x002C5BB4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x002C79CC File Offset: 0x002C5BCC
		public int BattlePower
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

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x0600AAD1 RID: 43729 RVA: 0x002C7A0C File Offset: 0x002C5C0C
		public int Cost
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

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x0600AAD2 RID: 43730 RVA: 0x002C7A4C File Offset: 0x002C5C4C
		public int BackRecoverCost
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

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x0600AAD3 RID: 43731 RVA: 0x002C7A8C File Offset: 0x002C5C8C
		public int Element
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

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x0600AAD4 RID: 43732 RVA: 0x002C7ACC File Offset: 0x002C5CCC
		public int CardGroupNum
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x0600AAD5 RID: 43733 RVA: 0x002C7B0C File Offset: 0x002C5D0C
		public int SlotTendency
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x002C7B4C File Offset: 0x002C5D4C
		public int CardAddTendency(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0600AAD7 RID: 43735 RVA: 0x002C7B8C File Offset: 0x002C5D8C
		public int CardAddTendencyLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x002C7BB8 File Offset: 0x002C5DB8
		public Span<int> GetCardAddTendencyBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600AAD9 RID: 43737 RVA: 0x002C7BC8 File Offset: 0x002C5DC8
		public int[] GetCardAddTendencyArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x002C7BE0 File Offset: 0x002C5DE0
		public int PassiveSkillId(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600AADB RID: 43739 RVA: 0x002C7C20 File Offset: 0x002C5E20
		public int PassiveSkillIdLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x002C7C4C File Offset: 0x002C5E4C
		public Span<int> GetPassiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600AADD RID: 43741 RVA: 0x002C7C5C File Offset: 0x002C5E5C
		public int[] GetPassiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0600AADE RID: 43742 RVA: 0x002C7C74 File Offset: 0x002C5E74
		public int CountSkill
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

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0600AADF RID: 43743 RVA: 0x002C7CB4 File Offset: 0x002C5EB4
		public int CountConfig
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

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x0600AAE0 RID: 43744 RVA: 0x002C7CF4 File Offset: 0x002C5EF4
		public int ActiveSkillTag
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

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x002C7D34 File Offset: 0x002C5F34
		public int ActiveSkillId
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

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x002C7D74 File Offset: 0x002C5F74
		public int DurableSkillId
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

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x002C7DB4 File Offset: 0x002C5FB4
		public int DurableSkillCd
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x002C7DF4 File Offset: 0x002C5FF4
		public string FieldConditionDesc
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

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x002C7E2C File Offset: 0x002C602C
		public Span<byte> GetFieldConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x002C7E3C File Offset: 0x002C603C
		public byte[] GetFieldConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x002C7E54 File Offset: 0x002C6054
		public string FieldUnlockConditionDesc
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x002C7E8C File Offset: 0x002C608C
		public Span<byte> GetFieldUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x002C7E9C File Offset: 0x002C609C
		public byte[] GetFieldUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x0600AAEA RID: 43754 RVA: 0x002C7EB4 File Offset: 0x002C60B4
		public string FieldConditionIcon
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x002C7EEC File Offset: 0x002C60EC
		public Span<byte> GetFieldConditionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x002C7EFC File Offset: 0x002C60FC
		public byte[] GetFieldConditionIconArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x002C7F14 File Offset: 0x002C6114
		public string FieldTriggerDesc
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x002C7F4C File Offset: 0x002C614C
		public Span<byte> GetFieldTriggerDescBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x002C7F5C File Offset: 0x002C615C
		public byte[] GetFieldTriggerDescArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x002C7F74 File Offset: 0x002C6174
		public int CardFactorId(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x002C7FB4 File Offset: 0x002C61B4
		public int CardFactorIdLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x002C7FE0 File Offset: 0x002C61E0
		public Span<int> GetCardFactorIdBytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x002C7FF0 File Offset: 0x002C61F0
		public int[] GetCardFactorIdArray()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x002C8008 File Offset: 0x002C6208
		public DicIntInt? InitAttack(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600AAF5 RID: 43765 RVA: 0x002C806C File Offset: 0x002C626C
		public int InitAttackLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x0600AAF6 RID: 43766 RVA: 0x002C8098 File Offset: 0x002C6298
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x0600AAF7 RID: 43767 RVA: 0x002C80D8 File Offset: 0x002C62D8
		public int AttrLevel
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x002C8118 File Offset: 0x002C6318
		public int BaseProId
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

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x0600AAF9 RID: 43769 RVA: 0x002C8158 File Offset: 0x002C6358
		public string CardEffectDescription
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

		// Token: 0x0600AAFA RID: 43770 RVA: 0x002C8190 File Offset: 0x002C6390
		public Span<byte> GetCardEffectDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x002C81A0 File Offset: 0x002C63A0
		public byte[] GetCardEffectDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x002C81B8 File Offset: 0x002C63B8
		public string CardEffectDescriptionParams(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x002C81F4 File Offset: 0x002C63F4
		public int CardEffectDescriptionParamsLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x002C8220 File Offset: 0x002C6420
		public string DurableSkillDescription
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

		// Token: 0x0600AAFF RID: 43775 RVA: 0x002C8258 File Offset: 0x002C6458
		public Span<byte> GetDurableSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x002C8268 File Offset: 0x002C6468
		public byte[] GetDurableSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x002C8280 File Offset: 0x002C6480
		public string DurableSkillDescriptionParams(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002C82BC File Offset: 0x002C64BC
		public int DurableSkillDescriptionParamsLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x0600AB03 RID: 43779 RVA: 0x002C82E8 File Offset: 0x002C64E8
		public string CountSkillDescription
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

		// Token: 0x0600AB04 RID: 43780 RVA: 0x002C8320 File Offset: 0x002C6520
		public Span<byte> GetCountSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x002C8330 File Offset: 0x002C6530
		public byte[] GetCountSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x002C8348 File Offset: 0x002C6548
		public string CountSkillDescriptionParams(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x0600AB07 RID: 43783 RVA: 0x002C8384 File Offset: 0x002C6584
		public int CountSkillDescriptionParamsLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x002C83B0 File Offset: 0x002C65B0
		public int EntryIdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x0600AB09 RID: 43785 RVA: 0x002C83F0 File Offset: 0x002C65F0
		public int EntryIdListLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x002C841C File Offset: 0x002C661C
		public Span<int> GetEntryIdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x002C842C File Offset: 0x002C662C
		public int[] GetEntryIdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x002C8444 File Offset: 0x002C6644
		public string CardFaceTexture
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x002C847C File Offset: 0x002C667C
		public Span<byte> GetCardFaceTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x002C848C File Offset: 0x002C668C
		public byte[] GetCardFaceTextureArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x002C84A4 File Offset: 0x002C66A4
		public string DeckFaceTexture
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

		// Token: 0x0600AB10 RID: 43792 RVA: 0x002C84DC File Offset: 0x002C66DC
		public Span<byte> GetDeckFaceTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x002C84EC File Offset: 0x002C66EC
		public byte[] GetDeckFaceTextureArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x002C8504 File Offset: 0x002C6704
		public string BvbIcon
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x002C853C File Offset: 0x002C673C
		public Span<byte> GetBvbIconBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x002C854C File Offset: 0x002C674C
		public byte[] GetBvbIconArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x0600AB15 RID: 43797 RVA: 0x002C8564 File Offset: 0x002C6764
		public string SpineAtlas
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

		// Token: 0x0600AB16 RID: 43798 RVA: 0x002C859C File Offset: 0x002C679C
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x002C85AC File Offset: 0x002C67AC
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x002C85C4 File Offset: 0x002C67C4
		public string SpineSkeleton
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

		// Token: 0x0600AB19 RID: 43801 RVA: 0x002C85FC File Offset: 0x002C67FC
		public Span<byte> GetSpineSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600AB1A RID: 43802 RVA: 0x002C860C File Offset: 0x002C680C
		public byte[] GetSpineSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x0600AB1B RID: 43803 RVA: 0x002C8624 File Offset: 0x002C6824
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x002C8664 File Offset: 0x002C6864
		public string ConditionDesc
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

		// Token: 0x0600AB1D RID: 43805 RVA: 0x002C869C File Offset: 0x002C689C
		public Span<byte> GetConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x002C86AC File Offset: 0x002C68AC
		public byte[] GetConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x0600AB1F RID: 43807 RVA: 0x002C86C4 File Offset: 0x002C68C4
		public bool EnableBuy
		{
			get
			{
				int num = this.__p.__offset(98);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x002C8704 File Offset: 0x002C6904
		public string TypeDescription
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

		// Token: 0x0600AB21 RID: 43809 RVA: 0x002C873C File Offset: 0x002C693C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x002C874C File Offset: 0x002C694C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x0600AB23 RID: 43811 RVA: 0x002C8764 File Offset: 0x002C6964
		public string AttributesDescription
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

		// Token: 0x0600AB24 RID: 43812 RVA: 0x002C879C File Offset: 0x002C699C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x002C87AC File Offset: 0x002C69AC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x002C87C4 File Offset: 0x002C69C4
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x002C87FC File Offset: 0x002C69FC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x002C880C File Offset: 0x002C6A0C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x0600AB29 RID: 43817 RVA: 0x002C8824 File Offset: 0x002C6A24
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x002C885C File Offset: 0x002C6A5C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x002C886C File Offset: 0x002C6A6C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600AB2C RID: 43820 RVA: 0x002C8884 File Offset: 0x002C6A84
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x002C88BC File Offset: 0x002C6ABC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x002C88CC File Offset: 0x002C6ACC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x002C88E4 File Offset: 0x002C6AE4
		public string IconSmall
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

		// Token: 0x0600AB30 RID: 43824 RVA: 0x002C891C File Offset: 0x002C6B1C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x002C892C File Offset: 0x002C6B2C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x002C8944 File Offset: 0x002C6B44
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x002C897C File Offset: 0x002C6B7C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x002C898C File Offset: 0x002C6B8C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x002C89A4 File Offset: 0x002C6BA4
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x002C89DC File Offset: 0x002C6BDC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x002C89EC File Offset: 0x002C6BEC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600AB38 RID: 43832 RVA: 0x002C8A04 File Offset: 0x002C6C04
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(116);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x002C8A44 File Offset: 0x002C6C44
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(118);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x002C8A84 File Offset: 0x002C6C84
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x002C8AB0 File Offset: 0x002C6CB0
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(118, 4);
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x002C8AC0 File Offset: 0x002C6CC0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(118) ?? Array.Empty<int>();
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0600AB3D RID: 43837 RVA: 0x002C8AD8 File Offset: 0x002C6CD8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x002C8B18 File Offset: 0x002C6D18
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600AB3F RID: 43839 RVA: 0x002C8B58 File Offset: 0x002C6D58
		public string AtmosphereEffect
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x002C8B90 File Offset: 0x002C6D90
		public Span<byte> GetAtmosphereEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x002C8BA0 File Offset: 0x002C6DA0
		public byte[] GetAtmosphereEffectArray()
		{
			return this.__p.__vector_as_array<byte>(124) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x002C8BB8 File Offset: 0x002C6DB8
		public string SettingEffect(int j)
		{
			int num = this.__p.__offset(126);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600AB43 RID: 43843 RVA: 0x002C8BF4 File Offset: 0x002C6DF4
		public int SettingEffectLength
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002C8C20 File Offset: 0x002C6E20
		public string TaskBg
		{
			get
			{
				int num = this.__p.__offset(128);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x002C8C5B File Offset: 0x002C6E5B
		public Span<byte> GetTaskBgBytes()
		{
			return this.__p.__vector_as_span<byte>(128, 1);
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x002C8C6E File Offset: 0x002C6E6E
		public byte[] GetTaskBgArray()
		{
			return this.__p.__vector_as_array<byte>(128) ?? Array.Empty<byte>();
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x002C8C8C File Offset: 0x002C6E8C
		public string FieldBg
		{
			get
			{
				int num = this.__p.__offset(130);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x002C8CC7 File Offset: 0x002C6EC7
		public Span<byte> GetFieldBgBytes()
		{
			return this.__p.__vector_as_span<byte>(130, 1);
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x002C8CDA File Offset: 0x002C6EDA
		public byte[] GetFieldBgArray()
		{
			return this.__p.__vector_as_array<byte>(130) ?? Array.Empty<byte>();
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x002C8CF8 File Offset: 0x002C6EF8
		public int EffectId
		{
			get
			{
				int num = this.__p.__offset(132);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x002C8D38 File Offset: 0x002C6F38
		public bool IsNpcCard
		{
			get
			{
				int num = this.__p.__offset(134);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x002C8D7B File Offset: 0x002C6F7B
		[NullableContext(1)]
		public int[] CardAddTendency()
		{
			return this.GetCardAddTendencyArray();
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x002C8D83 File Offset: 0x002C6F83
		[NullableContext(1)]
		public IEnumerable<int> CardAddTendencyIter()
		{
			PhantomBattleCard.<CardAddTendencyIter>d__213 <CardAddTendencyIter>d__ = new PhantomBattleCard.<CardAddTendencyIter>d__213(-2);
			<CardAddTendencyIter>d__.<>3__<>4__this = this;
			return <CardAddTendencyIter>d__;
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x002C8D98 File Offset: 0x002C6F98
		[NullableContext(1)]
		public string[] CardEffectDescriptionParams()
		{
			return this.CardEffectDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x002C8DA5 File Offset: 0x002C6FA5
		[NullableContext(1)]
		public IEnumerable<string> CardEffectDescriptionParamsIter()
		{
			PhantomBattleCard.<CardEffectDescriptionParamsIter>d__215 <CardEffectDescriptionParamsIter>d__ = new PhantomBattleCard.<CardEffectDescriptionParamsIter>d__215(-2);
			<CardEffectDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <CardEffectDescriptionParamsIter>d__;
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x002C8DBA File Offset: 0x002C6FBA
		[NullableContext(1)]
		public int[] CardFactorId()
		{
			return this.GetCardFactorIdArray();
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x002C8DC2 File Offset: 0x002C6FC2
		[NullableContext(1)]
		public IEnumerable<int> CardFactorIdIter()
		{
			PhantomBattleCard.<CardFactorIdIter>d__217 <CardFactorIdIter>d__ = new PhantomBattleCard.<CardFactorIdIter>d__217(-2);
			<CardFactorIdIter>d__.<>3__<>4__this = this;
			return <CardFactorIdIter>d__;
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x002C8DD7 File Offset: 0x002C6FD7
		[NullableContext(1)]
		public string[] CountSkillDescriptionParams()
		{
			return this.CountSkillDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x002C8DE4 File Offset: 0x002C6FE4
		[NullableContext(1)]
		public IEnumerable<string> CountSkillDescriptionParamsIter()
		{
			PhantomBattleCard.<CountSkillDescriptionParamsIter>d__219 <CountSkillDescriptionParamsIter>d__ = new PhantomBattleCard.<CountSkillDescriptionParamsIter>d__219(-2);
			<CountSkillDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <CountSkillDescriptionParamsIter>d__;
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x002C8DF9 File Offset: 0x002C6FF9
		[NullableContext(1)]
		public string[] DurableSkillDescriptionParams()
		{
			return this.DurableSkillDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x002C8E06 File Offset: 0x002C7006
		[NullableContext(1)]
		public IEnumerable<string> DurableSkillDescriptionParamsIter()
		{
			PhantomBattleCard.<DurableSkillDescriptionParamsIter>d__221 <DurableSkillDescriptionParamsIter>d__ = new PhantomBattleCard.<DurableSkillDescriptionParamsIter>d__221(-2);
			<DurableSkillDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DurableSkillDescriptionParamsIter>d__;
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x002C8E1B File Offset: 0x002C701B
		[NullableContext(1)]
		public int[] EntryIdList()
		{
			return this.GetEntryIdListArray();
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x002C8E23 File Offset: 0x002C7023
		[NullableContext(1)]
		public IEnumerable<int> EntryIdListIter()
		{
			PhantomBattleCard.<EntryIdListIter>d__223 <EntryIdListIter>d__ = new PhantomBattleCard.<EntryIdListIter>d__223(-2);
			<EntryIdListIter>d__.<>3__<>4__this = this;
			return <EntryIdListIter>d__;
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x002C8E38 File Offset: 0x002C7038
		[NullableContext(1)]
		public Dictionary<int, int> InitAttack()
		{
			return this.InitAttackIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x002C8E8E File Offset: 0x002C708E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> InitAttackIter()
		{
			PhantomBattleCard.<InitAttackIter>d__225 <InitAttackIter>d__ = new PhantomBattleCard.<InitAttackIter>d__225(-2);
			<InitAttackIter>d__.<>3__<>4__this = this;
			return <InitAttackIter>d__;
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x002C8EA3 File Offset: 0x002C70A3
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x002C8EAB File Offset: 0x002C70AB
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			PhantomBattleCard.<ItemAccessIter>d__227 <ItemAccessIter>d__ = new PhantomBattleCard.<ItemAccessIter>d__227(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x002C8EC0 File Offset: 0x002C70C0
		[NullableContext(1)]
		public int[] PassiveSkillId()
		{
			return this.GetPassiveSkillIdArray();
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x002C8EC8 File Offset: 0x002C70C8
		[NullableContext(1)]
		public IEnumerable<int> PassiveSkillIdIter()
		{
			PhantomBattleCard.<PassiveSkillIdIter>d__229 <PassiveSkillIdIter>d__ = new PhantomBattleCard.<PassiveSkillIdIter>d__229(-2);
			<PassiveSkillIdIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIdIter>d__;
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x002C8EDD File Offset: 0x002C70DD
		[NullableContext(1)]
		public string[] SettingEffect()
		{
			return this.SettingEffectIter().ToArray<string>();
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x002C8EEA File Offset: 0x002C70EA
		[NullableContext(1)]
		public IEnumerable<string> SettingEffectIter()
		{
			PhantomBattleCard.<SettingEffectIter>d__231 <SettingEffectIter>d__ = new PhantomBattleCard.<SettingEffectIter>d__231(-2);
			<SettingEffectIter>d__.<>3__<>4__this = this;
			return <SettingEffectIter>d__;
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x002C8EFF File Offset: 0x002C70FF
		[NullableContext(1)]
		public OneItemConfig[] UnlockConsumeItems()
		{
			return this.UnlockConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x002C8F0C File Offset: 0x002C710C
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> UnlockConsumeItemsIter()
		{
			PhantomBattleCard.<UnlockConsumeItemsIter>d__233 <UnlockConsumeItemsIter>d__ = new PhantomBattleCard.<UnlockConsumeItemsIter>d__233(-2);
			<UnlockConsumeItemsIter>d__.<>3__<>4__this = this;
			return <UnlockConsumeItemsIter>d__;
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x002C8F21 File Offset: 0x002C7121
		[NullableContext(1)]
		public OneItemConfig[] UpOutLookConsumeItems()
		{
			return this.UpOutLookConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x002C8F2E File Offset: 0x002C712E
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> UpOutLookConsumeItemsIter()
		{
			PhantomBattleCard.<UpOutLookConsumeItemsIter>d__235 <UpOutLookConsumeItemsIter>d__ = new PhantomBattleCard.<UpOutLookConsumeItemsIter>d__235(-2);
			<UpOutLookConsumeItemsIter>d__.<>3__<>4__this = this;
			return <UpOutLookConsumeItemsIter>d__;
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x002C8F44 File Offset: 0x002C7144
		public int? GetInitAttack(int key)
		{
			this.EnsureInitAttackCacheIfNeeded();
			int value;
			if (!this.InitAttackCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x002C8F78 File Offset: 0x002C7178
		private void EnsureInitAttackCacheIfNeeded()
		{
			if (this.InitAttackCache != null)
			{
				return;
			}
			this.InitAttackCache = this.InitAttackIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x002C8FDE File Offset: 0x002C71DE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetInitAttackFrozenDict()
		{
			this.EnsureInitAttackCacheIfNeeded();
			return this.InitAttackCache;
		}

		// Token: 0x04005560 RID: 21856
		private Table __p;

		// Token: 0x04005561 RID: 21857
		[Nullable(2)]
		private FrozenDictionary<int, int> InitAttackCache;
	}
}
