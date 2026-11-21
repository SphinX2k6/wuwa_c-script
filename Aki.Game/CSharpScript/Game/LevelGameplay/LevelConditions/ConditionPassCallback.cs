using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EF5 RID: 24309
	[NullableContext(1)]
	[Nullable(0)]
	public class ConditionPassCallback
	{
		// Token: 0x0603A8F9 RID: 239865 RVA: 0x0108D289 File Offset: 0x0108B489
		public ConditionPassCallback(TConditionPassCallback callback, [Nullable(new byte[]
		{
			2,
			1
		})] object[] parameters = null)
		{
			this.Callback = callback;
			this.Params = parameters;
		}

		// Token: 0x0401EC7F RID: 126079
		public TConditionPassCallback Callback;

		// Token: 0x0401EC80 RID: 126080
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] Params;
	}
}
