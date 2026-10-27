using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002875 RID: 10357
[NullableContext(1)]
[Nullable(0)]
public class RoleBreakPreviewView : UiViewBase
{
	// Token: 0x060154FA RID: 87290 RVA: 0x00561F65 File Offset: 0x00560165
	public RoleBreakPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060154FB RID: 87291 RVA: 0x00561F70 File Offset: 0x00560170
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

	// Token: 0x060154FC RID: 87292 RVA: 0x005620D0 File Offset: 0x005602D0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreakPreviewView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreakPreviewView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060154FD RID: 87293 RVA: 0x00562114 File Offset: 0x00560314
	protected override void OnStart()
	{
		this.LevelLayoutInstance = new GenericLayout<LevelLayoutGrid, ILevelLayoutGridData>(base.GetHorizontalLayout(0), new Func<LevelLayoutGrid>(this.BoundViewModel.CreateLevelLayoutGrid), null, false, true);
		this.ItemLayoutInstance = new GenericLayout<CostMediumItemGrid, ISelectedData>(base.GetHorizontalLayout(3), new Func<CostMediumItemGrid>(this.BoundViewModel.CreateItemLayoutGrid), null, false, true);
		this.BoundViewModel.BindView(this);
		this.BoundViewModel.HandleViewOnStart();
	}

	// Token: 0x060154FE RID: 87294 RVA: 0x00562184 File Offset: 0x00560384
	protected override void OnBeforeDestroy()
	{
		this.BoundViewModel.Dispose();
		this.BoundViewModel = null;
		this.LevelLayoutInstance = null;
		this.ItemLayoutInstance = null;
		this.CostContentItemInstance = null;
	}

	// Token: 0x060154FF RID: 87295 RVA: 0x005621B0 File Offset: 0x005603B0
	public void RefreshLevelLayout(ILevelLayoutGridData[] data)
	{
		List<ILevelLayoutGridData> list = new List<ILevelLayoutGridData>(data.Length);
		for (int i = 0; i < data.Length; i++)
		{
			list.Add(data[i]);
		}
		this.LevelLayoutInstance.RefreshByData(list, null, false);
	}

	// Token: 0x06015500 RID: 87296 RVA: 0x005621EC File Offset: 0x005603EC
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

	// Token: 0x06015501 RID: 87297 RVA: 0x00562232 File Offset: 0x00560432
	public void RefreshLevelContent(int value)
	{
		base.GetText(2).SetText(value.ToString(), true);
	}

	// Token: 0x06015502 RID: 87298 RVA: 0x00562248 File Offset: 0x00560448
	public void RefreshLeftButton(bool active)
	{
		base.GetButton(6).SetSelfInteractive(active);
	}

	// Token: 0x06015503 RID: 87299 RVA: 0x00562257 File Offset: 0x00560457
	public void RefreshRightButton(bool active)
	{
		base.GetButton(7).SetSelfInteractive(active);
	}

	// Token: 0x06015504 RID: 87300 RVA: 0x00562266 File Offset: 0x00560466
	public void RefreshLevelContentItem(bool active)
	{
		base.GetItem(9).SetUIActive(active);
	}

	// Token: 0x06015505 RID: 87301 RVA: 0x00562276 File Offset: 0x00560476
	public void RefreshHasBrokenTip(bool active)
	{
		base.GetText(10).SetUIActive(active);
	}

	// Token: 0x06015506 RID: 87302 RVA: 0x00562286 File Offset: 0x00560486
	private void OnClickLeft()
	{
		this.BoundViewModel.HandleClickLeft();
	}

	// Token: 0x06015507 RID: 87303 RVA: 0x00562293 File Offset: 0x00560493
	private void OnClickRight()
	{
		this.BoundViewModel.HandleClickRight();
	}

	// Token: 0x06015508 RID: 87304 RVA: 0x005622A0 File Offset: 0x005604A0
	private void OnClickClose()
	{
		this.BoundViewModel.HandleViewClosePromise(UiManager.Instance.CloseViewAsync(EUiViewName.RoleBreakPreviewView));
	}

	// Token: 0x04009F4C RID: 40780
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<LevelLayoutGrid, ILevelLayoutGridData> LevelLayoutInstance;

	// Token: 0x04009F4D RID: 40781
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CostMediumItemGrid, ISelectedData> ItemLayoutInstance;

	// Token: 0x04009F4E RID: 40782
	[Nullable(2)]
	private CostContentItem CostContentItemInstance;

	// Token: 0x04009F4F RID: 40783
	[Nullable(2)]
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x02008E8A RID: 36490
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E3A8 RID: 189352
		LevelLayout,
		// Token: 0x0402E3A9 RID: 189353
		LevelLayoutTemplate,
		// Token: 0x0402E3AA RID: 189354
		LevelContent,
		// Token: 0x0402E3AB RID: 189355
		ItemLayout,
		// Token: 0x0402E3AC RID: 189356
		ItemLayoutTemplate,
		// Token: 0x0402E3AD RID: 189357
		CostContentItem,
		// Token: 0x0402E3AE RID: 189358
		LeftButton,
		// Token: 0x0402E3AF RID: 189359
		RightButton,
		// Token: 0x0402E3B0 RID: 189360
		CloseButton,
		// Token: 0x0402E3B1 RID: 189361
		LevelContentItem,
		// Token: 0x0402E3B2 RID: 189362
		HasBrokenTip
	}
}
