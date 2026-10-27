using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3A RID: 15930
	public class IFinishJellyfishReturnConditionT
	{
		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x06016573 RID: 91507 RVA: 0x00339AD4 File Offset: 0x00337CD4
		// (set) Token: 0x06016574 RID: 91508 RVA: 0x00339ADC File Offset: 0x00337CDC
		public EChildQuest Type { get; set; }

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x06016575 RID: 91509 RVA: 0x00339AE5 File Offset: 0x00337CE5
		// (set) Token: 0x06016576 RID: 91510 RVA: 0x00339AED File Offset: 0x00337CED
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x06016577 RID: 91511 RVA: 0x00339AF6 File Offset: 0x00337CF6
		// (set) Token: 0x06016578 RID: 91512 RVA: 0x00339AFE File Offset: 0x00337CFE
		public int StartPosEntityId { get; set; }

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x06016579 RID: 91513 RVA: 0x00339B07 File Offset: 0x00337D07
		// (set) Token: 0x0601657A RID: 91514 RVA: 0x00339B0F File Offset: 0x00337D0F
		public float StartRadius { get; set; }

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x0601657B RID: 91515 RVA: 0x00339B18 File Offset: 0x00337D18
		// (set) Token: 0x0601657C RID: 91516 RVA: 0x00339B20 File Offset: 0x00337D20
		public int EndPosEntityId { get; set; }

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x0601657D RID: 91517 RVA: 0x00339B29 File Offset: 0x00337D29
		// (set) Token: 0x0601657E RID: 91518 RVA: 0x00339B31 File Offset: 0x00337D31
		public float EndRadius { get; set; }

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x0601657F RID: 91519 RVA: 0x00339B3A File Offset: 0x00337D3A
		// (set) Token: 0x06016580 RID: 91520 RVA: 0x00339B42 File Offset: 0x00337D42
		public string LevelConfigDa { get; set; }

		// Token: 0x17006E38 RID: 28216
		// (get) Token: 0x06016581 RID: 91521 RVA: 0x00339B4B File Offset: 0x00337D4B
		// (set) Token: 0x06016582 RID: 91522 RVA: 0x00339B53 File Offset: 0x00337D53
		public string EffectDa { get; set; }

		// Token: 0x06016583 RID: 91523 RVA: 0x00339B5C File Offset: 0x00337D5C
		public IFinishJellyfishReturnConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.StartPosEntityId = 0;
			this.StartRadius = 0f;
			this.EndPosEntityId = 0;
			this.EndRadius = 0f;
			this.LevelConfigDa = null;
			this.EffectDa = null;
		}
	}
}
