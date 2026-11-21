using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019D8 RID: 6616
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FetterItemContent : GridProxyAbstract<FetterGroupContentData>
{
	// Token: 0x0601050F RID: 66831 RVA: 0x004C37C4 File Offset: 0x004C19C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickButton))
		};
	}

	// Token: 0x06010510 RID: 66832 RVA: 0x004C3858 File Offset: 0x004C1A58
	protected override UniTask OnBeforeStartAsync()
	{
		FetterItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FetterItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010511 RID: 66833 RVA: 0x004C389C File Offset: 0x004C1A9C
	public override void Refresh(FetterGroupContentData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshVisionElement(data);
		this.RefreshName(data);
		this.RefreshNum(data);
		bool flag = data.Index == data.CurrentSelectIndex;
		base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010512 RID: 66834 RVA: 0x004C38EC File Offset: 0x004C1AEC
	private void RefreshVisionElement(FetterGroupContentData data)
	{
		if (data.VisionFetterRecommendInfo == null)
		{
			return;
		}
		int recommendFetterGroupId = data.VisionFetterRecommendInfo.GetRecommendFetterGroupId();
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(recommendFetterGroupId);
		VisionFetterSuitItem visionElementItem = this.VisionElementItem;
		if (visionElementItem != null)
		{
			visionElementItem.Update(new PhantomFetterGroup?(fetterGroupById));
		}
		VisionFetterSuitItem visionElementItem2 = this.VisionElementItem;
		if (visionElementItem2 == null)
		{
			return;
		}
		visionElementItem2.SetUiActive(true);
	}

	// Token: 0x06010513 RID: 66835 RVA: 0x004C3944 File Offset: 0x004C1B44
	private void RefreshName(FetterGroupContentData data)
	{
		if (data.VisionFetterRecommendInfo == null)
		{
			return;
		}
		int recommendFetterGroupId = data.VisionFetterRecommendInfo.GetRecommendFetterGroupId();
		string fetterGroupName = PhantomBattleConfig.Instance.GetFetterGroupById(recommendFetterGroupId).FetterGroupName;
		base.GetText(2).ShowTextNew(fetterGroupName);
	}

	// Token: 0x06010514 RID: 66836 RVA: 0x004C3988 File Offset: 0x004C1B88
	private void RefreshNum(FetterGroupContentData data)
	{
		if (data.VisionFetterRecommendInfo == null)
		{
			return;
		}
		string usageText = data.VisionFetterRecommendInfo.GetUsageText();
		base.GetText(3).SetText(usageText, true);
	}

	// Token: 0x06010515 RID: 66837 RVA: 0x004C39B8 File Offset: 0x004C1BB8
	private void OnClickButton(EToggleState toggleState)
	{
		FetterGroupContentData currentData = this.CurrentData;
		if (currentData == null)
		{
			return;
		}
		Action<FetterGroupContentData> clickCallBack = currentData.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.CurrentData);
	}

	// Token: 0x04009071 RID: 36977
	[Nullable(2)]
	private FetterGroupContentData CurrentData;

	// Token: 0x04009072 RID: 36978
	[Nullable(2)]
	private VisionFetterSuitItem VisionElementItem;
}
