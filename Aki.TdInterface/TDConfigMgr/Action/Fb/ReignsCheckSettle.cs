using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A55 RID: 10837
	public class ReignsCheckSettle : ActionParams
	{
		// Token: 0x0600EE72 RID: 61042 RVA: 0x0022B577 File Offset: 0x00229777
		[NullableContext(1)]
		public static ReignsCheckSettle Create(IReignsCheckSettle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCheckSettle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008331 RID: 33585
		private IReignsCheckSettle Instance;
	}
}
