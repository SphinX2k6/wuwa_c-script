using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285B RID: 10331
	public class ITalkAkEvent
	{
		// Token: 0x0600E672 RID: 58994 RVA: 0x00221D66 File Offset: 0x0021FF66
		public static ITalkAkEvent Create(ITalkAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007EF1 RID: 32497
		private ITalkAkEvent Instance;
	}
}
