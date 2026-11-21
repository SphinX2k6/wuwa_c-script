using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D3 RID: 21203
	public class PinballItemGridLockComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CA9 RID: 216233 RVA: 0x00EC24C5 File Offset: 0x00EC06C5
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseLocked";
		}

		// Token: 0x06034CAA RID: 216234 RVA: 0x00EC24CC File Offset: 0x00EC06CC
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
