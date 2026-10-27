using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A5 RID: 22693
	public class InstanceDungeonRecommendElementItem : UiPanelBase
	{
		// Token: 0x06039BB0 RID: 236464 RVA: 0x00DB8570 File Offset: 0x00DB6770
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BB1 RID: 236465 RVA: 0x00DB85B8 File Offset: 0x00DB67B8
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(0), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Element);
			}
		}

		// Token: 0x06039BB2 RID: 236466 RVA: 0x00DB85F4 File Offset: 0x00DB67F4
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x06039BB3 RID: 236467 RVA: 0x00DB85FB File Offset: 0x00DB67FB
		[NullableContext(1)]
		public void RefreshItem(List<int> element)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new IInstanceDungeonRecommendElementItem
				{
					Element = element
				};
				return;
			}
			GenericLayout<TowerElementItem, int> elementLayout = this.ElementLayout;
			if (elementLayout == null)
			{
				return;
			}
			elementLayout.RefreshByData(element, null, false);
		}

		// Token: 0x0401E272 RID: 123506
		[Nullable(2)]
		private IInstanceDungeonRecommendElementItem ItemDataHandle;

		// Token: 0x0401E273 RID: 123507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x0200BB0D RID: 47885
		private enum EChildType
		{
			// Token: 0x04038820 RID: 231456
			RecommendElementLayout
		}
	}
}
