using System;
using CSharpScript.Core.Common;

// Token: 0x02000008 RID: 8
[EnumExtensions]
public enum ELogModule
{
	// Token: 0x040000B0 RID: 176
	Engine,
	// Token: 0x040000B1 RID: 177
	UiEditor,
	// Token: 0x040000B2 RID: 178
	ResourceCheck,
	// Token: 0x040000B3 RID: 179
	IllegalCodeCheck,
	// Token: 0x040000B4 RID: 180
	Temp,
	// Token: 0x040000B5 RID: 181
	HotPatch,
	// Token: 0x040000B6 RID: 182
	Log,
	// Token: 0x040000B7 RID: 183
	ExportProto,
	// Token: 0x040000B8 RID: 184
	Core,
	// Token: 0x040000B9 RID: 185
	Entity,
	// Token: 0x040000BA RID: 186
	Event,
	// Token: 0x040000BB RID: 187
	Json,
	// Token: 0x040000BC RID: 188
	P4,
	// Token: 0x040000BD RID: 189
	Config,
	// Token: 0x040000BE RID: 190
	CommonDbConnect,
	// Token: 0x040000BF RID: 191
	Pool,
	// Token: 0x040000C0 RID: 192
	Container,
	// Token: 0x040000C1 RID: 193
	UiCore,
	// Token: 0x040000C2 RID: 194
	Net,
	// Token: 0x040000C3 RID: 195
	Object,
	// Token: 0x040000C4 RID: 196
	Resource,
	// Token: 0x040000C5 RID: 197
	Tick,
	// Token: 0x040000C6 RID: 198
	Timer,
	// Token: 0x040000C7 RID: 199
	Game,
	// Token: 0x040000C8 RID: 200
	Render,
	// Token: 0x040000C9 RID: 201
	Preload,
	// Token: 0x040000CA RID: 202
	StateMachine,
	// Token: 0x040000CB RID: 203
	BehaviorTree,
	// Token: 0x040000CC RID: 204
	Camera,
	// Token: 0x040000CD RID: 205
	Character,
	// Token: 0x040000CE RID: 206
	TextUtil,
	// Token: 0x040000CF RID: 207
	Input,
	// Token: 0x040000D0 RID: 208
	InputSettings,
	// Token: 0x040000D1 RID: 209
	Level,
	// Token: 0x040000D2 RID: 210
	Audio,
	// Token: 0x040000D3 RID: 211
	Battle,
	// Token: 0x040000D4 RID: 212
	UiModel,
	// Token: 0x040000D5 RID: 213
	UiModelMorph,
	// Token: 0x040000D6 RID: 214
	BpBridge,
	// Token: 0x040000D7 RID: 215
	TaskGraph,
	// Token: 0x040000D8 RID: 216
	UiCommon,
	// Token: 0x040000D9 RID: 217
	ConfirmBox,
	// Token: 0x040000DA RID: 218
	UiTabModule,
	// Token: 0x040000DB RID: 219
	SceneTeam,
	// Token: 0x040000DC RID: 220
	MultiPlayerTeam,
	// Token: 0x040000DD RID: 221
	Formation,
	// Token: 0x040000DE RID: 222
	PianoGameplay,
	// Token: 0x040000DF RID: 223
	ErrorCode,
	// Token: 0x040000E0 RID: 224
	Functional,
	// Token: 0x040000E1 RID: 225
	Gm,
	// Token: 0x040000E2 RID: 226
	Guide,
	// Token: 0x040000E3 RID: 227
	Inventory,
	// Token: 0x040000E4 RID: 228
	Item,
	// Token: 0x040000E5 RID: 229
	ItemHint,
	// Token: 0x040000E6 RID: 230
	LevelUp,
	// Token: 0x040000E7 RID: 231
	Login,
	// Token: 0x040000E8 RID: 232
	Mail,
	// Token: 0x040000E9 RID: 233
	Map,
	// Token: 0x040000EA RID: 234
	MingSuTi,
	// Token: 0x040000EB RID: 235
	Phantom,
	// Token: 0x040000EC RID: 236
	Reconnect,
	// Token: 0x040000ED RID: 237
	Reward,
	// Token: 0x040000EE RID: 238
	RewardItem,
	// Token: 0x040000EF RID: 239
	Role,
	// Token: 0x040000F0 RID: 240
	Personal,
	// Token: 0x040000F1 RID: 241
	Shop,
	// Token: 0x040000F2 RID: 242
	Tape,
	// Token: 0x040000F3 RID: 243
	UiCamera,
	// Token: 0x040000F4 RID: 244
	CameraAnimation,
	// Token: 0x040000F5 RID: 245
	UiComponent,
	// Token: 0x040000F6 RID: 246
	ModuleUtil,
	// Token: 0x040000F7 RID: 247
	Weapon,
	// Token: 0x040000F8 RID: 248
	Bullet,
	// Token: 0x040000F9 RID: 249
	Pawn,
	// Token: 0x040000FA RID: 250
	SceneItem,
	// Token: 0x040000FB RID: 251
	RenderCharacter,
	// Token: 0x040000FC RID: 252
	RenderBattle,
	// Token: 0x040000FD RID: 253
	RenderEffect,
	// Token: 0x040000FE RID: 254
	RenderGI,
	// Token: 0x040000FF RID: 255
	RenderScene,
	// Token: 0x04000100 RID: 256
	RenderUtil,
	// Token: 0x04000101 RID: 257
	World,
	// Token: 0x04000102 RID: 258
	GameMode,
	// Token: 0x04000103 RID: 259
	Movement,
	// Token: 0x04000104 RID: 260
	Test,
	// Token: 0x04000105 RID: 261
	LevelExperienceComponent,
	// Token: 0x04000106 RID: 262
	LoopScrollView,
	// Token: 0x04000107 RID: 263
	ScrollViewGrid,
	// Token: 0x04000108 RID: 264
	LevelSequencePlayer,
	// Token: 0x04000109 RID: 265
	GachaSequencePlayer,
	// Token: 0x0400010A RID: 266
	UiSceneRoleActor,
	// Token: 0x0400010B RID: 267
	CreateCharacter,
	// Token: 0x0400010C RID: 268
	TimeOfDay,
	// Token: 0x0400010D RID: 269
	ModelUtil,
	// Token: 0x0400010E RID: 270
	Editor,
	// Token: 0x0400010F RID: 271
	AI,
	// Token: 0x04000110 RID: 272
	LevelAi,
	// Token: 0x04000111 RID: 273
	PowerModule,
	// Token: 0x04000112 RID: 274
	WorldLevel,
	// Token: 0x04000113 RID: 275
	TriggerVolume,
	// Token: 0x04000114 RID: 276
	GenericPrompt,
	// Token: 0x04000115 RID: 277
	SceneGameplay,
	// Token: 0x04000116 RID: 278
	SceneStep,
	// Token: 0x04000117 RID: 279
	InstanceDungeon,
	// Token: 0x04000118 RID: 280
	Quest,
	// Token: 0x04000119 RID: 281
	QuestResource,
	// Token: 0x0400011A RID: 282
	QuestRecall,
	// Token: 0x0400011B RID: 283
	LevelPlay,
	// Token: 0x0400011C RID: 284
	WuYinModel,
	// Token: 0x0400011D RID: 285
	ControlScreen,
	// Token: 0x0400011E RID: 286
	BuffItem,
	// Token: 0x0400011F RID: 287
	Marquee,
	// Token: 0x04000120 RID: 288
	Plot,
	// Token: 0x04000121 RID: 289
	KuroSdk,
	// Token: 0x04000122 RID: 290
	ResonanceEffect,
	// Token: 0x04000123 RID: 291
	RoleResonance,
	// Token: 0x04000124 RID: 292
	RedDot,
	// Token: 0x04000125 RID: 293
	DebugView,
	// Token: 0x04000126 RID: 294
	ProtocolMonitor,
	// Token: 0x04000127 RID: 295
	LevelEvent,
	// Token: 0x04000128 RID: 296
	LevelCondition,
	// Token: 0x04000129 RID: 297
	ActivityCondition,
	// Token: 0x0400012A RID: 298
	LevelConditionRegistry,
	// Token: 0x0400012B RID: 299
	UiSceneManager,
	// Token: 0x0400012C RID: 300
	Loading,
	// Token: 0x0400012D RID: 301
	GamePlayTimer,
	// Token: 0x0400012E RID: 302
	Menu,
	// Token: 0x0400012F RID: 303
	InputManager,
	// Token: 0x04000130 RID: 304
	UiTimeDilation,
	// Token: 0x04000131 RID: 305
	UiAnimation,
	// Token: 0x04000132 RID: 306
	Interaction,
	// Token: 0x04000133 RID: 307
	SneakUi,
	// Token: 0x04000134 RID: 308
	CollectActor,
	// Token: 0x04000135 RID: 309
	Video,
	// Token: 0x04000136 RID: 310
	Area,
	// Token: 0x04000137 RID: 311
	ElementBall,
	// Token: 0x04000138 RID: 312
	Stat,
	// Token: 0x04000139 RID: 313
	LogReport,
	// Token: 0x0400013A RID: 314
	SaveUtil,
	// Token: 0x0400013B RID: 315
	Platform,
	// Token: 0x0400013C RID: 316
	PlatformSdk,
	// Token: 0x0400013D RID: 317
	PublicUtil,
	// Token: 0x0400013E RID: 318
	ShortKeysExitView,
	// Token: 0x0400013F RID: 319
	MultiplayerCombat,
	// Token: 0x04000140 RID: 320
	CombatInfo,
	// Token: 0x04000141 RID: 321
	Controller,
	// Token: 0x04000142 RID: 322
	FilterSortView,
	// Token: 0x04000143 RID: 323
	Friend,
	// Token: 0x04000144 RID: 324
	Cursor,
	// Token: 0x04000145 RID: 325
	UiNavigation,
	// Token: 0x04000146 RID: 326
	UiNavigationHotKey,
	// Token: 0x04000147 RID: 327
	Chat,
	// Token: 0x04000148 RID: 328
	Track,
	// Token: 0x04000149 RID: 329
	Performance,
	// Token: 0x0400014A RID: 330
	GeneralLogicTree,
	// Token: 0x0400014B RID: 331
	Pay,
	// Token: 0x0400014C RID: 332
	TimeUtil,
	// Token: 0x0400014D RID: 333
	Gacha,
	// Token: 0x0400014E RID: 334
	Calabash,
	// Token: 0x0400014F RID: 335
	ItemExchange,
	// Token: 0x04000150 RID: 336
	AdventureGuide,
	// Token: 0x04000151 RID: 337
	Tutorial,
	// Token: 0x04000152 RID: 338
	Weather,
	// Token: 0x04000153 RID: 339
	InfoDisplay,
	// Token: 0x04000154 RID: 340
	Scene3dUi,
	// Token: 0x04000155 RID: 341
	LguiUtil,
	// Token: 0x04000156 RID: 342
	Cook,
	// Token: 0x04000157 RID: 343
	GenericLayoutNew,
	// Token: 0x04000158 RID: 344
	UiFloatContainer,
	// Token: 0x04000159 RID: 345
	InfluenceReputation,
	// Token: 0x0400015A RID: 346
	HudUnit,
	// Token: 0x0400015B RID: 347
	CycleTower,
	// Token: 0x0400015C RID: 348
	TowerDefense,
	// Token: 0x0400015D RID: 349
	Animal,
	// Token: 0x0400015E RID: 350
	Recorder,
	// Token: 0x0400015F RID: 351
	ManufactureCommon,
	// Token: 0x04000160 RID: 352
	Compose,
	// Token: 0x04000161 RID: 353
	Forging,
	// Token: 0x04000162 RID: 354
	UiLoginSceneManager,
	// Token: 0x04000163 RID: 355
	HotFixSceneManager,
	// Token: 0x04000164 RID: 356
	Advice,
	// Token: 0x04000165 RID: 357
	LocalStorage,
	// Token: 0x04000166 RID: 358
	ServerStorage,
	// Token: 0x04000167 RID: 359
	HandBook,
	// Token: 0x04000168 RID: 360
	ActorSystem,
	// Token: 0x04000169 RID: 361
	UiModelResourcesManager,
	// Token: 0x0400016A RID: 362
	NPC,
	// Token: 0x0400016B RID: 363
	BasePerform,
	// Token: 0x0400016C RID: 364
	Achievement,
	// Token: 0x0400016D RID: 365
	NewFlag,
	// Token: 0x0400016E RID: 366
	Heartbeat,
	// Token: 0x0400016F RID: 367
	UiManager,
	// Token: 0x04000170 RID: 368
	BattleUiSet,
	// Token: 0x04000171 RID: 369
	StackContainer,
	// Token: 0x04000172 RID: 370
	PlotContainer,
	// Token: 0x04000173 RID: 371
	DataTableUtil,
	// Token: 0x04000174 RID: 372
	PanelQte,
	// Token: 0x04000175 RID: 373
	CommonQte,
	// Token: 0x04000176 RID: 374
	ComboTeaching,
	// Token: 0x04000177 RID: 375
	Activity,
	// Token: 0x04000178 RID: 376
	Teleport,
	// Token: 0x04000179 RID: 377
	TeleportMisc,
	// Token: 0x0400017A RID: 378
	TextLanguageSearch,
	// Token: 0x0400017B RID: 379
	UiViewContainer,
	// Token: 0x0400017C RID: 380
	UiLayer,
	// Token: 0x0400017D RID: 381
	UiMask,
	// Token: 0x0400017E RID: 382
	UiImageSetting,
	// Token: 0x0400017F RID: 383
	UiPrefabLoad,
	// Token: 0x04000180 RID: 384
	PerfHeatmap,
	// Token: 0x04000181 RID: 385
	SeamlessTravel,
	// Token: 0x04000182 RID: 386
	Filter,
	// Token: 0x04000183 RID: 387
	Sort,
	// Token: 0x04000184 RID: 388
	UiTickConditionModule,
	// Token: 0x04000185 RID: 389
	TsUiSceneRoleActor,
	// Token: 0x04000186 RID: 390
	MultiTextCsvModule,
	// Token: 0x04000187 RID: 391
	BlackScreen,
	// Token: 0x04000188 RID: 392
	DynamicMaskButton,
	// Token: 0x04000189 RID: 393
	Roguelike,
	// Token: 0x0400018A RID: 394
	RogueBattle,
	// Token: 0x0400018B RID: 395
	SkipInterface,
	// Token: 0x0400018C RID: 396
	TickController,
	// Token: 0x0400018D RID: 397
	ExploreProgress,
	// Token: 0x0400018E RID: 398
	ExploreLevel,
	// Token: 0x0400018F RID: 399
	Blur,
	// Token: 0x04000190 RID: 400
	AndroidBack,
	// Token: 0x04000191 RID: 401
	CloudGame,
	// Token: 0x04000192 RID: 402
	FrequencyMonitor,
	// Token: 0x04000193 RID: 403
	Photo,
	// Token: 0x04000194 RID: 404
	PhotoCamera,
	// Token: 0x04000195 RID: 405
	FragmentMemory,
	// Token: 0x04000196 RID: 406
	Push,
	// Token: 0x04000197 RID: 407
	LogUpload,
	// Token: 0x04000198 RID: 408
	Perception,
	// Token: 0x04000199 RID: 409
	MoonChasing,
	// Token: 0x0400019A RID: 410
	MowingRisk,
	// Token: 0x0400019B RID: 411
	VersionPreheat,
	// Token: 0x0400019C RID: 412
	Spring25,
	// Token: 0x0400019D RID: 413
	SolarSpeed,
	// Token: 0x0400019E RID: 414
	InviteNewbie,
	// Token: 0x0400019F RID: 415
	RacingBets,
	// Token: 0x040001A0 RID: 416
	RacingBetsDungeon,
	// Token: 0x040001A1 RID: 417
	PortalGamePlay,
	// Token: 0x040001A2 RID: 418
	ActivityRegress,
	// Token: 0x040001A3 RID: 419
	Vehicle,
	// Token: 0x040001A4 RID: 420
	ScratchTicket,
	// Token: 0x040001A5 RID: 421
	FloroRanch,
	// Token: 0x040001A6 RID: 422
	FloroRanchGamePlay,
	// Token: 0x040001A7 RID: 423
	GameSettings,
	// Token: 0x040001A8 RID: 424
	MobileInputSwitch,
	// Token: 0x040001A9 RID: 425
	DreamLink,
	// Token: 0x040001AA RID: 426
	RoleSkin,
	// Token: 0x040001AB RID: 427
	WeaponSkin,
	// Token: 0x040001AC RID: 428
	FlySkin,
	// Token: 0x040001AD RID: 429
	Dockyard,
	// Token: 0x040001AE RID: 430
	FilterWithState,
	// Token: 0x040001AF RID: 431
	ResponsibilityChain,
	// Token: 0x040001B0 RID: 432
	LevelPlayReport,
	// Token: 0x040001B1 RID: 433
	ActivityDirectTrain,
	// Token: 0x040001B2 RID: 434
	Optimization,
	// Token: 0x040001B3 RID: 435
	Fishing,
	// Token: 0x040001B4 RID: 436
	ShipTower,
	// Token: 0x040001B5 RID: 437
	UiAsyncTask,
	// Token: 0x040001B6 RID: 438
	WeeklyRogue,
	// Token: 0x040001B7 RID: 439
	Chess,
	// Token: 0x040001B8 RID: 440
	SummonGongduola,
	// Token: 0x040001B9 RID: 441
	CiacconaGal,
	// Token: 0x040001BA RID: 442
	DangoMonopoly,
	// Token: 0x040001BB RID: 443
	TermExplanation,
	// Token: 0x040001BC RID: 444
	SplashScreenTask,
	// Token: 0x040001BD RID: 445
	PhantomArena,
	// Token: 0x040001BE RID: 446
	Shower,
	// Token: 0x040001BF RID: 447
	SceneItemCurveControl,
	// Token: 0x040001C0 RID: 448
	TemplateEntitySpawner,
	// Token: 0x040001C1 RID: 449
	ChargeSlash,
	// Token: 0x040001C2 RID: 450
	Morale,
	// Token: 0x040001C3 RID: 451
	LevelFlow,
	// Token: 0x040001C4 RID: 452
	TimeDilation,
	// Token: 0x040001C5 RID: 453
	KingShip,
	// Token: 0x040001C6 RID: 454
	TuningStand,
	// Token: 0x040001C7 RID: 455
	CommonGameMainView,
	// Token: 0x040001C8 RID: 456
	TowerDefenseEvent,
	// Token: 0x040001C9 RID: 457
	TowerDefenseBattle,
	// Token: 0x040001CA RID: 458
	TouchUiEdit,
	// Token: 0x040001CB RID: 459
	PsGamepadFeedback,
	// Token: 0x040001CC RID: 460
	HonamiStory,
	// Token: 0x040001CD RID: 461
	AnimNotify,
	// Token: 0x040001CE RID: 462
	ActivityFunPlay,
	// Token: 0x040001CF RID: 463
	HomeBtn,
	// Token: 0x040001D0 RID: 464
	DailyActivity,
	// Token: 0x040001D1 RID: 465
	RoleDev,
	// Token: 0x040001D2 RID: 466
	SurvivorsRogue,
	// Token: 0x040001D3 RID: 467
	FightPhotograph,
	// Token: 0x040001D4 RID: 468
	Photograph,
	// Token: 0x040001D5 RID: 469
	MeshStream,
	// Token: 0x040001D6 RID: 470
	CalabashSkin,
	// Token: 0x040001D7 RID: 471
	QuestTree,
	// Token: 0x040001D8 RID: 472
	ActivityPreWarm,
	// Token: 0x040001D9 RID: 473
	LevelListener,
	// Token: 0x040001DA RID: 474
	MultiTemplateScrollView,
	// Token: 0x040001DB RID: 475
	GridDelegate,
	// Token: 0x040001DC RID: 476
	MultiTemplateComponent,
	// Token: 0x040001DD RID: 477
	SubPackageDownLoad,
	// Token: 0x040001DE RID: 478
	Infrastructure,
	// Token: 0x040001DF RID: 479
	VillageInfr,
	// Token: 0x040001E0 RID: 480
	RollBlock,
	// Token: 0x040001E1 RID: 481
	AutoPilot,
	// Token: 0x040001E2 RID: 482
	VehicleStream,
	// Token: 0x040001E3 RID: 483
	Panoramic,
	// Token: 0x040001E4 RID: 484
	Motor,
	// Token: 0x040001E5 RID: 485
	PilotThrow,
	// Token: 0x040001E6 RID: 486
	MovieMode,
	// Token: 0x040001E7 RID: 487
	DeadEye,
	// Token: 0x040001E8 RID: 488
	WheelTower,
	// Token: 0x040001E9 RID: 489
	MotorParkour,
	// Token: 0x040001EA RID: 490
	MotorRailMove,
	// Token: 0x040001EB RID: 491
	PhantomInteraction,
	// Token: 0x040001EC RID: 492
	PhoneSystem,
	// Token: 0x040001ED RID: 493
	SunSpirit,
	// Token: 0x040001EE RID: 494
	Encircle,
	// Token: 0x040001EF RID: 495
	MotorFightActivity,
	// Token: 0x040001F0 RID: 496
	ActivityTotalTopUp,
	// Token: 0x040001F1 RID: 497
	SpringManor,
	// Token: 0x040001F2 RID: 498
	GuessJokerCard,
	// Token: 0x040001F3 RID: 499
	Drinks,
	// Token: 0x040001F4 RID: 500
	DropCatch,
	// Token: 0x040001F5 RID: 501
	RhythmGame,
	// Token: 0x040001F6 RID: 502
	SlidingBlocks,
	// Token: 0x040001F7 RID: 503
	Pinball,
	// Token: 0x040001F8 RID: 504
	RoleOrnament,
	// Token: 0x040001F9 RID: 505
	Decoration,
	// Token: 0x040001FA RID: 506
	FlagChallenge,
	// Token: 0x040001FB RID: 507
	BossPiling,
	// Token: 0x040001FC RID: 508
	PinballBattle,
	// Token: 0x040001FD RID: 509
	GolemHacking,
	// Token: 0x040001FE RID: 510
	ProjectorPuzzle,
	// Token: 0x040001FF RID: 511
	WeeklyChallenge,
	// Token: 0x04000200 RID: 512
	QuickHack,
	// Token: 0x04000201 RID: 513
	IosAudit,
	// Token: 0x04000202 RID: 514
	DollGrabMachine,
	// Token: 0x04000203 RID: 515
	Roverlike,
	// Token: 0x04000204 RID: 516
	MusicalInstrument,
	// Token: 0x04000205 RID: 517
	QuestMultiLine,
	// Token: 0x04000206 RID: 518
	PathDrivenActor,
	// Token: 0x04000207 RID: 519
	Capability,
	// Token: 0x04000208 RID: 520
	Sheriff,
	// Token: 0x04000209 RID: 521
	DangoBrawl,
	// Token: 0x0400020A RID: 522
	MatchThree,
	// Token: 0x0400020B RID: 523
	Giant,
	// Token: 0x0400020C RID: 524
	WuWaGo,
	// Token: 0x0400020D RID: 525
	Season,
	// Token: 0x0400020E RID: 526
	Kurotato,
	// Token: 0x0400020F RID: 527
	ComboTimeline,
	// Token: 0x04000210 RID: 528
	SolarSchool,
	// Token: 0x04000211 RID: 529
	VisualNovel
}
