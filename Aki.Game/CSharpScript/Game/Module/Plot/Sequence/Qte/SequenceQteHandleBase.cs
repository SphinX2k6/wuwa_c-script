using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005023 RID: 20515
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceQteHandleBase<[Nullable(0)] T> : ISequenceCommonQteHandle where T : CommonQteContextBase
	{
		// Token: 0x060347F8 RID: 215032 RVA: 0x00C5DAC8 File Offset: 0x00C5BCC8
		public SequenceQteHandleBase(SequenceQteManager qteManager, T context)
		{
			this.QteManager = qteManager;
			this.Context = context;
			this.Context.SuccessCallback = new TCommonQteCallback(this.OnQteSucceed);
			this.Context.FailCallback = new TCommonQteCallback(this.OnQteFailed);
		}

		// Token: 0x17008018 RID: 32792
		// (get) Token: 0x060347F9 RID: 215033 RVA: 0x00C5DB87 File Offset: 0x00C5BD87
		// (set) Token: 0x060347FA RID: 215034 RVA: 0x00C5DB8F File Offset: 0x00C5BD8F
		public int SubtitleId { get; set; } = -1;

		// Token: 0x17008019 RID: 32793
		// (get) Token: 0x060347FB RID: 215035 RVA: 0x00C5DB98 File Offset: 0x00C5BD98
		// (set) Token: 0x060347FC RID: 215036 RVA: 0x00C5DBA0 File Offset: 0x00C5BDA0
		public int OptionIndex { get; set; } = -1;

		// Token: 0x1700801A RID: 32794
		// (get) Token: 0x060347FD RID: 215037 RVA: 0x00C5DBA9 File Offset: 0x00C5BDA9
		// (set) Token: 0x060347FE RID: 215038 RVA: 0x00C5DBB1 File Offset: 0x00C5BDB1
		public bool IsProgressQte { get; set; }

		// Token: 0x1700801B RID: 32795
		// (get) Token: 0x060347FF RID: 215039 RVA: 0x00C5DBBA File Offset: 0x00C5BDBA
		// (set) Token: 0x06034800 RID: 215040 RVA: 0x00C5DBC2 File Offset: 0x00C5BDC2
		[Nullable(2)]
		public FFrameTime SequenceQteStartRange { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700801C RID: 32796
		// (get) Token: 0x06034801 RID: 215041 RVA: 0x00C5DBCB File Offset: 0x00C5BDCB
		// (set) Token: 0x06034802 RID: 215042 RVA: 0x00C5DBD3 File Offset: 0x00C5BDD3
		[Nullable(2)]
		public FFrameTime SequenceQteEndRange { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700801D RID: 32797
		// (get) Token: 0x06034803 RID: 215043 RVA: 0x00C5DBDC File Offset: 0x00C5BDDC
		// (set) Token: 0x06034804 RID: 215044 RVA: 0x00C5DBE4 File Offset: 0x00C5BDE4
		public bool IsUpdateWithProgress { get; set; }

		// Token: 0x1700801E RID: 32798
		// (get) Token: 0x06034805 RID: 215045 RVA: 0x00C5DBED File Offset: 0x00C5BDED
		// (set) Token: 0x06034806 RID: 215046 RVA: 0x00C5DBF5 File Offset: 0x00C5BDF5
		[Nullable(2)]
		public QteSpineInfoProxy SpineInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06034807 RID: 215047 RVA: 0x00C5DC00 File Offset: 0x00C5BE00
		public void SetEventSpineComponents(List<USpineSkeletonAnimationComponent> components)
		{
			this.EventSpineComponents.Clear();
			foreach (USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent in components)
			{
				if (ObjectUtils.IsValid(uspineSkeletonAnimationComponent))
				{
					this.EventSpineComponents.Add(uspineSkeletonAnimationComponent);
				}
			}
		}

		// Token: 0x06034808 RID: 215048 RVA: 0x00C5DC68 File Offset: 0x00C5BE68
		public void OnSequenceAnimFinished()
		{
			this.MarkSequenceQtePending = false;
			this.CheckFinish();
		}

		// Token: 0x06034809 RID: 215049 RVA: 0x00C5DC77 File Offset: 0x00C5BE77
		[NullableContext(2)]
		protected void OnQteSucceed(CommonQteContextBase context)
		{
			AudioSystem.Instance.PostEvent("plot_seq_qte_success");
			this.OptionIndex = 0;
			this.OnCommonQteFinished();
		}

		// Token: 0x0603480A RID: 215050 RVA: 0x00C5DC96 File Offset: 0x00C5BE96
		[NullableContext(2)]
		protected void OnQteFailed(CommonQteContextBase context)
		{
			this.OptionIndex = 1;
			AudioSystem.Instance.PostEvent("plot_seq_qte_timeout");
			this.OnCommonQteFinished();
		}

		// Token: 0x0603480B RID: 215051 RVA: 0x00C5DCB8 File Offset: 0x00C5BEB8
		public virtual void OnBegin()
		{
			if (!this.IsProgressQte)
			{
				SCommonQte config = this.Context.Config;
				float playRate = (config != null) ? config.BaseConfig.TimeDilation : 1f;
				this.QteManager.SetPlayRate(playRate);
			}
			this.NeedTick = true;
			if (this.SpineInfo != null)
			{
				PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("RegisterQteSpineCallback", delegate(PlotSubtitleView view)
				{
					if (this.SpineInfo == null || !this.NeedTick)
					{
						return UniTask.FromResult<object>(false);
					}
					this.View = view;
					this.View.RegisterCallback(new Action<string>(this.OnSpineFinishedCallback));
					return UniTask.FromResult<object>(true);
				}, null);
			}
			this.ProgressLerpSpeed = -1f;
			if (this.IsProgressQte)
			{
				this.SectionLength = this.SequenceQteEndRange.FrameNumber.Value - this.SequenceQteStartRange.FrameNumber.Value;
			}
		}

		// Token: 0x0603480C RID: 215052 RVA: 0x00C5DD6C File Offset: 0x00C5BF6C
		public virtual void OnFinish()
		{
			this.ResultSpineCheckList.Clear();
			this.ReleaseAllEventSpines(this.IsForceStop);
			this.EventSpineComponents.Clear();
			this.MissingEventSpineAnimationNames.Clear();
			this.QteManager.ResetPlayRate();
			if (this.SpineInfo != null)
			{
				PlotSubtitleView view = this.View;
				if (view != null)
				{
					view.RegisterCallback(null);
				}
				this.View = null;
			}
		}

		// Token: 0x0603480D RID: 215053 RVA: 0x00C5DDD4 File Offset: 0x00C5BFD4
		public void ForceStopSequenceQte()
		{
			if (this.Context.IsActive())
			{
				this.Context.SuccessCallback = null;
				this.Context.FailCallback = null;
				CommonQteController.Instance.StopQte(this.Context.HandleId);
			}
			this.IsForceStop = true;
			this.NeedTick = false;
			this.QteManager.FinishSequenceAnim(this.Context.QteId);
			AudioSystem.Instance.SetRtpcValue("plot_seq_qte_time_scale", 1f, null);
			this.CloseAllSpine();
			this.OnFinish();
		}

		// Token: 0x0603480E RID: 215054 RVA: 0x00C5DE81 File Offset: 0x00C5C081
		protected virtual void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.GetProgress(), 0f, 1f);
		}

		// Token: 0x0603480F RID: 215055 RVA: 0x00C5DEB0 File Offset: 0x00C5C0B0
		public void OnTick(float inDelta)
		{
			bool flag = this.CleanupInvalidEventSpines();
			if (!this.NeedTick)
			{
				if (flag)
				{
					this.CheckFinish();
				}
				return;
			}
			float num = inDelta;
			if (this.TickInterval > 0f)
			{
				this.TickCheckTime += inDelta;
				if (this.TickCheckTime < this.TickInterval)
				{
					return;
				}
				num = this.TickCheckTime;
				this.TickCheckTime = 0f;
			}
			this.LastProgress = this.CacheProgress;
			this.OnReceiveTick(num);
			if (this.ProgressLerpSpeed > 0f)
			{
				this.CacheProgress = MathUtils.Instance.InterpConstantTo(this.CacheProgress, this.Progress, num, this.ProgressLerpSpeed);
			}
			else
			{
				this.CacheProgress = this.Progress;
			}
			this.UpdateSequenceQte(num);
			this.UpdateSpine();
			if (this.HasCommonQteFinished && this.CheckProgressFinish())
			{
				this.NeedTick = false;
				this.PlayResultSpine(!this.Context.IsFail(), null);
				this.CheckFinish();
			}
		}

		// Token: 0x06034810 RID: 215056 RVA: 0x00C5DFAC File Offset: 0x00C5C1AC
		protected virtual void UpdateSequenceQte(float delta)
		{
			if (this.CacheProgress > this.LastProgress)
			{
				this.QteManager.ForwardSequenceAnim(this.Context.QteId, this.CacheProgress, this.SequenceQteEndRange);
			}
			else if (this.CacheProgress < this.LastProgress)
			{
				this.MarkSequenceQtePending = true;
				this.QteManager.BackwardSequenceAnim(this.Context.QteId, this.CacheProgress, this.SequenceQteStartRange);
			}
			if (this.IsUpdateWithProgress && this.IsProgressQte)
			{
				if (delta <= 0f)
				{
					return;
				}
				float? num = Math.Abs(this.CacheProgress - this.LastProgress) * (float)this.SectionLength / SequenceModel.Instance.CurFrameRate * (float)1000 / delta;
				this.QteManager.SetPlayRate(num.GetValueOrDefault());
			}
		}

		// Token: 0x06034811 RID: 215057 RVA: 0x00C5E0FC File Offset: 0x00C5C2FC
		protected void OnSpineFinishedCallback(string spineName)
		{
			if (this.ResultSpineCheckList.Remove(spineName) && this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0)
			{
				this.CheckFinish();
			}
		}

		// Token: 0x06034812 RID: 215058 RVA: 0x00C5E12C File Offset: 0x00C5C32C
		[NullableContext(2)]
		private void OnEventSpineCompleteCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Complete");
		}

		// Token: 0x06034813 RID: 215059 RVA: 0x00C5E13A File Offset: 0x00C5C33A
		[NullableContext(2)]
		private void OnEventSpineInterruptCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Interrupt");
		}

		// Token: 0x06034814 RID: 215060 RVA: 0x00C5E148 File Offset: 0x00C5C348
		[NullableContext(2)]
		private void OnEventSpineEndCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "End");
		}

		// Token: 0x06034815 RID: 215061 RVA: 0x00C5E156 File Offset: 0x00C5C356
		[NullableContext(2)]
		private void OnEventSpineDisposeCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Dispose");
		}

		// Token: 0x06034816 RID: 215062 RVA: 0x00C5E164 File Offset: 0x00C5C364
		private void OnEventSpineFinishedCallback([Nullable(2)] UTrackEntry entry, string eventName)
		{
			if (entry == null)
			{
				return;
			}
			this.EventSpineTracks.Values.FirstOrDefault((SequenceQteHandleBase<T>.EventSpineTrackState value) => value.Track == entry);
			if (ObjectUtils.IsValid(entry))
			{
				this.RemoveEventSpineCallbacks(entry);
			}
			if (this.PendingEventResultSpineTracks.Remove(entry) && this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0)
			{
				this.CheckFinish();
			}
		}

		// Token: 0x06034817 RID: 215063 RVA: 0x00C5E1F0 File Offset: 0x00C5C3F0
		protected virtual void OnCommonQteFinished()
		{
			this.HasCommonQteFinished = true;
			AudioSystem.Instance.SetRtpcValue("plot_seq_qte_time_scale", 1f, null);
			this.QteManager.ResetPlayRate();
			this.CheckFinish();
		}

		// Token: 0x06034818 RID: 215064 RVA: 0x00C5E234 File Offset: 0x00C5C434
		protected void UpdateSpine()
		{
			if (this.SpineInfo == null)
			{
				return;
			}
			HashSet<string> activeProgressSpineNames = this.GetActiveProgressSpineNames();
			if (activeProgressSpineNames.Count == 0)
			{
				this.PlayStartSpines();
				if (this.CacheProgress > 0f)
				{
					PlotSubtitleView view = this.View;
					if (view == null)
					{
						return;
					}
					view.ManualUpdateNiagara(this.SpineInfo.NiagaraParamNames, this.CacheProgress);
				}
				return;
			}
			this.CloseStartSpines();
			this.UpdateProgressSpineSegments(activeProgressSpineNames);
			PlotSubtitleView view2 = this.View;
			if (view2 == null)
			{
				return;
			}
			view2.ManualUpdateNiagara(this.SpineInfo.NiagaraParamNames, this.CacheProgress);
		}

		// Token: 0x06034819 RID: 215065 RVA: 0x00C5E2BC File Offset: 0x00C5C4BC
		private HashSet<string> GetActiveProgressSpineNames()
		{
			HashSet<string> hashSet = new HashSet<string>();
			QteSpineInfoProxy spineInfo = this.SpineInfo;
			if (((spineInfo != null) ? spineInfo.ProgressSpineSegments : null) != null)
			{
				foreach (QteProgressSpineSegmentProxy qteProgressSpineSegmentProxy in this.SpineInfo.ProgressSpineSegments)
				{
					if (qteProgressSpineSegmentProxy.IsActive(this.CacheProgress))
					{
						foreach (SpineDataProxy spineDataProxy in qteProgressSpineSegmentProxy.Spines)
						{
							if (!string.IsNullOrEmpty(spineDataProxy.Name))
							{
								hashSet.Add(spineDataProxy.Name);
							}
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x0603481A RID: 215066 RVA: 0x00C5E394 File Offset: 0x00C5C594
		private void UpdateProgressSpineSegments(HashSet<string> activeSpineNames)
		{
			this.CloseInactiveProgressSpines(activeSpineNames);
			QteSpineInfoProxy spineInfo = this.SpineInfo;
			if (((spineInfo != null) ? spineInfo.ProgressSpineSegments : null) != null)
			{
				foreach (QteProgressSpineSegmentProxy qteProgressSpineSegmentProxy in this.SpineInfo.ProgressSpineSegments)
				{
					if (qteProgressSpineSegmentProxy.IsActive(this.CacheProgress))
					{
						foreach (SpineDataProxy spineDataProxy in qteProgressSpineSegmentProxy.Spines)
						{
							if (!string.IsNullOrEmpty(spineDataProxy.Name))
							{
								if (!this.ActiveProgressSpineNames.Contains(spineDataProxy.Name))
								{
									PlotSubtitleView view = this.View;
									if (view != null)
									{
										view.PlaySonUiSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), true, qteProgressSpineSegmentProxy.BlendInTime);
									}
									this.PlayEventSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), true, qteProgressSpineSegmentProxy.BlendInTime, false);
									this.ActiveProgressSpineNames.Add(spineDataProxy.Name);
								}
								this.ActiveProgressSpineSegments[spineDataProxy.Name] = qteProgressSpineSegmentProxy;
								PlotSubtitleView view2 = this.View;
								if (view2 != null)
								{
									view2.UpdateSpineForQteByName(spineDataProxy.Name, qteProgressSpineSegmentProxy.GetSpineProgress(this.CacheProgress));
								}
								this.UpdateEventSpine(spineDataProxy.Name, qteProgressSpineSegmentProxy.GetSpineProgress(this.CacheProgress));
							}
						}
					}
				}
			}
			this.HasPlayProgressSpine = (this.ActiveProgressSpineNames.Count > 0);
		}

		// Token: 0x0603481B RID: 215067 RVA: 0x00C5E554 File Offset: 0x00C5C754
		private void PlayStartSpines()
		{
			if (this.HasPlayProgressSpine)
			{
				this.CloseInactiveProgressSpines(new HashSet<string>());
				this.HasPlayProgressSpine = false;
			}
			if (!this.HasPlayStartSpine)
			{
				QteSpineInfoProxy spineInfo = this.SpineInfo;
				foreach (SpineDataProxy spineDataProxy in (((spineInfo != null) ? spineInfo.StartLoopSpines : null) ?? new List<SpineDataProxy>()))
				{
					PlotSubtitleView view = this.View;
					if (view != null)
					{
						view.PlaySonUiSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), false, 0f);
					}
					this.PlayEventSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), false, 0f, false);
				}
				this.HasPlayStartSpine = true;
			}
		}

		// Token: 0x0603481C RID: 215068 RVA: 0x00C5E628 File Offset: 0x00C5C828
		private void CloseStartSpines()
		{
			if (this.HasPlayStartSpine)
			{
				QteSpineInfoProxy spineInfo = this.SpineInfo;
				this.CloseSpine((spineInfo != null) ? spineInfo.StartLoopSpines : null, 0.5f);
				this.HasPlayStartSpine = false;
			}
		}

		// Token: 0x0603481D RID: 215069 RVA: 0x00C5E658 File Offset: 0x00C5C858
		private void CloseInactiveProgressSpines(HashSet<string> activeSpineNames)
		{
			foreach (string text in this.ActiveProgressSpineNames.ToList<string>())
			{
				if (!activeSpineNames.Contains(text))
				{
					QteProgressSpineSegmentProxy qteProgressSpineSegmentProxy;
					this.ActiveProgressSpineSegments.TryGetValue(text, out qteProgressSpineSegmentProxy);
					PlotSubtitleView view = this.View;
					if (view != null)
					{
						view.CloseSpineAnimation(text, (qteProgressSpineSegmentProxy != null) ? qteProgressSpineSegmentProxy.BlendOutTime : 0f);
					}
					this.CloseEventSpine(text, (qteProgressSpineSegmentProxy != null) ? qteProgressSpineSegmentProxy.BlendOutTime : 0f);
					this.ActiveProgressSpineNames.Remove(text);
					this.ActiveProgressSpineSegments.Remove(text);
				}
			}
		}

		// Token: 0x0603481E RID: 215070 RVA: 0x00C5E714 File Offset: 0x00C5C914
		protected void CloseSpine([Nullable(new byte[]
		{
			2,
			1
		})] List<SpineDataProxy> spines, float blendOutTime = 0f)
		{
			if (spines == null)
			{
				return;
			}
			foreach (SpineDataProxy spineDataProxy in spines)
			{
				PlotSubtitleView view = this.View;
				if (view != null)
				{
					view.CloseSpineAnimation(spineDataProxy.Name, blendOutTime);
				}
				this.CloseEventSpine(spineDataProxy.Name, blendOutTime);
			}
		}

		// Token: 0x0603481F RID: 215071 RVA: 0x00C5E784 File Offset: 0x00C5C984
		protected void CloseAllSpine()
		{
			if (this.SpineInfo == null)
			{
				return;
			}
			this.CloseSpine(this.SpineInfo.GetProgressSpines(), 0f);
			this.CloseSpine(this.SpineInfo.StartLoopSpines, 0f);
			this.CloseSpine(this.SpineInfo.EndSpine, 0f);
			this.CloseSpine(this.SpineInfo.SuccessSpine, 0f);
			this.CloseSpine(this.SpineInfo.FailSpine, 0f);
			this.ActiveProgressSpineNames.Clear();
			this.ActiveProgressSpineSegments.Clear();
			this.HasPlayProgressSpine = false;
			this.HasPlayStartSpine = false;
		}

		// Token: 0x06034820 RID: 215072 RVA: 0x00C5E82C File Offset: 0x00C5CA2C
		protected void CloseProgressSpine()
		{
			if (this.SpineInfo == null)
			{
				return;
			}
			if (this.HasPlayProgressSpine)
			{
				this.CloseSpine(this.SpineInfo.GetProgressSpines(), 0f);
				this.ActiveProgressSpineNames.Clear();
				this.ActiveProgressSpineSegments.Clear();
				this.HasPlayProgressSpine = false;
			}
			if (this.HasPlayStartSpine)
			{
				this.CloseSpine(this.SpineInfo.StartLoopSpines, 0f);
				this.HasPlayStartSpine = false;
			}
		}

		// Token: 0x06034821 RID: 215073 RVA: 0x00C5E8A4 File Offset: 0x00C5CAA4
		[NullableContext(2)]
		protected void PlayResultSpine(bool isSuccess, QteSpineInfoProxy spineInfo = null)
		{
			if (spineInfo == null)
			{
				spineInfo = this.SpineInfo;
			}
			if (spineInfo == null)
			{
				return;
			}
			if (spineInfo == this.SpineInfo)
			{
				this.CloseProgressSpine();
			}
			List<SpineDataProxy> list = isSuccess ? spineInfo.GetSuccessResultSpine() : spineInfo.GetFailResultSpine();
			if (list != null)
			{
				foreach (SpineDataProxy spineDataProxy in list)
				{
					if (!string.IsNullOrEmpty(spineDataProxy.Name))
					{
						if (this.View != null)
						{
							if (this.View.RegisterCallback(new Action<string>(this.OnSpineFinishedCallback)) && spineInfo.WaitEndSpineFinish && !spineDataProxy.NeedLoop.GetValueOrDefault())
							{
								this.ResultSpineCheckList.Add(spineDataProxy.Name);
							}
							if (!this.View.PlaySonUiSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), false, 0f))
							{
								this.ResultSpineCheckList.Remove(spineDataProxy.Name);
							}
						}
						this.PlayEventSpine(spineDataProxy.Name, spineDataProxy.NeedLoop.GetValueOrDefault(), false, 0f, spineInfo.WaitEndSpineFinish && !spineDataProxy.NeedLoop.GetValueOrDefault());
					}
				}
			}
			int count = this.ResultSpineCheckList.Count;
		}

		// Token: 0x06034822 RID: 215074 RVA: 0x00C5E9FC File Offset: 0x00C5CBFC
		[NullableContext(2)]
		private void PlayEventSpine(string spineName, bool isLoop, bool freeze, float blendInTime, bool waitForFinish = false)
		{
			if (string.IsNullOrEmpty(spineName))
			{
				return;
			}
			int num = 0;
			foreach (USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent in this.EventSpineComponents.ToList<USpineSkeletonAnimationComponent>())
			{
				if (!ObjectUtils.IsValid(uspineSkeletonAnimationComponent))
				{
					this.EventSpineComponents.Remove(uspineSkeletonAnimationComponent);
					this.RemoveEventSpineTrack(uspineSkeletonAnimationComponent);
				}
				else if (!uspineSkeletonAnimationComponent.HasAnimation(spineName))
				{
					num++;
				}
				else
				{
					this.RemoveEventSpineTrack(uspineSkeletonAnimationComponent);
					UTrackEntry utrackEntry = uspineSkeletonAnimationComponent.SetAnimation(0, spineName, isLoop);
					if (utrackEntry != null && utrackEntry.isValidAnimation())
					{
						utrackEntry.SetMixDuration(blendInTime);
						utrackEntry.SetTimeScale(!freeze);
						this.EventSpineTracks[uspineSkeletonAnimationComponent] = new SequenceQteHandleBase<T>.EventSpineTrackState
						{
							Component = uspineSkeletonAnimationComponent,
							Track = utrackEntry,
							AnimationName = spineName,
							IsFrozen = freeze,
							Duration = utrackEntry.getAnimationDuration()
						};
						if (waitForFinish)
						{
							this.PendingEventResultSpineTracks.Add(utrackEntry);
							utrackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnEventSpineCompleteCallback));
							utrackEntry.AnimationInterrupt.Add(new Action<UTrackEntry>(this.OnEventSpineInterruptCallback));
							utrackEntry.AnimationEnd.Add(new Action<UTrackEntry>(this.OnEventSpineEndCallback));
							utrackEntry.AnimationDispose.Add(new Action<UTrackEntry>(this.OnEventSpineDisposeCallback));
						}
					}
				}
			}
			if (num > 0)
			{
				this.MissingEventSpineAnimationNames.Add(spineName);
			}
		}

		// Token: 0x06034823 RID: 215075 RVA: 0x00C5EB8C File Offset: 0x00C5CD8C
		private void UpdateEventSpine(string spineName, float progress)
		{
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values.ToList<SequenceQteHandleBase<T>.EventSpineTrackState>())
			{
				if (!(eventSpineTrackState.AnimationName != spineName) && eventSpineTrackState.IsFrozen && ObjectUtils.IsValid(eventSpineTrackState.Component) && ObjectUtils.IsValid(eventSpineTrackState.Track) && eventSpineTrackState.Track.isValidAnimation())
				{
					float num = eventSpineTrackState.Duration * progress;
					eventSpineTrackState.Track.SetTrackTime(num);
					eventSpineTrackState.Track.SetMixTime(num);
				}
			}
		}

		// Token: 0x06034824 RID: 215076 RVA: 0x00C5EC40 File Offset: 0x00C5CE40
		[NullableContext(2)]
		private void CloseEventSpine(string spineName, float blendOutTime)
		{
			if (string.IsNullOrEmpty(spineName))
			{
				return;
			}
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values.ToList<SequenceQteHandleBase<T>.EventSpineTrackState>())
			{
				if (!(eventSpineTrackState.AnimationName != spineName))
				{
					USpineSkeletonAnimationComponent component = eventSpineTrackState.Component;
					this.RemoveEventSpineTrack(component);
					if (ObjectUtils.IsValid(component))
					{
						component.SetEmptyAnimation(0, blendOutTime);
					}
				}
			}
		}

		// Token: 0x06034825 RID: 215077 RVA: 0x00C5ECCC File Offset: 0x00C5CECC
		private void ReleaseAllEventSpines(bool closeAnimation)
		{
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values.ToList<SequenceQteHandleBase<T>.EventSpineTrackState>())
			{
				USpineSkeletonAnimationComponent component = eventSpineTrackState.Component;
				this.RemoveEventSpineTrack(component);
				if (closeAnimation && ObjectUtils.IsValid(component))
				{
					component.SetEmptyAnimation(0, 0f);
				}
			}
			this.EventSpineTracks.Clear();
			this.PendingEventResultSpineTracks.Clear();
		}

		// Token: 0x06034826 RID: 215078 RVA: 0x00C5ED5C File Offset: 0x00C5CF5C
		private void RemoveEventSpineTrack(USpineSkeletonAnimationComponent component)
		{
			SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState;
			if (!this.EventSpineTracks.Remove(component, out eventSpineTrackState))
			{
				return;
			}
			if (ObjectUtils.IsValid(eventSpineTrackState.Track))
			{
				this.RemoveEventSpineCallbacks(eventSpineTrackState.Track);
			}
			this.PendingEventResultSpineTracks.Remove(eventSpineTrackState.Track);
		}

		// Token: 0x06034827 RID: 215079 RVA: 0x00C5EDA8 File Offset: 0x00C5CFA8
		private void RemoveEventSpineCallbacks(UTrackEntry track)
		{
			track.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnEventSpineCompleteCallback));
			track.AnimationInterrupt.Remove(new Action<UTrackEntry>(this.OnEventSpineInterruptCallback));
			track.AnimationEnd.Remove(new Action<UTrackEntry>(this.OnEventSpineEndCallback));
			track.AnimationDispose.Remove(new Action<UTrackEntry>(this.OnEventSpineDisposeCallback));
		}

		// Token: 0x06034828 RID: 215080 RVA: 0x00C5EE14 File Offset: 0x00C5D014
		private bool CleanupInvalidEventSpines()
		{
			bool flag = false;
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values.ToList<SequenceQteHandleBase<T>.EventSpineTrackState>())
			{
				if (!ObjectUtils.IsValid(eventSpineTrackState.Component) || !ObjectUtils.IsValid(eventSpineTrackState.Track) || !eventSpineTrackState.Track.isValidAnimation())
				{
					bool flag2 = this.PendingEventResultSpineTracks.Contains(eventSpineTrackState.Track);
					flag = (flag || flag2);
					this.RemoveEventSpineTrack(eventSpineTrackState.Component);
					this.EventSpineComponents.Remove(eventSpineTrackState.Component);
				}
			}
			return flag;
		}

		// Token: 0x06034829 RID: 215081 RVA: 0x00C5EEC8 File Offset: 0x00C5D0C8
		protected void CheckFinish()
		{
			if (this.HasFinished)
			{
				return;
			}
			if (!this.IsSequenceQteFinished())
			{
				return;
			}
			this.HasFinished = true;
			this.QteManager.OnSequenceQteFinished(this.Context.QteId);
		}

		// Token: 0x0603482A RID: 215082 RVA: 0x00C5EF00 File Offset: 0x00C5D100
		protected bool IsSequenceQteFinished()
		{
			return this.IsForceStop || (this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0 && this.CheckProgressFinish() && !this.MarkSequenceQtePending && !this.Context.IsPending());
		}

		// Token: 0x0603482B RID: 215083 RVA: 0x00C5EF60 File Offset: 0x00C5D160
		protected bool CheckProgressFinish()
		{
			return MathUtils.Instance.IsNearlyEqual((double)this.CacheProgress, (double)this.Progress, null);
		}

		// Token: 0x0401BFA8 RID: 114600
		private const string EVENT_SUCCESS = "plot_seq_qte_success";

		// Token: 0x0401BFA9 RID: 114601
		private const string EVENT_FAIL = "plot_seq_qte_timeout";

		// Token: 0x0401BFAA RID: 114602
		public const float PERCENT = 0.01f;

		// Token: 0x0401BFAB RID: 114603
		private const float BLEND_OUT_TIME = 0.5f;

		// Token: 0x0401BFAC RID: 114604
		protected readonly SequenceQteManager QteManager;

		// Token: 0x0401BFAD RID: 114605
		protected readonly T Context;

		// Token: 0x0401BFB4 RID: 114612
		protected bool MarkSequenceQtePending;

		// Token: 0x0401BFB5 RID: 114613
		protected bool IsForceStop;

		// Token: 0x0401BFB6 RID: 114614
		protected float UpdateInterval;

		// Token: 0x0401BFB7 RID: 114615
		protected float Progress;

		// Token: 0x0401BFB8 RID: 114616
		protected float CacheProgress;

		// Token: 0x0401BFB9 RID: 114617
		protected float LastProgress;

		// Token: 0x0401BFBA RID: 114618
		protected float ProgressLerpSpeed = -1f;

		// Token: 0x0401BFBB RID: 114619
		protected float TickInterval;

		// Token: 0x0401BFBC RID: 114620
		protected float TickCheckTime;

		// Token: 0x0401BFBD RID: 114621
		protected bool HasFinished;

		// Token: 0x0401BFBE RID: 114622
		protected bool HasCommonQteFinished;

		// Token: 0x0401BFBF RID: 114623
		protected bool NeedTick;

		// Token: 0x0401BFC0 RID: 114624
		protected int SectionLength;

		// Token: 0x0401BFC2 RID: 114626
		protected float CacheSpineProgress;

		// Token: 0x0401BFC3 RID: 114627
		[Nullable(2)]
		protected PlotSubtitleView View;

		// Token: 0x0401BFC4 RID: 114628
		protected bool HasPlayProgressSpine;

		// Token: 0x0401BFC5 RID: 114629
		protected bool HasPlayStartSpine;

		// Token: 0x0401BFC6 RID: 114630
		private readonly HashSet<string> ActiveProgressSpineNames = new HashSet<string>();

		// Token: 0x0401BFC7 RID: 114631
		private readonly Dictionary<string, QteProgressSpineSegmentProxy> ActiveProgressSpineSegments = new Dictionary<string, QteProgressSpineSegmentProxy>();

		// Token: 0x0401BFC8 RID: 114632
		protected readonly HashSet<string> ResultSpineCheckList = new HashSet<string>();

		// Token: 0x0401BFC9 RID: 114633
		private readonly HashSet<USpineSkeletonAnimationComponent> EventSpineComponents = new HashSet<USpineSkeletonAnimationComponent>();

		// Token: 0x0401BFCA RID: 114634
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			0
		})]
		private readonly Dictionary<USpineSkeletonAnimationComponent, SequenceQteHandleBase<T>.EventSpineTrackState> EventSpineTracks = new Dictionary<USpineSkeletonAnimationComponent, SequenceQteHandleBase<T>.EventSpineTrackState>();

		// Token: 0x0401BFCB RID: 114635
		private readonly HashSet<UTrackEntry> PendingEventResultSpineTracks = new HashSet<UTrackEntry>();

		// Token: 0x0401BFCC RID: 114636
		private readonly HashSet<string> MissingEventSpineAnimationNames = new HashSet<string>();

		// Token: 0x0200B158 RID: 45400
		[Nullable(0)]
		[RequiredMember]
		private class EventSpineTrackState
		{
			// Token: 0x0604E5F2 RID: 321010 RVA: 0x014CDBD6 File Offset: 0x014CBDD6
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EventSpineTrackState()
			{
			}

			// Token: 0x04035CF9 RID: 220409
			[RequiredMember]
			public USpineSkeletonAnimationComponent Component;

			// Token: 0x04035CFA RID: 220410
			[RequiredMember]
			public UTrackEntry Track;

			// Token: 0x04035CFB RID: 220411
			[RequiredMember]
			public string AnimationName;

			// Token: 0x04035CFC RID: 220412
			public bool IsFrozen;

			// Token: 0x04035CFD RID: 220413
			public float Duration;
		}
	}
}
