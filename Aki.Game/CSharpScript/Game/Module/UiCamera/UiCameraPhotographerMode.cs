using System;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399D RID: 14749
	public class UiCameraPhotographerMode : UiCameraModeBase
	{
		// Token: 0x06025FED RID: 155629 RVA: 0x00AAA6A7 File Offset: 0x00AA88A7
		protected override void RegisterComponents()
		{
			base.RegisterComponent(new UiCameraPhotographerComponent());
			base.RegisterComponent(new UiCameraDisplayComponent());
		}
	}
}
