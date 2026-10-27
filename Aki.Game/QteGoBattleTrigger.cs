using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FEF RID: 12271
[NullableContext(1)]
[Nullable(0)]
public class QteGoBattleTrigger : Trigger
{
	// Token: 0x0601A017 RID: 106519 RVA: 0x006CEE36 File Offset: 0x006CD036
	[NullableContext(2)]
	public QteGoBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A018 RID: 106520 RVA: 0x006CEE47 File Offset: 0x006CD047
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A019 RID: 106521 RVA: 0x006CEE64 File Offset: 0x006CD064
	protected override void OnActive()
	{
		if (!EventSystem.Instance.Has<int, int, int>(EEventName.CharExecuteQte, new Action<int, int, int>(this.OnEvent)))
		{
			EventSystem.Instance.Add<int, int, int>(EEventName.CharExecuteQte, new Action<int, int, int>(this.OnEvent));
		}
		if (!EventSystem.Instance.Has<int, int, int>(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnEvent)))
		{
			EventSystem.Instance.Add<int, int, int>(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnEvent));
		}
	}

	// Token: 0x0601A01A RID: 106522 RVA: 0x006CEED8 File Offset: 0x006CD0D8
	protected override void OnInactive()
	{
		if (EventSystem.Instance.Has<int, int, int>(EEventName.CharExecuteQte, new Action<int, int, int>(this.OnEvent)))
		{
			EventSystem.Instance.Remove<int, int, int>(EEventName.CharExecuteQte, new Action<int, int, int>(this.OnEvent));
		}
		if (EventSystem.Instance.Has<int, int, int>(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnEvent)))
		{
			EventSystem.Instance.Remove<int, int, int>(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnEvent));
		}
	}

	// Token: 0x0601A01B RID: 106523 RVA: 0x006CEF4C File Offset: 0x006CD14C
	private void OnEvent(int goBattleEntityId, int goDownEntityId, int roleQteType)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		ETriggerTargetType targetType = this.TargetType;
		if (targetType != ETriggerTargetType.Self)
		{
			if (targetType == ETriggerTargetType.LocalFormation)
			{
				SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)goBattleEntityId, new GetTeamItemOptions
				{
					ParamType = ETeamParamType.EntityId
				});
				if (teamItem == null || !teamItem.IsMyRole())
				{
					return;
				}
			}
		}
		else
		{
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			int? num;
			if (ownerTriggerComp == null)
			{
				num = null;
			}
			else
			{
				Entity entity = ownerTriggerComp.Entity;
				num = ((entity != null) ? new int?(entity.Id) : null);
			}
			int? num2 = num;
			if (!(goBattleEntityId == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["GoBattleEntity"] = EntitySystem.Instance.Get(goBattleEntityId);
		dictionary["GoDownEntity"] = EntitySystem.Instance.Get(goDownEntityId);
		dictionary["QteType"] = roleQteType;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A01C RID: 106524 RVA: 0x006CF044 File Offset: 0x006CD244
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D1 RID: 50385
	protected ETriggerTargetType TargetType;
}
