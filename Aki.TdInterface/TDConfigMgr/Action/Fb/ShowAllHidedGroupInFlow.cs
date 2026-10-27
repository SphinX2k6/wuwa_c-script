using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002835 RID: 10293
	public class ShowAllHidedGroupInFlow : ActionParams
	{
		// Token: 0x0600E43E RID: 58430 RVA: 0x00219A7A File Offset: 0x00217C7A
		[NullableContext(1)]
		public static ShowAllHidedGroupInFlow Create(IShowAllHidedGroupInFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowAllHidedGroupInFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007E49 RID: 32329
		private IShowAllHidedGroupInFlow Instance;
	}
}
