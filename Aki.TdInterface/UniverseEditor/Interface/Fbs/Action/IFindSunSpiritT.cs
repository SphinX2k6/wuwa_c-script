using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1F RID: 28191
	public class IFindSunSpiritT
	{
		// Token: 0x1700CEA4 RID: 52900
		// (get) Token: 0x06030AEE RID: 199406 RVA: 0x0069BBEF File Offset: 0x00699DEF
		// (set) Token: 0x06030AEF RID: 199407 RVA: 0x0069BBF7 File Offset: 0x00699DF7
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CEA5 RID: 52901
		// (get) Token: 0x06030AF0 RID: 199408 RVA: 0x0069BC00 File Offset: 0x00699E00
		// (set) Token: 0x06030AF1 RID: 199409 RVA: 0x0069BC08 File Offset: 0x00699E08
		public int Id { get; set; }

		// Token: 0x1700CEA6 RID: 52902
		// (get) Token: 0x06030AF2 RID: 199410 RVA: 0x0069BC11 File Offset: 0x00699E11
		// (set) Token: 0x06030AF3 RID: 199411 RVA: 0x0069BC19 File Offset: 0x00699E19
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CEA7 RID: 52903
		// (get) Token: 0x06030AF4 RID: 199412 RVA: 0x0069BC22 File Offset: 0x00699E22
		// (set) Token: 0x06030AF5 RID: 199413 RVA: 0x0069BC2A File Offset: 0x00699E2A
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700CEA8 RID: 52904
		// (get) Token: 0x06030AF6 RID: 199414 RVA: 0x0069BC33 File Offset: 0x00699E33
		// (set) Token: 0x06030AF7 RID: 199415 RVA: 0x0069BC3B File Offset: 0x00699E3B
		public List<int> SunSpiritEntityIds { get; set; }

		// Token: 0x1700CEA9 RID: 52905
		// (get) Token: 0x06030AF8 RID: 199416 RVA: 0x0069BC44 File Offset: 0x00699E44
		// (set) Token: 0x06030AF9 RID: 199417 RVA: 0x0069BC4C File Offset: 0x00699E4C
		public List<int> TargetLocationIds { get; set; }

		// Token: 0x1700CEAA RID: 52906
		// (get) Token: 0x06030AFA RID: 199418 RVA: 0x0069BC55 File Offset: 0x00699E55
		// (set) Token: 0x06030AFB RID: 199419 RVA: 0x0069BC5D File Offset: 0x00699E5D
		public ISunSpiritDifficultyReductionT DifficultyReductionConfig { get; set; }

		// Token: 0x06030AFC RID: 199420 RVA: 0x0069BC66 File Offset: 0x00699E66
		public IFindSunSpiritT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
			this.Pos = null;
			this.Direction = null;
			this.SunSpiritEntityIds = null;
			this.TargetLocationIds = null;
			this.DifficultyReductionConfig = null;
		}
	}
}
