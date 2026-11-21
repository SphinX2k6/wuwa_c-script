using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298D RID: 10637
	public class RogueActivatePortal : ActionParams
	{
		// Token: 0x0600EBE2 RID: 60386 RVA: 0x0022BCEC File Offset: 0x00229EEC
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

		// Token: 0x040081E7 RID: 33255
		private IRogueActivatePortal Instance;
	}
}
