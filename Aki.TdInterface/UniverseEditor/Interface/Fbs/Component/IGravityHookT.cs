using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532B RID: 21291
	public class IGravityHookT
	{
		// Token: 0x17009C5F RID: 40031
		// (get) Token: 0x06022CE0 RID: 142560 RVA: 0x004D2A39 File Offset: 0x004D0C39
		// (set) Token: 0x06022CE1 RID: 142561 RVA: 0x004D2A41 File Offset: 0x004D0C41
		public EHookInteractType Type { get; set; }

		// Token: 0x17009C60 RID: 40032
		// (get) Token: 0x06022CE2 RID: 142562 RVA: 0x004D2A4A File Offset: 0x004D0C4A
		// (set) Token: 0x06022CE3 RID: 142563 RVA: 0x004D2A52 File Offset: 0x004D0C52
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009C61 RID: 40033
		// (get) Token: 0x06022CE4 RID: 142564 RVA: 0x004D2A5B File Offset: 0x004D0C5B
		// (set) Token: 0x06022CE5 RID: 142565 RVA: 0x004D2A63 File Offset: 0x004D0C63
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009C62 RID: 40034
		// (get) Token: 0x06022CE6 RID: 142566 RVA: 0x004D2A6C File Offset: 0x004D0C6C
		// (set) Token: 0x06022CE7 RID: 142567 RVA: 0x004D2A74 File Offset: 0x004D0C74
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009C63 RID: 40035
		// (get) Token: 0x06022CE8 RID: 142568 RVA: 0x004D2A7D File Offset: 0x004D0C7D
		// (set) Token: 0x06022CE9 RID: 142569 RVA: 0x004D2A85 File Offset: 0x004D0C85
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009C64 RID: 40036
		// (get) Token: 0x06022CEA RID: 142570 RVA: 0x004D2A8E File Offset: 0x004D0C8E
		// (set) Token: 0x06022CEB RID: 142571 RVA: 0x004D2A96 File Offset: 0x004D0C96
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17009C65 RID: 40037
		// (get) Token: 0x06022CEC RID: 142572 RVA: 0x004D2A9F File Offset: 0x004D0C9F
		// (set) Token: 0x06022CED RID: 142573 RVA: 0x004D2AA7 File Offset: 0x004D0CA7
		public int SafePointId { get; set; }

		// Token: 0x17009C66 RID: 40038
		// (get) Token: 0x06022CEE RID: 142574 RVA: 0x004D2AB0 File Offset: 0x004D0CB0
		// (set) Token: 0x06022CEF RID: 142575 RVA: 0x004D2AB8 File Offset: 0x004D0CB8
		public int CameraLookAtPointId { get; set; }

		// Token: 0x17009C67 RID: 40039
		// (get) Token: 0x06022CF0 RID: 142576 RVA: 0x004D2AC1 File Offset: 0x004D0CC1
		// (set) Token: 0x06022CF1 RID: 142577 RVA: 0x004D2AC9 File Offset: 0x004D0CC9
		public byte NullMask { get; set; }

		// Token: 0x06022CF2 RID: 142578 RVA: 0x004D2AD4 File Offset: 0x004D0CD4
		public IGravityHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.GravityDirection = null;
			this.SafePointId = 0;
			this.CameraLookAtPointId = 0;
			this.NullMask = 0;
		}
	}
}
