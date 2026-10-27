using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel;
using CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200478A RID: 18314
	[NullableContext(1)]
	public interface ISecondaryUiType
	{
		// Token: 0x17007787 RID: 30599
		// (get) Token: 0x0602FE28 RID: 196136
		// (set) Token: 0x0602FE29 RID: 196137
		Action<CustomMarkItem, ECustomMarkPanelMode> CustomMarkPanel { get; set; }

		// Token: 0x17007788 RID: 30600
		// (get) Token: 0x0602FE2A RID: 196138
		// (set) Token: 0x0602FE2B RID: 196139
		Action<TeleportMarkItem> TeleportPanel { get; set; }

		// Token: 0x17007789 RID: 30601
		// (get) Token: 0x0602FE2C RID: 196140
		// (set) Token: 0x0602FE2D RID: 196141
		Action<ConfigMarkItem> GeneralPanel { get; set; }

		// Token: 0x1700778A RID: 30602
		// (get) Token: 0x0602FE2E RID: 196142
		// (set) Token: 0x0602FE2F RID: 196143
		Action<MarkItem[]> MarkMenuPanel { get; set; }

		// Token: 0x1700778B RID: 30603
		// (get) Token: 0x0602FE30 RID: 196144
		// (set) Token: 0x0602FE31 RID: 196145
		Action<TaskMarkItem> QuestPanel { get; set; }

		// Token: 0x1700778C RID: 30604
		// (get) Token: 0x0602FE32 RID: 196146
		// (set) Token: 0x0602FE33 RID: 196147
		Action<TeleportMarkItem> InstanceDungeonEntrancePanel { get; set; }

		// Token: 0x1700778D RID: 30605
		// (get) Token: 0x0602FE34 RID: 196148
		// (set) Token: 0x0602FE35 RID: 196149
		Action<SceneGameplayMarkItem> SceneGameplayPanel { get; set; }

		// Token: 0x1700778E RID: 30606
		// (get) Token: 0x0602FE36 RID: 196150
		// (set) Token: 0x0602FE37 RID: 196151
		Action<TeleportMarkItem> TowerEntrancePanel { get; set; }

		// Token: 0x1700778F RID: 30607
		// (get) Token: 0x0602FE38 RID: 196152
		// (set) Token: 0x0602FE39 RID: 196153
		Action<TeleportMarkItem> ShipTowerEntrancePanel { get; set; }

		// Token: 0x17007790 RID: 30608
		// (get) Token: 0x0602FE3A RID: 196154
		// (set) Token: 0x0602FE3B RID: 196155
		Action<ParkourMarkItem> ParkourPanel { get; set; }

		// Token: 0x17007791 RID: 30609
		// (get) Token: 0x0602FE3C RID: 196156
		// (set) Token: 0x0602FE3D RID: 196157
		Action<TemporaryTeleportMarkItem> TemporaryTeleportPanel { get; set; }

		// Token: 0x17007792 RID: 30610
		// (get) Token: 0x0602FE3E RID: 196158
		// (set) Token: 0x0602FE3F RID: 196159
		Action<TreasureBoxDetectorMarkItem> DetectorPanel { get; set; }

		// Token: 0x17007793 RID: 30611
		// (get) Token: 0x0602FE40 RID: 196160
		// (set) Token: 0x0602FE41 RID: 196161
		Action<IBoxMark> BoxPanel { get; set; }

		// Token: 0x17007794 RID: 30612
		// (get) Token: 0x0602FE42 RID: 196162
		// (set) Token: 0x0602FE43 RID: 196163
		Action<SceneGameplayMarkItem> LordGymPanel { get; set; }

		// Token: 0x17007795 RID: 30613
		// (get) Token: 0x0602FE44 RID: 196164
		// (set) Token: 0x0602FE45 RID: 196165
		Action<TeleportMarkItem> RoguelikePanel { get; set; }

		// Token: 0x17007796 RID: 30614
		// (get) Token: 0x0602FE46 RID: 196166
		// (set) Token: 0x0602FE47 RID: 196167
		Action<ConfigMarkItem> WeeklyRoguePanel { get; set; }

		// Token: 0x17007797 RID: 30615
		// (get) Token: 0x0602FE48 RID: 196168
		// (set) Token: 0x0602FE49 RID: 196169
		Action<ConfigMarkItem> RogueResPanel { get; set; }

		// Token: 0x17007798 RID: 30616
		// (get) Token: 0x0602FE4A RID: 196170
		// (set) Token: 0x0602FE4B RID: 196171
		Action<EnrichmentAreaItem> EnrichmentAreaPanel { get; set; }

		// Token: 0x17007799 RID: 30617
		// (get) Token: 0x0602FE4C RID: 196172
		// (set) Token: 0x0602FE4D RID: 196173
		Action<PunishReportMarkItem> PunishReportPanel { get; set; }

		// Token: 0x1700779A RID: 30618
		// (get) Token: 0x0602FE4E RID: 196174
		// (set) Token: 0x0602FE4F RID: 196175
		Action<CorniceMeetingMarkItem> CorniceMeetingPanel { get; set; }

		// Token: 0x1700779B RID: 30619
		// (get) Token: 0x0602FE50 RID: 196176
		// (set) Token: 0x0602FE51 RID: 196177
		Action<MarkItem[]> QuickNavigatePanel { get; set; }

		// Token: 0x1700779C RID: 30620
		// (get) Token: 0x0602FE52 RID: 196178
		// (set) Token: 0x0602FE53 RID: 196179
		Action<CaveHoleMarkItem> CaveHole { get; set; }

		// Token: 0x1700779D RID: 30621
		// (get) Token: 0x0602FE54 RID: 196180
		// (set) Token: 0x0602FE55 RID: 196181
		Action<ConfigMarkItem> CommonGamePlayPanel { get; set; }

		// Token: 0x1700779E RID: 30622
		// (get) Token: 0x0602FE56 RID: 196182
		// (set) Token: 0x0602FE57 RID: 196183
		Action<ITrackMenuItemData[]> TrackMenuPanel { get; set; }

		// Token: 0x1700779F RID: 30623
		// (get) Token: 0x0602FE58 RID: 196184
		// (set) Token: 0x0602FE59 RID: 196185
		Action<IMapNoteParams[]> WorldMapNotePanel { get; set; }

		// Token: 0x170077A0 RID: 30624
		// (get) Token: 0x0602FE5A RID: 196186
		// (set) Token: 0x0602FE5B RID: 196187
		Action MapMarkTogglePanel { get; set; }

		// Token: 0x170077A1 RID: 30625
		// (get) Token: 0x0602FE5C RID: 196188
		// (set) Token: 0x0602FE5D RID: 196189
		Action<TeleportMarkItem> MapTravelQuestPanel { get; set; }

		// Token: 0x170077A2 RID: 30626
		// (get) Token: 0x0602FE5E RID: 196190
		// (set) Token: 0x0602FE5F RID: 196191
		Action<FishingShipMarkItem> FishingShip { get; set; }

		// Token: 0x170077A3 RID: 30627
		// (get) Token: 0x0602FE60 RID: 196192
		// (set) Token: 0x0602FE61 RID: 196193
		Action<FishingPointMarkItem> FishingPoint { get; set; }

		// Token: 0x170077A4 RID: 30628
		// (get) Token: 0x0602FE62 RID: 196194
		// (set) Token: 0x0602FE63 RID: 196195
		Action<ConfigMarkItem> FishingCage { get; set; }

		// Token: 0x170077A5 RID: 30629
		// (get) Token: 0x0602FE64 RID: 196196
		// (set) Token: 0x0602FE65 RID: 196197
		Action<ConfigMarkItem> FishingDock { get; set; }

		// Token: 0x170077A6 RID: 30630
		// (get) Token: 0x0602FE66 RID: 196198
		// (set) Token: 0x0602FE67 RID: 196199
		Action<TraceExploreEntityMarkItem> TraceExploreEntityPanel { get; set; }

		// Token: 0x170077A7 RID: 30631
		// (get) Token: 0x0602FE68 RID: 196200
		// (set) Token: 0x0602FE69 RID: 196201
		Action<GreatSwordChallengeMarkItem> GreatSwordChallengePanel { get; set; }

		// Token: 0x170077A8 RID: 30632
		// (get) Token: 0x0602FE6A RID: 196202
		// (set) Token: 0x0602FE6B RID: 196203
		Action<HonamiScanItemMarkItem> HonamiScanItemPanel { get; set; }

		// Token: 0x170077A9 RID: 30633
		// (get) Token: 0x0602FE6C RID: 196204
		// (set) Token: 0x0602FE6D RID: 196205
		Action<HonamiScanMarkItem> HonamiScanMachinePanel { get; set; }

		// Token: 0x170077AA RID: 30634
		// (get) Token: 0x0602FE6E RID: 196206
		// (set) Token: 0x0602FE6F RID: 196207
		Action ActivityListPanel { get; set; }

		// Token: 0x170077AB RID: 30635
		// (get) Token: 0x0602FE70 RID: 196208
		// (set) Token: 0x0602FE71 RID: 196209
		Action<InfrObservatoryMarkItem> InfrObservatoryPanel { get; set; }

		// Token: 0x170077AC RID: 30636
		// (get) Token: 0x0602FE72 RID: 196210
		// (set) Token: 0x0602FE73 RID: 196211
		Action<InfrRoadMarkItem> InfrRoadPanel { get; set; }

		// Token: 0x170077AD RID: 30637
		// (get) Token: 0x0602FE74 RID: 196212
		// (set) Token: 0x0602FE75 RID: 196213
		Action<PhantomArenaNpcMarkItem> PhantomArenaNpcPanel { get; set; }

		// Token: 0x170077AE RID: 30638
		// (get) Token: 0x0602FE76 RID: 196214
		// (set) Token: 0x0602FE77 RID: 196215
		Action<TeleportMarkItem> WheelTowerEntrancePanel { get; set; }

		// Token: 0x170077AF RID: 30639
		// (get) Token: 0x0602FE78 RID: 196216
		// (set) Token: 0x0602FE79 RID: 196217
		Action<VillageInfrMarkItem> VillageInfrPanel { get; set; }

		// Token: 0x170077B0 RID: 30640
		// (get) Token: 0x0602FE7A RID: 196218
		// (set) Token: 0x0602FE7B RID: 196219
		Action<VillageInfrTreeMarkItem> VillageInfrTreePanel { get; set; }

		// Token: 0x170077B1 RID: 30641
		// (get) Token: 0x0602FE7C RID: 196220
		// (set) Token: 0x0602FE7D RID: 196221
		Action<int> SheriffCriminalPanel { get; set; }

		// Token: 0x170077B2 RID: 30642
		// (get) Token: 0x0602FE7E RID: 196222
		// (set) Token: 0x0602FE7F RID: 196223
		Action<SheriffQuestMarkItem> SheriffQuestPanel { get; set; }

		// Token: 0x170077B3 RID: 30643
		// (get) Token: 0x0602FE80 RID: 196224
		// (set) Token: 0x0602FE81 RID: 196225
		Action<DollGrabMachineMarkItem> DollGrabMachinePanel { get; set; }
	}
}
