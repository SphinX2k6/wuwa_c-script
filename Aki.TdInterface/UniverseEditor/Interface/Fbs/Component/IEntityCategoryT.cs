using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D4 RID: 22228
	public class IEntityCategoryT
	{
		// Token: 0x1700A019 RID: 40985
		// (get) Token: 0x06023A32 RID: 145970 RVA: 0x004E68B3 File Offset: 0x004E4AB3
		// (set) Token: 0x06023A33 RID: 145971 RVA: 0x004E68BB File Offset: 0x004E4ABB
		public EEntityMainType MainType { get; set; }

		// Token: 0x1700A01A RID: 40986
		// (get) Token: 0x06023A34 RID: 145972 RVA: 0x004E68C4 File Offset: 0x004E4AC4
		// (set) Token: 0x06023A35 RID: 145973 RVA: 0x004E68CC File Offset: 0x004E4ACC
		public string EntityPlotBindingType { get; set; }

		// Token: 0x1700A01B RID: 40987
		// (get) Token: 0x06023A36 RID: 145974 RVA: 0x004E68D5 File Offset: 0x004E4AD5
		// (set) Token: 0x06023A37 RID: 145975 RVA: 0x004E68DD File Offset: 0x004E4ADD
		public EControlMatchType ControlMatchType { get; set; }

		// Token: 0x1700A01C RID: 40988
		// (get) Token: 0x06023A38 RID: 145976 RVA: 0x004E68E6 File Offset: 0x004E4AE6
		// (set) Token: 0x06023A39 RID: 145977 RVA: 0x004E68EE File Offset: 0x004E4AEE
		public EMonsterMatchType MonsterMatchType { get; set; }

		// Token: 0x1700A01D RID: 40989
		// (get) Token: 0x06023A3A RID: 145978 RVA: 0x004E68F7 File Offset: 0x004E4AF7
		// (set) Token: 0x06023A3B RID: 145979 RVA: 0x004E68FF File Offset: 0x004E4AFF
		public EItemFoundationMatchType ItemFoundation { get; set; }

		// Token: 0x1700A01E RID: 40990
		// (get) Token: 0x06023A3C RID: 145980 RVA: 0x004E6908 File Offset: 0x004E4B08
		// (set) Token: 0x06023A3D RID: 145981 RVA: 0x004E6910 File Offset: 0x004E4B10
		public EHideInFlowType HideInFlowType { get; set; }

		// Token: 0x1700A01F RID: 40991
		// (get) Token: 0x06023A3E RID: 145982 RVA: 0x004E6919 File Offset: 0x004E4B19
		// (set) Token: 0x06023A3F RID: 145983 RVA: 0x004E6921 File Offset: 0x004E4B21
		public int ExploratoryDegree { get; set; }

		// Token: 0x1700A020 RID: 40992
		// (get) Token: 0x06023A40 RID: 145984 RVA: 0x004E692A File Offset: 0x004E4B2A
		// (set) Token: 0x06023A41 RID: 145985 RVA: 0x004E6932 File Offset: 0x004E4B32
		public ETraceMatchType TraceMatchType { get; set; }

		// Token: 0x1700A021 RID: 40993
		// (get) Token: 0x06023A42 RID: 145986 RVA: 0x004E693B File Offset: 0x004E4B3B
		// (set) Token: 0x06023A43 RID: 145987 RVA: 0x004E6943 File Offset: 0x004E4B43
		public EDestructibleType DestructibleType { get; set; }

		// Token: 0x1700A022 RID: 40994
		// (get) Token: 0x06023A44 RID: 145988 RVA: 0x004E694C File Offset: 0x004E4B4C
		// (set) Token: 0x06023A45 RID: 145989 RVA: 0x004E6954 File Offset: 0x004E4B54
		public ECollectType CollectType { get; set; }

		// Token: 0x1700A023 RID: 40995
		// (get) Token: 0x06023A46 RID: 145990 RVA: 0x004E695D File Offset: 0x004E4B5D
		// (set) Token: 0x06023A47 RID: 145991 RVA: 0x004E6965 File Offset: 0x004E4B65
		public ETreasureChestStatType TreasureChestStatType { get; set; }

		// Token: 0x1700A024 RID: 40996
		// (get) Token: 0x06023A48 RID: 145992 RVA: 0x004E696E File Offset: 0x004E4B6E
		// (set) Token: 0x06023A49 RID: 145993 RVA: 0x004E6976 File Offset: 0x004E4B76
		public ENpcType NpcType { get; set; }

		// Token: 0x1700A025 RID: 40997
		// (get) Token: 0x06023A4A RID: 145994 RVA: 0x004E697F File Offset: 0x004E4B7F
		// (set) Token: 0x06023A4B RID: 145995 RVA: 0x004E6987 File Offset: 0x004E4B87
		public EBulletPenetrationType BulletPenetrationType { get; set; }

		// Token: 0x1700A026 RID: 40998
		// (get) Token: 0x06023A4C RID: 145996 RVA: 0x004E6990 File Offset: 0x004E4B90
		// (set) Token: 0x06023A4D RID: 145997 RVA: 0x004E6998 File Offset: 0x004E4B98
		public EMechanismType MechanismType { get; set; }

		// Token: 0x1700A027 RID: 40999
		// (get) Token: 0x06023A4E RID: 145998 RVA: 0x004E69A1 File Offset: 0x004E4BA1
		// (set) Token: 0x06023A4F RID: 145999 RVA: 0x004E69A9 File Offset: 0x004E4BA9
		public EInhaledItemType InhaledItemType { get; set; }

		// Token: 0x1700A028 RID: 41000
		// (get) Token: 0x06023A50 RID: 146000 RVA: 0x004E69B2 File Offset: 0x004E4BB2
		// (set) Token: 0x06023A51 RID: 146001 RVA: 0x004E69BA File Offset: 0x004E4BBA
		public EPullStatueMatchType PullStatueMatchType { get; set; }

		// Token: 0x1700A029 RID: 41001
		// (get) Token: 0x06023A52 RID: 146002 RVA: 0x004E69C3 File Offset: 0x004E4BC3
		// (set) Token: 0x06023A53 RID: 146003 RVA: 0x004E69CB File Offset: 0x004E4BCB
		public EVehicleType VehicleType { get; set; }

		// Token: 0x1700A02A RID: 41002
		// (get) Token: 0x06023A54 RID: 146004 RVA: 0x004E69D4 File Offset: 0x004E4BD4
		// (set) Token: 0x06023A55 RID: 146005 RVA: 0x004E69DC File Offset: 0x004E4BDC
		public EFishingMechanismType FishingMechanismType { get; set; }

		// Token: 0x1700A02B RID: 41003
		// (get) Token: 0x06023A56 RID: 146006 RVA: 0x004E69E5 File Offset: 0x004E4BE5
		// (set) Token: 0x06023A57 RID: 146007 RVA: 0x004E69ED File Offset: 0x004E4BED
		public EHonamiStoryMapMarkType HonamiStoryMapMarkType { get; set; }

		// Token: 0x1700A02C RID: 41004
		// (get) Token: 0x06023A58 RID: 146008 RVA: 0x004E69F6 File Offset: 0x004E4BF6
		// (set) Token: 0x06023A59 RID: 146009 RVA: 0x004E69FE File Offset: 0x004E4BFE
		public EVisionDisplayType VisionDisplayType { get; set; }

		// Token: 0x1700A02D RID: 41005
		// (get) Token: 0x06023A5A RID: 146010 RVA: 0x004E6A07 File Offset: 0x004E4C07
		// (set) Token: 0x06023A5B RID: 146011 RVA: 0x004E6A0F File Offset: 0x004E4C0F
		public ESunSpiritInteractType SunSpiritInteractType { get; set; }

		// Token: 0x1700A02E RID: 41006
		// (get) Token: 0x06023A5C RID: 146012 RVA: 0x004E6A18 File Offset: 0x004E4C18
		// (set) Token: 0x06023A5D RID: 146013 RVA: 0x004E6A20 File Offset: 0x004E4C20
		public EAnimalType AnimalType { get; set; }

		// Token: 0x1700A02F RID: 41007
		// (get) Token: 0x06023A5E RID: 146014 RVA: 0x004E6A29 File Offset: 0x004E4C29
		// (set) Token: 0x06023A5F RID: 146015 RVA: 0x004E6A31 File Offset: 0x004E4C31
		public ERegionType RegionType { get; set; }

		// Token: 0x1700A030 RID: 41008
		// (get) Token: 0x06023A60 RID: 146016 RVA: 0x004E6A3A File Offset: 0x004E4C3A
		// (set) Token: 0x06023A61 RID: 146017 RVA: 0x004E6A42 File Offset: 0x004E4C42
		public ERaceType RaceType { get; set; }

		// Token: 0x1700A031 RID: 41009
		// (get) Token: 0x06023A62 RID: 146018 RVA: 0x004E6A4B File Offset: 0x004E4C4B
		// (set) Token: 0x06023A63 RID: 146019 RVA: 0x004E6A53 File Offset: 0x004E4C53
		public EProfessionType ProfessionType { get; set; }

		// Token: 0x1700A032 RID: 41010
		// (get) Token: 0x06023A64 RID: 146020 RVA: 0x004E6A5C File Offset: 0x004E4C5C
		// (set) Token: 0x06023A65 RID: 146021 RVA: 0x004E6A64 File Offset: 0x004E4C64
		public EGenderType GenderType { get; set; }

		// Token: 0x1700A033 RID: 41011
		// (get) Token: 0x06023A66 RID: 146022 RVA: 0x004E6A6D File Offset: 0x004E4C6D
		// (set) Token: 0x06023A67 RID: 146023 RVA: 0x004E6A75 File Offset: 0x004E4C75
		public int CollectiblesDetectionId { get; set; }

		// Token: 0x1700A034 RID: 41012
		// (get) Token: 0x06023A68 RID: 146024 RVA: 0x004E6A7E File Offset: 0x004E4C7E
		// (set) Token: 0x06023A69 RID: 146025 RVA: 0x004E6A86 File Offset: 0x004E4C86
		public uint NullMask { get; set; }

		// Token: 0x06023A6A RID: 146026 RVA: 0x004E6A90 File Offset: 0x004E4C90
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
			this.CollectiblesDetectionId = 0;
			this.NullMask = 0U;
		}
	}
}
