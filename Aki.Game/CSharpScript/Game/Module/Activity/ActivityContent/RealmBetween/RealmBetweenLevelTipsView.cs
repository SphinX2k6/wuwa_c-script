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

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006274 RID: 25204
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenLevelTipsView : UiViewBase
	{
		// Token: 0x0603F73B RID: 259899 RVA: 0x00F56B94 File Offset: 0x00F54D94
		public RealmBetweenLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F73C RID: 259900 RVA: 0x00F56BCC File Offset: 0x00F54DCC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0603F73D RID: 259901 RVA: 0x00F56C80 File Offset: 0x00F54E80
		protected override void OnStart()
		{
			this.OffsetTweenX = new LguiFloatTween();
			this.OffsetTweenX.BindUpdateTween(new Action<float>(this.UpdateOffsetX));
			this.OffsetTweenX.BindCompleteTween(new Action(this.OnCompleteOffsetX));
			ActivityRealmBetweenData activityRealmBetweenData = this.OpenParam as ActivityRealmBetweenData;
			this.PreLevel = activityRealmBetweenData.LastTravelLevel;
			this.CurLevel = activityRealmBetweenData.TravelLevel;
			this.PreExpTotalCount = activityRealmBetweenData.LastExpCount;
			this.CurExpTotalCount = activityRealmBetweenData.GetExpItemCount();
			this.PreCurExpCount = activityRealmBetweenData.LastCurrentExpCount;
			IRealmBetweenLevelData realmBetweenLevelData;
			activityRealmBetweenData.TravelLevelData.TryGetValue(this.PreLevel, out realmBetweenLevelData);
			this.PreLevelTargetExp = realmBetweenLevelData.TargetExp;
			this.CurExpCount = activityRealmBetweenData.GetCurrentExp();
			this.CurTargetExp = activityRealmBetweenData.GetCurrentTargetExp();
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
			this.RefreshLayout(activityRealmBetweenData.MaxTravelLevel);
		}

		// Token: 0x0603F73E RID: 259902 RVA: 0x00F56DDE File Offset: 0x00F54FDE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603F73F RID: 259903 RVA: 0x00F56DFC File Offset: 0x00F54FFC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603F740 RID: 259904 RVA: 0x00F56E1A File Offset: 0x00F5501A
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "TipsChange")
			{
				this.SetExpMaxText();
			}
		}

		// Token: 0x0603F741 RID: 259905 RVA: 0x00F56E30 File Offset: 0x00F55030
		protected override void OnBeforeShow()
		{
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Refresh), 20f, 1f, null, null, true);
			switch (this.TipsType)
			{
			case ETipsType.ExpAdd:
				this.SetExpText(this.CurExpCount - this.PreCurExpCount);
				this.SetExpTextVisible(true);
				this.RefreshBar((float)this.CurExpCount, (float)this.CurTargetExp);
				this.RefreshBarAdd((float)this.PreCurExpCount, (float)this.CurTargetExp);
				return;
			case ETipsType.LevelUp:
				this.SetExpTextVisible(false);
				this.RefreshBar((float)this.PreLevelTargetExp, (float)this.PreLevelTargetExp);
				this.RefreshBarAdd((float)this.PreLevelTargetExp, (float)this.PreLevelTargetExp);
				return;
			case ETipsType.LevelUpAndExpAdd:
				this.SetExpText(this.CurExpTotalCount - this.PreExpTotalCount);
				this.SetExpTextVisible(true);
				this.RefreshBar((float)this.PreLevelTargetExp, (float)this.PreLevelTargetExp);
				this.RefreshBarAdd((float)this.PreLevelTargetExp, (float)this.PreLevelTargetExp);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603F742 RID: 259906 RVA: 0x00F56F38 File Offset: 0x00F55138
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

		// Token: 0x0603F743 RID: 259907 RVA: 0x00F56F82 File Offset: 0x00F55182
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

		// Token: 0x0603F744 RID: 259908 RVA: 0x00F56F9A File Offset: 0x00F5519A
		private void UpdateOffsetX(float value)
		{
			UUIItem rootUiItem = this.LevelLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetAnchorOffsetX(value);
		}

		// Token: 0x0603F745 RID: 259909 RVA: 0x00F56FB2 File Offset: 0x00F551B2
		private void OnCompleteOffsetX()
		{
			LevelItemGrid layoutItemByIndex = this.LevelLayout.GetLayoutItemByIndex(this.CurLevel);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.PlayLevelUpAnim();
		}

		// Token: 0x0603F746 RID: 259910 RVA: 0x00F56FD0 File Offset: 0x00F551D0
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

		// Token: 0x0603F747 RID: 259911 RVA: 0x00F57030 File Offset: 0x00F55230
		private float GetOffsetX(int index)
		{
			return -((float)index * (this.LevelItemWidth + this.LevelItemSpacing) + this.LevelItemWidth * 0.5f);
		}

		// Token: 0x0603F748 RID: 259912 RVA: 0x00F57050 File Offset: 0x00F55250
		private LevelItemGrid OnCreateItem()
		{
			return new LevelItemGrid();
		}

		// Token: 0x0603F749 RID: 259913 RVA: 0x00F57058 File Offset: 0x00F55258
		private UniTask RunExpAdd()
		{
			RealmBetweenLevelTipsView.<RunExpAdd>d__27 <RunExpAdd>d__;
			<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunExpAdd>d__.<>4__this = this;
			<RunExpAdd>d__.<>1__state = -1;
			<RunExpAdd>d__.<>t__builder.Start<RealmBetweenLevelTipsView.<RunExpAdd>d__27>(ref <RunExpAdd>d__);
			return <RunExpAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0603F74A RID: 259914 RVA: 0x00F5709C File Offset: 0x00F5529C
		private UniTask RunLevelUp()
		{
			RealmBetweenLevelTipsView.<RunLevelUp>d__28 <RunLevelUp>d__;
			<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelUp>d__.<>4__this = this;
			<RunLevelUp>d__.<>1__state = -1;
			<RunLevelUp>d__.<>t__builder.Start<RealmBetweenLevelTipsView.<RunLevelUp>d__28>(ref <RunLevelUp>d__);
			return <RunLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0603F74B RID: 259915 RVA: 0x00F570E0 File Offset: 0x00F552E0
		protected void Refresh(float delta)
		{
			if (this.TickHandle == null || !this.RunBarAnim)
			{
				return;
			}
			this.RunBarAnimTime += delta;
			float current = MathUtils.Instance.Lerp(this.StartValue, this.TargetValue, this.RunBarAnimTime / (float)this.BarAnimTime);
			this.RefreshBarAdd(current, this.EndValue);
			if (this.RunBarAnimTime >= (float)this.BarAnimTime)
			{
				this.EndBarAnim();
			}
		}

		// Token: 0x0603F74C RID: 259916 RVA: 0x00F57154 File Offset: 0x00F55354
		private UniTask StartBarAnim(float current, float target, float end)
		{
			RealmBetweenLevelTipsView.<StartBarAnim>d__38 <StartBarAnim>d__;
			<StartBarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartBarAnim>d__.<>4__this = this;
			<StartBarAnim>d__.current = current;
			<StartBarAnim>d__.target = target;
			<StartBarAnim>d__.end = end;
			<StartBarAnim>d__.<>1__state = -1;
			<StartBarAnim>d__.<>t__builder.Start<RealmBetweenLevelTipsView.<StartBarAnim>d__38>(ref <StartBarAnim>d__);
			return <StartBarAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603F74D RID: 259917 RVA: 0x00F571AF File Offset: 0x00F553AF
		private void EndBarAnim()
		{
			this.RunBarAnim = false;
			this.BarAnimPromise.SetResult();
		}

		// Token: 0x0603F74E RID: 259918 RVA: 0x00F571C3 File Offset: 0x00F553C3
		private void RemoveTick()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x0603F74F RID: 259919 RVA: 0x00F571E8 File Offset: 0x00F553E8
		private void RefreshBar(float current, float target)
		{
			float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0603F750 RID: 259920 RVA: 0x00F57220 File Offset: 0x00F55420
		private void RefreshBarAdd(float current, float target)
		{
			float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0603F751 RID: 259921 RVA: 0x00F57257 File Offset: 0x00F55457
		private void SetExpTextVisible(bool bVisible)
		{
			base.GetItem(6).SetUIActive(bVisible);
		}

		// Token: 0x0603F752 RID: 259922 RVA: 0x00F57266 File Offset: 0x00F55466
		private void SetExpText(int expCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RealmBetweenLevelUpTipsExp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
		}

		// Token: 0x0603F753 RID: 259923 RVA: 0x00F57289 File Offset: 0x00F55489
		private void SetExpMaxText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RealmBetweenLevelCanUp_Text", Array.Empty<object>());
			this.SetExpTextVisible(true);
		}

		// Token: 0x0402126B RID: 135787
		private ETipsType TipsType;

		// Token: 0x0402126C RID: 135788
		private int PreLevel;

		// Token: 0x0402126D RID: 135789
		private int CurLevel;

		// Token: 0x0402126E RID: 135790
		private int PreExpTotalCount;

		// Token: 0x0402126F RID: 135791
		private int CurExpTotalCount;

		// Token: 0x04021270 RID: 135792
		private int PreLevelTargetExp;

		// Token: 0x04021271 RID: 135793
		private int PreCurExpCount;

		// Token: 0x04021272 RID: 135794
		private int CurExpCount;

		// Token: 0x04021273 RID: 135795
		private int CurTargetExp;

		// Token: 0x04021274 RID: 135796
		private GenericLayout<LevelItemGrid, int> LevelLayout;

		// Token: 0x04021275 RID: 135797
		private float LevelItemWidth;

		// Token: 0x04021276 RID: 135798
		[Nullable(2)]
		private LguiFloatTween OffsetTweenX;

		// Token: 0x04021277 RID: 135799
		private float LevelItemSpacing;

		// Token: 0x04021278 RID: 135800
		[Nullable(2)]
		protected TimerHandle TickHandle;

		// Token: 0x04021279 RID: 135801
		protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

		// Token: 0x0402127A RID: 135802
		protected bool RunBarAnim;

		// Token: 0x0402127B RID: 135803
		protected float RunBarAnimTime;

		// Token: 0x0402127C RID: 135804
		protected float StartValue;

		// Token: 0x0402127D RID: 135805
		protected float TargetValue;

		// Token: 0x0402127E RID: 135806
		protected float EndValue;

		// Token: 0x0402127F RID: 135807
		protected CustomPromise BarAnimPromise = new CustomPromise();
	}
}
