using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020025E0 RID: 9696
[NullableContext(1)]
[Nullable(0)]
public class SpecialTagListener
{
	// Token: 0x0601829C RID: 98972 RVA: 0x00741F0C File Offset: 0x0074010C
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

	// Token: 0x0601829D RID: 98973 RVA: 0x00741FC0 File Offset: 0x007401C0
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

	// Token: 0x0601829E RID: 98974 RVA: 0x0074204C File Offset: 0x0074024C
	private void TagListenerStateChange(int tagId, bool tagExist)
	{
		this.HasListenerTag = tagExist;
		this.RefreshCondition(0.0);
		this.UpdateTargetTagList();
	}

	// Token: 0x0601829F RID: 98975 RVA: 0x0074206C File Offset: 0x0074026C
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

	// Token: 0x060182A0 RID: 98976 RVA: 0x007420CC File Offset: 0x007402CC
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

	// Token: 0x060182A1 RID: 98977 RVA: 0x0074218C File Offset: 0x0074038C
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

	// Token: 0x060182A2 RID: 98978 RVA: 0x007421C3 File Offset: 0x007403C3
	public void UpdateCondition(double delta)
	{
		if (this.RefreshCondition(delta))
		{
			this.UpdateTargetTagList();
		}
	}

	// Token: 0x0400CFD5 RID: 53205
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CFD6 RID: 53206
	private int ListenerTag;

	// Token: 0x0400CFD7 RID: 53207
	private bool Condition = true;

	// Token: 0x0400CFD8 RID: 53208
	private bool HasListenerTag;

	// Token: 0x0400CFD9 RID: 53209
	private List<int> ForbidTagList = new List<int>();

	// Token: 0x0400CFDA RID: 53210
	private List<int> TargetTagList = new List<int>();

	// Token: 0x0400CFDB RID: 53211
	private HashSet<int> ForbidTagSet = new HashSet<int>();

	// Token: 0x0400CFDC RID: 53212
	[Nullable(2)]
	private Func<double, bool> CheckCondition;
}
