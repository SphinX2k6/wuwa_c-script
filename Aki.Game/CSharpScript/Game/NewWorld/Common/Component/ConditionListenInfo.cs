using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x020061FF RID: 25087
	[NullableContext(1)]
	[Nullable(0)]
	internal class ConditionListenInfo
	{
		// Token: 0x0603C428 RID: 246824 RVA: 0x0112BD34 File Offset: 0x01129F34
		public ConditionListenInfo(IClientConditionListener conditionListener, bool checkResult)
		{
		}

		// Token: 0x0401FE8B RID: 130699
		public IClientConditionListener ConditionListener = conditionListener;

		// Token: 0x0401FE8C RID: 130700
		public bool CheckResult = checkResult;

		// Token: 0x0401FE8D RID: 130701
		public List<int> LevelListenerIds = new List<int>();
	}
}
