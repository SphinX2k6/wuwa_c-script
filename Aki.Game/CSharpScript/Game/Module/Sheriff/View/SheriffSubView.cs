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
	// Token: 0x02004C5E RID: 19550
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffSubView : ActivitySubViewBase
	{
		// Token: 0x17007CD0 RID: 31952
		// (get) Token: 0x0603289C RID: 207004 RVA: 0x00BC63C0 File Offset: 0x00BC45C0
		private SheriffActivityData SheriffActivityDataInternal
		{
			get
			{
				return this.ActivityBaseData as SheriffActivityData;
			}
		}

		// Token: 0x0603289D RID: 207005 RVA: 0x00BC63D0 File Offset: 0x00BC45D0
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

		// Token: 0x0603289E RID: 207006 RVA: 0x00BC64B8 File Offset: 0x00BC46B8
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603289F RID: 207007 RVA: 0x00BC64FB File Offset: 0x00BC46FB
		protected override void OnStart()
		{
			this.RefreshShopBtn();
			this.RefreshActivityInfo();
			this.RefreshCommonInfoRedDot();
		}

		// Token: 0x060328A0 RID: 207008 RVA: 0x00BC650F File Offset: 0x00BC470F
		protected override void OnRefreshView()
		{
			this.RefreshShopBtn();
			this.RefreshActivityInfo();
			this.RefreshCommonInfoRedDot();
		}

		// Token: 0x060328A1 RID: 207009 RVA: 0x00BC6524 File Offset: 0x00BC4724
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopBtn));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x060328A2 RID: 207010 RVA: 0x00BC6588 File Offset: 0x00BC4788
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopBtn));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x060328A3 RID: 207011 RVA: 0x00BC65E9 File Offset: 0x00BC47E9
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.RefreshShopBtn();
		}

		// Token: 0x060328A4 RID: 207012 RVA: 0x00BC65F4 File Offset: 0x00BC47F4
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

		// Token: 0x060328A5 RID: 207013 RVA: 0x00BC663C File Offset: 0x00BC483C
		private void RefreshCommonInfoRedDot()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			SheriffActivityData sheriffActivityData = this.ActivityBaseData as SheriffActivityData;
			commonInfoPanel.SetFunctionRedDotVisible(sheriffActivityData != null && sheriffActivityData.IsUnlockRedDotActive());
		}

		// Token: 0x060328A6 RID: 207014 RVA: 0x00BC666C File Offset: 0x00BC486C
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

		// Token: 0x060328A7 RID: 207015 RVA: 0x00BC66D9 File Offset: 0x00BC48D9
		private void RefreshActivityInfo()
		{
			this.CommonInfoPanel.SetClickFunc(new Action<ActivityBaseData>(this.OnConfirmBtnClick));
			this.CommonInfoPanel.SetBtnText("Activity_110600001_Go", Array.Empty<object>());
		}

		// Token: 0x060328A8 RID: 207016 RVA: 0x00BC6707 File Offset: 0x00BC4907
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

		// Token: 0x060328A9 RID: 207017 RVA: 0x00BC6742 File Offset: 0x00BC4942
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				SheriffController.Instance.OpenSheriffMap(null);
			});
		}

		// Token: 0x0401AE6A RID: 110186
		[Nullable(1)]
		private readonly ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x0200AE02 RID: 44546
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04034DA4 RID: 216484
			public const int CommonActionInfo = 0;

			// Token: 0x04034DA5 RID: 216485
			public const int BtnShop = 1;

			// Token: 0x04034DA6 RID: 216486
			public const int TxtNum = 2;

			// Token: 0x04034DA7 RID: 216487
			public const int BtnShopRedDot = 3;
		}
	}
}
