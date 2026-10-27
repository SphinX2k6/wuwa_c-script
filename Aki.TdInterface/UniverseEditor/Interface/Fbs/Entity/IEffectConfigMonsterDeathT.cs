using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200478B RID: 18315
	public class IEffectConfigMonsterDeathT
	{
		// Token: 0x1700835D RID: 33629
		// (get) Token: 0x0601C34B RID: 115531 RVA: 0x003FE6D4 File Offset: 0x003FC8D4
		// (set) Token: 0x0601C34C RID: 115532 RVA: 0x003FE6DC File Offset: 0x003FC8DC
		public EEffectConfigType Type { get; set; }

		// Token: 0x1700835E RID: 33630
		// (get) Token: 0x0601C34D RID: 115533 RVA: 0x003FE6E5 File Offset: 0x003FC8E5
		// (set) Token: 0x0601C34E RID: 115534 RVA: 0x003FE6ED File Offset: 0x003FC8ED
		public string ParticleEffect { get; set; }

		// Token: 0x1700835F RID: 33631
		// (get) Token: 0x0601C34F RID: 115535 RVA: 0x003FE6F6 File Offset: 0x003FC8F6
		// (set) Token: 0x0601C350 RID: 115536 RVA: 0x003FE6FE File Offset: 0x003FC8FE
		public string MaterialEffect { get; set; }

		// Token: 0x17008360 RID: 33632
		// (get) Token: 0x0601C351 RID: 115537 RVA: 0x003FE707 File Offset: 0x003FC907
		// (set) Token: 0x0601C352 RID: 115538 RVA: 0x003FE70F File Offset: 0x003FC90F
		public EMonsterDeathEffectEndRule EndRule { get; set; }

		// Token: 0x17008361 RID: 33633
		// (get) Token: 0x0601C353 RID: 115539 RVA: 0x003FE718 File Offset: 0x003FC918
		// (set) Token: 0x0601C354 RID: 115540 RVA: 0x003FE720 File Offset: 0x003FC920
		public byte NullMask { get; set; }

		// Token: 0x0601C355 RID: 115541 RVA: 0x003FE729 File Offset: 0x003FC929
		public IEffectConfigMonsterDeathT()
		{
			this.Type = EEffectConfigType.Death;
			this.ParticleEffect = null;
			this.MaterialEffect = null;
			this.EndRule = EMonsterDeathEffectEndRule.Any;
			this.NullMask = 0;
		}
	}
}
