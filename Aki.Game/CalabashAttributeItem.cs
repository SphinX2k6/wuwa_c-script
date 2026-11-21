using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C06 RID: 3078
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class CalabashAttributeItem : GridProxyAbstract<CalabashAttributeData>
{
	// Token: 0x06008061 RID: 32865 RVA: 0x00275350 File Offset: 0x00273550
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

	// Token: 0x06008062 RID: 32866 RVA: 0x00275451 File Offset: 0x00273651
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

	// Token: 0x06008063 RID: 32867 RVA: 0x00275474 File Offset: 0x00273674
	protected override void OnStart()
	{
		base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.TargetLayout = new GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData>(base.GetVerticalLayout(7), new Func<CalabashAttributeContentItem>(this.InitItem), null, false, true);
	}

	// Token: 0x06008064 RID: 32868 RVA: 0x002754CD File Offset: 0x002736CD
	private CalabashAttributeContentItem InitItem()
	{
		return new CalabashAttributeContentItem();
	}

	// Token: 0x06008065 RID: 32869 RVA: 0x002754D4 File Offset: 0x002736D4
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

	// Token: 0x06008066 RID: 32870 RVA: 0x0027553C File Offset: 0x0027373C
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

	// Token: 0x06008067 RID: 32871 RVA: 0x00275688 File Offset: 0x00273888
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

	// Token: 0x06008068 RID: 32872 RVA: 0x002757E0 File Offset: 0x002739E0
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

	// Token: 0x06008069 RID: 32873 RVA: 0x00275844 File Offset: 0x00273A44
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

	// Token: 0x0600806A RID: 32874 RVA: 0x00275974 File Offset: 0x00273B74
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

	// Token: 0x0600806B RID: 32875 RVA: 0x002759C4 File Offset: 0x00273BC4
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

	// Token: 0x0600806C RID: 32876 RVA: 0x00275AA0 File Offset: 0x00273CA0
	private void RefreshToggleRaycastActive(bool boolValue)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetRaycastTarget(boolValue);
	}

	// Token: 0x0600806D RID: 32877 RVA: 0x00275ACC File Offset: 0x00273CCC
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

	// Token: 0x04004F17 RID: 20247
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashAttributeContentItem, CalabashAttributeContentData> TargetLayout;

	// Token: 0x04004F18 RID: 20248
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04004F19 RID: 20249
	[Nullable(2)]
	private CalabashAttributeData Data;

	// Token: 0x04004F1A RID: 20250
	private bool CurrentSelectState;
}
