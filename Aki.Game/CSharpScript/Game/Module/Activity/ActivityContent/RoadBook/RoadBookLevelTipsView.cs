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
	// Token: 0x0200514F RID: 20815
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookLevelTipsView : UiViewBase
	{
		// Token: 0x06034084 RID: 213124 RVA: 0x00E8E3CC File Offset: 0x00E8C5CC
		public RoadBookLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034085 RID: 213125 RVA: 0x00E8E404 File Offset: 0x00E8C604
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

		// Token: 0x06034086 RID: 213126 RVA: 0x00E8E4A0 File Offset: 0x00E8C6A0
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

		// Token: 0x06034087 RID: 213127 RVA: 0x00E8E5FE File Offset: 0x00E8C7FE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06034088 RID: 213128 RVA: 0x00E8E61C File Offset: 0x00E8C81C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06034089 RID: 213129 RVA: 0x00E8E63A File Offset: 0x00E8C83A
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "TipsChange")
			{
				this.SetExpMaxText();
			}
		}

		// Token: 0x0603408A RID: 213130 RVA: 0x00E8E650 File Offset: 0x00E8C850
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

		// Token: 0x0603408B RID: 213131 RVA: 0x00E8E72C File Offset: 0x00E8C92C
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

		// Token: 0x0603408C RID: 213132 RVA: 0x00E8E776 File Offset: 0x00E8C976
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

		// Token: 0x0603408D RID: 213133 RVA: 0x00E8E78E File Offset: 0x00E8C98E
		private void UpdateOffsetX(float value)
		{
			UUIItem rootUiItem = this.LevelLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetAnchorOffsetX(value);
		}

		// Token: 0x0603408E RID: 213134 RVA: 0x00E8E7A6 File Offset: 0x00E8C9A6
		private void OnCompleteOffsetX()
		{
			LevelItemGrid layoutItemByIndex = this.LevelLayout.GetLayoutItemByIndex(this.CurLevel);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.PlayLevelUpAnim();
		}

		// Token: 0x0603408F RID: 213135 RVA: 0x00E8E7C4 File Offset: 0x00E8C9C4
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

		// Token: 0x06034090 RID: 213136 RVA: 0x00E8E824 File Offset: 0x00E8CA24
		private float GetOffsetX(int index)
		{
			return -((float)index * (this.LevelItemWidth + this.LevelItemSpacing) + this.LevelItemWidth * 0.5f);
		}

		// Token: 0x06034091 RID: 213137 RVA: 0x00E8E844 File Offset: 0x00E8CA44
		private LevelItemGrid OnCreateItem()
		{
			return new LevelItemGrid();
		}

		// Token: 0x06034092 RID: 213138 RVA: 0x00E8E84C File Offset: 0x00E8CA4C
		private UniTask RunExpAdd()
		{
			RoadBookLevelTipsView.<RunExpAdd>d__27 <RunExpAdd>d__;
			<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunExpAdd>d__.<>4__this = this;
			<RunExpAdd>d__.<>1__state = -1;
			<RunExpAdd>d__.<>t__builder.Start<RoadBookLevelTipsView.<RunExpAdd>d__27>(ref <RunExpAdd>d__);
			return <RunExpAdd>d__.<>t__builder.Task;
		}

		// Token: 0x06034093 RID: 213139 RVA: 0x00E8E890 File Offset: 0x00E8CA90
		private UniTask RunLevelUp()
		{
			RoadBookLevelTipsView.<RunLevelUp>d__28 <RunLevelUp>d__;
			<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelUp>d__.<>4__this = this;
			<RunLevelUp>d__.<>1__state = -1;
			<RunLevelUp>d__.<>t__builder.Start<RoadBookLevelTipsView.<RunLevelUp>d__28>(ref <RunLevelUp>d__);
			return <RunLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x06034094 RID: 213140 RVA: 0x00E8E8D4 File Offset: 0x00E8CAD4
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

		// Token: 0x06034095 RID: 213141 RVA: 0x00E8E940 File Offset: 0x00E8CB40
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

		// Token: 0x06034096 RID: 213142 RVA: 0x00E8E99B File Offset: 0x00E8CB9B
		private void EndBarAnim()
		{
			this.RunBarAnim = false;
			this.BarAnimPromise.SetResult();
		}

		// Token: 0x06034097 RID: 213143 RVA: 0x00E8E9AF File Offset: 0x00E8CBAF
		private void RemoveTick()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x06034098 RID: 213144 RVA: 0x00E8E9D4 File Offset: 0x00E8CBD4
		private void RefreshBar(float current, float target)
		{
			float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
			base.GetSprite(5).SetFillAmount(fillAmount);
		}

		// Token: 0x06034099 RID: 213145 RVA: 0x00E8EA06 File Offset: 0x00E8CC06
		private void SetExpTextVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}

		// Token: 0x0603409A RID: 213146 RVA: 0x00E8EA15 File Offset: 0x00E8CC15
		private void SetExpText(int expCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoadBookLevelUpTipsExp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
		}

		// Token: 0x0603409B RID: 213147 RVA: 0x00E8EA38 File Offset: 0x00E8CC38
		private void SetExpMaxText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoadBookLevelCanUp_Text", Array.Empty<object>());
			this.SetExpTextVisible(true);
		}

		// Token: 0x0401B88B RID: 112779
		private ETipsType TipsType;

		// Token: 0x0401B88C RID: 112780
		private int PreLevel;

		// Token: 0x0401B88D RID: 112781
		private int CurLevel;

		// Token: 0x0401B88E RID: 112782
		private int PreExpTotalCount;

		// Token: 0x0401B88F RID: 112783
		private int CurExpTotalCount;

		// Token: 0x0401B890 RID: 112784
		private int PreLevelTargetExp;

		// Token: 0x0401B891 RID: 112785
		private int PreCurExpCount;

		// Token: 0x0401B892 RID: 112786
		private int CurExpCount;

		// Token: 0x0401B893 RID: 112787
		private int CurTargetExp;

		// Token: 0x0401B894 RID: 112788
		private GenericLayout<LevelItemGrid, int> LevelLayout;

		// Token: 0x0401B895 RID: 112789
		private float LevelItemWidth;

		// Token: 0x0401B896 RID: 112790
		[Nullable(2)]
		private LguiFloatTween OffsetTweenX;

		// Token: 0x0401B897 RID: 112791
		private float LevelItemSpacing;

		// Token: 0x0401B898 RID: 112792
		[Nullable(2)]
		protected TimerHandle TickHandle;

		// Token: 0x0401B899 RID: 112793
		protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

		// Token: 0x0401B89A RID: 112794
		protected bool RunBarAnim;

		// Token: 0x0401B89B RID: 112795
		protected float RunBarAnimTime;

		// Token: 0x0401B89C RID: 112796
		protected float StartValue;

		// Token: 0x0401B89D RID: 112797
		protected float TargetValue;

		// Token: 0x0401B89E RID: 112798
		protected float EndValue;

		// Token: 0x0401B89F RID: 112799
		protected CustomPromise BarAnimPromise = new CustomPromise();
	}
}
