using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9D RID: 28573
	public class ISetAnimSequenceBlendAnimTypeT
	{
		// Token: 0x1700D435 RID: 54325
		// (get) Token: 0x060327F9 RID: 206841 RVA: 0x006D0E4F File Offset: 0x006CF04F
		// (set) Token: 0x060327FA RID: 206842 RVA: 0x006D0E57 File Offset: 0x006CF057
		public EBlendAnimType Type { get; set; }

		// Token: 0x1700D436 RID: 54326
		// (get) Token: 0x060327FB RID: 206843 RVA: 0x006D0E60 File Offset: 0x006CF060
		// (set) Token: 0x060327FC RID: 206844 RVA: 0x006D0E68 File Offset: 0x006CF068
		public string AnimSequence { get; set; }

		// Token: 0x1700D437 RID: 54327
		// (get) Token: 0x060327FD RID: 206845 RVA: 0x006D0E71 File Offset: 0x006CF071
		// (set) Token: 0x060327FE RID: 206846 RVA: 0x006D0E79 File Offset: 0x006CF079
		public float ProtectTime { get; set; }

		// Token: 0x1700D438 RID: 54328
		// (get) Token: 0x060327FF RID: 206847 RVA: 0x006D0E82 File Offset: 0x006CF082
		// (set) Token: 0x06032800 RID: 206848 RVA: 0x006D0E8A File Offset: 0x006CF08A
		public byte NullMask { get; set; }

		// Token: 0x06032801 RID: 206849 RVA: 0x006D0E93 File Offset: 0x006CF093
		public ISetAnimSequenceBlendAnimTypeT()
		{
			this.Type = EBlendAnimType.StateMachine;
			this.AnimSequence = null;
			this.ProtectTime = 0f;
			this.NullMask = 0;
		}
	}
}
