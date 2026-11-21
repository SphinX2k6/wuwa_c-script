using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200349F RID: 13471
	public interface IGameCommand<T> : IGameCommandBase where T : ICommandType
	{
		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x0602253F RID: 140607
		// (set) Token: 0x06022540 RID: 140608
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Action<TCommandHandleParams<T>> Execute { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06022541 RID: 140609
		// (set) Token: 0x06022542 RID: 140610
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Action<TCommandHandleParams<T>> Undo { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06022543 RID: 140611
		// (set) Token: 0x06022544 RID: 140612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		TCommandHandleParams<T> Params { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
