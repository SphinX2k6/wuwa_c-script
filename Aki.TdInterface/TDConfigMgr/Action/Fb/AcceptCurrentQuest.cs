using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002909 RID: 10505
	public class AcceptCurrentQuest : ActionParams
	{
		// Token: 0x0600E9A6 RID: 59814 RVA: 0x00227FB9 File Offset: 0x002261B9
		public static AcceptCurrentQuest Create(IAcceptCurrentQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AcceptCurrentQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040080C9 RID: 32969
		private IAcceptCurrentQuest Instance;
	}
}
