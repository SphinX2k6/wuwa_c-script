using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3A RID: 10810
	public class ISpecificScanEffect
	{
		// Token: 0x0600EE13 RID: 60947 RVA: 0x0022AE21 File Offset: 0x00229021
		[NullableContext(1)]
		public static ISpecificScanEffect Create(ISpecificScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x0600EE14 RID: 60948 RVA: 0x0022AE40 File Offset: 0x00229040
		public virtual ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x04008306 RID: 33542
		private ISpecificScanEffect Instance;
	}
}
