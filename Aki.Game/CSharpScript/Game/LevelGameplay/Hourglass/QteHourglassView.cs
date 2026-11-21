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
	// Token: 0x02005F7D RID: 24445
	[NullableContext(1)]
	[Nullable(0)]
	public class QteHourglassView : UiTickViewBase
	{
		// Token: 0x0603AC68 RID: 240744 RVA: 0x0109E1E0 File Offset: 0x0109C3E0
		public QteHourglassView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AC69 RID: 240745 RVA: 0x0109E258 File Offset: 0x0109C458
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603AC6A RID: 240746 RVA: 0x0109E294 File Offset: 0x0109C494
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

		// Token: 0x0603AC6B RID: 240747 RVA: 0x0109E368 File Offset: 0x0109C568
		protected override UniTask OnCreateAsync()
		{
			QteHourglassView.<OnCreateAsync>d__29 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<QteHourglassView.<OnCreateAsync>d__29>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC6C RID: 240748 RVA: 0x0109E3AB File Offset: 0x0109C5AB
		protected override void OnBeforeHide()
		{
			this.CleanupRuntimeState();
			if (!this.LastHide)
			{
				this.LastHide = true;
				base.CloseMe(null);
			}
		}

		// Token: 0x0603AC6D RID: 240749 RVA: 0x0109E3CC File Offset: 0x0109C5CC
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

		// Token: 0x0603AC6E RID: 240750 RVA: 0x0109E45C File Offset: 0x0109C65C
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

		// Token: 0x0603AC6F RID: 240751 RVA: 0x0109E592 File Offset: 0x0109C792
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

		// Token: 0x0603AC70 RID: 240752 RVA: 0x0109E5B2 File Offset: 0x0109C7B2
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

		// Token: 0x0603AC71 RID: 240753 RVA: 0x0109E5D3 File Offset: 0x0109C7D3
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

		// Token: 0x0603AC72 RID: 240754 RVA: 0x0109E5F4 File Offset: 0x0109C7F4
		private void TryAutoStartCurrentQte()
		{
			if (!this.AutoStartQte)
			{
				return;
			}
			this.TryStartCurrentQte();
		}

		// Token: 0x0603AC73 RID: 240755 RVA: 0x0109E608 File Offset: 0x0109C808
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

		// Token: 0x0603AC74 RID: 240756 RVA: 0x0109E65C File Offset: 0x0109C85C
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

		// Token: 0x0603AC75 RID: 240757 RVA: 0x0109E6C1 File Offset: 0x0109C8C1
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

		// Token: 0x0603AC76 RID: 240758 RVA: 0x0109E6F4 File Offset: 0x0109C8F4
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

		// Token: 0x0603AC77 RID: 240759 RVA: 0x0109E7BC File Offset: 0x0109C9BC
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

		// Token: 0x0603AC78 RID: 240760 RVA: 0x0109E7F8 File Offset: 0x0109C9F8
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

		// Token: 0x0603AC79 RID: 240761 RVA: 0x0109E834 File Offset: 0x0109CA34
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

		// Token: 0x0603AC7A RID: 240762 RVA: 0x0109E8C0 File Offset: 0x0109CAC0
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

		// Token: 0x0603AC7B RID: 240763 RVA: 0x0109E910 File Offset: 0x0109CB10
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

		// Token: 0x0603AC7C RID: 240764 RVA: 0x0109E954 File Offset: 0x0109CB54
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

		// Token: 0x0603AC7D RID: 240765 RVA: 0x0109EA58 File Offset: 0x0109CC58
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

		// Token: 0x0603AC7E RID: 240766 RVA: 0x0109EAB4 File Offset: 0x0109CCB4
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

		// Token: 0x0603AC7F RID: 240767 RVA: 0x0109EBA4 File Offset: 0x0109CDA4
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

		// Token: 0x0603AC80 RID: 240768 RVA: 0x0109EBDC File Offset: 0x0109CDDC
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

		// Token: 0x0603AC81 RID: 240769 RVA: 0x0109EC2C File Offset: 0x0109CE2C
		private UniTask PreloadTrailCurves()
		{
			QteHourglassView.<PreloadTrailCurves>d__51 <PreloadTrailCurves>d__;
			<PreloadTrailCurves>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadTrailCurves>d__.<>4__this = this;
			<PreloadTrailCurves>d__.<>1__state = -1;
			<PreloadTrailCurves>d__.<>t__builder.Start<QteHourglassView.<PreloadTrailCurves>d__51>(ref <PreloadTrailCurves>d__);
			return <PreloadTrailCurves>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC82 RID: 240770 RVA: 0x0109EC6F File Offset: 0x0109CE6F
		private string GetTrailCurvePath([Nullable(2)] string curvePath, string defaultPath)
		{
			if (!StringUtils.IsEmpty(curvePath))
			{
				return curvePath;
			}
			return defaultPath;
		}

		// Token: 0x0603AC83 RID: 240771 RVA: 0x0109EC7C File Offset: 0x0109CE7C
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

		// Token: 0x0603AC84 RID: 240772 RVA: 0x0109ECA8 File Offset: 0x0109CEA8
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

		// Token: 0x0603AC85 RID: 240773 RVA: 0x0109ECF4 File Offset: 0x0109CEF4
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

		// Token: 0x0401EE54 RID: 126548
		private const float TIME = 1000f;

		// Token: 0x0401EE55 RID: 126549
		private const int TOTAL_QTE_COUNT = 3;

		// Token: 0x0401EE56 RID: 126550
		private List<IQteHourglassConfig> QteConfigs = new List<IQteHourglassConfig>();

		// Token: 0x0401EE57 RID: 126551
		private int ActiveQteHandleId;

		// Token: 0x0401EE58 RID: 126552
		private QteHourglassView.EHourglassState State;

		// Token: 0x0401EE59 RID: 126553
		private bool IsFinishing;

		// Token: 0x0401EE5A RID: 126554
		private bool AutoStartQte;

		// Token: 0x0401EE5B RID: 126555
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly IQteHourglassCompletedQteInfo[] CompletedQteInfos = new IQteHourglassCompletedQteInfo[3];

		// Token: 0x0401EE5C RID: 126556
		private readonly HashSet<int> CompletedQteHandleIds = new HashSet<int>();

		// Token: 0x0401EE5D RID: 126557
		[Nullable(2)]
		private UUIItem FillItem;

		// Token: 0x0401EE5E RID: 126558
		[Nullable(2)]
		private UUIItem TrailItem;

		// Token: 0x0401EE5F RID: 126559
		[Nullable(2)]
		private FloatCurve TrailCurveX;

		// Token: 0x0401EE60 RID: 126560
		[Nullable(2)]
		private FloatCurve TrailCurveY;

		// Token: 0x0401EE61 RID: 126561
		private float TrailDuration = 1000f;

		// Token: 0x0401EE62 RID: 126562
		private bool IsTrailMoving;

		// Token: 0x0401EE63 RID: 126563
		private float TrailElapsedMs;

		// Token: 0x0401EE64 RID: 126564
		[Nullable(2)]
		private Vector TrailStartPos;

		// Token: 0x0401EE65 RID: 126565
		private readonly Vector TrailEndPos = Vector.Create();

		// Token: 0x0401EE66 RID: 126566
		private readonly Vector TrailPos = Vector.Create();

		// Token: 0x0401EE67 RID: 126567
		[Nullable(2)]
		private string PendingPhaseSequence;

		// Token: 0x0401EE68 RID: 126568
		private string DefaultTrailCurveXPath = "";

		// Token: 0x0401EE69 RID: 126569
		private string DefaultTrailCurveYPath = "";

		// Token: 0x0401EE6A RID: 126570
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private readonly Dictionary<string, FloatCurve> TrailCurveCache = new Dictionary<string, FloatCurve>();

		// Token: 0x0200B8BD RID: 47293
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04039062 RID: 233570
			Fill,
			// Token: 0x04039063 RID: 233571
			Trail
		}

		// Token: 0x0200B8BE RID: 47294
		[NullableContext(0)]
		private enum EHourglassState
		{
			// Token: 0x04039065 RID: 233573
			WaitStart,
			// Token: 0x04039066 RID: 233574
			WaitQte1,
			// Token: 0x04039067 RID: 233575
			WaitPhaseA,
			// Token: 0x04039068 RID: 233576
			WaitQte2,
			// Token: 0x04039069 RID: 233577
			WaitPhaseB,
			// Token: 0x0403906A RID: 233578
			WaitQte3,
			// Token: 0x0403906B RID: 233579
			WaitPhaseC,
			// Token: 0x0403906C RID: 233580
			WaitClose,
			// Token: 0x0403906D RID: 233581
			Ended
		}

		// Token: 0x0200B8BF RID: 47295
		[Nullable(0)]
		private class EHourglassSequence
		{
			// Token: 0x0403906E RID: 233582
			public const string PhaseA = "PhaseA";

			// Token: 0x0403906F RID: 233583
			public const string PhaseB = "PhaseB";

			// Token: 0x04039070 RID: 233584
			public const string PhaseC = "PhaseC";
		}
	}
}
