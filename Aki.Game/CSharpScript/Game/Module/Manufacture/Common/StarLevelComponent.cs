using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004675 RID: 18037
	[NullableContext(1)]
	[Nullable(0)]
	public class StarLevelComponent
	{
		// Token: 0x0602D5D5 RID: 185813 RVA: 0x00CB3C8B File Offset: 0x00CB1E8B
		public StarLevelComponent(UUILayoutBase layout)
		{
			this.StarLayout = new GenericLayoutNew<StarItem>(layout, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.OnCreateStarProxy), null);
		}

		// Token: 0x0602D5D6 RID: 185814 RVA: 0x00CB3CAC File Offset: 0x00CB1EAC
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

		// Token: 0x0602D5D7 RID: 185815 RVA: 0x00CB3D00 File Offset: 0x00CB1F00
		public void ShowLevel(int current, int max)
		{
			List<bool> list = new List<bool>(new bool[max]);
			for (int i = 0; i < current; i++)
			{
				list[i] = true;
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x0602D5D8 RID: 185816 RVA: 0x00CB3D42 File Offset: 0x00CB1F42
		public void Clear()
		{
			this.StarLayout.ClearChildren();
		}

		// Token: 0x040184B9 RID: 99513
		private readonly GenericLayoutNew<StarItem> StarLayout;
	}
}
