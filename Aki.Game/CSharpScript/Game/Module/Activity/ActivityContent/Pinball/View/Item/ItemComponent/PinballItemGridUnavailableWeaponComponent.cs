using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052DC RID: 21212
	public class PinballItemGridUnavailableWeaponComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CD2 RID: 216274 RVA: 0x00EC2BAD File Offset: 0x00EC0DAD
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseUnavailableWeapon";
		}

		// Token: 0x06034CD3 RID: 216275 RVA: 0x00EC2BB4 File Offset: 0x00EC0DB4
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
