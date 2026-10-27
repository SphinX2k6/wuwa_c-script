using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8F RID: 10895
	public class HonamiStoryInteractPickUp : ActionParams
	{
		// Token: 0x0600EF5D RID: 61277 RVA: 0x0022CCD3 File Offset: 0x0022AED3
		[NullableContext(1)]
		public static HonamiStoryInteractPickUp Create(IHonamiStoryInteractPickUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryInteractPickUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040083B1 RID: 33713
		private IHonamiStoryInteractPickUp Instance;
	}
}
