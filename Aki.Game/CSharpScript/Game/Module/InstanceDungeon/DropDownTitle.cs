using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005886 RID: 22662
	public class DropDownTitle : TitleItemBase<TakeWeedsDifficulty>
	{
		// Token: 0x06039AC4 RID: 236228 RVA: 0x00DB52A7 File Offset: 0x00DB34A7
		[NullableContext(1)]
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06039AC5 RID: 236229 RVA: 0x00DB52B0 File Offset: 0x00DB34B0
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

		// Token: 0x06039AC6 RID: 236230 RVA: 0x00DB52F8 File Offset: 0x00DB34F8
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

		// Token: 0x0200BAE1 RID: 47841
		private static class EDropDownTitleComponents
		{
			// Token: 0x04038786 RID: 231302
			public const int TxtContent = 0;
		}
	}
}
