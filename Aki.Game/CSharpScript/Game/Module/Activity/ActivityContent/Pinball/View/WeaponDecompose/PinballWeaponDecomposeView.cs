using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.WeaponDecompose
{
	// Token: 0x020062E9 RID: 25321
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponDecomposeView : UiViewBase
	{
		// Token: 0x0603FB5A RID: 260954 RVA: 0x00F6A0F4 File Offset: 0x00F682F4
		public PinballWeaponDecomposeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FB5B RID: 260955 RVA: 0x00F6A128 File Offset: 0x00F68328
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnClickAllSelectToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FB5C RID: 260956 RVA: 0x00F6A320 File Offset: 0x00F68520
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponDecomposeView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB5D RID: 260957 RVA: 0x00F6A363 File Offset: 0x00F68563
		protected override void OnStart()
		{
			this.InitScroll();
			this.FilterSortEntrance = new FilterSortEntrance<PinballWeaponData>(base.GetItem(3), delegate(List<PinballWeaponData> list, bool isOutSideChange, EFilterSortType operationType)
			{
				this.OnFilterSortRefresh(list);
			});
			UUIExtendToggle extendToggle = base.GetExtendToggle(10);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603FB5E RID: 260958 RVA: 0x00F6A39F File Offset: 0x00F6859F
		private void InitScroll()
		{
			this.LoopScroll = new LoopScrollView<PinballItemWeaponGridView, PinballWeaponData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PinballItemWeaponGridView>(this.CreateGrid), false);
		}

		// Token: 0x0603FB5F RID: 260959 RVA: 0x00F6A3D4 File Offset: 0x00F685D4
		private PinballItemWeaponGridView CreateGrid()
		{
			PinballItemWeaponGridView pinballItemWeaponGridView = new PinballItemWeaponGridView();
			pinballItemWeaponGridView.BindOnExtendToggleClicked(new Action<IPinballItemToggleCallback>(this.ShowCurrentSelectedWeaponInfo));
			pinballItemWeaponGridView.BindReduceButtonCallback(new Func<IPinballItemButtonCallback, bool>(this.ReduceFunction));
			pinballItemWeaponGridView.BindOnStateChangeCallback(delegate(IPinballItemToggleCallback x)
			{
				this.AddFunction(x);
			});
			pinballItemWeaponGridView.BindOnCanExecuteChangeCallback(new Func<IPinballItemToggleCallback, bool>(this.OnCanExecuteChange));
			pinballItemWeaponGridView.BindFocusListenerDelegate(new Action<IPinballItemToggleCallback>(this.ShowCurrentSelectedWeaponInfo));
			return pinballItemWeaponGridView;
		}

		// Token: 0x0603FB60 RID: 260960 RVA: 0x00F6A440 File Offset: 0x00F68640
		protected override void OnBeforeShow()
		{
			this.RefreshList();
			this.RefreshWeaponInfo();
			this.RefreshPreviewItemAsync().Forget();
		}

		// Token: 0x0603FB61 RID: 260961 RVA: 0x00F6A45C File Offset: 0x00F6865C
		private void RefreshList()
		{
			List<PinballWeaponData> allWeaponDataList = PinballModel.Instance.GetAllWeaponDataList();
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(11), "Pinball_Weapon_Salvage_amount01", new <>z__ReadOnlySingleElementList<object>(allWeaponDataList.Count));
			FilterSortEntrance<PinballWeaponData> filterSortEntrance = this.FilterSortEntrance;
			if (filterSortEntrance == null)
			{
				return;
			}
			filterSortEntrance.UpdateData(EFilterSortGroupId.PinballWeaponDecompose, allWeaponDataList, Array.Empty<object>());
		}

		// Token: 0x0603FB62 RID: 260962 RVA: 0x00F6A4B3 File Offset: 0x00F686B3
		private void OnFilterSortRefresh(List<PinballWeaponData> list)
		{
			this.DataList = list;
			LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> loopScroll = this.LoopScroll;
			if (loopScroll == null)
			{
				return;
			}
			loopScroll.RefreshByData(this.DataList, false, null, true);
		}

		// Token: 0x0603FB63 RID: 260963 RVA: 0x00F6A4D5 File Offset: 0x00F686D5
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x0603FB64 RID: 260964 RVA: 0x00F6A4F3 File Offset: 0x00F686F3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x0603FB65 RID: 260965 RVA: 0x00F6A514 File Offset: 0x00F68714
		private void OnClickAllSelectToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				using (List<PinballWeaponData>.Enumerator enumerator = this.DataList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PinballWeaponData pinballWeaponData = enumerator.Current;
						if (this.CanAddItem(pinballWeaponData.IncId, false))
						{
							this.AddSelection(pinballWeaponData.IncId);
						}
					}
					goto IL_54;
				}
			}
			this.ClearSelection();
			IL_54:
			LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> loopScroll = this.LoopScroll;
			if (loopScroll != null)
			{
				loopScroll.UpdateData(this.DataList);
			}
			this.RefreshPreviewItemAsync().Forget();
		}

		// Token: 0x0603FB66 RID: 260966 RVA: 0x00F6A5A8 File Offset: 0x00F687A8
		private UniTask RefreshPreviewItemAsync()
		{
			PinballWeaponDecomposeView.<RefreshPreviewItemAsync>d__25 <RefreshPreviewItemAsync>d__;
			<RefreshPreviewItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPreviewItemAsync>d__.<>4__this = this;
			<RefreshPreviewItemAsync>d__.<>1__state = -1;
			<RefreshPreviewItemAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<RefreshPreviewItemAsync>d__25>(ref <RefreshPreviewItemAsync>d__);
			return <RefreshPreviewItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB67 RID: 260967 RVA: 0x00F6A5EC File Offset: 0x00F687EC
		private void RefreshWeaponInfo()
		{
			if (this.CurrentSelectedIncId == -1)
			{
				UUIText text = base.GetText(5);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				PinballWeaponTipsTopView tipsTopView = this.TipsTopView;
				if (tipsTopView != null)
				{
					tipsTopView.Hide(null);
				}
				PinballWeaponAttrView attrView = this.AttrView;
				if (attrView == null)
				{
					return;
				}
				attrView.Hide(null);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(this.CurrentSelectedIncId);
				if (weaponDataByIncId == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PinballBattle;
					ELogAuthor author = ELogAuthor.CB;
					string message = "找不到武器数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentSelectedIncId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				PinballWeaponTipsTopView tipsTopView2 = this.TipsTopView;
				if (tipsTopView2 != null)
				{
					tipsTopView2.Refresh(weaponDataByIncId);
				}
				PinballWeaponTipsTopView tipsTopView3 = this.TipsTopView;
				if (tipsTopView3 != null)
				{
					tipsTopView3.Show(null);
				}
				PinballWeaponAttrView attrView2 = this.AttrView;
				if (attrView2 != null)
				{
					attrView2.Refresh(weaponDataByIncId);
				}
				PinballWeaponAttrView attrView3 = this.AttrView;
				if (attrView3 == null)
				{
					return;
				}
				attrView3.Show(null);
				return;
			}
		}

		// Token: 0x0603FB68 RID: 260968 RVA: 0x00F6A6DC File Offset: 0x00F688DC
		private void OnClickBtnConfirm()
		{
			if (this.Selection.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_NotEnoughItem_Text", Array.Empty<object>());
				return;
			}
			this.RequestWeaponDecomposeAsync().Forget();
		}

		// Token: 0x0603FB69 RID: 260969 RVA: 0x00F6A70C File Offset: 0x00F6890C
		private UniTask RequestWeaponDecomposeAsync()
		{
			PinballWeaponDecomposeView.<RequestWeaponDecomposeAsync>d__28 <RequestWeaponDecomposeAsync>d__;
			<RequestWeaponDecomposeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestWeaponDecomposeAsync>d__.<>4__this = this;
			<RequestWeaponDecomposeAsync>d__.<>1__state = -1;
			<RequestWeaponDecomposeAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<RequestWeaponDecomposeAsync>d__28>(ref <RequestWeaponDecomposeAsync>d__);
			return <RequestWeaponDecomposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB6A RID: 260970 RVA: 0x00F6A750 File Offset: 0x00F68950
		private void OnPinballWeaponLockChanged(int incId, bool bLock)
		{
			if (bLock)
			{
				this.RemoveSelection(incId);
			}
			int gridIndex = -1;
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].IncId == incId)
				{
					gridIndex = i;
					break;
				}
			}
			LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> loopScroll = this.LoopScroll;
			if (loopScroll != null)
			{
				loopScroll.RefreshGridProxy(gridIndex);
			}
			this.RefreshPreviewItemAsync().Forget();
		}

		// Token: 0x0603FB6B RID: 260971 RVA: 0x00F6A7B4 File Offset: 0x00F689B4
		protected bool OnCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			int incId = ((IPinballItemDataWeapon)callbackParameter.Data).IncId;
			return this.CanAddItem(incId, true);
		}

		// Token: 0x0603FB6C RID: 260972 RVA: 0x00F6A7DC File Offset: 0x00F689DC
		protected bool AddFunction(IPinballItemToggleCallback @params)
		{
			int incId = ((IPinballItemDataWeapon)@params.Data).IncId;
			this.AddSelection(incId);
			@params.View.RefreshReduceBtnComponent(true).Forget();
			this.RefreshPreviewItemAsync().Forget();
			return true;
		}

		// Token: 0x0603FB6D RID: 260973 RVA: 0x00F6A820 File Offset: 0x00F68A20
		private void ShowCurrentSelectedWeaponInfo(IPinballItemToggleCallback @params)
		{
			this.CurrentSelectedIncId = ((IPinballItemDataWeapon)@params.Data).IncId;
			this.RefreshWeaponInfo();
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x0603FB6E RID: 260974 RVA: 0x00F6A860 File Offset: 0x00F68A60
		protected bool ReduceFunction(IPinballItemButtonCallback callbackParameter)
		{
			int incId = ((IPinballItemDataWeapon)callbackParameter.Data).IncId;
			this.RemoveSelection(incId);
			callbackParameter.View.RefreshReduceBtnComponent(false).Forget();
			int gridIndex = -1;
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].IncId == incId)
				{
					gridIndex = i;
					break;
				}
			}
			LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> loopScroll = this.LoopScroll;
			if (loopScroll != null)
			{
				loopScroll.RefreshGridProxy(gridIndex);
			}
			this.RefreshPreviewItemAsync().Forget();
			return true;
		}

		// Token: 0x0603FB6F RID: 260975 RVA: 0x00F6A8E4 File Offset: 0x00F68AE4
		private bool CanAddItem(int incId, bool isShowTip)
		{
			PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到武器数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (weaponDataByIncId.GetIsLock())
			{
				if (isShowTip)
				{
					ScrollingTipsController.Instance.ShowTipsById("WeaponLockTipsText", Array.Empty<object>());
				}
				return false;
			}
			if (weaponDataByIncId.RoleId > 0)
			{
				if (isShowTip)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Pinball_Weapon_ArmInfo03", Array.Empty<object>());
				}
				return false;
			}
			if (this.Selection.Count >= 1000)
			{
				if (isShowTip)
				{
					ScrollingTipsController.Instance.ShowTipsById("WeaponFullMaterialText", Array.Empty<object>());
				}
				return false;
			}
			return true;
		}

		// Token: 0x0603FB70 RID: 260976 RVA: 0x00F6A9A0 File Offset: 0x00F68BA0
		private void AddSelection(int incId)
		{
			PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId == null)
			{
				return;
			}
			weaponDataByIncId.IsSelected = true;
			this.Selection.Add(incId);
		}

		// Token: 0x0603FB71 RID: 260977 RVA: 0x00F6A9D4 File Offset: 0x00F68BD4
		private void RemoveSelection(int incId)
		{
			PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId == null)
			{
				return;
			}
			weaponDataByIncId.IsSelected = false;
			this.Selection.Remove(incId);
		}

		// Token: 0x0603FB72 RID: 260978 RVA: 0x00F6AA08 File Offset: 0x00F68C08
		private void ClearSelection()
		{
			foreach (int incId in this.Selection)
			{
				PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(incId);
				if (weaponDataByIncId != null)
				{
					weaponDataByIncId.IsSelected = false;
				}
			}
			this.Selection.Clear();
		}

		// Token: 0x0603FB73 RID: 260979 RVA: 0x00F6AA78 File Offset: 0x00F68C78
		private void OnPreviewItemExtendToggleClicked(IPinballItemToggleCallback callbackParameter)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.PreviewItemData.ItemData.ItemId, true, null);
		}

		// Token: 0x0603FB74 RID: 260980 RVA: 0x00F6AA96 File Offset: 0x00F68C96
		private bool OnPreviewItemCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			return false;
		}

		// Token: 0x0603FB75 RID: 260981 RVA: 0x00F6AA99 File Offset: 0x00F68C99
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FB76 RID: 260982 RVA: 0x00F6AAA2 File Offset: 0x00F68CA2
		protected override void OnBeforeDestroy()
		{
			this.ClearSelection();
		}

		// Token: 0x0402146B RID: 136299
		private int CurrentSelectedIncId = -1;

		// Token: 0x0402146C RID: 136300
		private readonly HashSet<int> Selection = new HashSet<int>();

		// Token: 0x0402146D RID: 136301
		private List<PinballWeaponData> DataList;

		// Token: 0x0402146E RID: 136302
		private LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> LoopScroll;

		// Token: 0x0402146F RID: 136303
		private FilterSortEntrance<PinballWeaponData> FilterSortEntrance;

		// Token: 0x04021470 RID: 136304
		private PinballItemView PreviewItemView;

		// Token: 0x04021471 RID: 136305
		private TItem PreviewItemData = new TItem(new InventoryDefine.GetItemData(89500002, 0), 0);

		// Token: 0x04021472 RID: 136306
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021473 RID: 136307
		private ButtonItem BtnConfirm;

		// Token: 0x04021474 RID: 136308
		private PinballWeaponTipsTopView TipsTopView;

		// Token: 0x04021475 RID: 136309
		private PinballWeaponAttrView AttrView;

		// Token: 0x04021476 RID: 136310
		private const int MAX_SELECT_COUNT = 1000;

		// Token: 0x0200C4D8 RID: 50392
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B66A RID: 243306
			Caption,
			// Token: 0x0403B66B RID: 243307
			LoopScroll,
			// Token: 0x0403B66C RID: 243308
			LoopScrollItem,
			// Token: 0x0403B66D RID: 243309
			SortFilter,
			// Token: 0x0403B66E RID: 243310
			PnlWeapon,
			// Token: 0x0403B66F RID: 243311
			TextEmptyTips,
			// Token: 0x0403B670 RID: 243312
			PnlWeaponAttr,
			// Token: 0x0403B671 RID: 243313
			PreviewItem,
			// Token: 0x0403B672 RID: 243314
			TextSelectedCount,
			// Token: 0x0403B673 RID: 243315
			BtnConfirm,
			// Token: 0x0403B674 RID: 243316
			AllSelectToggle,
			// Token: 0x0403B675 RID: 243317
			TextWeaponCount
		}
	}
}
