using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592A RID: 22826
	public class ISlashHookT
	{
		// Token: 0x1700AB3A RID: 43834
		// (get) Token: 0x060269B4 RID: 158132 RVA: 0x00551630 File Offset: 0x0054F830
		// (set) Token: 0x060269B5 RID: 158133 RVA: 0x00551638 File Offset: 0x0054F838
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AB3B RID: 43835
		// (get) Token: 0x060269B6 RID: 158134 RVA: 0x00551641 File Offset: 0x0054F841
		// (set) Token: 0x060269B7 RID: 158135 RVA: 0x00551649 File Offset: 0x0054F849
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AB3C RID: 43836
		// (get) Token: 0x060269B8 RID: 158136 RVA: 0x00551652 File Offset: 0x0054F852
		// (set) Token: 0x060269B9 RID: 158137 RVA: 0x0055165A File Offset: 0x0054F85A
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AB3D RID: 43837
		// (get) Token: 0x060269BA RID: 158138 RVA: 0x00551663 File Offset: 0x0054F863
		// (set) Token: 0x060269BB RID: 158139 RVA: 0x0055166B File Offset: 0x0054F86B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AB3E RID: 43838
		// (get) Token: 0x060269BC RID: 158140 RVA: 0x00551674 File Offset: 0x0054F874
		// (set) Token: 0x060269BD RID: 158141 RVA: 0x0055167C File Offset: 0x0054F87C
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AB3F RID: 43839
		// (get) Token: 0x060269BE RID: 158142 RVA: 0x00551685 File Offset: 0x0054F885
		// (set) Token: 0x060269BF RID: 158143 RVA: 0x0055168D File Offset: 0x0054F88D
		public ESlashHitType SlashHitType { get; set; }

		// Token: 0x1700AB40 RID: 43840
		// (get) Token: 0x060269C0 RID: 158144 RVA: 0x00551696 File Offset: 0x0054F896
		// (set) Token: 0x060269C1 RID: 158145 RVA: 0x0055169E File Offset: 0x0054F89E
		public ESlashAngleType SlashAngleType { get; set; }

		// Token: 0x1700AB41 RID: 43841
		// (get) Token: 0x060269C2 RID: 158146 RVA: 0x005516A7 File Offset: 0x0054F8A7
		// (set) Token: 0x060269C3 RID: 158147 RVA: 0x005516AF File Offset: 0x0054F8AF
		public ESlashDirType DefaultSlashDir { get; set; }

		// Token: 0x1700AB42 RID: 43842
		// (get) Token: 0x060269C4 RID: 158148 RVA: 0x005516B8 File Offset: 0x0054F8B8
		// (set) Token: 0x060269C5 RID: 158149 RVA: 0x005516C0 File Offset: 0x0054F8C0
		public IVectorInfoT CharacterLookAt { get; set; }

		// Token: 0x1700AB43 RID: 43843
		// (get) Token: 0x060269C6 RID: 158150 RVA: 0x005516C9 File Offset: 0x0054F8C9
		// (set) Token: 0x060269C7 RID: 158151 RVA: 0x005516D1 File Offset: 0x0054F8D1
		public int CharacterLookAtPointId { get; set; }

		// Token: 0x1700AB44 RID: 43844
		// (get) Token: 0x060269C8 RID: 158152 RVA: 0x005516DA File Offset: 0x0054F8DA
		// (set) Token: 0x060269C9 RID: 158153 RVA: 0x005516E2 File Offset: 0x0054F8E2
		public int SlashBackSafePointId { get; set; }

		// Token: 0x1700AB45 RID: 43845
		// (get) Token: 0x060269CA RID: 158154 RVA: 0x005516EB File Offset: 0x0054F8EB
		// (set) Token: 0x060269CB RID: 158155 RVA: 0x005516F3 File Offset: 0x0054F8F3
		public bool IsAdjustCameraConfig { get; set; }

		// Token: 0x1700AB46 RID: 43846
		// (get) Token: 0x060269CC RID: 158156 RVA: 0x005516FC File Offset: 0x0054F8FC
		// (set) Token: 0x060269CD RID: 158157 RVA: 0x00551704 File Offset: 0x0054F904
		public byte NullMask { get; set; }

		// Token: 0x060269CE RID: 158158 RVA: 0x00551710 File Offset: 0x0054F910
		public ISlashHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.SlashHitType = ESlashHitType.HeavySlash;
			this.SlashAngleType = ESlashAngleType.Slash45;
			this.DefaultSlashDir = ESlashDirType.Horizontal;
			this.CharacterLookAt = null;
			this.CharacterLookAtPointId = 0;
			this.SlashBackSafePointId = 0;
			this.IsAdjustCameraConfig = false;
			this.NullMask = 0;
		}
	}
}
