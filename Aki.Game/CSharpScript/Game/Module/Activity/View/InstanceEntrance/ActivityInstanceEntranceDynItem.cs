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
	// Token: 0x02004EFA RID: 20218
	public class ActivityInstanceEntranceDynItem : UiPanelBase, IDynamicScrollBaseItem<ActivityEntranceItemData>
	{
		// Token: 0x06032D01 RID: 208129 RVA: 0x00E43D00 File Offset: 0x00E41F00
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

		// Token: 0x06032D02 RID: 208130 RVA: 0x00E43D4C File Offset: 0x00E41F4C
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

		// Token: 0x06032D03 RID: 208131 RVA: 0x00E43DB8 File Offset: 0x00E41FB8
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

		// Token: 0x06032D04 RID: 208132 RVA: 0x00E43E00 File Offset: 0x00E42000
		public void ClearItem()
		{
		}

		// Token: 0x0200AC4F RID: 44111
		private class EComponent
		{
			// Token: 0x040354ED RID: 218349
			public const int InstanceSeriesItem = 0;

			// Token: 0x040354EE RID: 218350
			public const int InstanceItem = 1;

			// Token: 0x040354EF RID: 218351
			public const int LockInstanceSeriesItem = 2;

			// Token: 0x040354F0 RID: 218352
			public const int LockInstanceItem = 3;
		}
	}
}
