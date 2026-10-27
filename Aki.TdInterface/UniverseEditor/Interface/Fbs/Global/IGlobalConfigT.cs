using System;

namespace Aki.UniverseEditor.Interface.Fbs.Global
{
	// Token: 0x020046DD RID: 18141
	public class IGlobalConfigT
	{
		// Token: 0x1700813C RID: 33084
		// (get) Token: 0x0601BB3D RID: 113469 RVA: 0x003EE245 File Offset: 0x003EC445
		// (set) Token: 0x0601BB3E RID: 113470 RVA: 0x003EE24D File Offset: 0x003EC44D
		public string ActionConfigPath { get; set; }

		// Token: 0x1700813D RID: 33085
		// (get) Token: 0x0601BB3F RID: 113471 RVA: 0x003EE256 File Offset: 0x003EC456
		// (set) Token: 0x0601BB40 RID: 113472 RVA: 0x003EE25E File Offset: 0x003EC45E
		public string ComponentConfigPath { get; set; }

		// Token: 0x1700813E RID: 33086
		// (get) Token: 0x0601BB41 RID: 113473 RVA: 0x003EE267 File Offset: 0x003EC467
		// (set) Token: 0x0601BB42 RID: 113474 RVA: 0x003EE26F File Offset: 0x003EC46F
		public string EntityConfigPath { get; set; }

		// Token: 0x1700813F RID: 33087
		// (get) Token: 0x0601BB43 RID: 113475 RVA: 0x003EE278 File Offset: 0x003EC478
		// (set) Token: 0x0601BB44 RID: 113476 RVA: 0x003EE280 File Offset: 0x003EC480
		public string BlueprintConfigPath { get; set; }

		// Token: 0x17008140 RID: 33088
		// (get) Token: 0x0601BB45 RID: 113477 RVA: 0x003EE289 File Offset: 0x003EC489
		// (set) Token: 0x0601BB46 RID: 113478 RVA: 0x003EE291 File Offset: 0x003EC491
		public string LevelsConfigPath { get; set; }

		// Token: 0x17008141 RID: 33089
		// (get) Token: 0x0601BB47 RID: 113479 RVA: 0x003EE29A File Offset: 0x003EC49A
		// (set) Token: 0x0601BB48 RID: 113480 RVA: 0x003EE2A2 File Offset: 0x003EC4A2
		public string SubWpMapConfigPath { get; set; }

		// Token: 0x17008142 RID: 33090
		// (get) Token: 0x0601BB49 RID: 113481 RVA: 0x003EE2AB File Offset: 0x003EC4AB
		// (set) Token: 0x0601BB4A RID: 113482 RVA: 0x003EE2B3 File Offset: 0x003EC4B3
		public string LevelsDir { get; set; }

		// Token: 0x17008143 RID: 33091
		// (get) Token: 0x0601BB4B RID: 113483 RVA: 0x003EE2BC File Offset: 0x003EC4BC
		// (set) Token: 0x0601BB4C RID: 113484 RVA: 0x003EE2C4 File Offset: 0x003EC4C4
		public string LevelsDataDir { get; set; }

		// Token: 0x17008144 RID: 33092
		// (get) Token: 0x0601BB4D RID: 113485 RVA: 0x003EE2CD File Offset: 0x003EC4CD
		// (set) Token: 0x0601BB4E RID: 113486 RVA: 0x003EE2D5 File Offset: 0x003EC4D5
		public string TemplateDir { get; set; }

		// Token: 0x17008145 RID: 33093
		// (get) Token: 0x0601BB4F RID: 113487 RVA: 0x003EE2DE File Offset: 0x003EC4DE
		// (set) Token: 0x0601BB50 RID: 113488 RVA: 0x003EE2E6 File Offset: 0x003EC4E6
		public string TemplateConfigPath { get; set; }

		// Token: 0x17008146 RID: 33094
		// (get) Token: 0x0601BB51 RID: 113489 RVA: 0x003EE2EF File Offset: 0x003EC4EF
		// (set) Token: 0x0601BB52 RID: 113490 RVA: 0x003EE2F7 File Offset: 0x003EC4F7
		public string EntityDataConfigPath { get; set; }

		// Token: 0x17008147 RID: 33095
		// (get) Token: 0x0601BB53 RID: 113491 RVA: 0x003EE300 File Offset: 0x003EC500
		// (set) Token: 0x0601BB54 RID: 113492 RVA: 0x003EE308 File Offset: 0x003EC508
		public string TypeScriptRoot { get; set; }

		// Token: 0x17008148 RID: 33096
		// (get) Token: 0x0601BB55 RID: 113493 RVA: 0x003EE311 File Offset: 0x003EC511
		// (set) Token: 0x0601BB56 RID: 113494 RVA: 0x003EE319 File Offset: 0x003EC519
		public string CsvFileDir { get; set; }

