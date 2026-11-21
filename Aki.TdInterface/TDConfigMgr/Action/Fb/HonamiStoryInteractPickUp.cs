using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D83 RID: 11651
	public class HonamiStoryInteractPickUp : ActionParams
	{
		// Token: 0x0600FE13 RID: 65043 RVA: 0x0024A9DF File Offset: 0x00248BDF
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

		// Token: 0x04008AB5 RID: 35509
		private IHonamiStoryInteractPickUp Instance;
	}
}
