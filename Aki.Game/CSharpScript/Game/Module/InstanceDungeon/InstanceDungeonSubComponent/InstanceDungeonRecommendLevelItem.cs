using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A7 RID: 22695
	public class InstanceDungeonRecommendLevelItem : UiPanelBase
	{
		// Token: 0x06039BB8 RID: 236472 RVA: 0x00DB864C File Offset: 0x00DB684C
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

		// Token: 0x06039BB9 RID: 236473 RVA: 0x00DB8694 File Offset: 0x00DB6894
		protected override void OnStart()
		{
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Level);
			}
		}

		// Token: 0x06039BBA RID: 236474 RVA: 0x00DB86B0 File Offset: 0x00DB68B0
		[NullableContext(1)]
		public void RefreshItem(TowerDefenseRecommendLevel level)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new InstanceDungeonRecommendLevelItemData
				{
					Level = level
				};
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), level.TextId, new <>z__ReadOnlySingleElementList<object>(level.Level));
		}

		// Token: 0x0401E275 RID: 123509
		[Nullable(2)]
		private InstanceDungeonRecommendLevelItemData ItemDataHandle;

		// Token: 0x0200BB0E RID: 47886
		private enum EChildType
		{
			// Token: 0x04038822 RID: 231458
			RecommendLevelText
		}
	}
}
