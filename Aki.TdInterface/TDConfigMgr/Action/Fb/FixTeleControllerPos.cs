using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002782 RID: 10114
	public class FixTeleControllerPos : ActionParams
	{
		// Token: 0x0600E009 RID: 57353 RVA: 0x0020F99F File Offset: 0x0020DB9F
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

		// Token: 0x040079E0 RID: 31200
		private IFixTeleControllerPos Instance;
	}
}
