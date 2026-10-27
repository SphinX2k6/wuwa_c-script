using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024DD RID: 9437
	public class FixTeleControllerPos : ActionParams
	{
		// Token: 0x0600D2B4 RID: 53940 RVA: 0x001F4143 File Offset: 0x001F2343
		[NullableContext(1)]
		public static FixTeleControllerPos Create(IFixTeleControllerPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixTeleControllerPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007393 RID: 29587
		private IFixTeleControllerPos Instance;
	}
}
