using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F8 RID: 10744
	public class IAddOrSubAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x0600ED27 RID: 60711 RVA: 0x0022981A File Offset: 0x00227A1A
		[NullableContext(1)]
		public static IAddOrSubAlertValueChangeSpeed Create(IAddOrSubAlertValueChangeSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x0600ED28 RID: 60712 RVA: 0x00229839 File Offset: 0x00227A39
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x0600ED29 RID: 60713 RVA: 0x00229846 File Offset: 0x00227A46
		public virtual float DeltaValue
		{
			get
			{
				return this.Instance.DeltaValue;
			}
		}

		// Token: 0x04008292 RID: 33426
		private IAddOrSubAlertValueChangeSpeed Instance;
	}
}
