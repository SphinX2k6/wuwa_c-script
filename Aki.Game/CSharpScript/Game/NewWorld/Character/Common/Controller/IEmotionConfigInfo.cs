using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B1 RID: 28849
	[NullableContext(1)]
	[Nullable(0)]
	public class IEmotionConfigInfo : IEmotionBubbleConfig
	{
		// Token: 0x04024DB4 RID: 150964
		public string EmotionName = string.Empty;

		// Token: 0x04024DB5 RID: 150965
		public List<int> TagList = new List<int>();
	}
}