		// Token: 0x17008149 RID: 33097
		// (get) Token: 0x0601BB57 RID: 113495 RVA: 0x003EE322 File Offset: 0x003EC522
		// (set) Token: 0x0601BB58 RID: 113496 RVA: 0x003EE32A File Offset: 0x003EC52A
		public string FlowListDir { get; set; }

		// Token: 0x1700814A RID: 33098
		// (get) Token: 0x0601BB59 RID: 113497 RVA: 0x003EE333 File Offset: 0x003EC533
		// (set) Token: 0x0601BB5A RID: 113498 RVA: 0x003EE33B File Offset: 0x003EC53B
		public string QuestListDir { get; set; }

		// Token: 0x1700814B RID: 33099
		// (get) Token: 0x0601BB5B RID: 113499 RVA: 0x003EE344 File Offset: 0x003EC544
		// (set) Token: 0x0601BB5C RID: 113500 RVA: 0x003EE34C File Offset: 0x003EC54C
		public string QuestListExportDir { get; set; }

		// Token: 0x1700814C RID: 33100
		// (get) Token: 0x0601BB5D RID: 113501 RVA: 0x003EE355 File Offset: 0x003EC555
		// (set) Token: 0x0601BB5E RID: 113502 RVA: 0x003EE35D File Offset: 0x003EC55D
		public string EntityStateConfigPath { get; set; }

		// Token: 0x1700814D RID: 33101
		// (get) Token: 0x0601BB5F RID: 113503 RVA: 0x003EE366 File Offset: 0x003EC566
		// (set) Token: 0x0601BB60 RID: 113504 RVA: 0x003EE36E File Offset: 0x003EC56E
		public string EntityOwnerConfigPath { get; set; }

		// Token: 0x1700814E RID: 33102
		// (get) Token: 0x0601BB61 RID: 113505 RVA: 0x003EE377 File Offset: 0x003EC577
		// (set) Token: 0x0601BB62 RID: 113506 RVA: 0x003EE37F File Offset: 0x003EC57F
		public string ChildEntityOwnerConfigPath { get; set; }

		// Token: 0x1700814F RID: 33103
		// (get) Token: 0x0601BB63 RID: 113507 RVA: 0x003EE388 File Offset: 0x003EC588
		// (set) Token: 0x0601BB64 RID: 113508 RVA: 0x003EE390 File Offset: 0x003EC590
		public string AlwaysLoadEntityConfigPath { get; set; }

		// Token: 0x17008150 RID: 33104
		// (get) Token: 0x0601BB65 RID: 113509 RVA: 0x003EE399 File Offset: 0x003EC599
		// (set) Token: 0x0601BB66 RID: 113510 RVA: 0x003EE3A1 File Offset: 0x003EC5A1
		public string LevelPlayListDir { get; set; }

		// Token: 0x17008151 RID: 33105
		// (get) Token: 0x0601BB67 RID: 113511 RVA: 0x003EE3AA File Offset: 0x003EC5AA
		// (set) Token: 0x0601BB68 RID: 113512 RVA: 0x003EE3B2 File Offset: 0x003EC5B2
		public string LevelPlayListExportDir { get; set; }

		// Token: 0x17008152 RID: 33106
		// (get) Token: 0x0601BB69 RID: 113513 RVA: 0x003EE3BB File Offset: 0x003EC5BB
		// (set) Token: 0x0601BB6A RID: 113514 RVA: 0x003EE3C3 File Offset: 0x003EC5C3
		public string DynamicLevelPlayListExportDir { get; set; }

		// Token: 0x17008153 RID: 33107
		// (get) Token: 0x0601BB6B RID: 113515 RVA: 0x003EE3CC File Offset: 0x003EC5CC
		// (set) Token: 0x0601BB6C RID: 113516 RVA: 0x003EE3D4 File Offset: 0x003EC5D4
		public string TwoDimensionLevelListDir { get; set; }

		// Token: 0x17008154 RID: 33108
		// (get) Token: 0x0601BB6D RID: 113517 RVA: 0x003EE3DD File Offset: 0x003EC5DD
		// (set) Token: 0x0601BB6E RID: 113518 RVA: 0x003EE3E5 File Offset: 0x003EC5E5
		public string DangoBrawlObjectTemplateDir { get; set; }

		// Token: 0x17008155 RID: 33109
		// (get) Token: 0x0601BB6F RID: 113519 RVA: 0x003EE3EE File Offset: 0x003EC5EE
		// (set) Token: 0x0601BB70 RID: 113520 RVA: 0x003EE3F6 File Offset: 0x003EC5F6
		public string MarbleLevelConfigPath { get; set; }

		// Token: 0x17008156 RID: 33110
		// (get) Token: 0x0601BB71 RID: 113521 RVA: 0x003EE3FF File Offset: 0x003EC5FF
		// (set) Token: 0x0601BB72 RID: 113522 RVA: 0x003EE407 File Offset: 0x003EC607
		public string DangoBrawlLevelConfigPath { get; set; }

