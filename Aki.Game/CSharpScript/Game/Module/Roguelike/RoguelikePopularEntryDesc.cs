using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DDC RID: 19932
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikePopularEntryDesc : GridProxyAbstract<int>
	{
		// Token: 0x06033729 RID: 210729 RVA: 0x00C051A4 File Offset: 0x00C033A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISizeControlByOther));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603372A RID: 210730 RVA: 0x00C0520D File Offset: 0x00C0340D
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.DelegateTweener = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenerUpdate));
		}

		// Token: 0x0603372B RID: 210731 RVA: 0x00C05237 File Offset: 0x00C03437
		protected override void OnBeforeDestroy()
		{
			this.KillTweener();
			this.KillDelayTimer();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenerUpdate));
		}

		// Token: 0x0603372C RID: 210732 RVA: 0x00C05256 File Offset: 0x00C03456
		private void TweenerUpdate(float value)
		{
			this.SetProgress(MathUtils.Instance.Clamp(value, 0f, 1f), this.ShowState);
		}

		// Token: 0x0603372D RID: 210733 RVA: 0x00C0527C File Offset: 0x00C0347C
		private void SetProgress(float progress, bool isShow)
		{
			float height = this.DefaultHeight * (isShow ? progress : (1f - progress));
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetHeight(height);
		}

		// Token: 0x0603372E RID: 210734 RVA: 0x00C052B0 File Offset: 0x00C034B0
		private void StartTween()
		{
			base.GetUiSizeControlByOther(0).SetEnable(false);
			this.KillTweener();
			this.HeightTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateTweener, 0f, 1f, this.TweenMaxTime, 0f, LTweenEase.OutCubic);
			if (this.HeightTweener != null)
			{
				this.HeightTweener.SetEase(LTweenEase.OutExpo);
				this.HeightTweener.OnCompleteCallBack.Bind(new Action(this.OnTweenerEnd));
			}
			this.IsTween = true;
		}

		// Token: 0x0603372F RID: 210735 RVA: 0x00C05338 File Offset: 0x00C03538
		private void OnTweenerEnd()
		{
			if (this.IsTween)
			{
				this.EndTween();
				if (this.ShowState)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
				}
			}
		}

		// Token: 0x06033730 RID: 210736 RVA: 0x00C0537C File Offset: 0x00C0357C
		private void EndTween()
		{
			this.IsTween = false;
			this.RootItem.SetAlpha(1f);
			this.SetProgress(1f, this.ShowState);
			base.GetUiSizeControlByOther(0).SetEnable(true);
			base.SetUiActive(this.ShowState);
		}

		// Token: 0x06033731 RID: 210737 RVA: 0x00C053CA File Offset: 0x00C035CA
		private void KillTweener()
		{
			if (this.HeightTweener != null)
			{
				this.HeightTweener.Kill(false);
				this.HeightTweener = null;
			}
		}

		// Token: 0x06033732 RID: 210738 RVA: 0x00C053E8 File Offset: 0x00C035E8
		public override void Refresh(int overviewId, bool isSelected, int gridIndex)
		{
			this.OverviewId = overviewId;
			RoguelikeEntranceViewModel entranceViewModel = RoguelikeModel.Instance.GetEntranceViewModel();
			this.ShowState = entranceViewModel.GetOverviewIdActiveState(this.OverviewId);
			this.Update(false);
			base.SetUiActive(this.ShowState);
		}

		// Token: 0x06033733 RID: 210739 RVA: 0x00C0542C File Offset: 0x00C0362C
		private void Update(bool withAnim)
		{
			RoguelikeEntranceViewModel entranceViewModel = RoguelikeModel.Instance.GetEntranceViewModel();
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueHotEntryOverview? rogueHotEntryOverview = (instance != null) ? instance.GetRogueHotEntryOverviewConfig(this.OverviewId) : null;
			if (rogueHotEntryOverview == null)
			{
				return;
			}
			string text = "";
			int type = rogueHotEntryOverview.Value.Type;
			if (type == 1)
			{
				text = ((rogueHotEntryOverview.Value.DescLength > 0) ? rogueHotEntryOverview.Value.Desc(0) : "");
			}
			else if (type == 2)
			{
				int entriesOverviewIdCount = entranceViewModel.GetEntriesOverviewIdCount(this.OverviewId);
				text = ((rogueHotEntryOverview.Value.DescLength > entriesOverviewIdCount - 1) ? rogueHotEntryOverview.Value.Desc(Math.Max(0, entriesOverviewIdCount - 1)) : "");
			}
			List<string> list = new List<string>();
			List<int> entriesOverviewIdParam = entranceViewModel.GetEntriesOverviewIdParam(this.OverviewId);
			bool[] array = rogueHotEntryOverview.Value.ParamShowPercent();
			for (int i = 0; i < entriesOverviewIdParam.Count; i++)
			{
				float num = (float)entriesOverviewIdParam[i] / 10000f;
				if (array.Length <= i || array[i])
				{
					list.Add((num * 100f).ToString());
				}
				else
				{
					list.Add(num.ToString());
				}
			}
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			string text2 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(text, null), list.ToArray());
			if (text2 == this.CacheDescText)
			{
				return;
			}
			this.CacheDescText = text2;
			base.GetText(1).SetText(text2, true);
			if (withAnim)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
				}
			}
			this.DefaultHeight = base.GetRootItem().GetHeight();
		}

		// Token: 0x06033734 RID: 210740 RVA: 0x00C05608 File Offset: 0x00C03808
		private void ChangeState(bool showState, bool tween)
		{
			this.ShowState = showState;
			if (showState)
			{
				this.Update(false);
				if (!tween)
				{
					base.SetUiActive(true);
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
					return;
				}
				else
				{
					this.RootItem.SetAlpha(0f);
					base.SetUiActive(true);
				}
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayOrReplaySequenceByName("Close", false, null);
				}
			}
			this.StartTween();
		}

		// Token: 0x06033735 RID: 210741 RVA: 0x00C0568F File Offset: 0x00C0388F
		private void UpdateState(bool tween)
		{
			if (!tween)
			{
				this.Update(true);
				return;
			}
			this.DelayTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				if (this.ShowState)
				{
					this.Update(true);
				}
			}, this.TweenMaxTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x06033736 RID: 210742 RVA: 0x00C056CC File Offset: 0x00C038CC
		private void KillDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimerHandle);
				this.DelayTimerHandle = null;
			}
		}

		// Token: 0x06033737 RID: 210743 RVA: 0x00C056F8 File Offset: 0x00C038F8
		public void RefreshState(bool state, bool delayEmit)
		{
			if (state != this.ShowState)
			{
				this.ChangeState(state, delayEmit);
				return;
			}
			if (state)
			{
				this.UpdateState(delayEmit);
			}
		}

		// Token: 0x06033738 RID: 210744 RVA: 0x00C05716 File Offset: 0x00C03916
		public void Reset()
		{
			this.OnTweenerEnd();
			this.KillDelayTimer();
		}

		// Token: 0x0401B4FD RID: 111869
		public int OverviewId;

		// Token: 0x0401B4FE RID: 111870
		[Nullable(1)]
		private string CacheDescText = "";

		// Token: 0x0401B4FF RID: 111871
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B500 RID: 111872
		private ULTweener HeightTweener;

		// Token: 0x0401B501 RID: 111873
		[Nullable(1)]
		private FLTweenFloatSetterDynamic DelegateTweener;

		// Token: 0x0401B502 RID: 111874
		public bool ShowState = true;

		// Token: 0x0401B503 RID: 111875
		private bool IsTween;

		// Token: 0x0401B504 RID: 111876
		private readonly float TweenMaxTime = ConfigCommonParamById.GetFloatConfig("RoguelikeEntryDescTweenTime").GetValueOrDefault(0.1f);

		// Token: 0x0401B505 RID: 111877
		private float DefaultHeight;

		// Token: 0x0401B506 RID: 111878
		private TimerHandle DelayTimerHandle;

		// Token: 0x0200AF61 RID: 44897
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035415 RID: 218133
			public const int ItemSelf = 0;

			// Token: 0x04035416 RID: 218134
			public const int TxtDesc = 1;
		}
	}
}
