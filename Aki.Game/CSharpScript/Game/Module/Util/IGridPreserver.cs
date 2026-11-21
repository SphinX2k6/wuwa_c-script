using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383D RID: 14397
	[NullableContext(2)]
	public interface IGridPreserver
	{
		// Token: 0x0602564A RID: 153162
		int GetDisplayGridNum();

		// Token: 0x0602564B RID: 153163
		int GetPreservedGridNum();

		// Token: 0x0602564C RID: 153164
		int GetDisplayGridStartIndex();

		// Token: 0x0602564D RID: 153165
		int GetDisplayGridEndIndex();

		// Token: 0x0602564E RID: 153166
		UUIItem GetGrid(int gridIndex);

		// Token: 0x0602564F RID: 153167
		UUIItem GetGridByDisplayIndex(int displayIndex);

		// Token: 0x06025650 RID: 153168
		float GetGridAnimationInterval();

		// Token: 0x06025651 RID: 153169
		float GetGridAnimationStartTime();

		// Token: 0x06025652 RID: 153170
		void NotifyAnimationStart();

		// Token: 0x06025653 RID: 153171
		void NotifyAnimationEnd();

		// Token: 0x06025654 RID: 153172
		UUIInturnAnimController GetUiAnimController();
	}
}
