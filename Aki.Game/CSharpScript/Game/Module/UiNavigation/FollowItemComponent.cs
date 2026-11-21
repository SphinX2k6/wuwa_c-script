using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D6 RID: 14550
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowItemComponent : HotKeyComponent
	{
		// Token: 0x06025B4C RID: 154444 RVA: 0x00A9BFD1 File Offset: 0x00A9A1D1
		public FollowItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B4D RID: 154445 RVA: 0x00A9BFDA File Offset: 0x00A9A1DA
		public void ResetFollowItem()
		{
		}

		// Token: 0x06025B4E RID: 154446 RVA: 0x00A9BFDC File Offset: 0x00A9A1DC
		public void FollowItem(UUIItem item, int length)
		{
		}

		// Token: 0x06025B4F RID: 154447 RVA: 0x00A9BFDE File Offset: 0x00A9A1DE
		public void OnInteractionHintChangeItemCountEvent(int length)
		{
		}

		// Token: 0x06025B50 RID: 154448 RVA: 0x00A9BFE0 File Offset: 0x00A9A1E0
		protected override void OnInputAxis(string axisName, float value)
		{
		}
	}
}
