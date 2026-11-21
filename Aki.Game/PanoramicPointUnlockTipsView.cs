using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017F4 RID: 6132
[NullableContext(1)]
[Nullable(0)]
public class PanoramicPointUnlockTipsView : UiTickViewBase
{
	// Token: 0x0600F059 RID: 61529 RVA: 0x00469CC4 File Offset: 0x00467EC4
	public PanoramicPointUnlockTipsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600F05A RID: 61530 RVA: 0x00469CFC File Offset: 0x00467EFC
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

	// Token: 0x0600F05B RID: 61531 RVA: 0x00469E08 File Offset: 0x00468008
	protected override UniTask OnBeforeStartAsync()
	{
		PanoramicPointUnlockTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PanoramicPointUnlockTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F05C RID: 61532 RVA: 0x00469E4C File Offset: 0x0046804C
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

	// Token: 0x0600F05D RID: 61533 RVA: 0x00469EEC File Offset: 0x004680EC
	protected override void OnAfterShow()
	{
		this.UiViewSequence.PlaySequence("StartTips", false, null);
	}

	// Token: 0x0600F05E RID: 61534 RVA: 0x00469F14 File Offset: 0x00468114
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

	// Token: 0x0600F05F RID: 61535 RVA: 0x00469F9C File Offset: 0x0046819C
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

	// Token: 0x0600F060 RID: 61536 RVA: 0x0046A01C File Offset: 0x0046821C
	private void OnStartSeqFinish(string _)
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		this.StartTick = true;
	}

	// Token: 0x0600F061 RID: 61537 RVA: 0x0046A04A File Offset: 0x0046824A
	private void OnCloseSeqFinish(string _)
	{
		this.StartTick = false;
		base.CloseMe(null);
	}

	// Token: 0x040087CC RID: 34764
	private float CountDownTime;

	// Token: 0x040087CD RID: 34765
	private bool StartTick;

	// Token: 0x040087CE RID: 34766
	private readonly float Duration = ConfigCommonParamById.GetFloatConfig("PanoramicPointTipsDuration").GetValueOrDefault() * (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x02007A12 RID: 31250
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027936 RID: 162102
		public const int TextName = 0;

		// Token: 0x04027937 RID: 162103
		public const int SpriteIcon = 1;

		// Token: 0x04027938 RID: 162104
		public const int ButtonTips = 2;

		// Token: 0x04027939 RID: 162105
		public const int SpriteTimeBar = 3;

		// Token: 0x0402793A RID: 162106
		public const int TextTitle = 4;
	}
}
