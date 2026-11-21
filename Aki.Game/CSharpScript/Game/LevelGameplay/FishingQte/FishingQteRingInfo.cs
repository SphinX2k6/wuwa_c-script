using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB1 RID: 24497
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingInfo
	{
		// Token: 0x17006F3A RID: 28474
		// (get) Token: 0x0603ADBA RID: 241082 RVA: 0x010A1FE7 File Offset: 0x010A01E7
		// (set) Token: 0x0603ADBB RID: 241083 RVA: 0x010A1FEF File Offset: 0x010A01EF
		public EArrowDirection ArrowDirection { get; set; }

		// Token: 0x0603ADBC RID: 241084 RVA: 0x010A1FF8 File Offset: 0x010A01F8
		public FishingQteRingInfo(EArrowDirection arrowDirection)
		{
			this.ArrowDirection = arrowDirection;
		}

		// Token: 0x0603ADBD RID: 241085 RVA: 0x010A2036 File Offset: 0x010A0236
		public void Clear()
		{
			this.ValidAreas.Clear();
			this.QteAreas.Clear();
		}

		// Token: 0x0603ADBE RID: 241086 RVA: 0x010A204E File Offset: 0x010A024E
		public List<RingArea> GetValidAreas()
		{
			return this.ValidAreas;
		}

		// Token: 0x0603ADBF RID: 241087 RVA: 0x010A2056 File Offset: 0x010A0256
		public void AddValidArea(int startCellIndex, int endCellIndex)
		{
			this.ValidAreas.Add(new RingArea(startCellIndex, endCellIndex, this.ArrowDirection));
		}

		// Token: 0x0603ADC0 RID: 241088 RVA: 0x010A2070 File Offset: 0x010A0270
		public void ClearValidAreas()
		{
			this.ValidAreas.Clear();
		}

		// Token: 0x0603ADC1 RID: 241089 RVA: 0x010A207D File Offset: 0x010A027D
		public Dictionary<int, ContinuousRingArea> GetQteAreas()
		{
			return this.QteAreas;
		}

		// Token: 0x0603ADC2 RID: 241090 RVA: 0x010A2088 File Offset: 0x010A0288
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

		// Token: 0x0603ADC3 RID: 241091 RVA: 0x010A20A8 File Offset: 0x010A02A8
		public void AddQteArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.QteAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x0603ADC4 RID: 241092 RVA: 0x010A20C4 File Offset: 0x010A02C4
		public void RemoveQteArea(int continuousIndex)
		{
			this.QteAreas.Remove(continuousIndex);
		}

		// Token: 0x0603ADC5 RID: 241093 RVA: 0x010A20D3 File Offset: 0x010A02D3
		public Dictionary<int, ContinuousRingArea> GetPerfectAreas()
		{
			return this.PerfectAreas;
		}

		// Token: 0x0603ADC6 RID: 241094 RVA: 0x010A20DC File Offset: 0x010A02DC
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

		// Token: 0x0603ADC7 RID: 241095 RVA: 0x010A20FC File Offset: 0x010A02FC
		public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.PerfectAreas[continuousIndex] = new ContinuousRingArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x0603ADC8 RID: 241096 RVA: 0x010A2118 File Offset: 0x010A0318
		public void RemovePerfectArea(int continuousIndex)
		{
			this.PerfectAreas.Remove(continuousIndex);
		}

		// Token: 0x0603ADC9 RID: 241097 RVA: 0x010A2128 File Offset: 0x010A0328
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

		// Token: 0x0603ADCA RID: 241098 RVA: 0x010A21D0 File Offset: 0x010A03D0
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

		// Token: 0x0603ADCB RID: 241099 RVA: 0x010A2258 File Offset: 0x010A0458
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

		// Token: 0x0401EF11 RID: 126737
		public int CurrentArrowStayRelativeValidAreaIndex = -1;

		// Token: 0x0401EF12 RID: 126738
		public int CurrentArrowStayCellIndex;

		// Token: 0x0401EF14 RID: 126740
		public List<RingArea> ValidAreas = new List<RingArea>();

		// Token: 0x0401EF15 RID: 126741
		private Dictionary<int, ContinuousRingArea> QteAreas = new Dictionary<int, ContinuousRingArea>();

		// Token: 0x0401EF16 RID: 126742
		private Dictionary<int, ContinuousRingArea> PerfectAreas = new Dictionary<int, ContinuousRingArea>();

		// Token: 0x0401EF17 RID: 126743
		public bool IsWholeRing = true;
	}
}
