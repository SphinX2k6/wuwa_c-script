using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using Cysharp.Threading.Tasks;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006864 RID: 26724
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleReportPlayer
	{
		// Token: 0x06042BA2 RID: 273314 RVA: 0x0103ABD9 File Offset: 0x01038DD9
		public bool IsFightOver()
		{
			return this.HasReportFightOver;
		}

		// Token: 0x06042BA3 RID: 273315 RVA: 0x0103ABE4 File Offset: 0x01038DE4
		private void DriveTerminalAnimation()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null || battleManager.IsWin == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[DriveTerminalAnimation] 无法确定胜负（IsWin 为空），跳过终结态动画", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool value = battleManager.IsWin.Value;
			ActivityGameplayEntity entity = battleManager.GetEntity(value);
			object obj = (entity != null) ? entity.GetComponent<DangoBrawlMontageComponent>() : null;
			ActivityGameplayEntity entity2 = battleManager.GetEntity(!value);
			object obj2 = (entity2 != null) ? entity2.GetComponent<DangoBrawlMontageComponent>() : null;
			this.LogFightOver(battleManager, value);
			object obj3 = obj2;
			if (obj3 != null)
			{
				obj3.PlayDefeat();
			}
			object obj4 = obj;
			if (obj4 == null)
			{
				return;
			}
			obj4.PlayVictorySequence();
		}

		// Token: 0x06042BA4 RID: 273316 RVA: 0x0103AC80 File Offset: 0x01038E80
		private void LogFightOver(DangoBrawlBattleManager manager, bool selfWin)
		{
			DangoBrawlFightingClock fightingClock = manager.FightingClock;
			if ((this.NextVisualIdx < this.VisualTrack.Count || this.NextStateIdx < this.StateTrack.Count) && fightingClock != null)
			{
				float elapsed = fightingClock.Elapsed;
				float maxTime = this.MaxTime;
			}
		}

		// Token: 0x06042BA5 RID: 273317 RVA: 0x0103ACCC File Offset: 0x01038ECC
		private static int GetHpForLog(DangoBrawlBattleManager manager, bool isSelf)
		{
			ActivityGameplayEntity entity = manager.GetEntity(isSelf);
			DangoAttributeComponent dangoAttributeComponent = (entity != null) ? entity.GetComponent<DangoAttributeComponent>() : null;
			if (dangoAttributeComponent == null)
			{
				return -1;
			}
			return dangoAttributeComponent.GetAttribute(1);
		}

		// Token: 0x06042BA6 RID: 273318 RVA: 0x0103ACFC File Offset: 0x01038EFC
		private void TryChangeToRoundSettle()
		{
			if (this.HasChangedToSettle)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			if (battleManager.IsLeavingBattle)
			{
				return;
			}
			DangoBrawlFightingClock fightingClock = battleManager.FightingClock;
			if (this.TerminalStartMs < 0f && fightingClock != null)
			{
				this.TerminalStartMs = fightingClock.Elapsed;
			}
			DangoBrawlMontageComponent dangoBrawlMontageComponent;
			if (battleManager.IsWin == null)
			{
				dangoBrawlMontageComponent = null;
			}
			else
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(battleManager.IsWin.Value);
				dangoBrawlMontageComponent = ((entity != null) ? entity.GetComponent<DangoBrawlMontageComponent>() : null);
			}
			DangoBrawlMontageComponent dangoBrawlMontageComponent2 = dangoBrawlMontageComponent;
			bool flag = dangoBrawlMontageComponent2 == null || dangoBrawlMontageComponent2.IsTerminalAnimFinished();
			bool flag2 = fightingClock != null && this.TerminalStartMs >= 0f && fightingClock.Elapsed - this.TerminalStartMs >= 5000f;
			if (flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[TryChangeToRoundSettle] 终结态动画等待超时，强制切 RoundSettle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("winnerDone", flag);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (!flag2 && !flag)
			{
				return;
			}
			this.HasChangedToSettle = true;
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.ChangeState(EDangoBrawlFsmState.RoundSettle).Forget();
		}

		// Token: 0x17009789 RID: 38793
		// (get) Token: 0x06042BA7 RID: 273319 RVA: 0x0103AE08 File Offset: 0x01039008
		public DangoBrawlBattleSkillManager SkillManager { get; } = new DangoBrawlBattleSkillManager();

		// Token: 0x1700978A RID: 38794
		// (get) Token: 0x06042BA8 RID: 273320 RVA: 0x0103AE10 File Offset: 0x01039010
		public DangoBrawlBattleBuffManager BuffManager { get; } = new DangoBrawlBattleBuffManager();

		// Token: 0x1700978B RID: 38795
		// (get) Token: 0x06042BA9 RID: 273321 RVA: 0x0103AE18 File Offset: 0x01039018
		public DangoBrawlBattleFatigueDamageManager FatigueDamageManager { get; } = new DangoBrawlBattleFatigueDamageManager();

		// Token: 0x06042BAA RID: 273322 RVA: 0x0103AE20 File Offset: 0x01039020
		public void Init()
		{
			this.SkillManager.Init();
			this.BuffManager.Init();
			this.FatigueDamageManager.Init();
			this.BuildDualTracks();
		}

		// Token: 0x06042BAB RID: 273323 RVA: 0x0103AE4C File Offset: 0x0103904C
		public void Tick(float delta)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
			if (dangoBrawlFightingClock == null)
			{
				return;
			}
			float elapsed = dangoBrawlFightingClock.Elapsed;
			int nowMs = (int)elapsed;
			if (elapsed >= this.MaxTime)
			{
				if (!this.HasReportFightOver)
				{
					this.ForceFlushStateTrack();
					this.BuffManager.FlushPendingRemovals();
					this.ClearAllPerformances();
					this.NextVisualIdx = this.VisualTrack.Count;
					this.FlushAnimTracksToIdle();
					this.HasReportFightOver = true;
					this.DriveTerminalAnimation();
				}
				this.TryChangeToRoundSettle();
				return;
			}
			int nextStateIdx = this.NextStateIdx;
			this.TickStateTrack(nowMs);
			bool flag = this.StateAdvancedBuffSince(nextStateIdx);
			this.TickVisualTrack(nowMs);
			this.BuffManager.FlushPendingRemovals();
			this.TickAnimTracks(nowMs);
			this.SkillManager.Tick(delta);
			if (flag)
			{
				EventSystem.Instance.Emit(EEventName.OnDangoBrawlBattleBuffUpdate);
			}
			this.TryResetDamageGeometryWhenIdle();
			if (this.NextVisualIdx >= this.VisualTrack.Count && this.NextStateIdx >= this.StateTrack.Count && !this.SkillManager.HasActivePerformer && !this.HasReportFightOver)
			{
				this.HasReportFightOver = true;
				this.DriveTerminalAnimation();
			}
			if (this.HasReportFightOver)
			{
				this.TryChangeToRoundSettle();
			}
		}

		// Token: 0x06042BAC RID: 273324 RVA: 0x0103AF78 File Offset: 0x01039178
		private void TryResetDamageGeometryWhenIdle()
		{
			UDamageUiManager ueDamageUiManager = DamageUiManager.Instance.UeDamageUiManager;
			UDamageBatchView udamageBatchView = (ueDamageUiManager != null) ? ueDamageUiManager.DamageBatchView : null;
			if (udamageBatchView == null)
			{
				return;
			}
			if (udamageBatchView.SimpleDamageViewInfoList.Count > 0)
			{
				this.HasPendingDamageGeometryReset = true;
				return;
			}
			if (this.HasPendingDamageGeometryReset)
			{
				UUIDynamicBatchMesh dynamicBatch = udamageBatchView.DynamicBatch;
				if (dynamicBatch != null)
				{
					dynamicBatch.ClearAllGeometries();
				}
				this.HasPendingDamageGeometryReset = false;
			}
		}

		// Token: 0x06042BAD RID: 273325 RVA: 0x0103AFD8 File Offset: 0x010391D8
		private bool StateAdvancedBuffSince(int stateBefore)
		{
			for (int i = stateBefore; i < this.NextStateIdx; i++)
			{
				IDangoBrawlBattleAction action = this.StateTrack[i].Action;
				if (action.BuffChange != null || action.BuffRemove != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06042BAE RID: 273326 RVA: 0x0103B01B File Offset: 0x0103921B
		public void Destroy()
		{
			this.ClearAllPerformances();
			this.SkillManager.Destroy();
			this.BuffManager.Destroy();
			this.FatigueDamageManager.Destroy();
		}

		// Token: 0x06042BAF RID: 273327 RVA: 0x0103B044 File Offset: 0x01039244
		private void ClearAllPerformances()
		{
			foreach (TimerHandle timerHandle in this.PendingHandles)
			{
				timerHandle.Remove();
			}
			this.PendingHandles.Clear();
			foreach (int handle in this.ActiveEffectIds)
			{
				EffectSystem.Instance.StopEffectById(handle, "DangoBrawlBattleReportPlayer.ClearAllPerformances", true, null);
			}
			this.ActiveEffectIds.Clear();
		}

		// Token: 0x06042BB0 RID: 273328 RVA: 0x0103B104 File Offset: 0x01039304
		public void BuildDualTracks()
		{
			this.StateTrack.Clear();
			this.VisualTrack.Clear();
			this.NextStateIdx = 0;
			this.NextVisualIdx = 0;
			this.AttrSnapshotForBuild.Clear();
			this.SelfAnimTrack.Clear();
			this.OpponentAnimTrack.Clear();
			this.NextSelfAnimIdx = 0;
			this.NextOpponentAnimIdx = 0;
			this.TrueLoserFighterUId = -1;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			List<IDangoBrawlBattleAction> list = (battleManager != null) ? battleManager.BattleReport : null;
			if (list == null || list.Count == 0)
			{
				return;
			}
			this.InitAttrSnapshotFromFighters();
			this.ResolveTrueLoser(list);
			List<DangoBrawlBattleReportPlayer.BattleActionGroupEx> groupsEx = this.BuildGroupsEx(list);
			this.DispatchToTracks(list, groupsEx);
			this.RetimeLoserDeathToFatalHp();
			this.SortTracksStable();
			this.TruncateTracksAtDeath();
			this.BuildAnimTrack(list);
			this.LogTracksBuilt(list);
		}

		// Token: 0x06042BB1 RID: 273329 RVA: 0x0103B1CC File Offset: 0x010393CC
		private void LogTracksBuilt(List<IDangoBrawlBattleAction> report)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null && this.TrueLoserFighterUId != -1)
			{
				battleManager.GetIsSelfByFighterUid(this.TrueLoserFighterUId);
			}
			if (this.StateTrack.Count > 0)
			{
				int applyMs = this.StateTrack[this.StateTrack.Count - 1].ApplyMs;
			}
			if (this.VisualTrack.Count > 0)
			{
				int settleMs = this.VisualTrack[this.VisualTrack.Count - 1].SettleMs;
			}
		}

		// Token: 0x06042BB2 RID: 273330 RVA: 0x0103B258 File Offset: 0x01039458
		private void ResolveTrueLoser(List<IDangoBrawlBattleAction> report)
		{
			for (int i = report.Count - 1; i >= 0; i--)
			{
				if (report[i].Death != null)
				{
					this.TrueLoserFighterUId = report[i].Death.TargetFighterUId;
					return;
				}
			}
			this.TrueLoserFighterUId = -1;
		}

		// Token: 0x06042BB3 RID: 273331 RVA: 0x0103B2A8 File Offset: 0x010394A8
		[NullableContext(2)]
		private DangoBrawlBattleReportPlayer.StateEntry FindLoserFatalHpEntry()
		{
			DangoBrawlBattleReportPlayer.StateEntry stateEntry = null;
			foreach (DangoBrawlBattleReportPlayer.StateEntry stateEntry2 in this.StateTrack)
			{
				int num;
				if (stateEntry2.TargetFighterUId == this.TrueLoserFighterUId && stateEntry2.AttrDeltas != null && stateEntry2.AttrDeltas.TryGetValue(1, out num) && num < 0 && (stateEntry == null || stateEntry2.ApplyMs > stateEntry.ApplyMs))
				{
					stateEntry = stateEntry2;
				}
			}
			return stateEntry;
		}

		// Token: 0x06042BB4 RID: 273332 RVA: 0x0103B334 File Offset: 0x01039534
		private void RetimeLoserDeathToFatalHp()
		{
			if (this.TrueLoserFighterUId == -1)
			{
				return;
			}
			DangoBrawlBattleReportPlayer.StateEntry stateEntry = this.FindLoserFatalHpEntry();
			if (stateEntry == null)
			{
				return;
			}
			foreach (DangoBrawlBattleReportPlayer.StateEntry stateEntry2 in this.StateTrack)
			{
				if (stateEntry2.Action.Death != null && stateEntry2.Action.Death.TargetFighterUId == this.TrueLoserFighterUId)
				{
					stateEntry2.ApplyMs = stateEntry.ApplyMs;
				}
			}
		}

		// Token: 0x06042BB5 RID: 273333 RVA: 0x0103B3C8 File Offset: 0x010395C8
		private void TruncateTracksAtDeath()
		{
			if (this.TrueLoserFighterUId == -1)
			{
				return;
			}
			DangoBrawlBattleReportPlayer.StateEntry cutEntry = this.FindLoserFatalHpEntry();
			if (cutEntry != null)
			{
				cutEntry.ForceLoserZero = true;
				this.StateTrack.RemoveAll((DangoBrawlBattleReportPlayer.StateEntry e) => e.ApplyMs > cutEntry.ApplyMs);
				this.VisualTrack.RemoveAll((DangoBrawlBattleReportPlayer.VisualCue c) => c.SettleMs > cutEntry.ApplyMs);
				return;
			}
			int deathMs = int.MinValue;
			foreach (DangoBrawlBattleReportPlayer.StateEntry stateEntry in this.StateTrack)
			{
				if (stateEntry.Action.Death != null && stateEntry.Action.Death.TargetFighterUId == this.TrueLoserFighterUId)
				{
					deathMs = stateEntry.ApplyMs;
					break;
				}
			}
			if (deathMs == -2147483648)
			{
				return;
			}
			this.StateTrack.RemoveAll((DangoBrawlBattleReportPlayer.StateEntry e) => e.ApplyMs > deathMs);
			this.VisualTrack.RemoveAll((DangoBrawlBattleReportPlayer.VisualCue c) => c.SettleMs > deathMs);
		}

		// Token: 0x06042BB6 RID: 273334 RVA: 0x0103B4FC File Offset: 0x010396FC
		private void BuildAnimTrack(List<IDangoBrawlBattleAction> report)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			int montageSpaceTime = DangoBrawlConfig.Instance.GetMontageSpaceTime();
			this.BuildAnimTrackForSide(report, battleManager, true, this.SelfAnimTrack, montageSpaceTime);
			this.BuildAnimTrackForSide(report, battleManager, false, this.OpponentAnimTrack, montageSpaceTime);
		}

		// Token: 0x06042BB7 RID: 273335 RVA: 0x0103B544 File Offset: 0x01039744
		private void BuildAnimTrackForSide(List<IDangoBrawlBattleAction> report, DangoBrawlBattleManager manager, bool isSelf, List<DangoBrawlBattleReportPlayer.AnimCue> track, int spaceTimeMs)
		{
			ActivityGameplayEntity entity = manager.GetEntity(isSelf);
			if (((entity != null) ? entity.GetComponent<DangoBrawlMontageComponent>() : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[BuildAnimTrack] 取不到 MontageComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isSelf", isSelf);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = false;
			foreach (IDangoBrawlBattleAction dangoBrawlBattleAction in report)
			{
				DangoBrawlFightActionSkillCastInfo skillCast = dangoBrawlBattleAction.SkillCast;
				if (skillCast != null && manager.GetIsSelfByFighterUid(skillCast.SourceFighterUId) == isSelf)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
			track.Add(new DangoBrawlBattleReportPlayer.AnimCue
			{
				TriggerMs = 0,
				State = EDangoBrawlMontageState.AttackStart,
				IsSelf = isSelf
			});
		}

		// Token: 0x06042BB8 RID: 273336 RVA: 0x0103B614 File Offset: 0x01039814
		private void InitAttrSnapshotFromFighters()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in battleManager.GetFighterUidToIsSelfMap())
			{
				int key = keyValuePair.Key;
				ActivityGameplayEntity entity = battleManager.GetEntity(keyValuePair.Value);
				DangoAttributeComponent dangoAttributeComponent = (entity != null) ? entity.GetComponent<DangoAttributeComponent>() : null;
				if (dangoAttributeComponent != null)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					foreach (object obj in Enum.GetValues(typeof(DangoBrawlProType)))
					{
						int num = (int)((DangoBrawlProType)obj);
						if (dangoAttributeComponent.HasAttribute(num))
						{
							dictionary[num] = dangoAttributeComponent.GetAttribute(num);
						}
					}
					this.AttrSnapshotForBuild[key] = dictionary;
					string.Join(",", dictionary.Select(delegate(KeyValuePair<int, int> p)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<DangoBrawlProType>((DangoBrawlProType)p.Key);
						defaultInterpolatedStringHandler.AppendLiteral("=");
						defaultInterpolatedStringHandler.AppendFormatted<int>(p.Value);
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}));
				}
			}
		}

		// Token: 0x06042BB9 RID: 273337 RVA: 0x0103B750 File Offset: 0x01039950
		private List<DangoBrawlBattleReportPlayer.BattleActionGroupEx> BuildGroupsEx(List<IDangoBrawlBattleAction> report)
		{
			List<DangoBrawlBattleReportPlayer.BattleActionGroupEx> list = new List<DangoBrawlBattleReportPlayer.BattleActionGroupEx>();
			Dictionary<int, DangoBrawlBattleReportPlayer.BattleActionGroupEx> dictionary = new Dictionary<int, DangoBrawlBattleReportPlayer.BattleActionGroupEx>();
			foreach (IDangoBrawlBattleAction dangoBrawlBattleAction in report)
			{
				if (dangoBrawlBattleAction.ActionGroupUid == 0)
				{
					DangoBrawlBattleReportPlayer.BattleActionGroupEx battleActionGroupEx = new DangoBrawlBattleReportPlayer.BattleActionGroupEx
					{
						GroupUid = 0,
						TriggerMs = dangoBrawlBattleAction.TimeMs,
						Actions = new List<IDangoBrawlBattleAction>
						{
							dangoBrawlBattleAction
						}
					};
					if (dangoBrawlBattleAction.SkillCast != null)
					{
						battleActionGroupEx.SkillCastRef = dangoBrawlBattleAction.SkillCast;
					}
					list.Add(battleActionGroupEx);
				}
				else
				{
					DangoBrawlBattleReportPlayer.BattleActionGroupEx battleActionGroupEx2;
					if (!dictionary.TryGetValue(dangoBrawlBattleAction.ActionGroupUid, out battleActionGroupEx2))
					{
						battleActionGroupEx2 = new DangoBrawlBattleReportPlayer.BattleActionGroupEx
						{
							GroupUid = dangoBrawlBattleAction.ActionGroupUid,
							TriggerMs = dangoBrawlBattleAction.TimeMs,
							Actions = new List<IDangoBrawlBattleAction>()
						};
						dictionary[dangoBrawlBattleAction.ActionGroupUid] = battleActionGroupEx2;
					}
					if (dangoBrawlBattleAction.SkillCast != null && battleActionGroupEx2.SkillCastRef == null)
					{
						battleActionGroupEx2.SkillCastRef = dangoBrawlBattleAction.SkillCast;
					}
					if (dangoBrawlBattleAction.TimeMs < battleActionGroupEx2.TriggerMs)
					{
						battleActionGroupEx2.TriggerMs = dangoBrawlBattleAction.TimeMs;
					}
					battleActionGroupEx2.Actions.Add(dangoBrawlBattleAction);
				}
			}
			foreach (DangoBrawlBattleReportPlayer.BattleActionGroupEx item in dictionary.Values)
			{
				list.Add(item);
			}
			foreach (DangoBrawlBattleReportPlayer.BattleActionGroupEx battleActionGroupEx3 in list)
			{
				battleActionGroupEx3.SegmentSettleMsList = new List<int>();
				if (battleActionGroupEx3.SkillCastRef != null)
				{
					DangoBrawlDamageInfo damageInfo = battleActionGroupEx3.SkillCastRef.DamageInfo;
					if (((damageInfo != null) ? damageInfo.Damages : null) != null && battleActionGroupEx3.SkillCastRef.DamageInfo.Damages.Count > 0)
					{
						int count = battleActionGroupEx3.SkillCastRef.DamageInfo.Damages.Count;
						for (int i = 0; i < count; i++)
						{
							battleActionGroupEx3.SegmentSettleMsList.Add(battleActionGroupEx3.TriggerMs + this.GetSegmentHitDelay(battleActionGroupEx3.SkillCastRef.SkillConfigId, i));
						}
						continue;
					}
				}
				battleActionGroupEx3.SegmentSettleMsList.Add(battleActionGroupEx3.TriggerMs);
			}
			return list;
		}

		// Token: 0x06042BBA RID: 273338 RVA: 0x0103B9E8 File Offset: 0x01039BE8
		private unsafe void DispatchToTracks(List<IDangoBrawlBattleAction> report, List<DangoBrawlBattleReportPlayer.BattleActionGroupEx> groupsEx)
		{
			Dictionary<int, DangoBrawlBattleReportPlayer.BattleActionGroupEx> dictionary = new Dictionary<int, DangoBrawlBattleReportPlayer.BattleActionGroupEx>();
			int i = 0;
			foreach (DangoBrawlBattleReportPlayer.BattleActionGroupEx battleActionGroupEx in groupsEx)
			{
				if (battleActionGroupEx.GroupUid != 0)
				{
					dictionary[battleActionGroupEx.GroupUid] = battleActionGroupEx;
				}
			}
			for (int j = 0; j < report.Count; j++)
			{
				IDangoBrawlBattleAction dangoBrawlBattleAction = report[j];
				DangoBrawlBattleReportPlayer.BattleActionGroupEx battleActionGroupEx2 = null;
				if (dangoBrawlBattleAction.ActionGroupUid != 0)
				{
					dictionary.TryGetValue(dangoBrawlBattleAction.ActionGroupUid, out battleActionGroupEx2);
				}
				else
				{
					while (i < groupsEx.Count)
					{
						if (groupsEx[i].GroupUid == 0 && groupsEx[i].Actions.Count == 1 && groupsEx[i].Actions[0] == dangoBrawlBattleAction)
						{
							battleActionGroupEx2 = groupsEx[i];
							i++;
							break;
						}
						i++;
					}
				}
				if (battleActionGroupEx2 == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "[DispatchToTracks] action 找不到所属 group";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("idx", j);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("groupUid", dangoBrawlBattleAction.ActionGroupUid);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					if (dangoBrawlBattleAction.AttrChange != null)
					{
						this.DispatchAttrChangeToState(dangoBrawlBattleAction, battleActionGroupEx2, j);
					}
					if (dangoBrawlBattleAction.BuffChange != null || dangoBrawlBattleAction.BuffRemove != null || dangoBrawlBattleAction.Death != null)
					{
						this.StateTrack.Add(new DangoBrawlBattleReportPlayer.StateEntry
						{
							ApplyMs = battleActionGroupEx2.TriggerMs,
							SourceGroupUid = battleActionGroupEx2.GroupUid,
							OriginalIndex = j,
							SegmentIndex = 0,
							TargetFighterUId = DangoBrawlBattleReportPlayer.ExtractTargetFighterUId(dangoBrawlBattleAction),
							Action = dangoBrawlBattleAction
						});
					}
					this.DispatchVisualForAction(dangoBrawlBattleAction, battleActionGroupEx2, j);
				}
			}
		}

		// Token: 0x06042BBB RID: 273339 RVA: 0x0103BBE4 File Offset: 0x01039DE4
		private void DispatchAttrChangeToState(IDangoBrawlBattleAction action, DangoBrawlBattleReportPlayer.BattleActionGroupEx group, int originalIdx)
		{
			DangoBrawlFightActionAttrChangeInfo attrChange = action.AttrChange;
			int targetFighterUId = attrChange.TargetFighterUId;
			Dictionary<int, int> dictionary;
			if (!this.AttrSnapshotForBuild.TryGetValue(targetFighterUId, out dictionary))
			{
				dictionary = new Dictionary<int, int>();
				this.AttrSnapshotForBuild[targetFighterUId] = dictionary;
			}
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in attrChange.FinalAttrs)
			{
				int num2;
				int num = dictionary.TryGetValue(keyValuePair.Key, out num2) ? num2 : 0;
				int num3 = keyValuePair.Value - num;
				int key = keyValuePair.Key;
				if (num3 != 0)
				{
					dictionary2[keyValuePair.Key] = num3;
				}
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			if (dictionary2.Count == 0)
			{
				return;
			}
			bool flag;
			if (group.SkillCastRef != null)
			{
				DangoBrawlDamageInfo damageInfo = group.SkillCastRef.DamageInfo;
				if (((damageInfo != null) ? damageInfo.Damages : null) != null)
				{
					flag = (group.SkillCastRef.DamageInfo.Damages.Count > 0);
					goto IL_FE;
				}
			}
			flag = false;
			IL_FE:
			if (!flag)
			{
				this.StateTrack.Add(new DangoBrawlBattleReportPlayer.StateEntry
				{
					ApplyMs = group.TriggerMs,
					SourceGroupUid = group.GroupUid,
					OriginalIndex = originalIdx,
					SegmentIndex = 0,
					TargetFighterUId = targetFighterUId,
					Action = action,
					AttrDeltas = dictionary2
				});
				return;
			}
			RepeatedField<DangoBrawlDamageSegment> damages = group.SkillCastRef.DamageInfo.Damages;
			int count = damages.Count;
			int[] array = new int[count];
			long num4 = 0L;
			for (int i = 0; i < count; i++)
			{
				array[i] = damages[i].Damage;
				num4 += (long)array[i];
			}
			Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
			Dictionary<int, int> dictionary4 = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair2 in dictionary2)
			{
				if (DangoBrawlBattleReportPlayer.IsHpLikeAttr(keyValuePair2.Key))
				{
					dictionary3[keyValuePair2.Key] = keyValuePair2.Value;
				}
				else
				{
					dictionary4[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
			if (dictionary3.Count > 0)
			{
				Dictionary<int, int>[] array2 = new Dictionary<int, int>[count];
				for (int j = 0; j < count; j++)
				{
					array2[j] = new Dictionary<int, int>();
				}
				foreach (KeyValuePair<int, int> keyValuePair3 in dictionary3)
				{
					int value = keyValuePair3.Value;
					int num5 = 0;
					if (num4 == 0L)
					{
						for (int k = 0; k < count - 1; k++)
						{
							int num6 = (int)Math.Round((double)value * (double)(k + 1) / (double)count);
							array2[k][keyValuePair3.Key] = num6 - num5;
							num5 = num6;
						}
					}
					else
					{
						long num7 = 0L;
						for (int l = 0; l < count - 1; l++)
						{
							num7 += (long)array[l];
							int num8 = (int)Math.Round((double)value * (double)num7 / (double)num4);
							array2[l][keyValuePair3.Key] = num8 - num5;
							num5 = num8;
						}
					}
					array2[count - 1][keyValuePair3.Key] = value - num5;
				}
				for (int m = 0; m < count; m++)
				{
					if (array2[m].Count != 0)
					{
						int num9;
						array2[m].TryGetValue(1, out num9);
						this.StateTrack.Add(new DangoBrawlBattleReportPlayer.StateEntry
						{
							ApplyMs = group.SegmentSettleMsList[m],
							SourceGroupUid = group.GroupUid,
							OriginalIndex = originalIdx,
							SegmentIndex = m,
							TargetFighterUId = targetFighterUId,
							Action = action,
							AttrDeltas = array2[m]
						});
					}
				}
			}
			if (dictionary4.Count > 0)
			{
				this.StateTrack.Add(new DangoBrawlBattleReportPlayer.StateEntry
				{
					ApplyMs = group.SegmentSettleMsList[count - 1],
					SourceGroupUid = group.GroupUid,
					OriginalIndex = originalIdx,
					SegmentIndex = count - 1,
					TargetFighterUId = targetFighterUId,
					Action = action,
					AttrDeltas = dictionary4
				});
			}
		}

		// Token: 0x06042BBC RID: 273340 RVA: 0x0103C030 File Offset: 0x0103A230
		private unsafe void DispatchVisualForAction(IDangoBrawlBattleAction action, DangoBrawlBattleReportPlayer.BattleActionGroupEx group, int originalIdx)
		{
			bool flag;
			if (group.SkillCastRef != null)
			{
				DangoBrawlDamageInfo damageInfo = group.SkillCastRef.DamageInfo;
				if (((damageInfo != null) ? damageInfo.Damages : null) != null)
				{
					flag = (group.SkillCastRef.DamageInfo.Damages.Count > 0);
					goto IL_3C;
				}
			}
			flag = false;
			IL_3C:
			bool flag2 = flag;
			int num = flag2 ? group.SkillCastRef.DamageInfo.Damages.Count : 0;
			if (action.SkillCast != null)
			{
				this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
				{
					SettleMs = group.TriggerMs,
					SourceGroupUid = group.GroupUid,
					OriginalIndex = originalIdx,
					SegmentIndex = 0,
					Action = action
				});
			}
			if (action.ReflectDamage != null)
			{
				RepeatedField<int> damages = action.ReflectDamage.Damages;
				int num2 = (damages != null) ? damages.Count : 0;
				if (flag2 && num2 != num)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "[DispatchVisualForAction] ReflectDamage 段数与 SkillCast 不一致";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reflect", num2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skill", num);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				int num3 = flag2 ? Math.Min(num2, num) : num2;
				for (int i = 0; i < num3; i++)
				{
					this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
					{
						SettleMs = group.SegmentSettleMsList[Math.Min(i, group.SegmentSettleMsList.Count - 1)],
						SourceGroupUid = group.GroupUid,
						OriginalIndex = originalIdx,
						SegmentIndex = i,
						Action = action
					});
				}
			}
			if (action.Heal != null)
			{
				RepeatedField<int> healValues = action.Heal.HealValues;
				int num4 = (healValues != null) ? healValues.Count : 0;
				if (flag2)
				{
					if (num4 != num)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.DangoBrawl;
						ELogAuthor author2 = ELogAuthor.WHJ;
						string message2 = "[DispatchVisualForAction] Heal 段数与 SkillCast 不一致";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("heal", num4);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("skill", num);
						instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					int num5 = Math.Min(num4, num);
					for (int j = 0; j < num5; j++)
					{
						this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
						{
							SettleMs = group.SegmentSettleMsList[j],
							SourceGroupUid = group.GroupUid,
							OriginalIndex = originalIdx,
							SegmentIndex = j,
							Action = action
						});
					}
				}
				else
				{
					for (int k = 0; k < num4; k++)
					{
						this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
						{
							SettleMs = group.TriggerMs,
							SourceGroupUid = group.GroupUid,
							OriginalIndex = originalIdx,
							SegmentIndex = k,
							Action = action
						});
					}
				}
			}
			if (action.Lifesteal != null)
			{
				RepeatedField<int> healValues2 = action.Lifesteal.HealValues;
				int num6 = (healValues2 != null) ? healValues2.Count : 0;
				if (flag2)
				{
					if (num6 != num)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.DangoBrawl;
						ELogAuthor author3 = ELogAuthor.WHJ;
						string message3 = "[DispatchVisualForAction] Lifesteal 段数与 SkillCast 不一致";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("lifesteal", num6);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("skill", num);
						instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
					int num7 = Math.Min(num6, num);
					for (int l = 0; l < num7; l++)
					{
						this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
						{
							SettleMs = group.SegmentSettleMsList[l],
							SourceGroupUid = group.GroupUid,
							OriginalIndex = originalIdx,
							SegmentIndex = l,
							Action = action
						});
					}
				}
				else
				{
					for (int m = 0; m < num6; m++)
					{
						this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
						{
							SettleMs = group.TriggerMs,
							SourceGroupUid = group.GroupUid,
							OriginalIndex = originalIdx,
							SegmentIndex = m,
							Action = action
						});
					}
				}
			}
			if (action.BuffChange != null || action.BuffRemove != null || action.FatigueDamage != null || action.ShieldAdd != null || action.BuffTick != null || action.WeaponStop != null || action.EffectShow != null || action.InitWeaponCd != null)
			{
				this.VisualTrack.Add(new DangoBrawlBattleReportPlayer.VisualCue
				{
					SettleMs = group.TriggerMs,
					SourceGroupUid = group.GroupUid,
					OriginalIndex = originalIdx,
					SegmentIndex = 0,
					Action = action
				});
			}
		}

		// Token: 0x06042BBD RID: 273341 RVA: 0x0103C4E0 File Offset: 0x0103A6E0
		private void SortTracksStable()
		{
			List<DangoBrawlBattleReportPlayer.StateEntry> collection = (from e in this.StateTrack
			orderby e.ApplyMs, e.OriginalIndex, e.SegmentIndex
			select e).ToList<DangoBrawlBattleReportPlayer.StateEntry>();
			this.StateTrack.Clear();
			this.StateTrack.AddRange(collection);
			List<DangoBrawlBattleReportPlayer.VisualCue> collection2 = (from c in this.VisualTrack
			orderby c.SettleMs, c.OriginalIndex, c.SegmentIndex
			select c).ToList<DangoBrawlBattleReportPlayer.VisualCue>();
			this.VisualTrack.Clear();
			this.VisualTrack.AddRange(collection2);
		}

		// Token: 0x06042BBE RID: 273342 RVA: 0x0103C60C File Offset: 0x0103A80C
		private void TickStateTrack(int nowMs)
		{
			while (this.NextStateIdx < this.StateTrack.Count && this.StateTrack[this.NextStateIdx].ApplyMs <= nowMs)
			{
				this.ApplyStateEntry(this.StateTrack[this.NextStateIdx]);
				this.NextStateIdx++;
			}
		}

		// Token: 0x06042BBF RID: 273343 RVA: 0x0103C66C File Offset: 0x0103A86C
		private void TickVisualTrack(int nowMs)
		{
			while (this.NextVisualIdx < this.VisualTrack.Count && this.VisualTrack[this.NextVisualIdx].SettleMs <= nowMs)
			{
				this.PlayVisualCue(this.VisualTrack[this.NextVisualIdx]);
				this.NextVisualIdx++;
			}
		}

		// Token: 0x06042BC0 RID: 273344 RVA: 0x0103C6CC File Offset: 0x0103A8CC
		private void TickAnimTracks(int nowMs)
		{
			if (this.HasReportFightOver)
			{
				return;
			}
			while (this.NextSelfAnimIdx < this.SelfAnimTrack.Count)
			{
				if (this.SelfAnimTrack[this.NextSelfAnimIdx].TriggerMs > nowMs)
				{
					break;
				}
				this.PlayAnimCue(this.SelfAnimTrack[this.NextSelfAnimIdx]);
				this.NextSelfAnimIdx++;
			}
			while (this.NextOpponentAnimIdx < this.OpponentAnimTrack.Count && this.OpponentAnimTrack[this.NextOpponentAnimIdx].TriggerMs <= nowMs)
			{
				this.PlayAnimCue(this.OpponentAnimTrack[this.NextOpponentAnimIdx]);
				this.NextOpponentAnimIdx++;
			}
		}

		// Token: 0x06042BC1 RID: 273345 RVA: 0x0103C788 File Offset: 0x0103A988
		private unsafe void PlayAnimCue(DangoBrawlBattleReportPlayer.AnimCue cue)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlMontageComponent dangoBrawlMontageComponent;
			if (battleManager == null)
			{
				dangoBrawlMontageComponent = null;
			}
			else
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(cue.IsSelf);
				dangoBrawlMontageComponent = ((entity != null) ? entity.GetComponent<DangoBrawlMontageComponent>() : null);
			}
			DangoBrawlMontageComponent dangoBrawlMontageComponent2 = dangoBrawlMontageComponent;
			if (dangoBrawlMontageComponent2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[PlayAnimCue] 取不到 MontageComponent";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isSelf", cue.IsSelf);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", cue.State);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			dangoBrawlMontageComponent2.PlayMontage(cue.State);
			if (cue.State == EDangoBrawlMontageState.AttackStart)
			{
				DangoBrawlBattleManager battleManager2 = DangoBrawlModel.Instance.GetBattleManager(true);
				int id = (battleManager2 != null) ? battleManager2.GetDangoId(cue.IsSelf) : 0;
				DangoBrawlRole? dangoBrawlRole;
				DangoBrawlOpponent? dangoBrawlOpponent;
				string eventName = cue.IsSelf ? ((DangoBrawlConfig.Instance.GetRoleConfigById(id) != null) ? dangoBrawlRole.GetValueOrDefault().AudioAttackStart : null) : ((DangoBrawlConfig.Instance.GetOpponentConfigById(id) != null) ? dangoBrawlOpponent.GetValueOrDefault().AudioAttackStart : null);
				this.PostDangoAudio(cue.IsSelf, eventName);
			}
		}

		// Token: 0x06042BC2 RID: 273346 RVA: 0x0103C8D0 File Offset: 0x0103AAD0
		[NullableContext(2)]
		private void PostDangoAudio(bool isSelf, string eventName)
		{
			if (string.IsNullOrEmpty(eventName))
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			ACharacter acharacter;
			if (battleManager == null)
			{
				acharacter = null;
			}
			else
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(isSelf);
				if (entity == null)
				{
					acharacter = null;
				}
				else
				{
					DangoBrawlActorComponent component = entity.GetComponent<DangoBrawlActorComponent>();
					acharacter = ((component != null) ? component.SpawnedActor : null);
				}
			}
			ACharacter acharacter2 = acharacter;
			if (acharacter2 == null || !acharacter2.IsValid())
			{
				return;
			}
			AudioSystem.Instance.PostEvent(eventName, acharacter2, null);
		}

		// Token: 0x06042BC3 RID: 273347 RVA: 0x0103C93C File Offset: 0x0103AB3C
		private void FlushAnimTracksToIdle()
		{
			this.NextSelfAnimIdx = this.SelfAnimTrack.Count;
			this.NextOpponentAnimIdx = this.OpponentAnimTrack.Count;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(true);
				if (entity != null)
				{
					DangoBrawlMontageComponent component = entity.GetComponent<DangoBrawlMontageComponent>();
					if (component != null)
					{
						component.PlayMontage(EDangoBrawlMontageState.Idle);
					}
				}
			}
			if (battleManager == null)
			{
				return;
			}
			ActivityGameplayEntity entity2 = battleManager.GetEntity(false);
			if (entity2 == null)
			{
				return;
			}
			DangoBrawlMontageComponent component2 = entity2.GetComponent<DangoBrawlMontageComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.PlayMontage(EDangoBrawlMontageState.Idle);
		}

		// Token: 0x06042BC4 RID: 273348 RVA: 0x0103C9BC File Offset: 0x0103ABBC
		private void ApplyStateEntry(DangoBrawlBattleReportPlayer.StateEntry entry)
		{
			if (entry.AttrDeltas != null)
			{
				DangoAttributeComponent attrComp = DangoBrawlBattleReportPlayer.GetAttrComp(entry.TargetFighterUId);
				if (attrComp != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in entry.AttrDeltas)
					{
						int num = attrComp.GetAttribute(keyValuePair.Key) + keyValuePair.Value;
						if (keyValuePair.Key == 1)
						{
							if (entry.TargetFighterUId == this.TrueLoserFighterUId)
							{
								if (entry.ForceLoserZero || num < 0)
								{
									num = 0;
								}
							}
							else if (num < 1)
							{
								num = 1;
							}
						}
						attrComp.SetAttribute(keyValuePair.Key, num);
					}
				}
			}
			if (entry.Action.BuffChange != null || entry.Action.BuffRemove != null)
			{
				this.BuffManager.ApplyStateForAction(entry.Action);
			}
			if (entry.Action.Death != null && entry.Action.Death.TargetFighterUId == this.TrueLoserFighterUId)
			{
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				bool isSelf = battleManager != null && battleManager.GetIsSelfByFighterUid(entry.Action.Death.TargetFighterUId);
				DangoBrawlBattleManager battleManager2 = DangoBrawlModel.Instance.GetBattleManager(true);
				if (battleManager2 == null)
				{
					return;
				}
				ActivityGameplayEntity entity = battleManager2.GetEntity(isSelf);
				if (entity == null)
				{
					return;
				}
				DangoBrawlMontageComponent component = entity.GetComponent<DangoBrawlMontageComponent>();
				if (component == null)
				{
					return;
				}
				component.PlayDefeat();
			}
		}

		// Token: 0x06042BC5 RID: 273349 RVA: 0x0103CB20 File Offset: 0x0103AD20
		private void PlayVisualCue(DangoBrawlBattleReportPlayer.VisualCue cue)
		{
			if (cue.Action.SkillCast != null)
			{
				BattleActionGroup group = new BattleActionGroup
				{
					GroupUid = cue.SourceGroupUid,
					TriggerMs = cue.SettleMs,
					Actions = new List<IDangoBrawlBattleAction>
					{
						cue.Action
					}
				};
				this.SkillManager.OnActivateGroup(group);
				return;
			}
			if (cue.Action.FatigueDamage != null)
			{
				if (!this.HasNotifiedFatigueFirstTime)
				{
					this.HasNotifiedFatigueFirstTime = true;
					EventSystem.Instance.Emit(EEventName.OnDangoBrawlFatigueFirstTriggered);
				}
				BattleActionGroup group2 = new BattleActionGroup
				{
					GroupUid = cue.SourceGroupUid,
					TriggerMs = cue.SettleMs,
					Actions = new List<IDangoBrawlBattleAction>
					{
						cue.Action
					}
				};
				this.FatigueDamageManager.OnActivateGroup(group2);
				return;
			}
			if (cue.Action.BuffChange != null || cue.Action.BuffRemove != null)
			{
				this.BuffManager.PlayVisualForAction(cue.Action);
				if (cue.Action.BuffChange != null)
				{
					DangoBrawlFightActionBuffChangeInfo buffChange = cue.Action.BuffChange;
					if (buffChange.NextReadyMs > 0 && DangoBrawlUtil.ShouldTriggerItemUIEffect(buffChange.SourceItemUId, EDangoBrawlUIEffectSource.BuffChange))
					{
						DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(buffChange.BuffConfigId);
						if (buffConfigById != null && buffConfigById.GetValueOrDefault().NeedBuffChangeUICD)
						{
							EventSystem.Instance.Emit<int, int>(EEventName.OnDangoBrawlItemCdUpdate, buffChange.SourceItemUId, buffChange.NextReadyMs);
						}
						if (buffConfigById != null && buffConfigById.GetValueOrDefault().NeedBuffChangeUIEffect)
						{
							EventSystem.Instance.Emit<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new DangoBrawlItemUIEffectData
							{
								ItemUId = buffChange.SourceItemUId,
								IsTriggerLimit = false
							});
							return;
						}
					}
				}
			}
			else
			{
				if (cue.Action.BuffTick != null)
				{
					this.BuffManager.ReportBuffTick(cue.Action.BuffTick);
					return;
				}
				if (cue.Action.Heal != null || cue.Action.ShieldAdd != null || cue.Action.ReflectDamage != null || cue.Action.Lifesteal != null)
				{
					this.ReportSimpleDamageAction(cue.Action, cue.SegmentIndex);
					return;
				}
				if (cue.Action.EffectShow != null)
				{
					DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
					if (battleManager != null)
					{
						DangoBrawlDamageReporter damage = battleManager.Damage;
						if (damage != null)
						{
							damage.ReportEffectShow(cue.Action.EffectShow.OwnerFighterUId, cue.Action.EffectShow.EffectId);
						}
					}
					int itemUId = cue.Action.EffectShow.ItemUId;
					if (itemUId != 0 && DangoBrawlUtil.ShouldTriggerItemUIEffect(itemUId, EDangoBrawlUIEffectSource.EffectShow))
					{
						EventSystem.Instance.Emit<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new DangoBrawlItemUIEffectData
						{
							ItemUId = itemUId,
							IsTriggerLimit = cue.Action.EffectShow.IsTriggerLimit
						});
						return;
					}
				}
				else
				{
					if (cue.Action.WeaponStop != null)
					{
						DangoBrawlFightActionWeaponStopInfo weaponStop = cue.Action.WeaponStop;
						EventSystem.Instance.Emit<int, int>(EEventName.OnDangoBrawlWeaponStop, weaponStop.WeaponSourceItemUid, weaponStop.StopMs);
						return;
					}
					if (cue.Action.InitWeaponCd != null)
					{
						MapField<int, int> weaponNextReadyMs = cue.Action.InitWeaponCd.WeaponNextReadyMs;
						if (weaponNextReadyMs != null)
						{
							foreach (KeyValuePair<int, int> keyValuePair in weaponNextReadyMs)
							{
								EventSystem.Instance.Emit<int, int>(EEventName.OnDangoBrawlItemCdUpdate, keyValuePair.Key, keyValuePair.Value);
							}
						}
					}
				}
			}
		}

		// Token: 0x06042BC6 RID: 273350 RVA: 0x0103CEC0 File Offset: 0x0103B0C0
		private string DescribeVisualCue(DangoBrawlBattleReportPlayer.VisualCue cue)
		{
			IDangoBrawlBattleAction action = cue.Action;
			if (action.SkillCast != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 5);
				defaultInterpolatedStringHandler.AppendLiteral("SkillCast(skillConfigId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.SkillCast.SkillConfigId);
				defaultInterpolatedStringHandler.AppendLiteral(",weaponItemId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.SkillCast.WeaponItemId);
				defaultInterpolatedStringHandler.AppendLiteral(",weaponItem=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(action.SkillCast.WeaponItemUId));
				defaultInterpolatedStringHandler.AppendLiteral(",srcFighter=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeFighterUid(action.SkillCast.SourceFighterUId));
				defaultInterpolatedStringHandler.AppendLiteral(",targetFighter=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeFighterUid(action.SkillCast.TargetFighterUId));
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.FatigueDamage != null)
			{
				return "FatigueDamage(疲劳烧血)";
			}
			if (action.BuffChange != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(56, 4);
				defaultInterpolatedStringHandler.AppendLiteral("BuffChange(buffConfigId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.BuffChange.BuffConfigId);
				defaultInterpolatedStringHandler.AppendLiteral(",buffUid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.BuffChange.BuffUId);
				defaultInterpolatedStringHandler.AppendLiteral(",srcItem=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(action.BuffChange.SourceItemUId));
				defaultInterpolatedStringHandler.AppendLiteral(",nextReadyMs=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.BuffChange.NextReadyMs);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.BuffRemove != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("BuffRemove(buffUid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.BuffRemove.BuffUId);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.BuffTick != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("BuffTick(buffUid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.BuffTick.BuffUId);
				defaultInterpolatedStringHandler.AppendFormatted(this.DescribeBuffUid(action.BuffTick.BuffUId));
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.Heal != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Heal(itemConfigId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.Heal.ItemConfigId);
				defaultInterpolatedStringHandler.AppendLiteral(",itemUid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.Heal.ItemUId);
				defaultInterpolatedStringHandler.AppendLiteral(",target=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeFighterUid(action.Heal.TargetFighterUId));
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.ShieldAdd != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("ShieldAdd(item=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(action.ShieldAdd.ItemUId));
				defaultInterpolatedStringHandler.AppendLiteral(",target=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeFighterUid(action.ShieldAdd.TargetFighterUId));
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.ReflectDamage != null)
			{
				return "ReflectDamage(target=" + DangoBrawlBattleReportPlayer.DescribeFighterUid(action.ReflectDamage.TargetFighterUId) + ")";
			}
			if (action.Lifesteal != null)
			{
				return "Lifesteal(target=" + DangoBrawlBattleReportPlayer.DescribeFighterUid(action.Lifesteal.TargetFighterUId) + ")";
			}
			if (action.EffectShow != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
				defaultInterpolatedStringHandler.AppendLiteral("EffectShow(effectId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.EffectShow.EffectId);
				defaultInterpolatedStringHandler.AppendLiteral(",owner=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeFighterUid(action.EffectShow.OwnerFighterUId));
				defaultInterpolatedStringHandler.AppendLiteral(",item=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(action.EffectShow.ItemUId));
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.WeaponStop != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
				defaultInterpolatedStringHandler.AppendLiteral("WeaponStop(weaponItem=");
				defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(action.WeaponStop.WeaponSourceItemUid));
				defaultInterpolatedStringHandler.AppendLiteral(",stopMs=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(action.WeaponStop.StopMs);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (action.InitWeaponCd != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("InitWeaponCd(count=");
				MapField<int, int> weaponNextReadyMs = action.InitWeaponCd.WeaponNextReadyMs;
				defaultInterpolatedStringHandler.AppendFormatted<int>((weaponNextReadyMs != null) ? weaponNextReadyMs.Count : 0);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return "Unknown";
		}

		// Token: 0x06042BC7 RID: 273351 RVA: 0x0103D380 File Offset: 0x0103B580
		private static string DescribeFighterUid(int fighterUid)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (battleManager == null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(fighterUid);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(fighterUid);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(battleManager.GetIsSelfByFighterUid(fighterUid) ? "Self" : "Opponent");
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042BC8 RID: 273352 RVA: 0x0103D404 File Offset: 0x0103B604
		private static string DescribeItemUid(int itemUid)
		{
			if (itemUid == 0)
			{
				return "0";
			}
			int configIdByItemUid = DangoBrawlUtil.GetConfigIdByItemUid(itemUid);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (configIdByItemUid != -1)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemUid);
				defaultInterpolatedStringHandler.AppendLiteral("(cfg=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(configIdByItemUid);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemUid);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042BC9 RID: 273353 RVA: 0x0103D478 File Offset: 0x0103B678
		private string DescribeBuffUid(int buffUid)
		{
			int itemUid;
			int value;
			if (!this.BuffManager.TryGetBuffBrief(buffUid, out itemUid, out value))
			{
				return "";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral(",srcItem=");
			defaultInterpolatedStringHandler.AppendFormatted(DangoBrawlBattleReportPlayer.DescribeItemUid(itemUid));
			defaultInterpolatedStringHandler.AppendLiteral(",buffConfigId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042BCA RID: 273354 RVA: 0x0103D4DC File Offset: 0x0103B6DC
		private void ReportSimpleDamageAction(IDangoBrawlBattleAction action, int segmentIndex)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlDamageReporter dangoBrawlDamageReporter = (battleManager != null) ? battleManager.Damage : null;
			if (dangoBrawlDamageReporter == null)
			{
				return;
			}
			if (action.Heal != null)
			{
				RepeatedField<int> healValues = action.Heal.HealValues;
				if (healValues != null && segmentIndex >= 0 && segmentIndex < healValues.Count)
				{
					dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
					{
						Source = EDangoBrawlDamageSource.Heal,
						SourceConfigId = action.Heal.ItemConfigId,
						TargetFighterUid = action.Heal.TargetFighterUId,
						Value = healValues[segmentIndex],
						SourceItemUid = action.Heal.ItemUId
					});
				}
			}
			if (action.ShieldAdd != null)
			{
				dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
				{
					Source = EDangoBrawlDamageSource.Shield,
					TargetFighterUid = action.ShieldAdd.TargetFighterUId,
					Value = action.ShieldAdd.ShieldValue,
					SourceItemUid = action.ShieldAdd.ItemUId
				});
			}
			if (action.ReflectDamage != null)
			{
				RepeatedField<int> damages = action.ReflectDamage.Damages;
				if (damages != null && segmentIndex >= 0 && segmentIndex < damages.Count)
				{
					DangoBrawlBattleManager battleManager2 = DangoBrawlModel.Instance.GetBattleManager(true);
					dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
					{
						Source = EDangoBrawlDamageSource.Reflect,
						SourceConfigId = -1001,
						SourceFighterUid = ((battleManager2 != null) ? battleManager2.GetOppositeFighterUid(action.ReflectDamage.TargetFighterUId) : 0),
						TargetFighterUid = action.ReflectDamage.TargetFighterUId,
						Value = damages[segmentIndex]
					});
				}
			}
			if (action.Lifesteal != null)
			{
				RepeatedField<int> healValues2 = action.Lifesteal.HealValues;
				if (healValues2 != null && segmentIndex >= 0 && segmentIndex < healValues2.Count)
				{
					dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
					{
						Source = EDangoBrawlDamageSource.Lifesteal,
						SourceConfigId = -1002,
						TargetFighterUid = action.Lifesteal.TargetFighterUId,
						Value = healValues2[segmentIndex]
					});
				}
			}
		}

		// Token: 0x06042BCB RID: 273355 RVA: 0x0103D6B6 File Offset: 0x0103B8B6
		private int GetSegmentHitDelay(int skillConfigId, int segmentIndex)
		{
			return this.SkillManager.GetSegmentHitDelayMs(skillConfigId, segmentIndex);
		}

		// Token: 0x06042BCC RID: 273356 RVA: 0x0103D6C5 File Offset: 0x0103B8C5
		private void ForceFlushStateTrack()
		{
			while (this.NextStateIdx < this.StateTrack.Count)
			{
				this.ApplyStateEntry(this.StateTrack[this.NextStateIdx]);
				this.NextStateIdx++;
			}
		}

		// Token: 0x06042BCD RID: 273357 RVA: 0x0103D704 File Offset: 0x0103B904
		private static int ExtractTargetFighterUId(IDangoBrawlBattleAction action)
		{
			if (action.AttrChange != null)
			{
				return action.AttrChange.TargetFighterUId;
			}
			if (action.BuffChange != null)
			{
				return action.BuffChange.TargetFighterUId;
			}
			if (action.BuffRemove != null)
			{
				return action.BuffRemove.TargetFighterUId;
			}
			if (action.Death != null)
			{
				return action.Death.TargetFighterUId;
			}
			if (action.SkillCast != null)
			{
				return action.SkillCast.TargetFighterUId;
			}
			if (action.FatigueDamage != null)
			{
				return action.FatigueDamage.TargetFighterUId;
			}
			return 0;
		}

		// Token: 0x06042BCE RID: 273358 RVA: 0x0103D78C File Offset: 0x0103B98C
		[NullableContext(2)]
		private static DangoAttributeComponent GetAttrComp(int fighterUid)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return null;
			}
			bool isSelfByFighterUid = battleManager.GetIsSelfByFighterUid(fighterUid);
			ActivityGameplayEntity entity = battleManager.GetEntity(isSelfByFighterUid);
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<DangoAttributeComponent>();
		}

		// Token: 0x06042BCF RID: 273359 RVA: 0x0103D7C4 File Offset: 0x0103B9C4
		private static bool IsHpLikeAttr(int attrKey)
		{
			return attrKey == 1 || attrKey == 7;
		}

		// Token: 0x04022BBB RID: 142267
		private readonly List<TimerHandle> PendingHandles = new List<TimerHandle>();

		// Token: 0x04022BBC RID: 142268
		private readonly List<int> ActiveEffectIds = new List<int>();

		// Token: 0x04022BBD RID: 142269
		private readonly float MaxTime = 60000f;

		// Token: 0x04022BBE RID: 142270
		private bool HasReportFightOver;

		// Token: 0x04022BBF RID: 142271
		private bool HasChangedToSettle;

		// Token: 0x04022BC0 RID: 142272
		private float TerminalStartMs = -1f;

		// Token: 0x04022BC1 RID: 142273
		private const float TerminalTimeoutMs = 5000f;

		// Token: 0x04022BC2 RID: 142274
		private bool HasNotifiedFatigueFirstTime;

		// Token: 0x04022BC3 RID: 142275
		private bool HasPendingDamageGeometryReset;

		// Token: 0x04022BC7 RID: 142279
		private readonly List<DangoBrawlBattleReportPlayer.StateEntry> StateTrack = new List<DangoBrawlBattleReportPlayer.StateEntry>();

		// Token: 0x04022BC8 RID: 142280
		private readonly List<DangoBrawlBattleReportPlayer.VisualCue> VisualTrack = new List<DangoBrawlBattleReportPlayer.VisualCue>();

		// Token: 0x04022BC9 RID: 142281
		private int NextStateIdx;

		// Token: 0x04022BCA RID: 142282
		private int NextVisualIdx;

		// Token: 0x04022BCB RID: 142283
		private readonly Dictionary<int, Dictionary<int, int>> AttrSnapshotForBuild = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x04022BCC RID: 142284
		private const int NoLoser = -1;

		// Token: 0x04022BCD RID: 142285
		private int TrueLoserFighterUId = -1;

		// Token: 0x04022BCE RID: 142286
		private readonly List<DangoBrawlBattleReportPlayer.AnimCue> SelfAnimTrack = new List<DangoBrawlBattleReportPlayer.AnimCue>();

		// Token: 0x04022BCF RID: 142287
		private readonly List<DangoBrawlBattleReportPlayer.AnimCue> OpponentAnimTrack = new List<DangoBrawlBattleReportPlayer.AnimCue>();

		// Token: 0x04022BD0 RID: 142288
		private int NextSelfAnimIdx;

		// Token: 0x04022BD1 RID: 142289
		private int NextOpponentAnimIdx;

		// Token: 0x0200CA33 RID: 51763
		[NullableContext(0)]
		public class StateEntry
		{
			// Token: 0x0403D1DE RID: 250334
			public int ApplyMs;

			// Token: 0x0403D1DF RID: 250335
			public int SourceGroupUid;

			// Token: 0x0403D1E0 RID: 250336
			public int OriginalIndex;

			// Token: 0x0403D1E1 RID: 250337
			public int SegmentIndex;

			// Token: 0x0403D1E2 RID: 250338
			public int TargetFighterUId;

			// Token: 0x0403D1E3 RID: 250339
			[Nullable(1)]
			public IDangoBrawlBattleAction Action;

			// Token: 0x0403D1E4 RID: 250340
			[Nullable(2)]
			public Dictionary<int, int> AttrDeltas;

			// Token: 0x0403D1E5 RID: 250341
			public bool ForceLoserZero;
		}

		// Token: 0x0200CA34 RID: 51764
		[NullableContext(0)]
		public class VisualCue
		{
			// Token: 0x0403D1E6 RID: 250342
			public int SettleMs;

			// Token: 0x0403D1E7 RID: 250343
			public int SourceGroupUid;

			// Token: 0x0403D1E8 RID: 250344
			public int OriginalIndex;

			// Token: 0x0403D1E9 RID: 250345
			public int SegmentIndex;

			// Token: 0x0403D1EA RID: 250346
			[Nullable(1)]
			public IDangoBrawlBattleAction Action;
		}

		// Token: 0x0200CA35 RID: 51765
		[Nullable(0)]
		public class BattleActionGroupEx
		{
			// Token: 0x0403D1EB RID: 250347
			public int GroupUid;

			// Token: 0x0403D1EC RID: 250348
			public int TriggerMs;

			// Token: 0x0403D1ED RID: 250349
			public List<int> SegmentSettleMsList = new List<int>();

			// Token: 0x0403D1EE RID: 250350
			public List<IDangoBrawlBattleAction> Actions = new List<IDangoBrawlBattleAction>();

			// Token: 0x0403D1EF RID: 250351
			[Nullable(2)]
			public DangoBrawlFightActionSkillCastInfo SkillCastRef;
		}

		// Token: 0x0200CA36 RID: 51766
		[NullableContext(0)]
		public class AnimCue
		{
			// Token: 0x0403D1F0 RID: 250352
			public int TriggerMs;

			// Token: 0x0403D1F1 RID: 250353
			public EDangoBrawlMontageState State;

			// Token: 0x0403D1F2 RID: 250354
			public bool IsSelf;
		}
	}
}
