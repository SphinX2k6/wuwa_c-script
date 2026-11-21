using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487D RID: 18557
	public class InstanceDungeonRecommendElementItem : UiPanelBase
	{
		// Token: 0x0602EAD3 RID: 191187 RVA: 0x00D07488 File Offset: 0x00D05688
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

		// Token: 0x0602EAD4 RID: 191188 RVA: 0x00D074D0 File Offset: 0x00D056D0
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(0), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Element);
			}
		}

		// Token: 0x0602EAD5 RID: 191189 RVA: 0x00D0750C File Offset: 0x00D0570C
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x0602EAD6 RID: 191190 RVA: 0x00D07513 File Offset: 0x00D05713
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

		// Token: 0x04018D0F RID: 101647
		[Nullable(2)]
		private IInstanceDungeonRecommendElementItem ItemDataHandle;

		// Token: 0x04018D10 RID: 101648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x0200A526 RID: 42278
		private enum EChildType
		{
			// Token: 0x04033221 RID: 209441
			RecommendElementLayout
		}
	}
}
