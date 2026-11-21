using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x0200253B RID: 9531
[NullableContext(1)]
[Nullable(0)]
public class TagStackTrigger : Trigger
{
	// Token: 0x06017910 RID: 96528 RVA: 0x006F55BC File Offset: 0x006F37BC
	[NullableContext(2)]
	public TagStackTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017911 RID: 96529 RVA: 0x006F55D0 File Offset: 0x006F37D0
	public override void OnInitParams(string[] triggerParams)
	{
		string tagName = (triggerParams.Length != 0) ? triggerParams[0].Trim() : string.Empty;
		this.TagId = GameplayTagUtils.GetTagIdByName(tagName);
		this.InitBehavior = (TagTrigger.ETagTriggerInitBehavior)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x06017912 RID: 96530 RVA: 0x006F5618 File Offset: 0x006F3818
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

	// Token: 0x06017913 RID: 96531 RVA: 0x006F56CC File Offset: 0x006F38CC
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

	// Token: 0x06017914 RID: 96532 RVA: 0x006F5714 File Offset: 0x006F3914
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

	// Token: 0x06017915 RID: 96533 RVA: 0x006F5770 File Offset: 0x006F3970
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C885 RID: 51333
	protected int TagId;

	// Token: 0x0400C886 RID: 51334
	protected int OldCount;

	// Token: 0x0400C887 RID: 51335
	protected TagTrigger.ETagTriggerInitBehavior InitBehavior;
}
