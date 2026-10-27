using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DFC RID: 19964
	public class RogueInfoViewTokenElement : MediumItemGridComponent
	{
		// Token: 0x06033844 RID: 211012 RVA: 0x00C09C35 File Offset: 0x00C07E35
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueElement";
		}

		// Token: 0x06033845 RID: 211013 RVA: 0x00C09C3C File Offset: 0x00C07E3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033846 RID: 211014 RVA: 0x00C09C84 File Offset: 0x00C07E84
		protected override void OnActivate()
		{
			this.GenericLayout = new GenericLayout<CommonElementItem, int>(base.GetVerticalLayout(0), new Func<CommonElementItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06033847 RID: 211015 RVA: 0x00C09CA7 File Offset: 0x00C07EA7
		[NullableContext(1)]
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x06033848 RID: 211016 RVA: 0x00C09CB0 File Offset: 0x00C07EB0
		[NullableContext(2)]
		protected override void OnRefresh(object param = null)
		{
			RogueGainEntry rogueGainEntry = param as RogueGainEntry;
			if (rogueGainEntry == null)
			{
				return;
			}
			List<ElementInfo> sortElementInfoArrayByCount = rogueGainEntry.GetSortElementInfoArrayByCount(false);
			if (sortElementInfoArrayByCount.Count <= 0)
			{
				return;
			}
			ElementInfo elementInfo = sortElementInfoArrayByCount[0];
			List<int> list = new List<int>();
			for (int i = 0; i < elementInfo.Count; i++)
			{
				list.Add(elementInfo.ElementId);
			}
			GenericLayout<CommonElementItem, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0401B55A RID: 111962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x0200AF89 RID: 44937
		private class ERogueInfoViewTokenElement
		{
			// Token: 0x040354C5 RID: 218309
			public const int Layout = 0;
		}
	}
}
