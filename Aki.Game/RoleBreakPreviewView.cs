using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DF0 RID: 7664
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewView : UiViewBase
{
	// Token: 0x06012EF8 RID: 77560 RVA: 0x0058CCC1 File Offset: 0x0058AEC1
	public RoleBreakPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012EF9 RID: 77561 RVA: 0x0058CCCC File Offset: 0x0058AECC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickLeft)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickRight)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickClose))
		};
	}

	// Token: 0x06012EFA RID: 77562 RVA: 0x0058CE2C File Offset: 0x0058B02C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreakPreviewView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreakPreviewView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012EFB RID: 77563 RVA: 0x0058CE70 File Offset: 0x0058B070
	protected override void OnStart()
	{
		this.LevelLayoutInstance = new GenericLayout<LevelLayoutGrid, ILevelLayoutGridData>(base.GetHorizontalLayout(0), new Func<LevelLayoutGrid>(this.BoundViewModel.CreateLevelLayoutGrid), null, false, true);
		this.ItemLayoutInstance = new GenericLayout<CostMediumItemGrid, ISelectedData>(base.GetHorizontalLayout(3), new Func<CostMediumItemGrid>(this.BoundViewModel.CreateItemLayoutGrid), null, false, true);
		this.BoundViewModel.BindView(this);
		this.BoundViewModel.HandleViewOnStart();
	}

	// Token: 0x06012EFC RID: 77564 RVA: 0x0058CEE0 File Offset: 0x0058B0E0
	protected override void OnBeforeDestroy()
	{
		this.BoundViewModel.Dispose();
		this.BoundViewModel = null;
		this.LevelLayoutInstance = null;
		this.ItemLayoutInstance = null;
		this.CostContentItemInstance = null;
	}

	// Token: 0x06012EFD RID: 77565 RVA: 0x0058CF0C File Offset: 0x0058B10C
	public void RefreshLevelLayout(ILevelLayoutGridData[] data)
	{
		List<ILevelLayoutGridData> list = new List<ILevelLayoutGridData>(data.Length);
		for (int i = 0; i < data.Length; i++)
		{
			list.Add(data[i]);
		}
		this.LevelLayoutInstance.RefreshByData(list, null, false);
	}

	// Token: 0x06012EFE RID: 77566 RVA: 0x0058CF48 File Offset: 0x0058B148
	public void RefreshItemLayout(ISelectedData[] data)
	{
		List<ISelectedData> list = new List<ISelectedData>(data.Length);
		for (int i = 0; i < data.Length; i++)
		{
			list.Add(data[i]);
		}
		this.ItemLayoutInstance.RefreshByData(list, delegate
		{
			GenericLayout<CostMediumItemGrid, ISelectedData> itemLayoutInstance = this.ItemLayoutInstance;
			if (itemLayoutInstance == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = itemLayoutInstance.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}, false);
	}

	// Token: 0x06012EFF RID: 77567 RVA: 0x0058CF8E File Offset: 0x0058B18E
	public void RefreshLevelContent(int value)
	{
		base.GetText(2).SetText(value.ToString(), true);
	}

	// Token: 0x06012F00 RID: 77568 RVA: 0x0058CFA4 File Offset: 0x0058B1A4
	public void RefreshLeftButton(bool active)
	{
		base.GetButton(6).SetSelfInteractive(active);
	}

	// Token: 0x06012F01 RID: 77569 RVA: 0x0058CFB3 File Offset: 0x0058B1B3
	public void RefreshRightButton(bool active)
	{
		base.GetButton(7).SetSelfInteractive(active);
	}

	// Token: 0x06012F02 RID: 77570 RVA: 0x0058CFC2 File Offset: 0x0058B1C2
	public void RefreshLevelContentItem(bool active)
	{
		base.GetItem(9).SetUIActive(active);
	}

	// Token: 0x06012F03 RID: 77571 RVA: 0x0058CFD2 File Offset: 0x0058B1D2
	public void RefreshHasBrokenTip(bool active)
	{
		base.GetText(10).SetUIActive(active);
	}

	// Token: 0x06012F04 RID: 77572 RVA: 0x0058CFE2 File Offset: 0x0058B1E2
	private void OnClickLeft()
	{
		this.BoundViewModel.HandleClickLeft();
	}

	// Token: 0x06012F05 RID: 77573 RVA: 0x0058CFEF File Offset: 0x0058B1EF
	private void OnClickRight()
	{
		this.BoundViewModel.HandleClickRight();
	}

	// Token: 0x06012F06 RID: 77574 RVA: 0x0058CFFC File Offset: 0x0058B1FC
	private void OnClickClose()
	{
		this.BoundViewModel.HandleViewClosePromise(UiManager.Instance.CloseViewAsync(EUiViewName.RoleBreakPreviewView));
	}

	// Token: 0x0400A335 RID: 41781
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<LevelLayoutGrid, ILevelLayoutGridData> LevelLayoutInstance;

	// Token: 0x0400A336 RID: 41782
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CostMediumItemGrid, ISelectedData> ItemLayoutInstance;

	// Token: 0x0400A337 RID: 41783
	[Nullable(2)]
	private CostContentItem CostContentItemInstance;

	// Token: 0x0400A338 RID: 41784
	[Nullable(2)]
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x020080D0 RID: 32976
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029AA2 RID: 170658
		LevelLayout,
		// Token: 0x04029AA3 RID: 170659
		LevelLayoutTemplate,
		// Token: 0x04029AA4 RID: 170660
		LevelContent,
		// Token: 0x04029AA5 RID: 170661
		ItemLayout,
		// Token: 0x04029AA6 RID: 170662
		ItemLayoutTemplate,
		// Token: 0x04029AA7 RID: 170663
		CostContentItem,
		// Token: 0x04029AA8 RID: 170664
		LeftButton,
		// Token: 0x04029AA9 RID: 170665
		RightButton,
		// Token: 0x04029AAA RID: 170666
		CloseButton,
		// Token: 0x04029AAB RID: 170667
		LevelContentItem,
		// Token: 0x04029AAC RID: 170668
		HasBrokenTip
	}
}
