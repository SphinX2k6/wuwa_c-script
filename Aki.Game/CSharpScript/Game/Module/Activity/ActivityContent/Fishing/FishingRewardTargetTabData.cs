using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020054FB RID: 21755
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingRewardTargetTabData
	{
		// Token: 0x0401C7FC RID: 116732
		public string NameTextId;

		// Token: 0x0401C7FD RID: 116733
		public int Index = -1;

		// Token: 0x0401C7FE RID: 116734
		public Action<int> ClickedCallback;

		// Token: 0x0401C7FF RID: 116735
		public Func<int, bool> RefreshRedDot;
	}
}
