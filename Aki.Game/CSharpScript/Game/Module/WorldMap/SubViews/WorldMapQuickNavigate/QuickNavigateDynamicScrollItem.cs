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
	// Token: 0x02003703 RID: 14083
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickNavigateDynamicScrollItem : UiPanelBase, IDynamicScrollItem<QuickNavigateDynamicData>
	{
		// Token: 0x06024AA2 RID: 150178 RVA: 0x00A59C0C File Offset: 0x00A57E0C
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

		// Token: 0x06024AA3 RID: 150179 RVA: 0x00A59C78 File Offset: 0x00A57E78
		public UniTask Init(UUIItem actor)
		{
			QuickNavigateDynamicScrollItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<QuickNavigateDynamicScrollItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06024AA4 RID: 150180 RVA: 0x00A59CC4 File Offset: 0x00A57EC4
		protected override UniTask OnBeforeStartAsync()
		{
			QuickNavigateDynamicScrollItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickNavigateDynamicScrollItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024AA5 RID: 150181 RVA: 0x00A59D07 File Offset: 0x00A57F07
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(QuickNavigateDynamicData data)
		{
			if (data.ItemType == EQuickNavigateItemType.Country)
			{
				return this.GetItemActor(EQuickNavigateDynamicComponent.UiItemTabA);
			}
			if (data.ItemType == EQuickNavigateItemType.State)
			{
				return this.GetItemActor(EQuickNavigateDynamicComponent.UiItemTabB);
			}
			return null;
		}

		// Token: 0x06024AA6 RID: 150182 RVA: 0x00A59D2B File Offset: 0x00A57F2B
		[NullableContext(2)]
		private AUIBaseActor GetItemActor(EQuickNavigateDynamicComponent key)
		{
			UUIItem item = base.GetItem((int)key);
			return ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
		}

		// Token: 0x06024AA7 RID: 150183 RVA: 0x00A59D48 File Offset: 0x00A57F48
		public void Update(QuickNavigateDynamicData data, int index)
		{
			bool flag = data.ItemType == EQuickNavigateItemType.Country;
			QuickNavigateItemPanelA quickNavigateItemPanelA = this.QuickNavigateItemPanelA;
			if (quickNavigateItemPanelA != null)
			{
				quickNavigateItemPanelA.SetActive(flag);
			}
			QuickNavigateItemPanelB quickNavigateItemPanelB = this.QuickNavigateItemPanelB;
			if (quickNavigateItemPanelB != null)
			{
				quickNavigateItemPanelB.SetActive(!flag);
			}
			if (flag)
			{
				QuickNavigateItemPanelA quickNavigateItemPanelA2 = this.QuickNavigateItemPanelA;
				if (quickNavigateItemPanelA2 == null)
				{
					return;
				}
				quickNavigateItemPanelA2.RefreshByData(data);
				return;
			}
			else
			{
				QuickNavigateItemPanelB quickNavigateItemPanelB2 = this.QuickNavigateItemPanelB;
				if (quickNavigateItemPanelB2 == null)
				{
					return;
				}
				quickNavigateItemPanelB2.RefreshByData(data);
				return;
			}
		}

		// Token: 0x06024AA8 RID: 150184 RVA: 0x00A59DAC File Offset: 0x00A57FAC
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x040145D3 RID: 83411
		[Nullable(2)]
		private QuickNavigateItemPanelA QuickNavigateItemPanelA;

		// Token: 0x040145D4 RID: 83412
		[Nullable(2)]
		private QuickNavigateItemPanelB QuickNavigateItemPanelB;
	}
}
