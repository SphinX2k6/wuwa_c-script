using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495E RID: 18782
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowItemComponent : HotKeyComponent
	{
		// Token: 0x0603101C RID: 200732 RVA: 0x00B610F1 File Offset: 0x00B5F2F1
		public FollowItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603101D RID: 200733 RVA: 0x00B610FA File Offset: 0x00B5F2FA
		public void ResetFollowItem()
		{
		}

		// Token: 0x0603101E RID: 200734 RVA: 0x00B610FC File Offset: 0x00B5F2FC
		public void FollowItem(UUIItem item, int length)
		{
		}

		// Token: 0x0603101F RID: 200735 RVA: 0x00B610FE File Offset: 0x00B5F2FE
		public void OnInteractionHintChangeItemCountEvent(int length)
		{
		}

		// Token: 0x06031020 RID: 200736 RVA: 0x00B61100 File Offset: 0x00B5F300
		protected override void OnInputAxis(string axisName, float value)
		{
		}
	}
}
