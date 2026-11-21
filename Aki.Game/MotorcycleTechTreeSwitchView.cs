using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001757 RID: 5975
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeSwitchView : UiViewBase
{
	// Token: 0x17001629 RID: 5673
	// (get) Token: 0x0600E81B RID: 59419 RVA: 0x0043FA75 File Offset: 0x0043DC75
	private bool IsLockByTime
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreeTimeLocked();
		}
	}

	// Token: 0x1700162A RID: 5674
	// (get) Token: 0x0600E81C RID: 59420 RVA: 0x0043FA81 File Offset: 0x0043DC81
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x0600E81D RID: 59421 RVA: 0x0043FA8D File Offset: 0x0043DC8D
	public MotorcycleTechTreeSwitchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E81E RID: 59422 RVA: 0x0043FA98 File Offset: 0x0043DC98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x0600E81F RID: 59423 RVA: 0x0043FB08 File Offset: 0x0043DD08
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeSwitchView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeSwitchView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E820 RID: 59424 RVA: 0x0043FB4B File Offset: 0x0043DD4B
	protected override void OnBeforeShow()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetHorizontalLayout(1).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x0600E821 RID: 59425 RVA: 0x0043FB7E File Offset: 0x0043DD7E
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0600E822 RID: 59426 RVA: 0x0043FB91 File Offset: 0x0043DD91
	private MotorcycleTechTreeSwitchItem InitItem()
	{
		return new MotorcycleTechTreeSwitchItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle>(this.OnClickItem)
		};
	}

	// Token: 0x0600E823 RID: 59427 RVA: 0x0043FBAC File Offset: 0x0043DDAC
	private void OnClickItem(int treeType, UUIExtendToggle toggle)
	{
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.SelectedTechTreeType = treeType;
		bool enableClick = this.SelectedTechTreeType != this.CacheCurTreeType;
		this.SwitchBtnItem.SetEnableClick(enableClick);
	}

	// Token: 0x0600E824 RID: 59428 RVA: 0x0043FC0D File Offset: 0x0043DE0D
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E825 RID: 59429 RVA: 0x0043FC18 File Offset: 0x0043DE18
	private void OnBtnSwitchClick(int _)
	{
		if (this.IsLockByTime)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorBike_TechTree_ChangeFail_Time", Array.Empty<object>());
			return;
		}
		if (this.IsLockByPlayerStatus)
		{
			return;
		}
		int curTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		if (this.SelectedTechTreeType == curTreeType)
		{
			base.CloseMe(null);
			return;
		}
		MotorcycleDevelopController.Instance.RequestMotorTechTreeSwitch(this.SelectedTechTreeType, delegate
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("SwitchMotorTechTreeCD");
			if (intConfig != null)
			{
				MotorcycleDevelopModel.Instance.StartSwitchTechTreeLockTimer(intConfig.Value);
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(MotorConfig.Instance.GetMotorTechTreeConfig(this.SelectedTechTreeType).Value.Name, null);
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorBike_TechTree_ChangeSuccess", new object[]
			{
				localTextNew
			});
			base.CloseMe(null);
		});
	}

	// Token: 0x04008447 RID: 33863
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008448 RID: 33864
	[Nullable(2)]
	private ButtonItem SwitchBtnItem;

	// Token: 0x04008449 RID: 33865
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MotorcycleTechTreeSwitchItem, int> TechTreeLayout;

	// Token: 0x0400844A RID: 33866
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400844B RID: 33867
	private int SelectedTechTreeType;

	// Token: 0x0400844C RID: 33868
	private int CacheCurTreeType;

	// Token: 0x02007935 RID: 31029
	[NullableContext(0)]
	private class EMotorTechTreeSwitchComponent
	{
		// Token: 0x0402748D RID: 160909
		public const int ItemCaption = 0;

		// Token: 0x0402748E RID: 160910
		public const int Layout = 1;

		// Token: 0x0402748F RID: 160911
		public const int LayoutItem = 2;

		// Token: 0x04027490 RID: 160912
		public const int BtnConfirm = 3;
	}
}
