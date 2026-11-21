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
	// Token: 0x02004AA6 RID: 19110
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DeadReviveModel : ModelBase
	{
		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x0602FD06 RID: 195846 RVA: 0x00D57760 File Offset: 0x00D55960
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

		// Token: 0x0602FD07 RID: 195847 RVA: 0x00D577BC File Offset: 0x00D559BC
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

		// Token: 0x0602FD08 RID: 195848 RVA: 0x00D57858 File Offset: 0x00D55A58
		public void InitReviveConfig(int reviveId)
		{
			if (this.ReviveConfig == null || this.ReviveConfig.Value.Id != reviveId)
			{
				this.ReviveConfig = ConfigReviveById.GetConfig(reviveId, true);
			}
		}

		// Token: 0x0602FD09 RID: 195849 RVA: 0x00D57895 File Offset: 0x00D55A95
		protected override bool OnClear()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0602FD0A RID: 195850 RVA: 0x00D5789E File Offset: 0x00D55A9E
		protected override bool OnLeaveLevel()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0602FD0B RID: 195851 RVA: 0x00D578A7 File Offset: 0x00D55AA7
		protected override bool OnChangeMode()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x0602FD0C RID: 195852 RVA: 0x00D578B0 File Offset: 0x00D55AB0
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
			this.BlockInputInDarkTideDying = false;
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

		// Token: 0x0602FD0D RID: 195853 RVA: 0x00D57988 File Offset: 0x00D55B88
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

		// Token: 0x0602FD0E RID: 195854 RVA: 0x00D579BE File Offset: 0x00D55BBE
		public void ClearExternalHandles()
		{
			this.HandleOnClickGiveUpExternal = null;
		}

		// Token: 0x0602FD0F RID: 195855 RVA: 0x00D579C8 File Offset: 0x00D55BC8
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

		// Token: 0x0602FD10 RID: 195856 RVA: 0x00D57B28 File Offset: 0x00D55D28
		public void UnRegisterCooldown(long creatureDataId)
		{
			ReviveCooldownData data;
			if (this.ReviveCooldownCreatureMap.TryGetValue(creatureDataId, out data))
			{
				this.EndCooldown(creatureDataId, data);
				this.ReviveCooldownCreatureMap.Remove(creatureDataId);
			}
		}

		// Token: 0x0602FD11 RID: 195857 RVA: 0x00D57B5C File Offset: 0x00D55D5C
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

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x0602FD12 RID: 195858 RVA: 0x00D57BDA File Offset: 0x00D55DDA
		public static DeadReviveModel Instance
		{
			get
			{
				return DeadReviveModel._Instance;
			}
		}

		// Token: 0x0602FD13 RID: 195859 RVA: 0x00D57BE1 File Offset: 0x00D55DE1
		public static DeadReviveModel GetOrCreateInstance()
		{
			if (DeadReviveModel._Instance == null)
			{
				DeadReviveModel.CreateInstance();
			}
			return DeadReviveModel._Instance;
		}

		// Token: 0x0602FD14 RID: 195860 RVA: 0x00D57BF5 File Offset: 0x00D55DF5
		public static bool CreateInstance()
		{
			if (DeadReviveModel._Instance != null)
			{
				return true;
			}
			DeadReviveModel._Instance = new DeadReviveModel();
			return true;
		}

		// Token: 0x0602FD15 RID: 195861 RVA: 0x00D57C0B File Offset: 0x00D55E0B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FD16 RID: 195862 RVA: 0x00D57C0D File Offset: 0x00D55E0D
		public static void ResetStaticDefaultValue()
		{
			DeadReviveModel._Instance = null;
		}

		// Token: 0x0602FD17 RID: 195863 RVA: 0x00D57C15 File Offset: 0x00D55E15
		static DeadReviveModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DeadReviveModel.CreateStaticDefaultValue), new Action(DeadReviveModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019611 RID: 103953
		public EReviveMode ReviveMode;

		// Token: 0x04019612 RID: 103954
		public bool IsAutoRevive;

		// Token: 0x04019613 RID: 103955
		public bool IsShowRevive;

		// Token: 0x04019614 RID: 103956
		public float ReviveLimitTime;

		// Token: 0x04019615 RID: 103957
		public FVectorDouble? RevivePosition;

		// Token: 0x04019616 RID: 103958
		public FRotator? ReviveRotator;

		// Token: 0x04019617 RID: 103959
		[Nullable(2)]
		public global::Vector ReviveGravity;

		// Token: 0x04019618 RID: 103960
		public Revive? ReviveConfig;

		// Token: 0x04019619 RID: 103961
		[Nullable(2)]
		public TimerHandle DeadDelayTimer;

		// Token: 0x0401961A RID: 103962
		public Dictionary<long, ReviveCooldownData> ReviveCooldownCreatureMap = new Dictionary<long, ReviveCooldownData>();

		// Token: 0x0401961B RID: 103963
		public int CurrentShareReviveTimes;

		// Token: 0x0401961C RID: 103964
		public int MaxShareReviveTimes;

		// Token: 0x0401961D RID: 103965
		public int ChangeRoleIdAfterRevive;

		// Token: 0x0401961E RID: 103966
		public EUiViewName? OpenedViewName;

		// Token: 0x0401961F RID: 103967
		public bool BlockAllInput;

		// Token: 0x04019620 RID: 103968
		public bool BlockInputInDarkTideDying;

		// Token: 0x04019621 RID: 103969
		private Dictionary<ESkipFallInjureReason, bool> SkipFallInjureMap = new Dictionary<ESkipFallInjureReason, bool>();

		// Token: 0x04019622 RID: 103970
		public bool SkipDeathAnim;

		// Token: 0x04019623 RID: 103971
		public long ReviveFlowIncId;

		// Token: 0x04019624 RID: 103972
		[Nullable(2)]
		public Action HandleOnClickGiveUpExternal;

		// Token: 0x04019625 RID: 103973
		[Nullable(2)]
		private static DeadReviveModel _Instance;
	}
}
