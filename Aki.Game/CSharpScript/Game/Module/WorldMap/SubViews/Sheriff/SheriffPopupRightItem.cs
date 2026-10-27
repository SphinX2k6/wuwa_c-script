using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Sheriff
{
	// Token: 0x020047EF RID: 18415
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffPopupRightItem : PopupTypeRightItem
	{
		// Token: 0x060303B1 RID: 197553 RVA: 0x00B2DF10 File Offset: 0x00B2C110
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

		// Token: 0x060303B2 RID: 197554 RVA: 0x00B2E019 File Offset: 0x00B2C219
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(0);
		}

		// Token: 0x060303B3 RID: 197555 RVA: 0x00B2E024 File Offset: 0x00B2C224
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

		// Token: 0x060303B4 RID: 197556 RVA: 0x00B2E058 File Offset: 0x00B2C258
		public void SetTitleIcon(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.TrySetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
		}

		// Token: 0x060303B5 RID: 197557 RVA: 0x00B2E08C File Offset: 0x00B2C28C
		[NullableContext(2)]
		public void SetTitleIconByPath(string path)
		{
			base.TrySetSpriteByPath(path, base.GetSprite(2), false, null, null);
		}

		// Token: 0x060303B6 RID: 197558 RVA: 0x00B2E0B2 File Offset: 0x00B2C2B2
		public override void SetTitleText(string txt)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x0200AAB4 RID: 43700
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04033ED4 RID: 212692
			public const int Content = 0;

			// Token: 0x04033ED5 RID: 212693
			public const int BackBtn = 1;

			// Token: 0x04033ED6 RID: 212694
			public const int SprIcon = 2;

			// Token: 0x04033ED7 RID: 212695
			public const int TextName = 3;

			// Token: 0x04033ED8 RID: 212696
			public const int BtnClose = 4;
		}
	}
}
