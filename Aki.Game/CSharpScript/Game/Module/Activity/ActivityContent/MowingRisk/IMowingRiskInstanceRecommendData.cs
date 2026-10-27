using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C3 RID: 25539
	[NullableContext(1)]
	public interface IMowingRiskInstanceRecommendData
	{
		// Token: 0x170093CD RID: 37837
		// (get) Token: 0x060403FB RID: 263163
		// (set) Token: 0x060403FC RID: 263164
		string TextId { get; set; }

		// Token: 0x170093CE RID: 37838
		// (get) Token: 0x060403FD RID: 263165
		// (set) Token: 0x060403FE RID: 263166
		string[] TextArgs { get; set; }

		// Token: 0x170093CF RID: 37839
		// (get) Token: 0x060403FF RID: 263167
		// (set) Token: 0x06040400 RID: 263168
		int RecommendLevel { get; set; }
	}
}
