using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BDF RID: 11231
	public class IModifyActorMaterialParamBySplineProgressExitSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600F76B RID: 63339 RVA: 0x002402F5 File Offset: 0x0023E4F5
		public static IModifyActorMaterialParamBySplineProgressExitSpline Create(IModifyActorMaterialParamBySplineProgressExitSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressExitSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x0600F76C RID: 63340 RVA: 0x00240314 File Offset: 0x0023E514
		public override EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x0600F76D RID: 63341 RVA: 0x00240321 File Offset: 0x0023E521
		public override IModifyActorMaterialParamBySplineProgressTarget MoveTarget
		{
			get
			{
				if (this._MoveTargetInited)
				{
					return this._MoveTargetCache;
				}
				this._MoveTargetInited = true;
				this._MoveTargetCache = ActionReadHelper.ReadIModifyActorMaterialParamBySplineProgressExitSpline_MoveTarget(this.Instance);
				return this._MoveTargetCache;
			}
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x0600F76E RID: 63342 RVA: 0x00240350 File Offset: 0x0023E550
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x0400877D RID: 34685
		private IModifyActorMaterialParamBySplineProgressExitSpline Instance;

		// Token: 0x0400877E RID: 34686
		private IModifyActorMaterialParamBySplineProgressTarget _MoveTargetCache;

		// Token: 0x0400877F RID: 34687
		private bool _MoveTargetInited;
	}
}
