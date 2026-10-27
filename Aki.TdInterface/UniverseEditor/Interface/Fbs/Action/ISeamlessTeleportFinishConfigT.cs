using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4F RID: 28495
	public class ISeamlessTeleportFinishConfigT
	{
		// Token: 0x1700D3BD RID: 54205
		// (get) Token: 0x0603257B RID: 206203 RVA: 0x006CC3BA File Offset: 0x006CA5BA
		// (set) Token: 0x0603257C RID: 206204 RVA: 0x006CC3C2 File Offset: 0x006CA5C2
		public bool IsNotStopScreenEffect { get; set; }

		// Token: 0x1700D3BE RID: 54206
		// (get) Token: 0x0603257D RID: 206205 RVA: 0x006CC3CB File Offset: 0x006CA5CB
		// (set) Token: 0x0603257E RID: 206206 RVA: 0x006CC3D3 File Offset: 0x006CA5D3
		public int EffectExtraState { get; set; }

		// Token: 0x1700D3BF RID: 54207
		// (get) Token: 0x0603257F RID: 206207 RVA: 0x006CC3DC File Offset: 0x006CA5DC
		// (set) Token: 0x06032580 RID: 206208 RVA: 0x006CC3E4 File Offset: 0x006CA5E4
		public byte NullMask { get; set; }

		// Token: 0x06032581 RID: 206209 RVA: 0x006CC3ED File Offset: 0x006CA5ED
		public ISeamlessTeleportFinishConfigT()
		{
			this.IsNotStopScreenEffect = false;
			this.EffectExtraState = 0;
			this.NullMask = 0;
		}
	}
}
