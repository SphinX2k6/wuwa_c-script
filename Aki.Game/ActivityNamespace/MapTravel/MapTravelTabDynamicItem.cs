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
	// Token: 0x020044CF RID: 17615
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<MapTravelAreaData>
	{
		// Token: 0x0602D642 RID: 185922 RVA: 0x00A3E4A8 File Offset: 0x00A3C6A8
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

		// Token: 0x0602D643 RID: 185923 RVA: 0x00A3E4F4 File Offset: 0x00A3C6F4
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

		// Token: 0x0602D644 RID: 185924 RVA: 0x00A3E560 File Offset: 0x00A3C760
		public FVector2D GetItemSize(MapTravelAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0602D645 RID: 185925 RVA: 0x00A3E599 File Offset: 0x00A3C799
		public void ClearItem()
		{
		}

		// Token: 0x04018472 RID: 99442
		private Vector2D VectorValue;

		// Token: 0x0200A711 RID: 42769
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04032751 RID: 206673
			public const int NormalItem = 0;

			// Token: 0x04032752 RID: 206674
			public const int LockItem = 1;
		}
	}
}
