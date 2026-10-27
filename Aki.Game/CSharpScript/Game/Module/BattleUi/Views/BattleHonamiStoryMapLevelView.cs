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
	// Token: 0x02005D52 RID: 23890
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleHonamiStoryMapLevelView : BattleVisibleChildView
	{
		// Token: 0x0603CA6F RID: 248431 RVA: 0x00E8E7E4 File Offset: 0x00E8C9E4
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

		// Token: 0x0603CA70 RID: 248432 RVA: 0x00E8E998 File Offset: 0x00E8CB98
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryMapLevelView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA71 RID: 248433 RVA: 0x00E8E9DC File Offset: 0x00E8CBDC
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

		// Token: 0x0603CA72 RID: 248434 RVA: 0x00E8EA87 File Offset: 0x00E8CC87
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

		// Token: 0x0603CA73 RID: 248435 RVA: 0x00E8EAC7 File Offset: 0x00E8CCC7
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryInstInfoUpdate, new Action(this.OnPollutionInit));
			EventSystem.Instance.Add<int>(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnPollutionUpdate));
		}

		// Token: 0x0603CA74 RID: 248436 RVA: 0x00E8EB01 File Offset: 0x00E8CD01
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryInstInfoUpdate, new Action(this.OnPollutionInit));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnPollutionUpdate));
			this.RemoveFunctionOpenEvents();
		}

		// Token: 0x0603CA75 RID: 248437 RVA: 0x00E8EB44 File Offset: 0x00E8CD44
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

		// Token: 0x0603CA76 RID: 248438 RVA: 0x00E8EBC3 File Offset: 0x00E8CDC3
		private void OnPollutionInit()
		{
			this.RefreshPollution(true);
		}

		// Token: 0x0603CA77 RID: 248439 RVA: 0x00E8EBCC File Offset: 0x00E8CDCC
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

		// Token: 0x0603CA78 RID: 248440 RVA: 0x00E8EBE5 File Offset: 0x00E8CDE5
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			if (functionType == EFunctionType.HonamiStoryPollution && isOpen)
			{
				base.SetVisible(1, true);
				this.RemoveFunctionOpenEvents();
			}
		}

		// Token: 0x0603CA79 RID: 248441 RVA: 0x00E8EC04 File Offset: 0x00E8CE04
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

		// Token: 0x0603CA7A RID: 248442 RVA: 0x00E8ED94 File Offset: 0x00E8CF94
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

		// Token: 0x0603CA7B RID: 248443 RVA: 0x00E8EE08 File Offset: 0x00E8D008
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

		// Token: 0x0603CA7C RID: 248444 RVA: 0x00E8EE40 File Offset: 0x00E8D040
		private void OnClickToggle(EToggleState toggleState)
		{
			BattleHonamiStoryMapLevelHoverItem hoverItem = this.HoverItem;
			if (hoverItem == null)
			{
				return;
			}
			hoverItem.SetActive(toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x0603CA7D RID: 248445 RVA: 0x00E8EE58 File Offset: 0x00E8D058
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

		// Token: 0x0401F97F RID: 129407
		private const float BAR_MAX_FILL = 0.186f;

		// Token: 0x0401F980 RID: 129408
		private const float BAR_MIN_YAW = 10f;

		// Token: 0x0401F981 RID: 129409
		private const float BAR_MAX_YAW = 76f;

		// Token: 0x0401F982 RID: 129410
		private BattleHonamiStoryMapLevelView.EPollutionStateType CurrentState;

		// Token: 0x0401F983 RID: 129411
		private TimerHandle PollutionTimer;

		// Token: 0x0401F984 RID: 129412
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0401F985 RID: 129413
		private int LastLevel;

		// Token: 0x0401F986 RID: 129414
		private BattleHonamiStoryMapLevelHoverItem HoverItem;

		// Token: 0x0200BFFE RID: 49150
		[NullableContext(0)]
		private enum EPollutionStateType
		{
			// Token: 0x04039EEE RID: 237294
			Safe,
			// Token: 0x04039EEF RID: 237295
			Warning,
			// Token: 0x04039EF0 RID: 237296
			Danger
		}

		// Token: 0x0200BFFF RID: 49151
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039EF2 RID: 237298
			IconBgSprite,
			// Token: 0x04039EF3 RID: 237299
			IconTexture,
			// Token: 0x04039EF4 RID: 237300
			LevelBarSprite,
			// Token: 0x04039EF5 RID: 237301
			BarLightItem,
			// Token: 0x04039EF6 RID: 237302
			LevelText,
			// Token: 0x04039EF7 RID: 237303
			ShineTexture,
			// Token: 0x04039EF8 RID: 237304
			LevelUpItem,
			// Token: 0x04039EF9 RID: 237305
			LevelUpMaxItem,
			// Token: 0x04039EFA RID: 237306
			HoverItem,
			// Token: 0x04039EFB RID: 237307
			Toggle
		}
	}
}