		// Token: 0x17008157 RID: 33111
		// (get) Token: 0x0601BB73 RID: 113523 RVA: 0x003EE410 File Offset: 0x003EC610
		// (set) Token: 0x0601BB74 RID: 113524 RVA: 0x003EE418 File Offset: 0x003EC618
		public string DangoBrawlObjectTemplateConfigPath { get; set; }

		// Token: 0x17008158 RID: 33112
		// (get) Token: 0x0601BB75 RID: 113525 RVA: 0x003EE421 File Offset: 0x003EC621
		// (set) Token: 0x0601BB76 RID: 113526 RVA: 0x003EE429 File Offset: 0x003EC629
		public string FunctionalTestDir { get; set; }

		// Token: 0x17008159 RID: 33113
		// (get) Token: 0x0601BB77 RID: 113527 RVA: 0x003EE432 File Offset: 0x003EC632
		// (set) Token: 0x0601BB78 RID: 113528 RVA: 0x003EE43A File Offset: 0x003EC63A
		public string FlowTemplateConfigPath { get; set; }

		// Token: 0x1700815A RID: 33114
		// (get) Token: 0x0601BB79 RID: 113529 RVA: 0x003EE443 File Offset: 0x003EC643
		// (set) Token: 0x0601BB7A RID: 113530 RVA: 0x003EE44B File Offset: 0x003EC64B
		public string FlowTemplateCameraDir { get; set; }

		// Token: 0x1700815B RID: 33115
		// (get) Token: 0x0601BB7B RID: 113531 RVA: 0x003EE454 File Offset: 0x003EC654
		// (set) Token: 0x0601BB7C RID: 113532 RVA: 0x003EE45C File Offset: 0x003EC65C
		public string FlowTemplateCameraConfigPath { get; set; }

		// Token: 0x1700815C RID: 33116
		// (get) Token: 0x0601BB7D RID: 113533 RVA: 0x003EE465 File Offset: 0x003EC665
		// (set) Token: 0x0601BB7E RID: 113534 RVA: 0x003EE46D File Offset: 0x003EC66D
		public string FlowTemplateCameraConfgSourcePath { get; set; }

		// Token: 0x1700815D RID: 33117
		// (get) Token: 0x0601BB7F RID: 113535 RVA: 0x003EE476 File Offset: 0x003EC676
		// (set) Token: 0x0601BB80 RID: 113536 RVA: 0x003EE47E File Offset: 0x003EC67E
		public string GlobalVarConfigPath { get; set; }

		// Token: 0x1700815E RID: 33118
		// (get) Token: 0x0601BB81 RID: 113537 RVA: 0x003EE487 File Offset: 0x003EC687
		// (set) Token: 0x0601BB82 RID: 113538 RVA: 0x003EE48F File Offset: 0x003EC68F
		public string SystemVarConfigPath { get; set; }

		// Token: 0x1700815F RID: 33119
		// (get) Token: 0x0601BB83 RID: 113539 RVA: 0x003EE498 File Offset: 0x003EC698
		// (set) Token: 0x0601BB84 RID: 113540 RVA: 0x003EE4A0 File Offset: 0x003EC6A0
		public string VehicleRidingRolesConfigPath { get; set; }

		// Token: 0x17008160 RID: 33120
		// (get) Token: 0x0601BB85 RID: 113541 RVA: 0x003EE4A9 File Offset: 0x003EC6A9
		// (set) Token: 0x0601BB86 RID: 113542 RVA: 0x003EE4B1 File Offset: 0x003EC6B1
		public string OccupationConfigPath { get; set; }

		// Token: 0x17008161 RID: 33121
		// (get) Token: 0x0601BB87 RID: 113543 RVA: 0x003EE4BA File Offset: 0x003EC6BA
		// (set) Token: 0x0601BB88 RID: 113544 RVA: 0x003EE4C2 File Offset: 0x003EC6C2
		public string OccupiedExportPath { get; set; }

		// Token: 0x17008162 RID: 33122
		// (get) Token: 0x0601BB89 RID: 113545 RVA: 0x003EE4CB File Offset: 0x003EC6CB
		// (set) Token: 0x0601BB8A RID: 113546 RVA: 0x003EE4D3 File Offset: 0x003EC6D3
		public string InteractOptionConfigPath { get; set; }

		// Token: 0x17008163 RID: 33123
		// (get) Token: 0x0601BB8B RID: 113547 RVA: 0x003EE4DC File Offset: 0x003EC6DC
		// (set) Token: 0x0601BB8C RID: 113548 RVA: 0x003EE4E4 File Offset: 0x003EC6E4
		public string AreaEntitiesPath { get; set; }

