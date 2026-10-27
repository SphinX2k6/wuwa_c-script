using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FF0 RID: 12272
[NullableContext(1)]
[Nullable(0)]
public class QteGoDownTrigger : Trigger
{
	// Token: 0x0601A01D RID: 106525 RVA: 0x006CF04B File Offset: 0x006CD24B
	[NullableContext(2)]
	public QteGoDownTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A01E RID: 106526 RVA: 0x006CF05C File Offset: 0x006CD25C
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A01F RID: 106527 RVA: 0x006CF078 File Offset: 0x006CD278
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

	// Token: 0x0601A020 RID: 106528 RVA: 0x006CF0EC File Offset: 0x006CD2EC
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

	// Token: 0x0601A021 RID: 106529 RVA: 0x006CF160 File Offset: 0x006CD360
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
				SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)goDownEntityId, new GetTeamItemOptions
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
			if (!(goDownEntityId == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["GoBattleEntity"] = EntitySystem.Instance.Get(goBattleEntityId);
		dictionary["GoDownEntity"] = EntitySystem.Instance.Get(goDownEntityId);
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A022 RID: 106530 RVA: 0x006CF247 File Offset: 0x006CD447
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D2 RID: 50386
	protected ETriggerTargetType TargetType;
}
