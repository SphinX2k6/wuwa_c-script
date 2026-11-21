using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BDC RID: 11228
	public class IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600F75C RID: 63324 RVA: 0x00240143 File Offset: 0x0023E343
		public static IModifyActorMaterialParamBySplineProgressConfig Create(IModifyActorMaterialParamBySplineProgressConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x0600F75D RID: 63325 RVA: 0x00240162 File Offset: 0x0023E362
		public virtual EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x0600F75E RID: 63326 RVA: 0x0024016F File Offset: 0x0023E36F
		public virtual IModifyActorMaterialParamBySplineProgressTarget MoveTarget
		{
			get
			{
				if (this._MoveTargetInited)
				{
					return this._MoveTargetCache;
				}
				this._MoveTargetInited = true;
				this._MoveTargetCache = ActionReadHelper.ReadIModifyActorMaterialParamBySplineProgressConfig_MoveTarget(this.Instance);
				return this._MoveTargetCache;
			}
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x0600F75F RID: 63327 RVA: 0x0024019E File Offset: 0x0023E39E
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04008772 RID: 34674
		private IModifyActorMaterialParamBySplineProgressConfig Instance;

		// Token: 0x04008773 RID: 34675
		private IModifyActorMaterialParamBySplineProgressTarget _MoveTargetCache;

		// Token: 0x04008774 RID: 34676
		private bool _MoveTargetInited;
	}
}