		// Token: 0x17008164 RID: 33124
		// (get) Token: 0x0601BB8D RID: 113549 RVA: 0x003EE4ED File Offset: 0x003EC6ED
		// (set) Token: 0x0601BB8E RID: 113550 RVA: 0x003EE4F5 File Offset: 0x003EC6F5
		public string BtConfigPath { get; set; }

		// Token: 0x17008165 RID: 33125
		// (get) Token: 0x0601BB8F RID: 113551 RVA: 0x003EE4FE File Offset: 0x003EC6FE
		// (set) Token: 0x0601BB90 RID: 113552 RVA: 0x003EE506 File Offset: 0x003EC706
		public string MontageConfigPath { get; set; }

		// Token: 0x17008166 RID: 33126
		// (get) Token: 0x0601BB91 RID: 113553 RVA: 0x003EE50F File Offset: 0x003EC70F
		// (set) Token: 0x0601BB92 RID: 113554 RVA: 0x003EE517 File Offset: 0x003EC717
		public string AbpMontageConfigPath { get; set; }

		// Token: 0x17008167 RID: 33127
		// (get) Token: 0x0601BB93 RID: 113555 RVA: 0x003EE520 File Offset: 0x003EC720
		// (set) Token: 0x0601BB94 RID: 113556 RVA: 0x003EE528 File Offset: 0x003EC728
		public string AbpOverlayMontageConfigPath { get; set; }

		// Token: 0x17008168 RID: 33128
		// (get) Token: 0x0601BB95 RID: 113557 RVA: 0x003EE531 File Offset: 0x003EC731
		// (set) Token: 0x0601BB96 RID: 113558 RVA: 0x003EE539 File Offset: 0x003EC739
		public string AbpStateConfigPath { get; set; }

		// Token: 0x17008169 RID: 33129
		// (get) Token: 0x0601BB97 RID: 113559 RVA: 0x003EE542 File Offset: 0x003EC742
		// (set) Token: 0x0601BB98 RID: 113560 RVA: 0x003EE54A File Offset: 0x003EC74A
		public string FaceExpressionConfigPath { get; set; }

		// Token: 0x1700816A RID: 33130
		// (get) Token: 0x0601BB99 RID: 113561 RVA: 0x003EE553 File Offset: 0x003EC753
		// (set) Token: 0x0601BB9A RID: 113562 RVA: 0x003EE55B File Offset: 0x003EC75B
		public string AoiGroupPath { get; set; }

		// Token: 0x1700816B RID: 33131
		// (get) Token: 0x0601BB9B RID: 113563 RVA: 0x003EE564 File Offset: 0x003EC764
		// (set) Token: 0x0601BB9C RID: 113564 RVA: 0x003EE56C File Offset: 0x003EC76C
		public string EntityPerformanceDataPath { get; set; }

		// Token: 0x1700816C RID: 33132
		// (get) Token: 0x0601BB9D RID: 113565 RVA: 0x003EE575 File Offset: 0x003EC775
		// (set) Token: 0x0601BB9E RID: 113566 RVA: 0x003EE57D File Offset: 0x003EC77D
		public string ActorRefConfigPath { get; set; }

		// Token: 0x1700816D RID: 33133
		// (get) Token: 0x0601BB9F RID: 113567 RVA: 0x003EE586 File Offset: 0x003EC786
		// (set) Token: 0x0601BBA0 RID: 113568 RVA: 0x003EE58E File Offset: 0x003EC78E
		public string AoiDefineDataPath { get; set; }

		// Token: 0x1700816E RID: 33134
		// (get) Token: 0x0601BBA1 RID: 113569 RVA: 0x003EE597 File Offset: 0x003EC797
		// (set) Token: 0x0601BBA2 RID: 113570 RVA: 0x003EE59F File Offset: 0x003EC79F
		public string PrefabDir { get; set; }

		// Token: 0x1700816F RID: 33135
		// (get) Token: 0x0601BBA3 RID: 113571 RVA: 0x003EE5A8 File Offset: 0x003EC7A8
		// (set) Token: 0x0601BBA4 RID: 113572 RVA: 0x003EE5B0 File Offset: 0x003EC7B0
		public string BundleDir { get; set; }

		// Token: 0x17008170 RID: 33136
		// (get) Token: 0x0601BBA5 RID: 113573 RVA: 0x003EE5B9 File Offset: 0x003EC7B9
		// (set) Token: 0x0601BBA6 RID: 113574 RVA: 0x003EE5C1 File Offset: 0x003EC7C1
		public string PrefabConfigPath { get; set; }

		// Token: 0x17008171 RID: 33137
		// (get) Token: 0x0601BBA7 RID: 113575 RVA: 0x003EE5CA File Offset: 0x003EC7CA
		// (set) Token: 0x0601BBA8 RID: 113576 RVA: 0x003EE5D2 File Offset: 0x003EC7D2
		public string EditorStartConfig { get; set; }

