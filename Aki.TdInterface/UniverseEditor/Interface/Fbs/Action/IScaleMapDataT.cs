using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F19 RID: 28441
	public class IScaleMapDataT
	{
		// Token: 0x1700D372 RID: 54130
		// (get) Token: 0x06032405 RID: 205829 RVA: 0x006C9DC7 File Offset: 0x006C7FC7
		// (set) Token: 0x06032406 RID: 205830 RVA: 0x006C9DCF File Offset: 0x006C7FCF
		public string Key { get; set; }

		// Token: 0x1700D373 RID: 54131
		// (get) Token: 0x06032407 RID: 205831 RVA: 0x006C9DD8 File Offset: 0x006C7FD8
		// (set) Token: 0x06032408 RID: 205832 RVA: 0x006C9DE0 File Offset: 0x006C7FE0
		public float Scale { get; set; }

		// Token: 0x06032409 RID: 205833 RVA: 0x006C9DE9 File Offset: 0x006C7FE9
		public IScaleMapDataT()
		{
			this.Key = null;
			this.Scale = 0f;
		}
	}
}
