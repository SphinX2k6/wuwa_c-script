using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C0F RID: 15375
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffSubView : ActivitySubViewBase
	{
		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x0602764F RID: 161359 RVA: 0x00B0B00C File Offset: 0x00B0920C
		private SheriffActivityData SheriffActivityDataInternal
		{
			get
			{
				return this.ActivityBaseData as SheriffActivityData;
			}
		}

		// Token: 0x06027650 RID: 161360 RVA: 0x00B0B01C File Offset: 0x00B0921C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnShopClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027651 RID: 161361 RVA: 0x00B0B104 File Offset: 0x00B09304
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027652 RID: 161362 RVA: 0x00B0B147 File Offset: 0x00B09347
		protected override void OnStart()
		{
			this.RefreshShopBtn();
			this.RefreshActivityInfo();
			this.RefreshCommonInfoRedDot();
		}

		// Token: 0x06027653 RID: 161363 RVA: 0x00B0B15B File Offset: 0x00B0935B
		protected override void OnRefreshView()
		{
			this.RefreshShopBtn();
			this.RefreshActivityInfo();
			this.RefreshCommonInfoRedDot();
		}

		// Token: 0x06027654 RID: 161364 RVA: 0x00B0B170 File Offset: 0x00B09370
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopBtn));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x06027655 RID: 161365 RVA: 0x00B0B1D4 File Offset: 0x00B093D4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopBtn));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x06027656 RID: 161366 RVA: 0x00B0B235 File Offset: 0x00B09435
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.RefreshShopBtn();
		}

		// Token: 0x06027657 RID: 161367 RVA: 0x00B0B240 File Offset: 0x00B09440
		private void OnRefreshActivityRedDot(int uid)
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (!(uid == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshCommonInfoRedDot();
		}

		// Token: 0x06027658 RID: 161368 RVA: 0x00B0B288 File Offset: 0x00B09488
		private void RefreshCommonInfoRedDot()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			SheriffActivityData sheriffActivityData = this.ActivityBaseData as SheriffActivityData;
			commonInfoPanel.SetFunctionRedDotVisible(sheriffActivityData != null && sheriffActivityData.IsUnlockRedDotActive());
		}

		// Token: 0x06027659 RID: 161369 RVA: 0x00B0B2B8 File Offset: 0x00B094B8
		private void RefreshShopBtn()
		{
			ValueTuple<int, int, int> shopGoodsPriceInfo = SheriffModel.Instance.GetShopGoodsPriceInfo();
			int item = shopGoodsPriceInfo.Item1;
			int item2 = shopGoodsPriceInfo.Item2;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "Sheriff_Shop_2", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
			base.GetItem(3).SetUIActive(SheriffModel.Instance.CheckShopRedDot());
		}

		// Token: 0x0602765A RID: 161370 RVA: 0x00B0B325 File Offset: 0x00B09525
		private void RefreshActivityInfo()
		{
			this.CommonInfoPanel.SetClickFunc(new Action<ActivityBaseData>(this.OnConfirmBtnClick));
			this.CommonInfoPanel.SetBtnText("Activity_110600001_Go", Array.Empty<object>());
		}

		// Token: 0x0602765B RID: 161371 RVA: 0x00B0B353 File Offset: 0x00B09553
		private void OnBtnShopClick()
		{
			SheriffModel.Instance.ClearShopRedDot();
			UiManager.Instance.OpenView(EUiViewName.SheriffShopView, null, delegate(bool success, int viewId)
			{
				if (success)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x0602765C RID: 161372 RVA: 0x00B0B38E File Offset: 0x00B0958E
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				SheriffController.Instance.OpenSheriffMap(null);
			});
		}

		// Token: 0x040157C7 RID: 88007
		[Nullable(1)]
		private readonly ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x02009820 RID: 38944
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402F749 RID: 194377
			public const int CommonActionInfo = 0;

			// Token: 0x0402F74A RID: 194378
			public const int BtnShop = 1;

			// Token: 0x0402F74B RID: 194379
			public const int TxtNum = 2;

			// Token: 0x0402F74C RID: 194380
			public const int BtnShopRedDot = 3;
		}
	}
}
