using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000825 RID: 2085
public class ActivityMotorGiftSubView : ActivitySubViewBase
{
	// Token: 0x06005E7A RID: 24186 RVA: 0x001E35D4 File Offset: 0x001E17D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnPreviewButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06005E7B RID: 24187 RVA: 0x001E3740 File Offset: 0x001E1940
	protected override void OnSetData()
	{
		this.MotorGiftData = (this.ActivityBaseData as ActivityMotorGiftData);
	}

	// Token: 0x06005E7C RID: 24188 RVA: 0x001E3754 File Offset: 0x001E1954
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityMotorGiftSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorGiftSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005E7D RID: 24189 RVA: 0x001E3797 File Offset: 0x001E1997
	protected override void OnStart()
	{
		this.OnRefreshView();
	}

	// Token: 0x06005E7E RID: 24190 RVA: 0x001E379F File Offset: 0x001E199F
	protected override void OnRefreshView()
	{
		this.RefreshMotorInfo();
		this.RefreshFinishState();
	}

	// Token: 0x06005E7F RID: 24191 RVA: 0x001E37B0 File Offset: 0x001E19B0
	private void RefreshMotorInfo()
	{
		ActivityMotorGiftData motorGiftData = this.MotorGiftData;
		MotorGeneralPreview? motorGeneralPreview = (motorGiftData != null) ? motorGiftData.GetMotorPreviewConfig() : null;
		if (motorGeneralPreview == null)
		{
			return;
		}
		MotorGeneralPreview value = motorGeneralPreview.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.SubTitle, Array.Empty<object>());
	}

	// Token: 0x06005E80 RID: 24192 RVA: 0x001E3824 File Offset: 0x001E1A24
	private void RefreshFinishState()
	{
		ActivityMotorGiftData motorGiftData = this.MotorGiftData;
		bool flag = motorGiftData != null && motorGiftData.IsRewardObtained();
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (flag)
		{
			this.RefreshFinishText();
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "MotorGiftHintDes", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MotorGiftHintName", Array.Empty<object>());
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(true);
	}

	// Token: 0x06005E81 RID: 24193 RVA: 0x001E38C0 File Offset: 0x001E1AC0
	private void RefreshFinishText()
	{
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		UUIText uiText = ULGUIBPLibrary.GetComponentInChildren(item.GetOwner(), UUIText.StaticClass(), false) as UUIText;
		LguiUtil.Instance.SetLocalTextNew(uiText, "MotorGiftFinishDes", Array.Empty<object>());
	}

	// Token: 0x06005E82 RID: 24194 RVA: 0x001E390A File Offset: 0x001E1B0A
	private void OnPreviewButtonClick()
	{
		ActivityMotorGiftData motorGiftData = this.MotorGiftData;
		if (motorGiftData == null)
		{
			return;
		}
		motorGiftData.OpenMotorPreviewView();
	}

	// Token: 0x04003E5E RID: 15966
	[Nullable(2)]
	private ActivityMotorGiftData MotorGiftData;

	// Token: 0x04003E5F RID: 15967
	[Nullable(2)]
	private ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02006B70 RID: 27504
	[NullableContext(1)]
	[Nullable(0)]
	private static class EMotorGiftTextKey
	{
		// Token: 0x04023522 RID: 144674
		public const string MotorGiftHintDes = "MotorGiftHintDes";

		// Token: 0x04023523 RID: 144675
		public const string MotorGiftHintName = "MotorGiftHintName";

		// Token: 0x04023524 RID: 144676
		public const string MotorGiftFinishDes = "MotorGiftFinishDes";
	}

	// Token: 0x02006B71 RID: 27505
	private class EComponents
	{
		// Token: 0x04023525 RID: 144677
		public const int BtnLookA = 0;

		// Token: 0x04023526 RID: 144678
		public const int ComActivityInfo = 1;

		// Token: 0x04023527 RID: 144679
		public const int TxtSkinMainTitle = 2;

		// Token: 0x04023528 RID: 144680
		public const int TxtSubTitle = 3;

		// Token: 0x04023529 RID: 144681
		public const int PnlLayout = 4;

		// Token: 0x0402352A RID: 144682
		public const int TxtTip2 = 5;

		// Token: 0x0402352B RID: 144683
		public const int TxtTip1 = 6;

		// Token: 0x0402352C RID: 144684
		public const int PnlFinish = 7;
	}
}
