using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006516 RID: 25878
	[NullableContext(2)]
	[Nullable(0)]
	public struct SkillTipEvent
	{
		// Token: 0x06040EA8 RID: 265896 RVA: 0x00FBB770 File Offset: 0x00FB9970
		public SkillTipEvent(string icon, string nameKey, bool isUltimate, ESkillCastEffect castEffect)
		{
			this.Icon = icon;
			this.NameKey = nameKey;
			this.IsUltimate = isUltimate;
			this.CastEffect = castEffect;
		}

		// Token: 0x04021DBA RID: 138682
		public string Icon;

		// Token: 0x04021DBB RID: 138683
		public string NameKey;

		// Token: 0x04021DBC RID: 138684
		public bool IsUltimate;

		// Token: 0x04021DBD RID: 138685
		public ESkillCastEffect CastEffect;
	}
}
