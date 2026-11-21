using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C17 RID: 23575
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class PianoGameplayController : ControllerBase
	{
		// Token: 0x06039E7F RID: 237183 RVA: 0x010489A0 File Offset: 0x01046BA0
		protected override bool OnInit()
		{
			global::Log.Instance.Info(ELogModule.PianoGameplay, ELogAuthor.FJH, "[PianoGameplayController] 初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			PianoGameplayModel.Instance.LoadPianoGameplaySetting();
			base.PauseTick();
			return true;
		}

		// Token: 0x06039E80 RID: 237184 RVA: 0x010489DC File Offset: 0x01046BDC
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			if (!this.GameplayEntityHandle)
			{
				base.PauseTick();
				return;
			}
			if (this.SplitScreenLogic != null)
			{
				this.SplitScreenLogic.Tick(delta);
			}
			if (this.PianoQteLogic != null)
			{
				this.PianoQteLogic.Tick(delta);
			}
			if (this.CheckInRange())
			{
				this.IsSuccess = true;
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "PianoGameplaySuccess", new Action(this.OnPianoGameplaySuccess), new object[]
				{
					2.0,
					EFadeInScreenShowType.Black
				});
				base.PauseTick();
			}
		}

		// Token: 0x06039E81 RID: 237185 RVA: 0x01048A80 File Offset: 0x01046C80
		[NullableContext(2)]
		public void StartPianoGameplay(int entityId, IPlayPianoGameplay config, Action<bool> onEnd = null)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
			if (!entityByPbDataId || entityByPbDataId.Entity == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[PianoGameplayController] 实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (config == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.PianoGameplay;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[PianoGameplayController] 配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.GameplayEntityHandle = entityByPbDataId;
			this.IsSuccess = false;
			this.OnEndCallback = onEnd;
			PianoGameplayModel.Instance.SetSplineComponent(config.SplineEntityId, entityId);
			PianoGameplayModel.Instance.GameplayStage = EPianoGameplayStage.Practice;
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.PianoGameplayView);
			UiManager.Instance.OpenView(EUiViewName.PianoGameplayView, null, new TOpenViewCallBack(this.StartPianoGameplayInternal));
			if (this.InitExitRangeCheck(config.RangeEntityId))
			{
				this.RangeEntityId = config.RangeEntityId;
			}
			else
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.PianoGameplay;
				ELogAuthor author3 = ELogAuthor.FJH;
				string message3 = "[PianoGameplayController] 范围数据初始化失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("entityId", config.RangeEntityId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			base.ResumeTick();
		}

		// Token: 0x06039E82 RID: 237186 RVA: 0x01048BB0 File Offset: 0x01046DB0
		private void StartPianoGameplayInternal(bool _, int __)
		{
			if (!this.GameplayEntityHandle)
			{
				return;
			}
			SceneItemActorComponent component = this.GameplayEntityHandle.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				return;
			}
			PianoGameplayView pianoGameplayView = UiManager.Instance.GetViewByName(EUiViewName.PianoGameplayView) as PianoGameplayView;
			if (pianoGameplayView == null)
			{
				return;
			}
			AUIContainerActor sceneCaptureViewAttachActor = pianoGameplayView.GetSceneCaptureViewAttachActor();
			if (sceneCaptureViewAttachActor == null)
			{
				return;
			}
			this.SplitScreenLogic.StartSplitScreen(component.ActorTransform, sceneCaptureViewAttachActor);
			pianoGameplayView.RefreshViewportLayout();
			this.PianoSubtitlesLogic.StartGameplay();
			if (PianoGameplayModel.Instance.PianoGameplaySetting.HelpID != 0)
			{
				HelpController.Instance.OpenHelpById(PianoGameplayModel.Instance.PianoGameplaySetting.HelpID);
				EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(PianoGameplayController.<StartPianoGameplayInternal>g__OnCloseHelpInfoView|11_0));
			}
			GameSettingsDeviceRender.Instance.TemporarySetIntCVar("r.AmbientOcclusion.HalfRes", 1);
			GameSettingsDeviceRender.Instance.TemporarySetIntCVar("ShowFlag.DistanceFieldAO", 0);
			GameSettingsDeviceRender.Instance.TemporarySetIntCVar("r.Kuro.SkeletalMesh.LODThrashThreshold", 0);
		}

		// Token: 0x06039E83 RID: 237187 RVA: 0x01048C9A File Offset: 0x01046E9A
		public void RefreshSplitScreenFov(float width, float height)
		{
			this.SplitScreenLogic.RefreshFov(width, height);
		}

		// Token: 0x06039E84 RID: 237188 RVA: 0x01048CAC File Offset: 0x01046EAC
		public void ExitPianoGameplay()
		{
			if (!this.GameplayEntityHandle)
			{
				return;
			}
			this.GameplayEntityHandle = null;
			this.SplitScreenLogic.StopSplitScreen();
			this.PianoQteLogic.ExitPianoQte();
			this.PianoSubtitlesLogic.ExitGameplay();
			base.PauseTick();
			if (this.RangeEntityId != -1)
			{
				this.ExitRangeCheck.Remove(this.RangeEntityId);
				this.RangeEntityId = -1;
			}
			if (this.OnEndCallback != null)
			{
				this.OnEndCallback(this.IsSuccess);
			}
			this.OnEndCallback = null;
			GameSettingsDeviceRender.Instance.TemporaryResetIntCVar("r.AmbientOcclusion.HalfRes");
			GameSettingsDeviceRender.Instance.TemporaryResetIntCVar("ShowFlag.DistanceFieldAO");
			GameSettingsDeviceRender.Instance.TemporaryResetIntCVar("r.Kuro.SkeletalMesh.LODThrashThreshold");
		}

		// Token: 0x06039E85 RID: 237189 RVA: 0x01048D63 File Offset: 0x01046F63
		public void StartPianoQte()
		{
			if (!this.GameplayEntityHandle || this.PianoQteLogic == null)
			{
				return;
			}
			this.PianoQteLogic.EnterPianoQte();
		}

		// Token: 0x06039E86 RID: 237190 RVA: 0x01048D86 File Offset: 0x01046F86
		public void StopPianoQte()
		{
			if (!this.GameplayEntityHandle || this.PianoQteLogic == null)
			{
				return;
			}
			this.PianoQteLogic.ExitPianoQte();
		}

		// Token: 0x06039E87 RID: 237191 RVA: 0x01048DAC File Offset: 0x01046FAC
		public void ExecutePianoSequenceEvent(string key)
		{
			if (!this.GameplayEntityHandle || this.PianoQteLogic == null)
			{
				return;
			}
			if (key == EPianoSequenceKeyType.ShowKey.ToEnumString())
			{
				this.PianoQteLogic.ExecutePianoSequenceEvent(EPianoSequenceKeyType.ShowKey);
				return;
			}
			if (key == EPianoSequenceKeyType.SeqEnd.ToEnumString())
			{
				this.PianoQteLogic.ExecutePianoSequenceEvent(EPianoSequenceKeyType.SeqEnd);
			}
		}

		// Token: 0x06039E88 RID: 237192 RVA: 0x01048E04 File Offset: 0x01047004
		public void OnPianoQteInput(string key)
		{
			if (!this.GameplayEntityHandle || this.PianoQteLogic == null)
			{
				return;
			}
			if (this.PianoQteLogic.IsAutoPlayEnabled)
			{
				return;
			}
			this.PianoQteLogic.OnKeyInput(key);
		}

		// Token: 0x06039E89 RID: 237193 RVA: 0x01048E36 File Offset: 0x01047036
		public void SetPianoAutoPlay(bool enable)
		{
			if (!this.GameplayEntityHandle || this.PianoQteLogic == null)
			{
				return;
			}
			this.PianoQteLogic.SetAutoPlay(enable);
		}

		// Token: 0x06039E8A RID: 237194 RVA: 0x01048E5A File Offset: 0x0104705A
		public bool IsPianoAutoPlayEnabled()
		{
			return !(!this.GameplayEntityHandle) && this.PianoQteLogic != null && this.PianoQteLogic.IsAutoPlayEnabled;
		}

		// Token: 0x06039E8B RID: 237195 RVA: 0x01048E7E File Offset: 0x0104707E
		private bool InitExitRangeCheck(int entityId)
		{
			if (this.ExitRangeCheck == null)
			{
				this.ExitRangeCheck = new RangeCheck();
			}
			return this.ExitRangeCheck.GetOrAdd(entityId) != null;
		}

		// Token: 0x06039E8C RID: 237196 RVA: 0x01048EA2 File Offset: 0x010470A2
		private bool CheckInRange()
		{
			return this.ExitRangeCheck != null && this.RangeEntityId != -1 && this.ExitRangeCheck.CheckReached(new int?(this.RangeEntityId));
		}

		// Token: 0x06039E8D RID: 237197 RVA: 0x01048ECD File Offset: 0x010470CD
		private void OnPianoGameplaySuccess()
		{
			UiManager.Instance.CloseView(EUiViewName.PianoGameplayView, null);
		}

		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x06039E8E RID: 237198 RVA: 0x01048EDF File Offset: 0x010470DF
		public static PianoGameplayController Instance
		{
			get
			{
				return PianoGameplayController._Instance;
			}
		}

		// Token: 0x06039E8F RID: 237199 RVA: 0x01048EE6 File Offset: 0x010470E6
		public static PianoGameplayController GetOrCreateInstance()
		{
			if (PianoGameplayController._Instance == null)
			{
				PianoGameplayController.CreateInstance();
			}
			return PianoGameplayController._Instance;
		}

		// Token: 0x06039E90 RID: 237200 RVA: 0x01048EFA File Offset: 0x010470FA
		public static bool CreateInstance()
		{
			if (PianoGameplayController._Instance != null)
			{
				return true;
			}
			PianoGameplayController._Instance = new PianoGameplayController();
			return true;
		}

		// Token: 0x06039E91 RID: 237201 RVA: 0x01048F10 File Offset: 0x01047110
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039E92 RID: 237202 RVA: 0x01048F12 File Offset: 0x01047112
		public static void ResetStaticDefaultValue()
		{
			PianoGameplayController._Instance = null;
		}

		// Token: 0x06039E93 RID: 237203 RVA: 0x01048F1A File Offset: 0x0104711A
		static PianoGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PianoGameplayController.CreateStaticDefaultValue), new Action(PianoGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x06039E95 RID: 237205 RVA: 0x01048F69 File Offset: 0x01047169
		[CompilerGenerated]
		internal static void <StartPianoGameplayInternal>g__OnCloseHelpInfoView|11_0(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.HelpGuideView)
			{
				return;
			}
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(PianoGameplayController.<StartPianoGameplayInternal>g__OnCloseHelpInfoView|11_0));
		}

		// Token: 0x0401E9A9 RID: 125353
		private readonly PianoSplitScreenLogic SplitScreenLogic = new PianoSplitScreenLogic();

		// Token: 0x0401E9AA RID: 125354
		private readonly PianoQteLogic PianoQteLogic = new PianoQteLogic();

		// Token: 0x0401E9AB RID: 125355
		private readonly PianoSubtitlesLogic PianoSubtitlesLogic = new PianoSubtitlesLogic();

		// Token: 0x0401E9AC RID: 125356
		[Nullable(2)]
		private EntityHandle GameplayEntityHandle;

		// Token: 0x0401E9AD RID: 125357
		private int RangeEntityId = -1;

		// Token: 0x0401E9AE RID: 125358
		[Nullable(2)]
		private RangeCheck ExitRangeCheck;

		// Token: 0x0401E9AF RID: 125359
		private bool IsSuccess;

		// Token: 0x0401E9B0 RID: 125360
		[Nullable(2)]
		private Action<bool> OnEndCallback;

		// Token: 0x0401E9B1 RID: 125361
		[Nullable(2)]
		private static PianoGameplayController _Instance;
	}
}
