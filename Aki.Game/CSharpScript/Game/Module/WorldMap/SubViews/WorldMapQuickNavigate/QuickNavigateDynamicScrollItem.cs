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
	// Token: 0x020047D2 RID: 18386
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickNavigateDynamicScrollItem : UiPanelBase, IDynamicScrollItem<QuickNavigateDynamicData>
	{
		// Token: 0x060302D2 RID: 197330 RVA: 0x00B29D70 File Offset: 0x00B27F70
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

		// Token: 0x060302D3 RID: 197331 RVA: 0x00B29DDC File Offset: 0x00B27FDC
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

		// Token: 0x060302D4 RID: 197332 RVA: 0x00B29E28 File Offset: 0x00B28028
		protected override UniTask OnBeforeStartAsync()
		{
			QuickNavigateDynamicScrollItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickNavigateDynamicScrollItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060302D5 RID: 197333 RVA: 0x00B29E6B File Offset: 0x00B2806B
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

		// Token: 0x060302D6 RID: 197334 RVA: 0x00B29E8F File Offset: 0x00B2808F
		[NullableContext(2)]
		private AUIBaseActor GetItemActor(EQuickNavigateDynamicComponent key)
		{
			UUIItem item = base.GetItem((int)key);
			return ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
		}

		// Token: 0x060302D7 RID: 197335 RVA: 0x00B29EAC File Offset: 0x00B280AC
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

		// Token: 0x060302D8 RID: 197336 RVA: 0x00B29F10 File Offset: 0x00B28110
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x04019F1F RID: 106271
		[Nullable(2)]
		private QuickNavigateItemPanelA QuickNavigateItemPanelA;

		// Token: 0x04019F20 RID: 106272
		[Nullable(2)]
		private QuickNavigateItemPanelB QuickNavigateItemPanelB;
	}
}
