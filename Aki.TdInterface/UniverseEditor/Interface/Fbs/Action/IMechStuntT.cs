using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AB RID: 29099
	public class IMechStuntT
	{
		// Token: 0x1700D529 RID: 54569
		// (get) Token: 0x060329EA RID: 207338 RVA: 0x006D7309 File Offset: 0x006D5509
		// (set) Token: 0x060329EB RID: 207339 RVA: 0x006D7311 File Offset: 0x006D5511
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D52A RID: 54570
		// (get) Token: 0x060329EC RID: 207340 RVA: 0x006D731A File Offset: 0x006D551A
		// (set) Token: 0x060329ED RID: 207341 RVA: 0x006D7322 File Offset: 0x006D5522
		public TMechStuntConfigUnion StuntConfig { get; set; }

		// Token: 0x1700D52B RID: 54571
		// (get) Token: 0x060329EE RID: 207342 RVA: 0x006D732B File Offset: 0x006D552B
		// (set) Token: 0x060329EF RID: 207343 RVA: 0x006D7333 File Offset: 0x006D5533
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700D52C RID: 54572
		// (get) Token: 0x060329F0 RID: 207344 RVA: 0x006D733C File Offset: 0x006D553C
		// (set) Token: 0x060329F1 RID: 207345 RVA: 0x006D7344 File Offset: 0x006D5544
		public bool CanInterrupt { get; set; }

		// Token: 0x1700D52D RID: 54573
		// (get) Token: 0x060329F2 RID: 207346 RVA: 0x006D734D File Offset: 0x006D554D
		// (set) Token: 0x060329F3 RID: 207347 RVA: 0x006D7355 File Offset: 0x006D5555
		public byte NullMask { get; set; }

		// Token: 0x060329F4 RID: 207348 RVA: 0x006D735E File Offset: 0x006D555E
		public IMechStuntT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.StuntConfig = null;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
