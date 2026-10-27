using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ECB RID: 7883
public class PnlTeam : UiPanelBase
{
	// Token: 0x0600F26B RID: 62059 RVA: 0x003A6D2C File Offset: 0x003A4F2C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnTeamBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F26C RID: 62060 RVA: 0x003A6E56 File Offset: 0x003A5056
	protected override void OnStart()
	{
		this.InitBoxList();
		this.RefreshView();
	}

	// Token: 0x0600F26D RID: 62061 RVA: 0x003A6E64 File Offset: 0x003A5064
	private void InitBoxList()
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		for (int i = 0; i < 3; i++)
		{
			UUIItem uuiitem;
			if (i == 0)
			{
				uuiitem = item2;
			}
			else
			{
				uuiitem = LguiUtil.Instance.CopyItem(item2, item);
			}
			PnlHeadBox pnlHeadBox = new PnlHeadBox();
			pnlHeadBox.CreateThenShowByActor(uuiitem.GetOwner(), null);
			this.HeadBoxItemList.Add(pnlHeadBox);
		}
	}

	// Token: 0x0600F26E RID: 62062 RVA: 0x003A6EC8 File Offset: 0x003A50C8
	public void RefreshView()
	{
		int powerLevel = HonamiStoryModel.Instance.GetPlayerData().PowerLevel;
		base.GetText(1).SetText(powerLevel.ToString(), true);
		bool uiactive = HonamiStoryModel.Instance.QuickAllCheck(false);
		base.GetSprite(2).SetUIActive(uiactive);
		base.GetItem(5).SetUIActive(uiactive);
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		if (allRoleIdList == null)
		{
			return;
		}
		for (int i = 0; i < this.HeadBoxItemList.Count; i++)
		{
			if (i < allRoleIdList.Length)
			{
				this.HeadBoxItemList[i].RefreshView(allRoleIdList[i]);
			}
			else
			{
				this.HeadBoxItemList[i].RefreshView(0);
			}
		}
	}

	// Token: 0x0600F26F RID: 62063 RVA: 0x003A6F72 File Offset: 0x003A5172
	private void OnTeamBtnClick()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x0400704D RID: 28749
	[Nullable(1)]
	private readonly List<PnlHeadBox> HeadBoxItemList = new List<PnlHeadBox>();
}
