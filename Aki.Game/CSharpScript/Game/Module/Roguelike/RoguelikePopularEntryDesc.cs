using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DA5 RID: 15781
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikePopularEntryDesc : GridProxyAbstract<int>
	{
		// Token: 0x06028594 RID: 165268 RVA: 0x00B4E6B4 File Offset: 0x00B4C8B4
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

		// Token: 0x06028595 RID: 165269 RVA: 0x00B4E71D File Offset: 0x00B4C91D
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.DelegateTweener = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenerUpdate));
		}

		// Token: 0x06028596 RID: 165270 RVA: 0x00B4E747 File Offset: 0x00B4C947
		protected override void OnBeforeDestroy()
		{
			this.KillTweener();
			this.KillDelayTimer();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenerUpdate));
		}

		// Token: 0x06028597 RID: 165271 RVA: 0x00B4E766 File Offset: 0x00B4C966
		private void TweenerUpdate(float value)
		{
			this.SetProgress(MathUtils.Instance.Clamp(value, 0f, 1f), this.ShowState);
		}

		// Token: 0x06028598 RID: 165272 RVA: 0x00B4E78C File Offset: 0x00B4C98C
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

		// Token: 0x06028599 RID: 165273 RVA: 0x00B4E7C0 File Offset: 0x00B4C9C0
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

		// Token: 0x0602859A RID: 165274 RVA: 0x00B4E848 File Offset: 0x00B4CA48
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

		// Token: 0x0602859B RID: 165275 RVA: 0x00B4E88C File Offset: 0x00B4CA8C
		private void EndTween()
		{
			this.IsTween = false;
			this.RootItem.SetAlpha(1f);
			this.SetProgress(1f, this.ShowState);
			base.GetUiSizeControlByOther(0).SetEnable(true);
			base.SetUiActive(this.ShowState);
		}

		// Token: 0x0602859C RID: 165276 RVA: 0x00B4E8DA File Offset: 0x00B4CADA
		private void KillTweener()
		{
			if (this.HeightTweener != null)
			{
				this.HeightTweener.Kill(false);
				this.HeightTweener = null;
			}
		}

		// Token: 0x0602859D RID: 165277 RVA: 0x00B4E8F8 File Offset: 0x00B4CAF8
		public override void Refresh(int overviewId, bool isSelected, int gridIndex)
		{
			this.OverviewId = overviewId;
			RoguelikeEntranceViewModel entranceViewModel = RoguelikeModel.Instance.GetEntranceViewModel();
			this.ShowState = entranceViewModel.GetOverviewIdActiveState(this.OverviewId);
			this.Update(false);
			base.SetUiActive(this.ShowState);
		}

		// Token: 0x0602859E RID: 165278 RVA: 0x00B4E93C File Offset: 0x00B4CB3C
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

		// Token: 0x0602859F RID: 165279 RVA: 0x00B4EB18 File Offset: 0x00B4CD18
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

		// Token: 0x060285A0 RID: 165280 RVA: 0x00B4EB9F File Offset: 0x00B4CD9F
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

		// Token: 0x060285A1 RID: 165281 RVA: 0x00B4EBDC File Offset: 0x00B4CDDC
		private void KillDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimerHandle);
				this.DelayTimerHandle = null;
			}
		}

		// Token: 0x060285A2 RID: 165282 RVA: 0x00B4EC08 File Offset: 0x00B4CE08
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

		// Token: 0x060285A3 RID: 165283 RVA: 0x00B4EC26 File Offset: 0x00B4CE26
		public void Reset()
		{
			this.OnTweenerEnd();
			this.KillDelayTimer();
		}

		// Token: 0x04015ED0 RID: 89808
		public int OverviewId;

		// Token: 0x04015ED1 RID: 89809
		[Nullable(1)]
		private string CacheDescText = "";

		// Token: 0x04015ED2 RID: 89810
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015ED3 RID: 89811
		private ULTweener HeightTweener;

		// Token: 0x04015ED4 RID: 89812
		[Nullable(1)]
		private FLTweenFloatSetterDynamic DelegateTweener;

		// Token: 0x04015ED5 RID: 89813
		public bool ShowState = true;

		// Token: 0x04015ED6 RID: 89814
		private bool IsTween;

		// Token: 0x04015ED7 RID: 89815
		private readonly float TweenMaxTime = ConfigCommonParamById.GetFloatConfig("RoguelikeEntryDescTweenTime").GetValueOrDefault(0.1f);

		// Token: 0x04015ED8 RID: 89816
		private float DefaultHeight;

		// Token: 0x04015ED9 RID: 89817
		private TimerHandle DelayTimerHandle;

		// Token: 0x02009996 RID: 39318
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402FE48 RID: 196168
			public const int ItemSelf = 0;

			// Token: 0x0402FE49 RID: 196169
			public const int TxtDesc = 1;
		}
	}
}
