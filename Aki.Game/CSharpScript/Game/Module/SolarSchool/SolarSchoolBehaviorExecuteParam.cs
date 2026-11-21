using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0F RID: 23055
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolBehaviorExecuteParam
	{
		// Token: 0x0401DE24 RID: 122404
		public int BehaviorId;

		// Token: 0x0401DE25 RID: 122405
		public int Level;

		// Token: 0x0401DE26 RID: 122406
		public bool Success;

		// Token: 0x0401DE27 RID: 122407
		public Action OnSettle;

		// Token: 0x0401DE28 RID: 122408
		public Action OnFinish;
	}
}
