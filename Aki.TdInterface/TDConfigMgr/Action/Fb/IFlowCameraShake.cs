using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002540 RID: 9536
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowCameraShake
	{
		// Token: 0x0600D49E RID: 54430 RVA: 0x001F7CFA File Offset: 0x001F5EFA
		public static IFlowCameraShake Create(IFlowCameraShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowCameraShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600D49F RID: 54431 RVA: 0x001F7D19 File Offset: 0x001F5F19
		public virtual string CameraShakeBp
		{
			get
			{
				return this.Instance.CameraShakeBp;
			}
		}

		// Token: 0x0400748C RID: 29836
		private IFlowCameraShake Instance;
	}
}
