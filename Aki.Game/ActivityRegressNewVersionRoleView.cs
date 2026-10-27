using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001443 RID: 5187
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressNewVersionRoleView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009284 RID: 37508 RVA: 0x001F63B8 File Offset: 0x001F45B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickUrlBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickJumpBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftBtn)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightBtn))
		};
	}

	// Token: 0x06009285 RID: 37509 RVA: 0x001F6530 File Offset: 0x001F4730
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressNewVersionRoleView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressNewVersionRoleView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009286 RID: 37510 RVA: 0x001F6574 File Offset: 0x001F4774
	protected override void OnStart()
	{
		base.OnStart();
		this.PoolScrollView = new GenericScrollViewNew<PoolScrollItem, ProtoGachaPoolInfo>(base.GetScrollViewWithScrollbar(2), new Func<PoolScrollItem>(this.OnInitItem), null, false, null);
		this.PoolInfoList = ActivityRegressModel.Instance.GetGachaPoolUpPool();
		this.PoolScrollView.RefreshByData(this.PoolInfoList, delegate
		{
			GenericScrollViewNew<PoolScrollItem, ProtoGachaPoolInfo> poolScrollView = this.PoolScrollView;
			if (poolScrollView == null)
			{
				return;
			}
			PoolScrollItem scrollItemByIndex = poolScrollView.GetScrollItemByIndex(0);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.SelectedToggle();
		}, false);
		UUIItem uuiitem = this.PoolScrollView.ContentItem.Value.Get();
		float width = uuiitem.Width;
		USceneComponent childComponent = uuiitem.GetChildComponent(0);
		if (childComponent != null)
		{
			float num = (childComponent.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).GetWidth() + 15f;
			if (width <= num * (float)this.PoolInfoList.Count)
			{
				uuiitem.SetAnchorAlign(UIAnchorHorizontalAlign.Left, UIAnchorVerticalAlign.Middle);
				uuiitem.SetWidth(num * (float)this.PoolInfoList.Count);
			}
		}
	}

	// Token: 0x06009287 RID: 37511 RVA: 0x001F665B File Offset: 0x001F485B
	private PoolScrollItem OnInitItem()
	{
		return new PoolScrollItem
		{
			OnClickToggleCallBack = new Action<ProtoGachaPoolInfo, UUIExtendToggle>(this.OnClickPoolItemToggle)
		};
	}

	// Token: 0x06009288 RID: 37512 RVA: 0x001F6674 File Offset: 0x001F4874
	private void OnClickPoolItemToggle([Nullable(2)] ProtoGachaPoolInfo poolInfo, UUIExtendToggle toggle)
	{
		if (poolInfo == null || this.CurrentSelectPoolInfo == poolInfo)
		{
			return;
		}
		this.CurrentSelectPoolInfo = poolInfo;
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.RefreshView();
	}

	// Token: 0x06009289 RID: 37513 RVA: 0x001F66B0 File Offset: 0x001F48B0
	private void RefreshView()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		RoleDescribeComponent roleDescribeComponent = this.RoleDescribeComponent;
		if (roleDescribeComponent != null)
		{
			roleDescribeComponent.Update(this.CurrentSelectPoolInfo.PreviewIdList[0], false);
		}
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(this.CurrentSelectPoolInfo.Id);
		if (gachaViewInfo == null)
		{
			return;
		}
		GachaViewInfo value = gachaViewInfo.Value;
		base.SetTextureByPath(value.UnderBgTexturePath, base.GetTexture(7), null, null);
		int uiType = this.CurrentSelectPoolInfo.UiType;
		if (uiType == 0)
		{
			return;
		}
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig(uiType);
		if (gachaViewTypeConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), gachaViewTypeConfig.Value.TypeText, Array.Empty<object>());
		base.GetText(9).SetText(this.CurrentSelectPoolInfo.Title, true);
		GachaPool? gachaPoolConfig = GachaConfig.Instance.GetGachaPoolConfig(this.CurrentSelectPoolInfo.Id);
		if (gachaPoolConfig == null)
		{
			return;
		}
		ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(gachaPoolConfig.Value.GachaId);
		if (gachaInfo == null)
		{
			this.CloseView();
			return;
		}
		double poolEndTimeByPoolInfo = gachaInfo.GetPoolEndTimeByPoolInfo(this.CurrentSelectPoolInfo);
		if (poolEndTimeByPoolInfo == 0.0)
		{
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = poolEndTimeByPoolInfo - serverTime;
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(remainTime);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_GachaRemainingTime_Text", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
		this.RefreshButtonUiActivity();
		this.RefreshRoleItemAsync(value.SpinePrefabResource, (value.TrialRoleId > 0) ? value.TrialRoleId : value.Id);
	}

	// Token: 0x0600928A RID: 37514 RVA: 0x001F6868 File Offset: 0x001F4A68
	private UniTask RefreshRoleItemAsync(string resourceId, int roleId)
	{
		ActivityRegressNewVersionRoleView.<RefreshRoleItemAsync>d__16 <RefreshRoleItemAsync>d__;
		<RefreshRoleItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleItemAsync>d__.<>4__this = this;
		<RefreshRoleItemAsync>d__.resourceId = resourceId;
		<RefreshRoleItemAsync>d__.roleId = roleId;
		<RefreshRoleItemAsync>d__.<>1__state = -1;
		<RefreshRoleItemAsync>d__.<>t__builder.Start<ActivityRegressNewVersionRoleView.<RefreshRoleItemAsync>d__16>(ref <RefreshRoleItemAsync>d__);
		return <RefreshRoleItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600928B RID: 37515 RVA: 0x001F68BC File Offset: 0x001F4ABC
	private UniTask InitRoleSpineItem(string resourceId, int roleId)
	{
		ActivityRegressNewVersionRoleView.<InitRoleSpineItem>d__17 <InitRoleSpineItem>d__;
		<InitRoleSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSpineItem>d__.<>4__this = this;
		<InitRoleSpineItem>d__.resourceId = resourceId;
		<InitRoleSpineItem>d__.roleId = roleId;
		<InitRoleSpineItem>d__.<>1__state = -1;
		<InitRoleSpineItem>d__.<>t__builder.Start<ActivityRegressNewVersionRoleView.<InitRoleSpineItem>d__17>(ref <InitRoleSpineItem>d__);
		return <InitRoleSpineItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600928C RID: 37516 RVA: 0x001F6910 File Offset: 0x001F4B10
	private UniTask InitRoleCommonItem()
	{
		ActivityRegressNewVersionRoleView.<InitRoleCommonItem>d__18 <InitRoleCommonItem>d__;
		<InitRoleCommonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleCommonItem>d__.<>4__this = this;
		<InitRoleCommonItem>d__.<>1__state = -1;
		<InitRoleCommonItem>d__.<>t__builder.Start<ActivityRegressNewVersionRoleView.<InitRoleCommonItem>d__18>(ref <InitRoleCommonItem>d__);
		return <InitRoleCommonItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600928D RID: 37517 RVA: 0x001F6954 File Offset: 0x001F4B54
	private void RefreshButtonUiActivity()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		int num = this.PoolInfoList.IndexOf(this.CurrentSelectPoolInfo);
		if (num <= 0)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
		}
		else
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(true);
		}
		if (num >= this.PoolInfoList.Count - 1)
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetButton(4).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600928E RID: 37518 RVA: 0x001F69F9 File Offset: 0x001F4BF9
	private void OnClickUrlBtn()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		ActivityRegressController.OpenGameIntroductionByRoleId(this.CurrentSelectPoolInfo.PreviewIdList[0]);
	}

	// Token: 0x0600928F RID: 37519 RVA: 0x001F6A18 File Offset: 0x001F4C18
	private void OnClickJumpBtn()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		GachaPool? gachaPoolConfig = GachaConfig.Instance.GetGachaPoolConfig(this.CurrentSelectPoolInfo.Id);
		if (gachaPoolConfig == null)
		{
			return;
		}
		ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(gachaPoolConfig.Value.GachaId);
		if (gachaInfo == null)
		{
			this.CloseView();
			return;
		}
		bool flag = UiManager.Instance.IsViewOpen(EUiViewName.ActivityRegressNewVersionMainView);
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, gachaInfo.Id, null);
		UiManager.Instance.CloseView(flag ? EUiViewName.ActivityRegressNewVersionMainView : EUiViewName.ActivityRegressMainView, null);
		UiManager.Instance.CloseView(EUiViewName.CommonActivityView, null);
	}

	// Token: 0x06009290 RID: 37520 RVA: 0x001F6AC8 File Offset: 0x001F4CC8
	private void CloseView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRegressMainView))
		{
			UiManager.Instance.CloseView(EUiViewName.ActivityRegressMainView, null);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRegressNewVersionMainView))
		{
			UiManager.Instance.CloseView(EUiViewName.ActivityRegressNewVersionMainView, null);
		}
	}

	// Token: 0x06009291 RID: 37521 RVA: 0x001F6B18 File Offset: 0x001F4D18
	private void OnClickLeftBtn()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		int num = this.PoolInfoList.IndexOf(this.CurrentSelectPoolInfo);
		if (num <= 0)
		{
			return;
		}
		num--;
		GenericScrollViewNew<PoolScrollItem, ProtoGachaPoolInfo> poolScrollView = this.PoolScrollView;
		PoolScrollItem poolScrollItem = (poolScrollView != null) ? poolScrollView.GetScrollItemByIndex(num) : null;
		if (poolScrollItem == null)
		{
			return;
		}
		poolScrollItem.SelectedToggle();
	}

	// Token: 0x06009292 RID: 37522 RVA: 0x001F6B68 File Offset: 0x001F4D68
	private void OnClickRightBtn()
	{
		if (this.CurrentSelectPoolInfo == null)
		{
			return;
		}
		int num = this.PoolInfoList.IndexOf(this.CurrentSelectPoolInfo);
		if (num >= this.PoolInfoList.Count - 1)
		{
			return;
		}
		num++;
		GenericScrollViewNew<PoolScrollItem, ProtoGachaPoolInfo> poolScrollView = this.PoolScrollView;
		PoolScrollItem poolScrollItem = (poolScrollView != null) ? poolScrollView.GetScrollItemByIndex(num) : null;
		if (poolScrollItem == null)
		{
			return;
		}
		poolScrollItem.SelectedToggle();
	}

	// Token: 0x040040E9 RID: 16617
	private const int POOL_ITEM_PADDING = 15;

	// Token: 0x040040EA RID: 16618
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PoolScrollItem, ProtoGachaPoolInfo> PoolScrollView;

	// Token: 0x040040EB RID: 16619
	[Nullable(2)]
	private RoleDescribeComponent RoleDescribeComponent;

	// Token: 0x040040EC RID: 16620
	[Nullable(2)]
	private ProtoGachaPoolInfo CurrentSelectPoolInfo;

	// Token: 0x040040ED RID: 16621
	private List<ProtoGachaPoolInfo> PoolInfoList = new List<ProtoGachaPoolInfo>();

	// Token: 0x040040EE RID: 16622
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040040EF RID: 16623
	private readonly Dictionary<int, NewPlayerSupportRoleSpineItem> RoleSpineItemMap = new Dictionary<int, NewPlayerSupportRoleSpineItem>();

	// Token: 0x040040F0 RID: 16624
	[Nullable(2)]
	private NewPlayerSupportRoleBaseItem CurRoleItem;

	// Token: 0x040040F1 RID: 16625
	[Nullable(2)]
	private NewPlayerSupportRoleCommonItem RoleCommonItem;

	// Token: 0x02007A7A RID: 31354
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040284C6 RID: 165062
		public const int LeftTimeText = 0;

		// Token: 0x040284C7 RID: 165063
		public const int RoleInfoItem = 1;

		// Token: 0x040284C8 RID: 165064
		public const int PoolListScrollView = 2;

		// Token: 0x040284C9 RID: 165065
		public const int LeftBtn = 3;

		// Token: 0x040284CA RID: 165066
		public const int RightBtn = 4;

		// Token: 0x040284CB RID: 165067
		public const int UrlBtn = 5;

		// Token: 0x040284CC RID: 165068
		public const int JumpToBtn = 6;

		// Token: 0x040284CD RID: 165069
		public const int BgTexture = 7;

		// Token: 0x040284CE RID: 165070
		public const int RoleSpineItem = 8;

		// Token: 0x040284CF RID: 165071
		public const int TitleText = 9;

		// Token: 0x040284D0 RID: 165072
		public const int SubTitleText = 10;
	}
}
