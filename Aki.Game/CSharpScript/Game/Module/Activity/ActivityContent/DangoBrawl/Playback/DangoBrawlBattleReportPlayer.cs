using System;
using System.Collections.Generic;
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
	// Token: 0x020057B4 RID: 22452
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleReportPlayer
	{
		// Token: 0x060376F7 RID: 227063 RVA: 0x00F7C125 File Offset: 0x00F7A325
		public bool IsFightOver()
		{
			return this.HasReportFightOver;
		}

		// Token: 0x060376F8 RID: 227064 RVA: 0x00F7C130 File Offset: 0x00F7A330
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

		// Token: 0x060376F9 RID: 227065 RVA: 0x00F7C1CC File Offset: 0x00F7A3CC
		private void LogFightOver(DangoBrawlBattleManager manager, bool selfWin)
		{
			DangoBrawlFightingClock fightingClock = manager.FightingClock;
			if ((this.NextVisualIdx < this.VisualTrack.Count || this.NextStateIdx < this.StateTrack.Count) && fightingClock != null)
			{
				float elapsed = fightingClock.Elapsed;
				float maxTime = this.MaxTime;
			}
		}

		// Token: 0x060376FA RID: 227066 RVA: 0x00F7C218 File Offset: 0x00F7A418
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

		// Token: 0x060376FB RID: 227067 RVA: 0x00F7C248 File Offset: 0x00F7A448
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

		// Token: 0x17006ACA RID: 27338
		// (get) Token: 0x060376FC RID: 227068 RVA: 0x00F7C354 File Offset: 0x00F7A554
		public DangoBrawlBattleSkillManager SkillManager { get; } = new DangoBrawlBattleSkillManager();

		// Token: 0x17006ACB RID: 27339
		// (get) Token: 0x060376FD RID: 227069 RVA: 0x00F7C35C File Offset: 0x00F7A55C
		public DangoBrawlBattleBuffManager BuffManager { get; } = new DangoBrawlBattleBuffManager();

		// Token: 0x17006ACC RID: 27340
		// (get) Token: 0x060376FE RID: 227070 RVA: 0x00F7C364 File Offset: 0x00F7A564
		public DangoBrawlBattleFatigueDamageManager FatigueDamageManager { get; } = new DangoBrawlBattleFatigueDamageManager();

		// Token: 0x060376FF RID: 227071 RVA: 0x00F7C36C File Offset: 0x00F7A56C
		public void Init()
		{
			this.SkillManager.Init();
			this.BuffManager.Init();
			this.FatigueDamageManager.Init();
			this.BuildDualTracks();
		}

		// Token: 0x06037700 RID: 227072 RVA: 0x00F7C398 File Offset: 0x00F7A598
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

		// Token: 0x06037701 RID: 227073 RVA: 0x00F7C4C4 File Offset: 0x00F7A6C4
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

		// Token: 0x06037702 RID: 227074 RVA: 0x00F7C524 File Offset: 0x00F7A724
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

		// Token: 0x06037703 RID: 227075 RVA: 0x00F7C567 File Offset: 0x00F7A767
		public void Destroy()
		{
			this.ClearAllPerformances();
			this.SkillManager.Destroy();
			this.BuffManager.Destroy();
			this.FatigueDamageManager.Destroy();
		}

		// Token: 0x06037704 RID: 227076 RVA: 0x00F7C590 File Offset: 0x00F7A790
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

		// Token: 0x06037705 RID: 227077 RVA: 0x00F7C650 File Offset: 0x00F7A850
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

		// Token: 0x06037706 RID: 227078 RVA: 0x00F7C718 File Offset: 0x00F7A918
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

		// Token: 0x06037707 RID: 227079 RVA: 0x00F7C7A4 File Offset: 0x00F7A9A4
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

		// Token: 0x06037708 RID: 227080 RVA: 0x00F7C7F4 File Offset: 0x00F7A9F4
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

		// Token: 0x06037709 RID: 227081 RVA: 0x00F7C880 File Offset: 0x00F7AA80
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

		// Token: 0x0603770A RID: 227082 RVA: 0x00F7C914 File Offset: 0x00F7AB14
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

		// Token: 0x0603770B RID: 227083 RVA: 0x00F7CA48 File Offset: 0x00F7AC48
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

		// Token: 0x0603770C RID: 227084 RVA: 0x00F7CA90 File Offset: 0x00F7AC90
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

		// Token: 0x0603770D RID: 227085 RVA: 0x00F7CB60 File Offset: 0x00F7AD60
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
				}
			}
		}

		// Token: 0x0603770E RID: 227086 RVA: 0x00F7CC68 File Offset: 0x00F7AE68
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

		// Token: 0x0603770F RID: 227087 RVA: 0x00F7CF00 File Offset: 0x00F7B100
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

		// Token: 0x06037710 RID: 227088 RVA: 0x00F7D0FC File Offset: 0x00F7B2FC
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

		// Token: 0x06037711 RID: 227089 RVA: 0x00F7D548 File Offset: 0x00F7B748
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

		// Token: 0x06037712 RID: 227090 RVA: 0x00F7D9F8 File Offset: 0x00F7BBF8
		private void SortTracksStable()
		{
			List<DangoBrawlBattleReportPlayer.StateEntry> stateTrack = this.StateTrack;
			Comparison<DangoBrawlBattleReportPlayer.StateEntry> comparison;
			if ((comparison = DangoBrawlBattleReportPlayer.<>O.<0>__CompareStateEntry) == null)
			{
				comparison = (DangoBrawlBattleReportPlayer.<>O.<0>__CompareStateEntry = new Comparison<DangoBrawlBattleReportPlayer.StateEntry>(DangoBrawlBattleReportPlayer.CompareStateEntry));
			}
			NoLinq.SortStable<DangoBrawlBattleReportPlayer.StateEntry>(stateTrack, comparison);
			List<DangoBrawlBattleReportPlayer.VisualCue> visualTrack = this.VisualTrack;
			Comparison<DangoBrawlBattleReportPlayer.VisualCue> comparison2;
			if ((comparison2 = DangoBrawlBattleReportPlayer.<>O.<1>__CompareVisualCue) == null)
			{
				comparison2 = (DangoBrawlBattleReportPlayer.<>O.<1>__CompareVisualCue = new Comparison<DangoBrawlBattleReportPlayer.VisualCue>(DangoBrawlBattleReportPlayer.CompareVisualCue));
			}
			NoLinq.SortStable<DangoBrawlBattleReportPlayer.VisualCue>(visualTrack, comparison2);
		}

		// Token: 0x06037713 RID: 227091 RVA: 0x00F7DA54 File Offset: 0x00F7BC54
		private static int CompareStateEntry(DangoBrawlBattleReportPlayer.StateEntry a, DangoBrawlBattleReportPlayer.StateEntry b)
		{
			int num = a.ApplyMs.CompareTo(b.ApplyMs);
			if (num != 0)
			{
				return num;
			}
			num = a.OriginalIndex.CompareTo(b.OriginalIndex);
			if (num != 0)
			{
				return num;
			}
			return a.SegmentIndex.CompareTo(b.SegmentIndex);
		}

		// Token: 0x06037714 RID: 227092 RVA: 0x00F7DAA0 File Offset: 0x00F7BCA0
		private static int CompareVisualCue(DangoBrawlBattleReportPlayer.VisualCue a, DangoBrawlBattleReportPlayer.VisualCue b)
		{
			int num = a.SettleMs.CompareTo(b.SettleMs);
			if (num != 0)
			{
				return num;
			}
			num = a.OriginalIndex.CompareTo(b.OriginalIndex);
			if (num != 0)
			{
				return num;
			}
			return a.SegmentIndex.CompareTo(b.SegmentIndex);
		}

		// Token: 0x06037715 RID: 227093 RVA: 0x00F7DAEC File Offset: 0x00F7BCEC
		private void TickStateTrack(int nowMs)
		{
			while (this.NextStateIdx < this.StateTrack.Count && this.StateTrack[this.NextStateIdx].ApplyMs <= nowMs)
			{
				this.ApplyStateEntry(this.StateTrack[this.NextStateIdx]);
				this.NextStateIdx++;
			}
		}

		// Token: 0x06037716 RID: 227094 RVA: 0x00F7DB4C File Offset: 0x00F7BD4C
		private void TickVisualTrack(int nowMs)
		{
			while (this.NextVisualIdx < this.VisualTrack.Count && this.VisualTrack[this.NextVisualIdx].SettleMs <= nowMs)
			{
				this.PlayVisualCue(this.VisualTrack[this.NextVisualIdx]);
				this.NextVisualIdx++;
			}
		}

		// Token: 0x06037717 RID: 227095 RVA: 0x00F7DBAC File Offset: 0x00F7BDAC
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

		// Token: 0x06037718 RID: 227096 RVA: 0x00F7DC68 File Offset: 0x00F7BE68
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

		// Token: 0x06037719 RID: 227097 RVA: 0x00F7DDB0 File Offset: 0x00F7BFB0
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

		// Token: 0x0603771A RID: 227098 RVA: 0x00F7DE1C File Offset: 0x00F7C01C
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

		// Token: 0x0603771B RID: 227099 RVA: 0x00F7DE9C File Offset: 0x00F7C09C
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

		// Token: 0x0603771C RID: 227100 RVA: 0x00F7E000 File Offset: 0x00F7C200
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

		// Token: 0x0603771D RID: 227101 RVA: 0x00F7E3A0 File Offset: 0x00F7C5A0
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

		// Token: 0x0603771E RID: 227102 RVA: 0x00F7E860 File Offset: 0x00F7CA60
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

		// Token: 0x0603771F RID: 227103 RVA: 0x00F7E8E4 File Offset: 0x00F7CAE4
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

		// Token: 0x06037720 RID: 227104 RVA: 0x00F7E958 File Offset: 0x00F7CB58
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

		// Token: 0x06037721 RID: 227105 RVA: 0x00F7E9BC File Offset: 0x00F7CBBC
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

		// Token: 0x06037722 RID: 227106 RVA: 0x00F7EB96 File Offset: 0x00F7CD96
		private int GetSegmentHitDelay(int skillConfigId, int segmentIndex)
		{
			return this.SkillManager.GetSegmentHitDelayMs(skillConfigId, segmentIndex);
		}

		// Token: 0x06037723 RID: 227107 RVA: 0x00F7EBA5 File Offset: 0x00F7CDA5
		private void ForceFlushStateTrack()
		{
			while (this.NextStateIdx < this.StateTrack.Count)
			{
				this.ApplyStateEntry(this.StateTrack[this.NextStateIdx]);
				this.NextStateIdx++;
			}
		}

		// Token: 0x06037724 RID: 227108 RVA: 0x00F7EBE4 File Offset: 0x00F7CDE4
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

		// Token: 0x06037725 RID: 227109 RVA: 0x00F7EC6C File Offset: 0x00F7CE6C
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

		// Token: 0x06037726 RID: 227110 RVA: 0x00F7ECA4 File Offset: 0x00F7CEA4
		private static bool IsHpLikeAttr(int attrKey)
		{
			return attrKey == 1 || attrKey == 7;
		}

		// Token: 0x0401D418 RID: 119832
		private readonly List<TimerHandle> PendingHandles = new List<TimerHandle>();

		// Token: 0x0401D419 RID: 119833
		private readonly List<int> ActiveEffectIds = new List<int>();

		// Token: 0x0401D41A RID: 119834
		private readonly float MaxTime = 60000f;

		// Token: 0x0401D41B RID: 119835
		private bool HasReportFightOver;

		// Token: 0x0401D41C RID: 119836
		private bool HasChangedToSettle;

		// Token: 0x0401D41D RID: 119837
		private float TerminalStartMs = -1f;

		// Token: 0x0401D41E RID: 119838
		private const float TerminalTimeoutMs = 5000f;

		// Token: 0x0401D41F RID: 119839
		private bool HasNotifiedFatigueFirstTime;

		// Token: 0x0401D420 RID: 119840
		private bool HasPendingDamageGeometryReset;

		// Token: 0x0401D424 RID: 119844
		private readonly List<DangoBrawlBattleReportPlayer.StateEntry> StateTrack = new List<DangoBrawlBattleReportPlayer.StateEntry>();

		// Token: 0x0401D425 RID: 119845
		private readonly List<DangoBrawlBattleReportPlayer.VisualCue> VisualTrack = new List<DangoBrawlBattleReportPlayer.VisualCue>();

		// Token: 0x0401D426 RID: 119846
		private int NextStateIdx;

		// Token: 0x0401D427 RID: 119847
		private int NextVisualIdx;

		// Token: 0x0401D428 RID: 119848
		private readonly Dictionary<int, Dictionary<int, int>> AttrSnapshotForBuild = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401D429 RID: 119849
		private const int NoLoser = -1;

		// Token: 0x0401D42A RID: 119850
		private int TrueLoserFighterUId = -1;

		// Token: 0x0401D42B RID: 119851
		private readonly List<DangoBrawlBattleReportPlayer.AnimCue> SelfAnimTrack = new List<DangoBrawlBattleReportPlayer.AnimCue>();

		// Token: 0x0401D42C RID: 119852
		private readonly List<DangoBrawlBattleReportPlayer.AnimCue> OpponentAnimTrack = new List<DangoBrawlBattleReportPlayer.AnimCue>();

		// Token: 0x0401D42D RID: 119853
		private int NextSelfAnimIdx;

		// Token: 0x0401D42E RID: 119854
		private int NextOpponentAnimIdx;

		// Token: 0x0200B3FD RID: 46077
		[NullableContext(0)]
		public class StateEntry
		{
			// Token: 0x04037AC3 RID: 228035
			public int ApplyMs;

			// Token: 0x04037AC4 RID: 228036
			public int SourceGroupUid;

			// Token: 0x04037AC5 RID: 228037
			public int OriginalIndex;

			// Token: 0x04037AC6 RID: 228038
			public int SegmentIndex;

			// Token: 0x04037AC7 RID: 228039
			public int TargetFighterUId;

			// Token: 0x04037AC8 RID: 228040
			[Nullable(1)]
			public IDangoBrawlBattleAction Action;

			// Token: 0x04037AC9 RID: 228041
			[Nullable(2)]
			public Dictionary<int, int> AttrDeltas;

			// Token: 0x04037ACA RID: 228042
			public bool ForceLoserZero;
		}

		// Token: 0x0200B3FE RID: 46078
		[NullableContext(0)]
		public class VisualCue
		{
			// Token: 0x04037ACB RID: 228043
			public int SettleMs;

			// Token: 0x04037ACC RID: 228044
			public int SourceGroupUid;

			// Token: 0x04037ACD RID: 228045
			public int OriginalIndex;

			// Token: 0x04037ACE RID: 228046
			public int SegmentIndex;

			// Token: 0x04037ACF RID: 228047
			[Nullable(1)]
			public IDangoBrawlBattleAction Action;
		}

		// Token: 0x0200B3FF RID: 46079
		[Nullable(0)]
		public class BattleActionGroupEx
		{
			// Token: 0x04037AD0 RID: 228048
			public int GroupUid;

			// Token: 0x04037AD1 RID: 228049
			public int TriggerMs;

			// Token: 0x04037AD2 RID: 228050
			public List<int> SegmentSettleMsList = new List<int>();

			// Token: 0x04037AD3 RID: 228051
			public List<IDangoBrawlBattleAction> Actions = new List<IDangoBrawlBattleAction>();

			// Token: 0x04037AD4 RID: 228052
			[Nullable(2)]
			public DangoBrawlFightActionSkillCastInfo SkillCastRef;
		}

		// Token: 0x0200B400 RID: 46080
		[NullableContext(0)]
		public class AnimCue
		{
			// Token: 0x04037AD5 RID: 228053
			public int TriggerMs;

			// Token: 0x04037AD6 RID: 228054
			public EDangoBrawlMontageState State;

			// Token: 0x04037AD7 RID: 228055
			public bool IsSelf;
		}

		// Token: 0x0200B401 RID: 46081
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037AD8 RID: 228056
			[Nullable(0)]
			public static Comparison<DangoBrawlBattleReportPlayer.StateEntry> <0>__CompareStateEntry;

			// Token: 0x04037AD9 RID: 228057
			[Nullable(0)]
			public static Comparison<DangoBrawlBattleReportPlayer.VisualCue> <1>__CompareVisualCue;
		}
	}
}
