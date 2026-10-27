using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x02004840 RID: 18496
	public class MapMoraleWarnItem : UiPanelBase
	{
		// Token: 0x06030676 RID: 198262 RVA: 0x00B3C528 File Offset: 0x00B3A728
		[NullableContext(1)]
		public UniTask Init(UUIItem parentItem, string resId = "UiItem_MapTipButtom")
		{
			MapMoraleWarnItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.parentItem = parentItem;
			<Init>d__.resId = resId;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MapMoraleWarnItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06030677 RID: 198263 RVA: 0x00B3C57C File Offset: 0x00B3A77C
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

		// Token: 0x06030678 RID: 198264 RVA: 0x00B3C5C4 File Offset: 0x00B3A7C4
		[NullableContext(1)]
		public void UpdateTitle(string titleId)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(titleId);
		}

		// Token: 0x0200AB1E RID: 43806
		public static class EChildType
		{
			// Token: 0x04034010 RID: 213008
			public const int TxtTitle = 0;
		}
	}
}
