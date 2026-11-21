using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D3 RID: 22227
	public struct IEntityCategory : IFlatbufferObject
	{
		// Token: 0x17009FFC RID: 40956
		// (get) Token: 0x060239EC RID: 145900 RVA: 0x004E5C7F File Offset: 0x004E3E7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239ED RID: 145901 RVA: 0x004E5C8C File Offset: 0x004E3E8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239EE RID: 145902 RVA: 0x004E5C94 File Offset: 0x004E3E94
		public static IEntityCategory GetRootAsIEntityCategory(ByteBuffer _bb)
		{
			return IEntityCategory.GetRootAsIEntityCategory(_bb, default(IEntityCategory));
		}

		// Token: 0x060239EF RID: 145903 RVA: 0x004E5CB0 File Offset: 0x004E3EB0
		public static IEntityCategory GetRootAsIEntityCategory(ByteBuffer _bb, IEntityCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239F0 RID: 145904 RVA: 0x004E5CCD File Offset: 0x004E3ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239F1 RID: 145905 RVA: 0x004E5CDC File Offset: 0x004E3EDC
		public IEntityCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FFD RID: 40957
		// (get) Token: 0x060239F2 RID: 145906 RVA: 0x004E5CEC File Offset: 0x004E3EEC
		public EEntityMainType MainType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityMainType.Npc;
				}
				return (EEntityMainType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009FFE RID: 40958
		// (get) Token: 0x060239F3 RID: 145907 RVA: 0x004E5D28 File Offset: 0x004E3F28
		public string EntityPlotBindingType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060239F4 RID: 145908 RVA: 0x004E5D5F File Offset: 0x004E3F5F
		public Span<byte> GetEntityPlotBindingTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060239F5 RID: 145909 RVA: 0x004E5D6E File Offset: 0x004E3F6E
		public byte[] GetEntityPlotBindingTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009FFF RID: 40959
		// (get) Token: 0x060239F6 RID: 145910 RVA: 0x004E5D7C File Offset: 0x004E3F7C
		public EControlMatchType ControlMatchType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EControlMatchType.GrowSolution;
				}
				return (EControlMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A000 RID: 40960
		// (get) Token: 0x060239F7 RID: 145911 RVA: 0x004E5DB8 File Offset: 0x004E3FB8
		public EMonsterMatchType MonsterMatchType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMonsterMatchType.Normal;
				}
				return (EMonsterMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A001 RID: 40961
		// (get) Token: 0x060239F8 RID: 145912 RVA: 0x004E5DF8 File Offset: 0x004E3FF8
		public EItemFoundationMatchType ItemFoundation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EItemFoundationMatchType.Branch;
				}
				return (EItemFoundationMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A002 RID: 40962
		// (get) Token: 0x060239F9 RID: 145913 RVA: 0x004E5E38 File Offset: 0x004E4038
		public EHideInFlowType HideInFlowType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EHideInFlowType.None;
				}
				return (EHideInFlowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A003 RID: 40963
		// (get) Token: 0x060239FA RID: 145914 RVA: 0x004E5E78 File Offset: 0x004E4078
		public int ExploratoryDegree
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

		// Token: 0x1700A004 RID: 40964
		// (get) Token: 0x060239FB RID: 145915 RVA: 0x004E5EB8 File Offset: 0x004E40B8
		public ETraceMatchType TraceMatchType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return ETraceMatchType.None;
				}
				return (ETraceMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A005 RID: 40965
		// (get) Token: 0x060239FC RID: 145916 RVA: 0x004E5EF8 File Offset: 0x004E40F8
		public EDestructibleType DestructibleType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EDestructibleType.Rock;
				}
				return (EDestructibleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A006 RID: 40966
		// (get) Token: 0x060239FD RID: 145917 RVA: 0x004E5F38 File Offset: 0x004E4138
		public ECollectType CollectType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return ECollectType.Botany;
				}
				return (ECollectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A007 RID: 40967
		// (get) Token: 0x060239FE RID: 145918 RVA: 0x004E5F78 File Offset: 0x004E4178
		public ETreasureChestStatType TreasureChestStatType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return ETreasureChestStatType.OneTime;
				}
				return (ETreasureChestStatType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A008 RID: 40968
		// (get) Token: 0x060239FF RID: 145919 RVA: 0x004E5FB8 File Offset: 0x004E41B8
		public ENpcType NpcType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return ENpcType.Common;
				}
				return (ENpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A009 RID: 40969
		// (get) Token: 0x06023A00 RID: 145920 RVA: 0x004E5FF8 File Offset: 0x004E41F8
		public EBulletPenetrationType BulletPenetrationType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return EBulletPenetrationType.Penetrable;
				}
				return (EBulletPenetrationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00A RID: 40970
		// (get) Token: 0x06023A01 RID: 145921 RVA: 0x004E6038 File Offset: 0x004E4238
		public EMechanismType MechanismType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return EMechanismType.Portal;
				}
				return (EMechanismType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00B RID: 40971
		// (get) Token: 0x06023A02 RID: 145922 RVA: 0x004E6078 File Offset: 0x004E4278
		public EInhaledItemType InhaledItemType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return EInhaledItemType.LonelyDollPollutant;
				}
				return (EInhaledItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00C RID: 40972
		// (get) Token: 0x06023A03 RID: 145923 RVA: 0x004E60B8 File Offset: 0x004E42B8
		public EPullStatueMatchType PullStatueMatchType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return EPullStatueMatchType.Statue;
				}
				return (EPullStatueMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00D RID: 40973
		// (get) Token: 0x06023A04 RID: 145924 RVA: 0x004E60F8 File Offset: 0x004E42F8
		public EVehicleType VehicleType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00E RID: 40974
		// (get) Token: 0x06023A05 RID: 145925 RVA: 0x004E6138 File Offset: 0x004E4338
		public EFishingMechanismType FishingMechanismType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return EFishingMechanismType.FishingPoint;
				}
				return (EFishingMechanismType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A00F RID: 40975
		// (get) Token: 0x06023A06 RID: 145926 RVA: 0x004E6178 File Offset: 0x004E4378
		public EHonamiStoryMapMarkType HonamiStoryMapMarkType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return EHonamiStoryMapMarkType.EvacuateMachine;
				}
				return (EHonamiStoryMapMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A010 RID: 40976
		// (get) Token: 0x06023A07 RID: 145927 RVA: 0x004E61B8 File Offset: 0x004E43B8
		public EVisionDisplayType VisionDisplayType
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return EVisionDisplayType.MechanicalDeer;
				}
				return (EVisionDisplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A011 RID: 40977
		// (get) Token: 0x06023A08 RID: 145928 RVA: 0x004E61F8 File Offset: 0x004E43F8
		public ESunSpiritInteractType SunSpiritInteractType
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return ESunSpiritInteractType.RollingBall;
				}
				return (ESunSpiritInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A012 RID: 40978
		// (get) Token: 0x06023A09 RID: 145929 RVA: 0x004E6238 File Offset: 0x004E4438
		public EAnimalType AnimalType
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return EAnimalType.Cat;
				}
				return (EAnimalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A013 RID: 40979
		// (get) Token: 0x06023A0A RID: 145930 RVA: 0x004E6278 File Offset: 0x004E4478
		public ERegionType RegionType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return ERegionType.Lahailuo;
				}
				return (ERegionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A014 RID: 40980
		// (get) Token: 0x06023A0B RID: 145931 RVA: 0x004E62B8 File Offset: 0x004E44B8
		public ERaceType RaceType
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return ERaceType.Luoyizu;
				}
				return (ERaceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A015 RID: 40981
		// (get) Token: 0x06023A0C RID: 145932 RVA: 0x004E62F8 File Offset: 0x004E44F8
		public EProfessionType ProfessionType
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return EProfessionType.Teacher;
				}
				return (EProfessionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A016 RID: 40982
		// (get) Token: 0x06023A0D RID: 145933 RVA: 0x004E6338 File Offset: 0x004E4538
		public EGenderType GenderType
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return EGenderType.Male;
				}
				return (EGenderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A017 RID: 40983
		// (get) Token: 0x06023A0E RID: 145934 RVA: 0x004E6378 File Offset: 0x004E4578
		public int CollectiblesDetectionId
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A018 RID: 40984
		// (get) Token: 0x06023A0F RID: 145935 RVA: 0x004E63B8 File Offset: 0x004E45B8
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A10 RID: 145936 RVA: 0x004E63F8 File Offset: 0x004E45F8
		public static Offset<IEntityCategory> CreateIEntityCategory(FlatBufferBuilder builder, EEntityMainType MainType = EEntityMainType.Npc, StringOffset EntityPlotBindingTypeOffset = default(StringOffset), EControlMatchType ControlMatchType = EControlMatchType.GrowSolution, EMonsterMatchType MonsterMatchType = EMonsterMatchType.Normal, EItemFoundationMatchType ItemFoundation = EItemFoundationMatchType.Branch, EHideInFlowType HideInFlowType = EHideInFlowType.None, int ExploratoryDegree = 0, ETraceMatchType TraceMatchType = ETraceMatchType.None, EDestructibleType DestructibleType = EDestructibleType.Rock, ECollectType CollectType = ECollectType.Botany, ETreasureChestStatType TreasureChestStatType = ETreasureChestStatType.OneTime, ENpcType NpcType = ENpcType.Common, EBulletPenetrationType BulletPenetrationType = EBulletPenetrationType.Penetrable, EMechanismType MechanismType = EMechanismType.Portal, EInhaledItemType InhaledItemType = EInhaledItemType.LonelyDollPollutant, EPullStatueMatchType PullStatueMatchType = EPullStatueMatchType.Statue, EVehicleType VehicleType = EVehicleType.Gongduola, EFishingMechanismType FishingMechanismType = EFishingMechanismType.FishingPoint, EHonamiStoryMapMarkType HonamiStoryMapMarkType = EHonamiStoryMapMarkType.EvacuateMachine, EVisionDisplayType VisionDisplayType = EVisionDisplayType.MechanicalDeer, ESunSpiritInteractType SunSpiritInteractType = ESunSpiritInteractType.RollingBall, EAnimalType AnimalType = EAnimalType.Cat, ERegionType RegionType = ERegionType.Lahailuo, ERaceType RaceType = ERaceType.Luoyizu, EProfessionType ProfessionType = EProfessionType.Teacher, EGenderType GenderType = EGenderType.Male, int CollectiblesDetectionId = 0, uint NullMask = 0U)
		{
			builder.StartTable(28);
			IEntityCategory.AddNullMask(builder, NullMask);
			IEntityCategory.AddCollectiblesDetectionId(builder, CollectiblesDetectionId);
			IEntityCategory.AddExploratoryDegree(builder, ExploratoryDegree);
			IEntityCategory.AddEntityPlotBindingType(builder, EntityPlotBindingTypeOffset);
			IEntityCategory.AddGenderType(builder, GenderType);
			IEntityCategory.AddProfessionType(builder, ProfessionType);
			IEntityCategory.AddRaceType(builder, RaceType);
			IEntityCategory.AddRegionType(builder, RegionType);
			IEntityCategory.AddAnimalType(builder, AnimalType);
			IEntityCategory.AddSunSpiritInteractType(builder, SunSpiritInteractType);
			IEntityCategory.AddVisionDisplayType(builder, VisionDisplayType);
			IEntityCategory.AddHonamiStoryMapMarkType(builder, HonamiStoryMapMarkType);
			IEntityCategory.AddFishingMechanismType(builder, FishingMechanismType);
			IEntityCategory.AddVehicleType(builder, VehicleType);
			IEntityCategory.AddPullStatueMatchType(builder, PullStatueMatchType);
			IEntityCategory.AddInhaledItemType(builder, InhaledItemType);
			IEntityCategory.AddMechanismType(builder, MechanismType);
			IEntityCategory.AddBulletPenetrationType(builder, BulletPenetrationType);
			IEntityCategory.AddNpcType(builder, NpcType);
			IEntityCategory.AddTreasureChestStatType(builder, TreasureChestStatType);
			IEntityCategory.AddCollectType(builder, CollectType);
			IEntityCategory.AddDestructibleType(builder, DestructibleType);
			IEntityCategory.AddTraceMatchType(builder, TraceMatchType);
			IEntityCategory.AddHideInFlowType(builder, HideInFlowType);
			IEntityCategory.AddItemFoundation(builder, ItemFoundation);
			IEntityCategory.AddMonsterMatchType(builder, MonsterMatchType);
			IEntityCategory.AddControlMatchType(builder, ControlMatchType);
			IEntityCategory.AddMainType(builder, MainType);
			return IEntityCategory.EndIEntityCategory(builder);
		}

		// Token: 0x06023A11 RID: 145937 RVA: 0x004E64F0 File Offset: 0x004E46F0
		public static void StartIEntityCategory(FlatBufferBuilder builder)
		{
			builder.StartTable(28);
		}

		// Token: 0x06023A12 RID: 145938 RVA: 0x004E64FA File Offset: 0x004E46FA
		public static void AddMainType(FlatBufferBuilder builder, EEntityMainType mainType)
		{
			builder.AddByte(0, (byte)mainType, 0);
		}

		// Token: 0x06023A13 RID: 145939 RVA: 0x004E6505 File Offset: 0x004E4705
		public static void AddEntityPlotBindingType(FlatBufferBuilder builder, StringOffset entityPlotBindingTypeOffset)
		{
			builder.AddOffset(1, entityPlotBindingTypeOffset.Value, 0);
		}

		// Token: 0x06023A14 RID: 145940 RVA: 0x004E6515 File Offset: 0x004E4715
		public static void AddControlMatchType(FlatBufferBuilder builder, EControlMatchType controlMatchType)
		{
			builder.AddByte(2, (byte)controlMatchType, 0);
		}

		// Token: 0x06023A15 RID: 145941 RVA: 0x004E6520 File Offset: 0x004E4720
		public static void AddMonsterMatchType(FlatBufferBuilder builder, EMonsterMatchType monsterMatchType)
		{
			builder.AddByte(3, (byte)monsterMatchType, 0);
		}

		// Token: 0x06023A16 RID: 145942 RVA: 0x004E652B File Offset: 0x004E472B
		public static void AddItemFoundation(FlatBufferBuilder builder, EItemFoundationMatchType itemFoundation)
		{
			builder.AddByte(4, (byte)itemFoundation, 0);
		}

		// Token: 0x06023A17 RID: 145943 RVA: 0x004E6536 File Offset: 0x004E4736
		public static void AddHideInFlowType(FlatBufferBuilder builder, EHideInFlowType hideInFlowType)
		{
			builder.AddByte(5, (byte)hideInFlowType, 0);
		}

		// Token: 0x06023A18 RID: 145944 RVA: 0x004E6541 File Offset: 0x004E4741
		public static void AddExploratoryDegree(FlatBufferBuilder builder, int exploratoryDegree)
		{
			builder.AddInt(6, exploratoryDegree, 0);
		}

		// Token: 0x06023A19 RID: 145945 RVA: 0x004E654C File Offset: 0x004E474C
		public static void AddTraceMatchType(FlatBufferBuilder builder, ETraceMatchType traceMatchType)
		{
			builder.AddByte(7, (byte)traceMatchType, 0);
		}

		// Token: 0x06023A1A RID: 145946 RVA: 0x004E6557 File Offset: 0x004E4757
		public static void AddDestructibleType(FlatBufferBuilder builder, EDestructibleType destructibleType)
		{
			builder.AddByte(8, (byte)destructibleType, 0);
		}

		// Token: 0x06023A1B RID: 145947 RVA: 0x004E6562 File Offset: 0x004E4762
		public static void AddCollectType(FlatBufferBuilder builder, ECollectType collectType)
		{
			builder.AddByte(9, (byte)collectType, 0);
		}

		// Token: 0x06023A1C RID: 145948 RVA: 0x004E656E File Offset: 0x004E476E
		public static void AddTreasureChestStatType(FlatBufferBuilder builder, ETreasureChestStatType treasureChestStatType)
		{
			builder.AddByte(10, (byte)treasureChestStatType, 0);
		}

		// Token: 0x06023A1D RID: 145949 RVA: 0x004E657A File Offset: 0x004E477A
		public static void AddNpcType(FlatBufferBuilder builder, ENpcType npcType)
		{
			builder.AddByte(11, (byte)npcType, 0);
		}

		// Token: 0x06023A1E RID: 145950 RVA: 0x004E6586 File Offset: 0x004E4786
		public static void AddBulletPenetrationType(FlatBufferBuilder builder, EBulletPenetrationType bulletPenetrationType)
		{
			builder.AddByte(12, (byte)bulletPenetrationType, 0);
		}

		// Token: 0x06023A1F RID: 145951 RVA: 0x004E6592 File Offset: 0x004E4792
		public static void AddMechanismType(FlatBufferBuilder builder, EMechanismType mechanismType)
		{
			builder.AddByte(13, (byte)mechanismType, 0);
		}

		// Token: 0x06023A20 RID: 145952 RVA: 0x004E659E File Offset: 0x004E479E
		public static void AddInhaledItemType(FlatBufferBuilder builder, EInhaledItemType inhaledItemType)
		{
			builder.AddByte(14, (byte)inhaledItemType, 0);
		}

		// Token: 0x06023A21 RID: 145953 RVA: 0x004E65AA File Offset: 0x004E47AA
		public static void AddPullStatueMatchType(FlatBufferBuilder builder, EPullStatueMatchType pullStatueMatchType)
		{
			builder.AddByte(15, (byte)pullStatueMatchType, 0);
		}

		// Token: 0x06023A22 RID: 145954 RVA: 0x004E65B6 File Offset: 0x004E47B6
		public static void AddVehicleType(FlatBufferBuilder builder, EVehicleType vehicleType)
		{
			builder.AddByte(16, (byte)vehicleType, 0);
		}

		// Token: 0x06023A23 RID: 145955 RVA: 0x004E65C2 File Offset: 0x004E47C2
		public static void AddFishingMechanismType(FlatBufferBuilder builder, EFishingMechanismType fishingMechanismType)
		{
			builder.AddByte(17, (byte)fishingMechanismType, 0);
		}

		// Token: 0x06023A24 RID: 145956 RVA: 0x004E65CE File Offset: 0x004E47CE
		public static void AddHonamiStoryMapMarkType(FlatBufferBuilder builder, EHonamiStoryMapMarkType honamiStoryMapMarkType)
		{
			builder.AddByte(18, (byte)honamiStoryMapMarkType, 0);
		}

		// Token: 0x06023A25 RID: 145957 RVA: 0x004E65DA File Offset: 0x004E47DA
		public static void AddVisionDisplayType(FlatBufferBuilder builder, EVisionDisplayType visionDisplayType)
		{
			builder.AddByte(19, (byte)visionDisplayType, 0);
		}

		// Token: 0x06023A26 RID: 145958 RVA: 0x004E65E6 File Offset: 0x004E47E6
		public static void AddSunSpiritInteractType(FlatBufferBuilder builder, ESunSpiritInteractType sunSpiritInteractType)
		{
			builder.AddByte(20, (byte)sunSpiritInteractType, 0);
		}

		// Token: 0x06023A27 RID: 145959 RVA: 0x004E65F2 File Offset: 0x004E47F2
		public static void AddAnimalType(FlatBufferBuilder builder, EAnimalType animalType)
		{
			builder.AddByte(21, (byte)animalType, 0);
		}

		// Token: 0x06023A28 RID: 145960 RVA: 0x004E65FE File Offset: 0x004E47FE
		public static void AddRegionType(FlatBufferBuilder builder, ERegionType regionType)
		{
			builder.AddByte(22, (byte)regionType, 0);
		}

		// Token: 0x06023A29 RID: 145961 RVA: 0x004E660A File Offset: 0x004E480A
		public static void AddRaceType(FlatBufferBuilder builder, ERaceType raceType)
		{
			builder.AddByte(23, (byte)raceType, 0);
		}

		// Token: 0x06023A2A RID: 145962 RVA: 0x004E6616 File Offset: 0x004E4816
		public static void AddProfessionType(FlatBufferBuilder builder, EProfessionType professionType)
		{
			builder.AddByte(24, (byte)professionType, 0);
		}

		// Token: 0x06023A2B RID: 145963 RVA: 0x004E6622 File Offset: 0x004E4822
		public static void AddGenderType(FlatBufferBuilder builder, EGenderType genderType)
		{
			builder.AddByte(25, (byte)genderType, 0);
		}

		// Token: 0x06023A2C RID: 145964 RVA: 0x004E662E File Offset: 0x004E482E
		public static void AddCollectiblesDetectionId(FlatBufferBuilder builder, int collectiblesDetectionId)
		{
			builder.AddInt(26, collectiblesDetectionId, 0);
		}

		// Token: 0x06023A2D RID: 145965 RVA: 0x004E663A File Offset: 0x004E483A
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(27, nullMask, 0U);
		}

		// Token: 0x06023A2E RID: 145966 RVA: 0x004E6646 File Offset: 0x004E4846
		public static Offset<IEntityCategory> EndIEntityCategory(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCategory>(builder.EndTable());
		}

		// Token: 0x06023A2F RID: 145967 RVA: 0x004E6654 File Offset: 0x004E4854
		public IEntityCategoryT UnPack()
		{
			IEntityCategoryT entityCategoryT = new IEntityCategoryT();
			this.UnPackTo(entityCategoryT);
			return entityCategoryT;
		}

		// Token: 0x06023A30 RID: 145968 RVA: 0x004E6670 File Offset: 0x004E4870
		public void UnPackTo(IEntityCategoryT _o)
		{
			_o.MainType = this.MainType;
			_o.EntityPlotBindingType = this.EntityPlotBindingType;
			_o.ControlMatchType = this.ControlMatchType;
			_o.MonsterMatchType = this.MonsterMatchType;
			_o.ItemFoundation = this.ItemFoundation;
			_o.HideInFlowType = this.HideInFlowType;
			_o.ExploratoryDegree = this.ExploratoryDegree;
			_o.TraceMatchType = this.TraceMatchType;
			_o.DestructibleType = this.DestructibleType;
			_o.CollectType = this.CollectType;
			_o.TreasureChestStatType = this.TreasureChestStatType;
			_o.NpcType = this.NpcType;
			_o.BulletPenetrationType = this.BulletPenetrationType;
			_o.MechanismType = this.MechanismType;
			_o.InhaledItemType = this.InhaledItemType;
			_o.PullStatueMatchType = this.PullStatueMatchType;
			_o.VehicleType = this.VehicleType;
			_o.FishingMechanismType = this.FishingMechanismType;
			_o.HonamiStoryMapMarkType = this.HonamiStoryMapMarkType;
			_o.VisionDisplayType = this.VisionDisplayType;
			_o.SunSpiritInteractType = this.SunSpiritInteractType;
			_o.AnimalType = this.AnimalType;
			_o.RegionType = this.RegionType;
			_o.RaceType = this.RaceType;
			_o.ProfessionType = this.ProfessionType;
			_o.GenderType = this.GenderType;
			_o.CollectiblesDetectionId = this.CollectiblesDetectionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023A31 RID: 145969 RVA: 0x004E67D0 File Offset: 0x004E49D0
		public static Offset<IEntityCategory> Pack(FlatBufferBuilder builder, IEntityCategoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCategory>);
			}
			StringOffset entityPlotBindingTypeOffset = (_o.EntityPlotBindingType == null) ? default(StringOffset) : builder.CreateString(_o.EntityPlotBindingType);
			return IEntityCategory.CreateIEntityCategory(builder, _o.MainType, entityPlotBindingTypeOffset, _o.ControlMatchType, _o.MonsterMatchType, _o.ItemFoundation, _o.HideInFlowType, _o.ExploratoryDegree, _o.TraceMatchType, _o.DestructibleType, _o.CollectType, _o.TreasureChestStatType, _o.NpcType, _o.BulletPenetrationType, _o.MechanismType, _o.InhaledItemType, _o.PullStatueMatchType, _o.VehicleType, _o.FishingMechanismType, _o.HonamiStoryMapMarkType, _o.VisionDisplayType, _o.SunSpiritInteractType, _o.AnimalType, _o.RegionType, _o.RaceType, _o.ProfessionType, _o.GenderType, _o.CollectiblesDetectionId, _o.NullMask);
		}

		// Token: 0x0400EE18 RID: 60952
		private Table __p;
	}
}
