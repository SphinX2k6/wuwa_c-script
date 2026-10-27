using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AC RID: 9644
	public class ITalkAkEvent
	{
		// Token: 0x0600D8F8 RID: 55544 RVA: 0x00206092 File Offset: 0x00204292
		[NullableContext(1)]
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

		// Token: 0x0400788A RID: 30858
		private ITalkAkEvent Instance;
	}
}
