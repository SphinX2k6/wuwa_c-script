using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Sheriff
{
	// Token: 0x02003720 RID: 14112
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffPopupRightItem : PopupTypeRightItem
	{
		// Token: 0x06024B81 RID: 150401 RVA: 0x00A5DE54 File Offset: 0x00A5C054
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(base.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024B82 RID: 150402 RVA: 0x00A5DF5D File Offset: 0x00A5C15D
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(0);
		}

		// Token: 0x06024B83 RID: 150403 RVA: 0x00A5DF68 File Offset: 0x00A5C168
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(false);
		}

		// Token: 0x06024B84 RID: 150404 RVA: 0x00A5DF9C File Offset: 0x00A5C19C
		public void SetTitleIcon(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.TrySetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
		}

		// Token: 0x06024B85 RID: 150405 RVA: 0x00A5DFD0 File Offset: 0x00A5C1D0
		[NullableContext(2)]
		public void SetTitleIconByPath(string path)
		{
			base.TrySetSpriteByPath(path, base.GetSprite(2), false, null, null);
		}

		// Token: 0x06024B86 RID: 150406 RVA: 0x00A5DFF6 File Offset: 0x00A5C1F6
		public override void SetTitleText(string txt)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x02009466 RID: 37990
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402E65A RID: 190042
			public const int Content = 0;

			// Token: 0x0402E65B RID: 190043
			public const int BackBtn = 1;

			// Token: 0x0402E65C RID: 190044
			public const int SprIcon = 2;

			// Token: 0x0402E65D RID: 190045
			public const int TextName = 3;

			// Token: 0x0402E65E RID: 190046
			public const int BtnClose = 4;
		}
	}
}
