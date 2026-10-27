using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x0200685F RID: 26719
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBuffManager
	{
		// Token: 0x06042B7F RID: 273279 RVA: 0x0103A332 File Offset: 0x01038532
		public void Init()
		{
			this.EffectManager.Init();
		}

		// Token: 0x06042B80 RID: 273280 RVA: 0x0103A340 File Offset: 0x01038540
		public bool ApplyStateForAction(IDangoBrawlBattleAction action)
		{
			bool result = false;
			if (action.BuffChange != null)
			{
				BuffVisualDelta value = this.ComputeBuffChangeDelta(action.BuffChange);
				this.ApplyBuffChange(action.BuffChange);
				result = true;
				this.PendingVisualDelta[action] = value;
			}
			if (action.BuffRemove != null)
			{
				BuffVisualDelta buffVisualDelta = this.ComputeBuffRemoveDelta(action.BuffRemove);
				if (buffVisualDelta != null)
				{
					this.PendingVisualDelta[action] = buffVisualDelta;
				}
				if (this.ApplyBuffRemove(action.BuffRemove))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06042B81 RID: 273281 RVA: 0x0103A3B8 File Offset: 0x010385B8
		public void PlayVisualForAction(IDangoBrawlBattleAction action)
		{
			BuffVisualDelta buffVisualDelta;
			if (!this.PendingVisualDelta.Remove(action, out buffVisualDelta))
			{
				return;
			}
			if (buffVisualDelta.Op == EDangoBrawlBuffVisualOp.None)
			{
				return;
			}
			DangoBrawlBattleBuffManager.LogBuffVisualDelta(buffVisualDelta);
			this.EffectManager.PlayEffectByDelta(buffVisualDelta);
			EventSystem.Instance.Emit<BuffVisualDelta>(EEventName.OnDangoBrawlBattleBuffVisualCue, buffVisualDelta);
			this.ReportBuffGainText(buffVisualDelta);
		}

		// Token: 0x06042B82 RID: 273282 RVA: 0x0103A40C File Offset: 0x0103860C
		private void ReportBuffGainText(BuffVisualDelta delta)
		{
			if (delta.Op != EDangoBrawlBuffVisualOp.Add && delta.Op != EDangoBrawlBuffVisualOp.StackChange)
			{
				return;
			}
			int num = delta.NewStack - delta.OldStack;
			if (num <= 0)
			{
				return;
			}
			DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(delta.BuffConfigId);
			if (buffConfigById == null)
			{
				return;
			}
			int damageTxtBuffId = buffConfigById.Value.DamageTxtBuffId;
			if (damageTxtBuffId == 0)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlDamageReporter dangoBrawlDamageReporter = (battleManager != null) ? battleManager.Damage : null;
			if (dangoBrawlDamageReporter == null)
			{
				return;
			}
			dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
			{
				Source = EDangoBrawlDamageSource.BuffGain,
				SourceConfigId = delta.BuffConfigId,
				SourceFighterUid = delta.SourceFighterUId,
				TargetFighterUid = delta.TargetFighterUId,
				Value = num,
				ShowType = damageTxtBuffId,
				SourceItemUid = delta.SourceItemUId
			});
		}

		// Token: 0x06042B83 RID: 273283 RVA: 0x0103A4DC File Offset: 0x010386DC
		private BuffVisualDelta ComputeBuffChangeDelta(DangoBrawlFightActionBuffChangeInfo info)
		{
			BuffInfo buffInfo;
			this.GetDictByFighter(info.TargetFighterUId).TryGetValue(info.BuffUId, out buffInfo);
			BuffVisualDelta buffVisualDelta = new BuffVisualDelta
			{
				SourceFighterUId = info.SourceFighterUId,
				TargetFighterUId = info.TargetFighterUId,
				BuffUId = info.BuffUId,
				BuffConfigId = info.BuffConfigId,
				OldStack = ((buffInfo != null) ? buffInfo.Stack : 0),
				NewStack = info.Stack,
				OldRemainingMs = ((buffInfo != null) ? buffInfo.RemainingMs : 0),
				NewRemainingMs = info.RemainingMs,
				SourceItemUId = info.SourceItemUId
			};
			if (buffInfo == null)
			{
				buffVisualDelta.Op = EDangoBrawlBuffVisualOp.Add;
			}
			else if (buffInfo.Stack != info.Stack)
			{
				buffVisualDelta.Op = EDangoBrawlBuffVisualOp.StackChange;
			}
			return buffVisualDelta;
		}

		// Token: 0x06042B84 RID: 273284 RVA: 0x0103A5A4 File Offset: 0x010387A4
		[return: Nullable(2)]
		private BuffVisualDelta ComputeBuffRemoveDelta(DangoBrawlFightActionBuffRemoveInfo info)
		{
			BuffInfo buffInfo;
			if (!this.GetDictByFighter(info.TargetFighterUId).TryGetValue(info.BuffUId, out buffInfo))
			{
				return null;
			}
			return new BuffVisualDelta
			{
				Op = EDangoBrawlBuffVisualOp.Remove,
				TargetFighterUId = info.TargetFighterUId,
				BuffUId = info.BuffUId,
				BuffConfigId = buffInfo.BuffConfigId,
				OldStack = buffInfo.Stack,
				NewStack = 0,
				OldRemainingMs = buffInfo.RemainingMs,
				NewRemainingMs = 0,
				SourceItemUId = buffInfo.SourceItemUId
			};
		}

		// Token: 0x06042B85 RID: 273285 RVA: 0x0103A630 File Offset: 0x01038830
		private static void LogBuffVisualDelta(BuffVisualDelta delta)
		{
		}

		// Token: 0x06042B86 RID: 273286 RVA: 0x0103A634 File Offset: 0x01038834
		private void ApplyBuffChange(DangoBrawlFightActionBuffChangeInfo info)
		{
			Dictionary<int, BuffInfo> dictByFighter = this.GetDictByFighter(info.TargetFighterUId);
			BuffInfo buffInfo;
			if (dictByFighter.TryGetValue(info.BuffUId, out buffInfo))
			{
				buffInfo.CopyFromChangeInfo(info);
				return;
			}
			BuffInfo buffInfo2 = new BuffInfo();
			buffInfo2.CopyFromChangeInfo(info);
			dictByFighter[info.BuffUId] = buffInfo2;
		}

		// Token: 0x06042B87 RID: 273287 RVA: 0x0103A680 File Offset: 0x01038880
		private unsafe bool ApplyBuffRemove(DangoBrawlFightActionBuffRemoveInfo info)
		{
			if (!this.GetDictByFighter(info.TargetFighterUId).ContainsKey(info.BuffUId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[BuffManager] ApplyBuffRemove 找不到对应 Buff";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffUId", info.BuffUId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetFighterUId", info.TargetFighterUId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.PendingRemovals.Add(new ValueTuple<int, int>(info.TargetFighterUId, info.BuffUId));
			return true;
		}

		// Token: 0x06042B88 RID: 273288 RVA: 0x0103A730 File Offset: 0x01038930
		public void FlushPendingRemovals()
		{
			if (this.PendingRemovals.Count == 0)
			{
				return;
			}
			foreach (ValueTuple<int, int> valueTuple in this.PendingRemovals)
			{
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.GetDictByFighter(item).Remove(item2);
			}
			this.PendingRemovals.Clear();
		}

		// Token: 0x06042B89 RID: 273289 RVA: 0x0103A7B0 File Offset: 0x010389B0
		private Dictionary<int, BuffInfo> GetDictByFighter(int fighterUid)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null || !battleManager.GetIsSelfByFighterUid(fighterUid))
			{
				return this.OpponentBuffs;
			}
			return this.SelfBuffs;
		}

		// Token: 0x06042B8A RID: 273290 RVA: 0x0103A7DC File Offset: 0x010389DC
		public void ReportBuffTick(DangoBrawlFightActionBuffTickInfo buffTick)
		{
			BuffInfo buffInfo = this.FindBuffByUid(buffTick.BuffUId);
			if (buffInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[ReportBuffTick] 找不到对应 Buff，跳过飘字";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BuffUId", buffTick.BuffUId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (buffTick.NextReadyMs > 0 && DangoBrawlUtil.ShouldTriggerItemUIEffect(buffInfo.SourceItemUId, EDangoBrawlUIEffectSource.BuffTick))
			{
				DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(buffInfo.BuffConfigId);
				if (buffConfigById != null && buffConfigById.GetValueOrDefault().NeedBuffTickUICD && !DangoBrawlUtil.IsBagItemByUid(buffInfo.SourceItemUId))
				{
					EventSystem.Instance.Emit<int, int>(EEventName.OnDangoBrawlItemCdUpdate, buffInfo.SourceItemUId, buffTick.NextReadyMs);
				}
				if (buffConfigById != null && buffConfigById.GetValueOrDefault().NeedBuffTickUIEffect)
				{
					EventSystem.Instance.Emit<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new DangoBrawlItemUIEffectData
					{
						ItemUId = buffInfo.SourceItemUId,
						IsTriggerLimit = false
					});
				}
			}
			DangoBrawlDamageInfo damageInfo = buffTick.DamageInfo;
			if (((damageInfo != null) ? damageInfo.Damages : null) == null || damageInfo.Damages.Count == 0)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlDamageReporter dangoBrawlDamageReporter = (battleManager != null) ? battleManager.Damage : null;
			if (dangoBrawlDamageReporter == null)
			{
				return;
			}
			bool isCrit = damageInfo.IsCrit;
			foreach (DangoBrawlDamageSegment dangoBrawlDamageSegment in damageInfo.Damages)
			{
				dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
				{
					Source = EDangoBrawlDamageSource.BuffTick,
					SourceConfigId = buffInfo.BuffConfigId,
					SourceFighterUid = buffInfo.SourceFighterUId,
					TargetFighterUid = buffInfo.TargetFighterUId,
					Value = dangoBrawlDamageSegment.Damage,
					IsCrit = isCrit,
					ShowType = dangoBrawlDamageSegment.ShowType,
					SourceItemUid = dangoBrawlDamageSegment.ItemUId
				});
			}
		}

		// Token: 0x06042B8B RID: 273291 RVA: 0x0103A9DC File Offset: 0x01038BDC
		public List<BuffInfo> GetCurrentBuffs(bool isSelf)
		{
			return (isSelf ? this.SelfBuffs : this.OpponentBuffs).Values.ToList<BuffInfo>();
		}

		// Token: 0x06042B8C RID: 273292 RVA: 0x0103A9FC File Offset: 0x01038BFC
		public bool TryGetBuffBrief(int buffUid, out int sourceItemUid, out int buffConfigId)
		{
			BuffInfo buffInfo = this.FindBuffByUid(buffUid);
			if (buffInfo == null)
			{
				sourceItemUid = 0;
				buffConfigId = 0;
				return false;
			}
			sourceItemUid = buffInfo.SourceItemUId;
			buffConfigId = buffInfo.BuffConfigId;
			return true;
		}

		// Token: 0x06042B8D RID: 273293 RVA: 0x0103AA30 File Offset: 0x01038C30
		[NullableContext(2)]
		private BuffInfo FindBuffByUid(int buffUid)
		{
			BuffInfo result;
			if (this.SelfBuffs.TryGetValue(buffUid, out result))
			{
				return result;
			}
			BuffInfo result2;
			if (this.OpponentBuffs.TryGetValue(buffUid, out result2))
			{
				return result2;
			}
			return null;
		}

		// Token: 0x06042B8E RID: 273294 RVA: 0x0103AA62 File Offset: 0x01038C62
		public void Destroy()
		{
			this.EffectManager.Destroy();
			this.PendingVisualDelta.Clear();
			this.PendingRemovals.Clear();
			this.SelfBuffs.Clear();
			this.OpponentBuffs.Clear();
		}

		// Token: 0x04022BB0 RID: 142256
		private readonly Dictionary<int, BuffInfo> SelfBuffs = new Dictionary<int, BuffInfo>();

		// Token: 0x04022BB1 RID: 142257
		private readonly Dictionary<int, BuffInfo> OpponentBuffs = new Dictionary<int, BuffInfo>();

		// Token: 0x04022BB2 RID: 142258
		private readonly Dictionary<IDangoBrawlBattleAction, BuffVisualDelta> PendingVisualDelta = new Dictionary<IDangoBrawlBattleAction, BuffVisualDelta>();

		// Token: 0x04022BB3 RID: 142259
		[TupleElementNames(new string[]
		{
			"TargetFighterUId",
			"BuffUId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> PendingRemovals = new List<ValueTuple<int, int>>();

		// Token: 0x04022BB4 RID: 142260
		private readonly DangoBrawlBattleBuffEffectManager EffectManager = new DangoBrawlBattleBuffEffectManager();
	}
}
