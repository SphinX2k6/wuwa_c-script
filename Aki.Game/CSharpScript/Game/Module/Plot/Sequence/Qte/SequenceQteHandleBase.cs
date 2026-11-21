using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FED RID: 16365
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceQteHandleBase<[Nullable(0)] T> : ISequenceCommonQteHandle where T : CommonQteContextBase
	{
		// Token: 0x0602969B RID: 169627 RVA: 0x00BA9014 File Offset: 0x00BA7214
		public SequenceQteHandleBase(SequenceQteManager qteManager, T context)
		{
			this.QteManager = qteManager;
			this.Context = context;
			this.Context.SuccessCallback = new TCommonQteCallback(this.OnQteSucceed);
			this.Context.FailCallback = new TCommonQteCallback(this.OnQteFailed);
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x0602969C RID: 169628 RVA: 0x00BA90D3 File Offset: 0x00BA72D3
		// (set) Token: 0x0602969D RID: 169629 RVA: 0x00BA90DB File Offset: 0x00BA72DB
		public int SubtitleId { get; set; } = -1;

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x0602969E RID: 169630 RVA: 0x00BA90E4 File Offset: 0x00BA72E4
		// (set) Token: 0x0602969F RID: 169631 RVA: 0x00BA90EC File Offset: 0x00BA72EC
		public int OptionIndex { get; set; } = -1;

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x060296A0 RID: 169632 RVA: 0x00BA90F5 File Offset: 0x00BA72F5
		// (set) Token: 0x060296A1 RID: 169633 RVA: 0x00BA90FD File Offset: 0x00BA72FD
		public bool IsProgressQte { get; set; }

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x060296A2 RID: 169634 RVA: 0x00BA9106 File Offset: 0x00BA7306
		// (set) Token: 0x060296A3 RID: 169635 RVA: 0x00BA910E File Offset: 0x00BA730E
		[Nullable(2)]
		public FFrameTime SequenceQteStartRange { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x060296A4 RID: 169636 RVA: 0x00BA9117 File Offset: 0x00BA7317
		// (set) Token: 0x060296A5 RID: 169637 RVA: 0x00BA911F File Offset: 0x00BA731F
		[Nullable(2)]
		public FFrameTime SequenceQteEndRange { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x060296A6 RID: 169638 RVA: 0x00BA9128 File Offset: 0x00BA7328
		// (set) Token: 0x060296A7 RID: 169639 RVA: 0x00BA9130 File Offset: 0x00BA7330
		public bool IsUpdateWithProgress { get; set; }

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x060296A8 RID: 169640 RVA: 0x00BA9139 File Offset: 0x00BA7339
		// (set) Token: 0x060296A9 RID: 169641 RVA: 0x00BA9141 File Offset: 0x00BA7341
		[Nullable(2)]
		public QteSpineInfoProxy SpineInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x060296AA RID: 169642 RVA: 0x00BA914C File Offset: 0x00BA734C
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

		// Token: 0x060296AB RID: 169643 RVA: 0x00BA91B4 File Offset: 0x00BA73B4
		public void OnSequenceAnimFinished()
		{
			this.MarkSequenceQtePending = false;
			this.CheckFinish();
		}

		// Token: 0x060296AC RID: 169644 RVA: 0x00BA91C3 File Offset: 0x00BA73C3
		[NullableContext(2)]
		protected void OnQteSucceed(CommonQteContextBase context)
		{
			AudioSystem.Instance.PostEvent("plot_seq_qte_success");
			this.OptionIndex = 0;
			this.OnCommonQteFinished();
		}

		// Token: 0x060296AD RID: 169645 RVA: 0x00BA91E2 File Offset: 0x00BA73E2
		[NullableContext(2)]
		protected void OnQteFailed(CommonQteContextBase context)
		{
			this.OptionIndex = 1;
			AudioSystem.Instance.PostEvent("plot_seq_qte_timeout");
			this.OnCommonQteFinished();
		}

		// Token: 0x060296AE RID: 169646 RVA: 0x00BA9204 File Offset: 0x00BA7404
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

		// Token: 0x060296AF RID: 169647 RVA: 0x00BA92B8 File Offset: 0x00BA74B8
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

		// Token: 0x060296B0 RID: 169648 RVA: 0x00BA9320 File Offset: 0x00BA7520
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

		// Token: 0x060296B1 RID: 169649 RVA: 0x00BA93CD File Offset: 0x00BA75CD
		protected virtual void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.GetProgress(), 0f, 1f);
		}

		// Token: 0x060296B2 RID: 169650 RVA: 0x00BA93FC File Offset: 0x00BA75FC
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

		// Token: 0x060296B3 RID: 169651 RVA: 0x00BA94F8 File Offset: 0x00BA76F8
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

		// Token: 0x060296B4 RID: 169652 RVA: 0x00BA9648 File Offset: 0x00BA7848
		protected void OnSpineFinishedCallback(string spineName)
		{
			if (this.ResultSpineCheckList.Remove(spineName) && this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0)
			{
				this.CheckFinish();
			}
		}

		// Token: 0x060296B5 RID: 169653 RVA: 0x00BA9678 File Offset: 0x00BA7878
		[NullableContext(2)]
		private void OnEventSpineCompleteCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Complete");
		}

		// Token: 0x060296B6 RID: 169654 RVA: 0x00BA9686 File Offset: 0x00BA7886
		[NullableContext(2)]
		private void OnEventSpineInterruptCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Interrupt");
		}

		// Token: 0x060296B7 RID: 169655 RVA: 0x00BA9694 File Offset: 0x00BA7894
		[NullableContext(2)]
		private void OnEventSpineEndCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "End");
		}

		// Token: 0x060296B8 RID: 169656 RVA: 0x00BA96A2 File Offset: 0x00BA78A2
		[NullableContext(2)]
		private void OnEventSpineDisposeCallback(UTrackEntry entry)
		{
			this.OnEventSpineFinishedCallback(entry, "Dispose");
		}

		// Token: 0x060296B9 RID: 169657 RVA: 0x00BA96B0 File Offset: 0x00BA78B0
		private void OnEventSpineFinishedCallback([Nullable(2)] UTrackEntry entry, string eventName)
		{
			if (entry == null)
			{
				return;
			}
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values)
			{
				if (eventSpineTrackState.Track == entry)
				{
					break;
				}
			}
			if (ObjectUtils.IsValid(entry))
			{
				this.RemoveEventSpineCallbacks(entry);
			}
			if (this.PendingEventResultSpineTracks.Remove(entry) && this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0)
			{
				this.CheckFinish();
			}
		}

		// Token: 0x060296BA RID: 169658 RVA: 0x00BA9750 File Offset: 0x00BA7950
		protected virtual void OnCommonQteFinished()
		{
			this.HasCommonQteFinished = true;
			AudioSystem.Instance.SetRtpcValue("plot_seq_qte_time_scale", 1f, null);
			this.QteManager.ResetPlayRate();
			this.CheckFinish();
		}

		// Token: 0x060296BB RID: 169659 RVA: 0x00BA9794 File Offset: 0x00BA7994
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

		// Token: 0x060296BC RID: 169660 RVA: 0x00BA981C File Offset: 0x00BA7A1C
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

		// Token: 0x060296BD RID: 169661 RVA: 0x00BA98F4 File Offset: 0x00BA7AF4
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

		// Token: 0x060296BE RID: 169662 RVA: 0x00BA9AB4 File Offset: 0x00BA7CB4
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

		// Token: 0x060296BF RID: 169663 RVA: 0x00BA9B88 File Offset: 0x00BA7D88
		private void CloseStartSpines()
		{
			if (this.HasPlayStartSpine)
			{
				QteSpineInfoProxy spineInfo = this.SpineInfo;
				this.CloseSpine((spineInfo != null) ? spineInfo.StartLoopSpines : null, 0.5f);
				this.HasPlayStartSpine = false;
			}
		}

		// Token: 0x060296C0 RID: 169664 RVA: 0x00BA9BB8 File Offset: 0x00BA7DB8
		private void CloseInactiveProgressSpines(HashSet<string> activeSpineNames)
		{
			foreach (string text in new List<string>(this.ActiveProgressSpineNames))
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

		// Token: 0x060296C1 RID: 169665 RVA: 0x00BA9C74 File Offset: 0x00BA7E74
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

		// Token: 0x060296C2 RID: 169666 RVA: 0x00BA9CE4 File Offset: 0x00BA7EE4
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

		// Token: 0x060296C3 RID: 169667 RVA: 0x00BA9D8C File Offset: 0x00BA7F8C
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

		// Token: 0x060296C4 RID: 169668 RVA: 0x00BA9E04 File Offset: 0x00BA8004
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

		// Token: 0x060296C5 RID: 169669 RVA: 0x00BA9F5C File Offset: 0x00BA815C
		[NullableContext(2)]
		private void PlayEventSpine(string spineName, bool isLoop, bool freeze, float blendInTime, bool waitForFinish = false)
		{
			if (string.IsNullOrEmpty(spineName))
			{
				return;
			}
			int num = 0;
			foreach (USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent in new List<USpineSkeletonAnimationComponent>(this.EventSpineComponents))
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

		// Token: 0x060296C6 RID: 169670 RVA: 0x00BAA0EC File Offset: 0x00BA82EC
		private void UpdateEventSpine(string spineName, float progress)
		{
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values)
			{
				if (!(eventSpineTrackState.AnimationName != spineName) && eventSpineTrackState.IsFrozen && ObjectUtils.IsValid(eventSpineTrackState.Component) && ObjectUtils.IsValid(eventSpineTrackState.Track) && eventSpineTrackState.Track.isValidAnimation())
				{
					float num = eventSpineTrackState.Duration * progress;
					eventSpineTrackState.Track.SetTrackTime(num);
					eventSpineTrackState.Track.SetMixTime(num);
				}
			}
		}

		// Token: 0x060296C7 RID: 169671 RVA: 0x00BAA19C File Offset: 0x00BA839C
		[NullableContext(2)]
		private void CloseEventSpine(string spineName, float blendOutTime)
		{
			if (string.IsNullOrEmpty(spineName))
			{
				return;
			}
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values)
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

		// Token: 0x060296C8 RID: 169672 RVA: 0x00BAA224 File Offset: 0x00BA8424
		private void ReleaseAllEventSpines(bool closeAnimation)
		{
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values)
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

		// Token: 0x060296C9 RID: 169673 RVA: 0x00BAA2B0 File Offset: 0x00BA84B0
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

		// Token: 0x060296CA RID: 169674 RVA: 0x00BAA2FC File Offset: 0x00BA84FC
		private void RemoveEventSpineCallbacks(UTrackEntry track)
		{
			track.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnEventSpineCompleteCallback));
			track.AnimationInterrupt.Remove(new Action<UTrackEntry>(this.OnEventSpineInterruptCallback));
			track.AnimationEnd.Remove(new Action<UTrackEntry>(this.OnEventSpineEndCallback));
			track.AnimationDispose.Remove(new Action<UTrackEntry>(this.OnEventSpineDisposeCallback));
		}

		// Token: 0x060296CB RID: 169675 RVA: 0x00BAA368 File Offset: 0x00BA8568
		private bool CleanupInvalidEventSpines()
		{
			bool flag = false;
			foreach (SequenceQteHandleBase<T>.EventSpineTrackState eventSpineTrackState in this.EventSpineTracks.Values)
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

		// Token: 0x060296CC RID: 169676 RVA: 0x00BAA418 File Offset: 0x00BA8618
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

		// Token: 0x060296CD RID: 169677 RVA: 0x00BAA450 File Offset: 0x00BA8650
		protected bool IsSequenceQteFinished()
		{
			return this.IsForceStop || (this.ResultSpineCheckList.Count == 0 && this.PendingEventResultSpineTracks.Count == 0 && this.CheckProgressFinish() && !this.MarkSequenceQtePending && !this.Context.IsPending());
		}

		// Token: 0x060296CE RID: 169678 RVA: 0x00BAA4B0 File Offset: 0x00BA86B0
		protected bool CheckProgressFinish()
		{
			return MathUtils.Instance.IsNearlyEqual((double)this.CacheProgress, (double)this.Progress, null);
		}

		// Token: 0x04016993 RID: 92563
		private const string EVENT_SUCCESS = "plot_seq_qte_success";

		// Token: 0x04016994 RID: 92564
		private const string EVENT_FAIL = "plot_seq_qte_timeout";

		// Token: 0x04016995 RID: 92565
		public const float PERCENT = 0.01f;

		// Token: 0x04016996 RID: 92566
		private const float BLEND_OUT_TIME = 0.5f;

		// Token: 0x04016997 RID: 92567
		protected readonly SequenceQteManager QteManager;

		// Token: 0x04016998 RID: 92568
		protected readonly T Context;

		// Token: 0x0401699F RID: 92575
		protected bool MarkSequenceQtePending;

		// Token: 0x040169A0 RID: 92576
		protected bool IsForceStop;

		// Token: 0x040169A1 RID: 92577
		protected float UpdateInterval;

		// Token: 0x040169A2 RID: 92578
		protected float Progress;

		// Token: 0x040169A3 RID: 92579
		protected float CacheProgress;

		// Token: 0x040169A4 RID: 92580
		protected float LastProgress;

		// Token: 0x040169A5 RID: 92581
		protected float ProgressLerpSpeed = -1f;

		// Token: 0x040169A6 RID: 92582
		protected float TickInterval;

		// Token: 0x040169A7 RID: 92583
		protected float TickCheckTime;

		// Token: 0x040169A8 RID: 92584
		protected bool HasFinished;

		// Token: 0x040169A9 RID: 92585
		protected bool HasCommonQteFinished;

		// Token: 0x040169AA RID: 92586
		protected bool NeedTick;

		// Token: 0x040169AB RID: 92587
		protected int SectionLength;

		// Token: 0x040169AD RID: 92589
		protected float CacheSpineProgress;

		// Token: 0x040169AE RID: 92590
		[Nullable(2)]
		protected PlotSubtitleView View;

		// Token: 0x040169AF RID: 92591
		protected bool HasPlayProgressSpine;

		// Token: 0x040169B0 RID: 92592
		protected bool HasPlayStartSpine;

		// Token: 0x040169B1 RID: 92593
		private readonly HashSet<string> ActiveProgressSpineNames = new HashSet<string>();

		// Token: 0x040169B2 RID: 92594
		private readonly Dictionary<string, QteProgressSpineSegmentProxy> ActiveProgressSpineSegments = new Dictionary<string, QteProgressSpineSegmentProxy>();

		// Token: 0x040169B3 RID: 92595
		protected readonly HashSet<string> ResultSpineCheckList = new HashSet<string>();

		// Token: 0x040169B4 RID: 92596
		private readonly HashSet<USpineSkeletonAnimationComponent> EventSpineComponents = new HashSet<USpineSkeletonAnimationComponent>();

		// Token: 0x040169B5 RID: 92597
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			0
		})]
		private readonly Dictionary<USpineSkeletonAnimationComponent, SequenceQteHandleBase<T>.EventSpineTrackState> EventSpineTracks = new Dictionary<USpineSkeletonAnimationComponent, SequenceQteHandleBase<T>.EventSpineTrackState>();

		// Token: 0x040169B6 RID: 92598
		private readonly HashSet<UTrackEntry> PendingEventResultSpineTracks = new HashSet<UTrackEntry>();

		// Token: 0x040169B7 RID: 92599
		private readonly HashSet<string> MissingEventSpineAnimationNames = new HashSet<string>();

		// Token: 0x02009B90 RID: 39824
		[Nullable(0)]
		[RequiredMember]
		private class EventSpineTrackState
		{
			// Token: 0x06044BFD RID: 281597 RVA: 0x01487366 File Offset: 0x01485566
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EventSpineTrackState()
			{
			}

			// Token: 0x04030741 RID: 198465
			[RequiredMember]
			public USpineSkeletonAnimationComponent Component;

			// Token: 0x04030742 RID: 198466
			[RequiredMember]
			public UTrackEntry Track;

			// Token: 0x04030743 RID: 198467
			[RequiredMember]
			public string AnimationName;

			// Token: 0x04030744 RID: 198468
			public bool IsFrozen;

			// Token: 0x04030745 RID: 198469
			public float Duration;
		}
	}
}
