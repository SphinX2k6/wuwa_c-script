using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FF4 RID: 12276
[NullableContext(1)]
[Nullable(0)]
public class VisionTrigger : Trigger
{
	// Token: 0x0601A037 RID: 106551 RVA: 0x006CFB4A File Offset: 0x006CDD4A
	[NullableContext(2)]
	public VisionTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A038 RID: 106552 RVA: 0x006CFB78 File Offset: 0x006CDD78
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

	// Token: 0x0601A039 RID: 106553 RVA: 0x006CFC28 File Offset: 0x006CDE28
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent));
		}
	}

	// Token: 0x0601A03A RID: 106554 RVA: 0x006CFC94 File Offset: 0x006CDE94
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<int>(target, EEventName.ActivateAbilityVision, new Action<int>(this.OnEvent));
		}
	}

	// Token: 0x0601A03B RID: 106555 RVA: 0x006CFD00 File Offset: 0x006CDF00
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

	// Token: 0x0601A03C RID: 106556 RVA: 0x006CFDBF File Offset: 0x006CDFBF
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4DB RID: 50395
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4DC RID: 50396
	protected readonly List<int> VisionIds = new List<int>();

	// Token: 0x0400C4DD RID: 50397
	protected bool AllVision;

	// Token: 0x0400C4DE RID: 50398
	protected int TriggerCount;

	// Token: 0x0400C4DF RID: 50399
	protected int EachVisionMaxTriggerCount = -1;

	// Token: 0x0400C4E0 RID: 50400
	protected readonly Dictionary<int, int> TriggerCountMap = new Dictionary<int, int>();
}
