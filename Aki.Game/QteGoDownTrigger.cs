using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002545 RID: 9541
[NullableContext(1)]
[Nullable(0)]
public class QteGoDownTrigger : Trigger
{
	// Token: 0x06017951 RID: 96593 RVA: 0x006F6EE7 File Offset: 0x006F50E7
	[NullableContext(2)]
	public QteGoDownTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017952 RID: 96594 RVA: 0x006F6EF8 File Offset: 0x006F50F8
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06017953 RID: 96595 RVA: 0x006F6F14 File Offset: 0x006F5114
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

	// Token: 0x06017954 RID: 96596 RVA: 0x006F6F88 File Offset: 0x006F5188
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

	// Token: 0x06017955 RID: 96597 RVA: 0x006F6FFC File Offset: 0x006F51FC
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

	// Token: 0x06017956 RID: 96598 RVA: 0x006F70E3 File Offset: 0x006F52E3
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C89A RID: 51354
	protected ETriggerTargetType TargetType;
}
