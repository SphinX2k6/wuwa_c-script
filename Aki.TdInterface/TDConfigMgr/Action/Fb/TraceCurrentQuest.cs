using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002785 RID: 10117
	public class TraceCurrentQuest : ActionParams
	{
		// Token: 0x0600E010 RID: 57360 RVA: 0x0020FA21 File Offset: 0x0020DC21
		public static TraceCurrentQuest Create(ITraceCurrentQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceCurrentQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079E3 RID: 31203
		private ITraceCurrentQuest Instance;
	}
}
