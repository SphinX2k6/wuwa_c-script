using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428A RID: 17034
	public class IFinishTetrisT
	{
		// Token: 0x17007473 RID: 29811
		// (get) Token: 0x06017D28 RID: 97576 RVA: 0x00367251 File Offset: 0x00365451
		// (set) Token: 0x06017D29 RID: 97577 RVA: 0x00367259 File Offset: 0x00365459
		public EChildQuest Type { get; set; }

		// Token: 0x17007474 RID: 29812
		// (get) Token: 0x06017D2A RID: 97578 RVA: 0x00367262 File Offset: 0x00365462
		// (set) Token: 0x06017D2B RID: 97579 RVA: 0x0036726A File Offset: 0x0036546A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007475 RID: 29813
		// (get) Token: 0x06017D2C RID: 97580 RVA: 0x00367273 File Offset: 0x00365473
		// (set) Token: 0x06017D2D RID: 97581 RVA: 0x0036727B File Offset: 0x0036547B
		public int OriginPosEntityId { get; set; }

		// Token: 0x17007476 RID: 29814
		// (get) Token: 0x06017D2E RID: 97582 RVA: 0x00367284 File Offset: 0x00365484
		// (set) Token: 0x06017D2F RID: 97583 RVA: 0x0036728C File Offset: 0x0036548C
		public TTetrisPlayModeUnion PlayMode { get; set; }

		// Token: 0x17007477 RID: 29815
		// (get) Token: 0x06017D30 RID: 97584 RVA: 0x00367295 File Offset: 0x00365495
		// (set) Token: 0x06017D31 RID: 97585 RVA: 0x0036729D File Offset: 0x0036549D
		public ETetrisDirection Direction { get; set; }

		// Token: 0x17007478 RID: 29816
		// (get) Token: 0x06017D32 RID: 97586 RVA: 0x003672A6 File Offset: 0x003654A6
		// (set) Token: 0x06017D33 RID: 97587 RVA: 0x003672AE File Offset: 0x003654AE
		public float PrepareTime { get; set; }

		// Token: 0x17007479 RID: 29817
		// (get) Token: 0x06017D34 RID: 97588 RVA: 0x003672B7 File Offset: 0x003654B7
		// (set) Token: 0x06017D35 RID: 97589 RVA: 0x003672BF File Offset: 0x003654BF
		public float FallSpeed { get; set; }

		// Token: 0x1700747A RID: 29818
		// (get) Token: 0x06017D36 RID: 97590 RVA: 0x003672C8 File Offset: 0x003654C8
		// (set) Token: 0x06017D37 RID: 97591 RVA: 0x003672D0 File Offset: 0x003654D0
		public ITetrisIndexedBoardT PresetBlocks { get; set; }

		// Token: 0x1700747B RID: 29819
		// (get) Token: 0x06017D38 RID: 97592 RVA: 0x003672D9 File Offset: 0x003654D9
		// (set) Token: 0x06017D39 RID: 97593 RVA: 0x003672E1 File Offset: 0x003654E1
		public List<string> AvailableCombineBlocks { get; set; }

		// Token: 0x1700747C RID: 29820
		// (get) Token: 0x06017D3A RID: 97594 RVA: 0x003672EA File Offset: 0x003654EA
		// (set) Token: 0x06017D3B RID: 97595 RVA: 0x003672F2 File Offset: 0x003654F2
		public TVarRefUnion IsSuccessVar { get; set; }

		// Token: 0x1700747D RID: 29821
		// (get) Token: 0x06017D3C RID: 97596 RVA: 0x003672FB File Offset: 0x003654FB
		// (set) Token: 0x06017D3D RID: 97597 RVA: 0x00367303 File Offset: 0x00365503
		public TVarRefUnion IsInitializedVar { get; set; }

		// Token: 0x1700747E RID: 29822
		// (get) Token: 0x06017D3E RID: 97598 RVA: 0x0036730C File Offset: 0x0036550C
		// (set) Token: 0x06017D3F RID: 97599 RVA: 0x00367314 File Offset: 0x00365514
		public byte NullMask { get; set; }

		// Token: 0x06017D40 RID: 97600 RVA: 0x00367320 File Offset: 0x00365520
		public IFinishTetrisT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.OriginPosEntityId = 0;
			this.PlayMode = null;
			this.Direction = ETetrisDirection.UpDown;
			this.PrepareTime = 0f;
			this.FallSpeed = 0f;
			this.PresetBlocks = null;
			this.AvailableCombineBlocks = null;
			this.IsSuccessVar = null;
			this.IsInitializedVar = null;
			this.NullMask = 0;
		}
	}
}
