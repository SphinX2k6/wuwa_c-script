using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DFE RID: 28158
	[NullableContext(1)]
	[Nullable(0)]
	public class QteHourglassView : UiTickViewBase
	{
		// Token: 0x06044B04 RID: 281348 RVA: 0x010F3F18 File Offset: 0x010F2118
		public QteHourglassView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06044B05 RID: 281349 RVA: 0x010F3F90 File Offset: 0x010F2190
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06044B06 RID: 281350 RVA: 0x010F3FCC File Offset: 0x010F21CC
		protected override void OnStart()
		{
			this.FillItem = base.GetItem(0);
			this.TrailItem = base.GetItem(1);
			this.ResetTrailMove();
			EventSystem.Instance.Add<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartSequenceFinished), false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.AddSequenceFinishEvent("PhaseA", new Action<string>(this.OnPhaseAFinished), false);
			}
			UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
			if (uiViewSequence3 != null)
			{
				uiViewSequence3.AddSequenceFinishEvent("PhaseB", new Action<string>(this.OnPhaseBFinished), false);
			}
			UiBehaviorLevelSequence uiViewSequence4 = this.UiViewSequence;
			if (uiViewSequence4 == null)
			{
				return;
			}
			uiViewSequence4.AddSequenceFinishEvent("PhaseC", new Action<string>(this.OnPhaseCFinished), false);
		}

		// Token: 0x06044B07 RID: 281351 RVA: 0x010F40A0 File Offset: 0x010F22A0
		protected override UniTask OnCreateAsync()
		{
			QteHourglassView.<OnCreateAsync>d__29 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<QteHourglassView.<OnCreateAsync>d__29>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044B08 RID: 281352 RVA: 0x010F40E3 File Offset: 0x010F22E3
		protected override void OnBeforeHide()
		{
			this.CleanupRuntimeState();
			if (!this.LastHide)
			{
				this.LastHide = true;
				base.CloseMe(null);
			}
		}

		// Token: 0x06044B09 RID: 281353 RVA: 0x010F4104 File Offset: 0x010F2304
		protected override void OnBeforeDestroy()
		{
			this.CleanupRuntimeState();
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
			this.QteConfigs.Clear();
			this.State = QteHourglassView.EHourglassState.Ended;
			this.AutoStartQte = false;
			this.TrailCurveX = null;
			this.TrailCurveY = null;
			this.TrailDuration = 1000f;
			this.DefaultTrailCurveXPath = "";
			this.DefaultTrailCurveYPath = "";
			this.TrailCurveCache.Clear();
			this.FillItem = null;
			this.TrailItem = null;
		}

		// Token: 0x06044B0A RID: 281354 RVA: 0x010F4194 File Offset: 0x010F2394
		protected override void OnTick(float delta)
		{
			if (!this.IsTrailMoving || this.IsFinishing)
			{
				return;
			}
			this.TrailElapsedMs += delta;
			float num = MathUtils.Instance.Clamp(this.TrailElapsedMs / this.TrailDuration, 0f, 1f);
			FloatCurve trailCurveX = this.TrailCurveX;
			float num2 = (trailCurveX != null) ? trailCurveX.GetCurrentValueByTime(num) : num;
			FloatCurve trailCurveY = this.TrailCurveY;
			float num3 = (trailCurveY != null) ? trailCurveY.GetCurrentValueByTime(num) : num;
			this.TrailPos.X = this.TrailStartPos.X + (this.TrailEndPos.X - this.TrailStartPos.X) * (double)num2;
			this.TrailPos.Y = this.TrailStartPos.Y + (this.TrailEndPos.Y - this.TrailStartPos.Y) * (double)num;
			this.TrailPos.Z = this.TrailStartPos.Z + (this.TrailEndPos.Z - this.TrailStartPos.Z) * (double)num3;
			UUIItem trailItem = this.TrailItem;
			FVector fvector = this.TrailPos.ToUeVectorOld();
			trailItem.SetUIWorldLocation(fvector);
			if (num >= 1f)
			{
				this.ResetTrailMove();
				this.PlayPendingPhaseSequence();
			}
		}

		// Token: 0x06044B0B RID: 281355 RVA: 0x010F42CA File Offset: 0x010F24CA
		private void OnStartSequenceFinished(string sequenceName)
		{
			if (this.State != QteHourglassView.EHourglassState.WaitStart)
			{
				return;
			}
			this.State = QteHourglassView.EHourglassState.WaitQte1;
			if (!this.TryConsumeCompletedCurrentQte())
			{
				this.TryAutoStartCurrentQte();
			}
		}

		// Token: 0x06044B0C RID: 281356 RVA: 0x010F42EA File Offset: 0x010F24EA
		private void OnPhaseAFinished(string sequenceName)
		{
			if (this.State != QteHourglassView.EHourglassState.WaitPhaseA)
			{
				return;
			}
			this.State = QteHourglassView.EHourglassState.WaitQte2;
			if (!this.TryConsumeCompletedCurrentQte())
			{
				this.TryAutoStartCurrentQte();
			}
		}

		// Token: 0x06044B0D RID: 281357 RVA: 0x010F430B File Offset: 0x010F250B
		private void OnPhaseBFinished(string sequenceName)
		{
			if (this.State != QteHourglassView.EHourglassState.WaitPhaseB)
			{
				return;
			}
			this.State = QteHourglassView.EHourglassState.WaitQte3;
			if (!this.TryConsumeCompletedCurrentQte())
			{
				this.TryAutoStartCurrentQte();
			}
		}

		// Token: 0x06044B0E RID: 281358 RVA: 0x010F432C File Offset: 0x010F252C
		private void TryAutoStartCurrentQte()
		{
			if (!this.AutoStartQte)
			{
				return;
			}
			this.TryStartCurrentQte();
		}

		// Token: 0x06044B0F RID: 281359 RVA: 0x010F4340 File Offset: 0x010F2540
		private void OnCommonQteEnd(int? handleId)
		{
			if (this.AutoStartQte || this.IsFinishing || handleId == null)
			{
				return;
			}
			CommonQteModel instance = CommonQteModel.Instance;
			CommonQteContextBase commonQteContextBase = (instance != null) ? instance.GetQteContext(handleId.Value) : null;
			if (commonQteContextBase == null)
			{
				return;
			}
			this.NotifyCommonQteCompleted(this.CreateCompletedQteInfo(commonQteContextBase));
		}

		// Token: 0x06044B10 RID: 281360 RVA: 0x010F4394 File Offset: 0x010F2594
		public void NotifyCommonQteCompleted(IQteHourglassCompletedQteInfo completedInfo)
		{
			if (this.AutoStartQte || this.IsFinishing || this.CompletedQteHandleIds.Contains(completedInfo.HandleId))
			{
				return;
			}
			int receivableQteIndex = this.GetReceivableQteIndex(completedInfo.QteId);
			if (receivableQteIndex < 0)
			{
				return;
			}
			this.CompletedQteHandleIds.Add(completedInfo.HandleId);
			this.CompletedQteInfos[receivableQteIndex] = completedInfo;
			this.TryConsumeCompletedCurrentQte();
		}

		// Token: 0x06044B11 RID: 281361 RVA: 0x010F43F9 File Offset: 0x010F25F9
		private void OnPhaseCFinished(string sequenceName)
		{
			if (this.State != QteHourglassView.EHourglassState.WaitPhaseC || this.IsFinishing)
			{
				return;
			}
			this.State = QteHourglassView.EHourglassState.WaitClose;
			this.IsFinishing = true;
			this.LastHide = true;
			base.CloseMe(null);
		}

		// Token: 0x06044B12 RID: 281362 RVA: 0x010F442C File Offset: 0x010F262C
		private void TryStartCurrentQte()
		{
			if (this.IsFinishing)
			{
				return;
			}
			int currentQteIndex = this.GetCurrentQteIndex();
			if (currentQteIndex < 0 || currentQteIndex >= this.QteConfigs.Count)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[QteHourglassView] QTE索引越界";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteIndex", currentQteIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.HandleQteSuccess(null);
				return;
			}
			int qteId = this.QteConfigs[currentQteIndex].QteId;
			CommonQteContextBase commonQteContextBase = CommonQteController.Instance.StartQte(qteId, null, null, EQteSource.Battle, null);
			if (commonQteContextBase == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelPlay;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[QteHourglassView] 启动QTE失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("QteId", qteId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.HandleQteSuccess(null);
				return;
			}
			this.ActiveQteHandleId = commonQteContextBase.HandleId;
		}

		// Token: 0x06044B13 RID: 281363 RVA: 0x010F44F4 File Offset: 0x010F26F4
		private int GetCurrentQteIndex()
		{
			switch (this.State)
			{
			case QteHourglassView.EHourglassState.WaitQte1:
				return 0;
			case QteHourglassView.EHourglassState.WaitQte2:
				return 1;
			case QteHourglassView.EHourglassState.WaitQte3:
				return 2;
			}
			return -1;
		}

		// Token: 0x06044B14 RID: 281364 RVA: 0x010F4530 File Offset: 0x010F2730
		private int GetEarliestReceivableQteIndex()
		{
			switch (this.State)
			{
			case QteHourglassView.EHourglassState.WaitStart:
			case QteHourglassView.EHourglassState.WaitQte1:
				return 0;
			case QteHourglassView.EHourglassState.WaitPhaseA:
			case QteHourglassView.EHourglassState.WaitQte2:
				return 1;
			case QteHourglassView.EHourglassState.WaitPhaseB:
			case QteHourglassView.EHourglassState.WaitQte3:
				return 2;
			default:
				return 3;
			}
		}

		// Token: 0x06044B15 RID: 281365 RVA: 0x010F456C File Offset: 0x010F276C
		private int GetReceivableQteIndex(int qteId)
		{
			int currentQteIndex = this.GetCurrentQteIndex();
			if (currentQteIndex >= 0 && currentQteIndex < this.QteConfigs.Count)
			{
				IQteHourglassConfig qteHourglassConfig = this.QteConfigs[currentQteIndex];
				if (qteHourglassConfig != null && qteHourglassConfig.QteId == qteId)
				{
					return currentQteIndex;
				}
			}
			for (int i = this.GetEarliestReceivableQteIndex(); i < this.QteConfigs.Count; i++)
			{
				if (this.CompletedQteInfos[i] == null)
				{
					IQteHourglassConfig qteHourglassConfig2 = this.QteConfigs[i];
					if (qteHourglassConfig2 != null && qteHourglassConfig2.QteId == qteId)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06044B16 RID: 281366 RVA: 0x010F45F8 File Offset: 0x010F27F8
		private IQteHourglassCompletedQteInfo CreateCompletedQteInfo(CommonQteContextBase context)
		{
			return new QteHourglassCompletedQteInfo
			{
				HandleId = context.HandleId,
				QteId = context.QteId,
				IsSuccess = context.IsSuccess(),
				IsFail = context.IsFail(),
				StartPos = this.GetQteStartPos(context)
			};
		}

		// Token: 0x06044B17 RID: 281367 RVA: 0x010F4648 File Offset: 0x010F2848
		private bool TryConsumeCompletedCurrentQte()
		{
			if (this.IsFinishing)
			{
				return false;
			}
			int currentQteIndex = this.GetCurrentQteIndex();
			if (currentQteIndex < 0)
			{
				return false;
			}
			IQteHourglassCompletedQteInfo qteHourglassCompletedQteInfo = this.CompletedQteInfos[currentQteIndex];
			if (qteHourglassCompletedQteInfo == null)
			{
				return false;
			}
			this.CompletedQteInfos[currentQteIndex] = null;
			this.HandleQteSuccess(qteHourglassCompletedQteInfo);
			return true;
		}

		// Token: 0x06044B18 RID: 281368 RVA: 0x010F468C File Offset: 0x010F288C
		[NullableContext(2)]
		private void HandleQteSuccess(IQteHourglassCompletedQteInfo completedInfo)
		{
			if (this.IsFinishing || completedInfo == null)
			{
				return;
			}
			int currentQteIndex = this.GetCurrentQteIndex();
			IQteHourglassConfig qteHourglassConfig = (currentQteIndex >= 0 && currentQteIndex < this.QteConfigs.Count) ? this.QteConfigs[currentQteIndex] : null;
			if (qteHourglassConfig == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[QteHourglassView] QTE配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteIndex", currentQteIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.AutoStartQte && completedInfo.HandleId != this.ActiveQteHandleId)
			{
				return;
			}
			this.ActiveQteHandleId = 0;
			switch (this.State)
			{
			case QteHourglassView.EHourglassState.WaitQte1:
				this.State = QteHourglassView.EHourglassState.WaitPhaseA;
				this.StartTrailMove(completedInfo.StartPos, "PhaseA", qteHourglassConfig);
				return;
			case QteHourglassView.EHourglassState.WaitPhaseA:
			case QteHourglassView.EHourglassState.WaitPhaseB:
				break;
			case QteHourglassView.EHourglassState.WaitQte2:
				this.State = QteHourglassView.EHourglassState.WaitPhaseB;
				this.StartTrailMove(completedInfo.StartPos, "PhaseB", qteHourglassConfig);
				return;
			case QteHourglassView.EHourglassState.WaitQte3:
				this.State = QteHourglassView.EHourglassState.WaitPhaseC;
				this.StartTrailMove(completedInfo.StartPos, "PhaseC", qteHourglassConfig);
				break;
			default:
				return;
			}
		}

		// Token: 0x06044B19 RID: 281369 RVA: 0x010F4790 File Offset: 0x010F2990
		private void CleanupRuntimeState()
		{
			this.ResetTrailMove();
			if (this.ActiveQteHandleId > 0)
			{
				CommonQteController.Instance.StopQte(this.ActiveQteHandleId);
				this.ActiveQteHandleId = 0;
			}
			this.PendingPhaseSequence = null;
			Array.Clear(this.CompletedQteInfos, 0, this.CompletedQteInfos.Length);
			this.CompletedQteHandleIds.Clear();
		}

		// Token: 0x06044B1A RID: 281370 RVA: 0x010F47EC File Offset: 0x010F29EC
		private void StartTrailMove([Nullable(2)] Vector startPos, string phaseSequence, IQteHourglassConfig qteConfig)
		{
			this.PendingPhaseSequence = phaseSequence;
			if (startPos == null || this.FillItem == null || this.TrailItem == null)
			{
				this.PlayPendingPhaseSequence();
				return;
			}
			this.ResetTrailMove();
			this.TrailStartPos = startPos;
			FVector uiworldPosition = this.FillItem.GetUIWorldPosition();
			this.TrailEndPos.FromUeVector(uiworldPosition);
			this.TrailElapsedMs = 0f;
			this.TrailDuration = ((qteConfig.TrailTime > 0f) ? (qteConfig.TrailTime * 1000f) : 1000f);
			this.TrailCurveX = this.GetLoadedTrailCurve(this.GetTrailCurvePath(qteConfig.TrailCurveX, this.DefaultTrailCurveXPath));
			this.TrailCurveY = this.GetLoadedTrailCurve(this.GetTrailCurvePath(qteConfig.TrailCurveY, this.DefaultTrailCurveYPath));
			this.IsTrailMoving = true;
			UUIItem trailItem = this.TrailItem;
			FVector fvector = this.TrailStartPos.ToUeVectorOld();
			trailItem.SetUIWorldLocation(fvector);
			this.TrailItem.SetUIActive(true);
		}

		// Token: 0x06044B1B RID: 281371 RVA: 0x010F48DC File Offset: 0x010F2ADC
		private void PlayPendingPhaseSequence()
		{
			string pendingPhaseSequence = this.PendingPhaseSequence;
			this.PendingPhaseSequence = null;
			if (pendingPhaseSequence == null || this.IsFinishing)
			{
				return;
			}
			base.PlayOrReplaySequence(pendingPhaseSequence, false, null);
		}

		// Token: 0x06044B1C RID: 281372 RVA: 0x010F4914 File Offset: 0x010F2B14
		private void ResetTrailMove()
		{
			this.IsTrailMoving = false;
			this.TrailElapsedMs = 0f;
			this.TrailDuration = 1000f;
			this.TrailStartPos = null;
			this.TrailCurveX = null;
			this.TrailCurveY = null;
			UUIItem trailItem = this.TrailItem;
			if (trailItem == null)
			{
				return;
			}
			trailItem.SetUIActive(false);
		}

		// Token: 0x06044B1D RID: 281373 RVA: 0x010F4964 File Offset: 0x010F2B64
		private UniTask PreloadTrailCurves()
		{
			QteHourglassView.<PreloadTrailCurves>d__51 <PreloadTrailCurves>d__;
			<PreloadTrailCurves>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadTrailCurves>d__.<>4__this = this;
			<PreloadTrailCurves>d__.<>1__state = -1;
			<PreloadTrailCurves>d__.<>t__builder.Start<QteHourglassView.<PreloadTrailCurves>d__51>(ref <PreloadTrailCurves>d__);
			return <PreloadTrailCurves>d__.<>t__builder.Task;
		}

		// Token: 0x06044B1E RID: 281374 RVA: 0x010F49A7 File Offset: 0x010F2BA7
		private string GetTrailCurvePath([Nullable(2)] string curvePath, string defaultPath)
		{
			if (!StringUtils.IsEmpty(curvePath))
			{
				return curvePath;
			}
			return defaultPath;
		}

		// Token: 0x06044B1F RID: 281375 RVA: 0x010F49B4 File Offset: 0x010F2BB4
		[return: Nullable(2)]
		private FloatCurve GetLoadedTrailCurve(string curvePath)
		{
			FloatCurve result;
			if (curvePath.Length <= 0 || !this.TrailCurveCache.TryGetValue(curvePath, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06044B20 RID: 281376 RVA: 0x010F49E0 File Offset: 0x010F2BE0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<FloatCurve> LoadTrailCurve(string curvePath)
		{
			QteHourglassView.<LoadTrailCurve>d__54 <LoadTrailCurve>d__;
			<LoadTrailCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloatCurve>.Create();
			<LoadTrailCurve>d__.<>4__this = this;
			<LoadTrailCurve>d__.curvePath = curvePath;
			<LoadTrailCurve>d__.<>1__state = -1;
			<LoadTrailCurve>d__.<>t__builder.Start<QteHourglassView.<LoadTrailCurve>d__54>(ref <LoadTrailCurve>d__);
			return <LoadTrailCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06044B21 RID: 281377 RVA: 0x010F4A2C File Offset: 0x010F2C2C
		[return: Nullable(2)]
		private Vector GetQteStartPos(CommonQteContextBase context)
		{
			AActor uiActor = context.UiActor;
			if (uiActor == null)
			{
				return null;
			}
			AUIBaseActor auibaseActor = uiActor as AUIBaseActor;
			UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return Vector.Create(uuiitem.GetUIWorldPosition());
		}

		// Token: 0x04023BB2 RID: 146354
		private const float TIME = 1000f;

		// Token: 0x04023BB3 RID: 146355
		private const int TOTAL_QTE_COUNT = 3;

		// Token: 0x04023BB4 RID: 146356
		private List<IQteHourglassConfig> QteConfigs = new List<IQteHourglassConfig>();

		// Token: 0x04023BB5 RID: 146357
		private int ActiveQteHandleId;

		// Token: 0x04023BB6 RID: 146358
		private QteHourglassView.EHourglassState State;

		// Token: 0x04023BB7 RID: 146359
		private bool IsFinishing;

		// Token: 0x04023BB8 RID: 146360
		private bool AutoStartQte;

		// Token: 0x04023BB9 RID: 146361
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly IQteHourglassCompletedQteInfo[] CompletedQteInfos = new IQteHourglassCompletedQteInfo[3];

		// Token: 0x04023BBA RID: 146362
		private readonly HashSet<int> CompletedQteHandleIds = new HashSet<int>();

		// Token: 0x04023BBB RID: 146363
		[Nullable(2)]
		private UUIItem FillItem;

		// Token: 0x04023BBC RID: 146364
		[Nullable(2)]
		private UUIItem TrailItem;

		// Token: 0x04023BBD RID: 146365
		[Nullable(2)]
		private FloatCurve TrailCurveX;

		// Token: 0x04023BBE RID: 146366
		[Nullable(2)]
		private FloatCurve TrailCurveY;

		// Token: 0x04023BBF RID: 146367
		private float TrailDuration = 1000f;

		// Token: 0x04023BC0 RID: 146368
		private bool IsTrailMoving;

		// Token: 0x04023BC1 RID: 146369
		private float TrailElapsedMs;

		// Token: 0x04023BC2 RID: 146370
		[Nullable(2)]
		private Vector TrailStartPos;

		// Token: 0x04023BC3 RID: 146371
		private readonly Vector TrailEndPos = Vector.Create();

		// Token: 0x04023BC4 RID: 146372
		private readonly Vector TrailPos = Vector.Create();

		// Token: 0x04023BC5 RID: 146373
		[Nullable(2)]
		private string PendingPhaseSequence;

		// Token: 0x04023BC6 RID: 146374
		private string DefaultTrailCurveXPath = "";

		// Token: 0x04023BC7 RID: 146375
		private string DefaultTrailCurveYPath = "";

		// Token: 0x04023BC8 RID: 146376
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private readonly Dictionary<string, FloatCurve> TrailCurveCache = new Dictionary<string, FloatCurve>();

		// Token: 0x0200CCCD RID: 52429
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403DC40 RID: 252992
			Fill,
			// Token: 0x0403DC41 RID: 252993
			Trail
		}

		// Token: 0x0200CCCE RID: 52430
		[NullableContext(0)]
		private enum EHourglassState
		{
			// Token: 0x0403DC43 RID: 252995
			WaitStart,
			// Token: 0x0403DC44 RID: 252996
			WaitQte1,
			// Token: 0x0403DC45 RID: 252997
			WaitPhaseA,
			// Token: 0x0403DC46 RID: 252998
			WaitQte2,
			// Token: 0x0403DC47 RID: 252999
			WaitPhaseB,
			// Token: 0x0403DC48 RID: 253000
			WaitQte3,
			// Token: 0x0403DC49 RID: 253001
			WaitPhaseC,
			// Token: 0x0403DC4A RID: 253002
			WaitClose,
			// Token: 0x0403DC4B RID: 253003
			Ended
		}

		// Token: 0x0200CCCF RID: 52431
		[Nullable(0)]
		private class EHourglassSequence
		{
			// Token: 0x0403DC4C RID: 253004
			public const string PhaseA = "PhaseA";

			// Token: 0x0403DC4D RID: 253005
			public const string PhaseB = "PhaseB";

			// Token: 0x0403DC4E RID: 253006
			public const string PhaseC = "PhaseC";
		}
	}
}
