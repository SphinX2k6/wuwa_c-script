using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200578A RID: 22410
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlSettleRoleBagDetailView : UiViewBase
	{
		// Token: 0x17006A8E RID: 27278
		// (get) Token: 0x060374E6 RID: 226534 RVA: 0x00F7201E File Offset: 0x00F7021E
		private ActivityDangoBrawlData ActData
		{
			get
			{
				ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.MyActivityData;
			}
		}

		// Token: 0x060374E7 RID: 226535 RVA: 0x00F72030 File Offset: 0x00F70230
		[NullableContext(1)]
		public DangoBrawlSettleRoleBagDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060374E8 RID: 226536 RVA: 0x00F7203C File Offset: 0x00F7023C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickTipsMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060374E9 RID: 226537 RVA: 0x00F721F0 File Offset: 0x00F703F0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlSettleRoleBagDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlSettleRoleBagDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374EA RID: 226538 RVA: 0x00F72233 File Offset: 0x00F70433
		protected override void OnBeforeShow()
		{
			this.RefreshInfo().Forget();
		}

		// Token: 0x060374EB RID: 226539 RVA: 0x00F72240 File Offset: 0x00F70440
		private UniTask RefreshInfo()
		{
			DangoBrawlSettleRoleBagDetailView.<RefreshInfo>d__11 <RefreshInfo>d__;
			<RefreshInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInfo>d__.<>4__this = this;
			<RefreshInfo>d__.<>1__state = -1;
			<RefreshInfo>d__.<>t__builder.Start<DangoBrawlSettleRoleBagDetailView.<RefreshInfo>d__11>(ref <RefreshInfo>d__);
			return <RefreshInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060374EC RID: 226540 RVA: 0x00F72284 File Offset: 0x00F70484
		private void RefreshRoleIcon(int roleConfigId)
		{
			if (roleConfigId <= 0)
			{
				return;
			}
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleConfigId);
			if (roleConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(roleConfigById.Value.RoleBigIcon, base.GetTexture(5), null, null);
		}

		// Token: 0x060374ED RID: 226541 RVA: 0x00F722D4 File Offset: 0x00F704D4
		[NullableContext(1)]
		private void OnBackpackItemClick(DangoBrawlOutBackpackItemBase item)
		{
			if (this.ItemTips == null || item.MyItemData == null)
			{
				return;
			}
			this.ItemTips.RefreshAndShow(new DangoBrawlItemTipsData
			{
				ItemId = item.MyItemData.MyConfigId,
				From = EDangoBrawlItemTipsFrom.Fixed,
				GridItem = item.GetRootItem(),
				GridSize = new float?(108.8f),
				ShowCombine = new bool?(true),
				OperationMode = EDangoBrawlTipsOperationMode.Selected
			}).Forget();
		}

		// Token: 0x060374EE RID: 226542 RVA: 0x00F7234E File Offset: 0x00F7054E
		[NullableContext(1)]
		private void OnItemTipsCombineInfoClick(DangoBrawlItemTipsData data)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = data.ItemId,
				AllowCombine = false,
				UseActData = false,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x060374EF RID: 226543 RVA: 0x00F7238D File Offset: 0x00F7058D
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x060374F0 RID: 226544 RVA: 0x00F723A0 File Offset: 0x00F705A0
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060374F1 RID: 226545 RVA: 0x00F723A9 File Offset: 0x00F705A9
		private void OnClickTipsMask()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlOutBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return;
			}
			backpackPanel.ClearItemSelected();
		}

		// Token: 0x0401D375 RID: 119669
		private const float GRID_SIZE_DIST = 0.8f;

		// Token: 0x0401D376 RID: 119670
		private const float FINAL_GRID_SIZE = 108.8f;

		// Token: 0x0401D377 RID: 119671
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x0401D378 RID: 119672
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0200B3C8 RID: 46024
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037971 RID: 227697
			BtnCloseMask,
			// Token: 0x04037972 RID: 227698
			BtnClose,
			// Token: 0x04037973 RID: 227699
			BackpackPanel,
			// Token: 0x04037974 RID: 227700
			TxtPrice,
			// Token: 0x04037975 RID: 227701
			TxtWeight,
			// Token: 0x04037976 RID: 227702
			TexRole,
			// Token: 0x04037977 RID: 227703
			BtnTipsMask,
			// Token: 0x04037978 RID: 227704
			BackpackTips
		}
	}
}
