using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F3 RID: 29427
	[NullableContext(1)]
	[Nullable(0)]
	public class PhotoInputContext : IPhotoInputContext
	{
		// Token: 0x17009F5C RID: 40796
		// (get) Token: 0x0604836C RID: 295788 RVA: 0x0128C964 File Offset: 0x0128AB64
		// (set) Token: 0x0604836D RID: 295789 RVA: 0x0128C96C File Offset: 0x0128AB6C
		[Nullable(2)]
		public TsBaseCharacter Character { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009F5D RID: 40797
		// (get) Token: 0x0604836E RID: 295790 RVA: 0x0128C975 File Offset: 0x0128AB75
		// (set) Token: 0x0604836F RID: 295791 RVA: 0x0128C97D File Offset: 0x0128AB7D
		public PhotoCameraLogicComponent Logic { get; set; }
	}
}
