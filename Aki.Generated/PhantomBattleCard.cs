using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC0 RID: 3776
	public struct PhantomBattleCard : IFlatbufferObject
	{
		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x002AA3A0 File Offset: 0x002A85A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x002AA3AD File Offset: 0x002A85AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x002AA3B4 File Offset: 0x002A85B4
		public static PhantomBattleCard GetRootAsPhantomBattleCard(ByteBuffer _bb)
		{
			return PhantomBattleCard.GetRootAsPhantomBattleCard(_bb, default(PhantomBattleCard));
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x002AA3D0 File Offset: 0x002A85D0
		public static PhantomBattleCard GetRootAsPhantomBattleCard(ByteBuffer _bb, PhantomBattleCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x002AA3ED File Offset: 0x002A85ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x002AA3FC File Offset: 0x002A85FC
		public PhantomBattleCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x002AA40C File Offset: 0x002A860C
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

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x002AA448 File Offset: 0x002A8648
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

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x002AA484 File Offset: 0x002A8684
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

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x0600A4A4 RID: 42148 RVA: 0x002AA4C0 File Offset: 0x002A86C0
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

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x0600A4A5 RID: 42149 RVA: 0x002AA500 File Offset: 0x002A8700
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

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x0600A4A6 RID: 42150 RVA: 0x002AA540 File Offset: 0x002A8740
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

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x002AA580 File Offset: 0x002A8780
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

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x002AA5C0 File Offset: 0x002A87C0
		public OneItemConfig? UnlockConsumeItems(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x002AA624 File Offset: 0x002A8824
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

		// Token: 0x0600A4AA RID: 42154 RVA: 0x002AA650 File Offset: 0x002A8850
		public OneItemConfig? UpOutLookConsumeItems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x002AA6B4 File Offset: 0x002A88B4
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

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x002AA6E0 File Offset: 0x002A88E0
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

		// Token: 0x0600A4AD RID: 42157 RVA: 0x002AA718 File Offset: 0x002A8918
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x002AA728 File Offset: 0x002A8928
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600A4AF RID: 42159 RVA: 0x002AA740 File Offset: 0x002A8940
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

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x002AA780 File Offset: 0x002A8980
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

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x0600A4B1 RID: 42161 RVA: 0x002AA7C0 File Offset: 0x002A89C0
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

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x002AA800 File Offset: 0x002A8A00
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

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x0600A4B3 RID: 42163 RVA: 0x002AA840 File Offset: 0x002A8A40
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

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x0600A4B4 RID: 42164 RVA: 0x002AA880 File Offset: 0x002A8A80
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

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x002AA8C0 File Offset: 0x002A8AC0
		public int CardAddTendency(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x0600A4B6 RID: 42166 RVA: 0x002AA900 File Offset: 0x002A8B00
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

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x002AA92C File Offset: 0x002A8B2C
		public Span<int> GetCardAddTendencyBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x002AA93C File Offset: 0x002A8B3C
		public int[] GetCardAddTendencyArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x002AA954 File Offset: 0x002A8B54
		public int PassiveSkillId(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x0600A4BA RID: 42170 RVA: 0x002AA994 File Offset: 0x002A8B94
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

		// Token: 0x0600A4BB RID: 42171 RVA: 0x002AA9C0 File Offset: 0x002A8BC0
		public Span<int> GetPassiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x002AA9D0 File Offset: 0x002A8BD0
		public int[] GetPassiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x002AA9E8 File Offset: 0x002A8BE8
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

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x0600A4BE RID: 42174 RVA: 0x002AAA28 File Offset: 0x002A8C28
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

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x002AAA68 File Offset: 0x002A8C68
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

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600A4C0 RID: 42176 RVA: 0x002AAAA8 File Offset: 0x002A8CA8
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

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x002AAAE8 File Offset: 0x002A8CE8
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

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x0600A4C2 RID: 42178 RVA: 0x002AAB28 File Offset: 0x002A8D28
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

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x002AAB68 File Offset: 0x002A8D68
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

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x002AABA0 File Offset: 0x002A8DA0
		public Span<byte> GetFieldConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x002AABB0 File Offset: 0x002A8DB0
		public byte[] GetFieldConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x0600A4C6 RID: 42182 RVA: 0x002AABC8 File Offset: 0x002A8DC8
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

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x002AAC00 File Offset: 0x002A8E00
		public Span<byte> GetFieldUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x002AAC10 File Offset: 0x002A8E10
		public byte[] GetFieldUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x0600A4C9 RID: 42185 RVA: 0x002AAC28 File Offset: 0x002A8E28
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

		// Token: 0x0600A4CA RID: 42186 RVA: 0x002AAC60 File Offset: 0x002A8E60
		public Span<byte> GetFieldConditionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x002AAC70 File Offset: 0x002A8E70
		public byte[] GetFieldConditionIconArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x0600A4CC RID: 42188 RVA: 0x002AAC88 File Offset: 0x002A8E88
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

		// Token: 0x0600A4CD RID: 42189 RVA: 0x002AACC0 File Offset: 0x002A8EC0
		public Span<byte> GetFieldTriggerDescBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x002AACD0 File Offset: 0x002A8ED0
		public byte[] GetFieldTriggerDescArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x002AACE8 File Offset: 0x002A8EE8
		public int CardFactorId(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x002AAD28 File Offset: 0x002A8F28
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

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x002AAD54 File Offset: 0x002A8F54
		public Span<int> GetCardFactorIdBytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x002AAD64 File Offset: 0x002A8F64
		public int[] GetCardFactorIdArray()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x002AAD7C File Offset: 0x002A8F7C
		public DicIntInt? InitAttack(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x002AADE0 File Offset: 0x002A8FE0
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

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600A4D5 RID: 42197 RVA: 0x002AAE0C File Offset: 0x002A900C
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

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x002AAE4C File Offset: 0x002A904C
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

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x0600A4D7 RID: 42199 RVA: 0x002AAE8C File Offset: 0x002A908C
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

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x0600A4D8 RID: 42200 RVA: 0x002AAECC File Offset: 0x002A90CC
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

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x002AAF04 File Offset: 0x002A9104
		public Span<byte> GetCardEffectDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x002AAF14 File Offset: 0x002A9114
		public byte[] GetCardEffectDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x002AAF2C File Offset: 0x002A912C
		public string CardEffectDescriptionParams(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600A4DC RID: 42204 RVA: 0x002AAF68 File Offset: 0x002A9168
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

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600A4DD RID: 42205 RVA: 0x002AAF94 File Offset: 0x002A9194
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

		// Token: 0x0600A4DE RID: 42206 RVA: 0x002AAFCC File Offset: 0x002A91CC
		public Span<byte> GetDurableSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600A4DF RID: 42207 RVA: 0x002AAFDC File Offset: 0x002A91DC
		public byte[] GetDurableSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x002AAFF4 File Offset: 0x002A91F4
		public string DurableSkillDescriptionParams(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x0600A4E1 RID: 42209 RVA: 0x002AB030 File Offset: 0x002A9230
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

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x0600A4E2 RID: 42210 RVA: 0x002AB05C File Offset: 0x002A925C
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

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x002AB094 File Offset: 0x002A9294
		public Span<byte> GetCountSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x002AB0A4 File Offset: 0x002A92A4
		public byte[] GetCountSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x002AB0BC File Offset: 0x002A92BC
		public string CountSkillDescriptionParams(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x0600A4E6 RID: 42214 RVA: 0x002AB0F8 File Offset: 0x002A92F8
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

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x002AB124 File Offset: 0x002A9324
		public int EntryIdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x0600A4E8 RID: 42216 RVA: 0x002AB164 File Offset: 0x002A9364
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

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x002AB190 File Offset: 0x002A9390
		public Span<int> GetEntryIdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x002AB1A0 File Offset: 0x002A93A0
		public int[] GetEntryIdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x0600A4EB RID: 42219 RVA: 0x002AB1B8 File Offset: 0x002A93B8
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

		// Token: 0x0600A4EC RID: 42220 RVA: 0x002AB1F0 File Offset: 0x002A93F0
		public Span<byte> GetCardFaceTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x002AB200 File Offset: 0x002A9400
		public byte[] GetCardFaceTextureArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x0600A4EE RID: 42222 RVA: 0x002AB218 File Offset: 0x002A9418
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

		// Token: 0x0600A4EF RID: 42223 RVA: 0x002AB250 File Offset: 0x002A9450
		public Span<byte> GetDeckFaceTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x002AB260 File Offset: 0x002A9460
		public byte[] GetDeckFaceTextureArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600A4F1 RID: 42225 RVA: 0x002AB278 File Offset: 0x002A9478
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

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x002AB2B0 File Offset: 0x002A94B0
		public Span<byte> GetBvbIconBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x002AB2C0 File Offset: 0x002A94C0
		public byte[] GetBvbIconArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x0600A4F4 RID: 42228 RVA: 0x002AB2D8 File Offset: 0x002A94D8
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

		// Token: 0x0600A4F5 RID: 42229 RVA: 0x002AB310 File Offset: 0x002A9510
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x002AB320 File Offset: 0x002A9520
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x0600A4F7 RID: 42231 RVA: 0x002AB338 File Offset: 0x002A9538
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

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x002AB370 File Offset: 0x002A9570
		public Span<byte> GetSpineSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x002AB380 File Offset: 0x002A9580
		public byte[] GetSpineSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x002AB398 File Offset: 0x002A9598
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

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x002AB3D8 File Offset: 0x002A95D8
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

		// Token: 0x0600A4FC RID: 42236 RVA: 0x002AB410 File Offset: 0x002A9610
		public Span<byte> GetConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x002AB420 File Offset: 0x002A9620
		public byte[] GetConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0600A4FE RID: 42238 RVA: 0x002AB438 File Offset: 0x002A9638
		public bool EnableBuy
		{
			get
			{
				int num = this.__p.__offset(98);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600A4FF RID: 42239 RVA: 0x002AB478 File Offset: 0x002A9678
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

		// Token: 0x0600A500 RID: 42240 RVA: 0x002AB4B0 File Offset: 0x002A96B0
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x002AB4C0 File Offset: 0x002A96C0
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0600A502 RID: 42242 RVA: 0x002AB4D8 File Offset: 0x002A96D8
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

		// Token: 0x0600A503 RID: 42243 RVA: 0x002AB510 File Offset: 0x002A9710
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x002AB520 File Offset: 0x002A9720
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x002AB538 File Offset: 0x002A9738
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

		// Token: 0x0600A506 RID: 42246 RVA: 0x002AB570 File Offset: 0x002A9770
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x002AB580 File Offset: 0x002A9780
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0600A508 RID: 42248 RVA: 0x002AB598 File Offset: 0x002A9798
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

		// Token: 0x0600A509 RID: 42249 RVA: 0x002AB5D0 File Offset: 0x002A97D0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x002AB5E0 File Offset: 0x002A97E0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x002AB5F8 File Offset: 0x002A97F8
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

		// Token: 0x0600A50C RID: 42252 RVA: 0x002AB630 File Offset: 0x002A9830
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x002AB640 File Offset: 0x002A9840
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x0600A50E RID: 42254 RVA: 0x002AB658 File Offset: 0x002A9858
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

		// Token: 0x0600A50F RID: 42255 RVA: 0x002AB690 File Offset: 0x002A9890
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x002AB6A0 File Offset: 0x002A98A0
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x002AB6B8 File Offset: 0x002A98B8
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

		// Token: 0x0600A512 RID: 42258 RVA: 0x002AB6F0 File Offset: 0x002A98F0
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x002AB700 File Offset: 0x002A9900
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x002AB718 File Offset: 0x002A9918
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

		// Token: 0x0600A515 RID: 42261 RVA: 0x002AB750 File Offset: 0x002A9950
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x002AB760 File Offset: 0x002A9960
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x0600A517 RID: 42263 RVA: 0x002AB778 File Offset: 0x002A9978
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(116);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x002AB7B8 File Offset: 0x002A99B8
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(118);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x002AB7F8 File Offset: 0x002A99F8
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

		// Token: 0x0600A51A RID: 42266 RVA: 0x002AB824 File Offset: 0x002A9A24
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(118, 4);
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x002AB834 File Offset: 0x002A9A34
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(118) ?? Array.Empty<int>();
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600A51C RID: 42268 RVA: 0x002AB84C File Offset: 0x002A9A4C
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

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600A51D RID: 42269 RVA: 0x002AB88C File Offset: 0x002A9A8C
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

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x002AB8CC File Offset: 0x002A9ACC
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

		// Token: 0x0600A51F RID: 42271 RVA: 0x002AB904 File Offset: 0x002A9B04
		public Span<byte> GetAtmosphereEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x002AB914 File Offset: 0x002A9B14
		public byte[] GetAtmosphereEffectArray()
		{
			return this.__p.__vector_as_array<byte>(124) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x002AB92C File Offset: 0x002A9B2C
		public string SettingEffect(int j)
		{
			int num = this.__p.__offset(126);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x002AB968 File Offset: 0x002A9B68
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

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x0600A523 RID: 42275 RVA: 0x002AB994 File Offset: 0x002A9B94
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

		// Token: 0x0600A524 RID: 42276 RVA: 0x002AB9CF File Offset: 0x002A9BCF
		public Span<byte> GetTaskBgBytes()
		{
			return this.__p.__vector_as_span<byte>(128, 1);
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x002AB9E2 File Offset: 0x002A9BE2
		public byte[] GetTaskBgArray()
		{
			return this.__p.__vector_as_array<byte>(128) ?? Array.Empty<byte>();
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x002ABA00 File Offset: 0x002A9C00
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

		// Token: 0x0600A527 RID: 42279 RVA: 0x002ABA3B File Offset: 0x002A9C3B
		public Span<byte> GetFieldBgBytes()
		{
			return this.__p.__vector_as_span<byte>(130, 1);
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x002ABA4E File Offset: 0x002A9C4E
		public byte[] GetFieldBgArray()
		{
			return this.__p.__vector_as_array<byte>(130) ?? Array.Empty<byte>();
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x0600A529 RID: 42281 RVA: 0x002ABA6C File Offset: 0x002A9C6C
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

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0600A52A RID: 42282 RVA: 0x002ABAAC File Offset: 0x002A9CAC
		public bool IsNpcCard
		{
			get
			{
				int num = this.__p.__offset(134);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x002ABAF0 File Offset: 0x002A9CF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CardAddTendencyIter()或GetCardAddTendencyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CardAddTendency()
		{
			PhantomBattleCard phantomBattleCard = this;
			return phantomBattleCard.GetCardAddTendencyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x002ABB14 File Offset: 0x002A9D14
		[NullableContext(1)]
		public readonly IEnumerable<int> CardAddTendencyIter()
		{
			PhantomBattleCard.<CardAddTendencyIter>d__213 <CardAddTendencyIter>d__ = new PhantomBattleCard.<CardAddTendencyIter>d__213(-2);
			<CardAddTendencyIter>d__.<>3__<>4__this = this;
			return <CardAddTendencyIter>d__;
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x002ABB29 File Offset: 0x002A9D29
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CardEffectDescriptionParamsIter()或GetCardEffectDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CardEffectDescriptionParams()
		{
			return this.CardEffectDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x002ABB36 File Offset: 0x002A9D36
		[NullableContext(1)]
		public readonly IEnumerable<string> CardEffectDescriptionParamsIter()
		{
			PhantomBattleCard.<CardEffectDescriptionParamsIter>d__215 <CardEffectDescriptionParamsIter>d__ = new PhantomBattleCard.<CardEffectDescriptionParamsIter>d__215(-2);
			<CardEffectDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <CardEffectDescriptionParamsIter>d__;
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x002ABB4C File Offset: 0x002A9D4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CardFactorIdIter()或GetCardFactorIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CardFactorId()
		{
			PhantomBattleCard phantomBattleCard = this;
			return phantomBattleCard.GetCardFactorIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x002ABB70 File Offset: 0x002A9D70
		[NullableContext(1)]
		public readonly IEnumerable<int> CardFactorIdIter()
		{
			PhantomBattleCard.<CardFactorIdIter>d__217 <CardFactorIdIter>d__ = new PhantomBattleCard.<CardFactorIdIter>d__217(-2);
			<CardFactorIdIter>d__.<>3__<>4__this = this;
			return <CardFactorIdIter>d__;
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x002ABB85 File Offset: 0x002A9D85
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CountSkillDescriptionParamsIter()或GetCountSkillDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CountSkillDescriptionParams()
		{
			return this.CountSkillDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x002ABB92 File Offset: 0x002A9D92
		[NullableContext(1)]
		public readonly IEnumerable<string> CountSkillDescriptionParamsIter()
		{
			PhantomBattleCard.<CountSkillDescriptionParamsIter>d__219 <CountSkillDescriptionParamsIter>d__ = new PhantomBattleCard.<CountSkillDescriptionParamsIter>d__219(-2);
			<CountSkillDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <CountSkillDescriptionParamsIter>d__;
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x002ABBA7 File Offset: 0x002A9DA7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DurableSkillDescriptionParamsIter()或GetDurableSkillDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DurableSkillDescriptionParams()
		{
			return this.DurableSkillDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x002ABBB4 File Offset: 0x002A9DB4
		[NullableContext(1)]
		public readonly IEnumerable<string> DurableSkillDescriptionParamsIter()
		{
			PhantomBattleCard.<DurableSkillDescriptionParamsIter>d__221 <DurableSkillDescriptionParamsIter>d__ = new PhantomBattleCard.<DurableSkillDescriptionParamsIter>d__221(-2);
			<DurableSkillDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DurableSkillDescriptionParamsIter>d__;
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x002ABBCC File Offset: 0x002A9DCC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntryIdListIter()或GetEntryIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EntryIdList()
		{
			PhantomBattleCard phantomBattleCard = this;
			return phantomBattleCard.GetEntryIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x002ABBF0 File Offset: 0x002A9DF0
		[NullableContext(1)]
		public readonly IEnumerable<int> EntryIdListIter()
		{
			PhantomBattleCard.<EntryIdListIter>d__223 <EntryIdListIter>d__ = new PhantomBattleCard.<EntryIdListIter>d__223(-2);
			<EntryIdListIter>d__.<>3__<>4__this = this;
			return <EntryIdListIter>d__;
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x002ABC08 File Offset: 0x002A9E08
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InitAttackFrozenDict()缓存字典，遍历请使用InitAttackIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> InitAttack()
		{
			return this.InitAttackIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x002ABC5E File Offset: 0x002A9E5E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> InitAttackIter()
		{
			PhantomBattleCard.<InitAttackIter>d__225 <InitAttackIter>d__ = new PhantomBattleCard.<InitAttackIter>d__225(-2);
			<InitAttackIter>d__.<>3__<>4__this = this;
			return <InitAttackIter>d__;
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x002ABC74 File Offset: 0x002A9E74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			PhantomBattleCard phantomBattleCard = this;
			return phantomBattleCard.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x002ABC98 File Offset: 0x002A9E98
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			PhantomBattleCard.<ItemAccessIter>d__227 <ItemAccessIter>d__ = new PhantomBattleCard.<ItemAccessIter>d__227(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x002ABCB0 File Offset: 0x002A9EB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillIdIter()或GetPassiveSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PassiveSkillId()
		{
			PhantomBattleCard phantomBattleCard = this;
			return phantomBattleCard.GetPassiveSkillIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x002ABCD4 File Offset: 0x002A9ED4
		[NullableContext(1)]
		public readonly IEnumerable<int> PassiveSkillIdIter()
		{
			PhantomBattleCard.<PassiveSkillIdIter>d__229 <PassiveSkillIdIter>d__ = new PhantomBattleCard.<PassiveSkillIdIter>d__229(-2);
			<PassiveSkillIdIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIdIter>d__;
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x002ABCE9 File Offset: 0x002A9EE9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SettingEffectIter()或GetSettingEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SettingEffect()
		{
			return this.SettingEffectIter().ToArray<string>();
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x002ABCF6 File Offset: 0x002A9EF6
		[NullableContext(1)]
		public readonly IEnumerable<string> SettingEffectIter()
		{
			PhantomBattleCard.<SettingEffectIter>d__231 <SettingEffectIter>d__ = new PhantomBattleCard.<SettingEffectIter>d__231(-2);
			<SettingEffectIter>d__.<>3__<>4__this = this;
			return <SettingEffectIter>d__;
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x002ABD0B File Offset: 0x002A9F0B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockConsumeItemsIter()或GetUnlockConsumeItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] UnlockConsumeItems()
		{
			return this.UnlockConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x002ABD18 File Offset: 0x002A9F18
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> UnlockConsumeItemsIter()
		{
			PhantomBattleCard.<UnlockConsumeItemsIter>d__233 <UnlockConsumeItemsIter>d__ = new PhantomBattleCard.<UnlockConsumeItemsIter>d__233(-2);
			<UnlockConsumeItemsIter>d__.<>3__<>4__this = this;
			return <UnlockConsumeItemsIter>d__;
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x002ABD2D File Offset: 0x002A9F2D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpOutLookConsumeItemsIter()或GetUpOutLookConsumeItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] UpOutLookConsumeItems()
		{
			return this.UpOutLookConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x002ABD3A File Offset: 0x002A9F3A
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> UpOutLookConsumeItemsIter()
		{
			PhantomBattleCard.<UpOutLookConsumeItemsIter>d__235 <UpOutLookConsumeItemsIter>d__ = new PhantomBattleCard.<UpOutLookConsumeItemsIter>d__235(-2);
			<UpOutLookConsumeItemsIter>d__.<>3__<>4__this = this;
			return <UpOutLookConsumeItemsIter>d__;
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x002ABD50 File Offset: 0x002A9F50
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

		// Token: 0x0600A544 RID: 42308 RVA: 0x002ABD84 File Offset: 0x002A9F84
		private void EnsureInitAttackCacheIfNeeded()
		{
			if (this.InitAttackCache != null)
			{
				return;
			}
			this.InitAttackCache = this.InitAttackIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x002ABDEA File Offset: 0x002A9FEA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetInitAttackFrozenDict(int key)
		{
			this.EnsureInitAttackCacheIfNeeded();
			return this.InitAttackCache;
		}

		// Token: 0x04004F7B RID: 20347
		private Table __p;

		// Token: 0x04004F7C RID: 20348
		[Nullable(2)]
		private FrozenDictionary<int, int> InitAttackCache;
	}
}
