using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F7 RID: 21495
	public struct IAttributeComponent : IFlatbufferObject
	{
		// Token: 0x1700981E RID: 38942
		// (get) Token: 0x06021983 RID: 137603 RVA: 0x004A1C96 File Offset: 0x0049FE96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021984 RID: 137604 RVA: 0x004A1CA3 File Offset: 0x0049FEA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021985 RID: 137605 RVA: 0x004A1CAC File Offset: 0x0049FEAC
		public static IAttributeComponent GetRootAsIAttributeComponent(ByteBuffer _bb)
		{
			return IAttributeComponent.GetRootAsIAttributeComponent(_bb, default(IAttributeComponent));
		}

		// Token: 0x06021986 RID: 137606 RVA: 0x004A1CC8 File Offset: 0x0049FEC8
		public static IAttributeComponent GetRootAsIAttributeComponent(ByteBuffer _bb, IAttributeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021987 RID: 137607 RVA: 0x004A1CE5 File Offset: 0x0049FEE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021988 RID: 137608 RVA: 0x004A1CF4 File Offset: 0x0049FEF4
		public IAttributeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700981F RID: 38943
		// (get) Token: 0x06021989 RID: 137609 RVA: 0x004A1D04 File Offset: 0x0049FF04
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009820 RID: 38944
		// (get) Token: 0x0602198A RID: 137610 RVA: 0x004A1D44 File Offset: 0x0049FF44
		public int PropertyId
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

		// Token: 0x17009821 RID: 38945
		// (get) Token: 0x0602198B RID: 137611 RVA: 0x004A1D80 File Offset: 0x0049FF80
		public int MonsterPropExtraRateId
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

		// Token: 0x17009822 RID: 38946
		// (get) Token: 0x0602198C RID: 137612 RVA: 0x004A1DBC File Offset: 0x0049FFBC
		public int MonsterPropGrowthId
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

		// Token: 0x17009823 RID: 38947
		// (get) Token: 0x0602198D RID: 137613 RVA: 0x004A1DFC File Offset: 0x0049FFFC
		public int Level
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

		// Token: 0x17009824 RID: 38948
		// (get) Token: 0x0602198E RID: 137614 RVA: 0x004A1E3C File Offset: 0x004A003C
		public int MoraleLevel
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

		// Token: 0x17009825 RID: 38949
		// (get) Token: 0x0602198F RID: 137615 RVA: 0x004A1E7C File Offset: 0x004A007C
		public int HonamiStoryMonsterGrowth
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

		// Token: 0x17009826 RID: 38950
		// (get) Token: 0x06021990 RID: 137616 RVA: 0x004A1EBC File Offset: 0x004A00BC
		public int FlagChallengeMonsterLevel
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

		// Token: 0x17009827 RID: 38951
		// (get) Token: 0x06021991 RID: 137617 RVA: 0x004A1EFC File Offset: 0x004A00FC
		public int RageModeId
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

		// Token: 0x17009828 RID: 38952
		// (get) Token: 0x06021992 RID: 137618 RVA: 0x004A1F3C File Offset: 0x004A013C
		public int HardnessModeId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009829 RID: 38953
		// (get) Token: 0x06021993 RID: 137619 RVA: 0x004A1F7C File Offset: 0x004A017C
		public int WorldLevelBonusId
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

		// Token: 0x1700982A RID: 38954
		// (get) Token: 0x06021994 RID: 137620 RVA: 0x004A1FBC File Offset: 0x004A01BC
		public bool IgnoreFightMusic
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700982B RID: 38955
		// (get) Token: 0x06021995 RID: 137621 RVA: 0x004A1FFC File Offset: 0x004A01FC
		public IFightMusicsSwitchByTagList? FightMusics
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IFightMusicsSwitchByTagList?(default(IFightMusicsSwitchByTagList).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700982C RID: 38956
		// (get) Token: 0x06021996 RID: 137622 RVA: 0x004A205C File Offset: 0x004A025C
		public string FightMusic
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

		// Token: 0x06021997 RID: 137623 RVA: 0x004A2094 File Offset: 0x004A0294
		public Span<byte> GetFightMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06021998 RID: 137624 RVA: 0x004A20A4 File Offset: 0x004A02A4
		public byte[] GetFightMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x1700982D RID: 38957
		// (get) Token: 0x06021999 RID: 137625 RVA: 0x004A20B4 File Offset: 0x004A02B4
		public bool FightMusicBanRadioMusic
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602199A RID: 137626 RVA: 0x004A20F4 File Offset: 0x004A02F4
		public long AppendBuffIds(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700982E RID: 38958
		// (get) Token: 0x0602199B RID: 137627 RVA: 0x004A2138 File Offset: 0x004A0338
		public int AppendBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602199C RID: 137628 RVA: 0x004A2164 File Offset: 0x004A0364
		public Span<long> GetAppendBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(34, 8);
		}

		// Token: 0x0602199D RID: 137629 RVA: 0x004A2174 File Offset: 0x004A0374
		public long[] GetAppendBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(34);
		}

		// Token: 0x1700982F RID: 38959
		// (get) Token: 0x0602199E RID: 137630 RVA: 0x004A2184 File Offset: 0x004A0384
		public TWorldLevelBonus WorldLevelBonusTypeType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return TWorldLevelBonus.NONE;
				}
				return (TWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602199F RID: 137631 RVA: 0x004A21C4 File Offset: 0x004A03C4
		public TTable? WorldLevelBonusType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060219A0 RID: 137632 RVA: 0x004A220C File Offset: 0x004A040C
		public IAreaBouns WorldLevelBonusTypeAsIAreaBouns()
		{
			return this.WorldLevelBonusType<IAreaBouns>().Value;
		}

		// Token: 0x060219A1 RID: 137633 RVA: 0x004A2228 File Offset: 0x004A0428
		public IWorldLevelTable WorldLevelBonusTypeAsIWorldLevelTable()
		{
			return this.WorldLevelBonusType<IWorldLevelTable>().Value;
		}

		// Token: 0x17009830 RID: 38960
		// (get) Token: 0x060219A2 RID: 137634 RVA: 0x004A2244 File Offset: 0x004A0444
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060219A3 RID: 137635 RVA: 0x004A2284 File Offset: 0x004A0484
		public static Offset<IAttributeComponent> CreateIAttributeComponent(FlatBufferBuilder builder, bool Disabled = false, int PropertyId = 0, int MonsterPropExtraRateId = 0, int MonsterPropGrowthId = 0, int Level = 0, int MoraleLevel = 0, int HonamiStoryMonsterGrowth = 0, int FlagChallengeMonsterLevel = 0, int RageModeId = 0, int HardnessModeId = 0, int WorldLevelBonusId = 0, bool IgnoreFightMusic = false, Offset<IFightMusicsSwitchByTagList> FightMusicsOffset = default(Offset<IFightMusicsSwitchByTagList>), StringOffset FightMusicOffset = default(StringOffset), bool FightMusicBanRadioMusic = false, VectorOffset AppendBuffIdsOffset = default(VectorOffset), TWorldLevelBonus WorldLevelBonusType_type = TWorldLevelBonus.NONE, int WorldLevelBonusTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(19);
			IAttributeComponent.AddWorldLevelBonusType(builder, WorldLevelBonusTypeOffset);
			IAttributeComponent.AddAppendBuffIds(builder, AppendBuffIdsOffset);
			IAttributeComponent.AddFightMusic(builder, FightMusicOffset);
			IAttributeComponent.AddFightMusics(builder, FightMusicsOffset);
			IAttributeComponent.AddWorldLevelBonusId(builder, WorldLevelBonusId);
			IAttributeComponent.AddHardnessModeId(builder, HardnessModeId);
			IAttributeComponent.AddRageModeId(builder, RageModeId);
			IAttributeComponent.AddFlagChallengeMonsterLevel(builder, FlagChallengeMonsterLevel);
			IAttributeComponent.AddHonamiStoryMonsterGrowth(builder, HonamiStoryMonsterGrowth);
			IAttributeComponent.AddMoraleLevel(builder, MoraleLevel);
			IAttributeComponent.AddLevel(builder, Level);
			IAttributeComponent.AddMonsterPropGrowthId(builder, MonsterPropGrowthId);
			IAttributeComponent.AddMonsterPropExtraRateId(builder, MonsterPropExtraRateId);
			IAttributeComponent.AddPropertyId(builder, PropertyId);
			IAttributeComponent.AddNullMask(builder, NullMask);
			IAttributeComponent.AddWorldLevelBonusTypeType(builder, WorldLevelBonusType_type);
			IAttributeComponent.AddFightMusicBanRadioMusic(builder, FightMusicBanRadioMusic);
			IAttributeComponent.AddIgnoreFightMusic(builder, IgnoreFightMusic);
			IAttributeComponent.AddDisabled(builder, Disabled);
			return IAttributeComponent.EndIAttributeComponent(builder);
		}

		// Token: 0x060219A4 RID: 137636 RVA: 0x004A2334 File Offset: 0x004A0534
		public static void StartIAttributeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(19);
		}

		// Token: 0x060219A5 RID: 137637 RVA: 0x004A233E File Offset: 0x004A053E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060219A6 RID: 137638 RVA: 0x004A2349 File Offset: 0x004A0549
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(1, propertyId, 0);
		}

		// Token: 0x060219A7 RID: 137639 RVA: 0x004A2354 File Offset: 0x004A0554
		public static void AddMonsterPropExtraRateId(FlatBufferBuilder builder, int monsterPropExtraRateId)
		{
			builder.AddInt(2, monsterPropExtraRateId, 0);
		}

		// Token: 0x060219A8 RID: 137640 RVA: 0x004A235F File Offset: 0x004A055F
		public static void AddMonsterPropGrowthId(FlatBufferBuilder builder, int monsterPropGrowthId)
		{
			builder.AddInt(3, monsterPropGrowthId, 0);
		}

		// Token: 0x060219A9 RID: 137641 RVA: 0x004A236A File Offset: 0x004A056A
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(4, level, 0);
		}

		// Token: 0x060219AA RID: 137642 RVA: 0x004A2375 File Offset: 0x004A0575
		public static void AddMoraleLevel(FlatBufferBuilder builder, int moraleLevel)
		{
			builder.AddInt(5, moraleLevel, 0);
		}

		// Token: 0x060219AB RID: 137643 RVA: 0x004A2380 File Offset: 0x004A0580
		public static void AddHonamiStoryMonsterGrowth(FlatBufferBuilder builder, int honamiStoryMonsterGrowth)
		{
			builder.AddInt(6, honamiStoryMonsterGrowth, 0);
		}

		// Token: 0x060219AC RID: 137644 RVA: 0x004A238B File Offset: 0x004A058B
		public static void AddFlagChallengeMonsterLevel(FlatBufferBuilder builder, int flagChallengeMonsterLevel)
		{
			builder.AddInt(7, flagChallengeMonsterLevel, 0);
		}

		// Token: 0x060219AD RID: 137645 RVA: 0x004A2396 File Offset: 0x004A0596
		public static void AddRageModeId(FlatBufferBuilder builder, int rageModeId)
		{
			builder.AddInt(8, rageModeId, 0);
		}

		// Token: 0x060219AE RID: 137646 RVA: 0x004A23A1 File Offset: 0x004A05A1
		public static void AddHardnessModeId(FlatBufferBuilder builder, int hardnessModeId)
		{
			builder.AddInt(9, hardnessModeId, 0);
		}

		// Token: 0x060219AF RID: 137647 RVA: 0x004A23AD File Offset: 0x004A05AD
		public static void AddWorldLevelBonusId(FlatBufferBuilder builder, int worldLevelBonusId)
		{
			builder.AddInt(10, worldLevelBonusId, 0);
		}

		// Token: 0x060219B0 RID: 137648 RVA: 0x004A23B9 File Offset: 0x004A05B9
		public static void AddIgnoreFightMusic(FlatBufferBuilder builder, bool ignoreFightMusic)
		{
			builder.AddBool(11, ignoreFightMusic, false);
		}

		// Token: 0x060219B1 RID: 137649 RVA: 0x004A23C5 File Offset: 0x004A05C5
		public static void AddFightMusics(FlatBufferBuilder builder, Offset<IFightMusicsSwitchByTagList> fightMusicsOffset)
		{
			builder.AddOffset(12, fightMusicsOffset.Value, 0);
		}

		// Token: 0x060219B2 RID: 137650 RVA: 0x004A23D6 File Offset: 0x004A05D6
		public static void AddFightMusic(FlatBufferBuilder builder, StringOffset fightMusicOffset)
		{
			builder.AddOffset(13, fightMusicOffset.Value, 0);
		}

		// Token: 0x060219B3 RID: 137651 RVA: 0x004A23E7 File Offset: 0x004A05E7
		public static void AddFightMusicBanRadioMusic(FlatBufferBuilder builder, bool fightMusicBanRadioMusic)
		{
			builder.AddBool(14, fightMusicBanRadioMusic, false);
		}

		// Token: 0x060219B4 RID: 137652 RVA: 0x004A23F3 File Offset: 0x004A05F3
		public static void AddAppendBuffIds(FlatBufferBuilder builder, VectorOffset appendBuffIdsOffset)
		{
			builder.AddOffset(15, appendBuffIdsOffset.Value, 0);
		}

		// Token: 0x060219B5 RID: 137653 RVA: 0x004A2404 File Offset: 0x004A0604
		public static VectorOffset CreateAppendBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060219B6 RID: 137654 RVA: 0x004A243B File Offset: 0x004A063B
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060219B7 RID: 137655 RVA: 0x004A2455 File Offset: 0x004A0655
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060219B8 RID: 137656 RVA: 0x004A2473 File Offset: 0x004A0673
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060219B9 RID: 137657 RVA: 0x004A248C File Offset: 0x004A068C
		public static void StartAppendBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x060219BA RID: 137658 RVA: 0x004A2497 File Offset: 0x004A0697
		public static void AddWorldLevelBonusTypeType(FlatBufferBuilder builder, TWorldLevelBonus worldLevelBonusTypeType)
		{
			builder.AddByte(16, (byte)worldLevelBonusTypeType, 0);
		}

		// Token: 0x060219BB RID: 137659 RVA: 0x004A24A3 File Offset: 0x004A06A3
		public static void AddWorldLevelBonusType(FlatBufferBuilder builder, int worldLevelBonusTypeOffset)
		{
			builder.AddOffset(17, worldLevelBonusTypeOffset, 0);
		}

		// Token: 0x060219BC RID: 137660 RVA: 0x004A24AF File Offset: 0x004A06AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(18, nullMask, 0);
		}

		// Token: 0x060219BD RID: 137661 RVA: 0x004A24BB File Offset: 0x004A06BB
		public static Offset<IAttributeComponent> EndIAttributeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAttributeComponent>(builder.EndTable());
		}

		// Token: 0x060219BE RID: 137662 RVA: 0x004A24C8 File Offset: 0x004A06C8
		public IAttributeComponentT UnPack()
		{
			IAttributeComponentT attributeComponentT = new IAttributeComponentT();
			this.UnPackTo(attributeComponentT);
			return attributeComponentT;
		}

		// Token: 0x060219BF RID: 137663 RVA: 0x004A24E4 File Offset: 0x004A06E4
		public void UnPackTo(IAttributeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.PropertyId = this.PropertyId;
			_o.MonsterPropExtraRateId = this.MonsterPropExtraRateId;
			_o.MonsterPropGrowthId = this.MonsterPropGrowthId;
			_o.Level = this.Level;
			_o.MoraleLevel = this.MoraleLevel;
			_o.HonamiStoryMonsterGrowth = this.HonamiStoryMonsterGrowth;
			_o.FlagChallengeMonsterLevel = this.FlagChallengeMonsterLevel;
			_o.RageModeId = this.RageModeId;
			_o.HardnessModeId = this.HardnessModeId;
			_o.WorldLevelBonusId = this.WorldLevelBonusId;
			_o.IgnoreFightMusic = this.IgnoreFightMusic;
			_o.FightMusics = ((this.FightMusics != null) ? this.FightMusics.Value.UnPack() : null);
			_o.FightMusic = this.FightMusic;
			_o.FightMusicBanRadioMusic = this.FightMusicBanRadioMusic;
			_o.AppendBuffIds = new List<long>();
			for (int i = 0; i < this.AppendBuffIdsLength; i++)
			{
				_o.AppendBuffIds.Add(this.AppendBuffIds(i));
			}
			_o.WorldLevelBonusType = new TWorldLevelBonusUnion();
			_o.WorldLevelBonusType.Type = this.WorldLevelBonusTypeType;
			TWorldLevelBonus worldLevelBonusTypeType = this.WorldLevelBonusTypeType;
			if (worldLevelBonusTypeType != TWorldLevelBonus.IAreaBouns)
			{
				if (worldLevelBonusTypeType == TWorldLevelBonus.IWorldLevelTable)
				{
					_o.WorldLevelBonusType.Value = ((this.WorldLevelBonusType<IWorldLevelTable>() != null) ? this.WorldLevelBonusType<IWorldLevelTable>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.WorldLevelBonusType.Value = ((this.WorldLevelBonusType<IAreaBouns>() != null) ? this.WorldLevelBonusType<IAreaBouns>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060219C0 RID: 137664 RVA: 0x004A26A0 File Offset: 0x004A08A0
		public static Offset<IAttributeComponent> Pack(FlatBufferBuilder builder, IAttributeComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttributeComponent>);
			}
			Offset<IFightMusicsSwitchByTagList> fightMusicsOffset = (_o.FightMusics == null) ? default(Offset<IFightMusicsSwitchByTagList>) : IFightMusicsSwitchByTagList.Pack(builder, _o.FightMusics);
			StringOffset fightMusicOffset = (_o.FightMusic == null) ? default(StringOffset) : builder.CreateString(_o.FightMusic);
			VectorOffset appendBuffIdsOffset = default(VectorOffset);
			if (_o.AppendBuffIds != null)
			{
				long[] data = _o.AppendBuffIds.ToArray();
				appendBuffIdsOffset = IAttributeComponent.CreateAppendBuffIdsVector(builder, data);
			}
			TWorldLevelBonus worldLevelBonusType_type = (_o.WorldLevelBonusType == null) ? TWorldLevelBonus.NONE : _o.WorldLevelBonusType.Type;
			int worldLevelBonusTypeOffset = (_o.WorldLevelBonusType == null) ? 0 : TWorldLevelBonusUnion.Pack(builder, _o.WorldLevelBonusType);
			return IAttributeComponent.CreateIAttributeComponent(builder, _o.Disabled, _o.PropertyId, _o.MonsterPropExtraRateId, _o.MonsterPropGrowthId, _o.Level, _o.MoraleLevel, _o.HonamiStoryMonsterGrowth, _o.FlagChallengeMonsterLevel, _o.RageModeId, _o.HardnessModeId, _o.WorldLevelBonusId, _o.IgnoreFightMusic, fightMusicsOffset, fightMusicOffset, _o.FightMusicBanRadioMusic, appendBuffIdsOffset, worldLevelBonusType_type, worldLevelBonusTypeOffset, _o.NullMask);
		}

		// Token: 0x0400E864 RID: 59492
		private Table __p;
	}
}
