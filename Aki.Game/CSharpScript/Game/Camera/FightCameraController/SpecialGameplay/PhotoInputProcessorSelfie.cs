using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F6 RID: 29430
	public class PhotoInputProcessorSelfie : PhotoInputProcessorBase
	{
		// Token: 0x06048375 RID: 295797 RVA: 0x0128CA3F File Offset: 0x0128AC3F
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
