using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B50 RID: 23376
	public class IMotorEjectHookT
	{
		// Token: 0x1700AA96 RID: 43670
		// (get) Token: 0x06026752 RID: 157522 RVA: 0x00544489 File Offset: 0x00542689
		// (set) Token: 0x06026753 RID: 157523 RVA: 0x00544491 File Offset: 0x00542691
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AA97 RID: 43671
		// (get) Token: 0x06026754 RID: 157524 RVA: 0x0054449A File Offset: 0x0054269A
		// (set) Token: 0x06026755 RID: 157525 RVA: 0x005444A2 File Offset: 0x005426A2
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AA98 RID: 43672
		// (get) Token: 0x06026756 RID: 157526 RVA: 0x005444AB File Offset: 0x005426AB
		// (set) Token: 0x06026757 RID: 157527 RVA: 0x005444B3 File Offset: 0x005426B3
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AA99 RID: 43673
		// (get) Token: 0x06026758 RID: 157528 RVA: 0x005444BC File Offset: 0x005426BC
		// (set) Token: 0x06026759 RID: 157529 RVA: 0x005444C4 File Offset: 0x005426C4
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AA9A RID: 43674
		// (get) Token: 0x0602675A RID: 157530 RVA: 0x005444CD File Offset: 0x005426CD
		// (set) Token: 0x0602675B RID: 157531 RVA: 0x005444D5 File Offset: 0x005426D5
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AA9B RID: 43675
		// (get) Token: 0x0602675C RID: 157532 RVA: 0x005444DE File Offset: 0x005426DE
		// (set) Token: 0x0602675D RID: 157533 RVA: 0x005444E6 File Offset: 0x005426E6
		public float MinPitchAngle { get; set; }

		// Token: 0x1700AA9C RID: 43676
		// (get) Token: 0x0602675E RID: 157534 RVA: 0x005444EF File Offset: 0x005426EF
		// (set) Token: 0x0602675F RID: 157535 RVA: 0x005444F7 File Offset: 0x005426F7
		public float DefaultPitchAngle { get; set; }

		// Token: 0x1700AA9D RID: 43677
		// (get) Token: 0x06026760 RID: 157536 RVA: 0x00544500 File Offset: 0x00542700
		// (set) Token: 0x06026761 RID: 157537 RVA: 0x00544508 File Offset: 0x00542708
		public float MaxPitchAngle { get; set; }

		// Token: 0x1700AA9E RID: 43678
		// (get) Token: 0x06026762 RID: 157538 RVA: 0x00544511 File Offset: 0x00542711
		// (set) Token: 0x06026763 RID: 157539 RVA: 0x00544519 File Offset: 0x00542719
		public float MaxYawAngleDelta { get; set; }

		// Token: 0x1700AA9F RID: 43679
		// (get) Token: 0x06026764 RID: 157540 RVA: 0x00544522 File Offset: 0x00542722
		// (set) Token: 0x06026765 RID: 157541 RVA: 0x0054452A File Offset: 0x0054272A
		public float MaxEjectDistance { get; set; }

		// Token: 0x1700AAA0 RID: 43680
		// (get) Token: 0x06026766 RID: 157542 RVA: 0x00544533 File Offset: 0x00542733
		// (set) Token: 0x06026767 RID: 157543 RVA: 0x0054453B File Offset: 0x0054273B
		public float InterpSpeed { get; set; }

		// Token: 0x1700AAA1 RID: 43681
		// (get) Token: 0x06026768 RID: 157544 RVA: 0x00544544 File Offset: 0x00542744
		// (set) Token: 0x06026769 RID: 157545 RVA: 0x0054454C File Offset: 0x0054274C
		public TMotorAutoEjectConfigUnion AutoEjectConfig { get; set; }

		// Token: 0x1700AAA2 RID: 43682
		// (get) Token: 0x0602676A RID: 157546 RVA: 0x00544555 File Offset: 0x00542755
		// (set) Token: 0x0602676B RID: 157547 RVA: 0x0054455D File Offset: 0x0054275D
		public byte NullMask { get; set; }

		// Token: 0x0602676C RID: 157548 RVA: 0x00544568 File Offset: 0x00542768
		public IMotorEjectHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.MinPitchAngle = 0f;
			this.DefaultPitchAngle = 0f;
			this.MaxPitchAngle = 0f;
			this.MaxYawAngleDelta = 0f;
			this.MaxEjectDistance = 0f;
			this.InterpSpeed = 0f;
			this.AutoEjectConfig = null;
			this.NullMask = 0;
		}
	}
}
