using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F2 RID: 10482
	public class StopCameraLookAt : ActionParams
	{
		// Token: 0x0600E942 RID: 59714 RVA: 0x002273C6 File Offset: 0x002255C6
		public static StopCameraLookAt Create(IStopCameraLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopCameraLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008080 RID: 32896
		private IStopCameraLookAt Instance;
	}
}
