using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000799 RID: 1945
[NullableContext(1)]
[Nullable(0)]
public class TravelLevelTipsView : UiViewBase
{
	// Token: 0x06005914 RID: 22804 RVA: 0x001CFBBC File Offset: 0x001CDDBC
	public TravelLevelTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x001CFBF4 File Offset: 0x001CDDF4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x001CFC80 File Offset: 0x001CDE80
	protected override void OnStart()
	{
		ActivityMapTravelData activityMapTravelData = this.OpenParam as ActivityMapTravelData;
		this.PreLevel = activityMapTravelData.LastTravelLevel;
		this.CurLevel = activityMapTravelData.TravelLevel;
		this.PreExpTotalCount = activityMapTravelData.LastExpCount;
		this.CurExpTotalCount = activityMapTravelData.GetExpItemCount();
		this.PreCurExpCount = activityMapTravelData.LastCurrentExpCount;
		IMapTravelLevelData mapTravelLevelData = activityMapTravelData.TravelLevelData[this.PreLevel];
		this.PreLevelTargetExp = mapTravelLevelData.TargetExp;
		this.CurExpCount = activityMapTravelData.GetCurrentExp();
		this.CurTargetExp = activityMapTravelData.GetCurrentTargetExp();
		bool flag = this.CurLevel > this.PreLevel;
		bool flag2 = this.CurExpTotalCount > this.PreExpTotalCount;
		if (flag)
		{
			if (flag2)
			{
				this.TipsType = TravelLevelTipsView.ETipsType.LevelUpAndExpAdd;
				return;
			}
			this.TipsType = TravelLevelTipsView.ETipsType.LevelUp;
			return;
		}
		else
		{
			if (flag2)
			{
				this.TipsType = TravelLevelTipsView.ETipsType.ExpAdd;
				return;
			}
			base.CloseMe(null);
			return;
		}
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x001CFD4F File Offset: 0x001CDF4F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x001CFD6D File Offset: 0x001CDF6D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x001CFD8B File Offset: 0x001CDF8B
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "TipsChange")
		{
			this.SetExpMaxText();
		}
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x001CFDA0 File Offset: 0x001CDFA0
	protected override void OnBeforeShow()
	{
		this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Refresh), 20f, 1f, null, null, true);
		this.RefreshBar(0f, 1f);
		this.SetLevelText(this.PreLevel);
		switch (this.TipsType)
		{
		case TravelLevelTipsView.ETipsType.ExpAdd:
			this.SetExpText(this.CurExpCount - this.PreCurExpCount);
			this.SetExpTextVisible(true);
			this.RefreshBar((float)this.PreCurExpCount, (float)this.CurTargetExp);
			return;
		case TravelLevelTipsView.ETipsType.LevelUp:
			this.SetExpTextVisible(false);
			this.RefreshBar((float)this.PreCurExpCount, (float)this.PreLevelTargetExp);
			return;
		case TravelLevelTipsView.ETipsType.LevelUpAndExpAdd:
			this.SetExpText(this.CurExpTotalCount - this.PreExpTotalCount);
			this.SetExpTextVisible(true);
			this.RefreshBar((float)this.PreCurExpCount, (float)this.PreLevelTargetExp);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600591B RID: 22811 RVA: 0x001CFE88 File Offset: 0x001CE088
	protected override void OnAfterShow()
	{
		switch (this.TipsType)
		{
		case TravelLevelTipsView.ETipsType.ExpAdd:
			this.RunExpAdd();
			return;
		case TravelLevelTipsView.ETipsType.LevelUp:
			this.RunLevelUp();
			return;
		case TravelLevelTipsView.ETipsType.LevelUpAndExpAdd:
			this.RunLevelUp();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x001CFEC6 File Offset: 0x001CE0C6
	protected override void OnBeforeDestroy()
	{
		this.RemoveTick();
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x001CFED0 File Offset: 0x001CE0D0
	private UniTask RunExpAdd()
	{
		TravelLevelTipsView.<RunExpAdd>d__20 <RunExpAdd>d__;
		<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunExpAdd>d__.<>4__this = this;
		<RunExpAdd>d__.<>1__state = -1;
		<RunExpAdd>d__.<>t__builder.Start<TravelLevelTipsView.<RunExpAdd>d__20>(ref <RunExpAdd>d__);
		return <RunExpAdd>d__.<>t__builder.Task;
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x001CFF14 File Offset: 0x001CE114
	private UniTask RunLevelUp()
	{
		TravelLevelTipsView.<RunLevelUp>d__21 <RunLevelUp>d__;
		<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunLevelUp>d__.<>4__this = this;
		<RunLevelUp>d__.<>1__state = -1;
		<RunLevelUp>d__.<>t__builder.Start<TravelLevelTipsView.<RunLevelUp>d__21>(ref <RunLevelUp>d__);
		return <RunLevelUp>d__.<>t__builder.Task;
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x001CFF58 File Offset: 0x001CE158
	protected void Refresh(float delta)
	{
		if (!this.RunBarAnim)
		{
			return;
		}
		this.RunBarAnimTime += delta;
		float current = MathUtils.Instance.Lerp(this.StartValue, this.TargetValue, this.RunBarAnimTime / (float)this.BarAnimTime);
		this.RefreshBar(current, this.EndValue);
		if (this.RunBarAnimTime >= (float)this.BarAnimTime)
		{
			this.EndBarAnim();
		}
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x001CFFC4 File Offset: 0x001CE1C4
	private UniTask StartBarAnim(float current, float target, float end)
	{
		TravelLevelTipsView.<StartBarAnim>d__31 <StartBarAnim>d__;
		<StartBarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartBarAnim>d__.<>4__this = this;
		<StartBarAnim>d__.current = current;
		<StartBarAnim>d__.target = target;
		<StartBarAnim>d__.end = end;
		<StartBarAnim>d__.<>1__state = -1;
		<StartBarAnim>d__.<>t__builder.Start<TravelLevelTipsView.<StartBarAnim>d__31>(ref <StartBarAnim>d__);
		return <StartBarAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x001D001F File Offset: 0x001CE21F
	private void EndBarAnim()
	{
		this.RunBarAnim = false;
		this.BarAnimPromise.SetResult();
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x001D0033 File Offset: 0x001CE233
	private void RemoveTick()
	{
		if (this.TickHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
			this.TickHandle = null;
		}
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x001D0058 File Offset: 0x001CE258
	private void RefreshBar(float current, float target)
	{
		float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
		base.GetSprite(2).SetFillAmount(fillAmount);
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x001D008A File Offset: 0x001CE28A
	private void SetExpTextVisible(bool bVisible)
	{
		base.GetText(1).SetUIActive(bVisible);
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x001D0099 File Offset: 0x001CE299
	private void SetExpText(int expCount)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MapTravelLevelUp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x001D00BC File Offset: 0x001CE2BC
	private void SetExpMaxText()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MapTravelLevelCanUp_Text", Array.Empty<object>());
		this.SetExpTextVisible(true);
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x001D00E0 File Offset: 0x001CE2E0
	private void SetLevelText(int level)
	{
		base.GetText(0).SetText(level.ToString(), true);
	}

	// Token: 0x04003C7B RID: 15483
	private TravelLevelTipsView.ETipsType TipsType;

	// Token: 0x04003C7C RID: 15484
	private int PreLevel;

	// Token: 0x04003C7D RID: 15485
	private int CurLevel;

	// Token: 0x04003C7E RID: 15486
	private int PreExpTotalCount;

	// Token: 0x04003C7F RID: 15487
	private int CurExpTotalCount;

	// Token: 0x04003C80 RID: 15488
	private int PreLevelTargetExp;

	// Token: 0x04003C81 RID: 15489
	private int PreCurExpCount;

	// Token: 0x04003C82 RID: 15490
	private int CurExpCount;

	// Token: 0x04003C83 RID: 15491
	private int CurTargetExp;

	// Token: 0x04003C84 RID: 15492
	protected TimerHandle TickHandle;

	// Token: 0x04003C85 RID: 15493
	protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

	// Token: 0x04003C86 RID: 15494
	protected bool RunBarAnim;

	// Token: 0x04003C87 RID: 15495
	protected float RunBarAnimTime;

	// Token: 0x04003C88 RID: 15496
	protected float StartValue;

	// Token: 0x04003C89 RID: 15497
	protected float TargetValue;

	// Token: 0x04003C8A RID: 15498
	protected float EndValue;

	// Token: 0x04003C8B RID: 15499
	protected CustomPromise BarAnimPromise = new CustomPromise();

	// Token: 0x02006A8D RID: 27277
	[NullableContext(0)]
	private enum ETipsType
	{
		// Token: 0x04023114 RID: 143636
		ExpAdd,
		// Token: 0x04023115 RID: 143637
		LevelUp,
		// Token: 0x04023116 RID: 143638
		LevelUpAndExpAdd
	}

	// Token: 0x02006A8E RID: 27278
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023117 RID: 143639
		public const int TxtLv = 0;

		// Token: 0x04023118 RID: 143640
		public const int TxtExp = 1;

		// Token: 0x04023119 RID: 143641
		public const int BarExp = 2;
	}
}
