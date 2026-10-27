using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273C RID: 10044
	public class ICloseTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x0600DFDB RID: 57307 RVA: 0x0021272D File Offset: 0x0021092D
		[NullableContext(1)]
		public static ICloseTraceSpline Create(ICloseTraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseTraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x0021274C File Offset: 0x0021094C
		public override ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x0600DFDD RID: 57309 RVA: 0x00212759 File Offset: 0x00210959
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04007C36 RID: 31798
		private ICloseTraceSpline Instance;
	}
}
