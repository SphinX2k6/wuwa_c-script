using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EDB RID: 3803
	public class ITimeScheduleFixedPositions : ITimeScheduleRefreshPosition
	{
		// Token: 0x060055A9 RID: 21929 RVA: 0x000D2611 File Offset: 0x000D0811
		public static ITimeScheduleFixedPositions Create(ITimeScheduleFixedPositions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleFixedPositions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x000D2630 File Offset: 0x000D0830
		public override ETimeScheduleRefreshPositionType Type
		{
			get
			{
				return (ETimeScheduleRefreshPositionType)this.Instance.Type;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x000D2640 File Offset: 0x000D0840
		public virtual List<PosA> Positions
		{
			get
			{
				if (this._PositionsInited)
				{
					return this._PositionsCache;
				}
				this._PositionsInited = true;
				int positionsLength = this.Instance.PositionsLength;
				this._PositionsCache = new List<PosA>(positionsLength);
				for (int i = 0; i < positionsLength; i++)
				{
					this._PositionsCache.Add(PosA.Create(this.Instance.Positions(i)));
				}
				return this._PositionsCache;
			}
		}

		// Token: 0x04003100 RID: 12544
		private ITimeScheduleFixedPositions Instance;

		// Token: 0x04003101 RID: 12545
		private List<PosA> _PositionsCache;

		// Token: 0x04003102 RID: 12546
		private bool _PositionsInited;
	}
}
