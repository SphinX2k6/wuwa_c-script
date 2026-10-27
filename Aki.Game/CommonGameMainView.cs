using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CAE RID: 7342
[NullableContext(1)]
[Nullable(0)]
public class CommonGameMainView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x0600DDA6 RID: 56742 RVA: 0x0033D56A File Offset: 0x0033B76A
	public CommonGameMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DDA7 RID: 56743 RVA: 0x0033D573 File Offset: 0x0033B773
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600DDA8 RID: 56744 RVA: 0x0033D5AC File Offset: 0x0033B7AC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonGameMainView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonGameMainView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDA9 RID: 56745 RVA: 0x0033D5EF File Offset: 0x0033B7EF
	protected override void OnStartImplementImplement()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.Start();
	}

	// Token: 0x0600DDAA RID: 56746 RVA: 0x0033D601 File Offset: 0x0033B801
	protected override void OnBeforeShowImplementImplement()
	{
		base.OnBeforeShowImplementImplement();
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.BeforeShow();
	}

	// Token: 0x0600DDAB RID: 56747 RVA: 0x0033D619 File Offset: 0x0033B819
	protected override void OnAfterShowImplement()
	{
		base.OnAfterShowImplement();
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.AfterShow();
	}

	// Token: 0x0600DDAC RID: 56748 RVA: 0x0033D631 File Offset: 0x0033B831
	protected override void OnBeforeHide()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.BeforeHide();
	}

	// Token: 0x0600DDAD RID: 56749 RVA: 0x0033D643 File Offset: 0x0033B843
	protected override void OnAfterHideImplementImplement()
	{
		base.OnAfterHideImplementImplement();
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.AfterHide();
	}

	// Token: 0x0600DDAE RID: 56750 RVA: 0x0033D65B File Offset: 0x0033B85B
	protected override void OnAddEventListener()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.AddEventListener();
	}

	// Token: 0x0600DDAF RID: 56751 RVA: 0x0033D66D File Offset: 0x0033B86D
	protected override void OnRemoveEventListener()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.RemoveEventListener();
	}

	// Token: 0x0600DDB0 RID: 56752 RVA: 0x0033D680 File Offset: 0x0033B880
	protected override void OnTick(float delta)
	{
		CharacterModel instance = CharacterModel.Instance;
		float delta2 = delta * ((instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f);
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.Tick(delta2);
	}

	// Token: 0x0600DDB1 RID: 56753 RVA: 0x0033D6B8 File Offset: 0x0033B8B8
	protected override void OnAfterTick(float delta)
	{
		CharacterModel instance = CharacterModel.Instance;
		float delta2 = delta * ((instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f);
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.AfterTick(delta2);
	}

	// Token: 0x0600DDB2 RID: 56754 RVA: 0x0033D6EE File Offset: 0x0033B8EE
	protected override void OnBeforeDestroy()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.BeforeDestroy();
	}

	// Token: 0x0600DDB3 RID: 56755 RVA: 0x0033D700 File Offset: 0x0033B900
	public UUIItem GetContentPanel()
	{
		return base.GetItem(0);
	}

	// Token: 0x0600DDB4 RID: 56756 RVA: 0x0033D709 File Offset: 0x0033B909
	public void SetMaskItemActive(bool active)
	{
		base.GetItem(1).SetUIActive(active);
	}

	// Token: 0x0600DDB5 RID: 56757 RVA: 0x0033D718 File Offset: 0x0033B918
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return null;
		}
		return viewProxy.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0600DDB6 RID: 56758 RVA: 0x0033D72C File Offset: 0x0033B92C
	protected override UniTask OnPlayingHideSequenceAsync()
	{
		CommonGameMainView.<OnPlayingHideSequenceAsync>d__18 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>4__this = this;
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<CommonGameMainView.<OnPlayingHideSequenceAsync>d__18>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDB7 RID: 56759 RVA: 0x0033D76F File Offset: 0x0033B96F
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null || !viewProxy.NeedUiCameraBehavior())
		{
			return;
		}
		this.ViewProxy.PushCameraHandle(viewName, viewId, isBlend);
	}

	// Token: 0x0600DDB8 RID: 56760 RVA: 0x0033D794 File Offset: 0x0033B994
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null || !viewProxy.NeedUiCameraBehavior())
		{
			return;
		}
		this.ViewProxy.PopCameraHandle(viewName, stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x040065BF RID: 26047
	[Nullable(2)]
	private GameMainViewProxy ViewProxy;

	// Token: 0x0200828D RID: 33421
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402A97E RID: 174462
		public const int ContentPanel = 0;

		// Token: 0x0402A97F RID: 174463
		public const int MaskItem = 1;
	}
}
