using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D34 RID: 19764
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleHonamiStoryMapLevelView : BattleVisibleChildView
	{
		// Token: 0x060319C8 RID: 203208 RVA: 0x00DDEF98 File Offset: 0x00DDD198
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060319C9 RID: 203209 RVA: 0x00DDF14C File Offset: 0x00DDD34C
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryMapLevelView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319CA RID: 203210 RVA: 0x00DDF190 File Offset: 0x00DDD390
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			this.TweenPlayer = new BattleUiTweenAnimPlayer();
			this.TweenPlayer.InitTweenAnim(6, base.GetItem(6), false);
			this.TweenPlayer.InitTweenAnim(7, base.GetItem(7), false);
			this.OnPollutionInit();
			this.AddEvents();
			if (!FunctionModel.Instance.IsOpen(10114))
			{
				base.SetVisible(1, false);
				EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
				EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
		}

		// Token: 0x060319CB RID: 203211 RVA: 0x00DDF23B File Offset: 0x00DDD43B
		public override void Reset()
		{
			this.RemoveEvents();
			TimerHandle pollutionTimer = this.PollutionTimer;
			if (pollutionTimer != null)
			{
				pollutionTimer.Remove();
			}
			this.PollutionTimer = null;
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer != null)
			{
				tweenPlayer.Clear(false);
			}
			this.TweenPlayer = null;
			base.Reset();
		}

		// Token: 0x060319CC RID: 203212 RVA: 0x00DDF27B File Offset: 0x00DDD47B
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryInstInfoUpdate, new Action(this.OnPollutionInit));
			EventSystem.Instance.Add<int>(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnPollutionUpdate));
		}

		// Token: 0x060319CD RID: 203213 RVA: 0x00DDF2B5 File Offset: 0x00DDD4B5
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryInstInfoUpdate, new Action(this.OnPollutionInit));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnPollutionUpdate));
			this.RemoveFunctionOpenEvents();
		}

		// Token: 0x060319CE RID: 203214 RVA: 0x00DDF2F8 File Offset: 0x00DDD4F8
		private void RemoveFunctionOpenEvents()
		{
			if (EventSystem.Instance.Has(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
			if (EventSystem.Instance.Has(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
		}

		// Token: 0x060319CF RID: 203215 RVA: 0x00DDF377 File Offset: 0x00DDD577
		private void OnPollutionInit()
		{
			this.RefreshPollution(true);
		}

		// Token: 0x060319D0 RID: 203216 RVA: 0x00DDF380 File Offset: 0x00DDD580
		private void OnPollutionUpdate(int _)
		{
			this.RefreshPollution(false);
			BattleHonamiStoryMapLevelHoverItem hoverItem = this.HoverItem;
			if (hoverItem == null)
			{
				return;
			}
			hoverItem.Refresh();
		}

		// Token: 0x060319D1 RID: 203217 RVA: 0x00DDF399 File Offset: 0x00DDD599
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			if (functionType == EFunctionType.HonamiStoryPollution && isOpen)
			{
				base.SetVisible(1, true);
				this.RemoveFunctionOpenEvents();
			}
		}

		// Token: 0x060319D2 RID: 203218 RVA: 0x00DDF3B8 File Offset: 0x00DDD5B8
		private void RefreshPollution(bool isInit = false)
		{
			int pollutionLevel = HonamiStoryModel.Instance.PollutionLevel;
			int pollutionMaxLevel = HonamiStoryModel.Instance.PollutionMaxLevel;
			bool flag = pollutionMaxLevel > 0 && pollutionLevel == pollutionMaxLevel;
			BattleHonamiStoryMapLevelView.EPollutionStateType epollutionStateType = flag ? BattleHonamiStoryMapLevelView.EPollutionStateType.Danger : this.GetPollutionState(pollutionLevel);
			if (isInit || epollutionStateType != this.CurrentState)
			{
				this.RefreshPollutionState(epollutionStateType);
				this.CurrentState = epollutionStateType;
			}
			string text = "#ffffff";
			base.GetSprite(0).SetColor(FColor.FromHex(flag ? "#a02649" : text));
			base.GetTexture(1).SetColor(FColor.FromHex(flag ? "#f54667" : text));
			base.GetText(4).SetText(flag ? "Max" : pollutionLevel.ToString(), true);
			if (this.TweenPlayer != null && pollutionLevel > this.LastLevel)
			{
				this.TweenPlayer.PlayTweenAnim(6);
				if (flag)
				{
					this.TweenPlayer.PlayTweenAnim(7);
				}
			}
			this.LastLevel = pollutionLevel;
			bool flag2 = HonamiStoryUtil.CheckInHonamiStoryTopTower();
			if (flag || flag2)
			{
				TimerHandle pollutionTimer = this.PollutionTimer;
				if (pollutionTimer != null)
				{
					pollutionTimer.Remove();
				}
				this.PollutionTimer = null;
				float yaw = flag ? 76f : 10f;
				float fillAmount = flag ? 0.186f : 0f;
				base.GetSprite(2).SetFillAmount(fillAmount);
				UUIItem item = base.GetItem(3);
				FRotator frotator = new FRotator();
				frotator.Yaw = yaw;
				item.SetUIRelativeRotation(frotator);
				return;
			}
			if (this.PollutionTimer == null)
			{
				this.PollutionTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					int pollutionLevel2 = HonamiStoryModel.Instance.PollutionLevel;
					float pollutionStarTime = HonamiStoryModel.Instance.PollutionStarTime;
					float value = (pollutionStarTime > 0f) ? ((float)TimeUtil.Instance.GetServerStopTimeStamp() - pollutionStarTime) : 0f;
					Dictionary<int, IHonamiStoryPollution> pollutionLevelMap = HonamiStoryModel.Instance.PollutionLevelMap;
					int? num;
					if (pollutionLevelMap == null)
					{
						num = null;
					}
					else
					{
						IHonamiStoryPollution valueOrDefault = pollutionLevelMap.GetValueOrDefault(pollutionLevel2);
						num = ((valueOrDefault != null) ? new int?(valueOrDefault.PersistMilliseconds) : null);
					}
					int? num2 = num;
					int valueOrDefault2 = num2.GetValueOrDefault(1);
					float fillAmount2 = MathUtils.Instance.RangeClamp(value, 0f, (float)valueOrDefault2, 0f, 0.186f);
					base.GetSprite(2).SetFillAmount(fillAmount2);
					UUIItem item2 = base.GetItem(3);
					FRotator frotator2 = new FRotator();
					frotator2.Yaw = MathUtils.Instance.RangeClamp(value, 0f, (float)valueOrDefault2, 10f, 76f);
					item2.SetUIRelativeRotation(frotator2);
				}, 500f, 1f, null, null, true);
			}
		}

		// Token: 0x060319D3 RID: 203219 RVA: 0x00DDF548 File Offset: 0x00DDD748
		private void RefreshPollutionState(BattleHonamiStoryMapLevelView.EPollutionStateType state)
		{
			string hexStr;
			string hexStr2;
			if (state == BattleHonamiStoryMapLevelView.EPollutionStateType.Safe)
			{
				hexStr = "#bbf0b4";
				hexStr2 = "#ffffff";
			}
			else if (state == BattleHonamiStoryMapLevelView.EPollutionStateType.Warning)
			{
				hexStr = "#e9ce83";
				hexStr2 = "#fff6c9";
			}
			else
			{
				hexStr = "#f54667";
				hexStr2 = "#f51818";
			}
			FColor color = FColor.FromHex(hexStr);
			FColor color2 = FColor.FromHex(hexStr2);
			base.GetSprite(2).SetColor(color);
			base.GetText(4).SetColor(color);
			base.GetTexture(5).SetColor(color2);
		}

		// Token: 0x060319D4 RID: 203220 RVA: 0x00DDF5BC File Offset: 0x00DDD7BC
		private BattleHonamiStoryMapLevelView.EPollutionStateType GetPollutionState(int level)
		{
			int pollutionWarningLevel = HonamiStoryModel.Instance.PollutionWarningLevel;
			int pollutionDangerLevel = HonamiStoryModel.Instance.PollutionDangerLevel;
			if (pollutionDangerLevel > 0 && level >= pollutionDangerLevel)
			{
				return BattleHonamiStoryMapLevelView.EPollutionStateType.Danger;
			}
			if (pollutionWarningLevel > 0 && level >= pollutionWarningLevel)
			{
				return BattleHonamiStoryMapLevelView.EPollutionStateType.Warning;
			}
			return BattleHonamiStoryMapLevelView.EPollutionStateType.Safe;
		}

		// Token: 0x060319D5 RID: 203221 RVA: 0x00DDF5F4 File Offset: 0x00DDD7F4
		private void OnClickToggle(EToggleState toggleState)
		{
			BattleHonamiStoryMapLevelHoverItem hoverItem = this.HoverItem;
			if (hoverItem == null)
			{
				return;
			}
			hoverItem.SetActive(toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x060319D6 RID: 203222 RVA: 0x00DDF60C File Offset: 0x00DDD80C
		private void OnAutoClose()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			if (extendToggle != null)
			{
				if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
			}
		}

		// Token: 0x0401A438 RID: 107576
		private const float BAR_MAX_FILL = 0.186f;

		// Token: 0x0401A439 RID: 107577
		private const float BAR_MIN_YAW = 10f;

		// Token: 0x0401A43A RID: 107578
		private const float BAR_MAX_YAW = 76f;

		// Token: 0x0401A43B RID: 107579
		private BattleHonamiStoryMapLevelView.EPollutionStateType CurrentState;

		// Token: 0x0401A43C RID: 107580
		private TimerHandle PollutionTimer;

		// Token: 0x0401A43D RID: 107581
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0401A43E RID: 107582
		private int LastLevel;

		// Token: 0x0401A43F RID: 107583
		private BattleHonamiStoryMapLevelHoverItem HoverItem;

		// Token: 0x0200AA04 RID: 43524
		[NullableContext(0)]
		private enum EPollutionStateType
		{
			// Token: 0x040348B0 RID: 215216
			Safe,
			// Token: 0x040348B1 RID: 215217
			Warning,
			// Token: 0x040348B2 RID: 215218
			Danger
		}

		// Token: 0x0200AA05 RID: 43525
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x040348B4 RID: 215220
			IconBgSprite,
			// Token: 0x040348B5 RID: 215221
			IconTexture,
			// Token: 0x040348B6 RID: 215222
			LevelBarSprite,
			// Token: 0x040348B7 RID: 215223
			BarLightItem,
			// Token: 0x040348B8 RID: 215224
			LevelText,
			// Token: 0x040348B9 RID: 215225
			ShineTexture,
			// Token: 0x040348BA RID: 215226
			LevelUpItem,
			// Token: 0x040348BB RID: 215227
			LevelUpMaxItem,
			// Token: 0x040348BC RID: 215228
			HoverItem,
			// Token: 0x040348BD RID: 215229
			Toggle
		}
	}
}
