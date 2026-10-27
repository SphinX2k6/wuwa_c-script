using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635D RID: 25437
	public class PinballItemGridRoleRecommendComponent : PinballItemGridComponentBase
	{
		// Token: 0x0604000E RID: 262158 RVA: 0x00F7BC1E File Offset: 0x00F79E1E
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRecommend";
		}

		// Token: 0x0604000F RID: 262159 RVA: 0x00F7BC28 File Offset: 0x00F79E28
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
