using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002632 RID: 9778
	public class StopCameraLookAt : ActionParams
	{
		// Token: 0x0600DB74 RID: 56180 RVA: 0x0020ABFA File Offset: 0x00208DFA
		[NullableContext(1)]
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

		// Token: 0x040079E4 RID: 31204
		private IStopCameraLookAt Instance;
	}
}
