using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2E RID: 11310
	public class IDisableCameraOperation : ICameraOperationType
	{
		// Token: 0x0600F8E2 RID: 63714 RVA: 0x00242C1A File Offset: 0x00240E1A
		public static IDisableCameraOperation Create(IDisableCameraOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x0600F8E3 RID: 63715 RVA: 0x00242C39 File Offset: 0x00240E39
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008818 RID: 34840
		private IDisableCameraOperation Instance;
	}
}
