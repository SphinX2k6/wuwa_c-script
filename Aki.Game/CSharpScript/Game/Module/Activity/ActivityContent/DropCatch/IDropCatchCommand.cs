using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055EF RID: 21999
	[NullableContext(1)]
	public interface IDropCatchCommand
	{
		// Token: 0x060367AD RID: 223149
		void Execute(ICommandContext context, [Nullable(2)] object @params);
	}
}
