using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487F RID: 18559
	public class InstanceDungeonRecommendLevelItem : UiPanelBase
	{
		// Token: 0x0602EADB RID: 191195 RVA: 0x00D07564 File Offset: 0x00D05764
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

		// Token: 0x0602EADC RID: 191196 RVA: 0x00D075AC File Offset: 0x00D057AC
		protected override void OnStart()
		{
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Level);
			}
		}

		// Token: 0x0602EADD RID: 191197 RVA: 0x00D075C8 File Offset: 0x00D057C8
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

		// Token: 0x04018D12 RID: 101650
		[Nullable(2)]
		private InstanceDungeonRecommendLevelItemData ItemDataHandle;

		// Token: 0x0200A527 RID: 42279
		private enum EChildType
		{
			// Token: 0x04033223 RID: 209443
			RecommendLevelText
		}
	}
}
