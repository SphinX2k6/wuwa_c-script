using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE4 RID: 11492
	public class IAlertValueSpeedChangeType
	{
		// Token: 0x0600FBBB RID: 64443 RVA: 0x0024716A File Offset: 0x0024536A
		public static IAlertValueSpeedChangeType Create(IAlertValueSpeedChangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertValueSpeedChangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x0600FBBC RID: 64444 RVA: 0x00247189 File Offset: 0x00245389
		public virtual EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008982 RID: 35202
		private IAlertValueSpeedChangeType Instance;
	}
}
