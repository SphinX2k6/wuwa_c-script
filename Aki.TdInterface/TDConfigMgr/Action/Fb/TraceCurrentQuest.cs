using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E0 RID: 9440
	public class TraceCurrentQuest : ActionParams
	{
		// Token: 0x0600D2BB RID: 53947 RVA: 0x001F41C5 File Offset: 0x001F23C5
		[NullableContext(1)]
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

		// Token: 0x04007396 RID: 29590
		private ITraceCurrentQuest Instance;
	}
}
