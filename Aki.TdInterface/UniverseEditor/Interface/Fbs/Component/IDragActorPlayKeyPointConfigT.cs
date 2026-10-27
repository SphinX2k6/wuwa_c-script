using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050BB RID: 20667
	public class IDragActorPlayKeyPointConfigT
	{
		// Token: 0x1700965A RID: 38490
		// (get) Token: 0x060213BF RID: 136127 RVA: 0x0049E292 File Offset: 0x0049C492
		// (set) Token: 0x060213C0 RID: 136128 RVA: 0x0049E29A File Offset: 0x0049C49A
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700965B RID: 38491
		// (get) Token: 0x060213C1 RID: 136129 RVA: 0x0049E2A3 File Offset: 0x0049C4A3
		// (set) Token: 0x060213C2 RID: 136130 RVA: 0x0049E2AB File Offset: 0x0049C4AB
		public float Radius { get; set; }

		// Token: 0x1700965C RID: 38492
		// (get) Token: 0x060213C3 RID: 136131 RVA: 0x0049E2B4 File Offset: 0x0049C4B4
		// (set) Token: 0x060213C4 RID: 136132 RVA: 0x0049E2BC File Offset: 0x0049C4BC
		public bool IsSnapping { get; set; }

		// Token: 0x1700965D RID: 38493
		// (get) Token: 0x060213C5 RID: 136133 RVA: 0x0049E2C5 File Offset: 0x0049C4C5
		// (set) Token: 0x060213C6 RID: 136134 RVA: 0x0049E2CD File Offset: 0x0049C4CD
		public float SnapTime { get; set; }

		// Token: 0x1700965E RID: 38494
		// (get) Token: 0x060213C7 RID: 136135 RVA: 0x0049E2D6 File Offset: 0x0049C4D6
		// (set) Token: 0x060213C8 RID: 136136 RVA: 0x0049E2DE File Offset: 0x0049C4DE
		public string EnterSendSelfEvent { get; set; }

		// Token: 0x1700965F RID: 38495
		// (get) Token: 0x060213C9 RID: 136137 RVA: 0x0049E2E7 File Offset: 0x0049C4E7
		// (set) Token: 0x060213CA RID: 136138 RVA: 0x0049E2EF File Offset: 0x0049C4EF
		public string ExitSendSelfEvent { get; set; }

		// Token: 0x17009660 RID: 38496
		// (get) Token: 0x060213CB RID: 136139 RVA: 0x0049E2F8 File Offset: 0x0049C4F8
		// (set) Token: 0x060213CC RID: 136140 RVA: 0x0049E300 File Offset: 0x0049C500
		public string ReleaseSendSelfEvent { get; set; }

		// Token: 0x17009661 RID: 38497
		// (get) Token: 0x060213CD RID: 136141 RVA: 0x0049E309 File Offset: 0x0049C509
		// (set) Token: 0x060213CE RID: 136142 RVA: 0x0049E311 File Offset: 0x0049C511
		public List<IActionInfoT> ReleaseClientActions { get; set; }

		// Token: 0x17009662 RID: 38498
		// (get) Token: 0x060213CF RID: 136143 RVA: 0x0049E31A File Offset: 0x0049C51A
		// (set) Token: 0x060213D0 RID: 136144 RVA: 0x0049E322 File Offset: 0x0049C522
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009663 RID: 38499
		// (get) Token: 0x060213D1 RID: 136145 RVA: 0x0049E32B File Offset: 0x0049C52B
		// (set) Token: 0x060213D2 RID: 136146 RVA: 0x0049E333 File Offset: 0x0049C533
		public byte NullMask { get; set; }

		// Token: 0x060213D3 RID: 136147 RVA: 0x0049E33C File Offset: 0x0049C53C
		public IDragActorPlayKeyPointConfigT()
		{
			this.Position = null;
			this.Radius = 0f;
			this.IsSnapping = false;
			this.SnapTime = 0f;
			this.EnterSendSelfEvent = null;
			this.ExitSendSelfEvent = null;
			this.ReleaseSendSelfEvent = null;
			this.ReleaseClientActions = null;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
