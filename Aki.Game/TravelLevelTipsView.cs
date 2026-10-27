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

// Token: 0x020012E5 RID: 4837
[NullableContext(1)]
[Nullable(0)]
public class TravelLevelTipsView : UiViewBase
{
	// Token: 0x06008579 RID: 34169 RVA: 0x001C6D50 File Offset: 0x001C4F50
	public TravelLevelTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600857A RID: 34170 RVA: 0x001C6D88 File Offset: 0x001C4F88
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

	// Token: 0x0600857B RID: 34171 RVA: 0x001C6E14 File Offset: 0x001C5014
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

	// Token: 0x0600857C RID: 34172 RVA: 0x001C6EE3 File Offset: 0x001C50E3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600857D RID: 34173 RVA: 0x001C6F01 File Offset: 0x001C5101
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600857E RID: 34174 RVA: 0x001C6F1F File Offset: 0x001C511F
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "TipsChange")
		{
			this.SetExpMaxText();
		}
	}

	// Token: 0x0600857F RID: 34175 RVA: 0x001C6F34 File Offset: 0x001C5134
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

	// Token: 0x06008580 RID: 34176 RVA: 0x001C701C File Offset: 0x001C521C
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

	// Token: 0x06008581 RID: 34177 RVA: 0x001C705A File Offset: 0x001C525A
	protected override void OnBeforeDestroy()
	{
		this.RemoveTick();
	}

	// Token: 0x06008582 RID: 34178 RVA: 0x001C7064 File Offset: 0x001C5264
	private UniTask RunExpAdd()
	{
		TravelLevelTipsView.<RunExpAdd>d__20 <RunExpAdd>d__;
		<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunExpAdd>d__.<>4__this = this;
		<RunExpAdd>d__.<>1__state = -1;
		<RunExpAdd>d__.<>t__builder.Start<TravelLevelTipsView.<RunExpAdd>d__20>(ref <RunExpAdd>d__);
		return <RunExpAdd>d__.<>t__builder.Task;
	}

	// Token: 0x06008583 RID: 34179 RVA: 0x001C70A8 File Offset: 0x001C52A8
	private UniTask RunLevelUp()
	{
		TravelLevelTipsView.<RunLevelUp>d__21 <RunLevelUp>d__;
		<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunLevelUp>d__.<>4__this = this;
		<RunLevelUp>d__.<>1__state = -1;
		<RunLevelUp>d__.<>t__builder.Start<TravelLevelTipsView.<RunLevelUp>d__21>(ref <RunLevelUp>d__);
		return <RunLevelUp>d__.<>t__builder.Task;
	}

	// Token: 0x06008584 RID: 34180 RVA: 0x001C70EC File Offset: 0x001C52EC
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

	// Token: 0x06008585 RID: 34181 RVA: 0x001C7158 File Offset: 0x001C5358
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

	// Token: 0x06008586 RID: 34182 RVA: 0x001C71B3 File Offset: 0x001C53B3
	private void EndBarAnim()
	{
		this.RunBarAnim = false;
		this.BarAnimPromise.SetResult();
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x001C71C7 File Offset: 0x001C53C7
	private void RemoveTick()
	{
		if (this.TickHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
			this.TickHandle = null;
		}
	}

	// Token: 0x06008588 RID: 34184 RVA: 0x001C71EC File Offset: 0x001C53EC
	private void RefreshBar(float current, float target)
	{
		float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
		base.GetSprite(2).SetFillAmount(fillAmount);
	}

	// Token: 0x06008589 RID: 34185 RVA: 0x001C721E File Offset: 0x001C541E
	private void SetExpTextVisible(bool bVisible)
	{
		base.GetText(1).SetUIActive(bVisible);
	}

	// Token: 0x0600858A RID: 34186 RVA: 0x001C722D File Offset: 0x001C542D
	private void SetExpText(int expCount)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MapTravelLevelUp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
	}

	// Token: 0x0600858B RID: 34187 RVA: 0x001C7250 File Offset: 0x001C5450
	private void SetExpMaxText()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MapTravelLevelCanUp_Text", Array.Empty<object>());
		this.SetExpTextVisible(true);
	}

	// Token: 0x0600858C RID: 34188 RVA: 0x001C7274 File Offset: 0x001C5474
	private void SetLevelText(int level)
	{
		base.GetText(0).SetText(level.ToString(), true);
	}

	// Token: 0x04003BE3 RID: 15331
	private TravelLevelTipsView.ETipsType TipsType;

	// Token: 0x04003BE4 RID: 15332
	private int PreLevel;

	// Token: 0x04003BE5 RID: 15333
	private int CurLevel;

	// Token: 0x04003BE6 RID: 15334
	private int PreExpTotalCount;

	// Token: 0x04003BE7 RID: 15335
	private int CurExpTotalCount;

	// Token: 0x04003BE8 RID: 15336
	private int PreLevelTargetExp;

	// Token: 0x04003BE9 RID: 15337
	private int PreCurExpCount;

	// Token: 0x04003BEA RID: 15338
	private int CurExpCount;

	// Token: 0x04003BEB RID: 15339
	private int CurTargetExp;

	// Token: 0x04003BEC RID: 15340
	protected TimerHandle TickHandle;

	// Token: 0x04003BED RID: 15341
	protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

	// Token: 0x04003BEE RID: 15342
	protected bool RunBarAnim;

	// Token: 0x04003BEF RID: 15343
	protected float RunBarAnimTime;

	// Token: 0x04003BF0 RID: 15344
	protected float StartValue;

	// Token: 0x04003BF1 RID: 15345
	protected float TargetValue;

	// Token: 0x04003BF2 RID: 15346
	protected float EndValue;

	// Token: 0x04003BF3 RID: 15347
	protected CustomPromise BarAnimPromise = new CustomPromise();

	// Token: 0x02007903 RID: 30979
	[NullableContext(0)]
	private enum ETipsType
	{
		// Token: 0x04027DE7 RID: 163303
		ExpAdd,
		// Token: 0x04027DE8 RID: 163304
		LevelUp,
		// Token: 0x04027DE9 RID: 163305
		LevelUpAndExpAdd
	}

	// Token: 0x02007904 RID: 30980
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027DEA RID: 163306
		public const int TxtLv = 0;

		// Token: 0x04027DEB RID: 163307
		public const int TxtExp = 1;

		// Token: 0x04027DEC RID: 163308
		public const int BarExp = 2;
	}
}
