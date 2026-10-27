using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200457B RID: 17787
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GameCommandBarely<[Nullable(0)] T> : GameCommandWithValidators<T> where T : ICommandType
	{
		// Token: 0x0602DE75 RID: 188021 RVA: 0x00A8DB3A File Offset: 0x00A8BD3A
		public GameCommandBarely([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<TCommandHandleParams<T>> execute, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<TCommandHandleParams<T>> undo, TCommandHandleParams<T> @params)
		{
			base.Execute = execute;
			base.Undo = undo;
			base.Params = @params;
		}
	}
}
