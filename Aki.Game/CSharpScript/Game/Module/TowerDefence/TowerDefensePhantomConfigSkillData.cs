using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADE RID: 15070
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomConfigSkillData : ITowerDefensePhantomConfigSkillData
	{
		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x06026B5A RID: 158554 RVA: 0x00AD6819 File Offset: 0x00AD4A19
		// (set) Token: 0x06026B5B RID: 158555 RVA: 0x00AD6821 File Offset: 0x00AD4A21
		public string Name { get; set; }

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x06026B5C RID: 158556 RVA: 0x00AD682A File Offset: 0x00AD4A2A
		// (set) Token: 0x06026B5D RID: 158557 RVA: 0x00AD6832 File Offset: 0x00AD4A32
		public string Description { get; set; }

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x06026B5E RID: 158558 RVA: 0x00AD683B File Offset: 0x00AD4A3B
		// (set) Token: 0x06026B5F RID: 158559 RVA: 0x00AD6843 File Offset: 0x00AD4A43
		public string UnlockDescription { get; set; }

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x06026B60 RID: 158560 RVA: 0x00AD684C File Offset: 0x00AD4A4C
		// (set) Token: 0x06026B61 RID: 158561 RVA: 0x00AD6854 File Offset: 0x00AD4A54
		public double? ExpThreshold { get; set; }

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x06026B62 RID: 158562 RVA: 0x00AD685D File Offset: 0x00AD4A5D
		// (set) Token: 0x06026B63 RID: 158563 RVA: 0x00AD6865 File Offset: 0x00AD4A65
		public int PhantomSkill { get; set; }
	}
}
