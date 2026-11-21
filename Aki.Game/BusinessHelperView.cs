using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007CD RID: 1997
[NullableContext(1)]
[Nullable(0)]
public class BusinessHelperView : UiViewBase
{
	// Token: 0x06005B33 RID: 23347 RVA: 0x001D802B File Offset: 0x001D622B
	public BusinessHelperView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005B34 RID: 23348 RVA: 0x001D8040 File Offset: 0x001D6240
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06005B35 RID: 23349 RVA: 0x001D80DC File Offset: 0x001D62DC
	private UniTask InitHelperPanel()
	{
		BusinessHelperView.<InitHelperPanel>d__7 <InitHelperPanel>d__;
		<InitHelperPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHelperPanel>d__.<>4__this = this;
		<InitHelperPanel>d__.<>1__state = -1;
		<InitHelperPanel>d__.<>t__builder.Start<BusinessHelperView.<InitHelperPanel>d__7>(ref <InitHelperPanel>d__);
		return <InitHelperPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06005B36 RID: 23350 RVA: 0x001D8120 File Offset: 0x001D6320
	private UniTask InitInteractivePanel()
	{
		BusinessHelperView.<InitInteractivePanel>d__8 <InitInteractivePanel>d__;
		<InitInteractivePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInteractivePanel>d__.<>4__this = this;
		<InitInteractivePanel>d__.<>1__state = -1;
		<InitInteractivePanel>d__.<>t__builder.Start<BusinessHelperView.<InitInteractivePanel>d__8>(ref <InitInteractivePanel>d__);
		return <InitInteractivePanel>d__.<>t__builder.Task;
	}

	// Token: 0x06005B37 RID: 23351 RVA: 0x001D8164 File Offset: 0x001D6364
	private UniTask InitCaptionItem()
	{
		BusinessHelperView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessHelperView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005B38 RID: 23352 RVA: 0x001D81A8 File Offset: 0x001D63A8
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessHelperView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessHelperView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005B39 RID: 23353 RVA: 0x001D81EB File Offset: 0x001D63EB
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005B3A RID: 23354 RVA: 0x001D8202 File Offset: 0x001D6402
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenTipsShopView, new Action(this.Vc.RefreshInteractivePanel));
	}

	// Token: 0x06005B3B RID: 23355 RVA: 0x001D8225 File Offset: 0x001D6425
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenTipsShopView, new Action(this.Vc.RefreshInteractivePanel));
	}

	// Token: 0x06005B3C RID: 23356 RVA: 0x001D8248 File Offset: 0x001D6448
	public UniTask RefreshSpine(int roleId)
	{
		BusinessHelperView.<RefreshSpine>d__14 <RefreshSpine>d__;
		<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSpine>d__.<>4__this = this;
		<RefreshSpine>d__.roleId = roleId;
		<RefreshSpine>d__.<>1__state = -1;
		<RefreshSpine>d__.<>t__builder.Start<BusinessHelperView.<RefreshSpine>d__14>(ref <RefreshSpine>d__);
		return <RefreshSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06005B3D RID: 23357 RVA: 0x001D8294 File Offset: 0x001D6494
	public void SkipToHelpPanel()
	{
		BusinessHelperPanel helperPanel = this.HelperPanel;
		if (helperPanel != null)
		{
			helperPanel.SetActive(true);
		}
		this.CaptionItem.SetTitleIconByResourceId("SP_ChasingMoonIcon8").Forget();
		base.PlaySequenceAsync("SwitchOut", true, false, null).ContinueWith(delegate()
		{
			BusinessInteractivePanel interactivePanel = this.InteractivePanel;
			if (interactivePanel == null)
			{
				return;
			}
			interactivePanel.SetActive(false);
		}).Forget();
	}

	// Token: 0x06005B3E RID: 23358 RVA: 0x001D82F4 File Offset: 0x001D64F4
	public void SkipToInteractivePanel()
	{
		BusinessInteractivePanel interactivePanel = this.InteractivePanel;
		if (interactivePanel != null)
		{
			interactivePanel.SetActive(true);
		}
		this.CaptionItem.SetTitleIconByResourceId("SP_ChasingMoonIcon1").Forget();
		base.PlaySequenceAsync("SwitchIn", true, false, null).ContinueWith(delegate()
		{
			BusinessHelperPanel helperPanel = this.HelperPanel;
			if (helperPanel != null)
			{
				helperPanel.SetActive(false);
			}
			EventSystem.Instance.Emit(EEventName.MoonChasingOnOpenInteractive);
		}).Forget();
	}

	// Token: 0x06005B3F RID: 23359 RVA: 0x001D8354 File Offset: 0x001D6554
	public void RefreshInteractivePanel()
	{
		BusinessInteractivePanel interactivePanel = this.InteractivePanel;
		if (interactivePanel == null)
		{
			return;
		}
		interactivePanel.Refresh().Forget();
	}

	// Token: 0x06005B40 RID: 23360 RVA: 0x001D836C File Offset: 0x001D656C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		string a = configParams[0];
		if (!(a == "Helper") && !(a == "HelperFirst"))
		{
			if (!(a == "Interactive"))
			{
				return null;
			}
			BusinessInteractivePanel interactivePanel = this.InteractivePanel;
			if (interactivePanel == null)
			{
				return null;
			}
			return interactivePanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			BusinessHelperPanel helperPanel = this.HelperPanel;
			if (helperPanel == null)
			{
				return null;
			}
			return helperPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x06005B41 RID: 23361 RVA: 0x001D83D5 File Offset: 0x001D65D5
	public void ShowView(bool inInInteractive)
	{
		if (MoonChasingModel.Instance.CheckRoleFosterTipsRedDotState())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Moonfiesta_HeartFullTip", Array.Empty<object>());
		}
		if (!inInInteractive)
		{
			BusinessHelperPanel helperPanel = this.HelperPanel;
			if (helperPanel == null)
			{
				return;
			}
			helperPanel.SetActive(true);
		}
	}

	// Token: 0x04003D11 RID: 15633
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003D12 RID: 15634
	[Nullable(2)]
	protected BusinessHelperPanel HelperPanel;

	// Token: 0x04003D13 RID: 15635
	[Nullable(2)]
	protected BusinessInteractivePanel InteractivePanel;

	// Token: 0x04003D14 RID: 15636
	private readonly BusinessHelperViewController Vc = new BusinessHelperViewController();

	// Token: 0x02006AF0 RID: 27376
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040232E5 RID: 144101
		public const int CaptionItem = 0;

		// Token: 0x040232E6 RID: 144102
		public const int HelperItem = 1;

		// Token: 0x040232E7 RID: 144103
		public const int InteractiveItem = 2;

		// Token: 0x040232E8 RID: 144104
		public const int RoleSpineItem = 3;

		// Token: 0x040232E9 RID: 144105
		public const int RoleSpine = 4;

		// Token: 0x040232EA RID: 144106
		public const int LockItem = 5;
	}
}
