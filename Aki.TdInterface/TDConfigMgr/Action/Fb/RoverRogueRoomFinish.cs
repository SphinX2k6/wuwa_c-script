using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0A RID: 10762
	public class RoverRogueRoomFinish : ActionParams
	{
		// Token: 0x0600ED66 RID: 60774 RVA: 0x00229CEB File Offset: 0x00227EEB
		[NullableContext(1)]
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

		// Token: 0x040082AE RID: 33454
		private IRoverRogueRoomFinish Instance;
	}
}
