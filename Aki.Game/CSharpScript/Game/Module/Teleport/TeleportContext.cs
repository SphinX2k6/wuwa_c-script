using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SeamlessTravel;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B19 RID: 15129
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportContext : ITeleportContext, IStaticVariableResetter
	{
		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x06026DC5 RID: 159173 RVA: 0x00AE03CA File Offset: 0x00ADE5CA
		// (set) Token: 0x06026DC6 RID: 159174 RVA: 0x00AE03D2 File Offset: 0x00ADE5D2
		[Nullable(1)]
		public string ClientReason { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x06026DC7 RID: 159175 RVA: 0x00AE03DB File Offset: 0x00ADE5DB
		// (set) Token: 0x06026DC8 RID: 159176 RVA: 0x00AE03E3 File Offset: 0x00ADE5E3
		public FVectorDouble TargetPosition { get; set; }

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x06026DC9 RID: 159177 RVA: 0x00AE03EC File Offset: 0x00ADE5EC
		// (set) Token: 0x06026DCA RID: 159178 RVA: 0x00AE03F4 File Offset: 0x00ADE5F4
		public ETeleportMode? TeleportMode { get; set; }

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x06026DCB RID: 159179 RVA: 0x00AE03FD File Offset: 0x00ADE5FD
		// (set) Token: 0x06026DCC RID: 159180 RVA: 0x00AE0405 File Offset: 0x00ADE605
		public IRotator TargetRotation { get; set; }

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x06026DCD RID: 159181 RVA: 0x00AE040E File Offset: 0x00ADE60E
		// (set) Token: 0x06026DCE RID: 159182 RVA: 0x00AE0416 File Offset: 0x00ADE616
		public IVector TargetGravityDirect { get; set; }

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06026DCF RID: 159183 RVA: 0x00AE041F File Offset: 0x00ADE61F
		// (set) Token: 0x06026DD0 RID: 159184 RVA: 0x00AE0427 File Offset: 0x00ADE627
		public IVector TargetSpeed { get; set; }

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06026DD1 RID: 159185 RVA: 0x00AE0430 File Offset: 0x00ADE630
		// (set) Token: 0x06026DD2 RID: 159186 RVA: 0x00AE0438 File Offset: 0x00ADE638
		public TeleportReason? ServerReason { get; set; }

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06026DD3 RID: 159187 RVA: 0x00AE0441 File Offset: 0x00ADE641
		// (set) Token: 0x06026DD4 RID: 159188 RVA: 0x00AE0449 File Offset: 0x00ADE649
		public TransitionOptionPb Option { get; set; }

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06026DD5 RID: 159189 RVA: 0x00AE0452 File Offset: 0x00ADE652
		// (set) Token: 0x06026DD6 RID: 159190 RVA: 0x00AE045A File Offset: 0x00ADE65A
		public int? TransitionConfigId { get; set; }

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x06026DD7 RID: 159191 RVA: 0x00AE0463 File Offset: 0x00ADE663
		// (set) Token: 0x06026DD8 RID: 159192 RVA: 0x00AE046B File Offset: 0x00ADE66B
		public ITeleportTransitionType TransitionConfig { get; set; }

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06026DD9 RID: 159193 RVA: 0x00AE0474 File Offset: 0x00ADE674
		// (set) Token: 0x06026DDA RID: 159194 RVA: 0x00AE047C File Offset: 0x00ADE67C
		public bool? NeedRestoreCamera { get; set; } = new bool?(true);

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06026DDB RID: 159195 RVA: 0x00AE0485 File Offset: 0x00ADE685
		// (set) Token: 0x06026DDC RID: 159196 RVA: 0x00AE048D File Offset: 0x00ADE68D
		public GameCtxPb GameCtx { get; set; }

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06026DDD RID: 159197 RVA: 0x00AE0496 File Offset: 0x00ADE696
		// (set) Token: 0x06026DDE RID: 159198 RVA: 0x00AE049E File Offset: 0x00ADE69E
		public Entity ElevatorEntity { get; set; }

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06026DDF RID: 159199 RVA: 0x00AE04A7 File Offset: 0x00ADE6A7
		// (set) Token: 0x06026DE0 RID: 159200 RVA: 0x00AE04AF File Offset: 0x00ADE6AF
		public bool? DisableAutoFade { get; set; } = new bool?(false);

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06026DE1 RID: 159201 RVA: 0x00AE04B8 File Offset: 0x00ADE6B8
		// (set) Token: 0x06026DE2 RID: 159202 RVA: 0x00AE04C0 File Offset: 0x00ADE6C0
		public int? TeleportCfgId { get; set; }

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06026DE3 RID: 159203 RVA: 0x00AE04C9 File Offset: 0x00ADE6C9
		// (set) Token: 0x06026DE4 RID: 159204 RVA: 0x00AE04D1 File Offset: 0x00ADE6D1
		public bool? NeedRequestToServer { get; set; } = new bool?(true);

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06026DE5 RID: 159205 RVA: 0x00AE04DA File Offset: 0x00ADE6DA
		// (set) Token: 0x06026DE6 RID: 159206 RVA: 0x00AE04E2 File Offset: 0x00ADE6E2
		public bool? NeedWaitStreaming { get; set; } = new bool?(true);

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06026DE7 RID: 159207 RVA: 0x00AE04EB File Offset: 0x00ADE6EB
		// (set) Token: 0x06026DE8 RID: 159208 RVA: 0x00AE04F3 File Offset: 0x00ADE6F3
		public bool? KeepCameraRelativeRotation { get; set; } = new bool?(false);

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06026DE9 RID: 159209 RVA: 0x00AE04FC File Offset: 0x00ADE6FC
		// (set) Token: 0x06026DEA RID: 159210 RVA: 0x00AE0504 File Offset: 0x00ADE704
		public bool? KeepSpeedRelativeRotation { get; set; } = new bool?(false);

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x06026DEB RID: 159211 RVA: 0x00AE050D File Offset: 0x00ADE70D
		public GameModePromise StreamingCompleted
		{
			get
			{
				return this.StreamingCompletedInternal;
			}
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06026DEC RID: 159212 RVA: 0x00AE0515 File Offset: 0x00ADE715
		public GameModePromise VoxelStreamingCompleted
		{
			get
			{
				return this.VoxelStreamingCompletedInternal;
			}
		}

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06026DED RID: 159213 RVA: 0x00AE051D File Offset: 0x00ADE71D
		public GameModePromise TeleportFinishRequest
		{
			get
			{
				return this.TeleportFinishRequestInternal;
			}
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06026DEE RID: 159214 RVA: 0x00AE0525 File Offset: 0x00ADE725
		public GameModePromise CgTeleportCompleted
		{
			get
			{
				return this.CgTeleportCompletedInternal;
			}
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06026DEF RID: 159215 RVA: 0x00AE052D File Offset: 0x00ADE72D
		public GameModePromise TeleportWaitRequest
		{
			get
			{
				return this.TeleportWaitRequestInternal;
			}
		}

		// Token: 0x06026DF0 RID: 159216 RVA: 0x00AE0538 File Offset: 0x00ADE738
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
					goto IL_11D;
				}
			}
			transitionConfig = null;
			IL_11D:
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

		// Token: 0x06026DF1 RID: 159217 RVA: 0x00AE0886 File Offset: 0x00ADEA86
		[NullableContext(1)]
		public static TeleportContext CreateContext(ITeleportContext contextParams)
		{
			TeleportContext teleportContext = new TeleportContext(contextParams);
			TeleportContext.TeleportContextIdHandler++;
			teleportContext.TeleportContextId = TeleportContext.TeleportContextIdHandler;
			return teleportContext;
		}

		// Token: 0x06026DF2 RID: 159218 RVA: 0x00AE08A8 File Offset: 0x00ADEAA8
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

		// Token: 0x06026DF3 RID: 159219 RVA: 0x00AE092E File Offset: 0x00ADEB2E
		static TeleportContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TeleportContext.CreateStaticDefaultValue), new Action(TeleportContext.ResetStaticDefaultValue));
		}

		// Token: 0x06026DF4 RID: 159220 RVA: 0x00AE094D File Offset: 0x00ADEB4D
		public static void CreateStaticDefaultValue()
		{
			TeleportContext.TeleportContextIdHandler = 0;
		}

		// Token: 0x06026DF5 RID: 159221 RVA: 0x00AE0955 File Offset: 0x00ADEB55
		public static void ResetStaticDefaultValue()
		{
			TeleportContext.TeleportContextIdHandler = 0;
		}

		// Token: 0x040153CD RID: 86989
		[Nullable(1)]
		public TeleportCore TeleportCore;

		// Token: 0x040153CE RID: 86990
		[Nullable(1)]
		public TeleportTransitionHelper TeleportTransitionHelper;

		// Token: 0x040153CF RID: 86991
		[Nullable(1)]
		public TeleportStreamingHelper TeleportStreamingHelper;

		// Token: 0x040153D0 RID: 86992
		public TeleportSeamlessHelper TeleportSeamlessHelper;

		// Token: 0x040153D1 RID: 86993
		private static int TeleportContextIdHandler;

		// Token: 0x040153D2 RID: 86994
		public int TeleportContextId;

		// Token: 0x040153D3 RID: 86995
		public Entity TeleportEntity;

		// Token: 0x040153D4 RID: 86996
		public TimerHandle CheckStreamingCompletedTimerId;

		// Token: 0x040153D5 RID: 86997
		private readonly GameModePromise StreamingCompletedInternal;

		// Token: 0x040153D6 RID: 86998
		private readonly GameModePromise VoxelStreamingCompletedInternal;

		// Token: 0x040153D7 RID: 86999
		private readonly GameModePromise TeleportFinishRequestInternal;

		// Token: 0x040153D8 RID: 87000
		private readonly GameModePromise CgTeleportCompletedInternal;

		// Token: 0x040153D9 RID: 87001
		private readonly GameModePromise TeleportWaitRequestInternal;

		// Token: 0x040153DA RID: 87002
		public bool? Seamless = new bool?(false);

		// Token: 0x040153DB RID: 87003
		public bool ForceInGameLoadMode;

		// Token: 0x040153DC RID: 87004
		public bool IsInSeamlessTeleport;

		// Token: 0x040153DD RID: 87005
		public SeamlessTravelContext SeamlessConfig;

		// Token: 0x040153DE RID: 87006
		public bool UseTreadmill;

		// Token: 0x040153DF RID: 87007
		public SeamlessTravelTreadmill Treadmill;

		// Token: 0x040153E0 RID: 87008
		public bool UseKeepKite;

		// Token: 0x040153E1 RID: 87009
		public SeamlessTravelKeepKite KeepKite;

		// Token: 0x040153E2 RID: 87010
		public bool UseKeepMovementMode;

		// Token: 0x040153E3 RID: 87011
		public SeamlessTravelKeepMovementMode KeepMovementMode;

		// Token: 0x040153E4 RID: 87012
		public SeamlessTravelPostProcess PostProcess;

		// Token: 0x040153E5 RID: 87013
		public SeamlessTravelScreenEffect ScreenEffect;

		// Token: 0x040153E6 RID: 87014
		public SeamlessTravelSceneEffect SceneEffect;

		// Token: 0x040153E7 RID: 87015
		public TimerHandle SeamlessEndHandle;

		// Token: 0x040153E8 RID: 87016
		public GameModePromise ScreenEffectStarted;

		// Token: 0x040153E9 RID: 87017
		public GameModePromise ScreenEffectEnded;

		// Token: 0x040153EA RID: 87018
		public GameModePromise SceneEffectStarted;

		// Token: 0x040153EB RID: 87019
		public GameModePromise SceneEffectEnded;

		// Token: 0x040153EC RID: 87020
		public GameModePromise LeastTimeFinished;

		// Token: 0x040153ED RID: 87021
		public GameModePromise TreadmillLoaded;

		// Token: 0x040153EE RID: 87022
		public GameModePromise TreadmillAppeared;

		// Token: 0x040153EF RID: 87023
		public GameModePromise TreadmillDisappeared;

		// Token: 0x040153F0 RID: 87024
		public GameModePromise PostProcessBlendedIn;

		// Token: 0x040153F1 RID: 87025
		public GameModePromise PostProcessBlendedOut;

		// Token: 0x040153F2 RID: 87026
		public GameModePromise KiteAppeared;
	}
}
