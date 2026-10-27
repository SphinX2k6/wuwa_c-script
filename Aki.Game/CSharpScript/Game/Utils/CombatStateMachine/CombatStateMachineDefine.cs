using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Utils.CombatStateMachine
{
	// Token: 0x0200457F RID: 17791
	public class CombatStateMachineDefine
	{
		// Token: 0x0200A82A RID: 43050
		public static class Fsm
		{
			// Token: 0x0200D07C RID: 53372
			public enum EFsmSyncKey
			{
				// Token: 0x0403E9ED RID: 256493
				RandomMontageIndex = 1,
				// Token: 0x0403E9EE RID: 256494
				MoveToTarget
			}

			// Token: 0x0200D07D RID: 53373
			public enum ETaskType
			{
				// Token: 0x0403E9F0 RID: 256496
				TaskSkill = 1,
				// Token: 0x0403E9F1 RID: 256497
				TaskSkillByName,
				// Token: 0x0403E9F2 RID: 256498
				TaskRandomMontage,
				// Token: 0x0403E9F3 RID: 256499
				TaskLeaveFight = 101,
				// Token: 0x0403E9F4 RID: 256500
				TaskMontage,
				// Token: 0x0403E9F5 RID: 256501
				TaskMoveToTarget,
				// Token: 0x0403E9F6 RID: 256502
				TaskPatrol,
				// Token: 0x0403E9F7 RID: 256503
				TaskBeHitMontage,
				// Token: 0x0403E9F8 RID: 256504
				TaskGroupPatrol,
				// Token: 0x0403E9F9 RID: 256505
				TaskGroupPerform
			}

			// Token: 0x0200D07E RID: 53374
			[NullableContext(2)]
			[Nullable(0)]
			public class Task
			{
				// Token: 0x0403E9FA RID: 256506
				public int Type;

				// Token: 0x0403E9FB RID: 256507
				public bool CanBeInterrupt;

				// Token: 0x0403E9FC RID: 256508
				public CombatStateMachineDefine.Fsm.TaskSkill TaskSkill;

				// Token: 0x0403E9FD RID: 256509
				public CombatStateMachineDefine.Fsm.TaskSkillByName TaskSkillByName;

				// Token: 0x0403E9FE RID: 256510
				public CombatStateMachineDefine.Fsm.TaskRandomMontage TaskRandomMontage;

				// Token: 0x0403E9FF RID: 256511
				public CombatStateMachineDefine.Fsm.TaskLeaveFight TaskLeaveFight;

				// Token: 0x0403EA00 RID: 256512
				public CombatStateMachineDefine.Fsm.TaskMontage TaskMontage;

				// Token: 0x0403EA01 RID: 256513
				public CombatStateMachineDefine.Fsm.TaskMoveToTarget TaskMoveToTarget;

				// Token: 0x0403EA02 RID: 256514
				public CombatStateMachineDefine.Fsm.TaskPatrol TaskPatrol;

				// Token: 0x0403EA03 RID: 256515
				public CombatStateMachineDefine.Fsm.TaskBeHitMontage TaskBeHitMontage;

				// Token: 0x0403EA04 RID: 256516
				public CombatStateMachineDefine.Fsm.TaskGroupPatrol TaskGroupPatrol;

				// Token: 0x0403EA05 RID: 256517
				public CombatStateMachineDefine.Fsm.TaskGroupPerform TaskGroupPerform;

				// Token: 0x0403EA06 RID: 256518
				public string Name;
			}

			// Token: 0x0200D07F RID: 53375
			public class TaskSkill
			{
				// Token: 0x0403EA07 RID: 256519
				public int SkillId;

				// Token: 0x0403EA08 RID: 256520
				public int ConfigReplaceTagId;

				// Token: 0x0403EA09 RID: 256521
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200D080 RID: 53376
			[NullableContext(1)]
			[Nullable(0)]
			public class TaskSkillByName
			{
				// Token: 0x0403EA0A RID: 256522
				public string SkillName = "";

				// Token: 0x0403EA0B RID: 256523
				public int ConfigReplaceTagId;

				// Token: 0x0403EA0C RID: 256524
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200D081 RID: 53377
			public class TaskRandomMontage
			{
				// Token: 0x0403EA0D RID: 256525
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<string> MontageNames;

				// Token: 0x0403EA0E RID: 256526
				public bool HideOnLoading;

				// Token: 0x0403EA0F RID: 256527
				public float BlendInTime;

				// Token: 0x0403EA10 RID: 256528
				public bool RandomByClient;
			}

			// Token: 0x0200D082 RID: 53378
			public class TaskLeaveFight
			{
				// Token: 0x0403EA11 RID: 256529
				public float BlinkTime;

				// Token: 0x0403EA12 RID: 256530
				public float MaxStopTime;

				// Token: 0x0403EA13 RID: 256531
				public bool UsePatrolPointPriority;
			}

			// Token: 0x0200D083 RID: 53379
			[NullableContext(1)]
			[Nullable(0)]
			public class TaskMontage
			{
				// Token: 0x0403EA14 RID: 256532
				public string MontageName = "";

				// Token: 0x0403EA15 RID: 256533
				public bool HideOnLoading;

				// Token: 0x0403EA16 RID: 256534
				public float BlendInTime;

				// Token: 0x0403EA17 RID: 256535
				public bool ForcePush2Server;

				// Token: 0x0403EA18 RID: 256536
				public int ConfigReplaceTagId;

				// Token: 0x0403EA19 RID: 256537
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200D084 RID: 53380
			public class TaskMoveToTarget
			{
				// Token: 0x0403EA1A RID: 256538
				public int TargetType;

				// Token: 0x0403EA1B RID: 256539
				public int MoveState;

				// Token: 0x0403EA1C RID: 256540
				public float EndDistance;

				// Token: 0x0403EA1D RID: 256541
				public float TurnSpeed;

				// Token: 0x0403EA1E RID: 256542
				public bool WalkOff;
			}

			// Token: 0x0200D085 RID: 53381
			public class TaskPatrol
			{
				// Token: 0x0403EA1F RID: 256543
				public int MoveState;

				// Token: 0x0403EA20 RID: 256544
				public bool OpenDebugMode;
			}

			// Token: 0x0200D086 RID: 53382
			public class TaskBeHitMontage
			{
				// Token: 0x0403EA21 RID: 256545
				[Nullable(1)]
				public string DefaultMontageName = "";

				// Token: 0x0403EA22 RID: 256546
				[Nullable(new byte[]
				{
					1,
					0,
					1
				})]
				[JsonConverter(typeof(CombatStateMachineDefine.Fsm.MontageMapConverter))]
				public List<ValueTuple<int, string>> MontageMap = new List<ValueTuple<int, string>>();

				// Token: 0x0403EA23 RID: 256547
				public float BlendInTime;
			}

			// Token: 0x0200D087 RID: 53383
			[NullableContext(1)]
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1
			})]
			public class MontageMapConverter : JsonConverter<List<ValueTuple<int, string>>>
			{
				// Token: 0x060523B2 RID: 336818 RVA: 0x0165A8B0 File Offset: 0x01658AB0
				[return: Nullable(new byte[]
				{
					1,
					0,
					1
				})]
				public override List<ValueTuple<int, string>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
				{
					if (reader.TokenType != JsonTokenType.StartArray)
					{
						throw new JsonException("Expected start of array for tuple.");
					}
					List<ValueTuple<int, string>> list = new List<ValueTuple<int, string>>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						if (reader.TokenType != JsonTokenType.StartArray)
						{
							throw new JsonException("Expected start of array for tuple.");
						}
						reader.Read();
						int @int = reader.GetInt32();
						reader.Read();
						string @string = reader.GetString();
						reader.Read();
						list.Add(new ValueTuple<int, string>(@int, @string));
					}
					return list;
				}

				// Token: 0x060523B3 RID: 336819 RVA: 0x0165A930 File Offset: 0x01658B30
				public override void Write(Utf8JsonWriter writer, [Nullable(new byte[]
				{
					1,
					0,
					1
				})] List<ValueTuple<int, string>> value, JsonSerializerOptions options)
				{
					writer.WriteStartArray();
					foreach (ValueTuple<int, string> valueTuple in value)
					{
						writer.WriteStartArray();
						writer.WriteNumberValue(valueTuple.Item1);
						writer.WriteStringValue(valueTuple.Item2);
						writer.WriteEndArray();
					}
					writer.WriteEndArray();
				}
			}

			// Token: 0x0200D088 RID: 53384
			public class TaskGroupPatrol
			{
			}

			// Token: 0x0200D089 RID: 53385
			public class TaskGroupPerform
			{
			}

			// Token: 0x0200D08A RID: 53386
			public enum EActionType
			{
				// Token: 0x0403EA25 RID: 256549
				ActionAddBuff = 1,
				// Token: 0x0403EA26 RID: 256550
				ActionRemoveBuff,
				// Token: 0x0403EA27 RID: 256551
				ActionCastSkill,
				// Token: 0x0403EA28 RID: 256552
				ActionCancelSkill,
				// Token: 0x0403EA29 RID: 256553
				ActionResetStatus = 7,
				// Token: 0x0403EA2A RID: 256554
				ActionEnterFight,
				// Token: 0x0403EA2B RID: 256555
				ActionCastSkillByName,
				// Token: 0x0403EA2C RID: 256556
				ActionCancelSkillByName,
				// Token: 0x0403EA2D RID: 256557
				ActionInstChangeStateTag,
				// Token: 0x0403EA2E RID: 256558
				ActionResetPart,
				// Token: 0x0403EA2F RID: 256559
				ActionActivatePart,
				// Token: 0x0403EA30 RID: 256560
				ActionActivateSkillGroup,
				// Token: 0x0403EA31 RID: 256561
				ActionDispatchEvent,
				// Token: 0x0403EA32 RID: 256562
				ActionSetRageFullAttribute = 19,
				// Token: 0x0403EA33 RID: 256563
				ActionAddTagCount,
				// Token: 0x0403EA34 RID: 256564
				ActionRemoveTagCount,
				// Token: 0x0403EA35 RID: 256565
				ActionDispatchGameEvent,
				// Token: 0x0403EA36 RID: 256566
				ActionCue = 101,
				// Token: 0x0403EA37 RID: 256567
				ActionStopMontage,
				// Token: 0x0403EA38 RID: 256568
				ActionExitHit,
				// Token: 0x0403EA39 RID: 256569
				ActionSendGameplayEvent,
				// Token: 0x0403EA3A RID: 256570
				ActionCameraLockOn
			}

			// Token: 0x0200D08B RID: 53387
			[NullableContext(2)]
			[Nullable(0)]
			public class Action
			{
				// Token: 0x0403EA3B RID: 256571
				public int Type;

				// Token: 0x0403EA3C RID: 256572
				public CombatStateMachineDefine.Fsm.ActionAddBuff ActionAddBuff;

				// Token: 0x0403EA3D RID: 256573
				public CombatStateMachineDefine.Fsm.ActionRemoveBuff ActionRemoveBuff;

				// Token: 0x0403EA3E RID: 256574
				public CombatStateMachineDefine.Fsm.ActionCastSkill ActionCastSkill;

				// Token: 0x0403EA3F RID: 256575
				public CombatStateMachineDefine.Fsm.ActionCancelSkill ActionCancelSkill;

				// Token: 0x0403EA40 RID: 256576
				public CombatStateMachineDefine.Fsm.ActionResetStatus ActionResetStatus;

				// Token: 0x0403EA41 RID: 256577
				public CombatStateMachineDefine.Fsm.ActionEnterFight ActionEnterFight;

				// Token: 0x0403EA42 RID: 256578
				public CombatStateMachineDefine.Fsm.ActionCastSkillByName ActionCastSkillByName;

				// Token: 0x0403EA43 RID: 256579
				public CombatStateMachineDefine.Fsm.ActionCancelSkillByName ActionCancelSkillByName;

				// Token: 0x0403EA44 RID: 256580
				public CombatStateMachineDefine.Fsm.ActionInstChangeStateTag ActionInstChangeStateTag;

				// Token: 0x0403EA45 RID: 256581
				public CombatStateMachineDefine.Fsm.ActionResetPart ActionResetPart;

				// Token: 0x0403EA46 RID: 256582
				public CombatStateMachineDefine.Fsm.ActionActivatePart ActionActivatePart;

				// Token: 0x0403EA47 RID: 256583
				public CombatStateMachineDefine.Fsm.ActionActivateSkillGroup ActionActivateSkillGroup;

				// Token: 0x0403EA48 RID: 256584
				public CombatStateMachineDefine.Fsm.ActionDispatchEvent ActionDispatchEvent;

				// Token: 0x0403EA49 RID: 256585
				public CombatStateMachineDefine.Fsm.ActionCue ActionCue;

				// Token: 0x0403EA4A RID: 256586
				public CombatStateMachineDefine.Fsm.ActionStopMontage ActionStopMontage;

				// Token: 0x0403EA4B RID: 256587
				public CombatStateMachineDefine.Fsm.ActionExitHit ActionExitHit;

				// Token: 0x0403EA4C RID: 256588
				public CombatStateMachineDefine.Fsm.ActionSendGameplayEvent ActionSendGameplayEvent;

				// Token: 0x0403EA4D RID: 256589
				public CombatStateMachineDefine.Fsm.ActionSetRageFullAttribute ActionSetRageFullAttribute;

				// Token: 0x0403EA4E RID: 256590
				public CombatStateMachineDefine.Fsm.ActionAddTagCount ActionAddTagCount;

				// Token: 0x0403EA4F RID: 256591
				public CombatStateMachineDefine.Fsm.ActionRemoveTagCount ActionRemoveTagCount;

				// Token: 0x0403EA50 RID: 256592
				public CombatStateMachineDefine.Fsm.ActionDispatchGameEvent ActionDispatchGameEvent;

				// Token: 0x0403EA51 RID: 256593
				public CombatStateMachineDefine.Fsm.ActionCameraLockOn ActionCameraLockOn;

				// Token: 0x0403EA52 RID: 256594
				public string Name;
			}

			// Token: 0x0200D08C RID: 53388
			public class ActionAddBuff
			{
				// Token: 0x0403EA53 RID: 256595
				public long BuffId;
			}

			// Token: 0x0200D08D RID: 53389
			public class ActionRemoveBuff
			{
				// Token: 0x0403EA54 RID: 256596
				public long BuffId;
			}

			// Token: 0x0200D08E RID: 53390
			public class ActionCastSkill
			{
				// Token: 0x0403EA55 RID: 256597
				public int SkillId;
			}

			// Token: 0x0200D08F RID: 53391
			public class ActionCancelSkill
			{
				// Token: 0x0403EA56 RID: 256598
				public int SkillId;
			}

			// Token: 0x0200D090 RID: 53392
			public class ActionResetStatus
			{
			}

			// Token: 0x0200D091 RID: 53393
			public class ActionEnterFight
			{
			}

			// Token: 0x0200D092 RID: 53394
			public class ActionCastSkillByName
			{
				// Token: 0x0403EA57 RID: 256599
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200D093 RID: 53395
			public class ActionCancelSkillByName
			{
				// Token: 0x0403EA58 RID: 256600
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200D094 RID: 53396
			public class ActionInstChangeStateTag
			{
				// Token: 0x0403EA59 RID: 256601
				public int TagId;
			}

			// Token: 0x0200D095 RID: 53397
			public class ActionResetPart
			{
				// Token: 0x0403EA5A RID: 256602
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x0403EA5B RID: 256603
				public bool ResetActivate;

				// Token: 0x0403EA5C RID: 256604
				public bool ResetLife;
			}

			// Token: 0x0200D096 RID: 53398
			public class ActionActivatePart
			{
				// Token: 0x0403EA5D RID: 256605
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x0403EA5E RID: 256606
				public bool Activate;
			}

			// Token: 0x0200D097 RID: 53399
			public class ActionActivateSkillGroup
			{
				// Token: 0x0403EA5F RID: 256607
				public int ConfigId;

				// Token: 0x0403EA60 RID: 256608
				public bool Activate;
			}

			// Token: 0x0200D098 RID: 53400
			public class ActionDispatchEvent
			{
				// Token: 0x0403EA61 RID: 256609
				[Nullable(1)]
				public string Event = "";
			}

			// Token: 0x0200D099 RID: 53401
			public class ActionCue
			{
				// Token: 0x0403EA62 RID: 256610
				[Nullable(2)]
				public List<long> CueIds;

				// Token: 0x0403EA63 RID: 256611
				public int ConfigReplaceTagId;

				// Token: 0x0403EA64 RID: 256612
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200D09A RID: 53402
			public class ActionStopMontage
			{
				// Token: 0x0403EA65 RID: 256613
				public float BlendOutTime;
			}

			// Token: 0x0200D09B RID: 53403
			public class ActionExitHit
			{
			}

			// Token: 0x0200D09C RID: 53404
			public class ActionSendGameplayEvent
			{
				// Token: 0x0403EA66 RID: 256614
				public int TagId;
			}

			// Token: 0x0200D09D RID: 53405
			public class ActionSetRageFullAttribute
			{
			}

			// Token: 0x0200D09E RID: 53406
			public class ActionAddTagCount
			{
				// Token: 0x0403EA67 RID: 256615
				public int TagId;

				// Token: 0x0403EA68 RID: 256616
				public int Count;
			}

			// Token: 0x0200D09F RID: 53407
			public class ActionRemoveTagCount
			{
				// Token: 0x0403EA69 RID: 256617
				public int TagId;

				// Token: 0x0403EA6A RID: 256618
				public int Count;
			}

			// Token: 0x0200D0A0 RID: 53408
			public class ActionDispatchGameEvent
			{
			}

			// Token: 0x0200D0A1 RID: 53409
			public class ActionCameraLockOn
			{
				// Token: 0x0403EA6B RID: 256619
				public bool Enable;
			}

			// Token: 0x0200D0A2 RID: 53410
			public enum EStateType
			{
				// Token: 0x0403EA6D RID: 256621
				BindBuff = 1,
				// Token: 0x0403EA6E RID: 256622
				BindSkill,
				// Token: 0x0403EA6F RID: 256623
				BindTag,
				// Token: 0x0403EA70 RID: 256624
				BindSkillByName,
				// Token: 0x0403EA71 RID: 256625
				BindSkillCounter = 6,
				// Token: 0x0403EA72 RID: 256626
				BindDelaySuicide,
				// Token: 0x0403EA73 RID: 256627
				BindAiHateConfig = 102,
				// Token: 0x0403EA74 RID: 256628
				BindAiSenseEnable,
				// Token: 0x0403EA75 RID: 256629
				BindCue,
				// Token: 0x0403EA76 RID: 256630
				BindDisableActor,
				// Token: 0x0403EA77 RID: 256631
				BindBoneVisible = 108,
				// Token: 0x0403EA78 RID: 256632
				BindMeshVisible,
				// Token: 0x0403EA79 RID: 256633
				BindBoneCollision,
				// Token: 0x0403EA7A RID: 256634
				BindPartPanelVisible,
				// Token: 0x0403EA7B RID: 256635
				BindDeathMontage,
				// Token: 0x0403EA7C RID: 256636
				BindPalsy,
				// Token: 0x0403EA7D RID: 256637
				BindCollisionChannel,
				// Token: 0x0403EA7E RID: 256638
				BindDisableCollision,
				// Token: 0x0403EA7F RID: 256639
				BindDeathMontageByTag
			}

			// Token: 0x0200D0A3 RID: 53411
			[NullableContext(2)]
			[Nullable(0)]
			public class State
			{
				// Token: 0x0403EA80 RID: 256640
				public int Type;

				// Token: 0x0403EA81 RID: 256641
				public CombatStateMachineDefine.Fsm.BindBuff BindBuff;

				// Token: 0x0403EA82 RID: 256642
				public CombatStateMachineDefine.Fsm.BindSkill BindSkill;

				// Token: 0x0403EA83 RID: 256643
				public CombatStateMachineDefine.Fsm.BindTag BindTag;

				// Token: 0x0403EA84 RID: 256644
				public CombatStateMachineDefine.Fsm.BindSkillByName BindSkillByName;

				// Token: 0x0403EA85 RID: 256645
				public CombatStateMachineDefine.Fsm.BindSkillCounter BindSkillCounter;

				// Token: 0x0403EA86 RID: 256646
				public CombatStateMachineDefine.Fsm.BindDelaySuicide BindDelaySuicide;

				// Token: 0x0403EA87 RID: 256647
				public CombatStateMachineDefine.Fsm.BindAiHateConfig BindAiHateConfig;

				// Token: 0x0403EA88 RID: 256648
				public CombatStateMachineDefine.Fsm.BindAiSenseEnable BindAiSenseEnable;

				// Token: 0x0403EA89 RID: 256649
				public CombatStateMachineDefine.Fsm.BindCue BindCue;

				// Token: 0x0403EA8A RID: 256650
				public CombatStateMachineDefine.Fsm.BindDisableActor BindDisableActor;

				// Token: 0x0403EA8B RID: 256651
				public CombatStateMachineDefine.Fsm.BindLeaveFight BindLeaveFight;

				// Token: 0x0403EA8C RID: 256652
				public CombatStateMachineDefine.Fsm.BindMontage BindMontage;

				// Token: 0x0403EA8D RID: 256653
				public CombatStateMachineDefine.Fsm.BindBoneVisible BindBoneVisible;

				// Token: 0x0403EA8E RID: 256654
				public CombatStateMachineDefine.Fsm.BindMeshVisible BindMeshVisible;

				// Token: 0x0403EA8F RID: 256655
				public CombatStateMachineDefine.Fsm.BindBoneCollision BindBoneCollision;

				// Token: 0x0403EA90 RID: 256656
				public CombatStateMachineDefine.Fsm.BindPartPanelVisible BindPartPanelVisible;

				// Token: 0x0403EA91 RID: 256657
				public CombatStateMachineDefine.Fsm.BindDeathMontage BindDeathMontage;

				// Token: 0x0403EA92 RID: 256658
				public CombatStateMachineDefine.Fsm.BindPalsy BindPalsy;

				// Token: 0x0403EA93 RID: 256659
				public CombatStateMachineDefine.Fsm.BindCollisionChannel BindCollisionChannel;

				// Token: 0x0403EA94 RID: 256660
				public CombatStateMachineDefine.Fsm.BindDisableCollision BindDisableCollision;

				// Token: 0x0403EA95 RID: 256661
				public CombatStateMachineDefine.Fsm.BindDeathMontageByTag BindDeathMontageByTag;

				// Token: 0x0403EA96 RID: 256662
				public string Name;
			}

			// Token: 0x0200D0A4 RID: 53412
			public class BindBuff
			{
				// Token: 0x0403EA97 RID: 256663
				public long BuffId;
			}

			// Token: 0x0200D0A5 RID: 53413
			public class BindSkill
			{
				// Token: 0x0403EA98 RID: 256664
				public int SkillId;
			}

			// Token: 0x0200D0A6 RID: 53414
			public class BindTag
			{
				// Token: 0x0403EA99 RID: 256665
				public int TagId;
			}

			// Token: 0x0200D0A7 RID: 53415
			public class BindSkillByName
			{
				// Token: 0x0403EA9A RID: 256666
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200D0A8 RID: 53416
			public class BindSkillCounter
			{
				// Token: 0x0403EA9B RID: 256667
				[Nullable(2)]
				public int[] SkillIds;

				// Token: 0x0403EA9C RID: 256668
				[Nullable(1)]
				public string BlackboardKey = "";

				// Token: 0x0403EA9D RID: 256669
				public int AddValueMin;

				// Token: 0x0403EA9E RID: 256670
				public int AddValueMax;

				// Token: 0x0403EA9F RID: 256671
				public bool Reset;
			}

			// Token: 0x0200D0A9 RID: 53417
			public class BindDelaySuicide
			{
				// Token: 0x0403EAA0 RID: 256672
				public float SuicideDelay;

				// Token: 0x0403EAA1 RID: 256673
				public float DestroyDelay;
			}

			// Token: 0x0200D0AA RID: 53418
			public class BindActivateSkillGroup
			{
				// Token: 0x0403EAA2 RID: 256674
				public int ConfigId;
			}

			// Token: 0x0200D0AB RID: 53419
			public class BindAiHateConfig
			{
				// Token: 0x0403EAA3 RID: 256675
				public int ConfigId;
			}

			// Token: 0x0200D0AC RID: 53420
			public class BindAiSenseEnable
			{
				// Token: 0x0403EAA4 RID: 256676
				public int ConfigId;
			}

			// Token: 0x0200D0AD RID: 53421
			public class BindCue
			{
				// Token: 0x0403EAA5 RID: 256677
				[Nullable(2)]
				public List<long> CueIds;

				// Token: 0x0403EAA6 RID: 256678
				public bool HideOnLoading;

				// Token: 0x0403EAA7 RID: 256679
				public int ConfigReplaceTagId;

				// Token: 0x0403EAA8 RID: 256680
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200D0AE RID: 53422
			public class BindDisableActor
			{
			}

			// Token: 0x0200D0AF RID: 53423
			public class BindLeaveFight
			{
				// Token: 0x0403EAA9 RID: 256681
				public float RandomRadius;

				// Token: 0x0403EAAA RID: 256682
				public float MinWanderDistance;

				// Token: 0x0403EAAB RID: 256683
				public float MaxNavigationMillisecond;

				// Token: 0x0403EAAC RID: 256684
				public bool MoveStateForWanderOrReset;

				// Token: 0x0403EAAD RID: 256685
				public float MaxStopTime;

				// Token: 0x0403EAAE RID: 256686
				public float BlinkTime;

				// Token: 0x0403EAAF RID: 256687
				public bool UsePatrolPointPriority;
			}

			// Token: 0x0200D0B0 RID: 53424
			public class BindMontage
			{
				// Token: 0x0403EAB0 RID: 256688
				[Nullable(1)]
				public string MontageName = "";

				// Token: 0x0403EAB1 RID: 256689
				public bool HideOnLoading;
			}

			// Token: 0x0200D0B1 RID: 53425
			public class BindBoneVisible
			{
				// Token: 0x0403EAB2 RID: 256690
				[Nullable(1)]
				public string BoneName = "";

				// Token: 0x0403EAB3 RID: 256691
				public bool Visible;
			}

			// Token: 0x0200D0B2 RID: 53426
			public class BindMeshVisible
			{
				// Token: 0x0403EAB4 RID: 256692
				[Nullable(1)]
				public string Tag = "";

				// Token: 0x0403EAB5 RID: 256693
				public bool Visible;

				// Token: 0x0403EAB6 RID: 256694
				public bool PropagateToChildren;
			}

			// Token: 0x0200D0B3 RID: 53427
			public class BindBoneCollision
			{
				// Token: 0x0403EAB7 RID: 256695
				[Nullable(1)]
				public string BoneName = "";

				// Token: 0x0403EAB8 RID: 256696
				public bool IsBlockPawn;

				// Token: 0x0403EAB9 RID: 256697
				public bool IsBulletDetect;

				// Token: 0x0403EABA RID: 256698
				public bool IsBlockCamera;

				// Token: 0x0403EABB RID: 256699
				public bool IsBlockPawnOnExit;

				// Token: 0x0403EABC RID: 256700
				public bool IsBulletDetectOnExit;

				// Token: 0x0403EABD RID: 256701
				public bool IsBlockCameraOnExit;

				// Token: 0x0403EABE RID: 256702
				public bool IsActiveOcclusionDither;

				// Token: 0x0403EABF RID: 256703
				public bool IsActiveOcclusionDitherOnExit;
			}

			// Token: 0x0200D0B4 RID: 53428
			public class BindPartPanelVisible
			{
				// Token: 0x0403EAC0 RID: 256704
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x0403EAC1 RID: 256705
				public bool Visible;
			}

			// Token: 0x0200D0B5 RID: 53429
			public class BindDeathMontage
			{
				// Token: 0x0403EAC2 RID: 256706
				public int DeathType;

				// Token: 0x0403EAC3 RID: 256707
				[Nullable(1)]
				public string MontageName = "";
			}

			// Token: 0x0200D0B6 RID: 53430
			public class BindDeathMontageByTag
			{
				// Token: 0x0403EAC4 RID: 256708
				[Nullable(2)]
				public int[] MontageTagIds;

				// Token: 0x0403EAC5 RID: 256709
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public string[] MontageTagNames;

				// Token: 0x0403EAC6 RID: 256710
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public string[] TagMontageNames;
			}

			// Token: 0x0200D0B7 RID: 53431
			[NullableContext(1)]
			[Nullable(0)]
			public class BindPalsy
			{
				// Token: 0x0403EAC7 RID: 256711
				public string CounterAttackEffect = "";

				// Token: 0x0403EAC8 RID: 256712
				public string CounterAttackCamera = "";
			}

			// Token: 0x0200D0B8 RID: 53432
			public class BindCollisionChannel
			{
				// Token: 0x0403EAC9 RID: 256713
				[Nullable(2)]
				public List<int> IgnoreChannels;
			}

			// Token: 0x0200D0B9 RID: 53433
			public class BindDisableCollision
			{
			}

			// Token: 0x0200D0BA RID: 53434
			public enum EConditionType
			{
				// Token: 0x0403EACB RID: 256715
				CondAnd = 1,
				// Token: 0x0403EACC RID: 256716
				CondOr,
				// Token: 0x0403EACD RID: 256717
				CondTrue = 4,
				// Token: 0x0403EACE RID: 256718
				CondHpLessThan = 11,
				// Token: 0x0403EACF RID: 256719
				CondSkillEnd = 13,
				// Token: 0x0403EAD0 RID: 256720
				CondTag,
				// Token: 0x0403EAD1 RID: 256721
				CondBBValueCompare,
				// Token: 0x0403EAD2 RID: 256722
				CondAttrCompare,
				// Token: 0x0403EAD3 RID: 256723
				CondAttribute,
				// Token: 0x0403EAD4 RID: 256724
				CondAttributeRate,
				// Token: 0x0403EAD5 RID: 256725
				CondCheckState,
				// Token: 0x0403EAD6 RID: 256726
				CondHate,
				// Token: 0x0403EAD7 RID: 256727
				CondTimer = 22,
				// Token: 0x0403EAD8 RID: 256728
				CondWaitClient,
				// Token: 0x0403EAD9 RID: 256729
				CondCheckStateByName,
				// Token: 0x0403EADA RID: 256730
				CondInstStateChange,
				// Token: 0x0403EADB RID: 256731
				CondBuffStack,
				// Token: 0x0403EADC RID: 256732
				CondPartLife,
				// Token: 0x0403EADD RID: 256733
				CondCheckPartActivated,
				// Token: 0x0403EADE RID: 256734
				CondListenEvent,
				// Token: 0x0403EADF RID: 256735
				CondCheckLastState = 31,
				// Token: 0x0403EAE0 RID: 256736
				CondCheckDissolveCombine,
				// Token: 0x0403EAE1 RID: 256737
				CondTaskFinish = 101,
				// Token: 0x0403EAE2 RID: 256738
				CondMontageTimeRemaining,
				// Token: 0x0403EAE3 RID: 256739
				CondListenBeHit,
				// Token: 0x0403EAE4 RID: 256740
				CondHasMoveInput,
				// Token: 0x0403EAE5 RID: 256741
				CondMontageTimeElapsing,
				// Token: 0x0403EAE6 RID: 256742
				CondCheckGroupPatrol,
				// Token: 0x0403EAE7 RID: 256743
				CondCheckPositionState = 108,
				// Token: 0x0403EAE8 RID: 256744
				CondCheckGroupPerform
			}

			// Token: 0x0200D0BB RID: 53435
			[NullableContext(2)]
			[Nullable(0)]
			public class Condition
			{
				// Token: 0x0403EAE9 RID: 256745
				public int Type;

				// Token: 0x0403EAEA RID: 256746
				public bool Reverse;

				// Token: 0x0403EAEB RID: 256747
				public int Index;

				// Token: 0x0403EAEC RID: 256748
				public bool? IsClient;

				// Token: 0x0403EAED RID: 256749
				public CombatStateMachineDefine.Fsm.CondAnd CondAnd;

				// Token: 0x0403EAEE RID: 256750
				public CombatStateMachineDefine.Fsm.CondOr CondOr;

				// Token: 0x0403EAEF RID: 256751
				public CombatStateMachineDefine.Fsm.CondTrue CondTrue;

				// Token: 0x0403EAF0 RID: 256752
				public CombatStateMachineDefine.Fsm.CondHpLessThan CondHpLessThan;

				// Token: 0x0403EAF1 RID: 256753
				public CombatStateMachineDefine.Fsm.CondSkillEnd CondSkillEnd;

				// Token: 0x0403EAF2 RID: 256754
				public CombatStateMachineDefine.Fsm.CondTag CondTag;

				// Token: 0x0403EAF3 RID: 256755
				public CombatStateMachineDefine.Fsm.CondBBValueCompare CondBBValueCompare;

				// Token: 0x0403EAF4 RID: 256756
				public CombatStateMachineDefine.Fsm.CondAttrCompare CondAttrCompare;

				// Token: 0x0403EAF5 RID: 256757
				public CombatStateMachineDefine.Fsm.CondAttribute CondAttribute;

				// Token: 0x0403EAF6 RID: 256758
				public CombatStateMachineDefine.Fsm.CondAttributeRate CondAttributeRate;

				// Token: 0x0403EAF7 RID: 256759
				public CombatStateMachineDefine.Fsm.CondCheckState CondCheckState;

				// Token: 0x0403EAF8 RID: 256760
				public CombatStateMachineDefine.Fsm.CondHate CondHate;

				// Token: 0x0403EAF9 RID: 256761
				public CombatStateMachineDefine.Fsm.CondTimer CondTimer;

				// Token: 0x0403EAFA RID: 256762
				public CombatStateMachineDefine.Fsm.CondWaitClient CondWaitClient;

				// Token: 0x0403EAFB RID: 256763
				public CombatStateMachineDefine.Fsm.CondCheckStateByName CondCheckStateByName;

				// Token: 0x0403EAFC RID: 256764
				public CombatStateMachineDefine.Fsm.CondInstStateChange CondInstStateChange;

				// Token: 0x0403EAFD RID: 256765
				public CombatStateMachineDefine.Fsm.CondBuffStack CondBuffStack;

				// Token: 0x0403EAFE RID: 256766
				public CombatStateMachineDefine.Fsm.CondPartLife CondPartLife;

				// Token: 0x0403EAFF RID: 256767
				public CombatStateMachineDefine.Fsm.CondCheckPartActivated CondCheckPartActivated;

				// Token: 0x0403EB00 RID: 256768
				public CombatStateMachineDefine.Fsm.CondListenEvent CondListenEvent;

				// Token: 0x0403EB01 RID: 256769
				public CombatStateMachineDefine.Fsm.CondCheckPositionState CondCheckPositionState;

				// Token: 0x0403EB02 RID: 256770
				public CombatStateMachineDefine.Fsm.CondTaskFinish CondTaskFinish;

				// Token: 0x0403EB03 RID: 256771
				public CombatStateMachineDefine.Fsm.CondMontageTimeRemaining CondMontageTimeRemaining;

				// Token: 0x0403EB04 RID: 256772
				public CombatStateMachineDefine.Fsm.CondListenBeHit CondListenBeHit;

				// Token: 0x0403EB05 RID: 256773
				public CombatStateMachineDefine.Fsm.CondHasMoveInput CondHasMoveInput;

				// Token: 0x0403EB06 RID: 256774
				public CombatStateMachineDefine.Fsm.CondMontageTimeElapsing CondMontageTimeElapsing;

				// Token: 0x0403EB07 RID: 256775
				public CombatStateMachineDefine.Fsm.CondCheckGroupPatrol CondCheckGroupPatrol;

				// Token: 0x0403EB08 RID: 256776
				public CombatStateMachineDefine.Fsm.CondCheckGroupPerform CondCheckGroupPerform;

				// Token: 0x0403EB09 RID: 256777
				public CombatStateMachineDefine.Fsm.CondCheckLastState CondCheckLastState;

				// Token: 0x0403EB0A RID: 256778
				public CombatStateMachineDefine.Fsm.CondCheckDissolveCombine CondCheckDissolveCombine;

				// Token: 0x0403EB0B RID: 256779
				public string Name;
			}

			// Token: 0x0200D0BC RID: 53436
			public class CondAnd
			{
				// Token: 0x0403EB0C RID: 256780
				[Nullable(2)]
				public List<int> Conditions;
			}

			// Token: 0x0200D0BD RID: 53437
			public class CondOr
			{
				// Token: 0x0403EB0D RID: 256781
				[Nullable(2)]
				public List<int> Conditions;
			}

			// Token: 0x0200D0BE RID: 53438
			public class CondTrue
			{
			}

			// Token: 0x0200D0BF RID: 53439
			public class CondHpLessThan
			{
				// Token: 0x0403EB0E RID: 256782
				public float HpRatio;
			}

			// Token: 0x0200D0C0 RID: 53440
			public class CondSkillEnd
			{
			}

			// Token: 0x0200D0C1 RID: 53441
			public class CondTag
			{
				// Token: 0x0403EB0F RID: 256783
				public int TagId;

				// Token: 0x0403EB10 RID: 256784
				[Nullable(1)]
				public string TagName = "";
			}

			// Token: 0x0200D0C2 RID: 53442
			public class CondBBValueCompare
			{
				// Token: 0x0403EB11 RID: 256785
				public int Key1;

				// Token: 0x0403EB12 RID: 256786
				public int Key2;

				// Token: 0x0403EB13 RID: 256787
				public int Compare;
			}

			// Token: 0x0200D0C3 RID: 53443
			public class CondAttrCompare
			{
				// Token: 0x0403EB14 RID: 256788
				public int Attr1;

				// Token: 0x0403EB15 RID: 256789
				public int Attr2;

				// Token: 0x0403EB16 RID: 256790
				public int Compare;
			}

			// Token: 0x0200D0C4 RID: 53444
			public class CondAttribute
			{
				// Token: 0x0403EB17 RID: 256791
				public int AttributeId;

				// Token: 0x0403EB18 RID: 256792
				public float Min;

				// Token: 0x0403EB19 RID: 256793
				public float Max;
			}

			// Token: 0x0200D0C5 RID: 53445
			public class CondAttributeRate
			{
				// Token: 0x0403EB1A RID: 256794
				public int AttributeId;

				// Token: 0x0403EB1B RID: 256795
				public float Denominator;

				// Token: 0x0403EB1C RID: 256796
				public float Min;

				// Token: 0x0403EB1D RID: 256797
				public float Max;
			}

			// Token: 0x0200D0C6 RID: 53446
			public class CondCheckState
			{
				// Token: 0x0403EB1E RID: 256798
				public int TargetState;
			}

			// Token: 0x0200D0C7 RID: 53447
			public class CondHate
			{
			}

			// Token: 0x0200D0C8 RID: 53448
			public class CondTimer
			{
				// Token: 0x0403EB1F RID: 256799
				public float MinTime;

				// Token: 0x0403EB20 RID: 256800
				public float MaxTime;
			}

			// Token: 0x0200D0C9 RID: 53449
			public class CondWaitClient
			{
			}

			// Token: 0x0200D0CA RID: 53450
			public class CondCheckStateByName
			{
				// Token: 0x0403EB21 RID: 256801
				[Nullable(1)]
				public string TargetStateName = "";
			}

			// Token: 0x0200D0CB RID: 53451
			public class CondInstStateChange
			{
				// Token: 0x0403EB22 RID: 256802
				public int TagId;
			}

			// Token: 0x0200D0CC RID: 53452
			public class CondBuffStack
			{
				// Token: 0x0403EB23 RID: 256803
				public long BuffId;

				// Token: 0x0403EB24 RID: 256804
				public int MinStack;

				// Token: 0x0403EB25 RID: 256805
				public int MaxStack;
			}

			// Token: 0x0200D0CD RID: 53453
			public class CondPartLife
			{
				// Token: 0x0403EB26 RID: 256806
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x0403EB27 RID: 256807
				public bool CheckRate;

				// Token: 0x0403EB28 RID: 256808
				public float Min;

				// Token: 0x0403EB29 RID: 256809
				public float Max;
			}

			// Token: 0x0200D0CE RID: 53454
			public class CondCheckPartActivated
			{
				// Token: 0x0403EB2A RID: 256810
				[Nullable(1)]
				public string PartName = "";
			}

			// Token: 0x0200D0CF RID: 53455
			public class CondListenEvent
			{
				// Token: 0x0403EB2B RID: 256811
				[Nullable(1)]
				public string Event = "";
			}

			// Token: 0x0200D0D0 RID: 53456
			public class CondCheckPositionState
			{
				// Token: 0x0403EB2C RID: 256812
				public int PositionState;
			}

			// Token: 0x0200D0D1 RID: 53457
			public class CondTaskFinish
			{
			}

			// Token: 0x0200D0D2 RID: 53458
			public class CondMontageTimeRemaining
			{
				// Token: 0x0403EB2D RID: 256813
				public float Time;
			}

			// Token: 0x0200D0D3 RID: 53459
			public class CondListenBeHit
			{
				// Token: 0x0403EB2E RID: 256814
				public bool NoHitAnimation;

				// Token: 0x0403EB2F RID: 256815
				public bool SoftKnock;

				// Token: 0x0403EB30 RID: 256816
				public bool HeavyKnock;

				// Token: 0x0403EB31 RID: 256817
				public bool KnockUp;

				// Token: 0x0403EB32 RID: 256818
				public bool KnockDown;

				// Token: 0x0403EB33 RID: 256819
				public bool Parry;

				// Token: 0x0403EB34 RID: 256820
				public bool BreakWeakness;

				// Token: 0x0403EB35 RID: 256821
				public int VisionCounterAttackId;
			}

			// Token: 0x0200D0D4 RID: 53460
			public class CondHasMoveInput
			{
			}

			// Token: 0x0200D0D5 RID: 53461
			public class CondCheckGroupPatrol
			{
			}

			// Token: 0x0200D0D6 RID: 53462
			public class CondCheckGroupPerform
			{
			}

			// Token: 0x0200D0D7 RID: 53463
			public class CondMontageTimeElapsing
			{
				// Token: 0x0403EB36 RID: 256822
				public float Time;
			}

			// Token: 0x0200D0D8 RID: 53464
			public class CondCheckLastState
			{
				// Token: 0x0403EB37 RID: 256823
				[Nullable(1)]
				public string TargetStateName = "";
			}

			// Token: 0x0200D0D9 RID: 53465
			public class CondCheckDissolveCombine
			{
			}

			// Token: 0x0200D0DA RID: 53466
			public enum ETransitionPredictionType
			{
				// Token: 0x0403EB39 RID: 256825
				Server,
				// Token: 0x0403EB3A RID: 256826
				Autonomous,
				// Token: 0x0403EB3B RID: 256827
				Simulated
			}

			// Token: 0x0200D0DB RID: 53467
			public class Transition
			{
				// Token: 0x0403EB3C RID: 256828
				public int From;

				// Token: 0x0403EB3D RID: 256829
				public int To;

				// Token: 0x0403EB3E RID: 256830
				public CombatStateMachineDefine.Fsm.ETransitionPredictionType? TransitionPredictionType;

				// Token: 0x0403EB3F RID: 256831
				public int Weight;

				// Token: 0x0403EB40 RID: 256832
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Condition> Conditions;
			}

			// Token: 0x0200D0DC RID: 53468
			public enum ETakeControlType
			{
				// Token: 0x0403EB42 RID: 256834
				Default,
				// Token: 0x0403EB43 RID: 256835
				ReEnter
			}

			// Token: 0x0200D0DD RID: 53469
			public enum ETransitionRule
			{
				// Token: 0x0403EB45 RID: 256837
				Priority,
				// Token: 0x0403EB46 RID: 256838
				Weight
			}

			// Token: 0x0200D0DE RID: 53470
			[NullableContext(2)]
			[Nullable(0)]
			public class Node
			{
				// Token: 0x0403EB47 RID: 256839
				public int Uuid;

				// Token: 0x0403EB48 RID: 256840
				public int? ReferenceUuid;

				// Token: 0x0403EB49 RID: 256841
				public int? OverrideCommonUuid;

				// Token: 0x0403EB4A RID: 256842
				public bool IsAnimStateMachine;

				// Token: 0x0403EB4B RID: 256843
				public bool IsConduitNode;

				// Token: 0x0403EB4C RID: 256844
				public bool IsAnyState;

				// Token: 0x0403EB4D RID: 256845
				[Nullable(1)]
				public string Name = "";

				// Token: 0x0403EB4E RID: 256846
				public CombatStateMachineDefine.Fsm.ETakeControlType TakeControlType;

				// Token: 0x0403EB4F RID: 256847
				public CombatStateMachineDefine.Fsm.ETransitionRule TransitionRule;

				// Token: 0x0403EB50 RID: 256848
				public CombatStateMachineDefine.Fsm.Task Task;

				// Token: 0x0403EB51 RID: 256849
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.State> BindStates;

				// Token: 0x0403EB52 RID: 256850
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Action> OnEnterActions;

				// Token: 0x0403EB53 RID: 256851
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Action> OnExitActions;

				// Token: 0x0403EB54 RID: 256852
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Transition> Transitions;

				// Token: 0x0403EB55 RID: 256853
				public List<int> Children;
			}

			// Token: 0x0200D0DF RID: 53471
			public class StateMachineGroup
			{
				// Token: 0x0403EB56 RID: 256854
				public int? Version;

				// Token: 0x0403EB57 RID: 256855
				[Nullable(2)]
				public List<int> StateMachines;

				// Token: 0x0403EB58 RID: 256856
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Node> Nodes;
			}
		}
	}
}
