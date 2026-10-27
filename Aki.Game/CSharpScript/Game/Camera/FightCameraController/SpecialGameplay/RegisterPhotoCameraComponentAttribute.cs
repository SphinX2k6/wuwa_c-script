using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02007306 RID: 29446
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class RegisterPhotoCameraComponentAttribute : Attribute
	{
		// Token: 0x17009F7A RID: 40826
		// (get) Token: 0x06048468 RID: 296040 RVA: 0x012927AC File Offset: 0x012909AC
		public EPhotoCameraComponent Id { get; }

		// Token: 0x06048469 RID: 296041 RVA: 0x012927B4 File Offset: 0x012909B4
		public RegisterPhotoCameraComponentAttribute(EPhotoCameraComponent id)
		{
			this.Id = id;
		}
	}
}
