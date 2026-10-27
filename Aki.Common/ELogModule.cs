using System;
using CSharpScript.Core.Common;

// Token: 0x02000008 RID: 8
[EnumExtensions]
public enum ELogModule
{
	// Token: 0x040000AD RID: 173
	Engine,
	// Token: 0x040000AE RID: 174
	UiEditor,
	// Token: 0x040000AF RID: 175
	ResourceCheck,
	// Token: 0x040000B0 RID: 176
	IllegalCodeCheck,
	// Token: 0x040000B1 RID: 177
	Temp,
	// Token: 0x040000B2 RID: 178
	HotPatch,
	// Token: 0x040000B3 RID: 179
	Log,
	// Token: 0x040000B4 RID: 180
	ExportProto,
	// Token: 0x040000B5 RID: 181
	Core,
	// Token: 0x040000B6 RID: 182
	Entity,
	// Token: 0x040000B7 RID: 183
	Event,
	// Token: 0x040000B8 RID: 184
	Json,
	// Token: 0x040000B9 RID: 185
	P4,
	// Token: 0x040000BA RID: 186
	Config,
	// Token: 0x040000BB RID: 187
	CommonDbConnect,
	// Token: 0x040000BC RID: 188
	Pool,
	// Token: 0x040000BD RID: 189
	Container,
	// Token: 0x040000BE RID: 190
	UiCore,
	// Token: 0x040000BF RID: 191
	Net,
	// Token: 0x040000C0 RID: 192
	Object,
	// Token: 0x040000C1 RID: 193
	Resource,
	// Token: 0x040000C2 RID: 194
	Tick,
	// Token: 0x040000C3 RID: 195
	Timer,
	// Token: 0x040000C4 RID: 196
	Game,
	// Token: 0x040000C5 RID: 197
	Render,
	// Token: 0x040000C6 RID: 198
	Preload,
	// Token: 0x040000C7 RID: 199
	StateMachine,
	// Token: 0x040000C8 RID: 200
	BehaviorTree,
	// Token: 0x040000C9 RID: 201
	Camera,
	// Token: 0x040000CA RID: 202
	Character,
	// Token: 0x040000CB RID: 203
	TextUtil,
	// Token: 0x040000CC RID: 204
	Input,
	// Token: 0x040000CD RID: 205
	InputSettings,
	// Token: 0x040000CE RID: 206
	Level,
	// Token: 0x040000CF RID: 207
	Audio,
	// Token: 0x040000D0 RID: 208
	Battle,
	// Token: 0x040000D1 RID: 209
	UiModel,
	// Token: 0x040000D2 RID: 210
	UiModelMorph,
	// Token: 0x040000D3 RID: 211
	BpBridge,
	// Token: 0x040000D4 RID: 212
	TaskGraph,
	// Token: 0x040000D5 RID: 213
	UiCommon,
	// Token: 0x040000D6 RID: 214
	ConfirmBox,
	// Token: 0x040000D7 RID: 215
	UiTabModule,
	// Token: 0x040000D8 RID: 216
	SceneTeam,
	// Token: 0x040000D9 RID: 217
	MultiPlayerTeam,
	// Token: 0x040000DA RID: 218
	Formation,
	// Token: 0x040000DB RID: 219
	DarkTide,
	// Token: 0x040000DC RID: 220
	DarkTideRing,
	// Token: 0x040000DD RID: 221
	ErrorCode,
	// Token: 0x040000DE RID: 222
	Functional,
	// Token: 0x040000DF RID: 223
	Gm,
	// Token: 0x040000E0 RID: 224
	Guide,
	// Token: 0x040000E1 RID: 225
	Inventory,
	// Token: 0x040000E2 RID: 226
	Item,
	// Token: 0x040000E3 RID: 227
	ItemHint,
	// Token: 0x040000E4 RID: 228
	LevelUp,
	// Token: 0x040000E5 RID: 229
	Login,
	// Token: 0x040000E6 RID: 230
	Mail,
	// Token: 0x040000E7 RID: 231
	Map,
	// Token: 0x040000E8 RID: 232
	MingSuTi,
	// Token: 0x040000E9 RID: 233
	Phantom,
	// Token: 0x040000EA RID: 234
	Reconnect,
	// Token: 0x040000EB RID: 235
	Reward,
	// Token: 0x040000EC RID: 236
	RewardItem,
	// Token: 0x040000ED RID: 237
	Role,
	// Token: 0x040000EE RID: 238
	Personal,
	// Token: 0x040000EF RID: 239
	Shop,
	// Token: 0x040000F0 RID: 240
	Tape,
	// Token: 0x040000F1 RID: 241
	UiCamera,
	// Token: 0x040000F2 RID: 242
	CameraAnimation,
	// Token: 0x040000F3 RID: 243
	UiComponent,
	// Token: 0x040000F4 RID: 244
	ModuleUtil,
	// Token: 0x040000F5 RID: 245
	Weapon,
	// Token: 0x040000F6 RID: 246
	Bullet,
	// Token: 0x040000F7 RID: 247
	Pawn,
	// Token: 0x040000F8 RID: 248
	SceneItem,
	// Token: 0x040000F9 RID: 249
	RenderCharacter,
	// Token: 0x040000FA RID: 250
	RenderBattle,
	// Token: 0x040000FB RID: 251
	RenderEffect,
	// Token: 0x040000FC RID: 252
	RenderGI,
	// Token: 0x040000FD RID: 253
	RenderScene,
	// Token: 0x040000FE RID: 254
	RenderUtil,
	// Token: 0x040000FF RID: 255
	World,
	// Token: 0x04000100 RID: 256
	GameMode,
	// Token: 0x04000101 RID: 257
	Movement,
	// Token: 0x04000102 RID: 258
	Test,
	// Token: 0x04000103 RID: 259
	LevelExperienceComponent,
	// Token: 0x04000104 RID: 260
	LoopScrollView,
	// Token: 0x04000105 RID: 261
	ScrollViewGrid,
	// Token: 0x04000106 RID: 262
	LevelSequencePlayer,
	// Token: 0x04000107 RID: 263
	GachaSequencePlayer,
	// Token: 0x04000108 RID: 264
	UiSceneRoleActor,
	// Token: 0x04000109 RID: 265
	CreateCharacter,
	// Token: 0x0400010A RID: 266
	TimeOfDay,
	// Token: 0x0400010B RID: 267
	ModelUtil,
	// Token: 0x0400010C RID: 268
	Editor,
	// Token: 0x0400010D RID: 269
	AI,
	// Token: 0x0400010E RID: 270
	LevelAi,
	// Token: 0x0400010F RID: 271
	PowerModule,
	// Token: 0x04000110 RID: 272
	WorldLevel,
	// Token: 0x04000111 RID: 273
	TriggerVolume,
	// Token: 0x04000112 RID: 274
	GenericPrompt,
	// Token: 0x04000113 RID: 275
	SceneGameplay,
	// Token: 0x04000114 RID: 276
	SceneStep,
	// Token: 0x04000115 RID: 277
	InstanceDungeon,
	// Token: 0x04000116 RID: 278
	Quest,
	// Token: 0x04000117 RID: 279
	QuestResource,
	// Token: 0x04000118 RID: 280
	QuestRecall,
	// Token: 0x04000119 RID: 281
	LevelPlay,
	// Token: 0x0400011A RID: 282
	WuYinModel,
	// Token: 0x0400011B RID: 283
	ControlScreen,
	// Token: 0x0400011C RID: 284
	BuffItem,
	// Token: 0x0400011D RID: 285
	Marquee,
	// Token: 0x0400011E RID: 286
	Plot,
	// Token: 0x0400011F RID: 287
	KuroSdk,
	// Token: 0x04000120 RID: 288
	ResonanceEffect,
	// Token: 0x04000121 RID: 289
	RoleResonance,
	// Token: 0x04000122 RID: 290
	RedDot,
	// Token: 0x04000123 RID: 291
	DebugView,
	// Token: 0x04000124 RID: 292
	ProtocolMonitor,
	// Token: 0x04000125 RID: 293
	LevelEvent,
	// Token: 0x04000126 RID: 294
	LevelCondition,
	// Token: 0x04000127 RID: 295
	LevelConditionRegistry,
	// Token: 0x04000128 RID: 296
	UiSceneManager,
	// Token: 0x04000129 RID: 297
	Loading,
	// Token: 0x0400012A RID: 298
	GamePlayTimer,
	// Token: 0x0400012B RID: 299
	Menu,
	// Token: 0x0400012C RID: 300
	InputManager,
	// Token: 0x0400012D RID: 301
	UiTimeDilation,
	// Token: 0x0400012E RID: 302
	UiAnimation,
	// Token: 0x0400012F RID: 303
	Interaction,
	// Token: 0x04000130 RID: 304
	SneakUi,
	// Token: 0x04000131 RID: 305
	CollectActor,
	// Token: 0x04000132 RID: 306
	Video,
	// Token: 0x04000133 RID: 307
	Area,
	// Token: 0x04000134 RID: 308
	ElementBall,
	// Token: 0x04000135 RID: 309
	Stat,
	// Token: 0x04000136 RID: 310
	LogReport,
	// Token: 0x04000137 RID: 311
	SaveUtil,
	// Token: 0x04000138 RID: 312
	Platform,
	// Token: 0x04000139 RID: 313
	PlatformSdk,
	// Token: 0x0400013A RID: 314
	PublicUtil,
	// Token: 0x0400013B RID: 315
	ShortKeysExitView,
	// Token: 0x0400013C RID: 316
	MultiplayerCombat,
	// Token: 0x0400013D RID: 317
	CombatInfo,
	// Token: 0x0400013E RID: 318
	Controller,
	// Token: 0x0400013F RID: 319
	FilterSortView,
	// Token: 0x04000140 RID: 320
	Friend,
	// Token: 0x04000141 RID: 321
	Cursor,
	// Token: 0x04000142 RID: 322
	UiNavigation,
	// Token: 0x04000143 RID: 323
	UiNavigationHotKey,
	// Token: 0x04000144 RID: 324
	Chat,
	// Token: 0x04000145 RID: 325
	Track,
	// Token: 0x04000146 RID: 326
	Performance,
	// Token: 0x04000147 RID: 327
	GeneralLogicTree,
	// Token: 0x04000148 RID: 328
	Pay,
	// Token: 0x04000149 RID: 329
	TimeUtil,
	// Token: 0x0400014A RID: 330
	Gacha,
	// Token: 0x0400014B RID: 331
	Calabash,
	// Token: 0x0400014C RID: 332
	ItemExchange,
	// Token: 0x0400014D RID: 333
	AdventureGuide,
	// Token: 0x0400014E RID: 334
	Tutorial,
	// Token: 0x0400014F RID: 335
	Weather,
	// Token: 0x04000150 RID: 336
	InfoDisplay,
	// Token: 0x04000151 RID: 337
	Scene3dUi,
	// Token: 0x04000152 RID: 338
	LguiUtil,
	// Token: 0x04000153 RID: 339
	Cook,
	// Token: 0x04000154 RID: 340
	GenericLayoutNew,
	// Token: 0x04000155 RID: 341
	UiFloatContainer,
	// Token: 0x04000156 RID: 342
	InfluenceReputation,
	// Token: 0x04000157 RID: 343
	HudUnit,
	// Token: 0x04000158 RID: 344
	CycleTower,
	// Token: 0x04000159 RID: 345
	TowerDefense,
	// Token: 0x0400015A RID: 346
	Animal,
	// Token: 0x0400015B RID: 347
	Recorder,
	// Token: 0x0400015C RID: 348
	ManufactureCommon,
	// Token: 0x0400015D RID: 349
	Compose,
	// Token: 0x0400015E RID: 350
	Forging,
	// Token: 0x0400015F RID: 351
	UiLoginSceneManager,
	// Token: 0x04000160 RID: 352
	HotFixSceneManager,
	// Token: 0x04000161 RID: 353
	Advice,
	// Token: 0x04000162 RID: 354
	LocalStorage,
	// Token: 0x04000163 RID: 355
	ServerStorage,
	// Token: 0x04000164 RID: 356
	HandBook,
	// Token: 0x04000165 RID: 357
	ActorSystem,
	// Token: 0x04000166 RID: 358
	UiModelResourcesManager,
	// Token: 0x04000167 RID: 359
	NPC,
	// Token: 0x04000168 RID: 360
	BasePerform,
	// Token: 0x04000169 RID: 361
	Achievement,
	// Token: 0x0400016A RID: 362
	NewFlag,
	// Token: 0x0400016B RID: 363
	Heartbeat,
	// Token: 0x0400016C RID: 364
	UiManager,
	// Token: 0x0400016D RID: 365
	BattleUiSet,
	// Token: 0x0400016E RID: 366
	StackContainer,
	// Token: 0x0400016F RID: 367
	PlotContainer,
	// Token: 0x04000170 RID: 368
	DataTableUtil,
	// Token: 0x04000171 RID: 369
	PanelQte,
	// Token: 0x04000172 RID: 370
	CommonQte,
	// Token: 0x04000173 RID: 371
	ComboTeaching,
	// Token: 0x04000174 RID: 372
	Activity,
	// Token: 0x04000175 RID: 373
	Teleport,
	// Token: 0x04000176 RID: 374
	TeleportMisc,
	// Token: 0x04000177 RID: 375
	TextLanguageSearch,
	// Token: 0x04000178 RID: 376
	UiViewContainer,
	// Token: 0x04000179 RID: 377
	UiLayer,
	// Token: 0x0400017A RID: 378
	UiMask,
	// Token: 0x0400017B RID: 379
	UiImageSetting,
	// Token: 0x0400017C RID: 380
	UiPrefabLoad,
	// Token: 0x0400017D RID: 381
	PerfHeatmap,
	// Token: 0x0400017E RID: 382
	SeamlessTravel,
	// Token: 0x0400017F RID: 383
	Filter,
	// Token: 0x04000180 RID: 384
	Sort,
	// Token: 0x04000181 RID: 385
	UiTickConditionModule,
	// Token: 0x04000182 RID: 386
	TsUiSceneRoleActor,
	// Token: 0x04000183 RID: 387
	MultiTextCsvModule,
	// Token: 0x04000184 RID: 388
	BlackScreen,
	// Token: 0x04000185 RID: 389
	DynamicMaskButton,
	// Token: 0x04000186 RID: 390
	Roguelike,
	// Token: 0x04000187 RID: 391
	RogueBattle,
	// Token: 0x04000188 RID: 392
	SkipInterface,
	// Token: 0x04000189 RID: 393
	TickController,
	// Token: 0x0400018A RID: 394
	ExploreProgress,
	// Token: 0x0400018B RID: 395
	ExploreLevel,
	// Token: 0x0400018C RID: 396
	Blur,
	// Token: 0x0400018D RID: 397
	AndroidBack,
	// Token: 0x0400018E RID: 398
	CloudGame,
	// Token: 0x0400018F RID: 399
	FrequencyMonitor,
	// Token: 0x04000190 RID: 400
	Photo,
	// Token: 0x04000191 RID: 401
	PhotoCamera,
	// Token: 0x04000192 RID: 402
	FragmentMemory,
	// Token: 0x04000193 RID: 403
	Push,
	// Token: 0x04000194 RID: 404
	LogUpload,
	// Token: 0x04000195 RID: 405
	Perception,
	// Token: 0x04000196 RID: 406
	MoonChasing,
	// Token: 0x04000197 RID: 407
	MowingRisk,
	// Token: 0x04000198 RID: 408
	VersionPreheat,
	// Token: 0x04000199 RID: 409
	Spring25,
	// Token: 0x0400019A RID: 410
	SolarSpeed,
	// Token: 0x0400019B RID: 411
	InviteNewbie,
	// Token: 0x0400019C RID: 412
	RacingBets,
	// Token: 0x0400019D RID: 413
	RacingBetsDungeon,
	// Token: 0x0400019E RID: 414
	PortalGamePlay,
	// Token: 0x0400019F RID: 415
	ActivityRegress,
	// Token: 0x040001A0 RID: 416
	Vehicle,
	// Token: 0x040001A1 RID: 417
	ScratchTicket,
	// Token: 0x040001A2 RID: 418
	FloroRanch,
	// Token: 0x040001A3 RID: 419
	FloroRanchGamePlay,
	// Token: 0x040001A4 RID: 420
	GameSettings,
	// Token: 0x040001A5 RID: 421
	MobileInputSwitch,
	// Token: 0x040001A6 RID: 422
	DreamLink,
	// Token: 0x040001A7 RID: 423
	RoleSkin,
	// Token: 0x040001A8 RID: 424
	WeaponSkin,
	// Token: 0x040001A9 RID: 425
	FlySkin,
	// Token: 0x040001AA RID: 426
	Dockyard,
	// Token: 0x040001AB RID: 427
	FilterWithState,
	// Token: 0x040001AC RID: 428
	ResponsibilityChain,
	// Token: 0x040001AD RID: 429
	LevelPlayReport,
	// Token: 0x040001AE RID: 430
	ActivityDirectTrain,
	// Token: 0x040001AF RID: 431
	Optimization,
	// Token: 0x040001B0 RID: 432
	Fishing,
	// Token: 0x040001B1 RID: 433
	ShipTower,
	// Token: 0x040001B2 RID: 434
	UiAsyncTask,
	// Token: 0x040001B3 RID: 435
	WeeklyRogue,
	// Token: 0x040001B4 RID: 436
	Chess,
	// Token: 0x040001B5 RID: 437
	SummonGongduola,
	// Token: 0x040001B6 RID: 438
	CiacconaGal,
	// Token: 0x040001B7 RID: 439
	DangoMonopoly,
	// Token: 0x040001B8 RID: 440
	TermExplanation,
	// Token: 0x040001B9 RID: 441
	SplashScreenTask,
	// Token: 0x040001BA RID: 442
	PhantomArena,
	// Token: 0x040001BB RID: 443
	Shower,
	// Token: 0x040001BC RID: 444
	SceneItemCurveControl,
	// Token: 0x040001BD RID: 445
	TemplateEntitySpawner,
	// Token: 0x040001BE RID: 446
	ChargeSlash,
	// Token: 0x040001BF RID: 447
	Morale,
	// Token: 0x040001C0 RID: 448
	LevelFlow,
	// Token: 0x040001C1 RID: 449
	TimeDilation,
	// Token: 0x040001C2 RID: 450
	KingShip,
	// Token: 0x040001C3 RID: 451
	TuningStand,
	// Token: 0x040001C4 RID: 452
	CommonGameMainView,
	// Token: 0x040001C5 RID: 453
	TowerDefenseEvent,
	// Token: 0x040001C6 RID: 454
	TowerDefenseBattle,
	// Token: 0x040001C7 RID: 455
	TouchUiEdit,
	// Token: 0x040001C8 RID: 456
	PsGamepadFeedback,
	// Token: 0x040001C9 RID: 457
	HonamiStory,
	// Token: 0x040001CA RID: 458
	AnimNotify,
	// Token: 0x040001CB RID: 459
	ActivityFunPlay,
	// Token: 0x040001CC RID: 460
	HomeBtn,
	// Token: 0x040001CD RID: 461
	DailyActivity,
	// Token: 0x040001CE RID: 462
	RoleDev,
	// Token: 0x040001CF RID: 463
	SurvivorsRogue,
	// Token: 0x040001D0 RID: 464
	FightPhotograph,
	// Token: 0x040001D1 RID: 465
	Photograph,
	// Token: 0x040001D2 RID: 466
	MeshStream,
	// Token: 0x040001D3 RID: 467
	CalabashSkin,
	// Token: 0x040001D4 RID: 468
	QuestTree,
	// Token: 0x040001D5 RID: 469
	ActivityPreWarm,
	// Token: 0x040001D6 RID: 470
	LevelListener,
	// Token: 0x040001D7 RID: 471
	MultiTemplateScrollView,
	// Token: 0x040001D8 RID: 472
	GridDelegate,
	// Token: 0x040001D9 RID: 473
	MultiTemplateComponent,
	// Token: 0x040001DA RID: 474
	SubPackageDownLoad,
	// Token: 0x040001DB RID: 475
	Infrastructure,
	// Token: 0x040001DC RID: 476
	VillageInfr,
	// Token: 0x040001DD RID: 477
	RollBlock,
	// Token: 0x040001DE RID: 478
	AutoPilot,
	// Token: 0x040001DF RID: 479
	VehicleStream,
	// Token: 0x040001E0 RID: 480
	Panoramic,
	// Token: 0x040001E1 RID: 481
	Motor,
	// Token: 0x040001E2 RID: 482
	PilotThrow,
	// Token: 0x040001E3 RID: 483
	MovieMode,
	// Token: 0x040001E4 RID: 484
	DeadEye,
	// Token: 0x040001E5 RID: 485
	WheelTower,
	// Token: 0x040001E6 RID: 486
	MotorParkour,
	// Token: 0x040001E7 RID: 487
	MotorRailMove,
	// Token: 0x040001E8 RID: 488
	PhantomInteraction,
	// Token: 0x040001E9 RID: 489
	PhoneSystem,
	// Token: 0x040001EA RID: 490
	SunSpirit,
	// Token: 0x040001EB RID: 491
	Encircle,
	// Token: 0x040001EC RID: 492
	MotorFightActivity,
	// Token: 0x040001ED RID: 493
	ActivityTotalTopUp,
	// Token: 0x040001EE RID: 494
	SpringManor,
	// Token: 0x040001EF RID: 495
	GuessJokerCard,
	// Token: 0x040001F0 RID: 496
	Drinks,
	// Token: 0x040001F1 RID: 497
	DropCatch,
	// Token: 0x040001F2 RID: 498
	RhythmGame,
	// Token: 0x040001F3 RID: 499
	SlidingBlocks,
	// Token: 0x040001F4 RID: 500
	Pinball,
	// Token: 0x040001F5 RID: 501
	RoleOrnament,
	// Token: 0x040001F6 RID: 502
	Decoration,
	// Token: 0x040001F7 RID: 503
	FlagChallenge,
	// Token: 0x040001F8 RID: 504
	BossPiling,
	// Token: 0x040001F9 RID: 505
	PinballBattle,
	// Token: 0x040001FA RID: 506
	GolemHacking,
	// Token: 0x040001FB RID: 507
	ProjectorPuzzle,
	// Token: 0x040001FC RID: 508
	WeeklyChallenge,
	// Token: 0x040001FD RID: 509
	QuickHack,
	// Token: 0x040001FE RID: 510
	IosAudit,
	// Token: 0x040001FF RID: 511
	DollGrabMachine,
	// Token: 0x04000200 RID: 512
	Roverlike,
	// Token: 0x04000201 RID: 513
	MusicalInstrument,
	// Token: 0x04000202 RID: 514
	QuestMultiLine,
	// Token: 0x04000203 RID: 515
	PathDrivenActor,
	// Token: 0x04000204 RID: 516
	Capability,
	// Token: 0x04000205 RID: 517
	Sheriff,
	// Token: 0x04000206 RID: 518
	DangoBrawl,
	// Token: 0x04000207 RID: 519
	MatchThree,
	// Token: 0x04000208 RID: 520
	Giant,
	// Token: 0x04000209 RID: 521
	WuWaGo,
	// Token: 0x0400020A RID: 522
	Season,
	// Token: 0x0400020B RID: 523
	Kurotato,
	// Token: 0x0400020C RID: 524
	ComboTimeline
}
