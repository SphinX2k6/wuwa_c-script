using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200261F RID: 9759
	public class DestroyAllChild : ActionParams
	{
		// Token: 0x0600DB1A RID: 56090 RVA: 0x0020A1DE File Offset: 0x002083DE
		[NullableContext(1)]
		public static DestroyAllChild Create(IDestroyAllChild? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyAllChild
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079BD RID: 31165
		private IDestroyAllChild Instance;
	}
}
