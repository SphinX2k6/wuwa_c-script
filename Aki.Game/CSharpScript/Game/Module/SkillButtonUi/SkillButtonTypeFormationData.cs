using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BBC RID: 15292
	public class SkillButtonTypeFormationData
	{
		// Token: 0x060273C9 RID: 160713 RVA: 0x00AFF3F8 File Offset: 0x00AFD5F8
		public void Clear()
		{
			this.SkillIconPath = null;
			this.EnableSkillId = 0;
			this.IsLongPressControlCamera = false;
			this.LongPressTime = 0;
			this.IgnoreHiddenTag = false;
			this.IgnoreDefaultHidden = false;
			this.ExtraEffect = ESkillButtonExtraEffect.None;
			this.ExtraEffectDuration = 0f;
		}

		// Token: 0x0401564D RID: 87629
		[Nullable(2)]
		public string SkillIconPath;

		// Token: 0x0401564E RID: 87630
		public int EnableSkillId;

		// Token: 0x0401564F RID: 87631
		public bool IsLongPressControlCamera;

		// Token: 0x04015650 RID: 87632
		public int LongPressTime;

		// Token: 0x04015651 RID: 87633
		public bool IgnoreHiddenTag;

		// Token: 0x04015652 RID: 87634
		public bool IgnoreDefaultHidden;

		// Token: 0x04015653 RID: 87635
		public ESkillButtonExtraEffect ExtraEffect;

		// Token: 0x04015654 RID: 87636
		public float ExtraEffectDuration;
	}
}
