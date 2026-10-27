using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064B5 RID: 25781
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct ScoreComment
	{
		// Token: 0x06040BA0 RID: 265120 RVA: 0x00FAB7E1 File Offset: 0x00FA99E1
		public ScoreComment(int count, string color1, string color2, string icon)
		{
			this.Count = count;
			this.Color1 = color1;
			this.Color2 = color2;
			this.Icon = icon;
		}

		// Token: 0x04021B40 RID: 138048
		public readonly int Count;

		// Token: 0x04021B41 RID: 138049
		public readonly string Color1;

		// Token: 0x04021B42 RID: 138050
		public readonly string Color2;

		// Token: 0x04021B43 RID: 138051
		public readonly string Icon;
	}
}
