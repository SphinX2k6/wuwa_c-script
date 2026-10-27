using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C9 RID: 9929
	public class RogueActivatePortal : ActionParams
	{
		// Token: 0x0600DE06 RID: 56838 RVA: 0x0020F4AC File Offset: 0x0020D6AC
		[NullableContext(1)]
		public static RogueActivatePortal Create(IRogueActivatePortal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueActivatePortal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007B47 RID: 31559
		private IRogueActivatePortal Instance;
	}
}
