using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F9 RID: 10745
	public class ICustomAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x0600ED2B RID: 60715 RVA: 0x0022985B File Offset: 0x00227A5B
		[NullableContext(1)]
		public static ICustomAlertValueChangeSpeed Create(ICustomAlertValueChangeSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x0600ED2C RID: 60716 RVA: 0x0022987A File Offset: 0x00227A7A
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x0600ED2D RID: 60717 RVA: 0x00229887 File Offset: 0x00227A87
		public virtual float CustomValue
		{
			get
			{
				return this.Instance.CustomValue;
			}
		}

		// Token: 0x04008293 RID: 33427
		private ICustomAlertValueChangeSpeed Instance;
	}
}
