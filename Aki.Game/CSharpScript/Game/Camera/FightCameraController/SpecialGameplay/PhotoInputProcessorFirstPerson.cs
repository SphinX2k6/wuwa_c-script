using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F5 RID: 29429
	public class PhotoInputProcessorFirstPerson : PhotoInputProcessorBase
	{
		// Token: 0x06048373 RID: 295795 RVA: 0x0128CA0B File Offset: 0x0128AC0B
		[NullableContext(1)]
		public override void Process(IPhotoInputSnapshot raw, IPhotoInputContext context, IPhotoInputSnapshot @out)
		{
			base.Process(raw, context, @out);
			@out.MoveForward = 0f;
			@out.MoveRight = 0f;
			@out.MoveUp = 0f;
		}
	}
}
