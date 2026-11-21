using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B62 RID: 11106
	public class TakePlotPhoto : ActionParams
	{
		// Token: 0x0600F41F RID: 62495 RVA: 0x00239B87 File Offset: 0x00237D87
		public static TakePlotPhoto Create(ITakePlotPhoto? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TakePlotPhoto
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040085DE RID: 34270
		private ITakePlotPhoto Instance;
	}
}
