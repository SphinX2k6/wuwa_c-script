using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052DD RID: 21213
	public class PinballItemGridWeaponReplaceComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CD5 RID: 216277 RVA: 0x00EC2BD9 File Offset: 0x00EC0DD9
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseWeaponLift";
		}

		// Token: 0x06034CD6 RID: 216278 RVA: 0x00EC2BE0 File Offset: 0x00EC0DE0
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
