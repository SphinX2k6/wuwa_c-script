using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002273 RID: 8819
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeSwitchView : UiViewBase
{
	// Token: 0x170015F2 RID: 5618
	// (get) Token: 0x06011385 RID: 70533 RVA: 0x00432E69 File Offset: 0x00431069
	private bool IsLockByTime
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreeTimeLocked();
		}
	}

	// Token: 0x170015F3 RID: 5619
	// (get) Token: 0x06011386 RID: 70534 RVA: 0x00432E75 File Offset: 0x00431075
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x06011387 RID: 70535 RVA: 0x00432E81 File Offset: 0x00431081
	public MotorcycleTechTreeSwitchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011388 RID: 70536 RVA: 0x00432E8C File Offset: 0x0043108C
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

	// Token: 0x06011389 RID: 70537 RVA: 0x00432EFC File Offset: 0x004310FC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeSwitchView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeSwitchView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601138A RID: 70538 RVA: 0x00432F3F File Offset: 0x0043113F
	protected override void OnBeforeShow()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetHorizontalLayout(1).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x0601138B RID: 70539 RVA: 0x00432F72 File Offset: 0x00431172
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0601138C RID: 70540 RVA: 0x00432F85 File Offset: 0x00431185
	private MotorcycleTechTreeSwitchItem InitItem()
	{
		return new MotorcycleTechTreeSwitchItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle>(this.OnClickItem)
		};
	}

	// Token: 0x0601138D RID: 70541 RVA: 0x00432FA0 File Offset: 0x004311A0
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

	// Token: 0x0601138E RID: 70542 RVA: 0x00433001 File Offset: 0x00431201
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601138F RID: 70543 RVA: 0x0043300C File Offset: 0x0043120C
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

	// Token: 0x04008309 RID: 33545
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400830A RID: 33546
	[Nullable(2)]
	private ButtonItem SwitchBtnItem;

	// Token: 0x0400830B RID: 33547
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MotorcycleTechTreeSwitchItem, int> TechTreeLayout;

	// Token: 0x0400830C RID: 33548
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400830D RID: 33549
	private int SelectedTechTreeType;

	// Token: 0x0400830E RID: 33550
	private int CacheCurTreeType;

	// Token: 0x020087AC RID: 34732
	[NullableContext(0)]
	private class EMotorTechTreeSwitchComponent
	{
		// Token: 0x0402C175 RID: 180597
		public const int ItemCaption = 0;

		// Token: 0x0402C176 RID: 180598
		public const int Layout = 1;

		// Token: 0x0402C177 RID: 180599
		public const int LayoutItem = 2;

		// Token: 0x0402C178 RID: 180600
		public const int BtnConfirm = 3;
	}
}
