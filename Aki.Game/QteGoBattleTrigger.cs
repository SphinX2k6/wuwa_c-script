using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002544 RID: 9540
[NullableContext(1)]
[Nullable(0)]
public class QteGoBattleTrigger : Trigger
{
	// Token: 0x0601794B RID: 96587 RVA: 0x006F6CD2 File Offset: 0x006F4ED2
	[NullableContext(2)]
	public QteGoBattleTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601794C RID: 96588 RVA: 0x006F6CE3 File Offset: 0x006F4EE3
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601794D RID: 96589 RVA: 0x006F6D00 File Offset: 0x006F4F00
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

	// Token: 0x0601794E RID: 96590 RVA: 0x006F6D74 File Offset: 0x006F4F74
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

	// Token: 0x0601794F RID: 96591 RVA: 0x006F6DE8 File Offset: 0x006F4FE8
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

	// Token: 0x06017950 RID: 96592 RVA: 0x006F6EE0 File Offset: 0x006F50E0
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C899 RID: 51353
	protected ETriggerTargetType TargetType;
}
