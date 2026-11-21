using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A4 RID: 13476
	[NullableContext(1)]
	[Nullable(0)]
	public static class GameCommandFactory
	{
		// Token: 0x06022558 RID: 140632 RVA: 0x009B926F File Offset: 0x009B746F
		public static IGameCommandWithReceivers<T> CreateGameCommandWithReceivers<[Nullable(0)] T>(TCommandHandleParams<T> @params) where T : ICommandType
		{
			return new GameCommandWithReceivers<T>(@params);
		}

		// Token: 0x06022559 RID: 140633 RVA: 0x009B9277 File Offset: 0x009B7477
		public static IGameCommand<T> CreateGameCommandBarely<[Nullable(0)] T>([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<TCommandHandleParams<T>> execute, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<TCommandHandleParams<T>> undo, TCommandHandleParams<T> @params) where T : ICommandType
		{
			return new GameCommandBarely<T>(execute, undo, @params);
		}
	}
}
