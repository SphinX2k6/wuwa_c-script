using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052D1 RID: 21201
	public class PinballShopItemNewTagView : UiPanelBase
	{
		// Token: 0x06034CA1 RID: 216225 RVA: 0x00EC23EB File Offset: 0x00EC05EB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		}

		// Token: 0x0401BF00 RID: 114432
		[Nullable(1)]
		public const string ResourceId = "UiItem_ItemBaseNew";
	}
}
