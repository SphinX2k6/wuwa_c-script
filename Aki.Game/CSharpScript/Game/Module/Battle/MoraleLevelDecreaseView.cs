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
	// Token: 0x02005C52 RID: 23634
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleLevelDecreaseView : UiTickViewBase
	{
		// Token: 0x0603BBCC RID: 244684 RVA: 0x00E44614 File Offset: 0x00E42814
		public MoraleLevelDecreaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BBCD RID: 244685 RVA: 0x00E44640 File Offset: 0x00E42840
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

		// Token: 0x0603BBCE RID: 244686 RVA: 0x00E44688 File Offset: 0x00E42888
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

		// Token: 0x0603BBCF RID: 244687 RVA: 0x00E4470D File Offset: 0x00E4290D
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603BBD0 RID: 244688 RVA: 0x00E44710 File Offset: 0x00E42910
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

		// Token: 0x0603BBD1 RID: 244689 RVA: 0x00E44780 File Offset: 0x00E42980
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

		// Token: 0x0603BBD2 RID: 244690 RVA: 0x00E447E8 File Offset: 0x00E429E8
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

		// Token: 0x0603BBD3 RID: 244691 RVA: 0x00E44897 File Offset: 0x00E42A97
		private void OnStartAnimEnd(string s)
		{
			if (this.AnimSpeed < 0f)
			{
				this.IsEnableTick = true;
				return;
			}
			this.TryCloseMe();
		}

		// Token: 0x0603BBD4 RID: 244692 RVA: 0x00E448B4 File Offset: 0x00E42AB4
		private void OnCloseAnimEnd(string s)
		{
			if (this.IsLevelAnimFinished && MoraleBattleModel.Instance.GetMoraleIndomitableLevel() > 1)
			{
				UiManager.Instance.OpenView(EUiViewName.MoraleIndomitableLevelView, null, null);
			}
		}

		// Token: 0x0603BBD5 RID: 244693 RVA: 0x00E448DC File Offset: 0x00E42ADC
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x0603BBD6 RID: 244694 RVA: 0x00E448E4 File Offset: 0x00E42AE4
		private void TryCloseMe()
		{
			this.IsEnableTick = false;
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0401F1A0 RID: 127392
		private const float LEVEL_ANIM_DURATION = 500f;

		// Token: 0x0401F1A1 RID: 127393
		private const float LEVEL_ANIM_EXPIRED_TIME = 5000f;

		// Token: 0x0401F1A2 RID: 127394
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[MoraleLevelDecreaseView]OnTick", "", "");

		// Token: 0x0401F1A3 RID: 127395
		[Nullable(2)]
		private UUIArtText LevelText;

		// Token: 0x0401F1A4 RID: 127396
		private int StartLevel = 1;

		// Token: 0x0401F1A5 RID: 127397
		private int EndLevel = 1;

		// Token: 0x0401F1A6 RID: 127398
		private int CurrentLevel = 1;

		// Token: 0x0401F1A7 RID: 127399
		private float ProgressLevel = 1f;

		// Token: 0x0401F1A8 RID: 127400
		private float AnimSpeed;

		// Token: 0x0401F1A9 RID: 127401
		private bool IsEnableTick;

		// Token: 0x0401F1AA RID: 127402
		private bool IsLevelAnimFinished;

		// Token: 0x0401F1AB RID: 127403
		private float PassTime;

		// Token: 0x0200BE62 RID: 48738
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040396A0 RID: 235168
			LevelText
		}
	}
}
