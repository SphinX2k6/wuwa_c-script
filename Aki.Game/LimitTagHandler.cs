using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003232 RID: 12850
[NullableContext(1)]
[Nullable(0)]
public class LimitTagHandler
{
	// Token: 0x0601BB66 RID: 113510 RVA: 0x007A0C26 File Offset: 0x0079EE26
	public LimitTagHandler(int tagId, int priority, bool tagExist, Action<bool> callBack)
	{
		this.TagId = tagId;
		this.Priority = (double)MathUtils.Instance.Clamp(priority, 0, 3);
		this.TagExist = tagExist;
		this.CallBack = callBack;
	}

	// Token: 0x0400DA4B RID: 55883
	private const int MAX_PRIORITY = 3;

	// Token: 0x0400DA4C RID: 55884
	public int TagId;

	// Token: 0x0400DA4D RID: 55885
	public double Priority;

	// Token: 0x0400DA4E RID: 55886
	public bool TagExist;

	// Token: 0x0400DA4F RID: 55887
	public Action<bool> CallBack;

	// Token: 0x0400DA50 RID: 55888
	public List<int> MutuallyTags = new List<int>();

	// Token: 0x0400DA51 RID: 55889
	public bool Active;
}
