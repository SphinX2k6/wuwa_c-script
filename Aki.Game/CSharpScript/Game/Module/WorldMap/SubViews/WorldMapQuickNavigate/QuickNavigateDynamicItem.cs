using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x02003702 RID: 14082
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickNavigateDynamicItem : UiPanelBase, IDynamicScrollBaseItem<QuickNavigateDynamicData>
	{
		// Token: 0x06024A9C RID: 150172 RVA: 0x00A59AF4 File Offset: 0x00A57CF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024A9D RID: 150173 RVA: 0x00A59B60 File Offset: 0x00A57D60
		public UniTask Init(UUIItem actor)
		{
			QuickNavigateDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<QuickNavigateDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06024A9E RID: 150174 RVA: 0x00A59BAC File Offset: 0x00A57DAC
		public FVector2D GetItemSize(QuickNavigateDynamicData data)
		{
			if (data.ItemType == EQuickNavigateItemType.Country)
			{
				UUIItem item = base.GetItem(0);
				return new FVector2D(item.GetWidth(), item.GetHeight());
			}
			UUIItem item2 = base.GetItem(1);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}

		// Token: 0x06024A9F RID: 150175 RVA: 0x00A59BF4 File Offset: 0x00A57DF4
		public virtual void ClearItem()
		{
		}
	}
}
