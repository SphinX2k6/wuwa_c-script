using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200669F RID: 26271
	[NullableContext(1)]
	public interface IDropCatchCommand
	{
		// Token: 0x06041C61 RID: 269409
		void Execute(ICommandContext context, [Nullable(2)] object @params);
	}
}
