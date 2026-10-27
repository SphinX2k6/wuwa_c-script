using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264A RID: 9802
	public class FinishDoInteract : ActionParams
	{
		// Token: 0x0600DBDA RID: 56282 RVA: 0x0020B814 File Offset: 0x00209A14
		[NullableContext(1)]
		public static FinishDoInteract Create(IFinishDoInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDoInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007A2E RID: 31278
		private IFinishDoInteract Instance;
	}
}
