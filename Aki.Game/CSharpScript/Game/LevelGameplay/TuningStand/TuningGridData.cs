using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069C5 RID: 27077
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningGridData
	{
		// Token: 0x17009868 RID: 39016
		// (get) Token: 0x060435EE RID: 275950 RVA: 0x01076354 File Offset: 0x01074554
		// (set) Token: 0x060435ED RID: 275949 RVA: 0x0107631F File Offset: 0x0107451F
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

		// Token: 0x060435EF RID: 275951 RVA: 0x0107635C File Offset: 0x0107455C
		public ITuningStateData GetCurGridState()
		{
			if (!this.IsStatic)
			{
				return this.DynamicState;
			}
			return this.StaticState;
		}

		// Token: 0x060435F0 RID: 275952 RVA: 0x01076373 File Offset: 0x01074573
		public double GetCenterDistance()
		{
			return (double)(Math.Abs(this.GridLoc[0] - (int)Math.Floor(2.5)) + Math.Abs(this.GridLoc[1] - (int)Math.Floor(3.5)));
		}

		// Token: 0x04023253 RID: 143955
		private int IndexInner;

		// Token: 0x04023254 RID: 143956
		public bool IsStatic = true;

		// Token: 0x04023255 RID: 143957
		public int[] GridLoc = new int[]
		{
			-1,
			-1
		};

		// Token: 0x04023256 RID: 143958
		public ETuningStandGridType GridType;

		// Token: 0x04023257 RID: 143959
		public EGridMainType GridMainType;

		// Token: 0x04023258 RID: 143960
		public int GridValue;

		// Token: 0x04023259 RID: 143961
		public ITuningStateData StaticState = new TuningStateData
		{
			State = EGridBelongType.Empty
		};

		// Token: 0x0402325A RID: 143962
		public ITuningStateData DynamicState = new TuningStateData
		{
			State = EGridBelongType.Empty
		};
	}
}
