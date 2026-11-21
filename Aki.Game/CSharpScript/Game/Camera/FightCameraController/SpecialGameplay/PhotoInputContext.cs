using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006476 RID: 25718
	[NullableContext(1)]
	[Nullable(0)]
	public class PhotoInputContext : IPhotoInputContext
	{
		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x0603E7B8 RID: 255928 RVA: 0x0122F318 File Offset: 0x0122D518
		// (set) Token: 0x0603E7B9 RID: 255929 RVA: 0x0122F320 File Offset: 0x0122D520
		[Nullable(2)]
		public TsBaseCharacter Character { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x0603E7BA RID: 255930 RVA: 0x0122F329 File Offset: 0x0122D529
		// (set) Token: 0x0603E7BB RID: 255931 RVA: 0x0122F331 File Offset: 0x0122D531
		public PhotoCameraLogicComponent Logic { get; set; }
	}
}
