using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725A RID: 29274
	public class ISwitchEffectStateT
	{
		// Token: 0x1700D937 RID: 55607
		// (get) Token: 0x06033EEA RID: 212714 RVA: 0x006FC2D7 File Offset: 0x006FA4D7
		// (set) Token: 0x06033EEB RID: 212715 RVA: 0x006FC2DF File Offset: 0x006FA4DF
		public EEffectType Type { get; set; }

		// Token: 0x1700D938 RID: 55608
		// (get) Token: 0x06033EEC RID: 212716 RVA: 0x006FC2E8 File Offset: 0x006FA4E8
		// (set) Token: 0x06033EED RID: 212717 RVA: 0x006FC2F0 File Offset: 0x006FA4F0
		public string Path { get; set; }

		// Token: 0x1700D939 RID: 55609
		// (get) Token: 0x06033EEE RID: 212718 RVA: 0x006FC2F9 File Offset: 0x006FA4F9
		// (set) Token: 0x06033EEF RID: 212719 RVA: 0x006FC301 File Offset: 0x006FA501
		public TSwitchEffectStateEffectTypeUnion EffectType { get; set; }

		// Token: 0x1700D93A RID: 55610
		// (get) Token: 0x06033EF0 RID: 212720 RVA: 0x006FC30A File Offset: 0x006FA50A
		// (set) Token: 0x06033EF1 RID: 212721 RVA: 0x006FC312 File Offset: 0x006FA512
		public int TargetStateIndex { get; set; }

		// Token: 0x06033EF2 RID: 212722 RVA: 0x006FC31B File Offset: 0x006FA51B
		public ISwitchEffectStateT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.EffectType = null;
			this.TargetStateIndex = 0;
		}
	}
}