		// Token: 0x17008172 RID: 33138
		// (get) Token: 0x0601BBA9 RID: 113577 RVA: 0x003EE5DB File Offset: 0x003EC7DB
		// (set) Token: 0x0601BBAA RID: 113578 RVA: 0x003EE5E3 File Offset: 0x003EC7E3
		public string BubbleConfigPath { get; set; }

		// Token: 0x17008173 RID: 33139
		// (get) Token: 0x0601BBAB RID: 113579 RVA: 0x003EE5EC File Offset: 0x003EC7EC
		// (set) Token: 0x0601BBAC RID: 113580 RVA: 0x003EE5F4 File Offset: 0x003EC7F4
		public string LevelEntityVoxelPath { get; set; }

		// Token: 0x17008174 RID: 33140
		// (get) Token: 0x0601BBAD RID: 113581 RVA: 0x003EE5FD File Offset: 0x003EC7FD
		// (set) Token: 0x0601BBAE RID: 113582 RVA: 0x003EE605 File Offset: 0x003EC805
		public string TidTextTempPath { get; set; }

		// Token: 0x17008175 RID: 33141
		// (get) Token: 0x0601BBAF RID: 113583 RVA: 0x003EE60E File Offset: 0x003EC80E
		// (set) Token: 0x0601BBB0 RID: 113584 RVA: 0x003EE616 File Offset: 0x003EC816
		public string AudioStatePath { get; set; }

		// Token: 0x17008176 RID: 33142
		// (get) Token: 0x0601BBB1 RID: 113585 RVA: 0x003EE61F File Offset: 0x003EC81F
		// (set) Token: 0x0601BBB2 RID: 113586 RVA: 0x003EE627 File Offset: 0x003EC827
		public string PlotHandBookPath { get; set; }

		// Token: 0x17008177 RID: 33143
		// (get) Token: 0x0601BBB3 RID: 113587 RVA: 0x003EE630 File Offset: 0x003EC830
		// (set) Token: 0x0601BBB4 RID: 113588 RVA: 0x003EE638 File Offset: 0x003EC838
		public string PlotPositionPath { get; set; }

		// Token: 0x17008178 RID: 33144
		// (get) Token: 0x0601BBB5 RID: 113589 RVA: 0x003EE641 File Offset: 0x003EC841
		// (set) Token: 0x0601BBB6 RID: 113590 RVA: 0x003EE649 File Offset: 0x003EC849
		public string TextLibraryDir { get; set; }

		// Token: 0x17008179 RID: 33145
		// (get) Token: 0x0601BBB7 RID: 113591 RVA: 0x003EE652 File Offset: 0x003EC852
		// (set) Token: 0x0601BBB8 RID: 113592 RVA: 0x003EE65A File Offset: 0x003EC85A
		public string EnrichmentArea { get; set; }

		// Token: 0x1700817A RID: 33146
		// (get) Token: 0x0601BBB9 RID: 113593 RVA: 0x003EE663 File Offset: 0x003EC863
		// (set) Token: 0x0601BBBA RID: 113594 RVA: 0x003EE66B File Offset: 0x003EC86B
		public string MarkedErrorCsvPath { get; set; }

		// Token: 0x1700817B RID: 33147
		// (get) Token: 0x0601BBBB RID: 113595 RVA: 0x003EE674 File Offset: 0x003EC874
		// (set) Token: 0x0601BBBC RID: 113596 RVA: 0x003EE67C File Offset: 0x003EC87C
		public string BrokenRockConfig { get; set; }

		// Token: 0x1700817C RID: 33148
		// (get) Token: 0x0601BBBD RID: 113597 RVA: 0x003EE685 File Offset: 0x003EC885
		// (set) Token: 0x0601BBBE RID: 113598 RVA: 0x003EE68D File Offset: 0x003EC88D
		public string GridItemShapeConfigPath { get; set; }

		// Token: 0x1700817D RID: 33149
		// (get) Token: 0x0601BBBF RID: 113599 RVA: 0x003EE696 File Offset: 0x003EC896
		// (set) Token: 0x0601BBC0 RID: 113600 RVA: 0x003EE69E File Offset: 0x003EC89E
		public string FishingRouletteConfig { get; set; }

		// Token: 0x1700817E RID: 33150
		// (get) Token: 0x0601BBC1 RID: 113601 RVA: 0x003EE6A7 File Offset: 0x003EC8A7
		// (set) Token: 0x0601BBC2 RID: 113602 RVA: 0x003EE6AF File Offset: 0x003EC8AF
		public string AreaQuestTracking { get; set; }

		// Token: 0x1700817F RID: 33151
		// (get) Token: 0x0601BBC3 RID: 113603 RVA: 0x003EE6B8 File Offset: 0x003EC8B8
		// (set) Token: 0x0601BBC4 RID: 113604 RVA: 0x003EE6C0 File Offset: 0x003EC8C0
		public string OfflineComponentExportPath { get; set; }

