using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Utils.CombatStateMachine
{
	// Token: 0x020034A7 RID: 13479
	public class CombatStateMachineDefine
	{
		// Token: 0x020091E0 RID: 37344
		public static class Fsm
		{
			// Token: 0x0200BC5A RID: 48218
			public enum EFsmSyncKey
			{
				// Token: 0x04039E35 RID: 237109
				RandomMontageIndex = 1,
				// Token: 0x04039E36 RID: 237110
				MoveToTarget
			}

			// Token: 0x0200BC5B RID: 48219
			public enum ETaskType
			{
				// Token: 0x04039E38 RID: 237112
				TaskSkill = 1,
				// Token: 0x04039E39 RID: 237113
				TaskSkillByName,
				// Token: 0x04039E3A RID: 237114
				TaskRandomMontage,
				// Token: 0x04039E3B RID: 237115
				TaskLeaveFight = 101,
				// Token: 0x04039E3C RID: 237116
				TaskMontage,
				// Token: 0x04039E3D RID: 237117
				TaskMoveToTarget,
				// Token: 0x04039E3E RID: 237118
				TaskPatrol,
				// Token: 0x04039E3F RID: 237119
				TaskBeHitMontage,
				// Token: 0x04039E40 RID: 237120
				TaskGroupPatrol,
				// Token: 0x04039E41 RID: 237121
				TaskGroupPerform
			}

			// Token: 0x0200BC5C RID: 48220
			[NullableContext(2)]
			[Nullable(0)]
			public class Task
			{
				// Token: 0x04039E42 RID: 237122
				public int Type;

				// Token: 0x04039E43 RID: 237123
				public bool CanBeInterrupt;

				// Token: 0x04039E44 RID: 237124
				public CombatStateMachineDefine.Fsm.TaskSkill TaskSkill;

				// Token: 0x04039E45 RID: 237125
				public CombatStateMachineDefine.Fsm.TaskSkillByName TaskSkillByName;

				// Token: 0x04039E46 RID: 237126
				public CombatStateMachineDefine.Fsm.TaskRandomMontage TaskRandomMontage;

				// Token: 0x04039E47 RID: 237127
				public CombatStateMachineDefine.Fsm.TaskLeaveFight TaskLeaveFight;

				// Token: 0x04039E48 RID: 237128
				public CombatStateMachineDefine.Fsm.TaskMontage TaskMontage;

				// Token: 0x04039E49 RID: 237129
				public CombatStateMachineDefine.Fsm.TaskMoveToTarget TaskMoveToTarget;

				// Token: 0x04039E4A RID: 237130
				public CombatStateMachineDefine.Fsm.TaskPatrol TaskPatrol;

				// Token: 0x04039E4B RID: 237131
				public CombatStateMachineDefine.Fsm.TaskBeHitMontage TaskBeHitMontage;

				// Token: 0x04039E4C RID: 237132
				public CombatStateMachineDefine.Fsm.TaskGroupPatrol TaskGroupPatrol;

				// Token: 0x04039E4D RID: 237133
				public CombatStateMachineDefine.Fsm.TaskGroupPerform TaskGroupPerform;

				// Token: 0x04039E4E RID: 237134
				public string Name;
			}

			// Token: 0x0200BC5D RID: 48221
			public class TaskSkill
			{
				// Token: 0x04039E4F RID: 237135
				public int SkillId;

				// Token: 0x04039E50 RID: 237136
				public int ConfigReplaceTagId;

				// Token: 0x04039E51 RID: 237137
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200BC5E RID: 48222
			[NullableContext(1)]
			[Nullable(0)]
			public class TaskSkillByName
			{
				// Token: 0x04039E52 RID: 237138
				public string SkillName = "";

				// Token: 0x04039E53 RID: 237139
				public int ConfigReplaceTagId;

				// Token: 0x04039E54 RID: 237140
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200BC5F RID: 48223
			public class TaskRandomMontage
			{
				// Token: 0x04039E55 RID: 237141
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<string> MontageNames;

				// Token: 0x04039E56 RID: 237142
				public bool HideOnLoading;

				// Token: 0x04039E57 RID: 237143
				public float BlendInTime;

				// Token: 0x04039E58 RID: 237144
				public bool RandomByClient;
			}

			// Token: 0x0200BC60 RID: 48224
			public class TaskLeaveFight
			{
				// Token: 0x04039E59 RID: 237145
				public float BlinkTime;

				// Token: 0x04039E5A RID: 237146
				public float MaxStopTime;

				// Token: 0x04039E5B RID: 237147
				public bool UsePatrolPointPriority;
			}

			// Token: 0x0200BC61 RID: 48225
			[NullableContext(1)]
			[Nullable(0)]
			public class TaskMontage
			{
				// Token: 0x04039E5C RID: 237148
				public string MontageName = "";

				// Token: 0x04039E5D RID: 237149
				public bool HideOnLoading;

				// Token: 0x04039E5E RID: 237150
				public float BlendInTime;

				// Token: 0x04039E5F RID: 237151
				public bool ForcePush2Server;

				// Token: 0x04039E60 RID: 237152
				public int ConfigReplaceTagId;

				// Token: 0x04039E61 RID: 237153
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200BC62 RID: 48226
			public class TaskMoveToTarget
			{
				// Token: 0x04039E62 RID: 237154
				public int TargetType;

				// Token: 0x04039E63 RID: 237155
				public int MoveState;

				// Token: 0x04039E64 RID: 237156
				public float EndDistance;

				// Token: 0x04039E65 RID: 237157
				public float TurnSpeed;

				// Token: 0x04039E66 RID: 237158
				public bool WalkOff;
			}

			// Token: 0x0200BC63 RID: 48227
			public class TaskPatrol
			{
				// Token: 0x04039E67 RID: 237159
				public int MoveState;

				// Token: 0x04039E68 RID: 237160
				public bool OpenDebugMode;
			}

			// Token: 0x0200BC64 RID: 48228
			public class TaskBeHitMontage
			{
				// Token: 0x04039E69 RID: 237161
				[Nullable(1)]
				public string DefaultMontageName = "";

				// Token: 0x04039E6A RID: 237162
				[Nullable(new byte[]
				{
					1,
					0,
					1
				})]
				[JsonConverter(typeof(CombatStateMachineDefine.Fsm.MontageMapConverter))]
				public List<ValueTuple<int, string>> MontageMap = new List<ValueTuple<int, string>>();

				// Token: 0x04039E6B RID: 237163
				public float BlendInTime;
			}

			// Token: 0x0200BC65 RID: 48229
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
				// Token: 0x06048C50 RID: 298064 RVA: 0x0162FE18 File Offset: 0x0162E018
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

				// Token: 0x06048C51 RID: 298065 RVA: 0x0162FE98 File Offset: 0x0162E098
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

			// Token: 0x0200BC66 RID: 48230
			public class TaskGroupPatrol
			{
			}

			// Token: 0x0200BC67 RID: 48231
			public class TaskGroupPerform
			{
			}

			// Token: 0x0200BC68 RID: 48232
			public enum EActionType
			{
				// Token: 0x04039E6D RID: 237165
				ActionAddBuff = 1,
				// Token: 0x04039E6E RID: 237166
				ActionRemoveBuff,
				// Token: 0x04039E6F RID: 237167
				ActionCastSkill,
				// Token: 0x04039E70 RID: 237168
				ActionCancelSkill,
				// Token: 0x04039E71 RID: 237169
				ActionResetStatus = 7,
				// Token: 0x04039E72 RID: 237170
				ActionEnterFight,
				// Token: 0x04039E73 RID: 237171
				ActionCastSkillByName,
				// Token: 0x04039E74 RID: 237172
				ActionCancelSkillByName,
				// Token: 0x04039E75 RID: 237173
				ActionInstChangeStateTag,
				// Token: 0x04039E76 RID: 237174
				ActionResetPart,
				// Token: 0x04039E77 RID: 237175
				ActionActivatePart,
				// Token: 0x04039E78 RID: 237176
				ActionActivateSkillGroup,
				// Token: 0x04039E79 RID: 237177
				ActionDispatchEvent,
				// Token: 0x04039E7A RID: 237178
				ActionSetRageFullAttribute = 19,
				// Token: 0x04039E7B RID: 237179
				ActionAddTagCount,
				// Token: 0x04039E7C RID: 237180
				ActionRemoveTagCount,
				// Token: 0x04039E7D RID: 237181
				ActionDispatchGameEvent,
				// Token: 0x04039E7E RID: 237182
				ActionCue = 101,
				// Token: 0x04039E7F RID: 237183
				ActionStopMontage,
				// Token: 0x04039E80 RID: 237184
				ActionExitHit,
				// Token: 0x04039E81 RID: 237185
				ActionSendGameplayEvent,
				// Token: 0x04039E82 RID: 237186
				ActionCameraLockOn
			}

			// Token: 0x0200BC69 RID: 48233
			[NullableContext(2)]
			[Nullable(0)]
			public class Action
			{
				// Token: 0x04039E83 RID: 237187
				public int Type;

				// Token: 0x04039E84 RID: 237188
				public CombatStateMachineDefine.Fsm.ActionAddBuff ActionAddBuff;

				// Token: 0x04039E85 RID: 237189
				public CombatStateMachineDefine.Fsm.ActionRemoveBuff ActionRemoveBuff;

				// Token: 0x04039E86 RID: 237190
				public CombatStateMachineDefine.Fsm.ActionCastSkill ActionCastSkill;

				// Token: 0x04039E87 RID: 237191
				public CombatStateMachineDefine.Fsm.ActionCancelSkill ActionCancelSkill;

				// Token: 0x04039E88 RID: 237192
				public CombatStateMachineDefine.Fsm.ActionResetStatus ActionResetStatus;

				// Token: 0x04039E89 RID: 237193
				public CombatStateMachineDefine.Fsm.ActionEnterFight ActionEnterFight;

				// Token: 0x04039E8A RID: 237194
				public CombatStateMachineDefine.Fsm.ActionCastSkillByName ActionCastSkillByName;

				// Token: 0x04039E8B RID: 237195
				public CombatStateMachineDefine.Fsm.ActionCancelSkillByName ActionCancelSkillByName;

				// Token: 0x04039E8C RID: 237196
				public CombatStateMachineDefine.Fsm.ActionInstChangeStateTag ActionInstChangeStateTag;

				// Token: 0x04039E8D RID: 237197
				public CombatStateMachineDefine.Fsm.ActionResetPart ActionResetPart;

				// Token: 0x04039E8E RID: 237198
				public CombatStateMachineDefine.Fsm.ActionActivatePart ActionActivatePart;

				// Token: 0x04039E8F RID: 237199
				public CombatStateMachineDefine.Fsm.ActionActivateSkillGroup ActionActivateSkillGroup;

				// Token: 0x04039E90 RID: 237200
				public CombatStateMachineDefine.Fsm.ActionDispatchEvent ActionDispatchEvent;

				// Token: 0x04039E91 RID: 237201
				public CombatStateMachineDefine.Fsm.ActionCue ActionCue;

				// Token: 0x04039E92 RID: 237202
				public CombatStateMachineDefine.Fsm.ActionStopMontage ActionStopMontage;

				// Token: 0x04039E93 RID: 237203
				public CombatStateMachineDefine.Fsm.ActionExitHit ActionExitHit;

				// Token: 0x04039E94 RID: 237204
				public CombatStateMachineDefine.Fsm.ActionSendGameplayEvent ActionSendGameplayEvent;

				// Token: 0x04039E95 RID: 237205
				public CombatStateMachineDefine.Fsm.ActionSetRageFullAttribute ActionSetRageFullAttribute;

				// Token: 0x04039E96 RID: 237206
				public CombatStateMachineDefine.Fsm.ActionAddTagCount ActionAddTagCount;

				// Token: 0x04039E97 RID: 237207
				public CombatStateMachineDefine.Fsm.ActionRemoveTagCount ActionRemoveTagCount;

				// Token: 0x04039E98 RID: 237208
				public CombatStateMachineDefine.Fsm.ActionDispatchGameEvent ActionDispatchGameEvent;

				// Token: 0x04039E99 RID: 237209
				public CombatStateMachineDefine.Fsm.ActionCameraLockOn ActionCameraLockOn;

				// Token: 0x04039E9A RID: 237210
				public string Name;
			}

			// Token: 0x0200BC6A RID: 48234
			public class ActionAddBuff
			{
				// Token: 0x04039E9B RID: 237211
				public long BuffId;
			}

			// Token: 0x0200BC6B RID: 48235
			public class ActionRemoveBuff
			{
				// Token: 0x04039E9C RID: 237212
				public long BuffId;
			}

			// Token: 0x0200BC6C RID: 48236
			public class ActionCastSkill
			{
				// Token: 0x04039E9D RID: 237213
				public int SkillId;
			}

			// Token: 0x0200BC6D RID: 48237
			public class ActionCancelSkill
			{
				// Token: 0x04039E9E RID: 237214
				public int SkillId;
			}

			// Token: 0x0200BC6E RID: 48238
			public class ActionResetStatus
			{
			}

			// Token: 0x0200BC6F RID: 48239
			public class ActionEnterFight
			{
			}

			// Token: 0x0200BC70 RID: 48240
			public class ActionCastSkillByName
			{
				// Token: 0x04039E9F RID: 237215
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200BC71 RID: 48241
			public class ActionCancelSkillByName
			{
				// Token: 0x04039EA0 RID: 237216
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200BC72 RID: 48242
			public class ActionInstChangeStateTag
			{
				// Token: 0x04039EA1 RID: 237217
				public int TagId;
			}

			// Token: 0x0200BC73 RID: 48243
			public class ActionResetPart
			{
				// Token: 0x04039EA2 RID: 237218
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x04039EA3 RID: 237219
				public bool ResetActivate;

				// Token: 0x04039EA4 RID: 237220
				public bool ResetLife;
			}

			// Token: 0x0200BC74 RID: 48244
			public class ActionActivatePart
			{
				// Token: 0x04039EA5 RID: 237221
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x04039EA6 RID: 237222
				public bool Activate;
			}

			// Token: 0x0200BC75 RID: 48245
			public class ActionActivateSkillGroup
			{
				// Token: 0x04039EA7 RID: 237223
				public int ConfigId;

				// Token: 0x04039EA8 RID: 237224
				public bool Activate;
			}

			// Token: 0x0200BC76 RID: 48246
			public class ActionDispatchEvent
			{
				// Token: 0x04039EA9 RID: 237225
				[Nullable(1)]
				public string Event = "";
			}

			// Token: 0x0200BC77 RID: 48247
			public class ActionCue
			{
				// Token: 0x04039EAA RID: 237226
				[Nullable(2)]
				public List<long> CueIds;

				// Token: 0x04039EAB RID: 237227
				public int ConfigReplaceTagId;

				// Token: 0x04039EAC RID: 237228
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200BC78 RID: 48248
			public class ActionStopMontage
			{
				// Token: 0x04039EAD RID: 237229
				public float BlendOutTime;
			}

			// Token: 0x0200BC79 RID: 48249
			public class ActionExitHit
			{
			}

			// Token: 0x0200BC7A RID: 48250
			public class ActionSendGameplayEvent
			{
				// Token: 0x04039EAE RID: 237230
				public int TagId;
			}

			// Token: 0x0200BC7B RID: 48251
			public class ActionSetRageFullAttribute
			{
			}

			// Token: 0x0200BC7C RID: 48252
			public class ActionAddTagCount
			{
				// Token: 0x04039EAF RID: 237231
				public int TagId;

				// Token: 0x04039EB0 RID: 237232
				public int Count;
			}

			// Token: 0x0200BC7D RID: 48253
			public class ActionRemoveTagCount
			{
				// Token: 0x04039EB1 RID: 237233
				public int TagId;

				// Token: 0x04039EB2 RID: 237234
				public int Count;
			}

			// Token: 0x0200BC7E RID: 48254
			public class ActionDispatchGameEvent
			{
			}

			// Token: 0x0200BC7F RID: 48255
			public class ActionCameraLockOn
			{
				// Token: 0x04039EB3 RID: 237235
				public bool Enable;
			}

			// Token: 0x0200BC80 RID: 48256
			public enum EStateType
			{
				// Token: 0x04039EB5 RID: 237237
				BindBuff = 1,
				// Token: 0x04039EB6 RID: 237238
				BindSkill,
				// Token: 0x04039EB7 RID: 237239
				BindTag,
				// Token: 0x04039EB8 RID: 237240
				BindSkillByName,
				// Token: 0x04039EB9 RID: 237241
				BindSkillCounter = 6,
				// Token: 0x04039EBA RID: 237242
				BindDelaySuicide,
				// Token: 0x04039EBB RID: 237243
				BindAiHateConfig = 102,
				// Token: 0x04039EBC RID: 237244
				BindAiSenseEnable,
				// Token: 0x04039EBD RID: 237245
				BindCue,
				// Token: 0x04039EBE RID: 237246
				BindDisableActor,
				// Token: 0x04039EBF RID: 237247
				BindBoneVisible = 108,
				// Token: 0x04039EC0 RID: 237248
				BindMeshVisible,
				// Token: 0x04039EC1 RID: 237249
				BindBoneCollision,
				// Token: 0x04039EC2 RID: 237250
				BindPartPanelVisible,
				// Token: 0x04039EC3 RID: 237251
				BindDeathMontage,
				// Token: 0x04039EC4 RID: 237252
				BindPalsy,
				// Token: 0x04039EC5 RID: 237253
				BindCollisionChannel,
				// Token: 0x04039EC6 RID: 237254
				BindDisableCollision,
				// Token: 0x04039EC7 RID: 237255
				BindDeathMontageByTag
			}

			// Token: 0x0200BC81 RID: 48257
			[NullableContext(2)]
			[Nullable(0)]
			public class State
			{
				// Token: 0x04039EC8 RID: 237256
				public int Type;

				// Token: 0x04039EC9 RID: 237257
				public CombatStateMachineDefine.Fsm.BindBuff BindBuff;

				// Token: 0x04039ECA RID: 237258
				public CombatStateMachineDefine.Fsm.BindSkill BindSkill;

				// Token: 0x04039ECB RID: 237259
				public CombatStateMachineDefine.Fsm.BindTag BindTag;

				// Token: 0x04039ECC RID: 237260
				public CombatStateMachineDefine.Fsm.BindSkillByName BindSkillByName;

				// Token: 0x04039ECD RID: 237261
				public CombatStateMachineDefine.Fsm.BindSkillCounter BindSkillCounter;

				// Token: 0x04039ECE RID: 237262
				public CombatStateMachineDefine.Fsm.BindDelaySuicide BindDelaySuicide;

				// Token: 0x04039ECF RID: 237263
				public CombatStateMachineDefine.Fsm.BindAiHateConfig BindAiHateConfig;

				// Token: 0x04039ED0 RID: 237264
				public CombatStateMachineDefine.Fsm.BindAiSenseEnable BindAiSenseEnable;

				// Token: 0x04039ED1 RID: 237265
				public CombatStateMachineDefine.Fsm.BindCue BindCue;

				// Token: 0x04039ED2 RID: 237266
				public CombatStateMachineDefine.Fsm.BindDisableActor BindDisableActor;

				// Token: 0x04039ED3 RID: 237267
				public CombatStateMachineDefine.Fsm.BindLeaveFight BindLeaveFight;

				// Token: 0x04039ED4 RID: 237268
				public CombatStateMachineDefine.Fsm.BindMontage BindMontage;

				// Token: 0x04039ED5 RID: 237269
				public CombatStateMachineDefine.Fsm.BindBoneVisible BindBoneVisible;

				// Token: 0x04039ED6 RID: 237270
				public CombatStateMachineDefine.Fsm.BindMeshVisible BindMeshVisible;

				// Token: 0x04039ED7 RID: 237271
				public CombatStateMachineDefine.Fsm.BindBoneCollision BindBoneCollision;

				// Token: 0x04039ED8 RID: 237272
				public CombatStateMachineDefine.Fsm.BindPartPanelVisible BindPartPanelVisible;

				// Token: 0x04039ED9 RID: 237273
				public CombatStateMachineDefine.Fsm.BindDeathMontage BindDeathMontage;

				// Token: 0x04039EDA RID: 237274
				public CombatStateMachineDefine.Fsm.BindPalsy BindPalsy;

				// Token: 0x04039EDB RID: 237275
				public CombatStateMachineDefine.Fsm.BindCollisionChannel BindCollisionChannel;

				// Token: 0x04039EDC RID: 237276
				public CombatStateMachineDefine.Fsm.BindDisableCollision BindDisableCollision;

				// Token: 0x04039EDD RID: 237277
				public CombatStateMachineDefine.Fsm.BindDeathMontageByTag BindDeathMontageByTag;

				// Token: 0x04039EDE RID: 237278
				public string Name;
			}

			// Token: 0x0200BC82 RID: 48258
			public class BindBuff
			{
				// Token: 0x04039EDF RID: 237279
				public long BuffId;
			}

			// Token: 0x0200BC83 RID: 48259
			public class BindSkill
			{
				// Token: 0x04039EE0 RID: 237280
				public int SkillId;
			}

			// Token: 0x0200BC84 RID: 48260
			public class BindTag
			{
				// Token: 0x04039EE1 RID: 237281
				public int TagId;
			}

			// Token: 0x0200BC85 RID: 48261
			public class BindSkillByName
			{
				// Token: 0x04039EE2 RID: 237282
				[Nullable(1)]
				public string SkillName = "";
			}

			// Token: 0x0200BC86 RID: 48262
			public class BindSkillCounter
			{
				// Token: 0x04039EE3 RID: 237283
				[Nullable(2)]
				public int[] SkillIds;

				// Token: 0x04039EE4 RID: 237284
				[Nullable(1)]
				public string BlackboardKey = "";

				// Token: 0x04039EE5 RID: 237285
				public int AddValueMin;

				// Token: 0x04039EE6 RID: 237286
				public int AddValueMax;

				// Token: 0x04039EE7 RID: 237287
				public bool Reset;
			}

			// Token: 0x0200BC87 RID: 48263
			public class BindDelaySuicide
			{
				// Token: 0x04039EE8 RID: 237288
				public float SuicideDelay;

				// Token: 0x04039EE9 RID: 237289
				public float DestroyDelay;
			}

			// Token: 0x0200BC88 RID: 48264
			public class BindActivateSkillGroup
			{
				// Token: 0x04039EEA RID: 237290
				public int ConfigId;
			}

			// Token: 0x0200BC89 RID: 48265
			public class BindAiHateConfig
			{
				// Token: 0x04039EEB RID: 237291
				public int ConfigId;
			}

			// Token: 0x0200BC8A RID: 48266
			public class BindAiSenseEnable
			{
				// Token: 0x04039EEC RID: 237292
				public int ConfigId;
			}

			// Token: 0x0200BC8B RID: 48267
			public class BindCue
			{
				// Token: 0x04039EED RID: 237293
				[Nullable(2)]
				public List<long> CueIds;

				// Token: 0x04039EEE RID: 237294
				public bool HideOnLoading;

				// Token: 0x04039EEF RID: 237295
				public int ConfigReplaceTagId;

				// Token: 0x04039EF0 RID: 237296
				[Nullable(1)]
				public string ConfigReplaceTagName = "";
			}

			// Token: 0x0200BC8C RID: 48268
			public class BindDisableActor
			{
			}

			// Token: 0x0200BC8D RID: 48269
			public class BindLeaveFight
			{
				// Token: 0x04039EF1 RID: 237297
				public float RandomRadius;

				// Token: 0x04039EF2 RID: 237298
				public float MinWanderDistance;

				// Token: 0x04039EF3 RID: 237299
				public float MaxNavigationMillisecond;

				// Token: 0x04039EF4 RID: 237300
				public bool MoveStateForWanderOrReset;

				// Token: 0x04039EF5 RID: 237301
				public float MaxStopTime;

				// Token: 0x04039EF6 RID: 237302
				public float BlinkTime;

				// Token: 0x04039EF7 RID: 237303
				public bool UsePatrolPointPriority;
			}

			// Token: 0x0200BC8E RID: 48270
			public class BindMontage
			{
				// Token: 0x04039EF8 RID: 237304
				[Nullable(1)]
				public string MontageName = "";

				// Token: 0x04039EF9 RID: 237305
				public bool HideOnLoading;
			}

			// Token: 0x0200BC8F RID: 48271
			public class BindBoneVisible
			{
				// Token: 0x04039EFA RID: 237306
				[Nullable(1)]
				public string BoneName = "";

				// Token: 0x04039EFB RID: 237307
				public bool Visible;
			}

			// Token: 0x0200BC90 RID: 48272
			public class BindMeshVisible
			{
				// Token: 0x04039EFC RID: 237308
				[Nullable(1)]
				public string Tag = "";

				// Token: 0x04039EFD RID: 237309
				public bool Visible;

				// Token: 0x04039EFE RID: 237310
				public bool PropagateToChildren;
			}

			// Token: 0x0200BC91 RID: 48273
			public class BindBoneCollision
			{
				// Token: 0x04039EFF RID: 237311
				[Nullable(1)]
				public string BoneName = "";

				// Token: 0x04039F00 RID: 237312
				public bool IsBlockPawn;

				// Token: 0x04039F01 RID: 237313
				public bool IsBulletDetect;

				// Token: 0x04039F02 RID: 237314
				public bool IsBlockCamera;

				// Token: 0x04039F03 RID: 237315
				public bool IsBlockPawnOnExit;

				// Token: 0x04039F04 RID: 237316
				public bool IsBulletDetectOnExit;

				// Token: 0x04039F05 RID: 237317
				public bool IsBlockCameraOnExit;

				// Token: 0x04039F06 RID: 237318
				public bool IsActiveOcclusionDither;

				// Token: 0x04039F07 RID: 237319
				public bool IsActiveOcclusionDitherOnExit;
			}

			// Token: 0x0200BC92 RID: 48274
			public class BindPartPanelVisible
			{
				// Token: 0x04039F08 RID: 237320
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x04039F09 RID: 237321
				public bool Visible;
			}

			// Token: 0x0200BC93 RID: 48275
			public class BindDeathMontage
			{
				// Token: 0x04039F0A RID: 237322
				public int DeathType;

				// Token: 0x04039F0B RID: 237323
				[Nullable(1)]
				public string MontageName = "";
			}

			// Token: 0x0200BC94 RID: 48276
			public class BindDeathMontageByTag
			{
				// Token: 0x04039F0C RID: 237324
				[Nullable(2)]
				public int[] MontageTagIds;

				// Token: 0x04039F0D RID: 237325
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public string[] MontageTagNames;

				// Token: 0x04039F0E RID: 237326
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public string[] TagMontageNames;
			}

			// Token: 0x0200BC95 RID: 48277
			[NullableContext(1)]
			[Nullable(0)]
			public class BindPalsy
			{
				// Token: 0x04039F0F RID: 237327
				public string CounterAttackEffect = "";

				// Token: 0x04039F10 RID: 237328
				public string CounterAttackCamera = "";
			}

			// Token: 0x0200BC96 RID: 48278
			public class BindCollisionChannel
			{
				// Token: 0x04039F11 RID: 237329
				[Nullable(2)]
				public List<int> IgnoreChannels;
			}

			// Token: 0x0200BC97 RID: 48279
			public class BindDisableCollision
			{
			}

			// Token: 0x0200BC98 RID: 48280
			public enum EConditionType
			{
				// Token: 0x04039F13 RID: 237331
				CondAnd = 1,
				// Token: 0x04039F14 RID: 237332
				CondOr,
				// Token: 0x04039F15 RID: 237333
				CondTrue = 4,
				// Token: 0x04039F16 RID: 237334
				CondHpLessThan = 11,
				// Token: 0x04039F17 RID: 237335
				CondSkillEnd = 13,
				// Token: 0x04039F18 RID: 237336
				CondTag,
				// Token: 0x04039F19 RID: 237337
				CondBBValueCompare,
				// Token: 0x04039F1A RID: 237338
				CondAttrCompare,
				// Token: 0x04039F1B RID: 237339
				CondAttribute,
				// Token: 0x04039F1C RID: 237340
				CondAttributeRate,
				// Token: 0x04039F1D RID: 237341
				CondCheckState,
				// Token: 0x04039F1E RID: 237342
				CondHate,
				// Token: 0x04039F1F RID: 237343
				CondTimer = 22,
				// Token: 0x04039F20 RID: 237344
				CondWaitClient,
				// Token: 0x04039F21 RID: 237345
				CondCheckStateByName,
				// Token: 0x04039F22 RID: 237346
				CondInstStateChange,
				// Token: 0x04039F23 RID: 237347
				CondBuffStack,
				// Token: 0x04039F24 RID: 237348
				CondPartLife,
				// Token: 0x04039F25 RID: 237349
				CondCheckPartActivated,
				// Token: 0x04039F26 RID: 237350
				CondListenEvent,
				// Token: 0x04039F27 RID: 237351
				CondCheckLastState = 31,
				// Token: 0x04039F28 RID: 237352
				CondCheckDissolveCombine,
				// Token: 0x04039F29 RID: 237353
				CondTaskFinish = 101,
				// Token: 0x04039F2A RID: 237354
				CondMontageTimeRemaining,
				// Token: 0x04039F2B RID: 237355
				CondListenBeHit,
				// Token: 0x04039F2C RID: 237356
				CondHasMoveInput,
				// Token: 0x04039F2D RID: 237357
				CondMontageTimeElapsing,
				// Token: 0x04039F2E RID: 237358
				CondCheckGroupPatrol,
				// Token: 0x04039F2F RID: 237359
				CondCheckPositionState = 108,
				// Token: 0x04039F30 RID: 237360
				CondCheckGroupPerform
			}

			// Token: 0x0200BC99 RID: 48281
			[NullableContext(2)]
			[Nullable(0)]
			public class Condition
			{
				// Token: 0x04039F31 RID: 237361
				public int Type;

				// Token: 0x04039F32 RID: 237362
				public bool Reverse;

				// Token: 0x04039F33 RID: 237363
				public int Index;

				// Token: 0x04039F34 RID: 237364
				public bool? IsClient;

				// Token: 0x04039F35 RID: 237365
				public CombatStateMachineDefine.Fsm.CondAnd CondAnd;

				// Token: 0x04039F36 RID: 237366
				public CombatStateMachineDefine.Fsm.CondOr CondOr;

				// Token: 0x04039F37 RID: 237367
				public CombatStateMachineDefine.Fsm.CondTrue CondTrue;

				// Token: 0x04039F38 RID: 237368
				public CombatStateMachineDefine.Fsm.CondHpLessThan CondHpLessThan;

				// Token: 0x04039F39 RID: 237369
				public CombatStateMachineDefine.Fsm.CondSkillEnd CondSkillEnd;

				// Token: 0x04039F3A RID: 237370
				public CombatStateMachineDefine.Fsm.CondTag CondTag;

				// Token: 0x04039F3B RID: 237371
				public CombatStateMachineDefine.Fsm.CondBBValueCompare CondBBValueCompare;

				// Token: 0x04039F3C RID: 237372
				public CombatStateMachineDefine.Fsm.CondAttrCompare CondAttrCompare;

				// Token: 0x04039F3D RID: 237373
				public CombatStateMachineDefine.Fsm.CondAttribute CondAttribute;

				// Token: 0x04039F3E RID: 237374
				public CombatStateMachineDefine.Fsm.CondAttributeRate CondAttributeRate;

				// Token: 0x04039F3F RID: 237375
				public CombatStateMachineDefine.Fsm.CondCheckState CondCheckState;

				// Token: 0x04039F40 RID: 237376
				public CombatStateMachineDefine.Fsm.CondHate CondHate;

				// Token: 0x04039F41 RID: 237377
				public CombatStateMachineDefine.Fsm.CondTimer CondTimer;

				// Token: 0x04039F42 RID: 237378
				public CombatStateMachineDefine.Fsm.CondWaitClient CondWaitClient;

				// Token: 0x04039F43 RID: 237379
				public CombatStateMachineDefine.Fsm.CondCheckStateByName CondCheckStateByName;

				// Token: 0x04039F44 RID: 237380
				public CombatStateMachineDefine.Fsm.CondInstStateChange CondInstStateChange;

				// Token: 0x04039F45 RID: 237381
				public CombatStateMachineDefine.Fsm.CondBuffStack CondBuffStack;

				// Token: 0x04039F46 RID: 237382
				public CombatStateMachineDefine.Fsm.CondPartLife CondPartLife;

				// Token: 0x04039F47 RID: 237383
				public CombatStateMachineDefine.Fsm.CondCheckPartActivated CondCheckPartActivated;

				// Token: 0x04039F48 RID: 237384
				public CombatStateMachineDefine.Fsm.CondListenEvent CondListenEvent;

				// Token: 0x04039F49 RID: 237385
				public CombatStateMachineDefine.Fsm.CondCheckPositionState CondCheckPositionState;

				// Token: 0x04039F4A RID: 237386
				public CombatStateMachineDefine.Fsm.CondTaskFinish CondTaskFinish;

				// Token: 0x04039F4B RID: 237387
				public CombatStateMachineDefine.Fsm.CondMontageTimeRemaining CondMontageTimeRemaining;

				// Token: 0x04039F4C RID: 237388
				public CombatStateMachineDefine.Fsm.CondListenBeHit CondListenBeHit;

				// Token: 0x04039F4D RID: 237389
				public CombatStateMachineDefine.Fsm.CondHasMoveInput CondHasMoveInput;

				// Token: 0x04039F4E RID: 237390
				public CombatStateMachineDefine.Fsm.CondMontageTimeElapsing CondMontageTimeElapsing;

				// Token: 0x04039F4F RID: 237391
				public CombatStateMachineDefine.Fsm.CondCheckGroupPatrol CondCheckGroupPatrol;

				// Token: 0x04039F50 RID: 237392
				public CombatStateMachineDefine.Fsm.CondCheckGroupPerform CondCheckGroupPerform;

				// Token: 0x04039F51 RID: 237393
				public CombatStateMachineDefine.Fsm.CondCheckLastState CondCheckLastState;

				// Token: 0x04039F52 RID: 237394
				public CombatStateMachineDefine.Fsm.CondCheckDissolveCombine CondCheckDissolveCombine;

				// Token: 0x04039F53 RID: 237395
				public string Name;
			}

			// Token: 0x0200BC9A RID: 48282
			public class CondAnd
			{
				// Token: 0x04039F54 RID: 237396
				[Nullable(2)]
				public List<int> Conditions;
			}

			// Token: 0x0200BC9B RID: 48283
			public class CondOr
			{
				// Token: 0x04039F55 RID: 237397
				[Nullable(2)]
				public List<int> Conditions;
			}

			// Token: 0x0200BC9C RID: 48284
			public class CondTrue
			{
			}

			// Token: 0x0200BC9D RID: 48285
			public class CondHpLessThan
			{
				// Token: 0x04039F56 RID: 237398
				public float HpRatio;
			}

			// Token: 0x0200BC9E RID: 48286
			public class CondSkillEnd
			{
			}

			// Token: 0x0200BC9F RID: 48287
			public class CondTag
			{
				// Token: 0x04039F57 RID: 237399
				public int TagId;

				// Token: 0x04039F58 RID: 237400
				[Nullable(1)]
				public string TagName = "";
			}

			// Token: 0x0200BCA0 RID: 48288
			public class CondBBValueCompare
			{
				// Token: 0x04039F59 RID: 237401
				public int Key1;

				// Token: 0x04039F5A RID: 237402
				public int Key2;

				// Token: 0x04039F5B RID: 237403
				public int Compare;
			}

			// Token: 0x0200BCA1 RID: 48289
			public class CondAttrCompare
			{
				// Token: 0x04039F5C RID: 237404
				public int Attr1;

				// Token: 0x04039F5D RID: 237405
				public int Attr2;

				// Token: 0x04039F5E RID: 237406
				public int Compare;
			}

			// Token: 0x0200BCA2 RID: 48290
			public class CondAttribute
			{
				// Token: 0x04039F5F RID: 237407
				public int AttributeId;

				// Token: 0x04039F60 RID: 237408
				public float Min;

				// Token: 0x04039F61 RID: 237409
				public float Max;
			}

			// Token: 0x0200BCA3 RID: 48291
			public class CondAttributeRate
			{
				// Token: 0x04039F62 RID: 237410
				public int AttributeId;

				// Token: 0x04039F63 RID: 237411
				public float Denominator;

				// Token: 0x04039F64 RID: 237412
				public float Min;

				// Token: 0x04039F65 RID: 237413
				public float Max;
			}

			// Token: 0x0200BCA4 RID: 48292
			public class CondCheckState
			{
				// Token: 0x04039F66 RID: 237414
				public int TargetState;
			}

			// Token: 0x0200BCA5 RID: 48293
			public class CondHate
			{
			}

			// Token: 0x0200BCA6 RID: 48294
			public class CondTimer
			{
				// Token: 0x04039F67 RID: 237415
				public float MinTime;

				// Token: 0x04039F68 RID: 237416
				public float MaxTime;
			}

			// Token: 0x0200BCA7 RID: 48295
			public class CondWaitClient
			{
			}

			// Token: 0x0200BCA8 RID: 48296
			public class CondCheckStateByName
			{
				// Token: 0x04039F69 RID: 237417
				[Nullable(1)]
				public string TargetStateName = "";
			}

			// Token: 0x0200BCA9 RID: 48297
			public class CondInstStateChange
			{
				// Token: 0x04039F6A RID: 237418
				public int TagId;
			}

			// Token: 0x0200BCAA RID: 48298
			public class CondBuffStack
			{
				// Token: 0x04039F6B RID: 237419
				public long BuffId;

				// Token: 0x04039F6C RID: 237420
				public int MinStack;

				// Token: 0x04039F6D RID: 237421
				public int MaxStack;
			}

			// Token: 0x0200BCAB RID: 48299
			public class CondPartLife
			{
				// Token: 0x04039F6E RID: 237422
				[Nullable(1)]
				public string PartName = "";

				// Token: 0x04039F6F RID: 237423
				public bool CheckRate;

				// Token: 0x04039F70 RID: 237424
				public float Min;

				// Token: 0x04039F71 RID: 237425
				public float Max;
			}

			// Token: 0x0200BCAC RID: 48300
			public class CondCheckPartActivated
			{
				// Token: 0x04039F72 RID: 237426
				[Nullable(1)]
				public string PartName = "";
			}

			// Token: 0x0200BCAD RID: 48301
			public class CondListenEvent
			{
				// Token: 0x04039F73 RID: 237427
				[Nullable(1)]
				public string Event = "";
			}

			// Token: 0x0200BCAE RID: 48302
			public class CondCheckPositionState
			{
				// Token: 0x04039F74 RID: 237428
				public int PositionState;
			}

			// Token: 0x0200BCAF RID: 48303
			public class CondTaskFinish
			{
			}

			// Token: 0x0200BCB0 RID: 48304
			public class CondMontageTimeRemaining
			{
				// Token: 0x04039F75 RID: 237429
				public float Time;
			}

			// Token: 0x0200BCB1 RID: 48305
			public class CondListenBeHit
			{
				// Token: 0x04039F76 RID: 237430
				public bool NoHitAnimation;

				// Token: 0x04039F77 RID: 237431
				public bool SoftKnock;

				// Token: 0x04039F78 RID: 237432
				public bool HeavyKnock;

				// Token: 0x04039F79 RID: 237433
				public bool KnockUp;

				// Token: 0x04039F7A RID: 237434
				public bool KnockDown;

				// Token: 0x04039F7B RID: 237435
				public bool Parry;

				// Token: 0x04039F7C RID: 237436
				public bool BreakWeakness;

				// Token: 0x04039F7D RID: 237437
				public int VisionCounterAttackId;
			}

			// Token: 0x0200BCB2 RID: 48306
			public class CondHasMoveInput
			{
			}

			// Token: 0x0200BCB3 RID: 48307
			public class CondCheckGroupPatrol
			{
			}

			// Token: 0x0200BCB4 RID: 48308
			public class CondCheckGroupPerform
			{
			}

			// Token: 0x0200BCB5 RID: 48309
			public class CondMontageTimeElapsing
			{
				// Token: 0x04039F7E RID: 237438
				public float Time;
			}

			// Token: 0x0200BCB6 RID: 48310
			public class CondCheckLastState
			{
				// Token: 0x04039F7F RID: 237439
				[Nullable(1)]
				public string TargetStateName = "";
			}

			// Token: 0x0200BCB7 RID: 48311
			public class CondCheckDissolveCombine
			{
			}

			// Token: 0x0200BCB8 RID: 48312
			public enum ETransitionPredictionType
			{
				// Token: 0x04039F81 RID: 237441
				Server,
				// Token: 0x04039F82 RID: 237442
				Autonomous,
				// Token: 0x04039F83 RID: 237443
				Simulated
			}

			// Token: 0x0200BCB9 RID: 48313
			public class Transition
			{
				// Token: 0x04039F84 RID: 237444
				public int From;

				// Token: 0x04039F85 RID: 237445
				public int To;

				// Token: 0x04039F86 RID: 237446
				public CombatStateMachineDefine.Fsm.ETransitionPredictionType? TransitionPredictionType;

				// Token: 0x04039F87 RID: 237447
				public int Weight;

				// Token: 0x04039F88 RID: 237448
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Condition> Conditions;
			}

			// Token: 0x0200BCBA RID: 48314
			public enum ETakeControlType
			{
				// Token: 0x04039F8A RID: 237450
				Default,
				// Token: 0x04039F8B RID: 237451
				ReEnter
			}

			// Token: 0x0200BCBB RID: 48315
			public enum ETransitionRule
			{
				// Token: 0x04039F8D RID: 237453
				Priority,
				// Token: 0x04039F8E RID: 237454
				Weight
			}

			// Token: 0x0200BCBC RID: 48316
			[NullableContext(2)]
			[Nullable(0)]
			public class Node
			{
				// Token: 0x04039F8F RID: 237455
				public int Uuid;

				// Token: 0x04039F90 RID: 237456
				public int? ReferenceUuid;

				// Token: 0x04039F91 RID: 237457
				public int? OverrideCommonUuid;

				// Token: 0x04039F92 RID: 237458
				public bool IsAnimStateMachine;

				// Token: 0x04039F93 RID: 237459
				public bool IsConduitNode;

				// Token: 0x04039F94 RID: 237460
				public bool IsAnyState;

				// Token: 0x04039F95 RID: 237461
				[Nullable(1)]
				public string Name = "";

				// Token: 0x04039F96 RID: 237462
				public CombatStateMachineDefine.Fsm.ETakeControlType TakeControlType;

				// Token: 0x04039F97 RID: 237463
				public CombatStateMachineDefine.Fsm.ETransitionRule TransitionRule;

				// Token: 0x04039F98 RID: 237464
				public CombatStateMachineDefine.Fsm.Task Task;

				// Token: 0x04039F99 RID: 237465
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.State> BindStates;

				// Token: 0x04039F9A RID: 237466
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Action> OnEnterActions;

				// Token: 0x04039F9B RID: 237467
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Action> OnExitActions;

				// Token: 0x04039F9C RID: 237468
				[Nullable(new byte[]
				{
					2,
					1
				})]
				public List<CombatStateMachineDefine.Fsm.Transition> Transitions;

				// Token: 0x04039F9D RID: 237469
				public List<int> Children;
			}

			// Token: 0x0200BCBD RID: 48317
			public class StateMachineGroup
			{
				// Token: 0x04039F9E RID: 237470
				public int? Version;

				// Token: 0x04039F9F RID: 237471
				[Nullable(2)]
				public List<int> StateMachines;

				// Token: 0x04039FA0 RID: 237472
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
