using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004573 RID: 17779
	[NullableContext(1)]
	public interface IReceiver<[Nullable(0)] T> where T : ICommandType
	{
		// Token: 0x17007587 RID: 30087
		// (get) Token: 0x0602DE53 RID: 187987
		// (set) Token: 0x0602DE54 RID: 187988
		Action<TCommandHandleParams<T>> ReceiveExecute { get; set; }

		// Token: 0x17007588 RID: 30088
		// (get) Token: 0x0602DE55 RID: 187989
		// (set) Token: 0x0602DE56 RID: 187990
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Action<TCommandHandleParams<T>> ReceiveUndo { [return: Nullable(new byte[]
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
	}
}
