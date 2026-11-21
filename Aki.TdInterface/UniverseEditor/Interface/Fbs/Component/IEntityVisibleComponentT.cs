using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572B RID: 22315
	public class IEntityVisibleComponentT
	{
		// Token: 0x1700A11C RID: 41244
		// (get) Token: 0x06023E48 RID: 147016 RVA: 0x004EF3A5 File Offset: 0x004ED5A5
		// (set) Token: 0x06023E49 RID: 147017 RVA: 0x004EF3AD File Offset: 0x004ED5AD
		public bool Disabled { get; set; }

		// Token: 0x1700A11D RID: 41245
		// (get) Token: 0x06023E4A RID: 147018 RVA: 0x004EF3B6 File Offset: 0x004ED5B6
		// (set) Token: 0x06023E4B RID: 147019 RVA: 0x004EF3BE File Offset: 0x004ED5BE
		public bool DelayChange { get; set; }

		// Token: 0x1700A11E RID: 41246
		// (get) Token: 0x06023E4C RID: 147020 RVA: 0x004EF3C7 File Offset: 0x004ED5C7
		// (set) Token: 0x06023E4D RID: 147021 RVA: 0x004EF3CF File Offset: 0x004ED5CF
		public bool UseFadeEffect { get; set; }

		// Token: 0x1700A11F RID: 41247
		// (get) Token: 0x06023E4E RID: 147022 RVA: 0x004EF3D8 File Offset: 0x004ED5D8
		// (set) Token: 0x06023E4F RID: 147023 RVA: 0x004EF3E0 File Offset: 0x004ED5E0
		public bool UseCutEffect { get; set; }

		// Token: 0x1700A120 RID: 41248
		// (get) Token: 0x06023E50 RID: 147024 RVA: 0x004EF3E9 File Offset: 0x004ED5E9
		// (set) Token: 0x06023E51 RID: 147025 RVA: 0x004EF3F1 File Offset: 0x004ED5F1
		public bool UseHolographicEffect { get; set; }

		// Token: 0x1700A121 RID: 41249
		// (get) Token: 0x06023E52 RID: 147026 RVA: 0x004EF3FA File Offset: 0x004ED5FA
		// (set) Token: 0x06023E53 RID: 147027 RVA: 0x004EF402 File Offset: 0x004ED602
		public List<IVisibleConditionGroupT> VisibleConditions { get; set; }

		// Token: 0x1700A122 RID: 41250
		// (get) Token: 0x06023E54 RID: 147028 RVA: 0x004EF40B File Offset: 0x004ED60B
		// (set) Token: 0x06023E55 RID: 147029 RVA: 0x004EF413 File Offset: 0x004ED613
		public int CustomVisibleRange { get; set; }

		// Token: 0x1700A123 RID: 41251
		// (get) Token: 0x06023E56 RID: 147030 RVA: 0x004EF41C File Offset: 0x004ED61C
		// (set) Token: 0x06023E57 RID: 147031 RVA: 0x004EF424 File Offset: 0x004ED624
		public ERuntimePlatformOptions TargetPlatform { get; set; }

		// Token: 0x1700A124 RID: 41252
		// (get) Token: 0x06023E58 RID: 147032 RVA: 0x004EF42D File Offset: 0x004ED62D
		// (set) Token: 0x06023E59 RID: 147033 RVA: 0x004EF435 File Offset: 0x004ED635
		public byte NullMask { get; set; }

		// Token: 0x06023E5A RID: 147034 RVA: 0x004EF440 File Offset: 0x004ED640
		public IEntityVisibleComponentT()
		{
			this.Disabled = false;
			this.DelayChange = false;
			this.UseFadeEffect = false;
			this.UseCutEffect = false;
			this.UseHolographicEffect = false;
			this.VisibleConditions = null;
			this.CustomVisibleRange = 0;
			this.TargetPlatform = ERuntimePlatformOptions.None;
			this.NullMask = 0;
		}
	}
}
