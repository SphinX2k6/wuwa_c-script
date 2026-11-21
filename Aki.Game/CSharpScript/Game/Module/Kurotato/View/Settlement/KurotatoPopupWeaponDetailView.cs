using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.Overview;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x020046FC RID: 18172
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupWeaponDetailView : UiViewBase
	{
		// Token: 0x0602DA9A RID: 187034 RVA: 0x00CC42DB File Offset: 0x00CC24DB
		public KurotatoPopupWeaponDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DA9B RID: 187035 RVA: 0x00CC42FC File Offset: 0x00CC24FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DA9C RID: 187036 RVA: 0x00CC446C File Offset: 0x00CC266C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupWeaponDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupWeaponDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DA9D RID: 187037 RVA: 0x00CC44B0 File Offset: 0x00CC26B0
		private UniTask CreateWeaponTipAsync()
		{
			KurotatoPopupWeaponDetailView.<CreateWeaponTipAsync>d__9 <CreateWeaponTipAsync>d__;
			<CreateWeaponTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTipAsync>d__.<>4__this = this;
			<CreateWeaponTipAsync>d__.<>1__state = -1;
			<CreateWeaponTipAsync>d__.<>t__builder.Start<KurotatoPopupWeaponDetailView.<CreateWeaponTipAsync>d__9>(ref <CreateWeaponTipAsync>d__);
			return <CreateWeaponTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DA9E RID: 187038 RVA: 0x00CC44F4 File Offset: 0x00CC26F4
		protected override void OnStart()
		{
			this.CreateWeaponScrollList();
			IKurotatoPopupItemDetailOpenParam kurotatoPopupItemDetailOpenParam = (IKurotatoPopupItemDetailOpenParam)this.OpenParam;
			this.CardData = kurotatoPopupItemDetailOpenParam.CardData;
			this.Index = kurotatoPopupItemDetailOpenParam.Index;
			this.RefreshScrollList();
			this.RefreshArrows();
		}

		// Token: 0x0602DA9F RID: 187039 RVA: 0x00CC4537 File Offset: 0x00CC2737
		private void CreateWeaponScrollList()
		{
			this.WeaponScrollList = new GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetScrollViewWithScrollbar(4), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(false);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, null);
		}

		// Token: 0x0602DAA0 RID: 187040 RVA: 0x00CC455C File Offset: 0x00CC275C
		private void RefreshScrollList()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			List<IKurotatoSmallItemGridData> list = new List<IKurotatoSmallItemGridData>();
			foreach (KurotatoCardTip kurotatoCardTip in this.CardData)
			{
				list.Add(new KurotatoSmallItemGridData
				{
					Type = kurotatoCardTip.CardType,
					Id = (kurotatoCardTip.IsConfigId.GetValueOrDefault() ? kurotatoCardTip.SelectId : instance.GetWeaponDataByIncId(kurotatoCardTip.SelectId).WeaponId),
					IncId = kurotatoCardTip.SelectId,
					Count = 0
				});
			}
			this.WeaponScrollList.RefreshByData(list, delegate
			{
				this.RefreshItemTip();
			}, false);
		}

		// Token: 0x0602DAA1 RID: 187041 RVA: 0x00CC4628 File Offset: 0x00CC2828
		private void RefreshItemTip()
		{
			this.Index = Math.Max(0, Math.Min(this.Index, this.CardData.Count - 1));
			if (this.CardData.Count == 0)
			{
				return;
			}
			KurotatoWeaponSmallItemGrid selectItem = this.SelectItem;
			if (selectItem != null)
			{
				selectItem.SetSelected(false, false);
			}
			this.SelectItem = this.WeaponScrollList.GetScrollItemByIndex(this.Index);
			UUIItem itemByIndex = this.WeaponScrollList.GetItemByIndex(this.Index);
			this.ItemTip.Refresh(this.CardData[this.Index].CardType, this.CardData[this.Index].SelectId, true, false, null);
			KurotatoWeaponSmallItemGrid selectItem2 = this.SelectItem;
			if (selectItem2 != null)
			{
				selectItem2.SetSelected(true, false);
			}
			if (itemByIndex != null)
			{
				this.WeaponScrollList.LateScrollTo(itemByIndex, null, false);
			}
			this.RefreshArrows();
		}

		// Token: 0x0602DAA2 RID: 187042 RVA: 0x00CC4710 File Offset: 0x00CC2910
		private void RefreshArrows()
		{
			bool uiactive = this.CardData.Count > 1;
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(uiactive);
				}
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(uiactive);
		}

		// Token: 0x0602DAA3 RID: 187043 RVA: 0x00CC4776 File Offset: 0x00CC2976
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DAA4 RID: 187044 RVA: 0x00CC477F File Offset: 0x00CC297F
		private void OnClickLeft()
		{
			if (this.CardData.Count <= 1)
			{
				return;
			}
			this.Index = ((this.Index <= 0) ? (this.CardData.Count - 1) : (this.Index - 1));
			this.RefreshItemTip();
		}

		// Token: 0x0602DAA5 RID: 187045 RVA: 0x00CC47BC File Offset: 0x00CC29BC
		private void OnClickRight()
		{
			if (this.CardData.Count <= 1)
			{
				return;
			}
			this.Index = ((this.Index >= this.CardData.Count - 1) ? 0 : (this.Index + 1));
			this.RefreshItemTip();
		}

		// Token: 0x0602DAA6 RID: 187046 RVA: 0x00CC47F9 File Offset: 0x00CC29F9
		private void OnClickGrid(IKurotatoSmallItemGridData data, EToggleState state, int gridIndex)
		{
			if (state == EToggleState.ETT_Checked)
			{
				KurotatoWeaponSmallItemGrid selectItem = this.SelectItem;
				if (selectItem != null)
				{
					selectItem.SetSelected(false, false);
				}
				this.Index = gridIndex;
				this.RefreshItemTip();
			}
		}

		// Token: 0x040186CC RID: 100044
		private readonly KurotatoItemInfoTipPanel ItemTip = new KurotatoItemInfoTipPanel();

		// Token: 0x040186CD RID: 100045
		private List<KurotatoCardTip> CardData = new List<KurotatoCardTip>();

		// Token: 0x040186CE RID: 100046
		private int Index;

		// Token: 0x040186CF RID: 100047
		[Nullable(2)]
		private KurotatoWeaponSmallItemGrid SelectItem;

		// Token: 0x040186D0 RID: 100048
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponScrollList;

		// Token: 0x0200A303 RID: 41731
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040328DD RID: 207069
			public const int BtnClose = 0;

			// Token: 0x040328DE RID: 207070
			public const int TipItem = 1;

			// Token: 0x040328DF RID: 207071
			public const int BtnLeft = 2;

			// Token: 0x040328E0 RID: 207072
			public const int BtnRight = 3;

			// Token: 0x040328E1 RID: 207073
			public const int ScrollView = 4;

			// Token: 0x040328E2 RID: 207074
			public const int ItemGrid = 5;
		}
	}
}