		// Token: 0x17008180 RID: 33152
		// (get) Token: 0x0601BBC5 RID: 113605 RVA: 0x003EE6C9 File Offset: 0x003EC8C9
		// (set) Token: 0x0601BBC6 RID: 113606 RVA: 0x003EE6D1 File Offset: 0x003EC8D1
		public string SummonGongduolaConfigExportPath { get; set; }

		// Token: 0x17008181 RID: 33153
		// (get) Token: 0x0601BBC7 RID: 113607 RVA: 0x003EE6DA File Offset: 0x003EC8DA
		// (set) Token: 0x0601BBC8 RID: 113608 RVA: 0x003EE6E2 File Offset: 0x003EC8E2
		public string HideGroupFixConfigPath { get; set; }

		// Token: 0x17008182 RID: 33154
		// (get) Token: 0x0601BBC9 RID: 113609 RVA: 0x003EE6EB File Offset: 0x003EC8EB
		// (set) Token: 0x0601BBCA RID: 113610 RVA: 0x003EE6F3 File Offset: 0x003EC8F3
		public string EntityFixProcessorPath { get; set; }

		// Token: 0x17008183 RID: 33155
		// (get) Token: 0x0601BBCB RID: 113611 RVA: 0x003EE6FC File Offset: 0x003EC8FC
		// (set) Token: 0x0601BBCC RID: 113612 RVA: 0x003EE704 File Offset: 0x003EC904
		public string GravityAbnormalEntityListPath { get; set; }

		// Token: 0x17008184 RID: 33156
		// (get) Token: 0x0601BBCD RID: 113613 RVA: 0x003EE70D File Offset: 0x003EC90D
		// (set) Token: 0x0601BBCE RID: 113614 RVA: 0x003EE715 File Offset: 0x003EC915
		public string ActorRefComponentsConfigPath { get; set; }

		// Token: 0x17008185 RID: 33157
		// (get) Token: 0x0601BBCF RID: 113615 RVA: 0x003EE71E File Offset: 0x003EC91E
		// (set) Token: 0x0601BBD0 RID: 113616 RVA: 0x003EE726 File Offset: 0x003EC926
		public string SeqRefComponentsConfigPath { get; set; }

		// Token: 0x17008186 RID: 33158
		// (get) Token: 0x0601BBD1 RID: 113617 RVA: 0x003EE72F File Offset: 0x003EC92F
		// (set) Token: 0x0601BBD2 RID: 113618 RVA: 0x003EE737 File Offset: 0x003EC937
		public string QuestRefMp4Path { get; set; }

		// Token: 0x17008187 RID: 33159
		// (get) Token: 0x0601BBD3 RID: 113619 RVA: 0x003EE740 File Offset: 0x003EC940
		// (set) Token: 0x0601BBD4 RID: 113620 RVA: 0x003EE748 File Offset: 0x003EC948
		public string BehaviorTreeFragmentDir { get; set; }

		// Token: 0x17008188 RID: 33160
		// (get) Token: 0x0601BBD5 RID: 113621 RVA: 0x003EE751 File Offset: 0x003EC951
		// (set) Token: 0x0601BBD6 RID: 113622 RVA: 0x003EE759 File Offset: 0x003EC959
		public string CommonBtDir { get; set; }

		// Token: 0x17008189 RID: 33161
		// (get) Token: 0x0601BBD7 RID: 113623 RVA: 0x003EE762 File Offset: 0x003EC962
		// (set) Token: 0x0601BBD8 RID: 113624 RVA: 0x003EE76A File Offset: 0x003EC96A
		public string CommonBtExportDir { get; set; }

		// Token: 0x1700818A RID: 33162
		// (get) Token: 0x0601BBD9 RID: 113625 RVA: 0x003EE773 File Offset: 0x003EC973
		// (set) Token: 0x0601BBDA RID: 113626 RVA: 0x003EE77B File Offset: 0x003EC97B
		public string LevelBuildingGrids { get; set; }

		// Token: 0x1700818B RID: 33163
		// (get) Token: 0x0601BBDB RID: 113627 RVA: 0x003EE784 File Offset: 0x003EC984
		// (set) Token: 0x0601BBDC RID: 113628 RVA: 0x003EE78C File Offset: 0x003EC98C
		public string GlobalFixConfigPath { get; set; }

		// Token: 0x1700818C RID: 33164
		// (get) Token: 0x0601BBDD RID: 113629 RVA: 0x003EE795 File Offset: 0x003EC995
		// (set) Token: 0x0601BBDE RID: 113630 RVA: 0x003EE79D File Offset: 0x003EC99D
		public string AreaFunctionConfigPath { get; set; }

