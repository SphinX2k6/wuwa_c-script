using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AC3 RID: 23235
	public class ActionSetNpcPosition : ActionParams
	{
		// Token: 0x0401E1DD RID: 123357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<EntityPositionData> EntityData;

		// Token: 0x0401E1DE RID: 123358
		public bool IsCenterPosition = true;
	}
}
