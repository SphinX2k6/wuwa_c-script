using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006310 RID: 25360
	[NullableContext(1)]
	[Nullable(0)]
	public class IEmotionConfigInfo : IEmotionBubbleConfig
	{
		// Token: 0x040208DB RID: 133339
		public string EmotionName = string.Empty;

		// Token: 0x040208DC RID: 133340
		public List<int> TagList = new List<int>();
	}
}
