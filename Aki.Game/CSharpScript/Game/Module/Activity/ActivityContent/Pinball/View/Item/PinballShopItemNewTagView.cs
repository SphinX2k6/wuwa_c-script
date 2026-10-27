using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006353 RID: 25427
	public class PinballShopItemNewTagView : UiPanelBase
	{
		// Token: 0x0603FFE0 RID: 262112 RVA: 0x00F7B48B File Offset: 0x00F7968B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		}

		// Token: 0x040215D1 RID: 136657
		[Nullable(1)]
		public const string ResourceId = "UiItem_ItemBaseNew";
	}
}
