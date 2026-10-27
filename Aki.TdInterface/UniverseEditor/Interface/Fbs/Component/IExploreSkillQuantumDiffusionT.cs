using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FF RID: 20991
	public class IExploreSkillQuantumDiffusionT
	{
		// Token: 0x170099C7 RID: 39367
		// (get) Token: 0x060221B8 RID: 139704 RVA: 0x004BBD4B File Offset: 0x004B9F4B
		// (set) Token: 0x060221B9 RID: 139705 RVA: 0x004BBD53 File Offset: 0x004B9F53
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x170099C8 RID: 39368
		// (get) Token: 0x060221BA RID: 139706 RVA: 0x004BBD5C File Offset: 0x004B9F5C
		// (set) Token: 0x060221BB RID: 139707 RVA: 0x004BBD64 File Offset: 0x004B9F64
		public bool NeedFollowShooter { get; set; }

		// Token: 0x170099C9 RID: 39369
		// (get) Token: 0x060221BC RID: 139708 RVA: 0x004BBD6D File Offset: 0x004B9F6D
		// (set) Token: 0x060221BD RID: 139709 RVA: 0x004BBD75 File Offset: 0x004B9F75
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x170099CA RID: 39370
		// (get) Token: 0x060221BE RID: 139710 RVA: 0x004BBD7E File Offset: 0x004B9F7E
		// (set) Token: 0x060221BF RID: 139711 RVA: 0x004BBD86 File Offset: 0x004B9F86
		public byte NullMask { get; set; }

		// Token: 0x060221C0 RID: 139712 RVA: 0x004BBD8F File Offset: 0x004B9F8F
		public IExploreSkillQuantumDiffusionT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.NeedFollowShooter = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
