using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005F02 RID: 24322
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySwitchToggleDynamicItem : UiPanelBase, IDynamicScrollBaseItem<IActivityCategoryTabData>
	{
		// Token: 0x17008EF4 RID: 36596
		// (get) Token: 0x0603DCE1 RID: 253153 RVA: 0x00EF0D0A File Offset: 0x00EEEF0A
		// (set) Token: 0x0603DCE2 RID: 253154 RVA: 0x00EF0D12 File Offset: 0x00EEEF12
		private Vector2D ItemSizeVector { get; set; }

		// Token: 0x0603DCE3 RID: 253155 RVA: 0x00EF0D1C File Offset: 0x00EEEF1C
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ActivitySwitchToggleDynamicItem.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivitySwitchToggleDynamicItem.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603DCE4 RID: 253156 RVA: 0x00EF0D68 File Offset: 0x00EEEF68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DCE5 RID: 253157 RVA: 0x00EF0DD4 File Offset: 0x00EEEFD4
		[NullableContext(1)]
		public FVector2D GetItemSize(IActivityCategoryTabData data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			if (data.IsLineType)
			{
				UUIItem item = base.GetItem(1);
				this.ItemSizeVector.Set((double)item.GetWidth(), (double)item.GetHeight());
				return this.ItemSizeVector.ToUeVector2D(false);
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x0603DCE6 RID: 253158 RVA: 0x00EF0E56 File Offset: 0x00EEF056
		public void ClearItem()
		{
		}

		// Token: 0x0200C237 RID: 49719
		[NullableContext(0)]
		private class ECategoryComponents
		{
			// Token: 0x0403AADE RID: 240350
			public const int ItemTypeTitle = 1;

			// Token: 0x0403AADF RID: 240351
			public const int PanelTab = 0;
		}
	}
}
