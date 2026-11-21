using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005679 RID: 22137
	public class PostAudioEventCommand : IDropCatchCommand
	{
		// Token: 0x060369FC RID: 223740 RVA: 0x00F3E3FC File Offset: 0x00F3C5FC
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IPostAudioEventCommandParams postAudioEventCommandParams = (IPostAudioEventCommandParams)@params;
			AudioSystem.Instance.PostEvent(postAudioEventCommandParams.Event);
		}
	}
}
