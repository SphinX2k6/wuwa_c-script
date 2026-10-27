using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A91 RID: 10897
	public class HonamiStoryActivateSafeEvacuation : ActionParams
	{
		// Token: 0x0600EF64 RID: 61284 RVA: 0x0022CD73 File Offset: 0x0022AF73
		[NullableContext(1)]
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

		// Token: 0x040083B3 RID: 33715
		private IHonamiStoryActivateSafeEvacuation Instance;
	}
}
