using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200657D RID: 25981
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingRewardTargetTabData
	{
		// Token: 0x04021ECB RID: 138955
		public string NameTextId;

		// Token: 0x04021ECC RID: 138956
		public int Index = -1;

		// Token: 0x04021ECD RID: 138957
		public Action<int> ClickedCallback;

		// Token: 0x04021ECE RID: 138958
		public Func<int, bool> RefreshRedDot;
	}
}
