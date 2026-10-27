using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200516F RID: 20847
	public class IEntityCategoryT
	{
		// Token: 0x1700982B RID: 38955
		// (get) Token: 0x06021ADC RID: 137948 RVA: 0x004AC8C1 File Offset: 0x004AAAC1
		// (set) Token: 0x06021ADD RID: 137949 RVA: 0x004AC8C9 File Offset: 0x004AAAC9
		public EEntityMainType MainType { get; set; }

		// Token: 0x1700982C RID: 38956
		// (get) Token: 0x06021ADE RID: 137950 RVA: 0x004AC8D2 File Offset: 0x004AAAD2
		// (set) Token: 0x06021ADF RID: 137951 RVA: 0x004AC8DA File Offset: 0x004AAADA
		public string EntityPlotBindingType { get; set; }

		// Token: 0x1700982D RID: 38957
		// (get) Token: 0x06021AE0 RID: 137952 RVA: 0x004AC8E3 File Offset: 0x004AAAE3
		// (set) Token: 0x06021AE1 RID: 137953 RVA: 0x004AC8EB File Offset: 0x004AAAEB
		public EControlMatchType ControlMatchType { get; set; }

		// Token: 0x1700982E RID: 38958
		// (get) Token: 0x06021AE2 RID: 137954 RVA: 0x004AC8F4 File Offset: 0x004AAAF4
		// (set) Token: 0x06021AE3 RID: 137955 RVA: 0x004AC8FC File Offset: 0x004AAAFC
		public EMonsterMatchType MonsterMatchType { get; set; }

		// Token: 0x1700982F RID: 38959
		// (get) Token: 0x06021AE4 RID: 137956 RVA: 0x004AC905 File Offset: 0x004AAB05
		// (set) Token: 0x06021AE5 RID: 137957 RVA: 0x004AC90D File Offset: 0x004AAB0D
		public EItemFoundationMatchType ItemFoundation { get; set; }

		// Token: 0x17009830 RID: 38960
		// (get) Token: 0x06021AE6 RID: 137958 RVA: 0x004AC916 File Offset: 0x004AAB16
		// (set) Token: 0x06021AE7 RID: 137959 RVA: 0x004AC91E File Offset: 0x004AAB1E
		public EHideInFlowType HideInFlowType { get; set; }

		// Token: 0x17009831 RID: 38961
		// (get) Token: 0x06021AE8 RID: 137960 RVA: 0x004AC927 File Offset: 0x004AAB27
		// (set) Token: 0x06021AE9 RID: 137961 RVA: 0x004AC92F File Offset: 0x004AAB2F
		public int ExploratoryDegree { get; set; }

		// Token: 0x17009832 RID: 38962
		// (get) Token: 0x06021AEA RID: 137962 RVA: 0x004AC938 File Offset: 0x004AAB38
		// (set) Token: 0x06021AEB RID: 137963 RVA: 0x004AC940 File Offset: 0x004AAB40
		public ETraceMatchType TraceMatchType { get; set; }

		// Token: 0x17009833 RID: 38963
		// (get) Token: 0x06021AEC RID: 137964 RVA: 0x004AC949 File Offset: 0x004AAB49
		// (set) Token: 0x06021AED RID: 137965 RVA: 0x004AC951 File Offset: 0x004AAB51
		public EDestructibleType DestructibleType { get; set; }

		// Token: 0x17009834 RID: 38964
		// (get) Token: 0x06021AEE RID: 137966 RVA: 0x004AC95A File Offset: 0x004AAB5A
		// (set) Token: 0x06021AEF RID: 137967 RVA: 0x004AC962 File Offset: 0x004AAB62
		public ECollectType CollectType { get; set; }

		// Token: 0x17009835 RID: 38965
		// (get) Token: 0x06021AF0 RID: 137968 RVA: 0x004AC96B File Offset: 0x004AAB6B
		// (set) Token: 0x06021AF1 RID: 137969 RVA: 0x004AC973 File Offset: 0x004AAB73
		public ETreasureChestStatType TreasureChestStatType { get; set; }

		// Token: 0x17009836 RID: 38966
		// (get) Token: 0x06021AF2 RID: 137970 RVA: 0x004AC97C File Offset: 0x004AAB7C
		// (set) Token: 0x06021AF3 RID: 137971 RVA: 0x004AC984 File Offset: 0x004AAB84
		public ENpcType NpcType { get; set; }

		// Token: 0x17009837 RID: 38967
		// (get) Token: 0x06021AF4 RID: 137972 RVA: 0x004AC98D File Offset: 0x004AAB8D
		// (set) Token: 0x06021AF5 RID: 137973 RVA: 0x004AC995 File Offset: 0x004AAB95
		public EBulletPenetrationType BulletPenetrationType { get; set; }

		// Token: 0x17009838 RID: 38968
		// (get) Token: 0x06021AF6 RID: 137974 RVA: 0x004AC99E File Offset: 0x004AAB9E
		// (set) Token: 0x06021AF7 RID: 137975 RVA: 0x004AC9A6 File Offset: 0x004AABA6
		public EMechanismType MechanismType { get; set; }

		// Token: 0x17009839 RID: 38969
		// (get) Token: 0x06021AF8 RID: 137976 RVA: 0x004AC9AF File Offset: 0x004AABAF
		// (set) Token: 0x06021AF9 RID: 137977 RVA: 0x004AC9B7 File Offset: 0x004AABB7
		public EInhaledItemType InhaledItemType { get; set; }

		// Token: 0x1700983A RID: 38970
		// (get) Token: 0x06021AFA RID: 137978 RVA: 0x004AC9C0 File Offset: 0x004AABC0
		// (set) Token: 0x06021AFB RID: 137979 RVA: 0x004AC9C8 File Offset: 0x004AABC8
		public EPullStatueMatchType PullStatueMatchType { get; set; }

		// Token: 0x1700983B RID: 38971
		// (get) Token: 0x06021AFC RID: 137980 RVA: 0x004AC9D1 File Offset: 0x004AABD1
		// (set) Token: 0x06021AFD RID: 137981 RVA: 0x004AC9D9 File Offset: 0x004AABD9
		public EVehicleType VehicleType { get; set; }

		// Token: 0x1700983C RID: 38972
		// (get) Token: 0x06021AFE RID: 137982 RVA: 0x004AC9E2 File Offset: 0x004AABE2
		// (set) Token: 0x06021AFF RID: 137983 RVA: 0x004AC9EA File Offset: 0x004AABEA
		public EFishingMechanismType FishingMechanismType { get; set; }

		// Token: 0x1700983D RID: 38973
		// (get) Token: 0x06021B00 RID: 137984 RVA: 0x004AC9F3 File Offset: 0x004AABF3
		// (set) Token: 0x06021B01 RID: 137985 RVA: 0x004AC9FB File Offset: 0x004AABFB
		public EHonamiStoryMapMarkType HonamiStoryMapMarkType { get; set; }

		// Token: 0x1700983E RID: 38974
		// (get) Token: 0x06021B02 RID: 137986 RVA: 0x004ACA04 File Offset: 0x004AAC04
		// (set) Token: 0x06021B03 RID: 137987 RVA: 0x004ACA0C File Offset: 0x004AAC0C
		public EVisionDisplayType VisionDisplayType { get; set; }

		// Token: 0x1700983F RID: 38975
		// (get) Token: 0x06021B04 RID: 137988 RVA: 0x004ACA15 File Offset: 0x004AAC15
		// (set) Token: 0x06021B05 RID: 137989 RVA: 0x004ACA1D File Offset: 0x004AAC1D
		public ESunSpiritInteractType SunSpiritInteractType { get; set; }

		// Token: 0x17009840 RID: 38976
		// (get) Token: 0x06021B06 RID: 137990 RVA: 0x004ACA26 File Offset: 0x004AAC26
		// (set) Token: 0x06021B07 RID: 137991 RVA: 0x004ACA2E File Offset: 0x004AAC2E
		public EAnimalType AnimalType { get; set; }

		// Token: 0x17009841 RID: 38977
		// (get) Token: 0x06021B08 RID: 137992 RVA: 0x004ACA37 File Offset: 0x004AAC37
		// (set) Token: 0x06021B09 RID: 137993 RVA: 0x004ACA3F File Offset: 0x004AAC3F
		public ERegionType RegionType { get; set; }

		// Token: 0x17009842 RID: 38978
		// (get) Token: 0x06021B0A RID: 137994 RVA: 0x004ACA48 File Offset: 0x004AAC48
		// (set) Token: 0x06021B0B RID: 137995 RVA: 0x004ACA50 File Offset: 0x004AAC50
		public ERaceType RaceType { get; set; }

		// Token: 0x17009843 RID: 38979
		// (get) Token: 0x06021B0C RID: 137996 RVA: 0x004ACA59 File Offset: 0x004AAC59
		// (set) Token: 0x06021B0D RID: 137997 RVA: 0x004ACA61 File Offset: 0x004AAC61
		public EProfessionType ProfessionType { get; set; }

		// Token: 0x17009844 RID: 38980
		// (get) Token: 0x06021B0E RID: 137998 RVA: 0x004ACA6A File Offset: 0x004AAC6A
		// (set) Token: 0x06021B0F RID: 137999 RVA: 0x004ACA72 File Offset: 0x004AAC72
		public EGenderType GenderType { get; set; }

		// Token: 0x17009845 RID: 38981
		// (get) Token: 0x06021B10 RID: 138000 RVA: 0x004ACA7B File Offset: 0x004AAC7B
		// (set) Token: 0x06021B11 RID: 138001 RVA: 0x004ACA83 File Offset: 0x004AAC83
		public uint NullMask { get; set; }

		// Token: 0x06021B12 RID: 138002 RVA: 0x004ACA8C File Offset: 0x004AAC8C
		public IEntityCategoryT()
		{
			this.MainType = EEntityMainType.Npc;
			this.EntityPlotBindingType = null;
			this.ControlMatchType = EControlMatchType.GrowSolution;
			this.MonsterMatchType = EMonsterMatchType.Normal;
			this.ItemFoundation = EItemFoundationMatchType.Branch;
			this.HideInFlowType = EHideInFlowType.None;
			this.ExploratoryDegree = 0;
			this.TraceMatchType = ETraceMatchType.None;
			this.DestructibleType = EDestructibleType.Rock;
			this.CollectType = ECollectType.Botany;
			this.TreasureChestStatType = ETreasureChestStatType.OneTime;
			this.NpcType = ENpcType.Common;
			this.BulletPenetrationType = EBulletPenetrationType.Penetrable;
			this.MechanismType = EMechanismType.Portal;
			this.InhaledItemType = EInhaledItemType.LonelyDollPollutant;
			this.PullStatueMatchType = EPullStatueMatchType.Statue;
			this.VehicleType = EVehicleType.Gongduola;
			this.FishingMechanismType = EFishingMechanismType.FishingPoint;
			this.HonamiStoryMapMarkType = EHonamiStoryMapMarkType.EvacuateMachine;
			this.VisionDisplayType = EVisionDisplayType.MechanicalDeer;
			this.SunSpiritInteractType = ESunSpiritInteractType.RollingBall;
			this.AnimalType = EAnimalType.Cat;
			this.RegionType = ERegionType.Lahailuo;
			this.RaceType = ERaceType.Luoyizu;
			this.ProfessionType = EProfessionType.Teacher;
			this.GenderType = EGenderType.Male;
			this.NullMask = 0U;
		}
	}
}
