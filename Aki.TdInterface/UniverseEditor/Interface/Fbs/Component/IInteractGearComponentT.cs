using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DC RID: 23004
	public class IInteractGearComponentT
	{
		// Token: 0x1700A730 RID: 42800
		// (get) Token: 0x060258F5 RID: 153845 RVA: 0x00526F08 File Offset: 0x00525108
		// (set) Token: 0x060258F6 RID: 153846 RVA: 0x00526F10 File Offset: 0x00525110
		public bool Disabled { get; set; }

		// Token: 0x1700A731 RID: 42801
		// (get) Token: 0x060258F7 RID: 153847 RVA: 0x00526F19 File Offset: 0x00525119
		// (set) Token: 0x060258F8 RID: 153848 RVA: 0x00526F21 File Offset: 0x00525121
		public float NormalPrepareTime { get; set; }

		// Token: 0x1700A732 RID: 42802
		// (get) Token: 0x060258F9 RID: 153849 RVA: 0x00526F2A File Offset: 0x0052512A
		// (set) Token: 0x060258FA RID: 153850 RVA: 0x00526F32 File Offset: 0x00525132
		public float ActivePrepareTime { get; set; }

		// Token: 0x1700A733 RID: 42803
		// (get) Token: 0x060258FB RID: 153851 RVA: 0x00526F3B File Offset: 0x0052513B
		// (set) Token: 0x060258FC RID: 153852 RVA: 0x00526F43 File Offset: 0x00525143
		public byte NullMask { get; set; }

		// Token: 0x060258FD RID: 153853 RVA: 0x00526F4C File Offset: 0x0052514C
		public IInteractGearComponentT()
		{
			this.Disabled = false;
			this.NormalPrepareTime = 0f;
			this.ActivePrepareTime = 0f;
			this.NullMask = 0;
		}
	}
}
