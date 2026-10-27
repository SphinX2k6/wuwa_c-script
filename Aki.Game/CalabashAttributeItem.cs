using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200174D RID: 5965
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class CalabashAttributeItem : GridProxyAbstract<CalabashAttributeData>
{
	// Token: 0x0600AC7A RID: 44154 RVA: 0x0026AF08 File Offset: 0x00269108
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600AC7B RID: 44155 RVA: 0x0026B009 File Offset: 0x00269209
	private void OnClickToggle(EToggleState toggleState)
	{
		CalabashAttributeData data = this.Data;
		if (data == null)
		{
			return;
		}
		Action<CalabashAttributeData> clickCallBack = data.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.Data);
	}

	// Token: 0x0600AC7C RID: 44156 RVA: 0x0026B02C File Offset: 0x0026922C
	protected override void OnStart()
	{
		base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.TargetLayout = new GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData>(base.GetVerticalLayout(7), new Func<CalabashAttributeContentItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600AC7D RID: 44157 RVA: 0x0026B085 File Offset: 0x00269285
	private CalabashAttributeContentItem InitItem()
	{
		return new CalabashAttributeContentItem();
	}

	// Token: 0x0600AC7E RID: 44158 RVA: 0x0026B08C File Offset: 0x0026928C
	private void ShowBasicAbsorptionInfo(CalabashAttributeData data)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(text, data.Value.TextKey, data.Value.Params);
		UUIItem item2 = base.GetItem(6);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600AC7F RID: 44159 RVA: 0x0026B0F4 File Offset: 0x002692F4
	private void ShowUpAbsorptionInfo(CalabashAttributeData data)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		if (data.Value != null)
		{
			LguiUtil.Instance.TrySetLocalTextNew(text, data.Value.TextKey, data.Value.Params);
		}
		List<CalabashAttributeContentData> list = new List<CalabashAttributeContentData>();
		list.Add(new CalabashAttributeContentData
		{
			Type = ECalabashLevelSubShowType.UpgradeTarget,
			StringKey = "UpAbsorptionTarget",
			StringValue = new TableTextArgNew("UpAbsorptionTargetName", Array.Empty<object>())
		});
		CalabashAttributeContentData calabashAttributeContentData = new CalabashAttributeContentData();
		calabashAttributeContentData.Type = ECalabashLevelSubShowType.UpgradeTarget;
		calabashAttributeContentData.StringKey = "UpAbsorptionTimeText";
		int currentSelectLevel = data.CurrentSelectLevel;
		CalabashModel instance = CalabashModel.Instance;
		int num = (instance != null) ? instance.GetLeftIntensifyCaptureGuarantee() : 0;
		CalabashConfig instance2 = CalabashConfig.Instance;
		CalabashLevel? calabashLevel = (instance2 != null) ? instance2.GetCalabashConfigByLevel(currentSelectLevel) : null;
		int num2 = (calabashLevel != null) ? calabashLevel.GetValueOrDefault().IntensifyCaptureGuarantee : 0;
		calabashAttributeContentData.StringValue = new TableTextArgNew("UpAbsorptionTimeDescText", new <>z__ReadOnlyArray<object>(new object[]
		{
			num.ToString(),
			num2.ToString()
		}));
		list.Add(calabashAttributeContentData);
		GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData> targetLayout = this.TargetLayout;
		if (targetLayout == null)
		{
			return;
		}
		targetLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600AC80 RID: 44160 RVA: 0x0026B240 File Offset: 0x00269440
	private void ShowLowCostUpAbsorptionInfo(CalabashAttributeData data)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		if (data.Value != null)
		{
			LguiUtil.Instance.TrySetLocalTextNew(text, data.Value.TextKey, data.Value.Params);
		}
		List<CalabashAttributeContentData> list = new List<CalabashAttributeContentData>();
		list.Add(new CalabashAttributeContentData
		{
			Type = ECalabashLevelSubShowType.UpgradeTarget,
			StringKey = "UpAbsorptionTarget",
			StringValue = new TableTextArgNew(ECalabashTxt.UpAbsorptionTargetNameJunior.ToString(), Array.Empty<object>())
		});
		CalabashAttributeContentData calabashAttributeContentData = new CalabashAttributeContentData();
		calabashAttributeContentData.Type = ECalabashLevelSubShowType.UpgradeTarget;
		calabashAttributeContentData.StringKey = "UpAbsorptionTimeText";
		int currentSelectLevel = data.CurrentSelectLevel;
		CalabashModel instance = CalabashModel.Instance;
		int num = (instance != null) ? instance.GetLeftLowCostIntensifyCaptureGuarantee() : 0;
		CalabashConfig instance2 = CalabashConfig.Instance;
		CalabashLevel? calabashLevel = (instance2 != null) ? instance2.GetCalabashConfigByLevel(currentSelectLevel) : null;
		int num2 = (calabashLevel != null) ? calabashLevel.GetValueOrDefault().LowCostIntensifyCaptureGuarantee : 0;
		calabashAttributeContentData.StringValue = new TableTextArgNew("UpAbsorptionTimeDescText", new <>z__ReadOnlyArray<object>(new object[]
		{
			num.ToString(),
			num2.ToString()
		}));
		list.Add(calabashAttributeContentData);
		GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData> targetLayout = this.TargetLayout;
		if (targetLayout == null)
		{
			return;
		}
		targetLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600AC81 RID: 44161 RVA: 0x0026B398 File Offset: 0x00269598
	private void ShowMaxCostInfo(CalabashAttributeData data)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(data.CostCount.ToString(), true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600AC82 RID: 44162 RVA: 0x0026B3FC File Offset: 0x002695FC
	private void ShowMaxQualityInfo(CalabashAttributeData data)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(text, data.Value.TextKey, data.Value.Params);
		int currentSelectLevel = data.CurrentSelectLevel;
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(currentSelectLevel);
		Dictionary<int, int> dictionary = (calabashConfigByLevel != null) ? calabashConfigByLevel.GetValueOrDefault().QualityDropWeight() : null;
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		List<CalabashAttributeContentData> list = new List<CalabashAttributeContentData>();
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int value = keyValuePair.Value;
				if (value > 0)
				{
					list.Add(new CalabashAttributeContentData
					{
						Type = ECalabashLevelSubShowType.UpgradeQuality,
						Key = keyValuePair.Key,
						Value = value
					});
				}
			}
		}
		GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData> targetLayout = this.TargetLayout;
		if (targetLayout == null)
		{
			return;
		}
		targetLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600AC83 RID: 44163 RVA: 0x0026B52C File Offset: 0x0026972C
	private void RefreshLayoutItemShowState()
	{
		CalabashAttributeData data = this.Data;
		if (data != null && data.CurrentSelect)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		else
		{
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
	}

	// Token: 0x0600AC84 RID: 44164 RVA: 0x0026B57C File Offset: 0x0026977C
	public override void Refresh(CalabashAttributeData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(data.Type == ECalabashAttributeDataType.MaxQuality && data.IsUp);
		}
		this.RefreshLayoutItemShowState();
		this.RefreshToggleRaycastActive(data.IsToggleRaycast);
		switch (data.Type)
		{
		case ECalabashAttributeDataType.BasicAbsorption:
			this.ShowBasicAbsorptionInfo(data);
			break;
		case ECalabashAttributeDataType.UpAbsorption:
			this.ShowUpAbsorptionInfo(data);
			break;
		case ECalabashAttributeDataType.LowCostUpAbsorption:
			this.ShowLowCostUpAbsorptionInfo(data);
			break;
		case ECalabashAttributeDataType.MaxQuality:
			this.ShowMaxQualityInfo(data);
			break;
		case ECalabashAttributeDataType.MaxCost:
			this.ShowMaxCostInfo(data);
			break;
		}
		if (this.CurrentSelectState != data.CurrentSelect)
		{
			this.CurrentSelectState = data.CurrentSelect;
			this.PlaySequenceBySelectState(this.CurrentSelectState);
		}
	}

	// Token: 0x0600AC85 RID: 44165 RVA: 0x0026B658 File Offset: 0x00269858
	private void RefreshToggleRaycastActive(bool boolValue)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetRaycastTarget(boolValue);
	}

	// Token: 0x0600AC86 RID: 44166 RVA: 0x0026B684 File Offset: 0x00269884
	private void PlaySequenceBySelectState(bool state)
	{
		string sequenceName = state ? "Show" : "Hide";
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
	}

	// Token: 0x04004E6E RID: 20078
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData> TargetLayout;

	// Token: 0x04004E6F RID: 20079
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04004E70 RID: 20080
	[Nullable(2)]
	private CalabashAttributeData Data;

	// Token: 0x04004E71 RID: 20081
	private bool CurrentSelectState;
}
