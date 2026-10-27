using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002901 RID: 10497
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyActorMaterialParamBySplineProgressEnterSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600E913 RID: 59667 RVA: 0x00222F01 File Offset: 0x00221101
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

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x0600E914 RID: 59668 RVA: 0x00222F20 File Offset: 0x00221120
		public override EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x0600E915 RID: 59669 RVA: 0x00222F2D File Offset: 0x0022112D
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x00222F3C File Offset: 0x0022113C
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

		// Token: 0x040080AB RID: 32939
		private IModifyActorMaterialParamBySplineProgressEnterSpline Instance;

		// Token: 0x040080AC RID: 32940
		private List<IActorRefWithMaterialParam> _ActorRefsCache;

		// Token: 0x040080AD RID: 32941
		private bool _ActorRefsInited;
	}
}
