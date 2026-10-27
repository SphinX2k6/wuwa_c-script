using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Map
{
	// Token: 0x02004C65 RID: 19557
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffMapSubTabItem : GridProxyAbstract<ISheriffSubTabItemData>
	{
		// Token: 0x06032901 RID: 207105 RVA: 0x00BC8428 File Offset: 0x00BC6628
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032902 RID: 207106 RVA: 0x00BC8531 File Offset: 0x00BC6731
		private void OnClickItem()
		{
			if (this.Data == null)
			{
				return;
			}
			Action<ISheriffSubTabItemData> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this.Data);
		}

		// Token: 0x06032903 RID: 207107 RVA: 0x00BC8554 File Offset: 0x00BC6754
		[NullableContext(1)]
		public override void Refresh(ISheriffSubTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.TabTxt, true);
			}
			base.TrySetSpriteByPath(data.TabIcon, base.GetSprite(1), false, null, null);
			base.GetItem(3).SetUIActive(!data.IsFinished);
			base.GetItem(4).SetUIActive(data.IsFinished);
		}

		// Token: 0x0401AE7E RID: 110206
		[Nullable(2)]
		private ISheriffSubTabItemData Data;

		// Token: 0x0401AE7F RID: 110207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISheriffSubTabItemData> ClickCallBack;

		// Token: 0x0200AE18 RID: 44568
		private static class EComponent
		{
			// Token: 0x04034DF7 RID: 216567
			public const int Button = 0;

			// Token: 0x04034DF8 RID: 216568
			public const int Icon = 1;

			// Token: 0x04034DF9 RID: 216569
			public const int Text = 2;

			// Token: 0x04034DFA RID: 216570
			public const int Arrow = 3;

			// Token: 0x04034DFB RID: 216571
			public const int Finished = 4;
		}
	}
}
