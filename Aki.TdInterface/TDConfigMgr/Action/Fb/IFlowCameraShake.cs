using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E7 RID: 10215
	public class IFlowCameraShake
	{
		// Token: 0x0600E1FE RID: 57854 RVA: 0x0021375A File Offset: 0x0021195A
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

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0600E1FF RID: 57855 RVA: 0x00213779 File Offset: 0x00211979
		public virtual string CameraShakeBp
		{
			get
			{
				return this.Instance.CameraShakeBp;
			}
		}

		// Token: 0x04007AE1 RID: 31457
		private IFlowCameraShake Instance;
	}
}
