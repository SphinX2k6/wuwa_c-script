using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E1B RID: 19995
	public class RogueAddLevelComponent : MediumItemGridComponent
	{
		// Token: 0x06033938 RID: 211256 RVA: 0x00C0F5EC File Offset: 0x00C0D7EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033939 RID: 211257 RVA: 0x00C0F655 File Offset: 0x00C0D855
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueRoleType";
		}

		// Token: 0x0603393A RID: 211258 RVA: 0x00C0F65C File Offset: 0x00C0D85C
		[NullableContext(2)]
		protected override void OnRefresh(object @params = null)
		{
			int num2;
			if (@params is int)
			{
				int num = (int)@params;
				num2 = num;
			}
			else
			{
				num2 = 0;
			}
			int num3 = num2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_LevelShow_Text", new <>z__ReadOnlySingleElementList<object>(num3));
		}
	}
}
