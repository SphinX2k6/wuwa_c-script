using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C0B RID: 19467
	public class SkillButtonTypeFormationData
	{
		// Token: 0x06032619 RID: 206361 RVA: 0x00BBA874 File Offset: 0x00BB8A74
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

		// Token: 0x0401ACF1 RID: 109809
		[Nullable(2)]
		public string SkillIconPath;

		// Token: 0x0401ACF2 RID: 109810
		public int EnableSkillId;

		// Token: 0x0401ACF3 RID: 109811
		public bool IsLongPressControlCamera;

		// Token: 0x0401ACF4 RID: 109812
		public int LongPressTime;

		// Token: 0x0401ACF5 RID: 109813
		public bool IgnoreHiddenTag;

		// Token: 0x0401ACF6 RID: 109814
		public bool IgnoreDefaultHidden;

		// Token: 0x0401ACF7 RID: 109815
		public ESkillButtonExtraEffect ExtraEffect;

		// Token: 0x0401ACF8 RID: 109816
		public float ExtraEffectDuration;
	}
}
