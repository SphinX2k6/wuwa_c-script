using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006729 RID: 26409
	public class PostAudioEventCommand : IDropCatchCommand
	{
		// Token: 0x06041EB0 RID: 270000 RVA: 0x00FFD030 File Offset: 0x00FFB230
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IPostAudioEventCommandParams postAudioEventCommandParams = (IPostAudioEventCommandParams)@params;
			AudioSystem.Instance.PostEvent(postAudioEventCommandParams.Event);
		}
	}
}
