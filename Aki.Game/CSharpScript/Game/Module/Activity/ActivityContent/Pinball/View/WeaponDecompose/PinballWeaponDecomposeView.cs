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
	// Token: 0x02005267 RID: 21095
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponDecomposeView : UiViewBase
	{
		// Token: 0x0603481B RID: 215067 RVA: 0x00EB1051 File Offset: 0x00EAF251
		public PinballWeaponDecomposeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603481C RID: 215068 RVA: 0x00EB1084 File Offset: 0x00EAF284
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

		// Token: 0x0603481D RID: 215069 RVA: 0x00EB127C File Offset: 0x00EAF47C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponDecomposeView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603481E RID: 215070 RVA: 0x00EB12BF File Offset: 0x00EAF4BF
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

		// Token: 0x0603481F RID: 215071 RVA: 0x00EB12FB File Offset: 0x00EAF4FB
		private void InitScroll()
		{
			this.LoopScroll = new LoopScrollView<PinballItemWeaponGridView, PinballWeaponData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PinballItemWeaponGridView>(this.CreateGrid), false);
		}

		// Token: 0x06034820 RID: 215072 RVA: 0x00EB1330 File Offset: 0x00EAF530
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

		// Token: 0x06034821 RID: 215073 RVA: 0x00EB139C File Offset: 0x00EAF59C
		protected override void OnBeforeShow()
		{
			this.RefreshList();
			this.RefreshWeaponInfo();
			this.RefreshPreviewItemAsync().Forget();
		}

		// Token: 0x06034822 RID: 215074 RVA: 0x00EB13B8 File Offset: 0x00EAF5B8
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

		// Token: 0x06034823 RID: 215075 RVA: 0x00EB140F File Offset: 0x00EAF60F
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

		// Token: 0x06034824 RID: 215076 RVA: 0x00EB1431 File Offset: 0x00EAF631
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x06034825 RID: 215077 RVA: 0x00EB144F File Offset: 0x00EAF64F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x06034826 RID: 215078 RVA: 0x00EB1470 File Offset: 0x00EAF670
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

		// Token: 0x06034827 RID: 215079 RVA: 0x00EB1504 File Offset: 0x00EAF704
		private UniTask RefreshPreviewItemAsync()
		{
			PinballWeaponDecomposeView.<RefreshPreviewItemAsync>d__25 <RefreshPreviewItemAsync>d__;
			<RefreshPreviewItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPreviewItemAsync>d__.<>4__this = this;
			<RefreshPreviewItemAsync>d__.<>1__state = -1;
			<RefreshPreviewItemAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<RefreshPreviewItemAsync>d__25>(ref <RefreshPreviewItemAsync>d__);
			return <RefreshPreviewItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034828 RID: 215080 RVA: 0x00EB1548 File Offset: 0x00EAF748
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

		// Token: 0x06034829 RID: 215081 RVA: 0x00EB1638 File Offset: 0x00EAF838
		private void OnClickBtnConfirm()
		{
			if (this.Selection.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_NotEnoughItem_Text", Array.Empty<object>());
				return;
			}
			this.RequestWeaponDecomposeAsync().Forget();
		}

		// Token: 0x0603482A RID: 215082 RVA: 0x00EB1668 File Offset: 0x00EAF868
		private UniTask RequestWeaponDecomposeAsync()
		{
			PinballWeaponDecomposeView.<RequestWeaponDecomposeAsync>d__28 <RequestWeaponDecomposeAsync>d__;
			<RequestWeaponDecomposeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestWeaponDecomposeAsync>d__.<>4__this = this;
			<RequestWeaponDecomposeAsync>d__.<>1__state = -1;
			<RequestWeaponDecomposeAsync>d__.<>t__builder.Start<PinballWeaponDecomposeView.<RequestWeaponDecomposeAsync>d__28>(ref <RequestWeaponDecomposeAsync>d__);
			return <RequestWeaponDecomposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603482B RID: 215083 RVA: 0x00EB16AC File Offset: 0x00EAF8AC
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

		// Token: 0x0603482C RID: 215084 RVA: 0x00EB1710 File Offset: 0x00EAF910
		protected bool OnCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			int incId = ((IPinballItemDataWeapon)callbackParameter.Data).IncId;
			return this.CanAddItem(incId, true);
		}

		// Token: 0x0603482D RID: 215085 RVA: 0x00EB1738 File Offset: 0x00EAF938
		protected bool AddFunction(IPinballItemToggleCallback @params)
		{
			int incId = ((IPinballItemDataWeapon)@params.Data).IncId;
			this.AddSelection(incId);
			@params.View.RefreshReduceBtnComponent(true).Forget();
			this.RefreshPreviewItemAsync().Forget();
			return true;
		}

		// Token: 0x0603482E RID: 215086 RVA: 0x00EB177C File Offset: 0x00EAF97C
		private void ShowCurrentSelectedWeaponInfo(IPinballItemToggleCallback @params)
		{
			this.CurrentSelectedIncId = ((IPinballItemDataWeapon)@params.Data).IncId;
			this.RefreshWeaponInfo();
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x0603482F RID: 215087 RVA: 0x00EB17BC File Offset: 0x00EAF9BC
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

		// Token: 0x06034830 RID: 215088 RVA: 0x00EB1840 File Offset: 0x00EAFA40
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

		// Token: 0x06034831 RID: 215089 RVA: 0x00EB18FC File Offset: 0x00EAFAFC
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

		// Token: 0x06034832 RID: 215090 RVA: 0x00EB1930 File Offset: 0x00EAFB30
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

		// Token: 0x06034833 RID: 215091 RVA: 0x00EB1964 File Offset: 0x00EAFB64
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

		// Token: 0x06034834 RID: 215092 RVA: 0x00EB19D4 File Offset: 0x00EAFBD4
		private void OnPreviewItemExtendToggleClicked(IPinballItemToggleCallback callbackParameter)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.PreviewItemData.ItemData.ItemId, true, null, false);
		}

		// Token: 0x06034835 RID: 215093 RVA: 0x00EB19F3 File Offset: 0x00EAFBF3
		private bool OnPreviewItemCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			return false;
		}

		// Token: 0x06034836 RID: 215094 RVA: 0x00EB19F6 File Offset: 0x00EAFBF6
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034837 RID: 215095 RVA: 0x00EB19FF File Offset: 0x00EAFBFF
		protected override void OnBeforeDestroy()
		{
			this.ClearSelection();
		}

		// Token: 0x0401BD9A RID: 114074
		private int CurrentSelectedIncId = -1;

		// Token: 0x0401BD9B RID: 114075
		private readonly HashSet<int> Selection = new HashSet<int>();

		// Token: 0x0401BD9C RID: 114076
		private List<PinballWeaponData> DataList;

		// Token: 0x0401BD9D RID: 114077
		private LoopScrollView<PinballItemWeaponGridView, PinballWeaponData> LoopScroll;

		// Token: 0x0401BD9E RID: 114078
		private FilterSortEntrance<PinballWeaponData> FilterSortEntrance;

		// Token: 0x0401BD9F RID: 114079
		private PinballItemView PreviewItemView;

		// Token: 0x0401BDA0 RID: 114080
		private TItem PreviewItemData = new TItem(new InventoryDefine.GetItemData(89500002, 0), 0);

		// Token: 0x0401BDA1 RID: 114081
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BDA2 RID: 114082
		private ButtonItem BtnConfirm;

		// Token: 0x0401BDA3 RID: 114083
		private PinballWeaponTipsTopView TipsTopView;

		// Token: 0x0401BDA4 RID: 114084
		private PinballWeaponAttrView AttrView;

		// Token: 0x0401BDA5 RID: 114085
		private const int MAX_SELECT_COUNT = 1000;

		// Token: 0x0200AEBF RID: 44735
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035FCC RID: 221132
			Caption,
			// Token: 0x04035FCD RID: 221133
			LoopScroll,
			// Token: 0x04035FCE RID: 221134
			LoopScrollItem,
			// Token: 0x04035FCF RID: 221135
			SortFilter,
			// Token: 0x04035FD0 RID: 221136
			PnlWeapon,
			// Token: 0x04035FD1 RID: 221137
			TextEmptyTips,
			// Token: 0x04035FD2 RID: 221138
			PnlWeaponAttr,
			// Token: 0x04035FD3 RID: 221139
			PreviewItem,
			// Token: 0x04035FD4 RID: 221140
			TextSelectedCount,
			// Token: 0x04035FD5 RID: 221141
			BtnConfirm,
			// Token: 0x04035FD6 RID: 221142
			AllSelectToggle,
			// Token: 0x04035FD7 RID: 221143
			TextWeaponCount
		}
	}
}
