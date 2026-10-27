using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.Overview;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x02005767 RID: 22375
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookWeaponTabView : UiTabViewBase
	{
		// Token: 0x06038D7C RID: 232828 RVA: 0x00D81014 File Offset: 0x00D7F214
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D7D RID: 232829 RVA: 0x00D81104 File Offset: 0x00D7F304
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookWeaponTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookWeaponTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D7E RID: 232830 RVA: 0x00D81147 File Offset: 0x00D7F347
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Switch");
			}
			this.RefreshCurrentList();
		}

		// Token: 0x06038D7F RID: 232831 RVA: 0x00D81165 File Offset: 0x00D7F365
		protected override void OnShowUiTabViewFromView()
		{
			this.RefreshCurrentList();
		}

		// Token: 0x06038D80 RID: 232832 RVA: 0x00D8116D File Offset: 0x00D7F36D
		private void RefreshCurrentList()
		{
			if (this.TabType == EKurotatoCardType.None)
			{
				return;
			}
			LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> weaponLoopScrollView = this.WeaponLoopScrollView;
			if (weaponLoopScrollView == null)
			{
				return;
			}
			weaponLoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x06038D81 RID: 232833 RVA: 0x00D81189 File Offset: 0x00D7F389
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			this.ActivityData.ReadKurotatoItemRedDot();
			this.ActivityData.ReadKurotatoWeaponRedDot();
		}

		// Token: 0x06038D82 RID: 232834 RVA: 0x00D811A4 File Offset: 0x00D7F3A4
		private void OnTabToggleClick(EKurotatoCardType tabType)
		{
			if (this.TabType == EKurotatoCardType.Weapon)
			{
				this.ActivityData.ReadKurotatoWeaponRedDot();
			}
			if (this.TabType == EKurotatoCardType.Item)
			{
				this.ActivityData.ReadKurotatoItemRedDot();
			}
			this.TabType = tabType;
			GenericLayout<KurotatoHandBookWeaponViewTabItem, EKurotatoCardType> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxyByKey((int)tabType, false);
			}
			List<IKurotatoMediumItemGridData> list = (tabType == EKurotatoCardType.Weapon) ? this.ActivityData.GetKurotatoWeaponList() : this.ActivityData.GetKurotatoItemList();
			this.CurrentIdList = (from data in list
			select data.Id).ToList<int>();
			LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> weaponLoopScrollView = this.WeaponLoopScrollView;
			if (weaponLoopScrollView != null)
			{
				weaponLoopScrollView.SelectGridProxy(-1, false);
			}
			LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> weaponLoopScrollView2 = this.WeaponLoopScrollView;
			if (weaponLoopScrollView2 != null)
			{
				weaponLoopScrollView2.RefreshByData(list, false, delegate
				{
					this.OnGirdItemToggleClick(list[0].Id);
					LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> weaponLoopScrollView3 = this.WeaponLoopScrollView;
					if (weaponLoopScrollView3 == null)
					{
						return;
					}
					weaponLoopScrollView3.ScrollToGridIndex(0, true);
				}, true);
			}
			int item;
			int item2;
			if (tabType != EKurotatoCardType.Weapon)
			{
				ValueTuple<int, int> valueTuple = this.ActivityData.GetItemUnlockNum();
				item = valueTuple.Item1;
				item2 = valueTuple.Item2;
			}
			else
			{
				ValueTuple<int, int> valueTuple = this.ActivityData.GetWeaponUnlockNum();
				item = valueTuple.Item1;
				item2 = valueTuple.Item2;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Kurotato_Handbook_Collect", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
		}

		// Token: 0x06038D83 RID: 232835 RVA: 0x00D81300 File Offset: 0x00D7F500
		private void OnGirdItemToggleClick(int itemId)
		{
			int gridIndex = this.CurrentIdList.FindIndex((int id) => id == itemId);
			LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> weaponLoopScrollView = this.WeaponLoopScrollView;
			if (weaponLoopScrollView != null)
			{
				weaponLoopScrollView.SelectGridProxy(gridIndex, false);
			}
			KurotatoItemInfoTipPanel itemInfoTip = this.ItemInfoTip;
			if (itemInfoTip == null)
			{
				return;
			}
			itemInfoTip.Refresh(this.TabType, itemId, true, false, null);
		}

		// Token: 0x06038D84 RID: 232836 RVA: 0x00D8136C File Offset: 0x00D7F56C
		private KurotatoHandBookWeaponViewTabItem CreateTabItem()
		{
			return new KurotatoHandBookWeaponViewTabItem
			{
				OnToggleCallBack = new Action<EKurotatoCardType>(this.OnTabToggleClick)
			};
		}

		// Token: 0x06038D85 RID: 232837 RVA: 0x00D81388 File Offset: 0x00D7F588
		private KurotatoWeaponMediumItemGrid CreateWeaponItem()
		{
			KurotatoWeaponMediumItemGrid item = new KurotatoWeaponMediumItemGrid();
			item.IsShowItemCount = false;
			item.IsShowLock = true;
			item.IsShowNew = true;
			item.BindCallback(delegate(EToggleState state)
			{
				if (state == EToggleState.ETT_Checked)
				{
					this.OnGirdItemToggleClick(item.Data.Id);
				}
			});
			return item;
		}

		// Token: 0x0401DD08 RID: 122120
		private KurotatoActivityData ActivityData;

		// Token: 0x0401DD09 RID: 122121
		private EKurotatoCardType TabType = EKurotatoCardType.None;

		// Token: 0x0401DD0A RID: 122122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<KurotatoHandBookWeaponViewTabItem, EKurotatoCardType> TabLayout;

		// Token: 0x0401DD0B RID: 122123
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> WeaponLoopScrollView;

		// Token: 0x0401DD0C RID: 122124
		private List<int> CurrentIdList = new List<int>();

		// Token: 0x0401DD0D RID: 122125
		[Nullable(2)]
		private KurotatoItemInfoTipPanel ItemInfoTip;

		// Token: 0x0200B96B RID: 47467
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403811E RID: 229662
			LayoutTab,
			// Token: 0x0403811F RID: 229663
			ItemTab,
			// Token: 0x04038120 RID: 229664
			LayoutWeapon,
			// Token: 0x04038121 RID: 229665
			ItemWeapon,
			// Token: 0x04038122 RID: 229666
			TextCollected,
			// Token: 0x04038123 RID: 229667
			ItemInfoPanel,
			// Token: 0x04038124 RID: 229668
			ScrollWeapon
		}
	}
}
