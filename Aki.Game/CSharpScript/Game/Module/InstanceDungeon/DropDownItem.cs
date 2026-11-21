using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200485D RID: 18525
	public class DropDownItem : DropDownItemBase<TakeWeedsDifficulty>
	{
		// Token: 0x0602E9E3 RID: 190947 RVA: 0x00D040CE File Offset: 0x00D022CE
		[NullableContext(1)]
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602E9E4 RID: 190948 RVA: 0x00D040D8 File Offset: 0x00D022D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E9E5 RID: 190949 RVA: 0x00D04144 File Offset: 0x00D02344
		protected override void OnShowDropDownItemBase(TakeWeedsDifficulty data)
		{
			string str = ConfigMultiTextLang.GetLocalTextNew(data.Desc, null) ?? "";
			string str2 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MowingPointMultiply", null) ?? "", new string[]
			{
				(data.Magnification / 100).ToString()
			});
			base.GetText(1).SetText(str + "•" + str2, true);
		}

		// Token: 0x0602E9E6 RID: 190950 RVA: 0x00D041B6 File Offset: 0x00D023B6
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0200A4F9 RID: 42233
		private static class EDropDownItemComponents
		{
			// Token: 0x04033185 RID: 209285
			public const int TogOption = 0;

			// Token: 0x04033186 RID: 209286
			public const int TxtOption = 1;
		}
	}
}
