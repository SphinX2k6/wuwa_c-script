using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566C RID: 22124
	public class AddScoreCommand : IDropCatchCommand
	{
		// Token: 0x060369E2 RID: 223714 RVA: 0x00F3DE80 File Offset: 0x00F3C080
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddScoreCommandParams addScoreCommandParams = (IAddScoreCommandParams)@params;
			context.GetLogicContext().GetProxy().AddScore((float)addScoreCommandParams.Score);
		}
	}
}
