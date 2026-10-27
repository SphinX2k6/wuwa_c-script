using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001371 RID: 4977
public class ActivityMotorGiftSubView : ActivitySubViewBase
{
	// Token: 0x06008ADF RID: 35551 RVA: 0x001DA778 File Offset: 0x001D8978
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

	// Token: 0x06008AE0 RID: 35552 RVA: 0x001DA8E4 File Offset: 0x001D8AE4
	protected override void OnSetData()
	{
		this.MotorGiftData = (this.ActivityBaseData as ActivityMotorGiftData);
	}

	// Token: 0x06008AE1 RID: 35553 RVA: 0x001DA8F8 File Offset: 0x001D8AF8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityMotorGiftSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorGiftSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008AE2 RID: 35554 RVA: 0x001DA93B File Offset: 0x001D8B3B
	protected override void OnStart()
	{
		this.OnRefreshView();
	}

	// Token: 0x06008AE3 RID: 35555 RVA: 0x001DA943 File Offset: 0x001D8B43
	protected override void OnRefreshView()
	{
		this.RefreshMotorInfo();
		this.RefreshFinishState();
	}

	// Token: 0x06008AE4 RID: 35556 RVA: 0x001DA954 File Offset: 0x001D8B54
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

	// Token: 0x06008AE5 RID: 35557 RVA: 0x001DA9C8 File Offset: 0x001D8BC8
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

	// Token: 0x06008AE6 RID: 35558 RVA: 0x001DAA64 File Offset: 0x001D8C64
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

	// Token: 0x06008AE7 RID: 35559 RVA: 0x001DAAAE File Offset: 0x001D8CAE
	private void OnPreviewButtonClick()
	{
		ActivityMotorGiftData motorGiftData = this.MotorGiftData;
		if (motorGiftData == null)
		{
			return;
		}
		motorGiftData.OpenMotorPreviewView();
	}

	// Token: 0x04003DC6 RID: 15814
	[Nullable(2)]
	private ActivityMotorGiftData MotorGiftData;

	// Token: 0x04003DC7 RID: 15815
	[Nullable(2)]
	private ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x020079E6 RID: 31206
	[NullableContext(1)]
	[Nullable(0)]
	private static class EMotorGiftTextKey
	{
		// Token: 0x040281F5 RID: 164341
		public const string MotorGiftHintDes = "MotorGiftHintDes";

		// Token: 0x040281F6 RID: 164342
		public const string MotorGiftHintName = "MotorGiftHintName";

		// Token: 0x040281F7 RID: 164343
		public const string MotorGiftFinishDes = "MotorGiftFinishDes";
	}

	// Token: 0x020079E7 RID: 31207
	private class EComponents
	{
		// Token: 0x040281F8 RID: 164344
		public const int BtnLookA = 0;

		// Token: 0x040281F9 RID: 164345
		public const int ComActivityInfo = 1;

		// Token: 0x040281FA RID: 164346
		public const int TxtSkinMainTitle = 2;

		// Token: 0x040281FB RID: 164347
		public const int TxtSubTitle = 3;

		// Token: 0x040281FC RID: 164348
		public const int PnlLayout = 4;

		// Token: 0x040281FD RID: 164349
		public const int TxtTip2 = 5;

		// Token: 0x040281FE RID: 164350
		public const int TxtTip1 = 6;

		// Token: 0x040281FF RID: 164351
		public const int PnlFinish = 7;
	}
}
