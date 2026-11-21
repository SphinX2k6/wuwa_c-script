using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002549 RID: 9545
[NullableContext(1)]
[Nullable(0)]
public class VisionTrigger : Trigger
{
	// Token: 0x0601796B RID: 96619 RVA: 0x006F79E6 File Offset: 0x006F5BE6
	[NullableContext(2)]
	public VisionTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601796C RID: 96620 RVA: 0x006F7A14 File Offset: 0x006F5C14
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.VisionIds.Clear();
		this.AllVision = false;
		this.TriggerCount = 0;
		this.TriggerCountMap.Clear();
		string[] array = ((triggerParams.Length > 1) ? triggerParams[1] : string.Empty).Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			int num;
			if (int.TryParse(array[i], out num))
			{
				this.VisionIds.Add(num);
				if (num == -1)
				{
					this.AllVision = true;
				}
			}
		}
		this.EachVisionMaxTriggerCount = Convert.ToInt32((triggerParams.Length > 2) ? triggerParams[2] : "-1");
	}

	// Token: 0x0601796D RID: 96621 RVA: 0x006F7AC4 File Offset: 0x006F5CC4
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent));
		}
	}

	// Token: 0x0601796E RID: 96622 RVA: 0x006F7B30 File Offset: 0x006F5D30
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent));
		}
	}

	// Token: 0x0601796F RID: 96623 RVA: 0x006F7B9C File Offset: 0x006F5D9C
	private void OnEvent(int visionId)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (!this.AllVision)
		{
			bool flag = false;
			for (int i = 0; i < this.VisionIds.Count; i++)
			{
				if (this.VisionIds[i] == visionId)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		int num2;
		int num = this.TriggerCountMap.TryGetValue(visionId, out num2) ? num2 : 0;
		this.TriggerCountMap[visionId] = num + 1;
		if (this.EachVisionMaxTriggerCount < 0 || num < this.EachVisionMaxTriggerCount)
		{
			this.TriggerCount++;
			Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
			dictionary["TriggerCount"] = this.TriggerCount;
			base.EvaluateAndExecute(dictionary);
		}
	}

	// Token: 0x06017970 RID: 96624 RVA: 0x006F7C5B File Offset: 0x006F5E5B
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8A3 RID: 51363
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8A4 RID: 51364
	protected readonly List<int> VisionIds = new List<int>();

	// Token: 0x0400C8A5 RID: 51365
	protected bool AllVision;

	// Token: 0x0400C8A6 RID: 51366
	protected int TriggerCount;

	// Token: 0x0400C8A7 RID: 51367
	protected int EachVisionMaxTriggerCount = -1;

	// Token: 0x0400C8A8 RID: 51368
	protected readonly Dictionary<int, int> TriggerCountMap = new Dictionary<int, int>();
}
