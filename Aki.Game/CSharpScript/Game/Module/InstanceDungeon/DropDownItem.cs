using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005885 RID: 22661
	public class DropDownItem : DropDownItemBase<TakeWeedsDifficulty>
	{
		// Token: 0x06039AC0 RID: 236224 RVA: 0x00DB51B6 File Offset: 0x00DB33B6
		[NullableContext(1)]
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06039AC1 RID: 236225 RVA: 0x00DB51C0 File Offset: 0x00DB33C0
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

		// Token: 0x06039AC2 RID: 236226 RVA: 0x00DB522C File Offset: 0x00DB342C
		protected override void OnShowDropDownItemBase(TakeWeedsDifficulty data)
		{
			string str = ConfigMultiTextLang.GetLocalTextNew(data.Desc, null) ?? "";
			string str2 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MowingPointMultiply", null) ?? "", new string[]
			{
				(data.Magnification / 100).ToString()
			});
			base.GetText(1).SetText(str + "•" + str2, true);
		}

		// Token: 0x06039AC3 RID: 236227 RVA: 0x00DB529E File Offset: 0x00DB349E
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0200BAE0 RID: 47840
		private static class EDropDownItemComponents
		{
			// Token: 0x04038784 RID: 231300
			public const int TogOption = 0;

			// Token: 0x04038785 RID: 231301
			public const int TxtOption = 1;
		}
	}
}
