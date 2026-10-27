using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047CC RID: 18380
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NavigateIconItem : GridProxyAbstract<INavigateIconItemData>
	{
		// Token: 0x060302B5 RID: 197301 RVA: 0x00B29A80 File Offset: 0x00B27C80
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

		// Token: 0x060302B6 RID: 197302 RVA: 0x00B29B28 File Offset: 0x00B27D28
		[NullableContext(1)]
		public override void Refresh(INavigateIconItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data;
			string path = (data.IconId != null) ? UiResourceConfig.Instance.GetResourcePath(data.IconId) : data.IconPath;
			UUISprite sprite = base.GetSprite(1);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x060302B7 RID: 197303 RVA: 0x00B29B78 File Offset: 0x00B27D78
		private void OnClick()
		{
			if (this.DataParam != null)
			{
				this.DataParam.ClickCallback(this.DataParam.Id, this.DataParam.MarkItem);
			}
		}

		// Token: 0x04019F09 RID: 106249
		[Nullable(2)]
		private INavigateIconItemData DataParam;

		// Token: 0x0200AA8E RID: 43662
		public static class EChildType
		{
			// Token: 0x04033E40 RID: 212544
			public const int BtnRoot = 0;

			// Token: 0x04033E41 RID: 212545
			public const int SpriteIcon = 1;
		}
	}
}
