using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027A1 RID: 10145
[NullableContext(1)]
[Nullable(0)]
public class LimitTagHandler
{
	// Token: 0x060196EB RID: 104171 RVA: 0x007C9532 File Offset: 0x007C7732
	public LimitTagHandler(int tagId, int priority, bool tagExist, Action<bool> callBack)
	{
		this.TagId = tagId;
		this.Priority = (double)MathUtils.Instance.Clamp(priority, 0, 3);
		this.TagExist = tagExist;
		this.CallBack = callBack;
	}

	// Token: 0x0400DEEA RID: 57066
	private const int MAX_PRIORITY = 3;

	// Token: 0x0400DEEB RID: 57067
	public int TagId;

	// Token: 0x0400DEEC RID: 57068
	public double Priority;

	// Token: 0x0400DEED RID: 57069
	public bool TagExist;

	// Token: 0x0400DEEE RID: 57070
	public Action<bool> CallBack;

	// Token: 0x0400DEEF RID: 57071
	public List<int> MutuallyTags = new List<int>();

	// Token: 0x0400DEF0 RID: 57072
	public bool Active;
}
