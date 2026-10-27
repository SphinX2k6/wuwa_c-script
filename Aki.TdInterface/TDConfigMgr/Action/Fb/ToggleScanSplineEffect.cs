using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273A RID: 10042
	public class ToggleScanSplineEffect : ActionParams
	{
		// Token: 0x0600DFD3 RID: 57299 RVA: 0x002126AB File Offset: 0x002108AB
		[NullableContext(1)]
		public static ToggleScanSplineEffect Create(IToggleScanSplineEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x002126CA File Offset: 0x002108CA
		public virtual ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x04007C34 RID: 31796
		private IToggleScanSplineEffect Instance;
	}
}
