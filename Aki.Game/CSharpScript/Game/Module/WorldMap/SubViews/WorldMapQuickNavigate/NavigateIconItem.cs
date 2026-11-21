using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020036FD RID: 14077
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NavigateIconItem : GridProxyAbstract<INavigateIconItemData>
	{
		// Token: 0x06024A85 RID: 150149 RVA: 0x00A5991C File Offset: 0x00A57B1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024A86 RID: 150150 RVA: 0x00A599C4 File Offset: 0x00A57BC4
		[NullableContext(1)]
		public override void Refresh(INavigateIconItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data;
			string path = (data.IconId != null) ? UiResourceConfig.Instance.GetResourcePath(data.IconId) : data.IconPath;
			UUISprite sprite = base.GetSprite(1);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x06024A87 RID: 150151 RVA: 0x00A59A14 File Offset: 0x00A57C14
		private void OnClick()
		{
			if (this.DataParam != null)
			{
				this.DataParam.ClickCallback(this.DataParam.Id, this.DataParam.MarkItem);
			}
		}

		// Token: 0x040145BD RID: 83389
		[Nullable(2)]
		private INavigateIconItemData DataParam;

		// Token: 0x02009440 RID: 37952
		public static class EChildType
		{
			// Token: 0x0402E5C8 RID: 189896
			public const int BtnRoot = 0;

			// Token: 0x0402E5C9 RID: 189897
			public const int SpriteIcon = 1;
		}
	}
}
