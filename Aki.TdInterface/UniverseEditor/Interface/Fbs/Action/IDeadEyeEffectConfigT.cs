using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200654D RID: 25933
	public class IDeadEyeEffectConfigT
	{
		// Token: 0x1700C0C7 RID: 49351
		// (get) Token: 0x0602CFF6 RID: 184310 RVA: 0x0062D466 File Offset: 0x0062B666
		// (set) Token: 0x0602CFF7 RID: 184311 RVA: 0x0062D46E File Offset: 0x0062B66E
		public string FilterEffect { get; set; }

		// Token: 0x1700C0C8 RID: 49352
		// (get) Token: 0x0602CFF8 RID: 184312 RVA: 0x0062D477 File Offset: 0x0062B677
		// (set) Token: 0x0602CFF9 RID: 184313 RVA: 0x0062D47F File Offset: 0x0062B67F
		public string TargetIdleMaterialDa { get; set; }

		// Token: 0x1700C0C9 RID: 49353
		// (get) Token: 0x0602CFFA RID: 184314 RVA: 0x0062D488 File Offset: 0x0062B688
		// (set) Token: 0x0602CFFB RID: 184315 RVA: 0x0062D490 File Offset: 0x0062B690
		public string TargetLockedMaterialDa { get; set; }

		// Token: 0x0602CFFC RID: 184316 RVA: 0x0062D499 File Offset: 0x0062B699
		public IDeadEyeEffectConfigT()
		{
			this.FilterEffect = null;
			this.TargetIdleMaterialDa = null;
			this.TargetLockedMaterialDa = null;
		}
	}
}
