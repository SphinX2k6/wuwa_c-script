using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBB RID: 3515
	public class IPasserbyNpcRideLiftLeaveOnArrivalMove : IPasserbyNpcLiftMoveBase
	{
		// Token: 0x06004FDD RID: 20445 RVA: 0x000C698A File Offset: 0x000C4B8A
		public static IPasserbyNpcRideLiftLeaveOnArrivalMove Create(IPasserbyNpcRideLiftLeaveOnArrivalMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRideLiftLeaveOnArrivalMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x000C69A9 File Offset: 0x000C4BA9
		public override EPasserbyNpcLiftMoveType Type
		{
			get
			{
				return (EPasserbyNpcLiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x000C69B6 File Offset: 0x000C4BB6
		public virtual int LiftEntityId
		{
			get
			{
				return this.Instance.LiftEntityId;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x000C69C3 File Offset: 0x000C4BC3
		public virtual IPasserbyNpcLiftStopExitTiming ExitTiming
		{
			get
			{
				if (this._ExitTimingInited)
				{
					return this._ExitTimingCache;
				}
				this._ExitTimingInited = true;
				this._ExitTimingCache = IPasserbyNpcLiftStopExitTiming.Create(this.Instance.ExitTiming);
				return this._ExitTimingCache;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x000C69F8 File Offset: 0x000C4BF8
		public virtual List<IPasserbyNpcFloorSpline> FloorSplines
		{
			get
			{
				if (this._FloorSplinesInited)
				{
					return this._FloorSplinesCache;
				}
				this._FloorSplinesInited = true;
				int floorSplinesLength = this.Instance.FloorSplinesLength;
				this._FloorSplinesCache = new List<IPasserbyNpcFloorSpline>(floorSplinesLength);
				for (int i = 0; i < floorSplinesLength; i++)
				{
					this._FloorSplinesCache.Add(IPasserbyNpcFloorSpline.Create(this.Instance.FloorSplines(i)));
				}
				return this._FloorSplinesCache;
			}
		}

		// Token: 0x04002D82 RID: 11650
		private IPasserbyNpcRideLiftLeaveOnArrivalMove Instance;

		// Token: 0x04002D83 RID: 11651
		[Nullable(2)]
		private IPasserbyNpcLiftStopExitTiming _ExitTimingCache;

		// Token: 0x04002D84 RID: 11652
		private bool _ExitTimingInited;

		// Token: 0x04002D85 RID: 11653
		private List<IPasserbyNpcFloorSpline> _FloorSplinesCache;

		// Token: 0x04002D86 RID: 11654
		private bool _FloorSplinesInited;
	}
}
