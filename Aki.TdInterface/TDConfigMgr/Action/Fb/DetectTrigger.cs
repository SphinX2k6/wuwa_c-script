using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D4 RID: 9940
	public class DetectTrigger : ActionParams
	{
		// Token: 0x0600DE2F RID: 56879 RVA: 0x0020F9A8 File Offset: 0x0020DBA8
		[NullableContext(1)]
		public static DetectTrigger Create(IDetectTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DetectTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007B5C RID: 31580
		private IDetectTrigger Instance;
	}
}
