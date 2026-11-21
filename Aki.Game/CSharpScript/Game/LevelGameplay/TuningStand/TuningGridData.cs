using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B21 RID: 23329
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningGridData
	{
		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x0603962A RID: 235050 RVA: 0x0101A7E8 File Offset: 0x010189E8
		// (set) Token: 0x06039629 RID: 235049 RVA: 0x0101A7B3 File Offset: 0x010189B3
		public int Index
		{
			get
			{
				return this.IndexInner;
			}
			set
			{
				this.IndexInner = value;
				this.GridLoc[0] = (int)Math.Floor((double)((float)this.Index / 7f));
				this.GridLoc[1] = this.Index % 7;
			}
		}

		// Token: 0x0603962B RID: 235051 RVA: 0x0101A7F0 File Offset: 0x010189F0
		public ITuningStateData GetCurGridState()
		{
			if (!this.IsStatic)
			{
				return this.DynamicState;
			}
			return this.StaticState;
		}

		// Token: 0x0603962C RID: 235052 RVA: 0x0101A807 File Offset: 0x01018A07
		public double GetCenterDistance()
		{
			return (double)(Math.Abs(this.GridLoc[0] - (int)Math.Floor(2.5)) + Math.Abs(this.GridLoc[1] - (int)Math.Floor(3.5)));
		}

		// Token: 0x0401E443 RID: 123971
		private int IndexInner;

		// Token: 0x0401E444 RID: 123972
		public bool IsStatic = true;

		// Token: 0x0401E445 RID: 123973
		public int[] GridLoc = new int[]
		{
			-1,
			-1
		};

		// Token: 0x0401E446 RID: 123974
		public ETuningStandGridType GridType;

		// Token: 0x0401E447 RID: 123975
		public EGridMainType GridMainType;

		// Token: 0x0401E448 RID: 123976
		public int GridValue;

		// Token: 0x0401E449 RID: 123977
		public ITuningStateData StaticState = new TuningStateData
		{
			State = EGridBelongType.Empty
		};

		// Token: 0x0401E44A RID: 123978
		public ITuningStateData DynamicState = new TuningStateData
		{
			State = EGridBelongType.Empty
		};
	}
}
