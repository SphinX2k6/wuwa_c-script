using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005494 RID: 21652
	[NullableContext(2)]
	[Nullable(0)]
	public struct SkillTipEvent
	{
		// Token: 0x06035B6C RID: 220012 RVA: 0x00F027A0 File Offset: 0x00F009A0
		public SkillTipEvent(string icon, string nameKey, bool isUltimate, ESkillCastEffect castEffect)
		{
			this.Icon = icon;
			this.NameKey = nameKey;
			this.IsUltimate = isUltimate;
			this.CastEffect = castEffect;
		}

		// Token: 0x0401C6EB RID: 116459
		public string Icon;

		// Token: 0x0401C6EC RID: 116460
		public string NameKey;

		// Token: 0x0401C6ED RID: 116461
		public bool IsUltimate;

		// Token: 0x0401C6EE RID: 116462
		public ESkillCastEffect CastEffect;
	}
}
