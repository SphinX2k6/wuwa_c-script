using System;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006489 RID: 25737
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class RegisterPhotoCameraComponentAttribute : Attribute
	{
		// Token: 0x17007718 RID: 30488
		// (get) Token: 0x0603E8B5 RID: 256181 RVA: 0x0123522F File Offset: 0x0123342F
		public EPhotoCameraComponent Id { get; }

		// Token: 0x0603E8B6 RID: 256182 RVA: 0x01235237 File Offset: 0x01233437
		public RegisterPhotoCameraComponentAttribute(EPhotoCameraComponent id)
		{
			this.Id = id;
		}
	}
}
