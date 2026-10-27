using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F7 RID: 10743
	public class IAlertValueSpeedChangeType
	{
		// Token: 0x0600ED24 RID: 60708 RVA: 0x002297E6 File Offset: 0x002279E6
		[NullableContext(1)]
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

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x0600ED25 RID: 60709 RVA: 0x00229805 File Offset: 0x00227A05
		public virtual EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008291 RID: 33425
		private IAlertValueSpeedChangeType Instance;
	}
}
