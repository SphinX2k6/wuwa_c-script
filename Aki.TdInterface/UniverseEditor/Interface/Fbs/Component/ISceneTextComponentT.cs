using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DA RID: 22746
	public class ISceneTextComponentT
	{
		// Token: 0x1700AA5D RID: 43613
		// (get) Token: 0x06026674 RID: 157300 RVA: 0x0054AE7E File Offset: 0x0054907E
		// (set) Token: 0x06026675 RID: 157301 RVA: 0x0054AE86 File Offset: 0x00549086
		public bool Disabled { get; set; }

		// Token: 0x1700AA5E RID: 43614
		// (get) Token: 0x06026676 RID: 157302 RVA: 0x0054AE8F File Offset: 0x0054908F
		// (set) Token: 0x06026677 RID: 157303 RVA: 0x0054AE97 File Offset: 0x00549097
		public string DisplayState { get; set; }

		// Token: 0x1700AA5F RID: 43615
		// (get) Token: 0x06026678 RID: 157304 RVA: 0x0054AEA0 File Offset: 0x005490A0
		// (set) Token: 0x06026679 RID: 157305 RVA: 0x0054AEA8 File Offset: 0x005490A8
		public IPosAndRotT RelativeTransform { get; set; }

		// Token: 0x1700AA60 RID: 43616
		// (get) Token: 0x0602667A RID: 157306 RVA: 0x0054AEB1 File Offset: 0x005490B1
		// (set) Token: 0x0602667B RID: 157307 RVA: 0x0054AEB9 File Offset: 0x005490B9
		public TSceneTextUnion TextConfig { get; set; }

		// Token: 0x1700AA61 RID: 43617
		// (get) Token: 0x0602667C RID: 157308 RVA: 0x0054AEC2 File Offset: 0x005490C2
		// (set) Token: 0x0602667D RID: 157309 RVA: 0x0054AECA File Offset: 0x005490CA
		public byte NullMask { get; set; }

		// Token: 0x0602667E RID: 157310 RVA: 0x0054AED3 File Offset: 0x005490D3
		public ISceneTextComponentT()
		{
			this.Disabled = false;
			this.DisplayState = null;
			this.RelativeTransform = null;
			this.TextConfig = null;
			this.NullMask = 0;
		}
	}
}