		// Token: 0x1700818D RID: 33165
		// (get) Token: 0x0601BBDF RID: 113631 RVA: 0x003EE7A6 File Offset: 0x003EC9A6
		// (set) Token: 0x0601BBE0 RID: 113632 RVA: 0x003EE7AE File Offset: 0x003EC9AE
		public string DynamicSpawnMonsterRandomPoolConfigPath { get; set; }

		// Token: 0x1700818E RID: 33166
		// (get) Token: 0x0601BBE1 RID: 113633 RVA: 0x003EE7B7 File Offset: 0x003EC9B7
		// (set) Token: 0x0601BBE2 RID: 113634 RVA: 0x003EE7BF File Offset: 0x003EC9BF
		public string EntityCustomPrimitiveData { get; set; }

		// Token: 0x1700818F RID: 33167
		// (get) Token: 0x0601BBE3 RID: 113635 RVA: 0x003EE7C8 File Offset: 0x003EC9C8
		// (set) Token: 0x0601BBE4 RID: 113636 RVA: 0x003EE7D0 File Offset: 0x003EC9D0
		public string AnimalStandbyTagPath { get; set; }

		// Token: 0x17008190 RID: 33168
		// (get) Token: 0x0601BBE5 RID: 113637 RVA: 0x003EE7D9 File Offset: 0x003EC9D9
		// (set) Token: 0x0601BBE6 RID: 113638 RVA: 0x003EE7E1 File Offset: 0x003EC9E1
		public string AnsPerformDataPath { get; set; }

		// Token: 0x17008191 RID: 33169
		// (get) Token: 0x0601BBE7 RID: 113639 RVA: 0x003EE7EA File Offset: 0x003EC9EA
		// (set) Token: 0x0601BBE8 RID: 113640 RVA: 0x003EE7F2 File Offset: 0x003EC9F2
		public string RoadZonePath { get; set; }

		// Token: 0x17008192 RID: 33170
		// (get) Token: 0x0601BBE9 RID: 113641 RVA: 0x003EE7FB File Offset: 0x003EC9FB
		// (set) Token: 0x0601BBEA RID: 113642 RVA: 0x003EE803 File Offset: 0x003ECA03
		public string UltraLeaveRadiusLevelPlayPath { get; set; }

		// Token: 0x17008193 RID: 33171
		// (get) Token: 0x0601BBEB RID: 113643 RVA: 0x003EE80C File Offset: 0x003ECA0C
		// (set) Token: 0x0601BBEC RID: 113644 RVA: 0x003EE814 File Offset: 0x003ECA14
		public string AreaTeleportPath { get; set; }

		// Token: 0x17008194 RID: 33172
		// (get) Token: 0x0601BBED RID: 113645 RVA: 0x003EE81D File Offset: 0x003ECA1D
		// (set) Token: 0x0601BBEE RID: 113646 RVA: 0x003EE825 File Offset: 0x003ECA25
		public string SeqAreaPath { get; set; }

		// Token: 0x17008195 RID: 33173
		// (get) Token: 0x0601BBEF RID: 113647 RVA: 0x003EE82E File Offset: 0x003ECA2E
		// (set) Token: 0x0601BBF0 RID: 113648 RVA: 0x003EE836 File Offset: 0x003ECA36
		public string DungeonAreaOwnerDataPath { get; set; }

		// Token: 0x17008196 RID: 33174
		// (get) Token: 0x0601BBF1 RID: 113649 RVA: 0x003EE83F File Offset: 0x003ECA3F
		// (set) Token: 0x0601BBF2 RID: 113650 RVA: 0x003EE847 File Offset: 0x003ECA47
		public string DungeonAreaReachableDataPath { get; set; }

		// Token: 0x17008197 RID: 33175
		// (get) Token: 0x0601BBF3 RID: 113651 RVA: 0x003EE850 File Offset: 0x003ECA50
		// (set) Token: 0x0601BBF4 RID: 113652 RVA: 0x003EE858 File Offset: 0x003ECA58
		public string TimeSchedulePath { get; set; }

		// Token: 0x17008198 RID: 33176
		// (get) Token: 0x0601BBF5 RID: 113653 RVA: 0x003EE861 File Offset: 0x003ECA61
		// (set) Token: 0x0601BBF6 RID: 113654 RVA: 0x003EE869 File Offset: 0x003ECA69
		public string AiBehaviorTreePath { get; set; }

		// Token: 0x17008199 RID: 33177
		// (get) Token: 0x0601BBF7 RID: 113655 RVA: 0x003EE872 File Offset: 0x003ECA72
		// (set) Token: 0x0601BBF8 RID: 113656 RVA: 0x003EE87A File Offset: 0x003ECA7A
		public string RecallDataConfigPath { get; set; }

		// Token: 0x1700819A RID: 33178
		// (get) Token: 0x0601BBF9 RID: 113657 RVA: 0x003EE883 File Offset: 0x003ECA83
		// (set) Token: 0x0601BBFA RID: 113658 RVA: 0x003EE88B File Offset: 0x003ECA8B
		public string CombatOperationCaptureDir { get; set; }

