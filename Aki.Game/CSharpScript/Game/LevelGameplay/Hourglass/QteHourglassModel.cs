using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02005F7A RID: 24442
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QteHourglassModel : ModelBase
	{
		// Token: 0x0603AC4A RID: 240714 RVA: 0x0109DCF4 File Offset: 0x0109BEF4
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

		// Token: 0x0603AC4B RID: 240715 RVA: 0x0109DD77 File Offset: 0x0109BF77
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

		// Token: 0x0603AC4C RID: 240716 RVA: 0x0109DDB4 File Offset: 0x0109BFB4
		protected override bool OnClear()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x0603AC4D RID: 240717 RVA: 0x0109DDBD File Offset: 0x0109BFBD
		protected override bool OnLeaveLevel()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x0603AC4E RID: 240718 RVA: 0x0109DDC6 File Offset: 0x0109BFC6
		protected override bool OnChangeMode()
		{
			this.CloseGameplay();
			return true;
		}

		// Token: 0x0603AC4F RID: 240719 RVA: 0x0109DDD0 File Offset: 0x0109BFD0
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

		// Token: 0x0603AC50 RID: 240720 RVA: 0x0109DE4C File Offset: 0x0109C04C
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

		// Token: 0x0603AC51 RID: 240721 RVA: 0x0109DEC8 File Offset: 0x0109C0C8
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

		// Token: 0x0603AC52 RID: 240722 RVA: 0x0109DF3C File Offset: 0x0109C13C
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

		// Token: 0x0603AC53 RID: 240723 RVA: 0x0109DFD8 File Offset: 0x0109C1D8
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

		// Token: 0x0603AC54 RID: 240724 RVA: 0x0109E00C File Offset: 0x0109C20C
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

		// Token: 0x0603AC55 RID: 240725 RVA: 0x0109E06C File Offset: 0x0109C26C
		private void ResetRuntimeState()
		{
			this.BoundView = null;
			this.IsActive = false;
			this.GameplayQteIds.Clear();
			this.CompletedQteInfos.Clear();
			this.CompletedQteHandleIds.Clear();
		}

		// Token: 0x0603AC56 RID: 240726 RVA: 0x0109E0A0 File Offset: 0x0109C2A0
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

		// Token: 0x0603AC57 RID: 240727 RVA: 0x0109E0F0 File Offset: 0x0109C2F0
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

		// Token: 0x17006EE8 RID: 28392
		// (get) Token: 0x0603AC58 RID: 240728 RVA: 0x0109E131 File Offset: 0x0109C331
		public static QteHourglassModel Instance
		{
			get
			{
				return QteHourglassModel._Instance;
			}
		}

		// Token: 0x0603AC59 RID: 240729 RVA: 0x0109E138 File Offset: 0x0109C338
		public static QteHourglassModel GetOrCreateInstance()
		{
			if (QteHourglassModel._Instance == null)
			{
				QteHourglassModel.CreateInstance();
			}
			return QteHourglassModel._Instance;
		}

		// Token: 0x0603AC5A RID: 240730 RVA: 0x0109E14C File Offset: 0x0109C34C
		public static bool CreateInstance()
		{
			if (QteHourglassModel._Instance != null)
			{
				return true;
			}
			QteHourglassModel._Instance = new QteHourglassModel();
			return true;
		}

		// Token: 0x0603AC5B RID: 240731 RVA: 0x0109E162 File Offset: 0x0109C362
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AC5C RID: 240732 RVA: 0x0109E164 File Offset: 0x0109C364
		public static void ResetStaticDefaultValue()
		{
			QteHourglassModel._Instance = null;
		}

		// Token: 0x0603AC5D RID: 240733 RVA: 0x0109E16C File Offset: 0x0109C36C
		static QteHourglassModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QteHourglassModel.CreateStaticDefaultValue), new Action(QteHourglassModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE4B RID: 126539
		[Nullable(2)]
		private QteHourglassView BoundView;

		// Token: 0x0401EE4C RID: 126540
		private bool IsActive;

		// Token: 0x0401EE4D RID: 126541
		private int OpenToken;

		// Token: 0x0401EE4E RID: 126542
		private readonly HashSet<int> GameplayQteIds = new HashSet<int>();

		// Token: 0x0401EE4F RID: 126543
		private readonly List<IQteHourglassCompletedQteInfo> CompletedQteInfos = new List<IQteHourglassCompletedQteInfo>();

		// Token: 0x0401EE50 RID: 126544
		private readonly HashSet<int> CompletedQteHandleIds = new HashSet<int>();

		// Token: 0x0401EE51 RID: 126545
		[Nullable(2)]
		private static QteHourglassModel _Instance;
	}
}
