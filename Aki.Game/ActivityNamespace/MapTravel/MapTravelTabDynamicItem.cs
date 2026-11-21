using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x02002F5C RID: 12124
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<MapTravelAreaData>
	{
		// Token: 0x0601CB80 RID: 117632 RVA: 0x008C4108 File Offset: 0x008C2308
		public UniTask Init(UUIItem actor)
		{
			MapTravelTabDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MapTravelTabDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0601CB81 RID: 117633 RVA: 0x008C4154 File Offset: 0x008C2354
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

		// Token: 0x0601CB82 RID: 117634 RVA: 0x008C41C0 File Offset: 0x008C23C0
		public FVector2D GetItemSize(MapTravelAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0601CB83 RID: 117635 RVA: 0x008C41F9 File Offset: 0x008C23F9
		public void ClearItem()
		{
		}

		// Token: 0x0400F21A RID: 61978
		private Vector2D VectorValue;

		// Token: 0x02008BE7 RID: 35815
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402C51F RID: 181535
			public const int NormalItem = 0;

			// Token: 0x0402C520 RID: 181536
			public const int LockItem = 1;
		}
	}
}
