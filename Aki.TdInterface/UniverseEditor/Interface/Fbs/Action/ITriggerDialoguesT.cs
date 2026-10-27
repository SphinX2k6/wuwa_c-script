using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007479 RID: 29817
	public class ITriggerDialoguesT
	{
		// Token: 0x1700E25F RID: 57951
		// (get) Token: 0x060362FA RID: 221946 RVA: 0x0075E197 File Offset: 0x0075C397
		// (set) Token: 0x060362FB RID: 221947 RVA: 0x0075E19F File Offset: 0x0075C39F
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700E260 RID: 57952
		// (get) Token: 0x060362FC RID: 221948 RVA: 0x0075E1A8 File Offset: 0x0075C3A8
		// (set) Token: 0x060362FD RID: 221949 RVA: 0x0075E1B0 File Offset: 0x0075C3B0
		public float DelayTime { get; set; }

		// Token: 0x1700E261 RID: 57953
		// (get) Token: 0x060362FE RID: 221950 RVA: 0x0075E1B9 File Offset: 0x0075C3B9
		// (set) Token: 0x060362FF RID: 221951 RVA: 0x0075E1C1 File Offset: 0x0075C3C1
		public List<string> Talks { get; set; }

		// Token: 0x1700E262 RID: 57954
		// (get) Token: 0x06036300 RID: 221952 RVA: 0x0075E1CA File Offset: 0x0075C3CA
		// (set) Token: 0x06036301 RID: 221953 RVA: 0x0075E1D2 File Offset: 0x0075C3D2
		public IFocusObjectT FocusObject { get; set; }

		// Token: 0x1700E263 RID: 57955
		// (get) Token: 0x06036302 RID: 221954 RVA: 0x0075E1DB File Offset: 0x0075C3DB
		// (set) Token: 0x06036303 RID: 221955 RVA: 0x0075E1E3 File Offset: 0x0075C3E3
		public byte NullMask { get; set; }

		// Token: 0x06036304 RID: 221956 RVA: 0x0075E1EC File Offset: 0x0075C3EC
		public ITriggerDialoguesT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Talks = null;
			this.FocusObject = null;
			this.NullMask = 0;
		}
	}
}
