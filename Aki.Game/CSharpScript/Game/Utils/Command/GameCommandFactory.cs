using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200457C RID: 17788
	[NullableContext(1)]
	[Nullable(0)]
	public static class GameCommandFactory
	{
		// Token: 0x0602DE76 RID: 188022 RVA: 0x00A8DB57 File Offset: 0x00A8BD57
		public static IGameCommandWithReceivers<T> CreateGameCommandWithReceivers<[Nullable(0)] T>(TCommandHandleParams<T> @params) where T : ICommandType
		{
			return new GameCommandWithReceivers<T>(@params);
		}

		// Token: 0x0602DE77 RID: 188023 RVA: 0x00A8DB5F File Offset: 0x00A8BD5F
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
