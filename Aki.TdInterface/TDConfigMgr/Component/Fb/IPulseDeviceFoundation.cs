using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2F RID: 3119
	public class IPulseDeviceFoundation : IItemFoundationType
	{
		// Token: 0x0600476E RID: 18286 RVA: 0x000B5211 File Offset: 0x000B3411
		public static IPulseDeviceFoundation Create(IPulseDeviceFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPulseDeviceFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x000B5230 File Offset: 0x000B3430
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x04002824 RID: 10276
		private IPulseDeviceFoundation Instance;
	}
}
