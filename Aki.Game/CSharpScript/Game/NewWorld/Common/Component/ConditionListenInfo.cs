using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200707E RID: 28798
	[NullableContext(1)]
	[Nullable(0)]
	internal class ConditionListenInfo
	{
		// Token: 0x06046219 RID: 287257 RVA: 0x011825BF File Offset: 0x011807BF
		public ConditionListenInfo(IClientConditionListener conditionListener, bool checkResult)
		{
		}

		// Token: 0x04024BD0 RID: 150480
		public IClientConditionListener ConditionListener = conditionListener;

		// Token: 0x04024BD1 RID: 150481
		public bool CheckResult = checkResult;

		// Token: 0x04024BD2 RID: 150482
		public List<int> LevelListenerIds = new List<int>();
	}
}
