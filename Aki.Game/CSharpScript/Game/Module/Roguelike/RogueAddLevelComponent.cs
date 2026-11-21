using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE4 RID: 15844
	public class RogueAddLevelComponent : MediumItemGridComponent
	{
		// Token: 0x060287A3 RID: 165795 RVA: 0x00B58B24 File Offset: 0x00B56D24
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

		// Token: 0x060287A4 RID: 165796 RVA: 0x00B58B8D File Offset: 0x00B56D8D
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueRoleType";
		}

		// Token: 0x060287A5 RID: 165797 RVA: 0x00B58B94 File Offset: 0x00B56D94
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
