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
	// Token: 0x020067ED RID: 26605
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCombineViewGrid : GridProxyAbstract<DangoBrawlCombineViewGridData>
	{
		// Token: 0x17009706 RID: 38662
		// (get) Token: 0x060424A0 RID: 271520 RVA: 0x01017D22 File Offset: 0x01015F22
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

		// Token: 0x060424A1 RID: 271521 RVA: 0x01017D38 File Offset: 0x01015F38
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

		// Token: 0x060424A2 RID: 271522 RVA: 0x01017EC8 File Offset: 0x010160C8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineViewGrid.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineViewGrid.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060424A3 RID: 271523 RVA: 0x01017F0B File Offset: 0x0101610B
		protected override void OnBeforeDestroy()
		{
			this.BlurGridPool.Clear();
		}

		// Token: 0x060424A4 RID: 271524 RVA: 0x01017F18 File Offset: 0x01016118
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x060424A5 RID: 271525 RVA: 0x01017F3E File Offset: 0x0101613E
		[NullableContext(1)]
		public override void Refresh(DangoBrawlCombineViewGridData data, bool isSelected, int gridIndex)
		{
			this.RefreshByGridData(data);
		}

		// Token: 0x060424A6 RID: 271526 RVA: 0x01017F48 File Offset: 0x01016148
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

		// Token: 0x060424A7 RID: 271527 RVA: 0x01018064 File Offset: 0x01016264
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

		// Token: 0x060424A8 RID: 271528 RVA: 0x010181A2 File Offset: 0x010163A2
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x060424A9 RID: 271529 RVA: 0x010181AB File Offset: 0x010163AB
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x060424AA RID: 271530 RVA: 0x010181B4 File Offset: 0x010163B4
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

		// Token: 0x060424AB RID: 271531 RVA: 0x010181E0 File Offset: 0x010163E0
		public UUIItem GetNavigationItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.RootUIComp.Get();
		}

		// Token: 0x060424AC RID: 271532 RVA: 0x01018207 File Offset: 0x01016407
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

		// Token: 0x0402295B RID: 141659
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x0402295C RID: 141660
		public Func<int, bool> IsSelected;

		// Token: 0x0402295D RID: 141661
		private DangoBrawlViewCost CostItem;

		// Token: 0x0402295E RID: 141662
		private DangoBrawlCombineViewGridData Data;

		// Token: 0x0402295F RID: 141663
		[Nullable(1)]
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0200C929 RID: 51497
		[NullableContext(0)]
		private enum EHandBookItemComponent
		{
			// Token: 0x0403CBB4 RID: 248756
			TexQuality,
			// Token: 0x0403CBB5 RID: 248757
			TexIcon,
			// Token: 0x0403CBB6 RID: 248758
			GridContent,
			// Token: 0x0403CBB7 RID: 248759
			SprGrid,
			// Token: 0x0403CBB8 RID: 248760
			TogItem,
			// Token: 0x0403CBB9 RID: 248761
			CostItem,
			// Token: 0x0403CBBA RID: 248762
			FinishItem,
			// Token: 0x0403CBBB RID: 248763
			ShopItem,
			// Token: 0x0403CBBC RID: 248764
			Num,
			// Token: 0x0403CBBD RID: 248765
			UniqueWeaponItem
		}
	}
}
