using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC8 RID: 20168
	public struct IAttributeComponent : IFlatbufferObject
	{
		// Token: 0x170090AB RID: 37035
		// (get) Token: 0x0601FC3F RID: 130111 RVA: 0x0046BEC8 File Offset: 0x0046A0C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC40 RID: 130112 RVA: 0x0046BED5 File Offset: 0x0046A0D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC41 RID: 130113 RVA: 0x0046BEDC File Offset: 0x0046A0DC
		public static IAttributeComponent GetRootAsIAttributeComponent(ByteBuffer _bb)
		{
			return IAttributeComponent.GetRootAsIAttributeComponent(_bb, default(IAttributeComponent));
		}

		// Token: 0x0601FC42 RID: 130114 RVA: 0x0046BEF8 File Offset: 0x0046A0F8
		public static IAttributeComponent GetRootAsIAttributeComponent(ByteBuffer _bb, IAttributeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC43 RID: 130115 RVA: 0x0046BF15 File Offset: 0x0046A115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x0046BF24 File Offset: 0x0046A124
		public IAttributeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090AC RID: 37036
		// (get) Token: 0x0601FC45 RID: 130117 RVA: 0x0046BF34 File Offset: 0x0046A134
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170090AD RID: 37037
		// (get) Token: 0x0601FC46 RID: 130118 RVA: 0x0046BF74 File Offset: 0x0046A174
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

		// Token: 0x170090AE RID: 37038
		// (get) Token: 0x0601FC47 RID: 130119 RVA: 0x0046BFB0 File Offset: 0x0046A1B0
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

		// Token: 0x170090AF RID: 37039
		// (get) Token: 0x0601FC48 RID: 130120 RVA: 0x0046BFEC File Offset: 0x0046A1EC
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

		// Token: 0x170090B0 RID: 37040
		// (get) Token: 0x0601FC49 RID: 130121 RVA: 0x0046C02C File Offset: 0x0046A22C
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

		// Token: 0x170090B1 RID: 37041
		// (get) Token: 0x0601FC4A RID: 130122 RVA: 0x0046C06C File Offset: 0x0046A26C
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

		// Token: 0x170090B2 RID: 37042
		// (get) Token: 0x0601FC4B RID: 130123 RVA: 0x0046C0AC File Offset: 0x0046A2AC
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

		// Token: 0x170090B3 RID: 37043
		// (get) Token: 0x0601FC4C RID: 130124 RVA: 0x0046C0EC File Offset: 0x0046A2EC
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

		// Token: 0x170090B4 RID: 37044
		// (get) Token: 0x0601FC4D RID: 130125 RVA: 0x0046C12C File Offset: 0x0046A32C
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

		// Token: 0x170090B5 RID: 37045
		// (get) Token: 0x0601FC4E RID: 130126 RVA: 0x0046C16C File Offset: 0x0046A36C
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

		// Token: 0x170090B6 RID: 37046
		// (get) Token: 0x0601FC4F RID: 130127 RVA: 0x0046C1AC File Offset: 0x0046A3AC
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

		// Token: 0x170090B7 RID: 37047
		// (get) Token: 0x0601FC50 RID: 130128 RVA: 0x0046C1EC File Offset: 0x0046A3EC
		public bool IgnoreFightMusic
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170090B8 RID: 37048
		// (get) Token: 0x0601FC51 RID: 130129 RVA: 0x0046C22C File Offset: 0x0046A42C
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

		// Token: 0x170090B9 RID: 37049
		// (get) Token: 0x0601FC52 RID: 130130 RVA: 0x0046C28C File Offset: 0x0046A48C
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

		// Token: 0x0601FC53 RID: 130131 RVA: 0x0046C2C4 File Offset: 0x0046A4C4
		public Span<byte> GetFightMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x0046C2D4 File Offset: 0x0046A4D4
		public byte[] GetFightMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x170090BA RID: 37050
		// (get) Token: 0x0601FC55 RID: 130133 RVA: 0x0046C2E4 File Offset: 0x0046A4E4
		public bool FightMusicBanRadioMusic
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FC56 RID: 130134 RVA: 0x0046C324 File Offset: 0x0046A524
		public long AppendBuffIds(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170090BB RID: 37051
		// (get) Token: 0x0601FC57 RID: 130135 RVA: 0x0046C368 File Offset: 0x0046A568
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

		// Token: 0x0601FC58 RID: 130136 RVA: 0x0046C394 File Offset: 0x0046A594
		public Span<long> GetAppendBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(34, 8);
		}

		// Token: 0x0601FC59 RID: 130137 RVA: 0x0046C3A4 File Offset: 0x0046A5A4
		public long[] GetAppendBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(34);
		}

		// Token: 0x170090BC RID: 37052
		// (get) Token: 0x0601FC5A RID: 130138 RVA: 0x0046C3B4 File Offset: 0x0046A5B4
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

		// Token: 0x0601FC5B RID: 130139 RVA: 0x0046C3F4 File Offset: 0x0046A5F4
		public TTable? WorldLevelBonusType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FC5C RID: 130140 RVA: 0x0046C43C File Offset: 0x0046A63C
		public IAreaBouns WorldLevelBonusTypeAsIAreaBouns()
		{
			return this.WorldLevelBonusType<IAreaBouns>().Value;
		}

		// Token: 0x0601FC5D RID: 130141 RVA: 0x0046C458 File Offset: 0x0046A658
		public IWorldLevelTable WorldLevelBonusTypeAsIWorldLevelTable()
		{
			return this.WorldLevelBonusType<IWorldLevelTable>().Value;
		}

		// Token: 0x170090BD RID: 37053
		// (get) Token: 0x0601FC5E RID: 130142 RVA: 0x0046C474 File Offset: 0x0046A674
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

		// Token: 0x0601FC5F RID: 130143 RVA: 0x0046C4B4 File Offset: 0x0046A6B4
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

		// Token: 0x0601FC60 RID: 130144 RVA: 0x0046C564 File Offset: 0x0046A764
		public static void StartIAttributeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(19);
		}

		// Token: 0x0601FC61 RID: 130145 RVA: 0x0046C56E File Offset: 0x0046A76E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FC62 RID: 130146 RVA: 0x0046C579 File Offset: 0x0046A779
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(1, propertyId, 0);
		}

		// Token: 0x0601FC63 RID: 130147 RVA: 0x0046C584 File Offset: 0x0046A784
		public static void AddMonsterPropExtraRateId(FlatBufferBuilder builder, int monsterPropExtraRateId)
		{
			builder.AddInt(2, monsterPropExtraRateId, 0);
		}

		// Token: 0x0601FC64 RID: 130148 RVA: 0x0046C58F File Offset: 0x0046A78F
		public static void AddMonsterPropGrowthId(FlatBufferBuilder builder, int monsterPropGrowthId)
		{
			builder.AddInt(3, monsterPropGrowthId, 0);
		}

		// Token: 0x0601FC65 RID: 130149 RVA: 0x0046C59A File Offset: 0x0046A79A
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(4, level, 0);
		}

		// Token: 0x0601FC66 RID: 130150 RVA: 0x0046C5A5 File Offset: 0x0046A7A5
		public static void AddMoraleLevel(FlatBufferBuilder builder, int moraleLevel)
		{
			builder.AddInt(5, moraleLevel, 0);
		}

		// Token: 0x0601FC67 RID: 130151 RVA: 0x0046C5B0 File Offset: 0x0046A7B0
		public static void AddHonamiStoryMonsterGrowth(FlatBufferBuilder builder, int honamiStoryMonsterGrowth)
		{
			builder.AddInt(6, honamiStoryMonsterGrowth, 0);
		}

		// Token: 0x0601FC68 RID: 130152 RVA: 0x0046C5BB File Offset: 0x0046A7BB
		public static void AddFlagChallengeMonsterLevel(FlatBufferBuilder builder, int flagChallengeMonsterLevel)
		{
			builder.AddInt(7, flagChallengeMonsterLevel, 0);
		}

		// Token: 0x0601FC69 RID: 130153 RVA: 0x0046C5C6 File Offset: 0x0046A7C6
		public static void AddRageModeId(FlatBufferBuilder builder, int rageModeId)
		{
			builder.AddInt(8, rageModeId, 0);
		}

		// Token: 0x0601FC6A RID: 130154 RVA: 0x0046C5D1 File Offset: 0x0046A7D1
		public static void AddHardnessModeId(FlatBufferBuilder builder, int hardnessModeId)
		{
			builder.AddInt(9, hardnessModeId, 0);
		}

		// Token: 0x0601FC6B RID: 130155 RVA: 0x0046C5DD File Offset: 0x0046A7DD
		public static void AddWorldLevelBonusId(FlatBufferBuilder builder, int worldLevelBonusId)
		{
			builder.AddInt(10, worldLevelBonusId, 0);
		}

		// Token: 0x0601FC6C RID: 130156 RVA: 0x0046C5E9 File Offset: 0x0046A7E9
		public static void AddIgnoreFightMusic(FlatBufferBuilder builder, bool ignoreFightMusic)
		{
			builder.AddBool(11, ignoreFightMusic, false);
		}

		// Token: 0x0601FC6D RID: 130157 RVA: 0x0046C5F5 File Offset: 0x0046A7F5
		public static void AddFightMusics(FlatBufferBuilder builder, Offset<IFightMusicsSwitchByTagList> fightMusicsOffset)
		{
			builder.AddOffset(12, fightMusicsOffset.Value, 0);
		}

		// Token: 0x0601FC6E RID: 130158 RVA: 0x0046C606 File Offset: 0x0046A806
		public static void AddFightMusic(FlatBufferBuilder builder, StringOffset fightMusicOffset)
		{
			builder.AddOffset(13, fightMusicOffset.Value, 0);
		}

		// Token: 0x0601FC6F RID: 130159 RVA: 0x0046C617 File Offset: 0x0046A817
		public static void AddFightMusicBanRadioMusic(FlatBufferBuilder builder, bool fightMusicBanRadioMusic)
		{
			builder.AddBool(14, fightMusicBanRadioMusic, false);
		}

		// Token: 0x0601FC70 RID: 130160 RVA: 0x0046C623 File Offset: 0x0046A823
		public static void AddAppendBuffIds(FlatBufferBuilder builder, VectorOffset appendBuffIdsOffset)
		{
			builder.AddOffset(15, appendBuffIdsOffset.Value, 0);
		}

		// Token: 0x0601FC71 RID: 130161 RVA: 0x0046C634 File Offset: 0x0046A834
		public static VectorOffset CreateAppendBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FC72 RID: 130162 RVA: 0x0046C66B File Offset: 0x0046A86B
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC73 RID: 130163 RVA: 0x0046C685 File Offset: 0x0046A885
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC74 RID: 130164 RVA: 0x0046C6A3 File Offset: 0x0046A8A3
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FC75 RID: 130165 RVA: 0x0046C6BC File Offset: 0x0046A8BC
		public static void StartAppendBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0601FC76 RID: 130166 RVA: 0x0046C6C7 File Offset: 0x0046A8C7
		public static void AddWorldLevelBonusTypeType(FlatBufferBuilder builder, TWorldLevelBonus worldLevelBonusTypeType)
		{
			builder.AddByte(16, (byte)worldLevelBonusTypeType, 0);
		}

		// Token: 0x0601FC77 RID: 130167 RVA: 0x0046C6D3 File Offset: 0x0046A8D3
		public static void AddWorldLevelBonusType(FlatBufferBuilder builder, int worldLevelBonusTypeOffset)
		{
			builder.AddOffset(17, worldLevelBonusTypeOffset, 0);
		}

		// Token: 0x0601FC78 RID: 130168 RVA: 0x0046C6DF File Offset: 0x0046A8DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(18, nullMask, 0);
		}

		// Token: 0x0601FC79 RID: 130169 RVA: 0x0046C6EB File Offset: 0x0046A8EB
		public static Offset<IAttributeComponent> EndIAttributeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAttributeComponent>(builder.EndTable());
		}

		// Token: 0x0601FC7A RID: 130170 RVA: 0x0046C6F8 File Offset: 0x0046A8F8
		public IAttributeComponentT UnPack()
		{
			IAttributeComponentT attributeComponentT = new IAttributeComponentT();
			this.UnPackTo(attributeComponentT);
			return attributeComponentT;
		}

		// Token: 0x0601FC7B RID: 130171 RVA: 0x0046C714 File Offset: 0x0046A914
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

		// Token: 0x0601FC7C RID: 130172 RVA: 0x0046C8D0 File Offset: 0x0046AAD0
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

		// Token: 0x0400DCBD RID: 56509
		private Table __p;
	}
}
