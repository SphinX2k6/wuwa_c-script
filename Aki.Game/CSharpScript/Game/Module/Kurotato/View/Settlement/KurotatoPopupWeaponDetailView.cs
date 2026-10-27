using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005725 RID: 22309
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupWeaponDetailView : UiViewBase
	{
		// Token: 0x06038B8B RID: 232331 RVA: 0x00D75CA7 File Offset: 0x00D73EA7
		public KurotatoPopupWeaponDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038B8C RID: 232332 RVA: 0x00D75CC8 File Offset: 0x00D73EC8
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

		// Token: 0x06038B8D RID: 232333 RVA: 0x00D75E38 File Offset: 0x00D74038
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupWeaponDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupWeaponDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B8E RID: 232334 RVA: 0x00D75E7C File Offset: 0x00D7407C
		private UniTask CreateWeaponTipAsync()
		{
			KurotatoPopupWeaponDetailView.<CreateWeaponTipAsync>d__9 <CreateWeaponTipAsync>d__;
			<CreateWeaponTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTipAsync>d__.<>4__this = this;
			<CreateWeaponTipAsync>d__.<>1__state = -1;
			<CreateWeaponTipAsync>d__.<>t__builder.Start<KurotatoPopupWeaponDetailView.<CreateWeaponTipAsync>d__9>(ref <CreateWeaponTipAsync>d__);
			return <CreateWeaponTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B8F RID: 232335 RVA: 0x00D75EC0 File Offset: 0x00D740C0
		protected override void OnStart()
		{
			this.CreateWeaponScrollList();
			IKurotatoPopupItemDetailOpenParam kurotatoPopupItemDetailOpenParam = (IKurotatoPopupItemDetailOpenParam)this.OpenParam;
			this.CardData = kurotatoPopupItemDetailOpenParam.CardData;
			this.Index = kurotatoPopupItemDetailOpenParam.Index;
			this.RefreshScrollList();
			this.RefreshArrows();
		}

		// Token: 0x06038B90 RID: 232336 RVA: 0x00D75F03 File Offset: 0x00D74103
		private void CreateWeaponScrollList()
		{
			this.WeaponScrollList = new GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetScrollViewWithScrollbar(4), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(false);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, null);
		}

		// Token: 0x06038B91 RID: 232337 RVA: 0x00D75F28 File Offset: 0x00D74128
		private void RefreshScrollList()
		{
			KurotatoModel modelData = KurotatoModel.Instance;
			List<IKurotatoSmallItemGridData> data = (from item in this.CardData
			select new KurotatoSmallItemGridData
			{
				Type = item.CardType,
				Id = (item.IsConfigId.GetValueOrDefault() ? item.SelectId : modelData.GetWeaponDataByIncId(item.SelectId).WeaponId),
				IncId = item.SelectId,
				Count = 0
			}).ToList<IKurotatoSmallItemGridData>();
			this.WeaponScrollList.RefreshByData(data, delegate
			{
				this.RefreshItemTip();
			}, false);
		}

		// Token: 0x06038B92 RID: 232338 RVA: 0x00D75F84 File Offset: 0x00D74184
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

		// Token: 0x06038B93 RID: 232339 RVA: 0x00D7606C File Offset: 0x00D7426C
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

		// Token: 0x06038B94 RID: 232340 RVA: 0x00D760D2 File Offset: 0x00D742D2
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038B95 RID: 232341 RVA: 0x00D760DB File Offset: 0x00D742DB
		private void OnClickLeft()
		{
			if (this.CardData.Count <= 1)
			{
				return;
			}
			this.Index = ((this.Index <= 0) ? (this.CardData.Count - 1) : (this.Index - 1));
			this.RefreshItemTip();
		}

		// Token: 0x06038B96 RID: 232342 RVA: 0x00D76118 File Offset: 0x00D74318
		private void OnClickRight()
		{
			if (this.CardData.Count <= 1)
			{
				return;
			}
			this.Index = ((this.Index >= this.CardData.Count - 1) ? 0 : (this.Index + 1));
			this.RefreshItemTip();
		}

		// Token: 0x06038B97 RID: 232343 RVA: 0x00D76155 File Offset: 0x00D74355
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

		// Token: 0x0401DC36 RID: 121910
		private readonly KurotatoItemInfoTipPanel ItemTip = new KurotatoItemInfoTipPanel();

		// Token: 0x0401DC37 RID: 121911
		private List<KurotatoCardTip> CardData = new List<KurotatoCardTip>();

		// Token: 0x0401DC38 RID: 121912
		private int Index;

		// Token: 0x0401DC39 RID: 121913
		[Nullable(2)]
		private KurotatoWeaponSmallItemGrid SelectItem;

		// Token: 0x0401DC3A RID: 121914
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponScrollList;

		// Token: 0x0200B8E1 RID: 47329
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037ECB RID: 229067
			public const int BtnClose = 0;

			// Token: 0x04037ECC RID: 229068
			public const int TipItem = 1;

			// Token: 0x04037ECD RID: 229069
			public const int BtnLeft = 2;

			// Token: 0x04037ECE RID: 229070
			public const int BtnRight = 3;

			// Token: 0x04037ECF RID: 229071
			public const int ScrollView = 4;

			// Token: 0x04037ED0 RID: 229072
			public const int ItemGrid = 5;
		}
	}
}
