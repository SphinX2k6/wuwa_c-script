using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200485E RID: 18526
	public class DropDownTitle : TitleItemBase<TakeWeedsDifficulty>
	{
		// Token: 0x0602E9E7 RID: 190951 RVA: 0x00D041BF File Offset: 0x00D023BF
		[NullableContext(1)]
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602E9E8 RID: 190952 RVA: 0x00D041C8 File Offset: 0x00D023C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E9E9 RID: 190953 RVA: 0x00D04210 File Offset: 0x00D02410
		[NullableContext(1)]
		public override void ShowTemp(TakeWeedsDifficulty data, DropDownItemBase<TakeWeedsDifficulty> selectedItemObj)
		{
			string str = ConfigMultiTextLang.GetLocalTextNew(data.Desc, null) ?? "";
			string str2 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MowingPointMultiply", null) ?? "", new string[]
			{
				(data.Magnification / 100).ToString()
			});
			base.GetText(0).SetText(str + "•" + str2, true);
		}

		// Token: 0x0200A4FA RID: 42234
		private static class EDropDownTitleComponents
		{
			// Token: 0x04033187 RID: 209287
			public const int TxtContent = 0;
		}
	}
}
