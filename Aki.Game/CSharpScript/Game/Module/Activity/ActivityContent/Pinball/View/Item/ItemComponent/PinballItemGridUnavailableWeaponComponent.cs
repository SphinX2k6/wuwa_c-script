using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635E RID: 25438
	public class PinballItemGridUnavailableWeaponComponent : PinballItemGridComponentBase
	{
		// Token: 0x06040011 RID: 262161 RVA: 0x00F7BC4D File Offset: 0x00F79E4D
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseUnavailableWeapon";
		}

		// Token: 0x06040012 RID: 262162 RVA: 0x00F7BC54 File Offset: 0x00F79E54
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
