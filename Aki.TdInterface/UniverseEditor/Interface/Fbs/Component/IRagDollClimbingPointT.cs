using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D9 RID: 22489
	public class IRagDollClimbingPointT
	{
		// Token: 0x1700A7ED RID: 42989
		// (get) Token: 0x06025C58 RID: 154712 RVA: 0x00535996 File Offset: 0x00533B96
		// (set) Token: 0x06025C59 RID: 154713 RVA: 0x0053599E File Offset: 0x00533B9E
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A7EE RID: 42990
		// (get) Token: 0x06025C5A RID: 154714 RVA: 0x005359A7 File Offset: 0x00533BA7
		// (set) Token: 0x06025C5B RID: 154715 RVA: 0x005359AF File Offset: 0x00533BAF
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A7EF RID: 42991
		// (get) Token: 0x06025C5C RID: 154716 RVA: 0x005359B8 File Offset: 0x00533BB8
		// (set) Token: 0x06025C5D RID: 154717 RVA: 0x005359C0 File Offset: 0x00533BC0
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A7F0 RID: 42992
		// (get) Token: 0x06025C5E RID: 154718 RVA: 0x005359C9 File Offset: 0x00533BC9
		// (set) Token: 0x06025C5F RID: 154719 RVA: 0x005359D1 File Offset: 0x00533BD1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A7F1 RID: 42993
		// (get) Token: 0x06025C60 RID: 154720 RVA: 0x005359DA File Offset: 0x00533BDA
		// (set) Token: 0x06025C61 RID: 154721 RVA: 0x005359E2 File Offset: 0x00533BE2
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A7F2 RID: 42994
		// (get) Token: 0x06025C62 RID: 154722 RVA: 0x005359EB File Offset: 0x00533BEB
		// (set) Token: 0x06025C63 RID: 154723 RVA: 0x005359F3 File Offset: 0x00533BF3
		public bool IsSummitPoint { get; set; }

		// Token: 0x1700A7F3 RID: 42995
		// (get) Token: 0x06025C64 RID: 154724 RVA: 0x005359FC File Offset: 0x00533BFC
		// (set) Token: 0x06025C65 RID: 154725 RVA: 0x00535A04 File Offset: 0x00533C04
		public byte NullMask { get; set; }

		// Token: 0x06025C66 RID: 154726 RVA: 0x00535A0D File Offset: 0x00533C0D
		public IRagDollClimbingPointT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.IsSummitPoint = false;
			this.NullMask = 0;
		}
	}
}
