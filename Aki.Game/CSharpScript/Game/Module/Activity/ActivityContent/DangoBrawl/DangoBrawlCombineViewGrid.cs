using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200573D RID: 22333
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCombineViewGrid : GridProxyAbstract<DangoBrawlCombineViewGridData>
	{
		// Token: 0x17006A47 RID: 27207
		// (get) Token: 0x06036FF5 RID: 225269 RVA: 0x00F591D8 File Offset: 0x00F573D8
		public int ItemId
		{
			get
			{
				DangoBrawlCombineViewGridData data = this.Data;
				if (data == null)
				{
					return 0;
				}
				return data.ItemId;
			}
		}

		// Token: 0x06036FF6 RID: 225270 RVA: 0x00F591EC File Offset: 0x00F573EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036FF7 RID: 225271 RVA: 0x00F5937C File Offset: 0x00F5757C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineViewGrid.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineViewGrid.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FF8 RID: 225272 RVA: 0x00F593BF File Offset: 0x00F575BF
		protected override void OnBeforeDestroy()
		{
			this.BlurGridPool.Clear();
		}

		// Token: 0x06036FF9 RID: 225273 RVA: 0x00F593CC File Offset: 0x00F575CC
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x06036FFA RID: 225274 RVA: 0x00F593F2 File Offset: 0x00F575F2
		[NullableContext(1)]
		public override void Refresh(DangoBrawlCombineViewGridData data, bool isSelected, int gridIndex)
		{
			this.RefreshByGridData(data);
		}

		// Token: 0x06036FFB RID: 225275 RVA: 0x00F593FC File Offset: 0x00F575FC
		[NullableContext(1)]
		public void RefreshByGridData(DangoBrawlCombineViewGridData data)
		{
			this.Data = data;
			DangoBrawlItem value = DangoBrawlConfig.Instance.GetItemConfigById(data.ItemId).Value;
			int quality = value.Quality;
			string iconHandBook = value.IconHandBook;
			bool isSpeItem = value.IsSpeItem;
			string handBookSmallItemIcon = DangoBrawlConfig.Instance.GetItemQualityConfigById(quality).Value.HandBookSmallItemIcon;
			base.SetTextureByPath(handBookSmallItemIcon, base.GetTexture(0), null, null);
			base.SetTextureByPath(iconHandBook, base.GetTexture(1), null, null);
			DangoBrawlViewCost costItem = this.CostItem;
			if (costItem != null)
			{
				costItem.BindData(data.ItemId);
			}
			base.GetItem(6).SetUIActive(data.IsExist);
			base.GetItem(7).SetUIActive(data.IsShop.GetValueOrDefault());
			base.GetItem(9).SetUIActive(isSpeItem);
			Func<int, bool> isSelected = this.IsSelected;
			this.SetSelected(isSelected != null && isSelected(data.ItemId));
			PanelPos[] posList = DangoBrawlUtil.RotatePanelPosList(data.ItemId, EDangoBrawlRotate.Direction0);
			this.RefreshBlurGrids(posList);
		}

		// Token: 0x06036FFC RID: 225276 RVA: 0x00F59518 File Offset: 0x00F57718
		[NullableContext(1)]
		private void RefreshBlurGrids(PanelPos[] posList)
		{
			UUISprite sprite = base.GetSprite(3);
			UUIItem item = base.GetItem(2);
			if (sprite == null || item == null)
			{
				return;
			}
			float height = sprite.GetHeight();
			FVector relativeLocation = sprite.RelativeLocation;
			ValueTuple<int, int, int, int> panelPosBound = DangoBrawlUtil.GetPanelPosBound(posList);
			int item2 = panelPosBound.Item2;
			int item3 = panelPosBound.Item3;
			FVector fvector = new FVector((float)(-(float)item2) * height, (float)item3 * height, 0f);
			sprite.SetUIActive(false);
			for (int i = 0; i < posList.Length; i++)
			{
				PanelPos panelPos = posList[i];
				FVector fvector2 = new FVector((float)panelPos.ColIndex * height, (float)(-(float)panelPos.RowIndex) * height, 0f);
				FVector fvector3 = relativeLocation + fvector2;
				FVector uirelativeLocation = fvector3 + fvector;
				UUIItem uuiitem = (i < this.BlurGridPool.Count) ? this.BlurGridPool[i] : null;
				if (uuiitem == null)
				{
					uuiitem = LguiUtil.Instance.CopyItem(sprite, item);
					this.BlurGridPool.Add(uuiitem);
				}
				uuiitem.SetUIActive(true);
				uuiitem.SetUIRelativeLocation(uirelativeLocation);
			}
			for (int j = posList.Length; j < this.BlurGridPool.Count; j++)
			{
				this.BlurGridPool[j].SetUIActive(false);
			}
		}

		// Token: 0x06036FFD RID: 225277 RVA: 0x00F59656 File Offset: 0x00F57856
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x06036FFE RID: 225278 RVA: 0x00F5965F File Offset: 0x00F5785F
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x06036FFF RID: 225279 RVA: 0x00F59668 File Offset: 0x00F57868
		public void SetSelected(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06037000 RID: 225280 RVA: 0x00F59694 File Offset: 0x00F57894
		public UUIItem GetNavigationItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.RootUIComp.Get();
		}

		// Token: 0x06037001 RID: 225281 RVA: 0x00F596BB File Offset: 0x00F578BB
		private void OnToggleClick(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (this.Data == null || this.Data.ItemId <= 0)
			{
				return;
			}
			Action<int, UUIItem> onGridClick = this.OnGridClick;
			if (onGridClick == null)
			{
				return;
			}
			onGridClick(this.Data.ItemId, this.GetNavigationItem());
		}

		// Token: 0x0401D1B8 RID: 119224
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x0401D1B9 RID: 119225
		public Func<int, bool> IsSelected;

		// Token: 0x0401D1BA RID: 119226
		private DangoBrawlViewCost CostItem;

		// Token: 0x0401D1BB RID: 119227
		private DangoBrawlCombineViewGridData Data;

		// Token: 0x0401D1BC RID: 119228
		[Nullable(1)]
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0200B2F7 RID: 45815
		[NullableContext(0)]
		private enum EHandBookItemComponent
		{
			// Token: 0x040374A5 RID: 226469
			TexQuality,
			// Token: 0x040374A6 RID: 226470
			TexIcon,
			// Token: 0x040374A7 RID: 226471
			GridContent,
			// Token: 0x040374A8 RID: 226472
			SprGrid,
			// Token: 0x040374A9 RID: 226473
			TogItem,
			// Token: 0x040374AA RID: 226474
			CostItem,
			// Token: 0x040374AB RID: 226475
			FinishItem,
			// Token: 0x040374AC RID: 226476
			ShopItem,
			// Token: 0x040374AD RID: 226477
			Num,
			// Token: 0x040374AE RID: 226478
			UniqueWeaponItem
		}
	}
}
