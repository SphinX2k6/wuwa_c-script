using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B61 RID: 2913
	public class IPulseDeviceFoundation : IItemFoundationType
	{
		// Token: 0x06004315 RID: 17173 RVA: 0x000AB14D File Offset: 0x000A934D
		[NullableContext(1)]
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x000AB16C File Offset: 0x000A936C
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x040025DC RID: 9692
		private IPulseDeviceFoundation Instance;
	}
}
