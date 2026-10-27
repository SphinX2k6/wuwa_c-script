using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024F1 RID: 9457
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FetterItemContent : GridProxyAbstract<FetterGroupContentData>
{
	// Token: 0x06013050 RID: 77904 RVA: 0x004B5B1C File Offset: 0x004B3D1C
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

	// Token: 0x06013051 RID: 77905 RVA: 0x004B5BB0 File Offset: 0x004B3DB0
	protected override UniTask OnBeforeStartAsync()
	{
		FetterItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FetterItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013052 RID: 77906 RVA: 0x004B5BF4 File Offset: 0x004B3DF4
	public override void Refresh(FetterGroupContentData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshVisionElement(data);
		this.RefreshName(data);
		this.RefreshNum(data);
		bool flag = data.Index == data.CurrentSelectIndex;
		base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013053 RID: 77907 RVA: 0x004B5C44 File Offset: 0x004B3E44
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

	// Token: 0x06013054 RID: 77908 RVA: 0x004B5C9C File Offset: 0x004B3E9C
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

	// Token: 0x06013055 RID: 77909 RVA: 0x004B5CE0 File Offset: 0x004B3EE0
	private void RefreshNum(FetterGroupContentData data)
	{
		if (data.VisionFetterRecommendInfo == null)
		{
			return;
		}
		string usageText = data.VisionFetterRecommendInfo.GetUsageText();
		base.GetText(3).SetText(usageText, true);
	}

	// Token: 0x06013056 RID: 77910 RVA: 0x004B5D10 File Offset: 0x004B3F10
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

	// Token: 0x04008F27 RID: 36647
	[Nullable(2)]
	private FetterGroupContentData CurrentData;

	// Token: 0x04008F28 RID: 36648
	[Nullable(2)]
	private VisionFetterSuitItem VisionElementItem;
}
