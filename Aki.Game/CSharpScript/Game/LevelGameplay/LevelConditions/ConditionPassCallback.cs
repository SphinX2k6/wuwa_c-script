using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D76 RID: 28022
	[NullableContext(1)]
	[Nullable(0)]
	public class ConditionPassCallback
	{
		// Token: 0x06044795 RID: 280469 RVA: 0x010E30A5 File Offset: 0x010E12A5
		public ConditionPassCallback(TConditionPassCallback callback, [Nullable(new byte[]
		{
			2,
			1
		})] object[] parameters = null)
		{
			this.Callback = callback;
			this.Params = parameters;
		}

		// Token: 0x040239DD RID: 145885
		public TConditionPassCallback Callback;

		// Token: 0x040239DE RID: 145886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] Params;
	}
}
