using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4D RID: 28493
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedRingInfo
	{
		// Token: 0x06045508 RID: 283912 RVA: 0x0112619C File Offset: 0x0112439C
		public BigStuffedRingInfo(int RingId, EArrowDirection ArrowDirection)
		{
			this.RingId = RingId;
			this.ArrowDirection = ArrowDirection;
		}

		// Token: 0x06045509 RID: 283913 RVA: 0x011261E9 File Offset: 0x011243E9
		public void Clear()
		{
			this.ValidAreas.Clear();
			this.GoodAreas.Clear();
			this.PerfectAreas.Clear();
			this.BonusAreas.Clear();
		}

		// Token: 0x0604550A RID: 283914 RVA: 0x01126217 File Offset: 0x01124417
		public List<Area> GetValidAreas()
		{
			return this.ValidAreas;
		}

		// Token: 0x0604550B RID: 283915 RVA: 0x0112621F File Offset: 0x0112441F
		public void AddValidArea(int startCellIndex, int endCellIndex)
		{
			this.ValidAreas.Add(new Area(startCellIndex, endCellIndex, this.ArrowDirection));
		}

		// Token: 0x0604550C RID: 283916 RVA: 0x01126239 File Offset: 0x01124439
		public void ClearValidAreas()
		{
			this.ValidAreas.Clear();
		}

		// Token: 0x0604550D RID: 283917 RVA: 0x01126246 File Offset: 0x01124446
		public Dictionary<int, ContinuousArea> GetGoodAreas()
		{
			return this.GoodAreas;
		}

		// Token: 0x0604550E RID: 283918 RVA: 0x01126250 File Offset: 0x01124450
		[NullableContext(2)]
		public ContinuousArea GetGoodArea(int continuousIndex)
		{
			ContinuousArea result;
			if (this.GoodAreas.TryGetValue(continuousIndex, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0604550F RID: 283919 RVA: 0x01126270 File Offset: 0x01124470
		public void AddGoodArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.GoodAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x06045510 RID: 283920 RVA: 0x0112628C File Offset: 0x0112448C
		public void RemoveGoodArea(int continuousIndex)
		{
			this.GoodAreas.Remove(continuousIndex);
		}

		// Token: 0x06045511 RID: 283921 RVA: 0x0112629B File Offset: 0x0112449B
		public Dictionary<int, ContinuousArea> GetPerfectAreas()
		{
			return this.PerfectAreas;
		}

		// Token: 0x06045512 RID: 283922 RVA: 0x011262A3 File Offset: 0x011244A3
		public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.PerfectAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x06045513 RID: 283923 RVA: 0x011262BF File Offset: 0x011244BF
		public void RemovePerfectArea(int continuousIndex)
		{
			this.PerfectAreas.Remove(continuousIndex);
		}

		// Token: 0x06045514 RID: 283924 RVA: 0x011262CE File Offset: 0x011244CE
		public Dictionary<int, ContinuousArea> GetBonusAreas()
		{
			return this.BonusAreas;
		}

		// Token: 0x06045515 RID: 283925 RVA: 0x011262D6 File Offset: 0x011244D6
		public void AddBonusArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.BonusAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x06045516 RID: 283926 RVA: 0x011262F4 File Offset: 0x011244F4
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
			foreach (Area area in this.ValidAreas)
			{
				area.OnArrowDirectionReverse();
			}
			foreach (KeyValuePair<int, ContinuousArea> keyValuePair in this.GoodAreas)
			{
				keyValuePair.Value.OnArrowDirectionReverse();
			}
			foreach (KeyValuePair<int, ContinuousArea> keyValuePair2 in this.PerfectAreas)
			{
				keyValuePair2.Value.OnArrowDirectionReverse();
			}
			foreach (KeyValuePair<int, ContinuousArea> keyValuePair3 in this.BonusAreas)
			{
				keyValuePair3.Value.OnArrowDirectionReverse();
			}
		}

		// Token: 0x04024266 RID: 148070
		public readonly int RingId;

		// Token: 0x04024267 RID: 148071
		public EArrowDirection ArrowDirection;

		// Token: 0x04024268 RID: 148072
		public readonly List<Area> ValidAreas = new List<Area>();

		// Token: 0x04024269 RID: 148073
		private readonly Dictionary<int, ContinuousArea> GoodAreas = new Dictionary<int, ContinuousArea>();

		// Token: 0x0402426A RID: 148074
		private readonly Dictionary<int, ContinuousArea> PerfectAreas = new Dictionary<int, ContinuousArea>();

		// Token: 0x0402426B RID: 148075
		private readonly Dictionary<int, ContinuousArea> BonusAreas = new Dictionary<int, ContinuousArea>();
	}
}
