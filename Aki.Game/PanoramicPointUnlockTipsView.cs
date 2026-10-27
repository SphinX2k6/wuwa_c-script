using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002310 RID: 8976
[NullableContext(1)]
[Nullable(0)]
public class PanoramicPointUnlockTipsView : UiTickViewBase
{
	// Token: 0x06011BBC RID: 72636 RVA: 0x0045CFE8 File Offset: 0x0045B1E8
	public PanoramicPointUnlockTipsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x06011BBD RID: 72637 RVA: 0x0045D020 File Offset: 0x0045B220
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011BBE RID: 72638 RVA: 0x0045D12C File Offset: 0x0045B32C
	protected override UniTask OnBeforeStartAsync()
	{
		PanoramicPointUnlockTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PanoramicPointUnlockTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011BBF RID: 72639 RVA: 0x0045D170 File Offset: 0x0045B370
	protected override void OnStart()
	{
		this.StartTick = false;
		this.CountDownTime = 0f;
		string stringConfig = ConfigCommonParamById.GetStringConfig("PanoramicPointTipsTitle");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), stringConfig, Array.Empty<object>());
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("PanoramicPointTipsDescription");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), stringConfig2, Array.Empty<object>());
		this.UiViewSequence.AddSequenceFinishEvent("StartTips", new Action<string>(this.OnStartSeqFinish), false);
		this.UiViewSequence.AddSequenceFinishEvent("CloseTips", new Action<string>(this.OnCloseSeqFinish), false);
	}

	// Token: 0x06011BC0 RID: 72640 RVA: 0x0045D210 File Offset: 0x0045B410
	protected override void OnAfterShow()
	{
		this.UiViewSequence.PlaySequence("StartTips", false, null);
	}

	// Token: 0x06011BC1 RID: 72641 RVA: 0x0045D238 File Offset: 0x0045B438
	protected override void OnTick(float delta)
	{
		if (!this.StartTick)
		{
			return;
		}
		if (this.CountDownTime >= this.Duration)
		{
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
			this.StartTick = false;
			return;
		}
		UUISprite sprite = base.GetSprite(3);
		this.CountDownTime += delta;
		float num = Math.Max(this.Duration - this.CountDownTime, 0f);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(num / this.Duration);
	}

	// Token: 0x06011BC2 RID: 72642 RVA: 0x0045D2C0 File Offset: 0x0045B4C0
	private void OnClick()
	{
		PanoramicPointUnlockTipsParam panoramicPointUnlockTipsParam = this.OpenParam as PanoramicPointUnlockTipsParam;
		if (panoramicPointUnlockTipsParam == null)
		{
			return;
		}
		GeographyHandBookViewParam param = new GeographyHandBookViewParam
		{
			SelectedId = panoramicPointUnlockTipsParam.ConfigId
		};
		HandBookEntranceViewParam param2 = new HandBookEntranceViewParam
		{
			SelectedTabType = EHandBookTabType.Geography
		};
		UiManager.Instance.OpenView(EUiViewName.HandBookEntranceView, param2, delegate(bool _, int _)
		{
			UiManager.Instance.OpenView(EUiViewName.GeographyHandBookView, param, null);
		});
		this.UiViewSequence.PlaySequence("CloseTips", true, null);
	}

	// Token: 0x06011BC3 RID: 72643 RVA: 0x0045D340 File Offset: 0x0045B540
	private void OnStartSeqFinish(string _)
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		this.StartTick = true;
	}

	// Token: 0x06011BC4 RID: 72644 RVA: 0x0045D36E File Offset: 0x0045B56E
	private void OnCloseSeqFinish(string _)
	{
		this.StartTick = false;
		base.CloseMe(null);
	}

	// Token: 0x0400868C RID: 34444
	private float CountDownTime;

	// Token: 0x0400868D RID: 34445
	private bool StartTick;

	// Token: 0x0400868E RID: 34446
	private readonly float Duration = ConfigCommonParamById.GetFloatConfig("PanoramicPointTipsDuration").GetValueOrDefault() * (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x0200888C RID: 34956
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402C628 RID: 181800
		public const int TextName = 0;

		// Token: 0x0402C629 RID: 181801
		public const int SpriteIcon = 1;

		// Token: 0x0402C62A RID: 181802
		public const int ButtonTips = 2;

		// Token: 0x0402C62B RID: 181803
		public const int SpriteTimeBar = 3;

		// Token: 0x0402C62C RID: 181804
		public const int TextTitle = 4;
	}
}
