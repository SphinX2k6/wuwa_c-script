using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273B RID: 10043
	public class IOpenTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x0600DFD6 RID: 57302 RVA: 0x002126DF File Offset: 0x002108DF
		[NullableContext(1)]
		public static IOpenTraceSpline Create(IOpenTraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenTraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x0600DFD7 RID: 57303 RVA: 0x002126FE File Offset: 0x002108FE
		public override ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x0021270B File Offset: 0x0021090B
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x0600DFD9 RID: 57305 RVA: 0x00212718 File Offset: 0x00210918
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04007C35 RID: 31797
		private IOpenTraceSpline Instance;
	}
}
