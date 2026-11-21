using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.ItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E1F RID: 3615
[NullableContext(1)]
[Nullable(0)]
public class CommonResultView : UiViewBase
{
	// Token: 0x06009218 RID: 37400 RVA: 0x002BABB6 File Offset: 0x002B8DB6
	public CommonResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009219 RID: 37401 RVA: 0x002BABCC File Offset: 0x002B8DCC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite))
		};
	}

	// Token: 0x0600921A RID: 37402 RVA: 0x002BAC94 File Offset: 0x002B8E94
	protected override void OnStart()
	{
		base.GetText(2).SetUIActive(false);
		this.SetResultText("ChallengeGetReward");
		base.GetItem(3).SetUIActive(false);
		this.ButtonMap = new Dictionary<string, CommonResultButton>();
		this.ButtonItemMap = new Dictionary<string, UUIItem>();
		this.SetupButtonFormat();
		this.RewardLayout = new GenericLayoutNew<CommonItemSimpleGrid>(base.GetHorizontalLayout(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSimpleGrid>(this.InitScrollViewItem), null);
		this.InitTimer();
	}

	// Token: 0x0600921B RID: 37403 RVA: 0x002BAD07 File Offset: 0x002B8F07
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		this.ResetButtonList();
		this.RewardLayout.ClearChildren();
		this.RewardLayout = null;
	}

	// Token: 0x0600921C RID: 37404 RVA: 0x002BAD27 File Offset: 0x002B8F27
	protected virtual void SetupButtonFormat()
	{
	}

	// Token: 0x0600921D RID: 37405 RVA: 0x002BAD2C File Offset: 0x002B8F2C
	private CommonResultButton CreateButtonUsingTemplateButton(CommonResultButtonData data)
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		CommonResultButton commonResultButton = new CommonResultButton(LguiUtil.Instance.CopyItem(item, item2));
		commonResultButton.SetData(data);
		return commonResultButton;
	}

	// Token: 0x0600921E RID: 37406 RVA: 0x002BAD64 File Offset: 0x002B8F64
	private void ResetButtonList()
	{
		foreach (CommonResultButton commonResultButton in this.ButtonMap.Values)
		{
			commonResultButton.Destroy(null);
		}
		this.ButtonMap.Clear();
		this.ButtonItemMap.Clear();
	}

	// Token: 0x0600921F RID: 37407 RVA: 0x002BADD0 File Offset: 0x002B8FD0
	public void RefreshButtonList(List<CommonResultButtonData> dataList)
	{
		foreach (CommonResultButton commonResultButton in this.ButtonArray)
		{
			commonResultButton.ResetData();
			commonResultButton.SetActive(false);
		}
		int count = dataList.Count;
		List<CommonResultButton> buttonArray = this.ButtonArray;
		int count2 = buttonArray.Count;
		for (int i = 0; i < count; i++)
		{
			if (i < count2)
			{
				CommonResultButton commonResultButton2 = buttonArray[i];
				commonResultButton2.SetData(dataList[i]);
				commonResultButton2.SetActive(true);
			}
			else
			{
				CommonResultButton commonResultButton3 = this.CreateButtonUsingTemplateButton(dataList[i]);
				this.ButtonArray.Add(commonResultButton3);
				commonResultButton3.SetActive(true);
			}
		}
		foreach (CommonResultButton commonResultButton4 in this.ButtonArray)
		{
			commonResultButton4.DoRefreshCallBack();
		}
	}

	// Token: 0x06009220 RID: 37408 RVA: 0x002BAED4 File Offset: 0x002B90D4
	private ILayoutItem<CommonItemSimpleGrid> InitScrollViewItem(object data, UUIItem uiItem, int index)
	{
		CommonItemSimpleGrid commonItemSimpleGrid = new CommonItemSimpleGrid(uiItem.GetOwner());
		commonItemSimpleGrid.RefreshItem(((TItem)data).ItemData.ItemId, ((TItem)data).Count);
		return new LayoutItem<CommonItemSimpleGrid>
		{
			Key = index,
			Value = commonItemSimpleGrid
		};
	}

	// Token: 0x06009221 RID: 37409 RVA: 0x002BAF26 File Offset: 0x002B9126
	public void SetResultText(string textId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x06009222 RID: 37410 RVA: 0x002BAF3F File Offset: 0x002B913F
	public void SetTipsText(string textId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, Array.Empty<object>());
		base.GetText(2).SetUIActive(true);
	}

	// Token: 0x06009223 RID: 37411 RVA: 0x002BAF65 File Offset: 0x002B9165
	private void InitTimer()
	{
		this.CounterTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Timer), 1000f, 1f, null, null, true);
	}

	// Token: 0x06009224 RID: 37412 RVA: 0x002BAF90 File Offset: 0x002B9190
	private void Timer(float _)
	{
		foreach (CommonResultButton commonResultButton in this.ButtonArray)
		{
			commonResultButton.DoTimerCallBack(this.HasRunTime);
		}
		this.HasRunTime++;
		this.OnTimer();
	}

	// Token: 0x06009225 RID: 37413 RVA: 0x002BAFFC File Offset: 0x002B91FC
	protected virtual void OnTimer()
	{
	}

	// Token: 0x06009226 RID: 37414 RVA: 0x002BAFFE File Offset: 0x002B91FE
	private void ClearTimer()
	{
		if (this.CounterTimer != null && TimerSystem.GameplayTimeInstance.Has(this.CounterTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CounterTimer);
		}
		this.CounterTimer = null;
	}

	// Token: 0x04005660 RID: 22112
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, CommonResultButton> ButtonMap;

	// Token: 0x04005661 RID: 22113
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UUIItem> ButtonItemMap;

	// Token: 0x04005662 RID: 22114
	private readonly List<CommonResultButton> ButtonArray = new List<CommonResultButton>();

	// Token: 0x04005663 RID: 22115
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<CommonItemSimpleGrid> RewardLayout;

	// Token: 0x04005664 RID: 22116
	[Nullable(2)]
	private TimerHandle CounterTimer;

	// Token: 0x04005665 RID: 22117
	private int HasRunTime;

	// Token: 0x02007047 RID: 28743
	[NullableContext(0)]
	public enum ECommonResultView
	{
		// Token: 0x04024A14 RID: 150036
		PanelContent,
		// Token: 0x04024A15 RID: 150037
		ResultText,
		// Token: 0x04024A16 RID: 150038
		TipsText,
		// Token: 0x04024A17 RID: 150039
		ButtonTemplate,
		// Token: 0x04024A18 RID: 150040
		ButtonParent,
		// Token: 0x04024A19 RID: 150041
		TeamPlayerItem,
		// Token: 0x04024A1A RID: 150042
		TeamPlayer1Sprite,
		// Token: 0x04024A1B RID: 150043
		TeamPlayer2Sprite
	}
}
