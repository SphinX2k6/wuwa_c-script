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
	// Token: 0x02003771 RID: 14193
	public class MapMoraleWarnItem : UiPanelBase
	{
		// Token: 0x06024E46 RID: 151110 RVA: 0x00A6C710 File Offset: 0x00A6A910
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

		// Token: 0x06024E47 RID: 151111 RVA: 0x00A6C764 File Offset: 0x00A6A964
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

		// Token: 0x06024E48 RID: 151112 RVA: 0x00A6C7AC File Offset: 0x00A6A9AC
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

		// Token: 0x020094CC RID: 38092
		public static class EChildType
		{
			// Token: 0x0402E78B RID: 190347
			public const int TxtTitle = 0;
		}
	}
}
