using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061D1 RID: 25041
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookLevelTipsView : UiViewBase
	{
		// Token: 0x0603F3C3 RID: 259011 RVA: 0x00F47474 File Offset: 0x00F45674
		public RoadBookLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F3C4 RID: 259012 RVA: 0x00F474AC File Offset: 0x00F456AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite))
			};
		}

		// Token: 0x0603F3C5 RID: 259013 RVA: 0x00F47548 File Offset: 0x00F45748
		protected override void OnStart()
		{
			this.OffsetTweenX = new LguiFloatTween();
			this.OffsetTweenX.BindUpdateTween(new Action<float>(this.UpdateOffsetX));
			this.OffsetTweenX.BindCompleteTween(new Action(this.OnCompleteOffsetX));
			ActivityRoadBookData activityRoadBookData = this.OpenParam as ActivityRoadBookData;
			this.PreLevel = activityRoadBookData.LastTravelLevel;
			this.CurLevel = activityRoadBookData.TravelLevel;
			this.PreExpTotalCount = activityRoadBookData.LastExpCount;
			this.CurExpTotalCount = activityRoadBookData.GetExpItemCount();
			this.PreCurExpCount = activityRoadBookData.LastCurrentExpCount;
			IRoadBookLevelData roadBookLevelData;
			activityRoadBookData.TravelLevelData.TryGetValue(this.PreLevel, out roadBookLevelData);
			this.PreLevelTargetExp = roadBookLevelData.TargetExp;
			this.CurExpCount = activityRoadBookData.GetCurrentExp();
			this.CurTargetExp = activityRoadBookData.GetCurrentTargetExp();
			bool flag = this.CurLevel > this.PreLevel;
			bool flag2 = this.CurExpTotalCount > this.PreExpTotalCount;
			if (flag)
			{
				if (flag2)
				{
					this.TipsType = ETipsType.LevelUpAndExpAdd;
				}
				else
				{
					this.TipsType = ETipsType.LevelUp;
				}
			}
			else if (flag2)
			{
				this.TipsType = ETipsType.ExpAdd;
			}
			else
			{
				base.CloseMe(null);
			}
			this.LevelLayout = new GenericLayout<LevelItemGrid, int>(base.GetHorizontalLayout(2), new Func<LevelItemGrid>(this.OnCreateItem), null, false, true);
			this.LevelItemWidth = base.GetItem(3).Width;
			this.LevelItemSpacing = base.GetHorizontalLayout(2).Spacing;
			this.RefreshLayout(activityRoadBookData.MaxTravelLevel);
		}

		// Token: 0x0603F3C6 RID: 259014 RVA: 0x00F476A6 File Offset: 0x00F458A6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603F3C7 RID: 259015 RVA: 0x00F476C4 File Offset: 0x00F458C4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603F3C8 RID: 259016 RVA: 0x00F476E2 File Offset: 0x00F458E2
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "TipsChange")
			{
				this.SetExpMaxText();
			}
		}

		// Token: 0x0603F3C9 RID: 259017 RVA: 0x00F476F8 File Offset: 0x00F458F8
		protected override void OnBeforeShow()
		{
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Refresh), 20f, 1f, null, null, true);
			this.RefreshBar(0f, 1f);
			switch (this.TipsType)
			{
			case ETipsType.ExpAdd:
				this.SetExpText(this.CurExpCount - this.PreCurExpCount);
				this.SetExpTextVisible(true);
				this.RefreshBar((float)this.PreCurExpCount, (float)this.CurTargetExp);
				return;
			case ETipsType.LevelUp:
				this.SetExpTextVisible(false);
				this.RefreshBar((float)this.PreCurExpCount, (float)this.PreLevelTargetExp);
				return;
			case ETipsType.LevelUpAndExpAdd:
				this.SetExpText(this.CurExpTotalCount - this.PreExpTotalCount);
				this.SetExpTextVisible(true);
				this.RefreshBar((float)this.PreCurExpCount, (float)this.PreLevelTargetExp);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603F3CA RID: 259018 RVA: 0x00F477D4 File Offset: 0x00F459D4
		protected override void OnAfterShow()
		{
			switch (this.TipsType)
			{
			case ETipsType.ExpAdd:
				this.RunExpAdd().Forget();
				return;
			case ETipsType.LevelUp:
				this.RunLevelUp().Forget();
				return;
			case ETipsType.LevelUpAndExpAdd:
				this.RunLevelUp().Forget();
				return;
			default:
				return;
			}
		}

		// Token: 0x0603F3CB RID: 259019 RVA: 0x00F4781E File Offset: 0x00F45A1E
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
			LguiFloatTween offsetTweenX = this.OffsetTweenX;
			if (offsetTweenX == null)
			{
				return;
			}
			offsetTweenX.Destroy();
		}

		// Token: 0x0603F3CC RID: 259020 RVA: 0x00F47836 File Offset: 0x00F45A36
		private void UpdateOffsetX(float value)
		{
			UUIItem rootUiItem = this.LevelLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetAnchorOffsetX(value);
		}

		// Token: 0x0603F3CD RID: 259021 RVA: 0x00F4784E File Offset: 0x00F45A4E
		private void OnCompleteOffsetX()
		{
			LevelItemGrid layoutItemByIndex = this.LevelLayout.GetLayoutItemByIndex(this.CurLevel);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.PlayLevelUpAnim();
		}

		// Token: 0x0603F3CE RID: 259022 RVA: 0x00F4786C File Offset: 0x00F45A6C
		private void RefreshLayout(int maxLevel)
		{
			List<int> list = new List<int>();
			for (int i = 0; i <= maxLevel; i++)
			{
				list.Add(i);
			}
			this.LevelLayout.RefreshByData(list, delegate
			{
				this.LevelLayout.SelectGridProxy(this.PreLevel, false);
			}, false);
			UUIItem rootUiItem = this.LevelLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetAnchorOffsetX(this.GetOffsetX(this.PreLevel));
		}

		// Token: 0x0603F3CF RID: 259023 RVA: 0x00F478CC File Offset: 0x00F45ACC
		private float GetOffsetX(int index)
		{
			return -((float)index * (this.LevelItemWidth + this.LevelItemSpacing) + this.LevelItemWidth * 0.5f);
		}

		// Token: 0x0603F3D0 RID: 259024 RVA: 0x00F478EC File Offset: 0x00F45AEC
		private LevelItemGrid OnCreateItem()
		{
			return new LevelItemGrid();
		}

		// Token: 0x0603F3D1 RID: 259025 RVA: 0x00F478F4 File Offset: 0x00F45AF4
		private UniTask RunExpAdd()
		{
			RoadBookLevelTipsView.<RunExpAdd>d__27 <RunExpAdd>d__;
			<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunExpAdd>d__.<>4__this = this;
			<RunExpAdd>d__.<>1__state = -1;
			<RunExpAdd>d__.<>t__builder.Start<RoadBookLevelTipsView.<RunExpAdd>d__27>(ref <RunExpAdd>d__);
			return <RunExpAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3D2 RID: 259026 RVA: 0x00F47938 File Offset: 0x00F45B38
		private UniTask RunLevelUp()
		{
			RoadBookLevelTipsView.<RunLevelUp>d__28 <RunLevelUp>d__;
			<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelUp>d__.<>4__this = this;
			<RunLevelUp>d__.<>1__state = -1;
			<RunLevelUp>d__.<>t__builder.Start<RoadBookLevelTipsView.<RunLevelUp>d__28>(ref <RunLevelUp>d__);
			return <RunLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3D3 RID: 259027 RVA: 0x00F4797C File Offset: 0x00F45B7C
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

		// Token: 0x0603F3D4 RID: 259028 RVA: 0x00F479E8 File Offset: 0x00F45BE8
		private UniTask StartBarAnim(float current, float target, float end)
		{
			RoadBookLevelTipsView.<StartBarAnim>d__38 <StartBarAnim>d__;
			<StartBarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartBarAnim>d__.<>4__this = this;
			<StartBarAnim>d__.current = current;
			<StartBarAnim>d__.target = target;
			<StartBarAnim>d__.end = end;
			<StartBarAnim>d__.<>1__state = -1;
			<StartBarAnim>d__.<>t__builder.Start<RoadBookLevelTipsView.<StartBarAnim>d__38>(ref <StartBarAnim>d__);
			return <StartBarAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3D5 RID: 259029 RVA: 0x00F47A43 File Offset: 0x00F45C43
		private void EndBarAnim()
		{
			this.RunBarAnim = false;
			this.BarAnimPromise.SetResult();
		}

		// Token: 0x0603F3D6 RID: 259030 RVA: 0x00F47A57 File Offset: 0x00F45C57
		private void RemoveTick()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x0603F3D7 RID: 259031 RVA: 0x00F47A7C File Offset: 0x00F45C7C
		private void RefreshBar(float current, float target)
		{
			float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
			base.GetSprite(5).SetFillAmount(fillAmount);
		}

		// Token: 0x0603F3D8 RID: 259032 RVA: 0x00F47AAE File Offset: 0x00F45CAE
		private void SetExpTextVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}

		// Token: 0x0603F3D9 RID: 259033 RVA: 0x00F47ABD File Offset: 0x00F45CBD
		private void SetExpText(int expCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoadBookLevelUpTipsExp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
		}

		// Token: 0x0603F3DA RID: 259034 RVA: 0x00F47AE0 File Offset: 0x00F45CE0
		private void SetExpMaxText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoadBookLevelCanUp_Text", Array.Empty<object>());
			this.SetExpTextVisible(true);
		}

		// Token: 0x04020F5C RID: 135004
		private ETipsType TipsType;

		// Token: 0x04020F5D RID: 135005
		private int PreLevel;

		// Token: 0x04020F5E RID: 135006
		private int CurLevel;

		// Token: 0x04020F5F RID: 135007
		private int PreExpTotalCount;

		// Token: 0x04020F60 RID: 135008
		private int CurExpTotalCount;

		// Token: 0x04020F61 RID: 135009
		private int PreLevelTargetExp;

		// Token: 0x04020F62 RID: 135010
		private int PreCurExpCount;

		// Token: 0x04020F63 RID: 135011
		private int CurExpCount;

		// Token: 0x04020F64 RID: 135012
		private int CurTargetExp;

		// Token: 0x04020F65 RID: 135013
		private GenericLayout<LevelItemGrid, int> LevelLayout;

		// Token: 0x04020F66 RID: 135014
		private float LevelItemWidth;

		// Token: 0x04020F67 RID: 135015
		[Nullable(2)]
		private LguiFloatTween OffsetTweenX;

		// Token: 0x04020F68 RID: 135016
		private float LevelItemSpacing;

		// Token: 0x04020F69 RID: 135017
		[Nullable(2)]
		protected TimerHandle TickHandle;

		// Token: 0x04020F6A RID: 135018
		protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

		// Token: 0x04020F6B RID: 135019
		protected bool RunBarAnim;

		// Token: 0x04020F6C RID: 135020
		protected float RunBarAnimTime;

		// Token: 0x04020F6D RID: 135021
		protected float StartValue;

		// Token: 0x04020F6E RID: 135022
		protected float TargetValue;

		// Token: 0x04020F6F RID: 135023
		protected float EndValue;

		// Token: 0x04020F70 RID: 135024
		protected CustomPromise BarAnimPromise = new CustomPromise();
	}
}
