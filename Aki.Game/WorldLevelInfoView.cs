using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022C5 RID: 8901
public class WorldLevelInfoView : UiTickViewBase
{
	// Token: 0x17002163 RID: 8547
	// (get) Token: 0x06015FD6 RID: 90070 RVA: 0x0065F4DF File Offset: 0x0065D6DF
	// (set) Token: 0x06015FD7 RID: 90071 RVA: 0x0065F4E8 File Offset: 0x0065D6E8
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

	// Token: 0x06015FD8 RID: 90072 RVA: 0x0065F553 File Offset: 0x0065D753
	[NullableContext(1)]
	public WorldLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015FD9 RID: 90073 RVA: 0x0065F55C File Offset: 0x0065D75C
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

	// Token: 0x06015FDA RID: 90074 RVA: 0x0065F6EC File Offset: 0x0065D8EC
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

	// Token: 0x06015FDB RID: 90075 RVA: 0x0065F74F File Offset: 0x0065D94F
	protected override void OnTick(float delta)
	{
		this.UpdateInteract();
	}

	// Token: 0x06015FDC RID: 90076 RVA: 0x0065F757 File Offset: 0x0065D957
	private void SetTitleText()
	{
		base.GetText(0).SetText(WorldLevelModel.Instance.WorldLevelMultilingualText, true);
	}

	// Token: 0x06015FDD RID: 90077 RVA: 0x0065F770 File Offset: 0x0065D970
	private void SetDescribeText()
	{
		string textById = TextConfig.Instance.GetTextById("WorldLevelIntro");
		base.GetText(2).SetText(textById, true);
	}

	// Token: 0x06015FDE RID: 90078 RVA: 0x0065F79C File Offset: 0x0065D99C
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

	// Token: 0x06015FDF RID: 90079 RVA: 0x0065F804 File Offset: 0x0065DA04
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

	// Token: 0x06015FE0 RID: 90080 RVA: 0x0065F8C4 File Offset: 0x0065DAC4
	private int GetInteractTimeToLast()
	{
		return (int)TimeUtil.Instance.GetServerTime() - WorldLevelModel.Instance.LastChangeWorldLevelTimeStamp;
	}

	// Token: 0x06015FE1 RID: 90081 RVA: 0x0065F8DC File Offset: 0x0065DADC
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

	// Token: 0x0400B8C0 RID: 47296
	private bool ShowInteractCd;

	// Token: 0x0400B8C1 RID: 47297
	private int? ConditionLevel;

	// Token: 0x0400B8C2 RID: 47298
	private int? WorldLevelChangeCd;
}
