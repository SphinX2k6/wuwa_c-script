using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720E RID: 29198
	public class IModifyTipTextT
	{
		// Token: 0x1700D5B7 RID: 54711
		// (get) Token: 0x06032CE0 RID: 208096 RVA: 0x006DC817 File Offset: 0x006DAA17
		// (set) Token: 0x06032CE1 RID: 208097 RVA: 0x006DC81F File Offset: 0x006DAA1F
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700D5B8 RID: 54712
		// (get) Token: 0x06032CE2 RID: 208098 RVA: 0x006DC828 File Offset: 0x006DAA28
		// (set) Token: 0x06032CE3 RID: 208099 RVA: 0x006DC830 File Offset: 0x006DAA30
		public float DelayTime { get; set; }

		// Token: 0x1700D5B9 RID: 54713
		// (get) Token: 0x06032CE4 RID: 208100 RVA: 0x006DC839 File Offset: 0x006DAA39
		// (set) Token: 0x06032CE5 RID: 208101 RVA: 0x006DC841 File Offset: 0x006DAA41
		public string TipText { get; set; }

		// Token: 0x1700D5BA RID: 54714
		// (get) Token: 0x06032CE6 RID: 208102 RVA: 0x006DC84A File Offset: 0x006DAA4A
		// (set) Token: 0x06032CE7 RID: 208103 RVA: 0x006DC852 File Offset: 0x006DAA52
		public byte NullMask { get; set; }

		// Token: 0x06032CE8 RID: 208104 RVA: 0x006DC85B File Offset: 0x006DAA5B
		public IModifyTipTextT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.TipText = null;
			this.NullMask = 0;
		}
	}
}
