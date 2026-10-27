using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E7A RID: 7802
[NullableContext(1)]
[Nullable(0)]
public class HonamiSortOrderListClass
{
	// Token: 0x0600EDCF RID: 60879 RVA: 0x0038A870 File Offset: 0x00388A70
	public List<List<int>> GetSortOrderList(int length)
	{
		if (length == this.CurCacheLength)
		{
			return this.OutputResult;
		}
		this.OutputResult.Clear();
		this.TempOrderRes.Clear();
		this.OccupyList.Clear();
		for (int i = 0; i < length; i++)
		{
			this.OccupyList.Add(false);
		}
		this.CreateSortOrder();
		this.CurCacheLength = length;
		return this.OutputResult;
	}

	// Token: 0x0600EDD0 RID: 60880 RVA: 0x0038A8DC File Offset: 0x00388ADC
	private void CreateSortOrder()
	{
		if (this.TempOrderRes.Count == this.OccupyList.Count)
		{
			this.OutputResult.Add(new List<int>(this.TempOrderRes));
			return;
		}
		for (int i = 0; i < this.OccupyList.Count; i++)
		{
			if (!this.OccupyList[i])
			{
				this.OccupyList[i] = true;
				this.TempOrderRes.Add(i);
				this.CreateSortOrder();
				this.TempOrderRes.RemoveAt(this.TempOrderRes.Count - 1);
				this.OccupyList[i] = false;
			}
		}
	}

	// Token: 0x04006E55 RID: 28245
	private readonly List<int> TempOrderRes = new List<int>();

	// Token: 0x04006E56 RID: 28246
	private readonly List<bool> OccupyList = new List<bool>();

	// Token: 0x04006E57 RID: 28247
	private readonly List<List<int>> OutputResult = new List<List<int>>();

	// Token: 0x04006E58 RID: 28248
	private int CurCacheLength;
}
