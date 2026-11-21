using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF7 RID: 11511
	public class RoverRogueRoomFinish : ActionParams
	{
		// Token: 0x0600FBFD RID: 64509 RVA: 0x0024766F File Offset: 0x0024586F
		public static RoverRogueRoomFinish Create(IRoverRogueRoomFinish? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueRoomFinish
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400899F RID: 35231
		private IRoverRogueRoomFinish Instance;
	}
}
