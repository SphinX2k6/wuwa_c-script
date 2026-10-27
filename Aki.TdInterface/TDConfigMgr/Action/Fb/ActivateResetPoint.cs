using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002896 RID: 10390
	public class ActivateResetPoint : ActionParams
	{
		// Token: 0x0600E618 RID: 58904 RVA: 0x0021D112 File Offset: 0x0021B312
		[NullableContext(1)]
		public static ActivateResetPoint Create(IActivateResetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateResetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007F36 RID: 32566
		private IActivateResetPoint Instance;
	}
}
