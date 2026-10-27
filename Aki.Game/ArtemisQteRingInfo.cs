using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020010FF RID: 4351
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteRingInfo
{
	// Token: 0x0600715B RID: 29019 RVA: 0x00172582 File Offset: 0x00170782
	public ArtemisQteRingInfo(EArrowDirection arrowDirection)
	{
		this.ArrowDirection = arrowDirection;
	}

	// Token: 0x0600715C RID: 29020 RVA: 0x001725C0 File Offset: 0x001707C0
	public void Clear()
	{
		this.ValidAreas.Clear();
		this.QteAreas.Clear();
	}

	// Token: 0x0600715D RID: 29021 RVA: 0x001725D8 File Offset: 0x001707D8
	public List<RingArea> GetValidAreas()
	{
		return this.ValidAreas;
	}

	// Token: 0x0600715E RID: 29022 RVA: 0x001725E0 File Offset: 0x001707E0
	public void AddValidArea(int startCellIndex, int endCellIndex)
	{
		this.ValidAreas.Add(new RingArea(startCellIndex, endCellIndex, this.ArrowDirection));
	}

	// Token: 0x0600715F RID: 29023 RVA: 0x001725FA File Offset: 0x001707FA
	public void ClearValidAreas()
	{
		this.ValidAreas.Clear();
	}

	// Token: 0x06007160 RID: 29024 RVA: 0x00172607 File Offset: 0x00170807
	public Dictionary<int, ContinuousRingArea> GetQteAreas()
	{
		return this.QteAreas;
	}

	// Token: 0x06007161 RID: 29025 RVA: 0x00172610 File Offset: 0x00170810
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

	// Token: 0x06007162 RID: 29026 RVA: 0x00172630 File Offset: 0x00170830
	public void AddQteArea(int continuousIndex, int startCellIndex, int endCellIndex)
	{
		this.QteAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
	}

	// Token: 0x06007163 RID: 29027 RVA: 0x0017264C File Offset: 0x0017084C
	public void RemoveQteArea(int continuousIndex)
	{
		this.QteAreas.Remove(continuousIndex);
	}

	// Token: 0x06007164 RID: 29028 RVA: 0x0017265B File Offset: 0x0017085B
	public Dictionary<int, ContinuousRingArea> GetPerfectAreas()
	{
		return this.PerfectAreas;
	}

	// Token: 0x06007165 RID: 29029 RVA: 0x00172664 File Offset: 0x00170864
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

	// Token: 0x06007166 RID: 29030 RVA: 0x00172684 File Offset: 0x00170884
	public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
	{
		this.PerfectAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
	}

	// Token: 0x06007167 RID: 29031 RVA: 0x001726A0 File Offset: 0x001708A0
	public void RemovePerfectArea(int continuousIndex)
	{
		this.PerfectAreas.Remove(continuousIndex);
	}

	// Token: 0x06007168 RID: 29032 RVA: 0x001726B0 File Offset: 0x001708B0
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

	// Token: 0x06007169 RID: 29033 RVA: 0x00172758 File Offset: 0x00170958
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

	// Token: 0x0600716A RID: 29034 RVA: 0x001727E0 File Offset: 0x001709E0
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

	// Token: 0x04003499 RID: 13465
	public int CurrentArrowStayRelativeValidAreaIndex = -1;

	// Token: 0x0400349A RID: 13466
	public int CurrentArrowStayCellIndex;

	// Token: 0x0400349B RID: 13467
	public EArrowDirection ArrowDirection;

	// Token: 0x0400349C RID: 13468
	public readonly List<RingArea> ValidAreas = new List<RingArea>();

	// Token: 0x0400349D RID: 13469
	private readonly Dictionary<int, ContinuousRingArea> QteAreas = new Dictionary<int, ContinuousRingArea>();

	// Token: 0x0400349E RID: 13470
	private readonly Dictionary<int, ContinuousRingArea> PerfectAreas = new Dictionary<int, ContinuousRingArea>();

	// Token: 0x0400349F RID: 13471
	public bool IsWholeRing = true;
}
