using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699A RID: 27034
	public class IInteractPointT
	{
		// Token: 0x1700C894 RID: 51348
		// (get) Token: 0x0602F3CD RID: 193485 RVA: 0x0066F745 File Offset: 0x0066D945
		// (set) Token: 0x0602F3CE RID: 193486 RVA: 0x0066F74D File Offset: 0x0066D94D
		public int Tag { get; set; }

		// Token: 0x1700C895 RID: 51349
		// (get) Token: 0x0602F3CF RID: 193487 RVA: 0x0066F756 File Offset: 0x0066D956
		// (set) Token: 0x0602F3D0 RID: 193488 RVA: 0x0066F75E File Offset: 0x0066D95E
		public List<TInteractEffectUnion> InteractEffects { get; set; }

		// Token: 0x1700C896 RID: 51350
		// (get) Token: 0x0602F3D1 RID: 193489 RVA: 0x0066F767 File Offset: 0x0066D967
		// (set) Token: 0x0602F3D2 RID: 193490 RVA: 0x0066F76F File Offset: 0x0066D96F
		public bool IsValidPoint { get; set; }

		// Token: 0x1700C897 RID: 51351
		// (get) Token: 0x0602F3D3 RID: 193491 RVA: 0x0066F778 File Offset: 0x0066D978
		// (set) Token: 0x0602F3D4 RID: 193492 RVA: 0x0066F780 File Offset: 0x0066D980
		public float ProtectTime { get; set; }

		// Token: 0x1700C898 RID: 51352
		// (get) Token: 0x0602F3D5 RID: 193493 RVA: 0x0066F789 File Offset: 0x0066D989
		// (set) Token: 0x0602F3D6 RID: 193494 RVA: 0x0066F791 File Offset: 0x0066D991
		public bool CancelRaycast { get; set; }

		// Token: 0x1700C899 RID: 51353
		// (get) Token: 0x0602F3D7 RID: 193495 RVA: 0x0066F79A File Offset: 0x0066D99A
		// (set) Token: 0x0602F3D8 RID: 193496 RVA: 0x0066F7A2 File Offset: 0x0066D9A2
		public IDragInteractPointInteractionT InteractionConfig { get; set; }

		// Token: 0x1700C89A RID: 51354
		// (get) Token: 0x0602F3D9 RID: 193497 RVA: 0x0066F7AB File Offset: 0x0066D9AB
		// (set) Token: 0x0602F3DA RID: 193498 RVA: 0x0066F7B3 File Offset: 0x0066D9B3
		public byte NullMask { get; set; }

		// Token: 0x0602F3DB RID: 193499 RVA: 0x0066F7BC File Offset: 0x0066D9BC
		public IInteractPointT()
		{
			this.Tag = 0;
			this.InteractEffects = null;
			this.IsValidPoint = false;
			this.ProtectTime = 0f;
			this.CancelRaycast = false;
			this.InteractionConfig = null;
			this.NullMask = 0;
		}
	}
}
