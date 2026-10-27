using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D6B RID: 11627
public class WorldLevelInfoView : UiTickViewBase
{
	// Token: 0x17002108 RID: 8456
	// (get) Token: 0x06018734 RID: 100148 RVA: 0x006394C7 File Offset: 0x006376C7
	// (set) Token: 0x06018735 RID: 100149 RVA: 0x006394D0 File Offset: 0x006376D0
	public bool CanShowInteractCd
	{
		get
		{
			return this.ShowInteractCd;
		}
		set
		{
			if (this.ShowInteractCd != value)
			{
				this.ShowInteractCd = value;
				UUIItem item = base.GetItem(8);
				bool uiactive;
				if (!this.ShowInteractCd)
				{
					int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
					int? conditionLevel = this.ConditionLevel;
					uiactive = (originWorldLevel >= conditionLevel.GetValueOrDefault() & conditionLevel != null);
				}
				else
				{
					uiactive = false;
				}
				item.SetUIActive(uiactive);
				base.GetItem(4).SetUIActive(this.ShowInteractCd);
			}
		}
	}

	// Token: 0x06018736 RID: 100150 RVA: 0x0063953B File Offset: 0x0063773B
	[NullableContext(1)]
	public WorldLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06018737 RID: 100151 RVA: 0x00639544 File Offset: 0x00637744
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnWorldLevelBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06018738 RID: 100152 RVA: 0x006396D4 File Offset: 0x006378D4
	protected override void OnStart()
	{
		this.WorldLevelChangeCd = WorldLevelConfig.Instance.GetCommonValue("world_level_change_cd");
		this.ConditionLevel = WorldLevelConfig.Instance.GetCommonValue("world_level_change_conditon_level");
		base.GetItem(3).SetUIActive(true);
		base.GetItem(8).SetUIActive(true);
		this.SetTitleText();
		this.SetDescribeText();
		this.InitInteractNode();
	}

	// Token: 0x06018739 RID: 100153 RVA: 0x00639737 File Offset: 0x00637937
	protected override void OnTick(float delta)
	{
		this.UpdateInteract();
	}

	// Token: 0x0601873A RID: 100154 RVA: 0x0063973F File Offset: 0x0063793F
	private void SetTitleText()
	{
		base.GetText(0).SetText(WorldLevelModel.Instance.WorldLevelMultilingualText, true);
	}

	// Token: 0x0601873B RID: 100155 RVA: 0x00639758 File Offset: 0x00637958
	private void SetDescribeText()
	{
		string textById = TextConfig.Instance.GetTextById("WorldLevelIntro");
		base.GetText(2).SetText(textById, true);
	}

	// Token: 0x0601873C RID: 100156 RVA: 0x00639784 File Offset: 0x00637984
	private void InitInteractNode()
	{
		int interactTimeToLast = this.GetInteractTimeToLast();
		bool flag = Math.Max(this.WorldLevelChangeCd.Value - interactTimeToLast, 0) > 0;
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		int? conditionLevel = this.ConditionLevel;
		if ((originWorldLevel < conditionLevel.GetValueOrDefault() & conditionLevel != null) || flag)
		{
			base.GetItem(8).SetUIActive(false);
			return;
		}
		this.UpdateInteract();
	}

	// Token: 0x0601873D RID: 100157 RVA: 0x006397EC File Offset: 0x006379EC
	private void UpdateInteract()
	{
		int interactTimeToLast = this.GetInteractTimeToLast();
		int num = Math.Max(this.WorldLevelChangeCd.Value - interactTimeToLast, 0);
		this.CanShowInteractCd = (num > 0);
		if (this.CanShowInteractCd)
		{
			base.GetText(6).SetText(ShopUtils.FormatTime(num), true);
			return;
		}
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		string newText = "";
		if (curWorldLevel == originWorldLevel)
		{
			WorldLevelModel.Instance.WorldLevelChangeTarget = curWorldLevel - 1;
			newText = TextConfig.Instance.GetTextById("WorldLevelDown");
		}
		else if (curWorldLevel < originWorldLevel)
		{
			WorldLevelModel.Instance.WorldLevelChangeTarget = curWorldLevel + 1;
			newText = TextConfig.Instance.GetTextById("WorldLevelRestore");
		}
		base.GetText(7).SetText(newText, true);
	}

	// Token: 0x0601873E RID: 100158 RVA: 0x006398AC File Offset: 0x00637AAC
	private int GetInteractTimeToLast()
	{
		return (int)TimeUtil.Instance.GetServerTime() - WorldLevelModel.Instance.LastChangeWorldLevelTimeStamp;
	}

	// Token: 0x0601873F RID: 100159 RVA: 0x006398C4 File Offset: 0x00637AC4
	private void OnWorldLevelBtnClick()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsById("OnlineCantChangeLevel", Array.Empty<object>());
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.WorldLevelInfoView, null);
		if (!UiManager.Instance.IsViewShow(EUiViewName.WorldLevelChangeConfirmView))
		{
			UiManager.Instance.OpenView(EUiViewName.WorldLevelChangeConfirmView, null, null);
		}
	}

	// Token: 0x0400B54B RID: 46411
	private bool ShowInteractCd;

	// Token: 0x0400B54C RID: 46412
	private int? ConditionLevel;

	// Token: 0x0400B54D RID: 46413
	private int? WorldLevelChangeCd;
}
