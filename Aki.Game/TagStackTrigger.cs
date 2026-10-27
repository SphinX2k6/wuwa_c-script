using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FE6 RID: 12262
[NullableContext(1)]
[Nullable(0)]
public class TagStackTrigger : Trigger
{
	// Token: 0x06019FDC RID: 106460 RVA: 0x006CD6F0 File Offset: 0x006CB8F0
	[NullableContext(2)]
	public TagStackTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FDD RID: 106461 RVA: 0x006CD704 File Offset: 0x006CB904
	public override void OnInitParams(string[] triggerParams)
	{
		string tagName = (triggerParams.Length != 0) ? triggerParams[0].Trim() : string.Empty;
		this.TagId = GameplayTagUtils.GetTagIdByName(tagName);
		this.InitBehavior = (TagTrigger.ETagTriggerInitBehavior)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x06019FDE RID: 106462 RVA: 0x006CD74C File Offset: 0x006CB94C
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		BaseTagComponent baseTagComponent;
		if (ownerTriggerComp == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null)
		{
			return;
		}
		int tagCount = baseTagComponent2.GetTagCount(this.TagId);
		switch (this.InitBehavior)
		{
		case TagTrigger.ETagTriggerInitBehavior.CheckWhenHasTag:
			if (tagCount > 0)
			{
				this.OnEvent(tagCount, this.TagId, this.TagId, this.OldCount);
			}
			break;
		case TagTrigger.ETagTriggerInitBehavior.CheckWhenNotHasTag:
			if (tagCount <= 0)
			{
				this.OnEvent(tagCount, this.TagId, this.TagId, this.OldCount);
			}
			break;
		}
		this.OldCount = tagCount;
		baseTagComponent2.AddTagChangedListener(this.TagId, new BaseTagComponent.TTagChangedCallback(this.OnEvent), null);
	}

	// Token: 0x06019FDF RID: 106463 RVA: 0x006CD800 File Offset: 0x006CBA00
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		BaseTagComponent baseTagComponent;
		if (ownerTriggerComp == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null)
		{
			return;
		}
		baseTagComponent2.RemoveTagChangedListener(this.TagId, new BaseTagComponent.TTagChangedCallback(this.OnEvent));
	}

	// Token: 0x06019FE0 RID: 106464 RVA: 0x006CD848 File Offset: 0x006CBA48
	protected void OnEvent(int newCount, int tagId, int exactTagId, int oldCount)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["NewStack"] = newCount;
		dictionary["OldStack"] = this.OldCount;
		base.EvaluateAndExecute(dictionary);
		this.OldCount = newCount;
	}

	// Token: 0x06019FE1 RID: 106465 RVA: 0x006CD8A4 File Offset: 0x006CBAA4
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4BD RID: 50365
	protected int TagId;

	// Token: 0x0400C4BE RID: 50366
	protected int OldCount;

	// Token: 0x0400C4BF RID: 50367
	protected TagTrigger.ETagTriggerInitBehavior InitBehavior;
}
