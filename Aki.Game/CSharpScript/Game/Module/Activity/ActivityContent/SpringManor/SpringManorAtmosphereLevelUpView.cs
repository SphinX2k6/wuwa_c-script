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

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006095 RID: 24725
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorAtmosphereLevelUpView : UiViewBase
	{
		// Token: 0x0603E7EC RID: 255980 RVA: 0x00F1AF06 File Offset: 0x00F19106
		public SpringManorAtmosphereLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E7ED RID: 255981 RVA: 0x00F1AF1C File Offset: 0x00F1911C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E7EE RID: 255982 RVA: 0x00F1AFA8 File Offset: 0x00F191A8
		protected override void OnStart()
		{
			SpringManorAtmosphereLevelUpViewData springManorAtmosphereLevelUpViewData = this.OpenParam as SpringManorAtmosphereLevelUpViewData;
			this.PreLevel = springManorAtmosphereLevelUpViewData.OldLevel;
			this.CurLevel = springManorAtmosphereLevelUpViewData.NewLevel;
			this.PreAtmosphere = springManorAtmosphereLevelUpViewData.OldAtmosphere;
			this.CurAtmosphere = springManorAtmosphereLevelUpViewData.NewAtmosphere;
			this.CurMaxAtmosphere = springManorAtmosphereLevelUpViewData.MaxAtmosphere;
			SpringManorConfig instance = SpringManorConfig.Instance;
			AtmosphereLevel? levelConfigById = instance.GetLevelConfigById(this.PreLevel);
			this.PreNeed = levelConfigById.Value.AtmosphereNeed;
			this.PreNext = levelConfigById.Value.AtmosphereNext;
			AtmosphereLevel? levelConfigById2 = instance.GetLevelConfigById(this.CurLevel);
			this.CurNeed = levelConfigById2.Value.AtmosphereNeed;
			this.CurNext = levelConfigById2.Value.AtmosphereNext;
			if (this.CurLevel > this.PreLevel)
			{
				this.TipsType = ETipsType.LevelUp;
			}
			else
			{
				this.TipsType = ETipsType.ExpAdd;
			}
			UUIText text = base.GetText(0);
			(((text != null) ? text.GetOwner() : null) as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
			UUIText text2 = base.GetText(2);
			(((text2 != null) ? text2.GetOwner() : null) as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
		}

		// Token: 0x0603E7EF RID: 255983 RVA: 0x00F1B0EC File Offset: 0x00F192EC
		private void OnSequencePlayEvent(string seqName, string eventName)
		{
			if (!(eventName == "Max"))
			{
				if (eventName == "LevelChange")
				{
					UUIText text = base.GetText(0);
					if (text == null)
					{
						return;
					}
					text.SetText(this.CurLevel.ToString(), true);
				}
				return;
			}
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Spring26_Atmosphere_Max");
		}

		// Token: 0x0603E7F0 RID: 255984 RVA: 0x00F1B147 File Offset: 0x00F19347
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603E7F1 RID: 255985 RVA: 0x00F1B165 File Offset: 0x00F19365
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603E7F2 RID: 255986 RVA: 0x00F1B183 File Offset: 0x00F19383
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "TipsChange")
			{
				this.SetExpMaxText();
			}
		}

		// Token: 0x0603E7F3 RID: 255987 RVA: 0x00F1B198 File Offset: 0x00F19398
		protected override void OnBeforeShow()
		{
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Refresh), 20f, 1f, null, null, true);
			this.RefreshBar(0f, 1f);
			this.SetLevelText(this.PreLevel);
			this.SetExpText(this.CurAtmosphere, this.CurMaxAtmosphere);
			ETipsType tipsType = this.TipsType;
			if (tipsType != ETipsType.ExpAdd)
			{
				if (tipsType == ETipsType.LevelUp)
				{
					this.RefreshBar((float)(this.PreAtmosphere - this.PreNeed), (float)this.PreNext);
					return;
				}
			}
			else
			{
				this.RefreshBar((float)(this.PreAtmosphere - this.PreNeed), (float)this.PreNext);
			}
		}

		// Token: 0x0603E7F4 RID: 255988 RVA: 0x00F1B244 File Offset: 0x00F19444
		protected override void OnAfterShow()
		{
			ETipsType tipsType = this.TipsType;
			if (tipsType != ETipsType.ExpAdd)
			{
				if (tipsType == ETipsType.LevelUp)
				{
					this.RunLevelUp();
					return;
				}
			}
			else
			{
				this.RunExpAdd();
			}
		}

		// Token: 0x0603E7F5 RID: 255989 RVA: 0x00F1B26E File Offset: 0x00F1946E
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
		}

		// Token: 0x0603E7F6 RID: 255990 RVA: 0x00F1B278 File Offset: 0x00F19478
		private UniTask RunExpAdd()
		{
			SpringManorAtmosphereLevelUpView.<RunExpAdd>d__21 <RunExpAdd>d__;
			<RunExpAdd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunExpAdd>d__.<>4__this = this;
			<RunExpAdd>d__.<>1__state = -1;
			<RunExpAdd>d__.<>t__builder.Start<SpringManorAtmosphereLevelUpView.<RunExpAdd>d__21>(ref <RunExpAdd>d__);
			return <RunExpAdd>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7F7 RID: 255991 RVA: 0x00F1B2BC File Offset: 0x00F194BC
		private UniTask RunLevelUp()
		{
			SpringManorAtmosphereLevelUpView.<RunLevelUp>d__22 <RunLevelUp>d__;
			<RunLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunLevelUp>d__.<>4__this = this;
			<RunLevelUp>d__.<>1__state = -1;
			<RunLevelUp>d__.<>t__builder.Start<SpringManorAtmosphereLevelUpView.<RunLevelUp>d__22>(ref <RunLevelUp>d__);
			return <RunLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7F8 RID: 255992 RVA: 0x00F1B300 File Offset: 0x00F19500
		protected void Refresh(float delta)
		{
			if (!this.RunBarAnim)
			{
				return;
			}
			this.RunBarAnimTime += delta;
			float current = MathUtils.Instance.Lerp((float)this.StartValue, (float)this.TargetValue, this.RunBarAnimTime / 750f);
			this.RefreshBar(current, (float)this.EndValue);
			if (this.RunBarAnimTime >= 750f)
			{
				this.EndBarAnim();
			}
		}

		// Token: 0x0603E7F9 RID: 255993 RVA: 0x00F1B36C File Offset: 0x00F1956C
		private UniTask StartBarAnim(int current, int target, int end)
		{
			SpringManorAtmosphereLevelUpView.<StartBarAnim>d__31 <StartBarAnim>d__;
			<StartBarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartBarAnim>d__.<>4__this = this;
			<StartBarAnim>d__.current = current;
			<StartBarAnim>d__.target = target;
			<StartBarAnim>d__.end = end;
			<StartBarAnim>d__.<>1__state = -1;
			<StartBarAnim>d__.<>t__builder.Start<SpringManorAtmosphereLevelUpView.<StartBarAnim>d__31>(ref <StartBarAnim>d__);
			return <StartBarAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7FA RID: 255994 RVA: 0x00F1B3C8 File Offset: 0x00F195C8
		private void EndBarAnim()
		{
			this.RunBarAnim = false;
			this.BarAnimPromise.SetResult(default(UniTaskVoid));
		}

		// Token: 0x0603E7FB RID: 255995 RVA: 0x00F1B3F0 File Offset: 0x00F195F0
		private void RemoveTick()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x0603E7FC RID: 255996 RVA: 0x00F1B414 File Offset: 0x00F19614
		private void RefreshBar(float current, float target)
		{
			float fillAmount = MathUtils.Instance.Clamp(current / target, 0f, 1f);
			base.GetSprite(1).SetFillAmount(fillAmount);
		}

		// Token: 0x0603E7FD RID: 255997 RVA: 0x00F1B446 File Offset: 0x00F19646
		private void SetExpTextVisible(bool bVisible)
		{
			base.GetText(2).SetUIActive(bVisible);
		}

		// Token: 0x0603E7FE RID: 255998 RVA: 0x00F1B458 File Offset: 0x00F19658
		private void SetExpText(int current, int currentMax)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentMax);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603E7FF RID: 255999 RVA: 0x00F1B4A3 File Offset: 0x00F196A3
		private void SetExpMaxText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MapTravelLevelCanUp_Text", Array.Empty<object>());
			this.SetExpTextVisible(true);
		}

		// Token: 0x0603E800 RID: 256000 RVA: 0x00F1B4C7 File Offset: 0x00F196C7
		private void SetLevelText(int level)
		{
			base.GetText(0).SetText(level.ToString(), true);
		}

		// Token: 0x04020B48 RID: 133960
		private const int BAR_ANIM_TIME = 750;

		// Token: 0x04020B49 RID: 133961
		private ETipsType TipsType;

		// Token: 0x04020B4A RID: 133962
		private int PreLevel;

		// Token: 0x04020B4B RID: 133963
		private int PreAtmosphere;

		// Token: 0x04020B4C RID: 133964
		private int CurLevel;

		// Token: 0x04020B4D RID: 133965
		private int CurAtmosphere;

		// Token: 0x04020B4E RID: 133966
		private int CurMaxAtmosphere;

		// Token: 0x04020B4F RID: 133967
		private int PreNeed;

		// Token: 0x04020B50 RID: 133968
		private int PreNext;

		// Token: 0x04020B51 RID: 133969
		private int CurNeed;

		// Token: 0x04020B52 RID: 133970
		private int CurNext;

		// Token: 0x04020B53 RID: 133971
		[Nullable(2)]
		protected TimerHandle TickHandle;

		// Token: 0x04020B54 RID: 133972
		protected bool RunBarAnim;

		// Token: 0x04020B55 RID: 133973
		protected float RunBarAnimTime;

		// Token: 0x04020B56 RID: 133974
		protected int StartValue;

		// Token: 0x04020B57 RID: 133975
		protected int TargetValue;

		// Token: 0x04020B58 RID: 133976
		protected int EndValue;

		// Token: 0x04020B59 RID: 133977
		protected CustomPromise<UniTaskVoid> BarAnimPromise = new CustomPromise<UniTaskVoid>();
	}
}
