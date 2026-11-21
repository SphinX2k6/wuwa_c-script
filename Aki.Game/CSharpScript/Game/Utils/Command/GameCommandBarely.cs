using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A3 RID: 13475
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GameCommandBarely<[Nullable(0)] T> : GameCommandWithValidators<T> where T : ICommandType
	{
		// Token: 0x06022557 RID: 140631 RVA: 0x009B9252 File Offset: 0x009B7452
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
