using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BDE RID: 11230
	public class IModifyActorMaterialParamBySplineProgressEnterSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600F765 RID: 63333 RVA: 0x0024021B File Offset: 0x0023E41B
		public static IModifyActorMaterialParamBySplineProgressEnterSpline Create(IModifyActorMaterialParamBySplineProgressEnterSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressEnterSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x0600F766 RID: 63334 RVA: 0x0024023A File Offset: 0x0023E43A
		public override EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x0600F767 RID: 63335 RVA: 0x00240247 File Offset: 0x0023E447
		public override IModifyActorMaterialParamBySplineProgressTarget MoveTarget
		{
			get
			{
				if (this._MoveTargetInited)
				{
					return this._MoveTargetCache;
				}
				this._MoveTargetInited = true;
				this._MoveTargetCache = ActionReadHelper.ReadIModifyActorMaterialParamBySplineProgressEnterSpline_MoveTarget(this.Instance);
				return this._MoveTargetCache;
			}
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x0600F768 RID: 63336 RVA: 0x00240276 File Offset: 0x0023E476
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x0600F769 RID: 63337 RVA: 0x00240284 File Offset: 0x0023E484
		public virtual List<IActorRefWithMaterialParam> ActorRefs
		{
			get
			{
				if (this._ActorRefsInited)
				{
					return this._ActorRefsCache;
				}
				this._ActorRefsInited = true;
				int actorRefsLength = this.Instance.ActorRefsLength;
				this._ActorRefsCache = new List<IActorRefWithMaterialParam>(actorRefsLength);
				for (int i = 0; i < actorRefsLength; i++)
				{
					this._ActorRefsCache.Add(IActorRefWithMaterialParam.Create(this.Instance.ActorRefs(i)));
				}
				return this._ActorRefsCache;
			}
		}

		// Token: 0x04008778 RID: 34680
		private IModifyActorMaterialParamBySplineProgressEnterSpline Instance;

		// Token: 0x04008779 RID: 34681
		private IModifyActorMaterialParamBySplineProgressTarget _MoveTargetCache;

		// Token: 0x0400877A RID: 34682
		private bool _MoveTargetInited;

		// Token: 0x0400877B RID: 34683
		private List<IActorRefWithMaterialParam> _ActorRefsCache;

		// Token: 0x0400877C RID: 34684
		private bool _ActorRefsInited;
	}
}
