using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SeamlessTravel;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B6F RID: 19311
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportContext : ITeleportContext, IStaticVariableResetter
	{
		// Token: 0x17007C03 RID: 31747
		// (get) Token: 0x06032032 RID: 204850 RVA: 0x00B9C087 File Offset: 0x00B9A287
		// (set) Token: 0x06032033 RID: 204851 RVA: 0x00B9C08F File Offset: 0x00B9A28F
		[Nullable(1)]
		public string ClientReason { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007C04 RID: 31748
		// (get) Token: 0x06032034 RID: 204852 RVA: 0x00B9C098 File Offset: 0x00B9A298
		// (set) Token: 0x06032035 RID: 204853 RVA: 0x00B9C0A0 File Offset: 0x00B9A2A0
		public FVectorDouble TargetPosition { get; set; }

		// Token: 0x17007C05 RID: 31749
		// (get) Token: 0x06032036 RID: 204854 RVA: 0x00B9C0A9 File Offset: 0x00B9A2A9
		// (set) Token: 0x06032037 RID: 204855 RVA: 0x00B9C0B1 File Offset: 0x00B9A2B1
		public ETeleportMode? TeleportMode { get; set; }

		// Token: 0x17007C06 RID: 31750
		// (get) Token: 0x06032038 RID: 204856 RVA: 0x00B9C0BA File Offset: 0x00B9A2BA
		// (set) Token: 0x06032039 RID: 204857 RVA: 0x00B9C0C2 File Offset: 0x00B9A2C2
		public IRotator TargetRotation { get; set; }

		// Token: 0x17007C07 RID: 31751
		// (get) Token: 0x0603203A RID: 204858 RVA: 0x00B9C0CB File Offset: 0x00B9A2CB
		// (set) Token: 0x0603203B RID: 204859 RVA: 0x00B9C0D3 File Offset: 0x00B9A2D3
		public IVector TargetGravityDirect { get; set; }

		// Token: 0x17007C08 RID: 31752
		// (get) Token: 0x0603203C RID: 204860 RVA: 0x00B9C0DC File Offset: 0x00B9A2DC
		// (set) Token: 0x0603203D RID: 204861 RVA: 0x00B9C0E4 File Offset: 0x00B9A2E4
		public IVector TargetSpeed { get; set; }

		// Token: 0x17007C09 RID: 31753
		// (get) Token: 0x0603203E RID: 204862 RVA: 0x00B9C0ED File Offset: 0x00B9A2ED
		// (set) Token: 0x0603203F RID: 204863 RVA: 0x00B9C0F5 File Offset: 0x00B9A2F5
		public TeleportReason? ServerReason { get; set; }

		// Token: 0x17007C0A RID: 31754
		// (get) Token: 0x06032040 RID: 204864 RVA: 0x00B9C0FE File Offset: 0x00B9A2FE
		// (set) Token: 0x06032041 RID: 204865 RVA: 0x00B9C106 File Offset: 0x00B9A306
		public TransitionOptionPb Option { get; set; }

		// Token: 0x17007C0B RID: 31755
		// (get) Token: 0x06032042 RID: 204866 RVA: 0x00B9C10F File Offset: 0x00B9A30F
		// (set) Token: 0x06032043 RID: 204867 RVA: 0x00B9C117 File Offset: 0x00B9A317
		public int? TransitionConfigId { get; set; }

		// Token: 0x17007C0C RID: 31756
		// (get) Token: 0x06032044 RID: 204868 RVA: 0x00B9C120 File Offset: 0x00B9A320
		// (set) Token: 0x06032045 RID: 204869 RVA: 0x00B9C128 File Offset: 0x00B9A328
		public ITeleportTransitionType TransitionConfig { get; set; }

		// Token: 0x17007C0D RID: 31757
		// (get) Token: 0x06032046 RID: 204870 RVA: 0x00B9C131 File Offset: 0x00B9A331
		// (set) Token: 0x06032047 RID: 204871 RVA: 0x00B9C139 File Offset: 0x00B9A339
		public bool? NeedRestoreCamera { get; set; } = new bool?(true);

		// Token: 0x17007C0E RID: 31758
		// (get) Token: 0x06032048 RID: 204872 RVA: 0x00B9C142 File Offset: 0x00B9A342
		// (set) Token: 0x06032049 RID: 204873 RVA: 0x00B9C14A File Offset: 0x00B9A34A
		public GameCtxPb GameCtx { get; set; }

		// Token: 0x17007C0F RID: 31759
		// (get) Token: 0x0603204A RID: 204874 RVA: 0x00B9C153 File Offset: 0x00B9A353
		// (set) Token: 0x0603204B RID: 204875 RVA: 0x00B9C15B File Offset: 0x00B9A35B
		public Entity ElevatorEntity { get; set; }

		// Token: 0x17007C10 RID: 31760
		// (get) Token: 0x0603204C RID: 204876 RVA: 0x00B9C164 File Offset: 0x00B9A364
		// (set) Token: 0x0603204D RID: 204877 RVA: 0x00B9C16C File Offset: 0x00B9A36C
		public bool? DisableAutoFade { get; set; } = new bool?(false);

		// Token: 0x17007C11 RID: 31761
		// (get) Token: 0x0603204E RID: 204878 RVA: 0x00B9C175 File Offset: 0x00B9A375
		// (set) Token: 0x0603204F RID: 204879 RVA: 0x00B9C17D File Offset: 0x00B9A37D
		public int? TeleportCfgId { get; set; }

		// Token: 0x17007C12 RID: 31762
		// (get) Token: 0x06032050 RID: 204880 RVA: 0x00B9C186 File Offset: 0x00B9A386
		// (set) Token: 0x06032051 RID: 204881 RVA: 0x00B9C18E File Offset: 0x00B9A38E
		public bool? NeedRequestToServer { get; set; } = new bool?(true);

		// Token: 0x17007C13 RID: 31763
		// (get) Token: 0x06032052 RID: 204882 RVA: 0x00B9C197 File Offset: 0x00B9A397
		// (set) Token: 0x06032053 RID: 204883 RVA: 0x00B9C19F File Offset: 0x00B9A39F
		public bool? NeedWaitStreaming { get; set; } = new bool?(true);

		// Token: 0x17007C14 RID: 31764
		// (get) Token: 0x06032054 RID: 204884 RVA: 0x00B9C1A8 File Offset: 0x00B9A3A8
		// (set) Token: 0x06032055 RID: 204885 RVA: 0x00B9C1B0 File Offset: 0x00B9A3B0
		public bool? KeepCameraRelativeRotation { get; set; } = new bool?(false);

		// Token: 0x17007C15 RID: 31765
		// (get) Token: 0x06032056 RID: 204886 RVA: 0x00B9C1B9 File Offset: 0x00B9A3B9
		// (set) Token: 0x06032057 RID: 204887 RVA: 0x00B9C1C1 File Offset: 0x00B9A3C1
		public bool? KeepSpeedRelativeRotation { get; set; } = new bool?(false);

		// Token: 0x17007C16 RID: 31766
		// (get) Token: 0x06032058 RID: 204888 RVA: 0x00B9C1CA File Offset: 0x00B9A3CA
		// (set) Token: 0x06032059 RID: 204889 RVA: 0x00B9C1D2 File Offset: 0x00B9A3D2
		public bool? UseCameraCutForMotionBlur { get; set; } = new bool?(false);

		// Token: 0x17007C17 RID: 31767
		// (get) Token: 0x0603205A RID: 204890 RVA: 0x00B9C1DB File Offset: 0x00B9A3DB
		public GameModePromise StreamingCompleted
		{
			get
			{
				return this.StreamingCompletedInternal;
			}
		}

		// Token: 0x17007C18 RID: 31768
		// (get) Token: 0x0603205B RID: 204891 RVA: 0x00B9C1E3 File Offset: 0x00B9A3E3
		public GameModePromise VoxelStreamingCompleted
		{
			get
			{
				return this.VoxelStreamingCompletedInternal;
			}
		}

		// Token: 0x17007C19 RID: 31769
		// (get) Token: 0x0603205C RID: 204892 RVA: 0x00B9C1EB File Offset: 0x00B9A3EB
		public GameModePromise TeleportFinishRequest
		{
			get
			{
				return this.TeleportFinishRequestInternal;
			}
		}

		// Token: 0x17007C1A RID: 31770
		// (get) Token: 0x0603205D RID: 204893 RVA: 0x00B9C1F3 File Offset: 0x00B9A3F3
		public GameModePromise CgTeleportCompleted
		{
			get
			{
				return this.CgTeleportCompletedInternal;
			}
		}

		// Token: 0x17007C1B RID: 31771
		// (get) Token: 0x0603205E RID: 204894 RVA: 0x00B9C1FB File Offset: 0x00B9A3FB
		public GameModePromise TeleportWaitRequest
		{
			get
			{
				return this.TeleportWaitRequestInternal;
			}
		}

		// Token: 0x0603205F RID: 204895 RVA: 0x00B9C204 File Offset: 0x00B9A404
		[NullableContext(1)]
		public TeleportContext(ITeleportContext contextParams)
		{
			this.ClientReason = contextParams.ClientReason;
			this.TargetPosition = contextParams.TargetPosition;
			this.TeleportMode = new ETeleportMode?(contextParams.TeleportMode.GetValueOrDefault(ETeleportMode.Auto));
			this.TargetRotation = contextParams.TargetRotation;
			this.TargetGravityDirect = contextParams.TargetGravityDirect;
			this.TargetSpeed = contextParams.TargetSpeed;
			this.ServerReason = contextParams.ServerReason;
			this.Option = contextParams.Option;
			this.TransitionConfigId = contextParams.TransitionConfigId;
			ITeleportTransitionType transitionConfig;
			if (this.TransitionConfigId != null)
			{
				int? transitionConfigId = this.TransitionConfigId;
				int num = 0;
				if (transitionConfigId.GetValueOrDefault() > num & transitionConfigId != null)
				{
					transitionConfig = TeleportModel.Instance.ParseTransitionConfig(this.TransitionConfigId.Value);
					goto IL_129;
				}
			}
			transitionConfig = null;
			IL_129:
			this.TransitionConfig = transitionConfig;
			this.TeleportCfgId = contextParams.TeleportCfgId;
			this.GameCtx = contextParams.GameCtx;
			if (contextParams.NeedRestoreCamera.GetValueOrDefault())
			{
				this.NeedRestoreCamera = contextParams.NeedRestoreCamera;
			}
			ITeleportTransitionType transitionConfig2 = this.TransitionConfig;
			if (transitionConfig2 != null && transitionConfig2.Type == ETeleportTransitionType.Seamless)
			{
				this.SeamlessConfig = new SeamlessTravelContext();
				this.SeamlessConfig.ParseParamsByConfig(this.TransitionConfig as ITeleportTransitionInSeamlessType);
				this.ForceInGameLoadMode = (this.TransitionConfig as ITeleportTransitionInSeamlessType).IsNormalStreamingLoad.GetValueOrDefault();
				this.Seamless = new bool?(true);
			}
			else
			{
				TransitionOptionPb option = contextParams.Option;
				if (((option != null) ? option.TransitionInSeamless : null) != null)
				{
					this.SeamlessConfig = new SeamlessTravelContext();
					this.SeamlessConfig.ParseParamsByProto(this.Option.TransitionInSeamless);
					this.ForceInGameLoadMode = this.Option.TransitionInSeamless.NormalStreamingLoad;
					this.Seamless = new bool?(true);
				}
			}
			if (contextParams.NeedRequestToServer != null)
			{
				this.NeedRequestToServer = contextParams.NeedRequestToServer;
			}
			if (contextParams.NeedWaitStreaming != null)
			{
				this.NeedWaitStreaming = contextParams.NeedWaitStreaming;
			}
			if (contextParams.DisableAutoFade != null)
			{
				this.DisableAutoFade = contextParams.DisableAutoFade;
			}
			if (contextParams.KeepCameraRelativeRotation != null)
			{
				this.KeepCameraRelativeRotation = contextParams.KeepCameraRelativeRotation;
			}
			if (contextParams.KeepSpeedRelativeRotation != null)
			{
				this.KeepSpeedRelativeRotation = contextParams.KeepSpeedRelativeRotation;
			}
			if (contextParams.UseCameraCutForMotionBlur != null)
			{
				this.UseCameraCutForMotionBlur = contextParams.UseCameraCutForMotionBlur;
			}
			if (contextParams.ElevatorEntity != null)
			{
				this.ElevatorEntity = contextParams.ElevatorEntity;
			}
			this.StreamingCompletedInternal = new GameModePromise();
			this.VoxelStreamingCompletedInternal = new GameModePromise();
			this.TeleportFinishRequestInternal = new GameModePromise();
			this.CgTeleportCompletedInternal = new GameModePromise();
			this.TeleportWaitRequestInternal = new GameModePromise();
			this.TeleportCore = new TeleportCore(this);
			this.TeleportTransitionHelper = new TeleportTransitionHelper(this);
			this.TeleportStreamingHelper = new TeleportStreamingHelper(this);
			if (this.Seamless.GetValueOrDefault())
			{
				this.TeleportSeamlessHelper = new TeleportSeamlessHelper(this);
				if (this.KeepCameraRelativeRotation != null)
				{
					this.KeepCameraRelativeRotation = new bool?(true);
				}
			}
		}

		// Token: 0x06032060 RID: 204896 RVA: 0x00B9C57A File Offset: 0x00B9A77A
		[NullableContext(1)]
		public static TeleportContext CreateContext(ITeleportContext contextParams)
		{
			TeleportContext teleportContext = new TeleportContext(contextParams);
			TeleportContext.TeleportContextIdHandler++;
			teleportContext.TeleportContextId = TeleportContext.TeleportContextIdHandler;
			return teleportContext;
		}

		// Token: 0x06032061 RID: 204897 RVA: 0x00B9C59C File Offset: 0x00B9A79C
		public void InitSeamlessContext()
		{
			this.ScreenEffectStarted = new GameModePromise();
			this.ScreenEffectEnded = new GameModePromise();
			this.SceneEffectStarted = new GameModePromise();
			this.SceneEffectEnded = new GameModePromise();
			this.LeastTimeFinished = new GameModePromise();
			this.TreadmillLoaded = new GameModePromise();
			this.TreadmillAppeared = new GameModePromise();
			this.TreadmillDisappeared = new GameModePromise();
			this.PostProcessBlendedIn = new GameModePromise();
			this.PostProcessBlendedOut = new GameModePromise();
			this.KiteAppeared = new GameModePromise();
		}

		// Token: 0x06032062 RID: 204898 RVA: 0x00B9C622 File Offset: 0x00B9A822
		static TeleportContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TeleportContext.CreateStaticDefaultValue), new Action(TeleportContext.ResetStaticDefaultValue));
		}

		// Token: 0x06032063 RID: 204899 RVA: 0x00B9C641 File Offset: 0x00B9A841
		public static void CreateStaticDefaultValue()
		{
			TeleportContext.TeleportContextIdHandler = 0;
		}

		// Token: 0x06032064 RID: 204900 RVA: 0x00B9C649 File Offset: 0x00B9A849
		public static void ResetStaticDefaultValue()
		{
			TeleportContext.TeleportContextIdHandler = 0;
		}

		// Token: 0x0401AA79 RID: 109177
		[Nullable(1)]
		public TeleportCore TeleportCore;

		// Token: 0x0401AA7A RID: 109178
		[Nullable(1)]
		public TeleportTransitionHelper TeleportTransitionHelper;

		// Token: 0x0401AA7B RID: 109179
		[Nullable(1)]
		public TeleportStreamingHelper TeleportStreamingHelper;

		// Token: 0x0401AA7C RID: 109180
		public TeleportSeamlessHelper TeleportSeamlessHelper;

		// Token: 0x0401AA7D RID: 109181
		private static int TeleportContextIdHandler;

		// Token: 0x0401AA7E RID: 109182
		public int TeleportContextId;

		// Token: 0x0401AA7F RID: 109183
		public Entity TeleportEntity;

		// Token: 0x0401AA80 RID: 109184
		public TimerHandle CheckStreamingCompletedTimerId;

		// Token: 0x0401AA81 RID: 109185
		private readonly GameModePromise StreamingCompletedInternal;

		// Token: 0x0401AA82 RID: 109186
		private readonly GameModePromise VoxelStreamingCompletedInternal;

		// Token: 0x0401AA83 RID: 109187
		private readonly GameModePromise TeleportFinishRequestInternal;

		// Token: 0x0401AA84 RID: 109188
		private readonly GameModePromise CgTeleportCompletedInternal;

		// Token: 0x0401AA85 RID: 109189
		private readonly GameModePromise TeleportWaitRequestInternal;

		// Token: 0x0401AA86 RID: 109190
		public bool? Seamless = new bool?(false);

		// Token: 0x0401AA87 RID: 109191
		public bool ForceInGameLoadMode;

		// Token: 0x0401AA88 RID: 109192
		public bool IsInSeamlessTeleport;

		// Token: 0x0401AA89 RID: 109193
		public SeamlessTravelContext SeamlessConfig;

		// Token: 0x0401AA8A RID: 109194
		public bool UseTreadmill;

		// Token: 0x0401AA8B RID: 109195
		public SeamlessTravelTreadmill Treadmill;

		// Token: 0x0401AA8C RID: 109196
		public bool UseKeepKite;

		// Token: 0x0401AA8D RID: 109197
		public SeamlessTravelKeepKite KeepKite;

		// Token: 0x0401AA8E RID: 109198
		public bool UseKeepMovementMode;

		// Token: 0x0401AA8F RID: 109199
		public SeamlessTravelKeepMovementMode KeepMovementMode;

		// Token: 0x0401AA90 RID: 109200
		public SeamlessTravelPostProcess PostProcess;

		// Token: 0x0401AA91 RID: 109201
		public SeamlessTravelScreenEffect ScreenEffect;

		// Token: 0x0401AA92 RID: 109202
		public SeamlessTravelSceneEffect SceneEffect;

		// Token: 0x0401AA93 RID: 109203
		public TimerHandle SeamlessEndHandle;

		// Token: 0x0401AA94 RID: 109204
		public GameModePromise ScreenEffectStarted;

		// Token: 0x0401AA95 RID: 109205
		public GameModePromise ScreenEffectEnded;

		// Token: 0x0401AA96 RID: 109206
		public GameModePromise SceneEffectStarted;

		// Token: 0x0401AA97 RID: 109207
		public GameModePromise SceneEffectEnded;

		// Token: 0x0401AA98 RID: 109208
		public GameModePromise LeastTimeFinished;

		// Token: 0x0401AA99 RID: 109209
		public GameModePromise TreadmillLoaded;

		// Token: 0x0401AA9A RID: 109210
		public GameModePromise TreadmillAppeared;

		// Token: 0x0401AA9B RID: 109211
		public GameModePromise TreadmillDisappeared;

		// Token: 0x0401AA9C RID: 109212
		public GameModePromise PostProcessBlendedIn;

		// Token: 0x0401AA9D RID: 109213
		public GameModePromise PostProcessBlendedOut;

		// Token: 0x0401AA9E RID: 109214
		public GameModePromise KiteAppeared;
	}
}