		// Token: 0x1700819B RID: 33179
		// (get) Token: 0x0601BBFB RID: 113659 RVA: 0x003EE894 File Offset: 0x003ECA94
		// (set) Token: 0x0601BBFC RID: 113660 RVA: 0x003EE89C File Offset: 0x003ECA9C
		public string RecallEntityConfigPath { get; set; }

		// Token: 0x0601BBFD RID: 113661 RVA: 0x003EE8A8 File Offset: 0x003ECAA8
		public IGlobalConfigT()
		{
			this.ActionConfigPath = null;
			this.ComponentConfigPath = null;
			this.EntityConfigPath = null;
			this.BlueprintConfigPath = null;
			this.LevelsConfigPath = null;
			this.SubWpMapConfigPath = null;
			this.LevelsDir = null;
			this.LevelsDataDir = null;
			this.TemplateDir = null;
			this.TemplateConfigPath = null;
			this.EntityDataConfigPath = null;
			this.TypeScriptRoot = null;
			this.CsvFileDir = null;
			this.FlowListDir = null;
			this.QuestListDir = null;
			this.QuestListExportDir = null;
			this.EntityStateConfigPath = null;
			this.EntityOwnerConfigPath = null;
			this.ChildEntityOwnerConfigPath = null;
			this.AlwaysLoadEntityConfigPath = null;
			this.LevelPlayListDir = null;
			this.LevelPlayListExportDir = null;
			this.DynamicLevelPlayListExportDir = null;
			this.TwoDimensionLevelListDir = null;
			this.DangoBrawlObjectTemplateDir = null;
			this.MarbleLevelConfigPath = null;
			this.DangoBrawlLevelConfigPath = null;
			this.DangoBrawlObjectTemplateConfigPath = null;
			this.FunctionalTestDir = null;
			this.FlowTemplateConfigPath = null;
			this.FlowTemplateCameraDir = null;
			this.FlowTemplateCameraConfigPath = null;
			this.FlowTemplateCameraConfgSourcePath = null;
			this.GlobalVarConfigPath = null;
			this.SystemVarConfigPath = null;
			this.VehicleRidingRolesConfigPath = null;
			this.OccupationConfigPath = null;
			this.OccupiedExportPath = null;
			this.InteractOptionConfigPath = null;
			this.AreaEntitiesPath = null;
			this.BtConfigPath = null;
			this.MontageConfigPath = null;
			this.AbpMontageConfigPath = null;
			this.AbpOverlayMontageConfigPath = null;
			this.AbpStateConfigPath = null;
			this.FaceExpressionConfigPath = null;
			this.AoiGroupPath = null;
			this.EntityPerformanceDataPath = null;
			this.ActorRefConfigPath = null;
			this.AoiDefineDataPath = null;
			this.PrefabDir = null;
			this.BundleDir = null;
			this.PrefabConfigPath = null;
			this.EditorStartConfig = null;
			this.BubbleConfigPath = null;
			this.LevelEntityVoxelPath = null;
			this.TidTextTempPath = null;
			this.AudioStatePath = null;
			this.PlotHandBookPath = null;
			this.PlotPositionPath = null;
			this.TextLibraryDir = null;
			this.EnrichmentArea = null;
			this.MarkedErrorCsvPath = null;
			this.BrokenRockConfig = null;
			this.GridItemShapeConfigPath = null;
			this.FishingRouletteConfig = null;
			this.AreaQuestTracking = null;
			this.OfflineComponentExportPath = null;
			this.SummonGongduolaConfigExportPath = null;
			this.HideGroupFixConfigPath = null;
			this.EntityFixProcessorPath = null;
			this.GravityAbnormalEntityListPath = null;
			this.ActorRefComponentsConfigPath = null;
			this.SeqRefComponentsConfigPath = null;
			this.QuestRefMp4Path = null;
			this.BehaviorTreeFragmentDir = null;
			this.CommonBtDir = null;
			this.CommonBtExportDir = null;
			this.LevelBuildingGrids = null;
			this.GlobalFixConfigPath = null;
			this.AreaFunctionConfigPath = null;
			this.DynamicSpawnMonsterRandomPoolConfigPath = null;
			this.EntityCustomPrimitiveData = null;
			this.AnimalStandbyTagPath = null;
			this.AnsPerformDataPath = null;
			this.RoadZonePath = null;
			this.UltraLeaveRadiusLevelPlayPath = null;
			this.AreaTeleportPath = null;
			this.SeqAreaPath = null;
			this.DungeonAreaOwnerDataPath = null;
			this.DungeonAreaReachableDataPath = null;
			this.TimeSchedulePath = null;
			this.AiBehaviorTreePath = null;
			this.RecallDataConfigPath = null;
			this.CombatOperationCaptureDir = null;
			this.RecallEntityConfigPath = null;
		}
	}
}
