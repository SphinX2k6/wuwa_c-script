using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D85 RID: 11653
	public class HonamiStoryActivateSafeEvacuation : ActionParams
	{
		// Token: 0x0600FE1A RID: 65050 RVA: 0x0024AA7F File Offset: 0x00248C7F
		public static HonamiStoryActivateSafeEvacuation Create(IHonamiStoryActivateSafeEvacuation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryActivateSafeEvacuation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008AB7 RID: 35511
		private IHonamiStoryActivateSafeEvacuation Instance;
	}
}
