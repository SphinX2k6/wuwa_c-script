using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200138D RID: 5005
public class PnlTeam : UiPanelBase
{
	// Token: 0x0600C68A RID: 50826 RVA: 0x003B282C File Offset: 0x003B0A2C
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

	// Token: 0x0600C68B RID: 50827 RVA: 0x003B2956 File Offset: 0x003B0B56
	protected override void OnStart()
	{
		this.InitBoxList();
		this.RefreshView();
	}

	// Token: 0x0600C68C RID: 50828 RVA: 0x003B2964 File Offset: 0x003B0B64
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

	// Token: 0x0600C68D RID: 50829 RVA: 0x003B29C8 File Offset: 0x003B0BC8
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

	// Token: 0x0600C68E RID: 50830 RVA: 0x003B2A72 File Offset: 0x003B0C72
	private void OnTeamBtnClick()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x0400712E RID: 28974
	[Nullable(1)]
	private readonly List<PnlHeadBox> HeadBoxItemList = new List<PnlHeadBox>();
}
