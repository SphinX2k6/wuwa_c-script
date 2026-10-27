using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635F RID: 25439
	public class PinballItemGridWeaponReplaceComponent : PinballItemGridComponentBase
	{
		// Token: 0x06040014 RID: 262164 RVA: 0x00F7BC79 File Offset: 0x00F79E79
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseWeaponLift";
		}

		// Token: 0x06040015 RID: 262165 RVA: 0x00F7BC80 File Offset: 0x00F79E80
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
