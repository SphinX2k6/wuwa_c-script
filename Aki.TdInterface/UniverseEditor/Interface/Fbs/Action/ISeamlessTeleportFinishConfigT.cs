using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007709 RID: 30473
	public class ISeamlessTeleportFinishConfigT
	{
		// Token: 0x1700DF7C RID: 57212
		// (get) Token: 0x0603577B RID: 219003 RVA: 0x0072B676 File Offset: 0x00729876
		// (set) Token: 0x0603577C RID: 219004 RVA: 0x0072B67E File Offset: 0x0072987E
		public bool IsNotStopScreenEffect { get; set; }

		// Token: 0x1700DF7D RID: 57213
		// (get) Token: 0x0603577D RID: 219005 RVA: 0x0072B687 File Offset: 0x00729887
		// (set) Token: 0x0603577E RID: 219006 RVA: 0x0072B68F File Offset: 0x0072988F
		public int EffectExtraState { get; set; }

		// Token: 0x1700DF7E RID: 57214
		// (get) Token: 0x0603577F RID: 219007 RVA: 0x0072B698 File Offset: 0x00729898
		// (set) Token: 0x06035780 RID: 219008 RVA: 0x0072B6A0 File Offset: 0x007298A0
		public byte NullMask { get; set; }

		// Token: 0x06035781 RID: 219009 RVA: 0x0072B6A9 File Offset: 0x007298A9
		public ISeamlessTeleportFinishConfigT()
		{
			this.IsNotStopScreenEffect = false;
			this.EffectExtraState = 0;
			this.NullMask = 0;
		}
	}
}
