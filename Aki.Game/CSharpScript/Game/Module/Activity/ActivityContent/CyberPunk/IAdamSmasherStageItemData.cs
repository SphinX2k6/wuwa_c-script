using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005803 RID: 22531
	[NullableContext(1)]
	public interface IAdamSmasherStageItemData
	{
		// Token: 0x17006B08 RID: 27400
		// (get) Token: 0x060379A8 RID: 227752
		int StageId { get; }

		// Token: 0x17006B09 RID: 27401
		// (get) Token: 0x060379A9 RID: 227753
		string IndexText { get; }

		// Token: 0x17006B0A RID: 27402
		// (get) Token: 0x060379AA RID: 227754
		string Name { get; }

		// Token: 0x17006B0B RID: 27403
		// (get) Token: 0x060379AB RID: 227755
		bool IsUnlocked { get; }

		// Token: 0x17006B0C RID: 27404
		// (get) Token: 0x060379AC RID: 227756
		bool IsHard { get; }
	}
}
