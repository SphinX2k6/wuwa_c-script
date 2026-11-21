using System;
using System.Collections.Generic;
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
	// Token: 0x0200473E RID: 18238
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookWeaponTabView : UiTabViewBase
	{
		// Token: 0x0602DC8C RID: 187532 RVA: 0x00CCFAD8 File Offset: 0x00CCDCD8
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

		// Token: 0x0602DC8D RID: 187533 RVA: 0x00CCFBC8 File Offset: 0x00CCDDC8
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookWeaponTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookWeaponTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC8E RID: 187534 RVA: 0x00CCFC0B File Offset: 0x00CCDE0B
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Switch");
			}
			this.RefreshCurrentList();
		}

		// Token: 0x0602DC8F RID: 187535 RVA: 0x00CCFC29 File Offset: 0x00CCDE29
		protected override void OnShowUiTabViewFromView()
		{
			this.RefreshCurrentList();
		}

		// Token: 0x0602DC90 RID: 187536 RVA: 0x00CCFC31 File Offset: 0x00CCDE31
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

		// Token: 0x0602DC91 RID: 187537 RVA: 0x00CCFC4D File Offset: 0x00CCDE4D
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			this.ActivityData.ReadKurotatoItemRedDot();
			this.ActivityData.ReadKurotatoWeaponRedDot();
		}

		// Token: 0x0602DC92 RID: 187538 RVA: 0x00CCFC68 File Offset: 0x00CCDE68
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
			this.CurrentIdList = new List<int>(list.Count);
			foreach (IKurotatoMediumItemGridData kurotatoMediumItemGridData in list)
			{
				this.CurrentIdList.Add(kurotatoMediumItemGridData.Id);
			}
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

		// Token: 0x0602DC93 RID: 187539 RVA: 0x00CCFDFC File Offset: 0x00CCDFFC
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

		// Token: 0x0602DC94 RID: 187540 RVA: 0x00CCFE68 File Offset: 0x00CCE068
		private KurotatoHandBookWeaponViewTabItem CreateTabItem()
		{
			return new KurotatoHandBookWeaponViewTabItem
			{
				OnToggleCallBack = new Action<EKurotatoCardType>(this.OnTabToggleClick)
			};
		}

		// Token: 0x0602DC95 RID: 187541 RVA: 0x00CCFE84 File Offset: 0x00CCE084
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

		// Token: 0x0401879E RID: 100254
		private KurotatoActivityData ActivityData;

		// Token: 0x0401879F RID: 100255
		private EKurotatoCardType TabType = EKurotatoCardType.None;

		// Token: 0x040187A0 RID: 100256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<KurotatoHandBookWeaponViewTabItem, EKurotatoCardType> TabLayout;

		// Token: 0x040187A1 RID: 100257
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<KurotatoWeaponMediumItemGrid, IKurotatoMediumItemGridData> WeaponLoopScrollView;

		// Token: 0x040187A2 RID: 100258
		private List<int> CurrentIdList = new List<int>();

		// Token: 0x040187A3 RID: 100259
		[Nullable(2)]
		private KurotatoItemInfoTipPanel ItemInfoTip;

		// Token: 0x0200A386 RID: 41862
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04032B1A RID: 207642
			LayoutTab,
			// Token: 0x04032B1B RID: 207643
			ItemTab,
			// Token: 0x04032B1C RID: 207644
			LayoutWeapon,
			// Token: 0x04032B1D RID: 207645
			ItemWeapon,
			// Token: 0x04032B1E RID: 207646
			TextCollected,
			// Token: 0x04032B1F RID: 207647
			ItemInfoPanel,
			// Token: 0x04032B20 RID: 207648
			ScrollWeapon
		}
	}
}
