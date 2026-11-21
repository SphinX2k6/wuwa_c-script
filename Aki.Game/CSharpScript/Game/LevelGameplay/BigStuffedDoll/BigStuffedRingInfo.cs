using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CE RID: 24782
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedRingInfo
	{
		// Token: 0x0603B6B6 RID: 243382 RVA: 0x010D0148 File Offset: 0x010CE348
		public BigStuffedRingInfo(int RingId, EArrowDirection ArrowDirection)
		{
			this.RingId = RingId;
			this.ArrowDirection = ArrowDirection;
		}

		// Token: 0x0603B6B7 RID: 243383 RVA: 0x010D0195 File Offset: 0x010CE395
		public void Clear()
		{
			this.ValidAreas.Clear();
			this.GoodAreas.Clear();
			this.PerfectAreas.Clear();
			this.BonusAreas.Clear();
		}

		// Token: 0x0603B6B8 RID: 243384 RVA: 0x010D01C3 File Offset: 0x010CE3C3
		public List<Area> GetValidAreas()
		{
			return this.ValidAreas;
		}

		// Token: 0x0603B6B9 RID: 243385 RVA: 0x010D01CB File Offset: 0x010CE3CB
		public void AddValidArea(int startCellIndex, int endCellIndex)
		{
			this.ValidAreas.Add(new Area(startCellIndex, endCellIndex, this.ArrowDirection));
		}

		// Token: 0x0603B6BA RID: 243386 RVA: 0x010D01E5 File Offset: 0x010CE3E5
		public void ClearValidAreas()
		{
			this.ValidAreas.Clear();
		}

		// Token: 0x0603B6BB RID: 243387 RVA: 0x010D01F2 File Offset: 0x010CE3F2
		public Dictionary<int, ContinuousArea> GetGoodAreas()
		{
			return this.GoodAreas;
		}

		// Token: 0x0603B6BC RID: 243388 RVA: 0x010D01FC File Offset: 0x010CE3FC
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

		// Token: 0x0603B6BD RID: 243389 RVA: 0x010D021C File Offset: 0x010CE41C
		public void AddGoodArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.GoodAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x0603B6BE RID: 243390 RVA: 0x010D0238 File Offset: 0x010CE438
		public void RemoveGoodArea(int continuousIndex)
		{
			this.GoodAreas.Remove(continuousIndex);
		}

		// Token: 0x0603B6BF RID: 243391 RVA: 0x010D0247 File Offset: 0x010CE447
		public Dictionary<int, ContinuousArea> GetPerfectAreas()
		{
			return this.PerfectAreas;
		}

		// Token: 0x0603B6C0 RID: 243392 RVA: 0x010D024F File Offset: 0x010CE44F
		public void AddPerfectArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.PerfectAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x0603B6C1 RID: 243393 RVA: 0x010D026B File Offset: 0x010CE46B
		public void RemovePerfectArea(int continuousIndex)
		{
			this.PerfectAreas.Remove(continuousIndex);
		}

		// Token: 0x0603B6C2 RID: 243394 RVA: 0x010D027A File Offset: 0x010CE47A
		public Dictionary<int, ContinuousArea> GetBonusAreas()
		{
			return this.BonusAreas;
		}

		// Token: 0x0603B6C3 RID: 243395 RVA: 0x010D0282 File Offset: 0x010CE482
		public void AddBonusArea(int continuousIndex, int startCellIndex, int endCellIndex)
		{
			this.BonusAreas[continuousIndex] = new ContinuousArea(continuousIndex, startCellIndex, endCellIndex, this.ArrowDirection);
		}

		// Token: 0x0603B6C4 RID: 243396 RVA: 0x010D02A0 File Offset: 0x010CE4A0
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

		// Token: 0x0401F51B RID: 128283
		public readonly int RingId;

		// Token: 0x0401F51C RID: 128284
		public EArrowDirection ArrowDirection;

		// Token: 0x0401F51D RID: 128285
		public readonly List<Area> ValidAreas = new List<Area>();

		// Token: 0x0401F51E RID: 128286
		private readonly Dictionary<int, ContinuousArea> GoodAreas = new Dictionary<int, ContinuousArea>();

		// Token: 0x0401F51F RID: 128287
		private readonly Dictionary<int, ContinuousArea> PerfectAreas = new Dictionary<int, ContinuousArea>();

		// Token: 0x0401F520 RID: 128288
		private readonly Dictionary<int, ContinuousArea> BonusAreas = new Dictionary<int, ContinuousArea>();
	}
}
