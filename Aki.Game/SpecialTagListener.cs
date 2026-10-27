using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003089 RID: 12425
[NullableContext(1)]
[Nullable(0)]
public class SpecialTagListener
{
	// Token: 0x0601A8B5 RID: 108725 RVA: 0x0071BB54 File Offset: 0x00719D54
	public void InitTagListener(BaseTagComponent tagComp, int tag, List<int> forbid, List<int> target, [Nullable(2)] Func<double, bool> check = null)
	{
		this.TagComp = tagComp;
		this.ListenerTag = tag;
		this.TargetTagList = target;
		this.ForbidTagList = forbid;
		this.CheckCondition = check;
		if (this.TagComp == null)
		{
			return;
		}
		this.TagComp.AddTagAddOrRemoveListener(this.ListenerTag, new BaseTagComponent.TTagSwitchedCallback(this.TagListenerStateChange), null);
		foreach (int tagId in this.ForbidTagList)
		{
			this.TagComp.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.ForbidTagListenerStateChange), null);
		}
	}

	// Token: 0x0601A8B6 RID: 108726 RVA: 0x0071BC08 File Offset: 0x00719E08
	public void ClearTagListener()
	{
		if (this.TagComp == null)
		{
			return;
		}
		this.TagComp.RemoveTagAddOrRemoveListener(this.ListenerTag, new BaseTagComponent.TTagSwitchedCallback(this.TagListenerStateChange));
		foreach (int tagId in this.ForbidTagList)
		{
			this.TagComp.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.ForbidTagListenerStateChange));
		}
	}

	// Token: 0x0601A8B7 RID: 108727 RVA: 0x0071BC94 File Offset: 0x00719E94
	private void TagListenerStateChange(int tagId, bool tagExist)
	{
		this.HasListenerTag = tagExist;
		this.RefreshCondition(0.0);
		this.UpdateTargetTagList();
	}

	// Token: 0x0601A8B8 RID: 108728 RVA: 0x0071BCB4 File Offset: 0x00719EB4
	private void ForbidTagListenerStateChange(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			if (!this.ForbidTagSet.Contains(tagId))
			{
				this.ForbidTagSet.Add(tagId);
			}
		}
		else if (this.ForbidTagSet.Contains(tagId))
		{
			this.ForbidTagSet.Remove(tagId);
		}
		this.RefreshCondition(0.0);
		this.UpdateTargetTagList();
	}

	// Token: 0x0601A8B9 RID: 108729 RVA: 0x0071BD14 File Offset: 0x00719F14
	private void UpdateTargetTagList()
	{
		if (this.TagComp == null)
		{
			return;
		}
		bool flag = this.ForbidTagSet.Count > 0 || !this.HasListenerTag || !this.Condition;
		foreach (int num in this.TargetTagList)
		{
			if (!flag && !this.TagComp.HasTag(num))
			{
				this.TagComp.AddTag(new int?(num));
			}
			if (flag && this.TagComp.HasTag(num))
			{
				this.TagComp.RemoveTag(new int?(num));
			}
		}
	}

	// Token: 0x0601A8BA RID: 108730 RVA: 0x0071BDD4 File Offset: 0x00719FD4
	private bool RefreshCondition(double delta)
	{
		if (this.CheckCondition == null)
		{
			return false;
		}
		bool flag = this.CheckCondition(delta);
		if (this.Condition != flag)
		{
			this.Condition = flag;
			return true;
		}
		return false;
	}

	// Token: 0x0601A8BB RID: 108731 RVA: 0x0071BE0B File Offset: 0x0071A00B
	public void UpdateCondition(double delta)
	{
		if (this.RefreshCondition(delta))
		{
			this.UpdateTargetTagList();
		}
	}

	// Token: 0x0400CBF2 RID: 52210
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CBF3 RID: 52211
	private int ListenerTag;

	// Token: 0x0400CBF4 RID: 52212
	private bool Condition = true;

	// Token: 0x0400CBF5 RID: 52213
	private bool HasListenerTag;

	// Token: 0x0400CBF6 RID: 52214
	private List<int> ForbidTagList = new List<int>();

	// Token: 0x0400CBF7 RID: 52215
	private List<int> TargetTagList = new List<int>();

	// Token: 0x0400CBF8 RID: 52216
	private HashSet<int> ForbidTagSet = new HashSet<int>();

	// Token: 0x0400CBF9 RID: 52217
	[Nullable(2)]
	private Func<double, bool> CheckCondition;
}
