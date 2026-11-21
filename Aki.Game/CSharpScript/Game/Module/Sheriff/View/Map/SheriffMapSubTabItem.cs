using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Map
{
	// Token: 0x02003C16 RID: 15382
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffMapSubTabItem : GridProxyAbstract<ISheriffSubTabItemData>
	{
		// Token: 0x060276B4 RID: 161460 RVA: 0x00B0D094 File Offset: 0x00B0B294
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

		// Token: 0x060276B5 RID: 161461 RVA: 0x00B0D19D File Offset: 0x00B0B39D
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

		// Token: 0x060276B6 RID: 161462 RVA: 0x00B0D1C0 File Offset: 0x00B0B3C0
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

		// Token: 0x040157DB RID: 88027
		[Nullable(2)]
		private ISheriffSubTabItemData Data;

		// Token: 0x040157DC RID: 88028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISheriffSubTabItemData> ClickCallBack;

		// Token: 0x02009836 RID: 38966
		private static class EComponent
		{
			// Token: 0x0402F79C RID: 194460
			public const int Button = 0;

			// Token: 0x0402F79D RID: 194461
			public const int Icon = 1;

			// Token: 0x0402F79E RID: 194462
			public const int Text = 2;

			// Token: 0x0402F79F RID: 194463
			public const int Arrow = 3;

			// Token: 0x0402F7A0 RID: 194464
			public const int Finished = 4;
		}
	}
}
