using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C18 RID: 19480
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeOccupiedSuccessView : UiViewBase
	{
		// Token: 0x060309A5 RID: 199077 RVA: 0x00D8BFD2 File Offset: 0x00D8A1D2
		[NullableContext(1)]
		public FlagChallengeOccupiedSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x060309A6 RID: 199078 RVA: 0x00D8BFDB File Offset: 0x00D8A1DB
		public new FlagChallengeOccupiedSuccessViewParams OpenParam
		{
			get
			{
				return this.OpenParam as FlagChallengeOccupiedSuccessViewParams;
			}
		}

		// Token: 0x060309A7 RID: 199079 RVA: 0x00D8BFE8 File Offset: 0x00D8A1E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060309A8 RID: 199080 RVA: 0x00D8C074 File Offset: 0x00D8A274
		protected override void OnStart()
		{
			int activityId = this.OpenParam.ActivityId;
			this.LevelText = base.GetArtText(0);
			if (this.LevelText != null)
			{
				(this.LevelText.GetOwner() as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
				int preCalculatedLevel = FlagChallengeBattleModel.Instance.GetPreCalculatedLevel();
				this.LevelText.SetText(preCalculatedLevel.ToString());
			}
			int strongholdId = this.OpenParam.StrongholdId;
			FlagChallengeStrongholdData strongholdData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId).GetStrongholdData(strongholdId);
			base.GetItem(2).SetUIActive(strongholdData.IsBossStronghold());
		}

		// Token: 0x060309A9 RID: 199081 RVA: 0x00D8C115 File Offset: 0x00D8A315
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060309AA RID: 199082 RVA: 0x00D8C117 File Offset: 0x00D8A317
		protected override void OnAfterShow()
		{
			UUIArtText levelText = this.LevelText;
			AUIBaseActor auibaseActor = ((levelText != null) ? levelText.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnSequencePlayEvent.Unbind();
			}
			this.DelayClose();
		}

		// Token: 0x060309AB RID: 199083 RVA: 0x00D8C146 File Offset: 0x00D8A346
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
			this.ClearRollingTimer();
		}

		// Token: 0x060309AC RID: 199084 RVA: 0x00D8C154 File Offset: 0x00D8A354
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x060309AD RID: 199085 RVA: 0x00D8C172 File Offset: 0x00D8A372
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x060309AE RID: 199086 RVA: 0x00D8C190 File Offset: 0x00D8A390
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x060309AF RID: 199087 RVA: 0x00D8C198 File Offset: 0x00D8A398
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060309B0 RID: 199088 RVA: 0x00D8C1A9 File Offset: 0x00D8A3A9
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x060309B1 RID: 199089 RVA: 0x00D8C1DA File Offset: 0x00D8A3DA
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x060309B2 RID: 199090 RVA: 0x00D8C1FC File Offset: 0x00D8A3FC
		private void ClearRollingTimer()
		{
			if (this.RollingTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RollingTimer);
				this.RollingTimer = null;
			}
		}

		// Token: 0x060309B3 RID: 199091 RVA: 0x00D8C21E File Offset: 0x00D8A41E
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Level_Switch")
			{
				this.PlayLevelRolling();
			}
		}

		// Token: 0x060309B4 RID: 199092 RVA: 0x00D8C234 File Offset: 0x00D8A434
		private void PlayLevelRolling()
		{
			float elapsedTime = 0f;
			int startValue = FlagChallengeBattleModel.Instance.GetPreCalculatedLevel();
			int targetValue = FlagChallengeBattleModel.Instance.GetCalculatedLevel();
			this.RollingTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
			{
				elapsedTime += delta;
				if (elapsedTime >= 500f)
				{
					this.ClearRollingTimer();
					UUIArtText levelText = this.LevelText;
					if (levelText == null)
					{
						return;
					}
					levelText.SetText(targetValue.ToString());
					return;
				}
				else
				{
					float num = MathF.Min(elapsedTime / 500f, 1f);
					num = 1f - MathF.Pow(1f - num, 3f);
					float x = MathUtils.Instance.Lerp((float)startValue, (float)targetValue, num);
					UUIArtText levelText2 = this.LevelText;
					if (levelText2 == null)
					{
						return;
					}
					levelText2.SetText(MathF.Round(x).ToString(CultureInfo.InvariantCulture));
					return;
				}
			}, 20f, 1f, null, null, true);
		}

		// Token: 0x04019B89 RID: 105353
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x04019B8A RID: 105354
		private const float ROLLING_DURATION = 500f;

		// Token: 0x04019B8B RID: 105355
		private UUIArtText LevelText;

		// Token: 0x04019B8C RID: 105356
		private TimerHandle DelayTimer;

		// Token: 0x04019B8D RID: 105357
		private TimerHandle RollingTimer;

		// Token: 0x0200A833 RID: 43059
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033F4E RID: 212814
			LevelText,
			// Token: 0x04033F4F RID: 212815
			TitleText,
			// Token: 0x04033F50 RID: 212816
			ClearTipsItem
		}
	}
}
