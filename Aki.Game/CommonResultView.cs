using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.ItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001962 RID: 6498
[NullableContext(1)]
[Nullable(0)]
public class CommonResultView : UiViewBase
{
	// Token: 0x0600BE15 RID: 48661 RVA: 0x002AFD72 File Offset: 0x002ADF72
	public CommonResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BE16 RID: 48662 RVA: 0x002AFD88 File Offset: 0x002ADF88
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

	// Token: 0x0600BE17 RID: 48663 RVA: 0x002AFE50 File Offset: 0x002AE050
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

	// Token: 0x0600BE18 RID: 48664 RVA: 0x002AFEC3 File Offset: 0x002AE0C3
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		this.ResetButtonList();
		this.RewardLayout.ClearChildren();
		this.RewardLayout = null;
	}

	// Token: 0x0600BE19 RID: 48665 RVA: 0x002AFEE3 File Offset: 0x002AE0E3
	protected virtual void SetupButtonFormat()
	{
	}

	// Token: 0x0600BE1A RID: 48666 RVA: 0x002AFEE8 File Offset: 0x002AE0E8
	private CommonResultButton CreateButtonUsingTemplateButton(CommonResultButtonData data)
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		CommonResultButton commonResultButton = new CommonResultButton(LguiUtil.Instance.CopyItem(item, item2));
		commonResultButton.SetData(data);
		return commonResultButton;
	}

	// Token: 0x0600BE1B RID: 48667 RVA: 0x002AFF20 File Offset: 0x002AE120
	private void ResetButtonList()
	{
		foreach (CommonResultButton commonResultButton in this.ButtonMap.Values)
		{
			commonResultButton.Destroy(null);
		}
		this.ButtonMap.Clear();
		this.ButtonItemMap.Clear();
	}

	// Token: 0x0600BE1C RID: 48668 RVA: 0x002AFF8C File Offset: 0x002AE18C
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

	// Token: 0x0600BE1D RID: 48669 RVA: 0x002B0090 File Offset: 0x002AE290
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

	// Token: 0x0600BE1E RID: 48670 RVA: 0x002B00E2 File Offset: 0x002AE2E2
	public void SetResultText(string textId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x0600BE1F RID: 48671 RVA: 0x002B00FB File Offset: 0x002AE2FB
	public void SetTipsText(string textId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, Array.Empty<object>());
		base.GetText(2).SetUIActive(true);
	}

	// Token: 0x0600BE20 RID: 48672 RVA: 0x002B0121 File Offset: 0x002AE321
	private void InitTimer()
	{
		this.CounterTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Timer), 1000f, 1f, null, null, true);
	}

	// Token: 0x0600BE21 RID: 48673 RVA: 0x002B014C File Offset: 0x002AE34C
	private void Timer(float _)
	{
		foreach (CommonResultButton commonResultButton in this.ButtonArray)
		{
			commonResultButton.DoTimerCallBack(this.HasRunTime);
		}
		this.HasRunTime++;
		this.OnTimer();
	}

	// Token: 0x0600BE22 RID: 48674 RVA: 0x002B01B8 File Offset: 0x002AE3B8
	protected virtual void OnTimer()
	{
	}

	// Token: 0x0600BE23 RID: 48675 RVA: 0x002B01BA File Offset: 0x002AE3BA
	private void ClearTimer()
	{
		if (this.CounterTimer != null && TimerSystem.GameplayTimeInstance.Has(this.CounterTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CounterTimer);
		}
		this.CounterTimer = null;
	}

	// Token: 0x040055B3 RID: 21939
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, CommonResultButton> ButtonMap;

	// Token: 0x040055B4 RID: 21940
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<string, UUIItem> ButtonItemMap;

	// Token: 0x040055B5 RID: 21941
	private readonly List<CommonResultButton> ButtonArray = new List<CommonResultButton>();

	// Token: 0x040055B6 RID: 21942
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<CommonItemSimpleGrid> RewardLayout;

	// Token: 0x040055B7 RID: 21943
	[Nullable(2)]
	private TimerHandle CounterTimer;

	// Token: 0x040055B8 RID: 21944
	private int HasRunTime;

	// Token: 0x02007EB8 RID: 32440
	[NullableContext(0)]
	public enum ECommonResultView
	{
		// Token: 0x040296D7 RID: 169687
		PanelContent,
		// Token: 0x040296D8 RID: 169688
		ResultText,
		// Token: 0x040296D9 RID: 169689
		TipsText,
		// Token: 0x040296DA RID: 169690
		ButtonTemplate,
		// Token: 0x040296DB RID: 169691
		ButtonParent,
		// Token: 0x040296DC RID: 169692
		TeamPlayerItem,
		// Token: 0x040296DD RID: 169693
		TeamPlayer1Sprite,
		// Token: 0x040296DE RID: 169694
		TeamPlayer2Sprite
	}
}
