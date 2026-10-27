using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001319 RID: 4889
[NullableContext(1)]
[Nullable(0)]
public class BusinessHelperView : UiViewBase
{
	// Token: 0x06008798 RID: 34712 RVA: 0x001CF1BF File Offset: 0x001CD3BF
	public BusinessHelperView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x001CF1D4 File Offset: 0x001CD3D4
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

	// Token: 0x0600879A RID: 34714 RVA: 0x001CF270 File Offset: 0x001CD470
	private UniTask InitHelperPanel()
	{
		BusinessHelperView.<InitHelperPanel>d__7 <InitHelperPanel>d__;
		<InitHelperPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHelperPanel>d__.<>4__this = this;
		<InitHelperPanel>d__.<>1__state = -1;
		<InitHelperPanel>d__.<>t__builder.Start<BusinessHelperView.<InitHelperPanel>d__7>(ref <InitHelperPanel>d__);
		return <InitHelperPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600879B RID: 34715 RVA: 0x001CF2B4 File Offset: 0x001CD4B4
	private UniTask InitInteractivePanel()
	{
		BusinessHelperView.<InitInteractivePanel>d__8 <InitInteractivePanel>d__;
		<InitInteractivePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInteractivePanel>d__.<>4__this = this;
		<InitInteractivePanel>d__.<>1__state = -1;
		<InitInteractivePanel>d__.<>t__builder.Start<BusinessHelperView.<InitInteractivePanel>d__8>(ref <InitInteractivePanel>d__);
		return <InitInteractivePanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600879C RID: 34716 RVA: 0x001CF2F8 File Offset: 0x001CD4F8
	private UniTask InitCaptionItem()
	{
		BusinessHelperView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessHelperView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600879D RID: 34717 RVA: 0x001CF33C File Offset: 0x001CD53C
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessHelperView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessHelperView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600879E RID: 34718 RVA: 0x001CF37F File Offset: 0x001CD57F
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x0600879F RID: 34719 RVA: 0x001CF396 File Offset: 0x001CD596
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenTipsShopView, new Action(this.Vc.RefreshInteractivePanel));
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x001CF3B9 File Offset: 0x001CD5B9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenTipsShopView, new Action(this.Vc.RefreshInteractivePanel));
	}

	// Token: 0x060087A1 RID: 34721 RVA: 0x001CF3DC File Offset: 0x001CD5DC
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

	// Token: 0x060087A2 RID: 34722 RVA: 0x001CF428 File Offset: 0x001CD628
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

	// Token: 0x060087A3 RID: 34723 RVA: 0x001CF488 File Offset: 0x001CD688
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

	// Token: 0x060087A4 RID: 34724 RVA: 0x001CF4E8 File Offset: 0x001CD6E8
	public void RefreshInteractivePanel()
	{
		BusinessInteractivePanel interactivePanel = this.InteractivePanel;
		if (interactivePanel == null)
		{
			return;
		}
		interactivePanel.Refresh().Forget();
	}

	// Token: 0x060087A5 RID: 34725 RVA: 0x001CF500 File Offset: 0x001CD700
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

	// Token: 0x060087A6 RID: 34726 RVA: 0x001CF569 File Offset: 0x001CD769
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

	// Token: 0x04003C79 RID: 15481
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003C7A RID: 15482
	[Nullable(2)]
	protected BusinessHelperPanel HelperPanel;

	// Token: 0x04003C7B RID: 15483
	[Nullable(2)]
	protected BusinessInteractivePanel InteractivePanel;

	// Token: 0x04003C7C RID: 15484
	private readonly BusinessHelperViewController Vc = new BusinessHelperViewController();

	// Token: 0x02007966 RID: 31078
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027FB8 RID: 163768
		public const int CaptionItem = 0;

		// Token: 0x04027FB9 RID: 163769
		public const int HelperItem = 1;

		// Token: 0x04027FBA RID: 163770
		public const int InteractiveItem = 2;

		// Token: 0x04027FBB RID: 163771
		public const int RoleSpineItem = 3;

		// Token: 0x04027FBC RID: 163772
		public const int RoleSpine = 4;

		// Token: 0x04027FBD RID: 163773
		public const int LockItem = 5;
	}
}
