using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052DB RID: 21211
	public class PinballItemGridRoleRecommendComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CCF RID: 216271 RVA: 0x00EC2B7E File Offset: 0x00EC0D7E
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRecommend";
		}

		// Token: 0x06034CD0 RID: 216272 RVA: 0x00EC2B88 File Offset: 0x00EC0D88
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}
	}
}
