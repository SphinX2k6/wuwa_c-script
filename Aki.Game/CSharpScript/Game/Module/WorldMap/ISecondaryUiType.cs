using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel;
using CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036BB RID: 14011
	[NullableContext(1)]
	public interface ISecondaryUiType
	{
		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x060245F3 RID: 148979
		// (set) Token: 0x060245F4 RID: 148980
		Action<CustomMarkItem, ECustomMarkPanelMode> CustomMarkPanel { get; set; }

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x060245F5 RID: 148981
		// (set) Token: 0x060245F6 RID: 148982
		Action<TeleportMarkItem> TeleportPanel { get; set; }

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x060245F7 RID: 148983
		// (set) Token: 0x060245F8 RID: 148984
		Action<ConfigMarkItem> GeneralPanel { get; set; }

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x060245F9 RID: 148985
		// (set) Token: 0x060245FA RID: 148986
		Action<MarkItem[]> MarkMenuPanel { get; set; }

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x060245FB RID: 148987
		// (set) Token: 0x060245FC RID: 148988
		Action<TaskMarkItem> QuestPanel { get; set; }

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x060245FD RID: 148989
		// (set) Token: 0x060245FE RID: 148990
		Action<TeleportMarkItem> InstanceDungeonEntrancePanel { get; set; }

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x060245FF RID: 148991
		// (set) Token: 0x06024600 RID: 148992
		Action<SceneGameplayMarkItem> SceneGameplayPanel { get; set; }

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x06024601 RID: 148993
		// (set) Token: 0x06024602 RID: 148994
		Action<TeleportMarkItem> TowerEntrancePanel { get; set; }

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x06024603 RID: 148995
		// (set) Token: 0x06024604 RID: 148996
		Action<TeleportMarkItem> ShipTowerEntrancePanel { get; set; }

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x06024605 RID: 148997
		// (set) Token: 0x06024606 RID: 148998
		Action<ParkourMarkItem> ParkourPanel { get; set; }

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x06024607 RID: 148999
		// (set) Token: 0x06024608 RID: 149000
		Action<TemporaryTeleportMarkItem> TemporaryTeleportPanel { get; set; }

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x06024609 RID: 149001
		// (set) Token: 0x0602460A RID: 149002
		Action<TreasureBoxDetectorMarkItem> DetectorPanel { get; set; }

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x0602460B RID: 149003
		// (set) Token: 0x0602460C RID: 149004
		Action<IBoxMark> BoxPanel { get; set; }

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x0602460D RID: 149005
		// (set) Token: 0x0602460E RID: 149006
		Action<SceneGameplayMarkItem> LordGymPanel { get; set; }

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x0602460F RID: 149007
		// (set) Token: 0x06024610 RID: 149008
		Action<TeleportMarkItem> RoguelikePanel { get; set; }

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x06024611 RID: 149009
		// (set) Token: 0x06024612 RID: 149010
		Action<ConfigMarkItem> WeeklyRoguePanel { get; set; }

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x06024613 RID: 149011
		// (set) Token: 0x06024614 RID: 149012
		Action<ConfigMarkItem> RogueResPanel { get; set; }

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x06024615 RID: 149013
		// (set) Token: 0x06024616 RID: 149014
		Action<EnrichmentAreaItem> EnrichmentAreaPanel { get; set; }

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x06024617 RID: 149015
		// (set) Token: 0x06024618 RID: 149016
		Action<PunishReportMarkItem> PunishReportPanel { get; set; }

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x06024619 RID: 149017
		// (set) Token: 0x0602461A RID: 149018
		Action<CorniceMeetingMarkItem> CorniceMeetingPanel { get; set; }

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x0602461B RID: 149019
		// (set) Token: 0x0602461C RID: 149020
		Action<MarkItem[]> QuickNavigatePanel { get; set; }

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x0602461D RID: 149021
		// (set) Token: 0x0602461E RID: 149022
		Action<CaveHoleMarkItem> CaveHole { get; set; }

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x0602461F RID: 149023
		// (set) Token: 0x06024620 RID: 149024
		Action<ConfigMarkItem> CommonGamePlayPanel { get; set; }

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x06024621 RID: 149025
		// (set) Token: 0x06024622 RID: 149026
		Action<ITrackMenuItemData[]> TrackMenuPanel { get; set; }

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x06024623 RID: 149027
		// (set) Token: 0x06024624 RID: 149028
		Action<IMapNoteParams[]> WorldMapNotePanel { get; set; }

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x06024625 RID: 149029
		// (set) Token: 0x06024626 RID: 149030
		Action MapMarkTogglePanel { get; set; }

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x06024627 RID: 149031
		// (set) Token: 0x06024628 RID: 149032
		Action<TeleportMarkItem> MapTravelQuestPanel { get; set; }

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x06024629 RID: 149033
		// (set) Token: 0x0602462A RID: 149034
		Action<FishingShipMarkItem> FishingShip { get; set; }

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x0602462B RID: 149035
		// (set) Token: 0x0602462C RID: 149036
		Action<FishingPointMarkItem> FishingPoint { get; set; }

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x0602462D RID: 149037
		// (set) Token: 0x0602462E RID: 149038
		Action<ConfigMarkItem> FishingCage { get; set; }

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x0602462F RID: 149039
		// (set) Token: 0x06024630 RID: 149040
		Action<ConfigMarkItem> FishingDock { get; set; }

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x06024631 RID: 149041
		// (set) Token: 0x06024632 RID: 149042
		Action<TraceExploreEntityMarkItem> TraceExploreEntityPanel { get; set; }

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x06024633 RID: 149043
		// (set) Token: 0x06024634 RID: 149044
		Action<GreatSwordChallengeMarkItem> GreatSwordChallengePanel { get; set; }

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x06024635 RID: 149045
		// (set) Token: 0x06024636 RID: 149046
		Action<HonamiScanItemMarkItem> HonamiScanItemPanel { get; set; }

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x06024637 RID: 149047
		// (set) Token: 0x06024638 RID: 149048
		Action<HonamiScanMarkItem> HonamiScanMachinePanel { get; set; }

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x06024639 RID: 149049
		// (set) Token: 0x0602463A RID: 149050
		Action ActivityListPanel { get; set; }

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x0602463B RID: 149051
		// (set) Token: 0x0602463C RID: 149052
		Action<InfrObservatoryMarkItem> InfrObservatoryPanel { get; set; }

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x0602463D RID: 149053
		// (set) Token: 0x0602463E RID: 149054
		Action<InfrRoadMarkItem> InfrRoadPanel { get; set; }

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x0602463F RID: 149055
		// (set) Token: 0x06024640 RID: 149056
		Action<PhantomArenaNpcMarkItem> PhantomArenaNpcPanel { get; set; }

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x06024641 RID: 149057
		// (set) Token: 0x06024642 RID: 149058
		Action<TeleportMarkItem> WheelTowerEntrancePanel { get; set; }

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x06024643 RID: 149059
		// (set) Token: 0x06024644 RID: 149060
		Action<VillageInfrMarkItem> VillageInfrPanel { get; set; }

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x06024645 RID: 149061
		// (set) Token: 0x06024646 RID: 149062
		Action<VillageInfrTreeMarkItem> VillageInfrTreePanel { get; set; }

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x06024647 RID: 149063
		// (set) Token: 0x06024648 RID: 149064
		Action<int> SheriffCriminalPanel { get; set; }

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x06024649 RID: 149065
		// (set) Token: 0x0602464A RID: 149066
		Action<SheriffQuestMarkItem> SheriffQuestPanel { get; set; }

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x0602464B RID: 149067
		// (set) Token: 0x0602464C RID: 149068
		Action<DollGrabMachineMarkItem> DollGrabMachinePanel { get; set; }
	}
}
