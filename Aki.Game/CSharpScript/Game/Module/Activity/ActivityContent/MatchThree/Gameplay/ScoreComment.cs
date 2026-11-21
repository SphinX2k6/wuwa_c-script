using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005433 RID: 21555
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct ScoreComment
	{
		// Token: 0x06035864 RID: 219236 RVA: 0x00EF2829 File Offset: 0x00EF0A29
		public ScoreComment(int count, string color1, string color2, string icon)
		{
			this.Count = count;
			this.Color1 = color1;
			this.Color2 = color2;
			this.Icon = icon;
		}

		// Token: 0x0401C471 RID: 115825
		public readonly int Count;

		// Token: 0x0401C472 RID: 115826
		public readonly string Color1;

		// Token: 0x0401C473 RID: 115827
		public readonly string Color2;

		// Token: 0x0401C474 RID: 115828
		public readonly string Icon;
	}
}
