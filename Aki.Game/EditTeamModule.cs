using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001310 RID: 4880
[NullableContext(1)]
[Nullable(0)]
public class EditTeamModule : UiPanelBase
{
	// Token: 0x06008737 RID: 34615 RVA: 0x001CDB18 File Offset: 0x001CBD18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06008738 RID: 34616 RVA: 0x001CDB74 File Offset: 0x001CBD74
	protected override UniTask OnBeforeStartAsync()
	{
		EditTeamModule.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<EditTeamModule.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008739 RID: 34617 RVA: 0x001CDBB8 File Offset: 0x001CBDB8
	public UniTask RefreshEditTeamModule()
	{
		EditTeamModule.<RefreshEditTeamModule>d__8 <RefreshEditTeamModule>d__;
		<RefreshEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEditTeamModule>d__.<>4__this = this;
		<RefreshEditTeamModule>d__.<>1__state = -1;
		<RefreshEditTeamModule>d__.<>t__builder.Start<EditTeamModule.<RefreshEditTeamModule>d__8>(ref <RefreshEditTeamModule>d__);
		return <RefreshEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x0600873A RID: 34618 RVA: 0x001CDBFB File Offset: 0x001CBDFB
	private EditTeamItem InitScrollItem()
	{
		EditTeamItem editTeamItem = new EditTeamItem();
		editTeamItem.SetClickEvent(this.OnClickEvent);
		editTeamItem.SetCanExecuteChange(this.CanExecuteChange);
		editTeamItem.SetIsItemSelected(this.IsItemSelected);
		return editTeamItem;
	}

	// Token: 0x0600873B RID: 34619 RVA: 0x001CDC26 File Offset: 0x001CBE26
	public void SetClickEvent(TEditTeamClick onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x0600873C RID: 34620 RVA: 0x001CDC2F File Offset: 0x001CBE2F
	[NullableContext(2)]
	public void SetCanExecuteChange(TEditTeamCanExecuteChange canExecuteChange)
	{
		this.CanExecuteChange = canExecuteChange;
	}

	// Token: 0x0600873D RID: 34621 RVA: 0x001CDC38 File Offset: 0x001CBE38
	[NullableContext(2)]
	public void SetIsItemSelected(TEditTeamItemSelected isItemSelected)
	{
		this.IsItemSelected = isItemSelected;
	}

	// Token: 0x0600873E RID: 34622 RVA: 0x001CDC41 File Offset: 0x001CBE41
	public void SelectEditTeamItem(int index, bool fireEvent = false)
	{
		LoopScrollView<EditTeamItem, EditTeamData> loopScroll = this.LoopScroll;
		if (loopScroll == null)
		{
			return;
		}
		loopScroll.SelectGridProxy(index, fireEvent);
	}

	// Token: 0x0600873F RID: 34623 RVA: 0x001CDC55 File Offset: 0x001CBE55
	public void SetEditTeamDataList(List<EditTeamData> dataList)
	{
		this.DataList = dataList;
	}

	// Token: 0x06008740 RID: 34624 RVA: 0x001CDC5E File Offset: 0x001CBE5E
	public int GetDataLength()
	{
		return this.DataList.Count;
	}

	// Token: 0x06008741 RID: 34625 RVA: 0x001CDC6C File Offset: 0x001CBE6C
	public int GetSelectGridIndex()
	{
		int selectedGridIndex = this.LoopScroll.GetSelectedGridIndex();
		if (selectedGridIndex != -1)
		{
			return selectedGridIndex;
		}
		return 0;
	}

	// Token: 0x06008742 RID: 34626 RVA: 0x001CDC8C File Offset: 0x001CBE8C
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

	// Token: 0x06008743 RID: 34627 RVA: 0x001CDD79 File Offset: 0x001CBF79
	public void SetTitleItemActive(bool value)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x04003C5D RID: 15453
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<EditTeamItem, EditTeamData> LoopScroll;

	// Token: 0x04003C5E RID: 15454
	protected TEditTeamClick OnClickEvent;

	// Token: 0x04003C5F RID: 15455
	[Nullable(2)]
	protected TEditTeamCanExecuteChange CanExecuteChange;

	// Token: 0x04003C60 RID: 15456
	[Nullable(2)]
	protected TEditTeamItemSelected IsItemSelected;

	// Token: 0x04003C61 RID: 15457
	protected List<EditTeamData> DataList = new List<EditTeamData>();

	// Token: 0x0200794E RID: 31054
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F44 RID: 163652
		public const int Scroll = 0;

		// Token: 0x04027F45 RID: 163653
		public const int ScrollItem = 1;

		// Token: 0x04027F46 RID: 163654
		public const int TitleItem = 2;
	}
}
