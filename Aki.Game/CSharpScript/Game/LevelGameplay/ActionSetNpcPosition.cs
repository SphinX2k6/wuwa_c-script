using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006967 RID: 26983
	public class ActionSetNpcPosition : ActionParams
	{
		// Token: 0x04022FF3 RID: 143347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<EntityPositionData> EntityData;

		// Token: 0x04022FF4 RID: 143348
		public bool IsCenterPosition = true;
	}
}
