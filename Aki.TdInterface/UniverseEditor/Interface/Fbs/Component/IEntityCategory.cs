using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200516E RID: 20846
	public struct IEntityCategory : IFlatbufferObject
	{
		// Token: 0x1700980F RID: 38927
		// (get) Token: 0x06021A98 RID: 137880 RVA: 0x004ABCF3 File Offset: 0x004A9EF3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A99 RID: 137881 RVA: 0x004ABD00 File Offset: 0x004A9F00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A9A RID: 137882 RVA: 0x004ABD08 File Offset: 0x004A9F08
		public static IEntityCategory GetRootAsIEntityCategory(ByteBuffer _bb)
		{
			return IEntityCategory.GetRootAsIEntityCategory(_bb, default(IEntityCategory));
		}

		// Token: 0x06021A9B RID: 137883 RVA: 0x004ABD24 File Offset: 0x004A9F24
		public static IEntityCategory GetRootAsIEntityCategory(ByteBuffer _bb, IEntityCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A9C RID: 137884 RVA: 0x004ABD41 File Offset: 0x004A9F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A9D RID: 137885 RVA: 0x004ABD50 File Offset: 0x004A9F50
		public IEntityCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009810 RID: 38928
		// (get) Token: 0x06021A9E RID: 137886 RVA: 0x004ABD60 File Offset: 0x004A9F60
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

		// Token: 0x17009811 RID: 38929
		// (get) Token: 0x06021A9F RID: 137887 RVA: 0x004ABD9C File Offset: 0x004A9F9C
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

		// Token: 0x06021AA0 RID: 137888 RVA: 0x004ABDD3 File Offset: 0x004A9FD3
		public Span<byte> GetEntityPlotBindingTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021AA1 RID: 137889 RVA: 0x004ABDE2 File Offset: 0x004A9FE2
		public byte[] GetEntityPlotBindingTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009812 RID: 38930
		// (get) Token: 0x06021AA2 RID: 137890 RVA: 0x004ABDF0 File Offset: 0x004A9FF0
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

		// Token: 0x17009813 RID: 38931
		// (get) Token: 0x06021AA3 RID: 137891 RVA: 0x004ABE2C File Offset: 0x004AA02C
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

		// Token: 0x17009814 RID: 38932
		// (get) Token: 0x06021AA4 RID: 137892 RVA: 0x004ABE6C File Offset: 0x004AA06C
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

		// Token: 0x17009815 RID: 38933
		// (get) Token: 0x06021AA5 RID: 137893 RVA: 0x004ABEAC File Offset: 0x004AA0AC
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

		// Token: 0x17009816 RID: 38934
		// (get) Token: 0x06021AA6 RID: 137894 RVA: 0x004ABEEC File Offset: 0x004AA0EC
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

		// Token: 0x17009817 RID: 38935
		// (get) Token: 0x06021AA7 RID: 137895 RVA: 0x004ABF2C File Offset: 0x004AA12C
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

		// Token: 0x17009818 RID: 38936
		// (get) Token: 0x06021AA8 RID: 137896 RVA: 0x004ABF6C File Offset: 0x004AA16C
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

		// Token: 0x17009819 RID: 38937
		// (get) Token: 0x06021AA9 RID: 137897 RVA: 0x004ABFAC File Offset: 0x004AA1AC
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

		// Token: 0x1700981A RID: 38938
		// (get) Token: 0x06021AAA RID: 137898 RVA: 0x004ABFEC File Offset: 0x004AA1EC
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

		// Token: 0x1700981B RID: 38939
		// (get) Token: 0x06021AAB RID: 137899 RVA: 0x004AC02C File Offset: 0x004AA22C
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

		// Token: 0x1700981C RID: 38940
		// (get) Token: 0x06021AAC RID: 137900 RVA: 0x004AC06C File Offset: 0x004AA26C
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

		// Token: 0x1700981D RID: 38941
		// (get) Token: 0x06021AAD RID: 137901 RVA: 0x004AC0AC File Offset: 0x004AA2AC
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

		// Token: 0x1700981E RID: 38942
		// (get) Token: 0x06021AAE RID: 137902 RVA: 0x004AC0EC File Offset: 0x004AA2EC
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

		// Token: 0x1700981F RID: 38943
		// (get) Token: 0x06021AAF RID: 137903 RVA: 0x004AC12C File Offset: 0x004AA32C
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

		// Token: 0x17009820 RID: 38944
		// (get) Token: 0x06021AB0 RID: 137904 RVA: 0x004AC16C File Offset: 0x004AA36C
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

		// Token: 0x17009821 RID: 38945
		// (get) Token: 0x06021AB1 RID: 137905 RVA: 0x004AC1AC File Offset: 0x004AA3AC
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

		// Token: 0x17009822 RID: 38946
		// (get) Token: 0x06021AB2 RID: 137906 RVA: 0x004AC1EC File Offset: 0x004AA3EC
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

		// Token: 0x17009823 RID: 38947
		// (get) Token: 0x06021AB3 RID: 137907 RVA: 0x004AC22C File Offset: 0x004AA42C
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

		// Token: 0x17009824 RID: 38948
		// (get) Token: 0x06021AB4 RID: 137908 RVA: 0x004AC26C File Offset: 0x004AA46C
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

		// Token: 0x17009825 RID: 38949
		// (get) Token: 0x06021AB5 RID: 137909 RVA: 0x004AC2AC File Offset: 0x004AA4AC
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

		// Token: 0x17009826 RID: 38950
		// (get) Token: 0x06021AB6 RID: 137910 RVA: 0x004AC2EC File Offset: 0x004AA4EC
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

		// Token: 0x17009827 RID: 38951
		// (get) Token: 0x06021AB7 RID: 137911 RVA: 0x004AC32C File Offset: 0x004AA52C
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

		// Token: 0x17009828 RID: 38952
		// (get) Token: 0x06021AB8 RID: 137912 RVA: 0x004AC36C File Offset: 0x004AA56C
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

		// Token: 0x17009829 RID: 38953
		// (get) Token: 0x06021AB9 RID: 137913 RVA: 0x004AC3AC File Offset: 0x004AA5AC
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

		// Token: 0x1700982A RID: 38954
		// (get) Token: 0x06021ABA RID: 137914 RVA: 0x004AC3EC File Offset: 0x004AA5EC
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021ABB RID: 137915 RVA: 0x004AC42C File Offset: 0x004AA62C
		public static Offset<IEntityCategory> CreateIEntityCategory(FlatBufferBuilder builder, EEntityMainType MainType = EEntityMainType.Npc, StringOffset EntityPlotBindingTypeOffset = default(StringOffset), EControlMatchType ControlMatchType = EControlMatchType.GrowSolution, EMonsterMatchType MonsterMatchType = EMonsterMatchType.Normal, EItemFoundationMatchType ItemFoundation = EItemFoundationMatchType.Branch, EHideInFlowType HideInFlowType = EHideInFlowType.None, int ExploratoryDegree = 0, ETraceMatchType TraceMatchType = ETraceMatchType.None, EDestructibleType DestructibleType = EDestructibleType.Rock, ECollectType CollectType = ECollectType.Botany, ETreasureChestStatType TreasureChestStatType = ETreasureChestStatType.OneTime, ENpcType NpcType = ENpcType.Common, EBulletPenetrationType BulletPenetrationType = EBulletPenetrationType.Penetrable, EMechanismType MechanismType = EMechanismType.Portal, EInhaledItemType InhaledItemType = EInhaledItemType.LonelyDollPollutant, EPullStatueMatchType PullStatueMatchType = EPullStatueMatchType.Statue, EVehicleType VehicleType = EVehicleType.Gongduola, EFishingMechanismType FishingMechanismType = EFishingMechanismType.FishingPoint, EHonamiStoryMapMarkType HonamiStoryMapMarkType = EHonamiStoryMapMarkType.EvacuateMachine, EVisionDisplayType VisionDisplayType = EVisionDisplayType.MechanicalDeer, ESunSpiritInteractType SunSpiritInteractType = ESunSpiritInteractType.RollingBall, EAnimalType AnimalType = EAnimalType.Cat, ERegionType RegionType = ERegionType.Lahailuo, ERaceType RaceType = ERaceType.Luoyizu, EProfessionType ProfessionType = EProfessionType.Teacher, EGenderType GenderType = EGenderType.Male, uint NullMask = 0U)
		{
			builder.StartTable(27);
			IEntityCategory.AddNullMask(builder, NullMask);
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

		// Token: 0x06021ABC RID: 137916 RVA: 0x004AC51C File Offset: 0x004AA71C
		public static void StartIEntityCategory(FlatBufferBuilder builder)
		{
			builder.StartTable(27);
		}

		// Token: 0x06021ABD RID: 137917 RVA: 0x004AC526 File Offset: 0x004AA726
		public static void AddMainType(FlatBufferBuilder builder, EEntityMainType mainType)
		{
			builder.AddByte(0, (byte)mainType, 0);
		}

		// Token: 0x06021ABE RID: 137918 RVA: 0x004AC531 File Offset: 0x004AA731
		public static void AddEntityPlotBindingType(FlatBufferBuilder builder, StringOffset entityPlotBindingTypeOffset)
		{
			builder.AddOffset(1, entityPlotBindingTypeOffset.Value, 0);
		}

		// Token: 0x06021ABF RID: 137919 RVA: 0x004AC541 File Offset: 0x004AA741
		public static void AddControlMatchType(FlatBufferBuilder builder, EControlMatchType controlMatchType)
		{
			builder.AddByte(2, (byte)controlMatchType, 0);
		}

		// Token: 0x06021AC0 RID: 137920 RVA: 0x004AC54C File Offset: 0x004AA74C
		public static void AddMonsterMatchType(FlatBufferBuilder builder, EMonsterMatchType monsterMatchType)
		{
			builder.AddByte(3, (byte)monsterMatchType, 0);
		}

		// Token: 0x06021AC1 RID: 137921 RVA: 0x004AC557 File Offset: 0x004AA757
		public static void AddItemFoundation(FlatBufferBuilder builder, EItemFoundationMatchType itemFoundation)
		{
			builder.AddByte(4, (byte)itemFoundation, 0);
		}

		// Token: 0x06021AC2 RID: 137922 RVA: 0x004AC562 File Offset: 0x004AA762
		public static void AddHideInFlowType(FlatBufferBuilder builder, EHideInFlowType hideInFlowType)
		{
			builder.AddByte(5, (byte)hideInFlowType, 0);
		}

		// Token: 0x06021AC3 RID: 137923 RVA: 0x004AC56D File Offset: 0x004AA76D
		public static void AddExploratoryDegree(FlatBufferBuilder builder, int exploratoryDegree)
		{
			builder.AddInt(6, exploratoryDegree, 0);
		}

		// Token: 0x06021AC4 RID: 137924 RVA: 0x004AC578 File Offset: 0x004AA778
		public static void AddTraceMatchType(FlatBufferBuilder builder, ETraceMatchType traceMatchType)
		{
			builder.AddByte(7, (byte)traceMatchType, 0);
		}

		// Token: 0x06021AC5 RID: 137925 RVA: 0x004AC583 File Offset: 0x004AA783
		public static void AddDestructibleType(FlatBufferBuilder builder, EDestructibleType destructibleType)
		{
			builder.AddByte(8, (byte)destructibleType, 0);
		}

		// Token: 0x06021AC6 RID: 137926 RVA: 0x004AC58E File Offset: 0x004AA78E
		public static void AddCollectType(FlatBufferBuilder builder, ECollectType collectType)
		{
			builder.AddByte(9, (byte)collectType, 0);
		}

		// Token: 0x06021AC7 RID: 137927 RVA: 0x004AC59A File Offset: 0x004AA79A
		public static void AddTreasureChestStatType(FlatBufferBuilder builder, ETreasureChestStatType treasureChestStatType)
		{
			builder.AddByte(10, (byte)treasureChestStatType, 0);
		}

		// Token: 0x06021AC8 RID: 137928 RVA: 0x004AC5A6 File Offset: 0x004AA7A6
		public static void AddNpcType(FlatBufferBuilder builder, ENpcType npcType)
		{
			builder.AddByte(11, (byte)npcType, 0);
		}

		// Token: 0x06021AC9 RID: 137929 RVA: 0x004AC5B2 File Offset: 0x004AA7B2
		public static void AddBulletPenetrationType(FlatBufferBuilder builder, EBulletPenetrationType bulletPenetrationType)
		{
			builder.AddByte(12, (byte)bulletPenetrationType, 0);
		}

		// Token: 0x06021ACA RID: 137930 RVA: 0x004AC5BE File Offset: 0x004AA7BE
		public static void AddMechanismType(FlatBufferBuilder builder, EMechanismType mechanismType)
		{
			builder.AddByte(13, (byte)mechanismType, 0);
		}

		// Token: 0x06021ACB RID: 137931 RVA: 0x004AC5CA File Offset: 0x004AA7CA
		public static void AddInhaledItemType(FlatBufferBuilder builder, EInhaledItemType inhaledItemType)
		{
			builder.AddByte(14, (byte)inhaledItemType, 0);
		}

		// Token: 0x06021ACC RID: 137932 RVA: 0x004AC5D6 File Offset: 0x004AA7D6
		public static void AddPullStatueMatchType(FlatBufferBuilder builder, EPullStatueMatchType pullStatueMatchType)
		{
			builder.AddByte(15, (byte)pullStatueMatchType, 0);
		}

		// Token: 0x06021ACD RID: 137933 RVA: 0x004AC5E2 File Offset: 0x004AA7E2
		public static void AddVehicleType(FlatBufferBuilder builder, EVehicleType vehicleType)
		{
			builder.AddByte(16, (byte)vehicleType, 0);
		}

		// Token: 0x06021ACE RID: 137934 RVA: 0x004AC5EE File Offset: 0x004AA7EE
		public static void AddFishingMechanismType(FlatBufferBuilder builder, EFishingMechanismType fishingMechanismType)
		{
			builder.AddByte(17, (byte)fishingMechanismType, 0);
		}

		// Token: 0x06021ACF RID: 137935 RVA: 0x004AC5FA File Offset: 0x004AA7FA
		public static void AddHonamiStoryMapMarkType(FlatBufferBuilder builder, EHonamiStoryMapMarkType honamiStoryMapMarkType)
		{
			builder.AddByte(18, (byte)honamiStoryMapMarkType, 0);
		}

		// Token: 0x06021AD0 RID: 137936 RVA: 0x004AC606 File Offset: 0x004AA806
		public static void AddVisionDisplayType(FlatBufferBuilder builder, EVisionDisplayType visionDisplayType)
		{
			builder.AddByte(19, (byte)visionDisplayType, 0);
		}

		// Token: 0x06021AD1 RID: 137937 RVA: 0x004AC612 File Offset: 0x004AA812
		public static void AddSunSpiritInteractType(FlatBufferBuilder builder, ESunSpiritInteractType sunSpiritInteractType)
		{
			builder.AddByte(20, (byte)sunSpiritInteractType, 0);
		}

		// Token: 0x06021AD2 RID: 137938 RVA: 0x004AC61E File Offset: 0x004AA81E
		public static void AddAnimalType(FlatBufferBuilder builder, EAnimalType animalType)
		{
			builder.AddByte(21, (byte)animalType, 0);
		}

		// Token: 0x06021AD3 RID: 137939 RVA: 0x004AC62A File Offset: 0x004AA82A
		public static void AddRegionType(FlatBufferBuilder builder, ERegionType regionType)
		{
			builder.AddByte(22, (byte)regionType, 0);
		}

		// Token: 0x06021AD4 RID: 137940 RVA: 0x004AC636 File Offset: 0x004AA836
		public static void AddRaceType(FlatBufferBuilder builder, ERaceType raceType)
		{
			builder.AddByte(23, (byte)raceType, 0);
		}

		// Token: 0x06021AD5 RID: 137941 RVA: 0x004AC642 File Offset: 0x004AA842
		public static void AddProfessionType(FlatBufferBuilder builder, EProfessionType professionType)
		{
			builder.AddByte(24, (byte)professionType, 0);
		}

		// Token: 0x06021AD6 RID: 137942 RVA: 0x004AC64E File Offset: 0x004AA84E
		public static void AddGenderType(FlatBufferBuilder builder, EGenderType genderType)
		{
			builder.AddByte(25, (byte)genderType, 0);
		}

		// Token: 0x06021AD7 RID: 137943 RVA: 0x004AC65A File Offset: 0x004AA85A
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(26, nullMask, 0U);
		}

		// Token: 0x06021AD8 RID: 137944 RVA: 0x004AC666 File Offset: 0x004AA866
		public static Offset<IEntityCategory> EndIEntityCategory(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCategory>(builder.EndTable());
		}

		// Token: 0x06021AD9 RID: 137945 RVA: 0x004AC674 File Offset: 0x004AA874
		public IEntityCategoryT UnPack()
		{
			IEntityCategoryT entityCategoryT = new IEntityCategoryT();
			this.UnPackTo(entityCategoryT);
			return entityCategoryT;
		}

		// Token: 0x06021ADA RID: 137946 RVA: 0x004AC690 File Offset: 0x004AA890
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021ADB RID: 137947 RVA: 0x004AC7E4 File Offset: 0x004AA9E4
		public static Offset<IEntityCategory> Pack(FlatBufferBuilder builder, IEntityCategoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCategory>);
			}
			StringOffset entityPlotBindingTypeOffset = (_o.EntityPlotBindingType == null) ? default(StringOffset) : builder.CreateString(_o.EntityPlotBindingType);
			return IEntityCategory.CreateIEntityCategory(builder, _o.MainType, entityPlotBindingTypeOffset, _o.ControlMatchType, _o.MonsterMatchType, _o.ItemFoundation, _o.HideInFlowType, _o.ExploratoryDegree, _o.TraceMatchType, _o.DestructibleType, _o.CollectType, _o.TreasureChestStatType, _o.NpcType, _o.BulletPenetrationType, _o.MechanismType, _o.InhaledItemType, _o.PullStatueMatchType, _o.VehicleType, _o.FishingMechanismType, _o.HonamiStoryMapMarkType, _o.VisionDisplayType, _o.SunSpiritInteractType, _o.AnimalType, _o.RegionType, _o.RaceType, _o.ProfessionType, _o.GenderType, _o.NullMask);
		}

		// Token: 0x0400E21B RID: 57883
		private Table __p;
	}
}
