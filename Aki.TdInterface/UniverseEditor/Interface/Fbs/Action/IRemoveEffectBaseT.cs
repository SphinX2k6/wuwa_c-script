using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E47 RID: 28231
	public class IRemoveEffectBaseT
	{
		// Token: 0x1700D258 RID: 53848
		// (get) Token: 0x06031E3A RID: 204346 RVA: 0x006C0433 File Offset: 0x006BE633
		// (set) Token: 0x06031E3B RID: 204347 RVA: 0x006C043B File Offset: 0x006BE63B
		public EEffectType Type { get; set; }

		// Token: 0x1700D259 RID: 53849
		// (get) Token: 0x06031E3C RID: 204348 RVA: 0x006C0444 File Offset: 0x006BE644
		// (set) Token: 0x06031E3D RID: 204349 RVA: 0x006C044C File Offset: 0x006BE64C
		public string Path { get; set; }

		// Token: 0x06031E3E RID: 204350 RVA: 0x006C0455 File Offset: 0x006BE655
		public IRemoveEffectBaseT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
