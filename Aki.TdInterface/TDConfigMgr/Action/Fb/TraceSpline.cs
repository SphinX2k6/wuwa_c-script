using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273D RID: 10045
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceSpline : ActionParams
	{
		// Token: 0x0600DFDF RID: 57311 RVA: 0x0021276E File Offset: 0x0021096E
		public static TraceSpline Create(ITraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x0021278D File Offset: 0x0021098D
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x0600DFE1 RID: 57313 RVA: 0x0021279A File Offset: 0x0021099A
		public virtual int Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x002127A7 File Offset: 0x002109A7
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04007C37 RID: 31799
		private ITraceSpline Instance;
	}
}
