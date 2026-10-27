using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004577 RID: 17783
	public interface IGameCommand<T> : IGameCommandBase where T : ICommandType
	{
		// Token: 0x1700758C RID: 30092
		// (get) Token: 0x0602DE5D RID: 187997
		// (set) Token: 0x0602DE5E RID: 187998
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

		// Token: 0x1700758D RID: 30093
		// (get) Token: 0x0602DE5F RID: 187999
		// (set) Token: 0x0602DE60 RID: 188000
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

		// Token: 0x1700758E RID: 30094
		// (get) Token: 0x0602DE61 RID: 188001
		// (set) Token: 0x0602DE62 RID: 188002
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
