using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200569F RID: 22175
	[NullableContext(1)]
	[Nullable(0)]
	public class StarLevelComponent
	{
		// Token: 0x060386D8 RID: 231128 RVA: 0x00D65B3B File Offset: 0x00D63D3B
		public StarLevelComponent(UUILayoutBase layout)
		{
			this.StarLayout = new GenericLayoutNew<StarItem>(layout, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.OnCreateStarProxy), null);
		}

		// Token: 0x060386D9 RID: 231129 RVA: 0x00D65B5C File Offset: 0x00D63D5C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<StarItem> OnCreateStarProxy(object data, UUIItem uiItem, int index)
		{
			if (data is bool)
			{
				bool state = (bool)data;
				StarItem starItem = new StarItem();
				starItem.CreateThenShowByActor(uiItem.GetOwner(), null);
				starItem.SetState(state);
				return new LayoutItem<StarItem>
				{
					Key = index,
					Value = starItem
				};
			}
			return null;
		}

		// Token: 0x060386DA RID: 231130 RVA: 0x00D65BB0 File Offset: 0x00D63DB0
		public void ShowLevel(int current, int max)
		{
			List<bool> list = new List<bool>(new bool[max]);
			for (int i = 0; i < current; i++)
			{
				list[i] = true;
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x060386DB RID: 231131 RVA: 0x00D65BF2 File Offset: 0x00D63DF2
		public void Clear()
		{
			this.StarLayout.ClearChildren();
		}

		// Token: 0x0401DA2E RID: 121390
		private readonly GenericLayoutNew<StarItem> StarLayout;
	}
}
