using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC5 RID: 23237
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DeadReviveModel : ModelBase
	{
		// Token: 0x17008C23 RID: 35875
		// (get) Token: 0x0603AD94 RID: 241044 RVA: 0x00E06A84 File Offset: 0x00E04C84
		public bool SkipFallInjure
		{
			get
			{
				using (Dictionary<ESkipFallInjureReason, bool>.ValueCollection.Enumerator enumerator = this.SkipFallInjureMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0603AD95 RID: 241045 RVA: 0x00E06AE0 File Offset: 0x00E04CE0
		public unsafe void SetSkipFallInjure(ESkipFallInjureReason reason, bool skip)
		{
			this.SkipFallInjureMap[reason] = skip;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "防跌落伤害状态变更";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Skip", skip);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Result", this.SkipFallInjure);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0603AD96 RID: 241046 RVA: 0x00E06B7C File Offset: 0x00E04D7C
		public void InitReviveConfig(int reviveId)
		{
			if (this.ReviveConfig == null || this.ReviveConfig.Value.Id != reviveId)
			{
				this.ReviveConfig = ConfigReviveById.GetConfig(reviveId, true);
			}
		}

		// Token: 0x0603AD97 RID: 241047 RVA: 0x00E06BB9 File Offset: 0x00E04DB9
		protected override bool OnClear()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0603AD98 RID: 241048 RVA: 0x00E06BC2 File Offset: 0x00E04DC2
		protected override bool OnLeaveLevel()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0603AD99 RID: 241049 RVA: 0x00E06BCB File Offset: 0x00E04DCB
		protected override bool OnChangeMode()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0603AD9A RID: 241050 RVA: 0x00E06BD4 File Offset: 0x00E04DD4
		private void ClearAll()
		{
			this.ClearReviveData();
			this.ClearExternalHandles();
			this.ReviveMode = EReviveMode.Common;
			this.CurrentShareReviveTimes = 0;
			this.MaxShareReviveTimes = 0;
			this.RevivePosition = null;
			this.ReviveRotator = null;
			this.ReviveGravity = null;
			this.ReviveFlowIncId = 0L;
			this.BlockAllInput = false;
			this.ChangeRoleIdAfterRevive = 0;
			foreach (KeyValuePair<long, ReviveCooldownData> keyValuePair in this.ReviveCooldownCreatureMap)
			{
				long num;
				ReviveCooldownData reviveCooldownData;
				keyValuePair.Deconstruct(out num, out reviveCooldownData);
				long creatureDataId = num;
				ReviveCooldownData data = reviveCooldownData;
				this.EndCooldown(creatureDataId, data);
			}
			this.ReviveCooldownCreatureMap.Clear();
			this.SkipFallInjureMap.Clear();
		}

		// Token: 0x0603AD9B RID: 241051 RVA: 0x00E06CA8 File Offset: 0x00E04EA8
		public void ClearReviveData()
		{
			this.ReviveLimitTime = 0f;
			this.IsShowRevive = false;
			this.IsAutoRevive = false;
			if (this.DeadDelayTimer != null)
			{
				this.DeadDelayTimer.Remove();
				this.DeadDelayTimer = null;
			}
		}

		// Token: 0x0603AD9C RID: 241052 RVA: 0x00E06CDE File Offset: 0x00E04EDE
		public void ClearExternalHandles()
		{
			this.HandleOnClickGiveUpExternal = null;
		}

		// Token: 0x0603AD9D RID: 241053 RVA: 0x00E06CE8 File Offset: 0x00E04EE8
		public void RegisterCooldown(long creatureDataId, long cdMilliseconds)
		{
			if (this.ReviveCooldownCreatureMap.ContainsKey(creatureDataId))
			{
				return;
			}
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem(creatureDataId, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.CreatureDataId
			});
			if (teamItem == null)
			{
				return;
			}
			int playerId = teamItem.GetPlayerId();
			BattleUiFormationPanelData formationPanelData = BattleUiModel.Instance.FormationPanelData;
			int? num = (formationPanelData != null) ? new int?(formationPanelData.GetRolePosition(playerId, teamItem.GetConfigId)) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 1;
				if (!(num2.GetValueOrDefault() < num3 & num2 != null))
				{
					float cdSeconds = (float)cdMilliseconds * 0.001f;
					int index = num.Value - 1;
					TimerHandle handle = null;
					handle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
					{
						ReviveCooldownData reviveCooldownData = null;
						this.ReviveCooldownCreatureMap.TryGetValue(creatureDataId, out reviveCooldownData);
						if (reviveCooldownData == null)
						{
							EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, playerId, teamItem.GetConfigId, null, null);
							EventSystem.Instance.Emit<long, float>(EEventName.OnRoleReviveCooldownChange, creatureDataId, 0f);
							TimerHandle handle = handle;
							if (handle == null)
							{
								return;
							}
							handle.Remove();
							return;
						}
						else
						{
							double serverStopTimeStamp = Time.Instance.ServerStopTimeStamp;
							double num4 = serverStopTimeStamp - reviveCooldownData.LastServerStopTimeStamp;
							reviveCooldownData.LastServerStopTimeStamp = serverStopTimeStamp;
							double num5 = reviveCooldownData.RemainMilliseconds - num4;
							if (num5 <= 0.0)
							{
								this.UnRegisterCooldown(creatureDataId);
								return;
							}
							reviveCooldownData.RemainMilliseconds = num5;
							float num6 = (float)num5 * 0.001f;
							EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, playerId, teamItem.GetConfigId, new float?(num6), new float?(cdSeconds));
							EventSystem.Instance.Emit<long, float>(EEventName.OnRoleReviveCooldownChange, creatureDataId, num6);
							return;
						}
					}, 100f, 1f, null, null, true);
					if (handle != null)
					{
						ReviveCooldownData value = new ReviveCooldownData
						{
							Index = index,
							RemainMilliseconds = (double)cdMilliseconds,
							TimerHandle = handle,
							LastServerStopTimeStamp = Time.Instance.ServerStopTimeStamp
						};
						this.ReviveCooldownCreatureMap[creatureDataId] = value;
					}
					return;
				}
			}
		}

		// Token: 0x0603AD9E RID: 241054 RVA: 0x00E06E48 File Offset: 0x00E05048
		public void UnRegisterCooldown(long creatureDataId)
		{
			ReviveCooldownData data;
			if (this.ReviveCooldownCreatureMap.TryGetValue(creatureDataId, out data))
			{
				this.EndCooldown(creatureDataId, data);
				this.ReviveCooldownCreatureMap.Remove(creatureDataId);
			}
		}

		// Token: 0x0603AD9F RID: 241055 RVA: 0x00E06E7C File Offset: 0x00E0507C
		private void EndCooldown(long creatureDataId, ReviveCooldownData data)
		{
			TimerHandle timerHandle = data.TimerHandle;
			if (timerHandle != null)
			{
				timerHandle.Remove();
			}
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem(creatureDataId, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.CreatureDataId
			});
			if (teamItem != null)
			{
				EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, teamItem.GetPlayerId(), teamItem.GetConfigId, null, null);
			}
			EventSystem.Instance.Emit<long, float>(EEventName.OnRoleReviveCooldownChange, creatureDataId, 0f);
		}

		// Token: 0x17008C24 RID: 35876
		// (get) Token: 0x0603ADA0 RID: 241056 RVA: 0x00E06EFA File Offset: 0x00E050FA
		public static DeadReviveModel Instance
		{
			get
			{
				return DeadReviveModel._Instance;
			}
		}

		// Token: 0x0603ADA1 RID: 241057 RVA: 0x00E06F01 File Offset: 0x00E05101
		public static DeadReviveModel GetOrCreateInstance()
		{
			if (DeadReviveModel._Instance == null)
			{
				DeadReviveModel.CreateInstance();
			}
			return DeadReviveModel._Instance;
		}

		// Token: 0x0603ADA2 RID: 241058 RVA: 0x00E06F15 File Offset: 0x00E05115
		public static bool CreateInstance()
		{
			if (DeadReviveModel._Instance != null)
			{
				return true;
			}
			DeadReviveModel._Instance = new DeadReviveModel();
			return true;
		}

		// Token: 0x0603ADA3 RID: 241059 RVA: 0x00E06F2B File Offset: 0x00E0512B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ADA4 RID: 241060 RVA: 0x00E06F2D File Offset: 0x00E0512D
		public static void ResetStaticDefaultValue()
		{
			DeadReviveModel._Instance = null;
		}

		// Token: 0x0603ADA5 RID: 241061 RVA: 0x00E06F35 File Offset: 0x00E05135
		static DeadReviveModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DeadReviveModel.CreateStaticDefaultValue), new Action(DeadReviveModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EB56 RID: 125782
		public EReviveMode ReviveMode;

		// Token: 0x0401EB57 RID: 125783
		public bool IsAutoRevive;

		// Token: 0x0401EB58 RID: 125784
		public bool IsShowRevive;

		// Token: 0x0401EB59 RID: 125785
		public float ReviveLimitTime;

		// Token: 0x0401EB5A RID: 125786
		public FVectorDouble? RevivePosition;

		// Token: 0x0401EB5B RID: 125787
		public FRotator? ReviveRotator;

		// Token: 0x0401EB5C RID: 125788
		[Nullable(2)]
		public global::Vector ReviveGravity;

		// Token: 0x0401EB5D RID: 125789
		public Revive? ReviveConfig;

		// Token: 0x0401EB5E RID: 125790
		[Nullable(2)]
		public TimerHandle DeadDelayTimer;

		// Token: 0x0401EB5F RID: 125791
		public Dictionary<long, ReviveCooldownData> ReviveCooldownCreatureMap = new Dictionary<long, ReviveCooldownData>();

		// Token: 0x0401EB60 RID: 125792
		public int CurrentShareReviveTimes;

		// Token: 0x0401EB61 RID: 125793
		public int MaxShareReviveTimes;

		// Token: 0x0401EB62 RID: 125794
		public int ChangeRoleIdAfterRevive;

		// Token: 0x0401EB63 RID: 125795
		public EUiViewName? OpenedViewName;

		// Token: 0x0401EB64 RID: 125796
		public bool BlockAllInput;

		// Token: 0x0401EB65 RID: 125797
		private Dictionary<ESkipFallInjureReason, bool> SkipFallInjureMap = new Dictionary<ESkipFallInjureReason, bool>();

		// Token: 0x0401EB66 RID: 125798
		public bool SkipDeathAnim;

		// Token: 0x0401EB67 RID: 125799
		public long ReviveFlowIncId;

		// Token: 0x0401EB68 RID: 125800
		[Nullable(2)]
		public Action HandleOnClickGiveUpExternal;

		// Token: 0x0401EB69 RID: 125801
		[Nullable(2)]
		private static DeadReviveModel _Instance;
	}
}
