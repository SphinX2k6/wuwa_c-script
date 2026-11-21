using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001170 RID: 4464
public class CommonGameMainView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x0600B1C3 RID: 45507 RVA: 0x00348FA6 File Offset: 0x003471A6
	[NullableContext(1)]
	public CommonGameMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B1C4 RID: 45508 RVA: 0x00348FAF File Offset: 0x003471AF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600B1C5 RID: 45509 RVA: 0x00348FE8 File Offset: 0x003471E8
	protected override UniTask OnBeforeStartAsync()
	{
		CommonGameMainView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonGameMainView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1C6 RID: 45510 RVA: 0x0034902B File Offset: 0x0034722B
	protected override void OnStartImplementImplement()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.Start();
	}

	// Token: 0x0600B1C7 RID: 45511 RVA: 0x0034903D File Offset: 0x0034723D
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

	// Token: 0x0600B1C8 RID: 45512 RVA: 0x00349055 File Offset: 0x00347255
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

	// Token: 0x0600B1C9 RID: 45513 RVA: 0x0034906D File Offset: 0x0034726D
	protected override void OnBeforeHide()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.BeforeHide();
	}

	// Token: 0x0600B1CA RID: 45514 RVA: 0x0034907F File Offset: 0x0034727F
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

	// Token: 0x0600B1CB RID: 45515 RVA: 0x00349097 File Offset: 0x00347297
	protected override void OnAddEventListener()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.AddEventListener();
	}

	// Token: 0x0600B1CC RID: 45516 RVA: 0x003490A9 File Offset: 0x003472A9
	protected override void OnRemoveEventListener()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.RemoveEventListener();
	}

	// Token: 0x0600B1CD RID: 45517 RVA: 0x003490BC File Offset: 0x003472BC
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

	// Token: 0x0600B1CE RID: 45518 RVA: 0x003490F4 File Offset: 0x003472F4
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

	// Token: 0x0600B1CF RID: 45519 RVA: 0x0034912A File Offset: 0x0034732A
	protected override void OnBeforeDestroy()
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.BeforeDestroy();
	}

	// Token: 0x0600B1D0 RID: 45520 RVA: 0x0034913C File Offset: 0x0034733C
	[NullableContext(1)]
	public UUIItem GetContentPanel()
	{
		return base.GetItem(0);
	}

	// Token: 0x0600B1D1 RID: 45521 RVA: 0x00349145 File Offset: 0x00347345
	public void SetMaskItemActive(bool active)
	{
		base.GetItem(1).SetUIActive(active);
	}

	// Token: 0x0600B1D2 RID: 45522 RVA: 0x00349154 File Offset: 0x00347354
	[NullableContext(1)]
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

	// Token: 0x0600B1D3 RID: 45523 RVA: 0x00349168 File Offset: 0x00347368
	protected override UniTask OnPlayingHideSequenceAsync()
	{
		CommonGameMainView.<OnPlayingHideSequenceAsync>d__18 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>4__this = this;
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<CommonGameMainView.<OnPlayingHideSequenceAsync>d__18>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1D4 RID: 45524 RVA: 0x003491AB File Offset: 0x003473AB
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null || !viewProxy.NeedUiCameraBehavior())
		{
			return;
		}
		this.ViewProxy.PushCameraHandleByOpenView(viewName, viewId, operationType);
	}

	// Token: 0x0600B1D5 RID: 45525 RVA: 0x003491D0 File Offset: 0x003473D0
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		GameMainViewProxy viewProxy = this.ViewProxy;
		if (viewProxy == null || !viewProxy.NeedUiCameraBehavior())
		{
			return;
		}
		this.ViewProxy.PopCameraHandleByCloseView(viewName, nextViewName, closeViewId, operationType);
	}

	// Token: 0x0400669E RID: 26270
	[Nullable(2)]
	private GameMainViewProxy ViewProxy;

	// Token: 0x02007417 RID: 29719
	private static class EComponentDefine
	{
		// Token: 0x04025CA9 RID: 154793
		public const int ContentPanel = 0;

		// Token: 0x04025CAA RID: 154794
		public const int MaskItem = 1;
	}
}
