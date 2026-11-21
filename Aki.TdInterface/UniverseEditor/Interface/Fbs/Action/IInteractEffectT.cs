using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007035 RID: 28725
	public class IInteractEffectT
	{
		// Token: 0x1700D256 RID: 53846
		// (get) Token: 0x06031C96 RID: 203926 RVA: 0x006BD606 File Offset: 0x006BB806
		// (set) Token: 0x06031C97 RID: 203927 RVA: 0x006BD60E File Offset: 0x006BB80E
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700D257 RID: 53847
		// (get) Token: 0x06031C98 RID: 203928 RVA: 0x006BD617 File Offset: 0x006BB817
		// (set) Token: 0x06031C99 RID: 203929 RVA: 0x006BD61F File Offset: 0x006BB81F
		public float DelayTime { get; set; }

		// Token: 0x1700D258 RID: 53848
		// (get) Token: 0x06031C9A RID: 203930 RVA: 0x006BD628 File Offset: 0x006BB828
		// (set) Token: 0x06031C9B RID: 203931 RVA: 0x006BD630 File Offset: 0x006BB830
		public byte NullMask { get; set; }

		// Token: 0x06031C9C RID: 203932 RVA: 0x006BD639 File Offset: 0x006BB839
		public IInteractEffectT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
