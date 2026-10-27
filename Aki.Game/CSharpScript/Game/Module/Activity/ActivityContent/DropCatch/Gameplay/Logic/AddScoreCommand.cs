using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671C RID: 26396
	public class AddScoreCommand : IDropCatchCommand
	{
		// Token: 0x06041E96 RID: 269974 RVA: 0x00FFCAB4 File Offset: 0x00FFACB4
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddScoreCommandParams addScoreCommandParams = (IAddScoreCommandParams)@params;
			context.GetLogicContext().GetProxy().AddScore((float)addScoreCommandParams.Score);
		}
	}
}
