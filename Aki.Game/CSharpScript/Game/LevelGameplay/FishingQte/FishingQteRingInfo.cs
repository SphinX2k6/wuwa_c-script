using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E30 RID: 28208
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingInfo
	{
		// Token: 0x17009A25 RID: 39461
		// (get) Token: 0x06044C2C RID: 281644 RVA: 0x010F7916 File Offset: 0x010F5B16
		// (set) Token: 0x06044C2D RID: 281645 RVA: 0x010F791E File Offset: 0x010F5B1E
		public EArrowDirection ArrowDirection { get; set; }

		// Token: 0x06044C2E RID: 281646 RVA: 0x010F7927 File Offset: 0x010F5B27
		public FishingQteRingInfo(EArrowDirection arrowDirection)
		{
			this.ArrowDirection = arrowDirection;
		}

		// Token: 0x06044C2F RID: 281647 RVA: 0x010F7965 File Offset: 0x010F5B65
		public void Clear()
		{
			this.ValidAreas.Clear();
			this.QteAreas.Clear();
		}

		// Token: 0x06044C30 RID: 281648 RVA: 0x010F797D File Offset: 0x010F5B7D
		public List<RingArea> GetValidAreas()
		{
			return this.ValidAreas;
		}

		// Token: 0x06044C31 RID: 281649 RVA: 0x010F7985 File Offset: 0x010F5B85
		public void AddValidArea(int startCellIndex, int endCellIndex)
		{
			this.ValidAreas.Add(new RingArea(startCellIndex, endCellIndex, this.ArrowDirection));
		}

		// Token: 0x06044C32 RID: 281650 RVA: 0x010F799F File Offset: 0x010F5B9F
		public void ClearValidAreas()
		{
			this.ValidAreas.Clear();
		}

		// Token: 0x06044C33 RID: 281651 RVA: 0x010F79AC File Offset: 0x010F5BAC
		public Dictionary<int, ContinuousRingArea> GetQteAreas()
		{
			return this.QteAreas;
		}

		// Token: 0x06044C34 RID: 281652 RVA: 0x010F79B4 File Offset: 0x010F5BB4
		[NullableContext(2)]
		public ContinuousRingArea GetQteArea(int continuousIndex)
		{
			ContinuousRingArea result;
			if (this.QteAreas.TryGetValue(continuousIndex, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06044C35 RID: 281653 RVA: 0x010F79D4 File Offset: 0x010F5BD4
		public void AddQteArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.QteAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x06044C36 RID: 281654 RVA: 0x010F79F0 File Offset: 0x010F5BF0
		public void RemoveQteArea(int continuousIndex)
		{
			this.QteAreas.Remove(continuousIndex);
		}

		// Token: 0x06044C37 RID: 281655 RVA: 0x010F79FF File Offset: 0x010F5BFF
		public Dictionary<int, ContinuousRingArea> GetPerfectAreas()
		{
			return this.PerfectAreas;
		}

		// Token: 0x06044C38 RID: 281656 RVA: 0x010F7A08 File Offset: 0x010F5C08
		[NullableContext(2)]
		public ContinuousRingArea GetPerfectArea(int continuousIndex)
		{
			ContinuousRingArea result;
			if (this.PerfectAreas.TryGetValue(continuousIndex, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06044C39 RID: 281657 RVA: 0x010F7A28 File Offset: 0x010F5C28
		public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.PerfectAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x06044C3A RID: 281658 RVA: 0x010F7A44 File Offset: 0x010F5C44
		public void RemovePerfectArea(int continuousIndex)
		{
			this.PerfectAreas.Remove(continuousIndex);
		}

		// Token: 0x06044C3B RID: 281659 RVA: 0x010F7A54 File Offset: 0x010F5C54
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

		// Token: 0x06044C3C RID: 281660 RVA: 0x010F7AFC File Offset: 0x010F5CFC
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
			EventSystem.Instance.Emit<int>(EEventName.OnFishingQteAreaChange, this.CurrentArrowStayRelativeValidAreaIndex);
		}

		// Token: 0x06044C3D RID: 281661 RVA: 0x010F7B84 File Offset: 0x010F5D84
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

		// Token: 0x04023C5C RID: 146524
		public int CurrentArrowStayRelativeValidAreaIndex = -1;

		// Token: 0x04023C5D RID: 146525
		public int CurrentArrowStayCellIndex;

		// Token: 0x04023C5F RID: 146527
		public List<RingArea> ValidAreas = new List<RingArea>();

		// Token: 0x04023C60 RID: 146528
		private Dictionary<int, ContinuousRingArea> QteAreas = new Dictionary<int, ContinuousRingArea>();

		// Token: 0x04023C61 RID: 146529
		private Dictionary<int, ContinuousRingArea> PerfectAreas = new Dictionary<int, ContinuousRingArea>();

		// Token: 0x04023C62 RID: 146530
		public bool IsWholeRing = true;
	}
}
