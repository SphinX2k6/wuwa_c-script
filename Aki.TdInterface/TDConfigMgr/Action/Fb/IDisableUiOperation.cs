using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C34 RID: 11316
	public class IDisableUiOperation : IUiOperationType
	{
		// Token: 0x0600F8F4 RID: 63732 RVA: 0x00242D52 File Offset: 0x00240F52
		public static IDisableUiOperation Create(IDisableUiOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x0600F8F5 RID: 63733 RVA: 0x00242D71 File Offset: 0x00240F71
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400881E RID: 34846
		private IDisableUiOperation Instance;
	}
}
