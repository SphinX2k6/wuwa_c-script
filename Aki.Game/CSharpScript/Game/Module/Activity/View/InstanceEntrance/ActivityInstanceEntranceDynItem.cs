using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F13 RID: 24339
	public class ActivityInstanceEntranceDynItem : UiPanelBase, IDynamicScrollBaseItem<ActivityEntranceItemData>
	{
		// Token: 0x0603DD66 RID: 253286 RVA: 0x00EF1FF8 File Offset: 0x00EF01F8
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ActivityInstanceEntranceDynItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivityInstanceEntranceDynItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD67 RID: 253287 RVA: 0x00EF2044 File Offset: 0x00EF0244
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

		// Token: 0x0603DD68 RID: 253288 RVA: 0x00EF20B0 File Offset: 0x00EF02B0
		[NullableContext(1)]
		public FVector2D GetItemSize(ActivityEntranceItemData data)
		{
			if (data.GetStyle() == 0)
			{
				UUIItem item = base.GetItem(0);
				return new FVector2D(item.GetWidth(), item.GetHeight());
			}
			UUIItem item2 = base.GetItem(1);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}

		// Token: 0x0603DD69 RID: 253289 RVA: 0x00EF20F8 File Offset: 0x00EF02F8
		public void ClearItem()
		{
		}

		// Token: 0x0200C242 RID: 49730
		private class EComponent
		{
			// Token: 0x0403AAFB RID: 240379
			public const int InstanceSeriesItem = 0;

			// Token: 0x0403AAFC RID: 240380
			public const int InstanceItem = 1;

			// Token: 0x0403AAFD RID: 240381
			public const int LockInstanceSeriesItem = 2;

			// Token: 0x0403AAFE RID: 240382
			public const int LockInstanceItem = 3;
		}
	}
}
