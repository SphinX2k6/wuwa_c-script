using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC2 RID: 11202
	public class ICloseSplineMove : ISplineMoveConfig
	{
		// Token: 0x0600F6F2 RID: 63218 RVA: 0x0023F6FA File Offset: 0x0023D8FA
		public static ICloseSplineMove Create(ICloseSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x0600F6F3 RID: 63219 RVA: 0x0023F719 File Offset: 0x0023D919
		public override ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x0600F6F4 RID: 63220 RVA: 0x0023F726 File Offset: 0x0023D926
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadICloseSplineMove_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x0600F6F5 RID: 63221 RVA: 0x0023F755 File Offset: 0x0023D955
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04008738 RID: 34616
		private ICloseSplineMove Instance;

		// Token: 0x04008739 RID: 34617
		private ITargetEntityType _TargetCache;

		// Token: 0x0400873A RID: 34618
		private bool _TargetInited;
	}
}
