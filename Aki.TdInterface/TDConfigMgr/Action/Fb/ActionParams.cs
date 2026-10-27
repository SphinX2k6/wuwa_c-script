using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D2 RID: 9426
	public class ActionParams
	{
		// Token: 0x0600D291 RID: 53905 RVA: 0x001F3DCD File Offset: 0x001F1FCD
		[NullableContext(1)]
		public static ActionParams Create(IActionParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400737E RID: 29566
		private IActionParams Instance;
	}
}
