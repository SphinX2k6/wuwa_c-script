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
	// Token: 0x02005C38 RID: 23608
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeOccupiedSuccessView : UiViewBase
	{
		// Token: 0x0603BA5A RID: 244314 RVA: 0x00E3BC62 File Offset: 0x00E39E62
		[NullableContext(1)]
		public FlagChallengeOccupiedSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008DB5 RID: 36277
		// (get) Token: 0x0603BA5B RID: 244315 RVA: 0x00E3BC6B File Offset: 0x00E39E6B
		public new FlagChallengeOccupiedSuccessViewParams OpenParam
		{
			get
			{
				return this.OpenParam as FlagChallengeOccupiedSuccessViewParams;
			}
		}

		// Token: 0x0603BA5C RID: 244316 RVA: 0x00E3BC78 File Offset: 0x00E39E78
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

		// Token: 0x0603BA5D RID: 244317 RVA: 0x00E3BD04 File Offset: 0x00E39F04
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

		// Token: 0x0603BA5E RID: 244318 RVA: 0x00E3BDA5 File Offset: 0x00E39FA5
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603BA5F RID: 244319 RVA: 0x00E3BDA7 File Offset: 0x00E39FA7
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

		// Token: 0x0603BA60 RID: 244320 RVA: 0x00E3BDD6 File Offset: 0x00E39FD6
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
			this.ClearRollingTimer();
		}

		// Token: 0x0603BA61 RID: 244321 RVA: 0x00E3BDE4 File Offset: 0x00E39FE4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BA62 RID: 244322 RVA: 0x00E3BE02 File Offset: 0x00E3A002
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BA63 RID: 244323 RVA: 0x00E3BE20 File Offset: 0x00E3A020
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x0603BA64 RID: 244324 RVA: 0x00E3BE28 File Offset: 0x00E3A028
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603BA65 RID: 244325 RVA: 0x00E3BE39 File Offset: 0x00E3A039
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0603BA66 RID: 244326 RVA: 0x00E3BE6A File Offset: 0x00E3A06A
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x0603BA67 RID: 244327 RVA: 0x00E3BE8C File Offset: 0x00E3A08C
		private void ClearRollingTimer()
		{
			if (this.RollingTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RollingTimer);
				this.RollingTimer = null;
			}
		}

		// Token: 0x0603BA68 RID: 244328 RVA: 0x00E3BEAE File Offset: 0x00E3A0AE
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Level_Switch")
			{
				this.PlayLevelRolling();
			}
		}

		// Token: 0x0603BA69 RID: 244329 RVA: 0x00E3BEC4 File Offset: 0x00E3A0C4
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

		// Token: 0x0401F0D8 RID: 127192
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x0401F0D9 RID: 127193
		private const float ROLLING_DURATION = 500f;

		// Token: 0x0401F0DA RID: 127194
		private UUIArtText LevelText;

		// Token: 0x0401F0DB RID: 127195
		private TimerHandle DelayTimer;

		// Token: 0x0401F0DC RID: 127196
		private TimerHandle RollingTimer;

		// Token: 0x0200BE2B RID: 48683
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0403958B RID: 234891
			LevelText,
			// Token: 0x0403958C RID: 234892
			TitleText,
			// Token: 0x0403958D RID: 234893
			ClearTipsItem
		}
	}
}
