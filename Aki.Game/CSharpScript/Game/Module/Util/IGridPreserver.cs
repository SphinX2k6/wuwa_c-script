using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C6 RID: 18630
	[NullableContext(2)]
	public interface IGridPreserver
	{
		// Token: 0x06030B1E RID: 199454
		int GetDisplayGridNum();

		// Token: 0x06030B1F RID: 199455
		int GetPreservedGridNum();

		// Token: 0x06030B20 RID: 199456
		int GetDisplayGridStartIndex();

		// Token: 0x06030B21 RID: 199457
		int GetDisplayGridEndIndex();

		// Token: 0x06030B22 RID: 199458
		UUIItem GetGrid(int gridIndex);

		// Token: 0x06030B23 RID: 199459
		UUIItem GetGridByDisplayIndex(int displayIndex);

		// Token: 0x06030B24 RID: 199460
		float GetGridAnimationInterval();

		// Token: 0x06030B25 RID: 199461
		float GetGridAnimationStartTime();

		// Token: 0x06030B26 RID: 199462
		void NotifyAnimationStart();

		// Token: 0x06030B27 RID: 199463
		void NotifyAnimationEnd();

		// Token: 0x06030B28 RID: 199464
		UUIInturnAnimController GetUiAnimController();
	}
}
