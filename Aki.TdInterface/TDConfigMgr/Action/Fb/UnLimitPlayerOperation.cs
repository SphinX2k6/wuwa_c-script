using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C7 RID: 10183
	public class UnLimitPlayerOperation : ActionParams
	{
		// Token: 0x0600E276 RID: 57974 RVA: 0x002171D3 File Offset: 0x002153D3
		[NullableContext(1)]
		public static UnLimitPlayerOperation Create(IUnLimitPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnLimitPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007D97 RID: 32151
		private IUnLimitPlayerOperation Instance;
	}
}
