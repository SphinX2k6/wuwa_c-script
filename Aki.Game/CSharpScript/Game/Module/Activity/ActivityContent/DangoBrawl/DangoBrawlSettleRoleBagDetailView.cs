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
	// Token: 0x0200683A RID: 26682
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlSettleRoleBagDetailView : UiViewBase
	{
		// Token: 0x1700974D RID: 38733
		// (get) Token: 0x06042992 RID: 272786 RVA: 0x01030B12 File Offset: 0x0102ED12
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

		// Token: 0x06042993 RID: 272787 RVA: 0x01030B24 File Offset: 0x0102ED24
		[NullableContext(1)]
		public DangoBrawlSettleRoleBagDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042994 RID: 272788 RVA: 0x01030B30 File Offset: 0x0102ED30
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

		// Token: 0x06042995 RID: 272789 RVA: 0x01030CE4 File Offset: 0x0102EEE4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlSettleRoleBagDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlSettleRoleBagDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042996 RID: 272790 RVA: 0x01030D27 File Offset: 0x0102EF27
		protected override void OnBeforeShow()
		{
			this.RefreshInfo().Forget();
		}

		// Token: 0x06042997 RID: 272791 RVA: 0x01030D34 File Offset: 0x0102EF34
		private UniTask RefreshInfo()
		{
			DangoBrawlSettleRoleBagDetailView.<RefreshInfo>d__11 <RefreshInfo>d__;
			<RefreshInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInfo>d__.<>4__this = this;
			<RefreshInfo>d__.<>1__state = -1;
			<RefreshInfo>d__.<>t__builder.Start<DangoBrawlSettleRoleBagDetailView.<RefreshInfo>d__11>(ref <RefreshInfo>d__);
			return <RefreshInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06042998 RID: 272792 RVA: 0x01030D78 File Offset: 0x0102EF78
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

		// Token: 0x06042999 RID: 272793 RVA: 0x01030DC8 File Offset: 0x0102EFC8
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

		// Token: 0x0604299A RID: 272794 RVA: 0x01030E42 File Offset: 0x0102F042
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

		// Token: 0x0604299B RID: 272795 RVA: 0x01030E81 File Offset: 0x0102F081
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x0604299C RID: 272796 RVA: 0x01030E94 File Offset: 0x0102F094
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604299D RID: 272797 RVA: 0x01030E9D File Offset: 0x0102F09D
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

		// Token: 0x04022B18 RID: 142104
		private const float GRID_SIZE_DIST = 0.8f;

		// Token: 0x04022B19 RID: 142105
		private const float FINAL_GRID_SIZE = 108.8f;

		// Token: 0x04022B1A RID: 142106
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x04022B1B RID: 142107
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0200C9FC RID: 51708
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403D088 RID: 249992
			BtnCloseMask,
			// Token: 0x0403D089 RID: 249993
			BtnClose,
			// Token: 0x0403D08A RID: 249994
			BackpackPanel,
			// Token: 0x0403D08B RID: 249995
			TxtPrice,
			// Token: 0x0403D08C RID: 249996
			TxtWeight,
			// Token: 0x0403D08D RID: 249997
			TexRole,
			// Token: 0x0403D08E RID: 249998
			BtnTipsMask,
			// Token: 0x0403D08F RID: 249999
			BackpackTips
		}
	}
}
