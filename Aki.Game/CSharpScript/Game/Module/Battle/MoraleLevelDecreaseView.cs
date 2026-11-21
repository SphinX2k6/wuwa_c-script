using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C32 RID: 19506
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleLevelDecreaseView : UiTickViewBase
	{
		// Token: 0x06030B17 RID: 199447 RVA: 0x00D949E0 File Offset: 0x00D92BE0
		public MoraleLevelDecreaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030B18 RID: 199448 RVA: 0x00D94A0C File Offset: 0x00D92C0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030B19 RID: 199449 RVA: 0x00D94A54 File Offset: 0x00D92C54
		protected override void OnStart()
		{
			this.LevelText = base.GetArtText(0);
			this.StartLevel = MoraleBattleModel.Instance.GetLastMoraleLevel();
			this.EndLevel = 1;
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				levelText.SetText(this.StartLevel.ToString());
			}
			this.CurrentLevel = this.StartLevel;
			this.ProgressLevel = (float)this.CurrentLevel;
			int num = this.EndLevel - this.StartLevel;
			if (num != 0)
			{
				this.AnimSpeed = (float)num / 500f;
			}
		}

		// Token: 0x06030B1A RID: 199450 RVA: 0x00D94AD9 File Offset: 0x00D92CD9
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06030B1B RID: 199451 RVA: 0x00D94ADC File Offset: 0x00D92CDC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartAnimEnd), false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.AddSequenceFinishEvent("Close", new Action<string>(this.OnCloseAnimEnd), false);
		}

		// Token: 0x06030B1C RID: 199452 RVA: 0x00D94B4C File Offset: 0x00D92D4C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			this.UiViewSequence.RemoveSequenceFinishEvent("Start", new Action<string>(this.OnStartAnimEnd));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.RemoveSequenceFinishEvent("Close", new Action<string>(this.OnCloseAnimEnd));
		}

		// Token: 0x06030B1D RID: 199453 RVA: 0x00D94BB4 File Offset: 0x00D92DB4
		protected override void OnTick(float delta)
		{
			if (!this.IsEnableTick)
			{
				return;
			}
			float num = delta * this.AnimSpeed;
			this.PassTime += delta;
			this.ProgressLevel += num;
			this.CurrentLevel = Math.Max(this.EndLevel, (int)Math.Round((double)this.ProgressLevel));
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				levelText.SetText(this.CurrentLevel.ToString());
			}
			if (this.CurrentLevel == this.EndLevel || this.PassTime > 5000f)
			{
				this.AnimSpeed = 0f;
				this.IsEnableTick = false;
				this.IsLevelAnimFinished = true;
				this.TryCloseMe();
			}
		}

		// Token: 0x06030B1E RID: 199454 RVA: 0x00D94C63 File Offset: 0x00D92E63
		private void OnStartAnimEnd(string s)
		{
			if (this.AnimSpeed < 0f)
			{
				this.IsEnableTick = true;
				return;
			}
			this.TryCloseMe();
		}

		// Token: 0x06030B1F RID: 199455 RVA: 0x00D94C80 File Offset: 0x00D92E80
		private void OnCloseAnimEnd(string s)
		{
			if (this.IsLevelAnimFinished && MoraleBattleModel.Instance.GetMoraleIndomitableLevel() > 1)
			{
				UiManager.Instance.OpenView(EUiViewName.MoraleIndomitableLevelView, null, null);
			}
		}

		// Token: 0x06030B20 RID: 199456 RVA: 0x00D94CA8 File Offset: 0x00D92EA8
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x06030B21 RID: 199457 RVA: 0x00D94CB0 File Offset: 0x00D92EB0
		private void TryCloseMe()
		{
			this.IsEnableTick = false;
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x04019C51 RID: 105553
		private const float LEVEL_ANIM_DURATION = 500f;

		// Token: 0x04019C52 RID: 105554
		private const float LEVEL_ANIM_EXPIRED_TIME = 5000f;

		// Token: 0x04019C53 RID: 105555
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[MoraleLevelDecreaseView]OnTick", "", "");

		// Token: 0x04019C54 RID: 105556
		[Nullable(2)]
		private UUIArtText LevelText;

		// Token: 0x04019C55 RID: 105557
		private int StartLevel = 1;

		// Token: 0x04019C56 RID: 105558
		private int EndLevel = 1;

		// Token: 0x04019C57 RID: 105559
		private int CurrentLevel = 1;

		// Token: 0x04019C58 RID: 105560
		private float ProgressLevel = 1f;

		// Token: 0x04019C59 RID: 105561
		private float AnimSpeed;

		// Token: 0x04019C5A RID: 105562
		private bool IsEnableTick;

		// Token: 0x04019C5B RID: 105563
		private bool IsLevelAnimFinished;

		// Token: 0x04019C5C RID: 105564
		private float PassTime;

		// Token: 0x0200A868 RID: 43112
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034061 RID: 213089
			LevelText
		}
	}
}
