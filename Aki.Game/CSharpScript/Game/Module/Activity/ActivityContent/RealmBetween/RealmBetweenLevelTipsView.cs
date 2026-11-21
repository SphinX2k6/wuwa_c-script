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
	// Token: 0x020051F2 RID: 20978
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenLevelTipsView : UiViewBase
	{
		// Token: 0x060343FC RID: 214012 RVA: 0x00E9DAF0 File Offset: 0x00E9BCF0
		public RealmBetweenLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060343FD RID: 214013 RVA: 0x00E9DB28 File Offset: 0x00E9BD28
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

		// Token: 0x060343FE RID: 214014 RVA: 0x00E9DBDC File Offset: 0x00E9BDDC
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

		// Token: 0x060343FF RID: 214015 RVA: 0x00E9DD3A File Offset: 0x00E9BF3A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06034400 RID: 214016 RVA: 0x00E9DD58 File Offset: 0x00E9BF58
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06034401 RID: 214017 RVA: 0x00E9DD76 File Offset: 0x00E9BF76
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "TipsChange")
			{
				this.SetExpMaxText();
			}
		}

		// Token: 0x06034402 RID: 214018 RVA: 0x00E9DD8C File Offset: 0x00E9BF8C
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

		// Token: 0x06034403 RID: 214019 RVA: 0x00E9DE94 File Offset: 0x00E9C094
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

		// Token: 0x06034404 RID: 214020 RVA: 0x00E9DEDE File Offset: 0x00E9C0DE
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

		// Token: 0x06034405 RID: 214021 RVA: 0x00E9DEF6 File Offset: 0x00E9C0F6
		private void UpdateOffsetX(float value)
		{
			UUIItem rootUiItem = this.LevelLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetAnchorOffsetX(value);
		}

		// Token: 0x06034406 RID: 214022 RVA: 0x00E9DF0E File Offset: 0x00E9C10E
		private void OnCompleteOffsetX()
		{
			LevelItemGrid layoutItemByIndex = this.LevelLayout.GetLayoutItemByIndex(this.CurLevel);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.PlayLevelUpAnim();
		}

		// Token: 0x06034407 RID: 214023 RVA: 0x00E9DF2C File Offset: 0x00E9C12C
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

		// Token: 0x06034408 RID: 214024 RVA: 0x00E9DF8C File Offset: 0x00E9C18C
		private float GetOffsetX(int index)
		{
			return -((float)index * (this.LevelItemWidth + this.LevelItemSpacing) + this.LevelItemWidth * 0.5f);
		}

		// Token: 0x06034409 RID: 214025 RVA: 0x00E9DFAC File Offset: 0x00E9C1AC
		private LevelItemGrid OnCreateItem()
		{
			return new LevelItemGrid();
		}

		// Token: 0x0603440A RID: 214026 RVA: 0x00E9DFB4 File Offset: 0x00E9C1B4
		private UniTask RunExpAdd()
		{
			RealmBetweenLevelTipsView.<RunExpAdd>d__27 <RunExpAdd>d__;
			<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunExpAdd>d__.<>4__this = this;
			<RunExpAdd>d__.<>1__state = -1;
			<RunExpAdd>d__.<>t__builder.Start<RealmBetweenLevelTipsView.<RunExpAdd>d__27>(ref <RunExpAdd>d__);
			return <RunExpAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0603440B RID: 214027 RVA: 0x00E9DFF8 File Offset: 0x00E9C1F8
		private UniTask RunLevelUp()
		{
			RealmBetweenLevelTipsView.<RunLevelUp>d__28 <RunLevelUp>d__;
			<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelUp>d__.<>4__this = this;
			<RunLevelUp>d__.<>1__state = -1;
			<RunLevelUp>d__.<>t__builder.Start<RealmBetweenLevelTipsView.<RunLevelUp>d__28>(ref <RunLevelUp>d__);
			return <RunLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0603440C RID: 214028 RVA: 0x00E9E03C File Offset: 0x00E9C23C
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

		// Token: 0x0603440D RID: 214029 RVA: 0x00E9E0B0 File Offset: 0x00E9C2B0
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

		// Token: 0x0603440E RID: 214030 RVA: 0x00E9E10B File Offset: 0x00E9C30B
		private void EndBarAnim()
		{
			this.RunBarAnim = false;
			this.BarAnimPromise.SetResult();
		}

		// Token: 0x0603440F RID: 214031 RVA: 0x00E9E11F File Offset: 0x00E9C31F
		private void RemoveTick()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x06034410 RID: 214032 RVA: 0x00E9E144 File Offset: 0x00E9C344
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

		// Token: 0x06034411 RID: 214033 RVA: 0x00E9E17C File Offset: 0x00E9C37C
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

		// Token: 0x06034412 RID: 214034 RVA: 0x00E9E1B3 File Offset: 0x00E9C3B3
		private void SetExpTextVisible(bool bVisible)
		{
			base.GetItem(6).SetUIActive(bVisible);
		}

		// Token: 0x06034413 RID: 214035 RVA: 0x00E9E1C2 File Offset: 0x00E9C3C2
		private void SetExpText(int expCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RealmBetweenLevelUpTipsExp_Text", new <>z__ReadOnlySingleElementList<object>(expCount));
		}

		// Token: 0x06034414 RID: 214036 RVA: 0x00E9E1E5 File Offset: 0x00E9C3E5
		private void SetExpMaxText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RealmBetweenLevelCanUp_Text", Array.Empty<object>());
			this.SetExpTextVisible(true);
		}

		// Token: 0x0401BB9A RID: 113562
		private ETipsType TipsType;

		// Token: 0x0401BB9B RID: 113563
		private int PreLevel;

		// Token: 0x0401BB9C RID: 113564
		private int CurLevel;

		// Token: 0x0401BB9D RID: 113565
		private int PreExpTotalCount;

		// Token: 0x0401BB9E RID: 113566
		private int CurExpTotalCount;

		// Token: 0x0401BB9F RID: 113567
		private int PreLevelTargetExp;

		// Token: 0x0401BBA0 RID: 113568
		private int PreCurExpCount;

		// Token: 0x0401BBA1 RID: 113569
		private int CurExpCount;

		// Token: 0x0401BBA2 RID: 113570
		private int CurTargetExp;

		// Token: 0x0401BBA3 RID: 113571
		private GenericLayout<LevelItemGrid, int> LevelLayout;

		// Token: 0x0401BBA4 RID: 113572
		private float LevelItemWidth;

		// Token: 0x0401BBA5 RID: 113573
		[Nullable(2)]
		private LguiFloatTween OffsetTweenX;

		// Token: 0x0401BBA6 RID: 113574
		private float LevelItemSpacing;

		// Token: 0x0401BBA7 RID: 113575
		[Nullable(2)]
		protected TimerHandle TickHandle;

		// Token: 0x0401BBA8 RID: 113576
		protected int BarAnimTime = ConfigCommonParamById.GetIntConfig("TravelExpBarDisplayTime").Value;

		// Token: 0x0401BBA9 RID: 113577
		protected bool RunBarAnim;

		// Token: 0x0401BBAA RID: 113578
		protected float RunBarAnimTime;

		// Token: 0x0401BBAB RID: 113579
		protected float StartValue;

		// Token: 0x0401BBAC RID: 113580
		protected float TargetValue;

		// Token: 0x0401BBAD RID: 113581
		protected float EndValue;

		// Token: 0x0401BBAE RID: 113582
		protected CustomPromise BarAnimPromise = new CustomPromise();
	}
}
