using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200133C RID: 4924
[NullableContext(1)]
[Nullable(0)]
public class HonamiSortOrderListClass
{
	// Token: 0x0600C1EE RID: 49646 RVA: 0x00396460 File Offset: 0x00394660
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

	// Token: 0x0600C1EF RID: 49647 RVA: 0x003964CC File Offset: 0x003946CC
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

	// Token: 0x04006F36 RID: 28470
	private readonly List<int> TempOrderRes = new List<int>();

	// Token: 0x04006F37 RID: 28471
	private readonly List<bool> OccupyList = new List<bool>();

	// Token: 0x04006F38 RID: 28472
	private readonly List<List<int>> OutputResult = new List<List<int>>();

	// Token: 0x04006F39 RID: 28473
	private int CurCacheLength;
}
