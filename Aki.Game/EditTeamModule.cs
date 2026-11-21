using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007C4 RID: 1988
[NullableContext(1)]
[Nullable(0)]
public class EditTeamModule : UiPanelBase
{
	// Token: 0x06005AD2 RID: 23250 RVA: 0x001D6984 File Offset: 0x001D4B84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x001D69E0 File Offset: 0x001D4BE0
	protected override UniTask OnBeforeStartAsync()
	{
		EditTeamModule.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<EditTeamModule.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x001D6A24 File Offset: 0x001D4C24
	public UniTask RefreshEditTeamModule()
	{
		EditTeamModule.<RefreshEditTeamModule>d__8 <RefreshEditTeamModule>d__;
		<RefreshEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEditTeamModule>d__.<>4__this = this;
		<RefreshEditTeamModule>d__.<>1__state = -1;
		<RefreshEditTeamModule>d__.<>t__builder.Start<EditTeamModule.<RefreshEditTeamModule>d__8>(ref <RefreshEditTeamModule>d__);
		return <RefreshEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x001D6A67 File Offset: 0x001D4C67
	private EditTeamItem InitScrollItem()
	{
		EditTeamItem editTeamItem = new EditTeamItem();
		editTeamItem.SetClickEvent(this.OnClickEvent);
		editTeamItem.SetCanExecuteChange(this.CanExecuteChange);
		editTeamItem.SetIsItemSelected(this.IsItemSelected);
		return editTeamItem;
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x001D6A92 File Offset: 0x001D4C92
	public void SetClickEvent(TEditTeamClick onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x06005AD7 RID: 23255 RVA: 0x001D6A9B File Offset: 0x001D4C9B
	[NullableContext(2)]
	public void SetCanExecuteChange(TEditTeamCanExecuteChange canExecuteChange)
	{
		this.CanExecuteChange = canExecuteChange;
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x001D6AA4 File Offset: 0x001D4CA4
	[NullableContext(2)]
	public void SetIsItemSelected(TEditTeamItemSelected isItemSelected)
	{
		this.IsItemSelected = isItemSelected;
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x001D6AAD File Offset: 0x001D4CAD
	public void SelectEditTeamItem(int index, bool fireEvent = false)
	{
		LoopScrollView<EditTeamItem, EditTeamData> loopScroll = this.LoopScroll;
		if (loopScroll == null)
		{
			return;
		}
		loopScroll.SelectGridProxy(index, fireEvent);
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x001D6AC1 File Offset: 0x001D4CC1
	public void SetEditTeamDataList(List<EditTeamData> dataList)
	{
		this.DataList = dataList;
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x001D6ACA File Offset: 0x001D4CCA
	public int GetDataLength()
	{
		return this.DataList.Count;
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x001D6AD8 File Offset: 0x001D4CD8
	public int GetSelectGridIndex()
	{
		int selectedGridIndex = this.LoopScroll.GetSelectedGridIndex();
		if (selectedGridIndex != -1)
		{
			return selectedGridIndex;
		}
		return 0;
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x001D6AF8 File Offset: 0x001D4CF8
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
		if (a == "Helper".ToString())
		{
			int num = -1;
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].GetTeamDataUnLockState() == EEditTeamDataUnLockState.TaskUnFinish)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return null;
			}
			LoopScrollView<EditTeamItem, EditTeamData> loopScroll = this.LoopScroll;
			UUIItem uuiitem = (loopScroll != null) ? loopScroll.GetGrid(num) : null;
			if (uuiitem == null)
			{
				return null;
			}
			LoopScrollView<EditTeamItem, EditTeamData> loopScroll2 = this.LoopScroll;
			if (loopScroll2 != null)
			{
				loopScroll2.ScrollToGridIndex(num, true);
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else
		{
			if (!(a == "Delegation".ToString()) && !(a == "HelperFirst".ToString()))
			{
				return null;
			}
			LoopScrollView<EditTeamItem, EditTeamData> loopScroll3 = this.LoopScroll;
			UUIItem uuiitem2 = (loopScroll3 != null) ? loopScroll3.GetGrid(0) : null;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x001D6BE5 File Offset: 0x001D4DE5
	public void SetTitleItemActive(bool value)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x04003CF5 RID: 15605
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<EditTeamItem, EditTeamData> LoopScroll;

	// Token: 0x04003CF6 RID: 15606
	protected TEditTeamClick OnClickEvent;

	// Token: 0x04003CF7 RID: 15607
	[Nullable(2)]
	protected TEditTeamCanExecuteChange CanExecuteChange;

	// Token: 0x04003CF8 RID: 15608
	[Nullable(2)]
	protected TEditTeamItemSelected IsItemSelected;

	// Token: 0x04003CF9 RID: 15609
	protected List<EditTeamData> DataList = new List<EditTeamData>();

	// Token: 0x02006AD8 RID: 27352
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023271 RID: 143985
		public const int Scroll = 0;

		// Token: 0x04023272 RID: 143986
		public const int ScrollItem = 1;

		// Token: 0x04023273 RID: 143987
		public const int TitleItem = 2;
	}
}
