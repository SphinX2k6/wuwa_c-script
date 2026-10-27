using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DFB RID: 28155
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QteHourglassModel : ModelBase
	{
		// Token: 0x06044AE6 RID: 281318 RVA: 0x010F3A2C File Offset: 0x010F1C2C
		public void OpenGameplay(IQteHourglass config)
		{
			this.CloseGameplay();
			this.IsActive = true;
			this.OpenToken++;
			int openToken = this.OpenToken;
			this.RefreshGameplayQteIds(config);
			this.StartListen();
			HourglassOpenParam param = new HourglassOpenParam
			{
				Config = config,
				AutoStartQte = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.QteHourglassView, param, delegate(bool success, int viewId)
			{
				if (this.OpenToken != openToken || !this.IsActive)
				{
					if (success && UiManager.Instance.IsViewOpen(EUiViewName.QteHourglassView))
					{
						UiManager.Instance.CloseView(EUiViewName.QteHourglassView, null);
					}
					return;
				}
				if (!success)
				{
					global::Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.FZX, "[QteHourglassModel] 打开界面失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.StopListen();
					this.ResetRuntimeState();
					return;
				}
				this.BoundView = (UiManager.Instance.GetView(viewId) as QteHourglassView);
				this.FlushCompletedQteInfos();
			});
		}

		// Token: 0x06044AE7 RID: 281319 RVA: 0x010F3AAF File Offset: 0x010F1CAF
		public void CloseGameplay()
		{
			bool flag = UiManager.Instance.IsViewOpen(EUiViewName.QteHourglassView);
			this.OpenToken++;
			this.StopListen();
			this.ResetRuntimeState();
			if (flag)
			{
				UiManager.Instance.CloseView(EUiViewName.QteHourglassView, null);
			}
		}

		// Token: 0x06044AE8 RID: 281320 RVA: 0x010F3AEC File Offset: 0x010F1CEC
		protected override bool OnClear()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x06044AE9 RID: 281321 RVA: 0x010F3AF5 File Offset: 0x010F1CF5
		protected override bool OnLeaveLevel()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x06044AEA RID: 281322 RVA: 0x010F3AFE File Offset: 0x010F1CFE
		protected override bool OnChangeMode()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x06044AEB RID: 281323 RVA: 0x010F3B08 File Offset: 0x010F1D08
		private void StartListen()
		{
			if (!EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
			{
				EventSystem.Instance.Add<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
			}
			if (!EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
			{
				EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			}
		}

		// Token: 0x06044AEC RID: 281324 RVA: 0x010F3B84 File Offset: 0x010F1D84
		private void StopListen()
		{
			if (EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
			{
				EventSystem.Instance.Remove<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
			}
			if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
			{
				EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			}
		}

		// Token: 0x06044AED RID: 281325 RVA: 0x010F3C00 File Offset: 0x010F1E00
		private void RefreshGameplayQteIds(IQteHourglass config)
		{
			this.GameplayQteIds.Clear();
			if (config.QteConfigs == null)
			{
				return;
			}
			foreach (IQteHourglassConfig qteHourglassConfig in config.QteConfigs)
			{
				this.GameplayQteIds.Add(qteHourglassConfig.QteId);
			}
		}

		// Token: 0x06044AEE RID: 281326 RVA: 0x010F3C74 File Offset: 0x010F1E74
		private void OnCommonQteEnd(int? handleId)
		{
			if (!this.IsActive || handleId == null || this.CompletedQteHandleIds.Contains(handleId.Value))
			{
				return;
			}
			CommonQteModel instance = CommonQteModel.Instance;
			CommonQteContextBase commonQteContextBase = (instance != null) ? instance.GetQteContext(handleId.Value) : null;
			if (commonQteContextBase == null)
			{
				return;
			}
			if (!this.GameplayQteIds.Contains(commonQteContextBase.QteId))
			{
				return;
			}
			IQteHourglassCompletedQteInfo qteHourglassCompletedQteInfo = this.CreateCompletedQteInfo(commonQteContextBase);
			this.CompletedQteHandleIds.Add(handleId.Value);
			this.CompletedQteInfos.Add(qteHourglassCompletedQteInfo);
			QteHourglassView boundView = this.BoundView;
			if (boundView == null)
			{
				return;
			}
			boundView.NotifyCommonQteCompleted(qteHourglassCompletedQteInfo);
		}

		// Token: 0x06044AEF RID: 281327 RVA: 0x010F3D10 File Offset: 0x010F1F10
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.QteHourglassView || !this.IsActive)
			{
				return;
			}
			this.OpenToken++;
			this.StopListen();
			this.ResetRuntimeState();
		}

		// Token: 0x06044AF0 RID: 281328 RVA: 0x010F3D44 File Offset: 0x010F1F44
		private void FlushCompletedQteInfos()
		{
			foreach (IQteHourglassCompletedQteInfo completedInfo in this.CompletedQteInfos)
			{
				QteHourglassView boundView = this.BoundView;
				if (boundView != null)
				{
					boundView.NotifyCommonQteCompleted(completedInfo);
				}
			}
		}

		// Token: 0x06044AF1 RID: 281329 RVA: 0x010F3DA4 File Offset: 0x010F1FA4
		private void ResetRuntimeState()
		{
			this.BoundView = null;
			this.IsActive = false;
			this.GameplayQteIds.Clear();
			this.CompletedQteInfos.Clear();
			this.CompletedQteHandleIds.Clear();
		}

		// Token: 0x06044AF2 RID: 281330 RVA: 0x010F3DD8 File Offset: 0x010F1FD8
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

		// Token: 0x06044AF3 RID: 281331 RVA: 0x010F3E28 File Offset: 0x010F2028
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

		// Token: 0x170099E5 RID: 39397
		// (get) Token: 0x06044AF4 RID: 281332 RVA: 0x010F3E69 File Offset: 0x010F2069
		public static QteHourglassModel Instance
		{
			get
			{
				return QteHourglassModel._Instance;
			}
		}

		// Token: 0x06044AF5 RID: 281333 RVA: 0x010F3E70 File Offset: 0x010F2070
		public static QteHourglassModel GetOrCreateInstance()
		{
			if (QteHourglassModel._Instance == null)
			{
				QteHourglassModel.CreateInstance();
			}
			return QteHourglassModel._Instance;
		}

		// Token: 0x06044AF6 RID: 281334 RVA: 0x010F3E84 File Offset: 0x010F2084
		public static bool CreateInstance()
		{
			if (QteHourglassModel._Instance != null)
			{
				return true;
			}
			QteHourglassModel._Instance = new QteHourglassModel();
			return true;
		}

		// Token: 0x06044AF7 RID: 281335 RVA: 0x010F3E9A File Offset: 0x010F209A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044AF8 RID: 281336 RVA: 0x010F3E9C File Offset: 0x010F209C
		public static void ResetStaticDefaultValue()
		{
			QteHourglassModel._Instance = null;
		}

		// Token: 0x06044AF9 RID: 281337 RVA: 0x010F3EA4 File Offset: 0x010F20A4
		static QteHourglassModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QteHourglassModel.CreateStaticDefaultValue), new Action(QteHourglassModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023BA9 RID: 146345
		[Nullable(2)]
		private QteHourglassView BoundView;

		// Token: 0x04023BAA RID: 146346
		private bool IsActive;

		// Token: 0x04023BAB RID: 146347
		private int OpenToken;

		// Token: 0x04023BAC RID: 146348
		private readonly HashSet<int> GameplayQteIds = new HashSet<int>();

		// Token: 0x04023BAD RID: 146349
		private readonly List<IQteHourglassCompletedQteInfo> CompletedQteInfos = new List<IQteHourglassCompletedQteInfo>();

		// Token: 0x04023BAE RID: 146350
		private readonly HashSet<int> CompletedQteHandleIds = new HashSet<int>();

		// Token: 0x04023BAF RID: 146351
		[Nullable(2)]
		private static QteHourglassModel _Instance;
	}
}
