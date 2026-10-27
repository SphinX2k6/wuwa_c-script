using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006355 RID: 25429
	public class PinballItemGridLockComponent : PinballItemGridComponentBase
	{
		// Token: 0x0603FFE8 RID: 262120 RVA: 0x00F7B565 File Offset: 0x00F79765
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseLocked";
		}

		// Token: 0x0603FFE9 RID: 262121 RVA: 0x00F7B56C File Offset: 0x00F7976C
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
