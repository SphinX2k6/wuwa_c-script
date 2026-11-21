using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020005B3 RID: 1459
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteRingInfo
{
	// Token: 0x060044F1 RID: 17649 RVA: 0x0017AF3E File Offset: 0x0017913E
	public ArtemisQteRingInfo(EArrowDirection arrowDirection)
	{
		this.ArrowDirection = arrowDirection;
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x0017AF7C File Offset: 0x0017917C
	public void Clear()
	{
		this.ValidAreas.Clear();
		this.QteAreas.Clear();
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x0017AF94 File Offset: 0x00179194
	public List<RingArea> GetValidAreas()
	{
		return this.ValidAreas;
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x0017AF9C File Offset: 0x0017919C
	public void AddValidArea(int startCellIndex, int endCellIndex)
	{
		this.ValidAreas.Add(new RingArea(startCellIndex, endCellIndex, this.ArrowDirection));
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x0017AFB6 File Offset: 0x001791B6
	public void ClearValidAreas()
	{
		this.ValidAreas.Clear();
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x0017AFC3 File Offset: 0x001791C3
	public Dictionary<int, ContinuousRingArea> GetQteAreas()
	{
		return this.QteAreas;
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x0017AFCC File Offset: 0x001791CC
	[NullableContext(2)]
	public ContinuousRingArea GetQteArea(int continuousIndex)
	{
		ContinuousRingArea result;
		if (!this.QteAreas.TryGetValue(continuousIndex, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x0017AFEC File Offset: 0x001791EC
	public void AddQteArea(int continuousIndex, int startCellIndex, int endCellIndex)
	{
		this.QteAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x0017B008 File Offset: 0x00179208
	public void RemoveQteArea(int continuousIndex)
	{
		this.QteAreas.Remove(continuousIndex);
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x0017B017 File Offset: 0x00179217
	public Dictionary<int, ContinuousRingArea> GetPerfectAreas()
	{
		return this.PerfectAreas;
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x0017B020 File Offset: 0x00179220
	[NullableContext(2)]
	public ContinuousRingArea GetPerfectArea(int continuousIndex)
	{
		ContinuousRingArea result;
		if (!this.PerfectAreas.TryGetValue(continuousIndex, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x0017B040 File Offset: 0x00179240
	public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
	{
		this.PerfectAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x0017B05C File Offset: 0x0017925C
	public void RemovePerfectArea(int continuousIndex)
	{
		this.PerfectAreas.Remove(continuousIndex);
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x0017B06C File Offset: 0x0017926C
	[return: Nullable(2)]
	public ContinuousRingArea CheckInArea(Dictionary<int, ContinuousRingArea> areas, int currentArrowStayCellIndex)
	{
		foreach (KeyValuePair<int, ContinuousRingArea> keyValuePair in areas)
		{
			ContinuousRingArea value = keyValuePair.Value;
			int startCellIndex = value.StartCellIndex;
			int endCellIndex = value.EndCellIndex;
			if (endCellIndex >= startCellIndex)
			{
				if (currentArrowStayCellIndex >= startCellIndex && currentArrowStayCellIndex <= endCellIndex)
				{
					return value;
				}
			}
			else
			{
				bool flag = currentArrowStayCellIndex >= startCellIndex && currentArrowStayCellIndex <= 36;
				bool flag2 = currentArrowStayCellIndex >= 1 && currentArrowStayCellIndex <= endCellIndex;
				if (flag || flag2)
				{
					return value;
				}
			}
		}
		return null;
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x0017B114 File Offset: 0x00179314
	public void EnterNextValidArea()
	{
		int count = this.ValidAreas.Count;
		if (count == 0)
		{
			return;
		}
		EArrowDirection arrowDirection = this.ArrowDirection;
		if (arrowDirection != EArrowDirection.Clockwise)
		{
			if (arrowDirection == EArrowDirection.Anticlockwise)
			{
				this.CurrentArrowStayRelativeValidAreaIndex--;
			}
		}
		else
		{
			this.CurrentArrowStayRelativeValidAreaIndex++;
		}
		if (this.CurrentArrowStayRelativeValidAreaIndex >= count)
		{
			this.CurrentArrowStayRelativeValidAreaIndex = 0;
		}
		else if (this.CurrentArrowStayRelativeValidAreaIndex < 0)
		{
			this.CurrentArrowStayRelativeValidAreaIndex = count - 1;
		}
		EventSystem.Instance.Emit<int>(EEventName.OnArtemisQteAreaChange, this.CurrentArrowStayRelativeValidAreaIndex);
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x0017B19C File Offset: 0x0017939C
	public void OnArrowDirectionReverse()
	{
		EArrowDirection arrowDirection = this.ArrowDirection;
		if (arrowDirection != EArrowDirection.Clockwise)
		{
			if (arrowDirection == EArrowDirection.Anticlockwise)
			{
				this.ArrowDirection = EArrowDirection.Clockwise;
			}
		}
		else
		{
			this.ArrowDirection = EArrowDirection.Anticlockwise;
		}
		foreach (RingArea ringArea in this.ValidAreas)
		{
			ringArea.OnArrowDirectionReverse();
		}
		foreach (KeyValuePair<int, ContinuousRingArea> keyValuePair in this.QteAreas)
		{
			keyValuePair.Value.OnArrowDirectionReverse();
		}
	}

	// Token: 0x04003532 RID: 13618
	public int CurrentArrowStayRelativeValidAreaIndex = -1;

	// Token: 0x04003533 RID: 13619
	public int CurrentArrowStayCellIndex;

	// Token: 0x04003534 RID: 13620
	public EArrowDirection ArrowDirection;

	// Token: 0x04003535 RID: 13621
	public readonly List<RingArea> ValidAreas = new List<RingArea>();

	// Token: 0x04003536 RID: 13622
	private readonly Dictionary<int, ContinuousRingArea> QteAreas = new Dictionary<int, ContinuousRingArea>();

	// Token: 0x04003537 RID: 13623
	private readonly Dictionary<int, ContinuousRingArea> PerfectAreas = new Dictionary<int, ContinuousRingArea>();

	// Token: 0x04003538 RID: 13624
	public bool IsWholeRing = true;
}
