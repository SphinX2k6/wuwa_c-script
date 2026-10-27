using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002684 RID: 9860
	public class DestroyFishingBoat : ActionParams
	{
		// Token: 0x0600DCD8 RID: 56536 RVA: 0x0020D652 File Offset: 0x0020B852
		[NullableContext(1)]
		public static DestroyFishingBoat Create(IDestroyFishingBoat? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyFishingBoat
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007AB6 RID: 31414
		private IDestroyFishingBoat Instance;
	}
}
