using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Level.ItemInspect;
using CSharpScript.Game.LevelGamePlay.ItemInspect.Effect;
using CSharpScript.Game.LevelGamePlay.ItemInspect.Point;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02005F60 RID: 24416
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemInspectModel : ModelBase
	{
		// Token: 0x0603AB3C RID: 240444 RVA: 0x01099856 File Offset: 0x01097A56
		protected override bool OnInit()
		{
			this.UiTypeToViewMap[ETextUiType.Astrology] = EUiViewName.AstrologyItemInspectView;
			this.EffectCenter.Init();
			return true;
		}

		// Token: 0x0603AB3D RID: 240445 RVA: 0x01099878 File Offset: 0x01097A78
		public void InitGlobalConfig(BP_ItemInspectGlobalConfig_C config)
		{
			this.InputSeedLimit = config.输入速度限制;
			this.RotateInterpSpeed = config.平滑插值旋转速度;
			this.ResetItemRotationSpeed = config.重置旋转速度;
			this.DarkStageMeshPath = config.压暗网格体.ToAssetPathName();
			this.DarkStageMaterialPath = config.压暗材质.ToAssetPathName();
			this.DarkStageScreenDepth = config.压暗屏幕深度;
			this.DarkStageAlpha = config.压暗不透明度;
			this.DarkStageBlendTime = config.压暗过渡时间;
			this.DarkStageBlendInterval = config.压暗过渡间隔;
			this.IsInitGlobal = true;
		}

		// Token: 0x0603AB3E RID: 240446 RVA: 0x01099902 File Offset: 0x01097B02
		public bool IsInitGlobalConfig()
		{
			return this.IsInitGlobal;
		}

		// Token: 0x0603AB3F RID: 240447 RVA: 0x0109990A File Offset: 0x01097B0A
		public float GetInputSeedLimit()
		{
			return this.InputSeedLimit;
		}

		// Token: 0x0603AB40 RID: 240448 RVA: 0x01099912 File Offset: 0x01097B12
		public float GetRotateInterpSpeed()
		{
			return this.RotateInterpSpeed;
		}

		// Token: 0x0603AB41 RID: 240449 RVA: 0x0109991A File Offset: 0x01097B1A
		public float GetResetItemRotationSpeed()
		{
			return this.ResetItemRotationSpeed;
		}

		// Token: 0x0603AB42 RID: 240450 RVA: 0x01099922 File Offset: 0x01097B22
		public string GetDarkStageMeshPath()
		{
			return this.DarkStageMeshPath;
		}

		// Token: 0x0603AB43 RID: 240451 RVA: 0x0109992A File Offset: 0x01097B2A
		public string GetDarkStageMaterialPath()
		{
			return this.DarkStageMaterialPath;
		}

		// Token: 0x0603AB44 RID: 240452 RVA: 0x01099932 File Offset: 0x01097B32
		public float GetDarkStageScreenDepth()
		{
			return this.DarkStageScreenDepth;
		}

		// Token: 0x0603AB45 RID: 240453 RVA: 0x0109993A File Offset: 0x01097B3A
		public float GetDarkStageAlpha()
		{
			return this.DarkStageAlpha;
		}

		// Token: 0x0603AB46 RID: 240454 RVA: 0x01099942 File Offset: 0x01097B42
		public float GetDarkStageBlendTime()
		{
			return this.DarkStageBlendTime;
		}

		// Token: 0x0603AB47 RID: 240455 RVA: 0x0109994A File Offset: 0x01097B4A
		public float GetDarkStageBlendInterval()
		{
			return this.DarkStageBlendInterval;
		}

		// Token: 0x0603AB48 RID: 240456 RVA: 0x01099954 File Offset: 0x01097B54
		public void InitData(ETextUiType uiType, float inputSensitivity, ItemInspectRangeChecker rangeChecker, ItemInspectPointManager pointManager, [Nullable(2)] IItemInspectFinishEffect finishEffect, UTraceLineElement lineElement, [Nullable(2)] Action<bool> onFinish = null)
		{
			EUiViewName value;
			if (this.UiTypeToViewMap.TryGetValue(uiType, out value))
			{
				this.CurrentViewName = new EUiViewName?(value);
			}
			else
			{
				this.CurrentViewName = null;
			}
			this.DragSensitivity = inputSensitivity;
			this.GamePadSensitivity = inputSensitivity * 20f;
			this.RangeChecker = rangeChecker;
			this.PointManager = pointManager;
			this.StageLifecycleLocked = true;
			this.PendingEnterInitialStage = false;
			this.OnEnterInitialStageFinish = null;
			this.FinishEffect = finishEffect;
			this.LineElement = lineElement;
			this.OnFinishItemInspect = onFinish;
		}

		// Token: 0x0603AB49 RID: 240457 RVA: 0x010999DC File Offset: 0x01097BDC
		public void ClearData()
		{
			this.CurItemId = 0;
			this.InputDirect.Reset();
			this.ResetDragRuntime();
			this.OnDragInteractSuccess = null;
			this.EffectCenter.ClearEffects();
			this.VisiblePoints.Clear();
			this.VisiblePointsPool.Clear();
			this.IsItemPrefabReady = false;
			this.IsOpenViewReady = false;
			this.RangeChecker = null;
			this.CurrentViewName = null;
			this.PointManager = null;
			this.StageLifecycleLocked = true;
			this.PendingEnterInitialStage = false;
			this.OnEnterInitialStageFinish = null;
			this.FinishEffect = null;
			this.LineElement = null;
			this.DragSensitivity = 0f;
			this.GamePadSensitivity = 0f;
			this.OnFinishItemInspect = null;
			this.ResettingItem = false;
			this.OnResetItemRotationFinish = null;
			this.FocusRotating = false;
			this.OnFocusRotationFinish = null;
			this.FocusRotationSpeedCurve = null;
			this.FocusRotationElapsedTime = 0f;
			this.OriginItemActor = null;
			AStaticMeshActor darkStageActor = this.DarkStageActor;
			if (darkStageActor != null && darkStageActor.IsValid())
			{
				ActorSystem.Instance.Put("ItemInspect Clear", this.DarkStageActor, null);
			}
			this.DarkStageActor = null;
			this.DarkStageMaterial = null;
			TimerHandle darkStageBlendTimer = this.DarkStageBlendTimer;
			if (darkStageBlendTimer != null)
			{
				darkStageBlendTimer.Remove();
			}
			this.DarkStageBlendTimer = null;
		}

		// Token: 0x0603AB4A RID: 240458 RVA: 0x01099B18 File Offset: 0x01097D18
		public void LoadPrefabReady()
		{
			this.IsItemPrefabReady = true;
		}

		// Token: 0x0603AB4B RID: 240459 RVA: 0x01099B21 File Offset: 0x01097D21
		public void OpenViewReady()
		{
			this.IsOpenViewReady = true;
		}

		// Token: 0x0603AB4C RID: 240460 RVA: 0x01099B2A File Offset: 0x01097D2A
		public bool IsInspectReady()
		{
			return this.IsItemPrefabReady && this.IsOpenViewReady;
		}

		// Token: 0x0603AB4D RID: 240461 RVA: 0x01099B3C File Offset: 0x01097D3C
		public EUiViewName? GetViewName()
		{
			return this.CurrentViewName;
		}

		// Token: 0x0603AB4E RID: 240462 RVA: 0x01099B44 File Offset: 0x01097D44
		[NullableContext(2)]
		public ItemInspectRangeChecker GetRangeChecker()
		{
			return this.RangeChecker;
		}

		// Token: 0x0603AB4F RID: 240463 RVA: 0x01099B4C File Offset: 0x01097D4C
		[NullableContext(2)]
		public ItemInspectPointManager GetPointManager()
		{
			return this.PointManager;
		}

		// Token: 0x0603AB50 RID: 240464 RVA: 0x01099B54 File Offset: 0x01097D54
		public bool IsStageLifecycleLocked()
		{
			return this.StageLifecycleLocked;
		}

		// Token: 0x0603AB51 RID: 240465 RVA: 0x01099B5C File Offset: 0x01097D5C
		public void SetStageLifecycleLocked(bool locked)
		{
			this.StageLifecycleLocked = locked;
		}

		// Token: 0x0603AB52 RID: 240466 RVA: 0x01099B65 File Offset: 0x01097D65
		public bool IsPendingEnterInitialStage()
		{
			return this.PendingEnterInitialStage;
		}

		// Token: 0x0603AB53 RID: 240467 RVA: 0x01099B6D File Offset: 0x01097D6D
		public void RequestEnterInitialStage(Action onFinish)
		{
			this.PendingEnterInitialStage = true;
			this.OnEnterInitialStageFinish = onFinish;
		}

		// Token: 0x0603AB54 RID: 240468 RVA: 0x01099B7D File Offset: 0x01097D7D
		[NullableContext(2)]
		public Action ConsumeEnterInitialStageRequest()
		{
			this.PendingEnterInitialStage = false;
			Action onEnterInitialStageFinish = this.OnEnterInitialStageFinish;
			this.OnEnterInitialStageFinish = null;
			return onEnterInitialStageFinish;
		}

		// Token: 0x0603AB55 RID: 240469 RVA: 0x01099B93 File Offset: 0x01097D93
		public ItemInspectEffectCenter GetEffectCenter()
		{
			return this.EffectCenter;
		}

		// Token: 0x0603AB56 RID: 240470 RVA: 0x01099B9B File Offset: 0x01097D9B
		public float GetDragSensitivity()
		{
			return this.DragSensitivity;
		}

		// Token: 0x0603AB57 RID: 240471 RVA: 0x01099BA3 File Offset: 0x01097DA3
		public float GetGamePadSensitivity()
		{
			return this.GamePadSensitivity;
		}

		// Token: 0x0603AB58 RID: 240472 RVA: 0x01099BAB File Offset: 0x01097DAB
		public int GetMaxValidPointCount()
		{
			ItemInspectPointManager pointManager = this.PointManager;
			if (pointManager == null)
			{
				return 0;
			}
			return pointManager.GetMaxValidCount();
		}

		// Token: 0x0603AB59 RID: 240473 RVA: 0x01099BBE File Offset: 0x01097DBE
		public int GetCheckedValidPointCount()
		{
			ItemInspectPointManager pointManager = this.PointManager;
			if (pointManager == null)
			{
				return 0;
			}
			return pointManager.GetCheckedValidCount();
		}

		// Token: 0x0603AB5A RID: 240474 RVA: 0x01099BD1 File Offset: 0x01097DD1
		[NullableContext(2)]
		public IItemInspectFinishEffect GetFinishEffect()
		{
			return this.FinishEffect;
		}

		// Token: 0x0603AB5B RID: 240475 RVA: 0x01099BD9 File Offset: 0x01097DD9
		[NullableContext(2)]
		public UTraceLineElement GetLineElement()
		{
			return this.LineElement;
		}

		// Token: 0x0603AB5C RID: 240476 RVA: 0x01099BE1 File Offset: 0x01097DE1
		[NullableContext(2)]
		public Action<bool> GetFinishCallback()
		{
			return this.OnFinishItemInspect;
		}

		// Token: 0x0603AB5D RID: 240477 RVA: 0x01099BEC File Offset: 0x01097DEC
		public void ResetDragRuntime()
		{
			this.IsDragging = false;
			this.IsDragSucceed = false;
			this.IsDragSnapping = false;
			this.DragSnapElapsedSecond = 0f;
			this.DragSnapStartLocation.Reset();
			this.DragItemActor = null;
			this.DragTargetActor = null;
			this.DragTargetTagId = 0;
			this.DragCheckDistance = 0f;
			this.DragPlaneDepth = 0f;
			this.DragScreenPos.Reset();
			this.DragTargetScreenPos.Reset();
			this.DragGamepadInput.Reset();
		}

		// Token: 0x17006ED9 RID: 28377
		// (get) Token: 0x0603AB5E RID: 240478 RVA: 0x01099C70 File Offset: 0x01097E70
		public static ItemInspectModel Instance
		{
			get
			{
				return ItemInspectModel._Instance;
			}
		}

		// Token: 0x0603AB5F RID: 240479 RVA: 0x01099C77 File Offset: 0x01097E77
		public static ItemInspectModel GetOrCreateInstance()
		{
			if (ItemInspectModel._Instance == null)
			{
				ItemInspectModel.CreateInstance();
			}
			return ItemInspectModel._Instance;
		}

		// Token: 0x0603AB60 RID: 240480 RVA: 0x01099C8B File Offset: 0x01097E8B
		public static bool CreateInstance()
		{
			if (ItemInspectModel._Instance != null)
			{
				return true;
			}
			ItemInspectModel._Instance = new ItemInspectModel();
			return true;
		}

		// Token: 0x0603AB61 RID: 240481 RVA: 0x01099CA1 File Offset: 0x01097EA1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AB62 RID: 240482 RVA: 0x01099CA3 File Offset: 0x01097EA3
		public static void ResetStaticDefaultValue()
		{
			ItemInspectModel._Instance = null;
		}

		// Token: 0x0603AB63 RID: 240483 RVA: 0x01099CAB File Offset: 0x01097EAB
		static ItemInspectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemInspectModel.CreateStaticDefaultValue), new Action(ItemInspectModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401ED90 RID: 126352
		private const int GAME_PAD_SENSITIVITY = 20;

		// Token: 0x0401ED91 RID: 126353
		private bool IsInitGlobal;

		// Token: 0x0401ED92 RID: 126354
		private float InputSeedLimit;

		// Token: 0x0401ED93 RID: 126355
		private float RotateInterpSpeed;

		// Token: 0x0401ED94 RID: 126356
		private float ResetItemRotationSpeed;

		// Token: 0x0401ED95 RID: 126357
		private string DarkStageMeshPath = "";

		// Token: 0x0401ED96 RID: 126358
		private string DarkStageMaterialPath = "";

		// Token: 0x0401ED97 RID: 126359
		private float DarkStageScreenDepth;

		// Token: 0x0401ED98 RID: 126360
		private float DarkStageAlpha;

		// Token: 0x0401ED99 RID: 126361
		private float DarkStageBlendTime;

		// Token: 0x0401ED9A RID: 126362
		private float DarkStageBlendInterval;

		// Token: 0x0401ED9B RID: 126363
		private readonly Dictionary<ETextUiType, EUiViewName> UiTypeToViewMap = new Dictionary<ETextUiType, EUiViewName>();

		// Token: 0x0401ED9C RID: 126364
		private readonly ItemInspectEffectCenter EffectCenter = new ItemInspectEffectCenter();

		// Token: 0x0401ED9D RID: 126365
		public bool CloseSkipConfirmBox;

		// Token: 0x0401ED9E RID: 126366
		public bool OpenRangeDebug;

		// Token: 0x0401ED9F RID: 126367
		[Nullable(2)]
		public AActor OriginItemActor;

		// Token: 0x0401EDA0 RID: 126368
		[Nullable(2)]
		public AStaticMeshActor DarkStageActor;

		// Token: 0x0401EDA1 RID: 126369
		[Nullable(2)]
		public UMaterialInstanceDynamic DarkStageMaterial;

		// Token: 0x0401EDA2 RID: 126370
		[Nullable(2)]
		public TimerHandle DarkStageBlendTimer;

		// Token: 0x0401EDA3 RID: 126371
		public int CurItemId;

		// Token: 0x0401EDA4 RID: 126372
		public bool ResettingItem;

		// Token: 0x0401EDA5 RID: 126373
		[Nullable(2)]
		public Action OnResetItemRotationFinish;

		// Token: 0x0401EDA6 RID: 126374
		public bool FocusRotating;

		// Token: 0x0401EDA7 RID: 126375
		[Nullable(2)]
		public Action OnFocusRotationFinish;

		// Token: 0x0401EDA8 RID: 126376
		public readonly Quat FocusTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401EDA9 RID: 126377
		public float FocusRotationSpeed = 5f;

		// Token: 0x0401EDAA RID: 126378
		[Nullable(2)]
		public UCurveFloat FocusRotationSpeedCurve;

		// Token: 0x0401EDAB RID: 126379
		public float FocusRotationElapsedTime;

		// Token: 0x0401EDAC RID: 126380
		public readonly Vector2D InputDirect = Vector2D.Create();

		// Token: 0x0401EDAD RID: 126381
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x0401EDAE RID: 126382
		public readonly Rotator TempRotator2 = Rotator.Create();

		// Token: 0x0401EDAF RID: 126383
		public readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401EDB0 RID: 126384
		public readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401EDB1 RID: 126385
		public readonly Vector TempVector = Vector.Create();

		// Token: 0x0401EDB2 RID: 126386
		public readonly List<IItemInspectVisiblePointData> VisiblePoints = new List<IItemInspectVisiblePointData>();

		// Token: 0x0401EDB3 RID: 126387
		public readonly List<IItemInspectVisiblePointData> VisiblePointsPool = new List<IItemInspectVisiblePointData>();

		// Token: 0x0401EDB4 RID: 126388
		public bool IsDragging;

		// Token: 0x0401EDB5 RID: 126389
		public bool IsDragSucceed;

		// Token: 0x0401EDB6 RID: 126390
		public bool IsDragSnapping;

		// Token: 0x0401EDB7 RID: 126391
		public float DragSnapElapsedSecond;

		// Token: 0x0401EDB8 RID: 126392
		public readonly Vector DragSnapStartLocation = Vector.Create();

		// Token: 0x0401EDB9 RID: 126393
		[Nullable(2)]
		public AActor DragItemActor;

		// Token: 0x0401EDBA RID: 126394
		[Nullable(2)]
		public AActor DragTargetActor;

		// Token: 0x0401EDBB RID: 126395
		public int DragTargetTagId;

		// Token: 0x0401EDBC RID: 126396
		public float DragCheckDistance;

		// Token: 0x0401EDBD RID: 126397
		public float DragPlaneDepth;

		// Token: 0x0401EDBE RID: 126398
		public readonly Vector DragStartLocation = Vector.Create();

		// Token: 0x0401EDBF RID: 126399
		public readonly Vector2D DragScreenPos = Vector2D.Create();

		// Token: 0x0401EDC0 RID: 126400
		public readonly Vector2D DragTargetScreenPos = Vector2D.Create();

		// Token: 0x0401EDC1 RID: 126401
		public readonly Vector2D DragGamepadInput = Vector2D.Create();

		// Token: 0x0401EDC2 RID: 126402
		[Nullable(2)]
		public Action<int> OnDragInteractSuccess;

		// Token: 0x0401EDC3 RID: 126403
		private bool IsItemPrefabReady;

		// Token: 0x0401EDC4 RID: 126404
		private bool IsOpenViewReady;

		// Token: 0x0401EDC5 RID: 126405
		[Nullable(2)]
		private ItemInspectRangeChecker RangeChecker;

		// Token: 0x0401EDC6 RID: 126406
		private EUiViewName? CurrentViewName;

		// Token: 0x0401EDC7 RID: 126407
		[Nullable(2)]
		private ItemInspectPointManager PointManager;

		// Token: 0x0401EDC8 RID: 126408
		private bool StageLifecycleLocked = true;

		// Token: 0x0401EDC9 RID: 126409
		private bool PendingEnterInitialStage;

		// Token: 0x0401EDCA RID: 126410
		[Nullable(2)]
		private Action OnEnterInitialStageFinish;

		// Token: 0x0401EDCB RID: 126411
		private float DragSensitivity;

		// Token: 0x0401EDCC RID: 126412
		private float GamePadSensitivity;

		// Token: 0x0401EDCD RID: 126413
		[Nullable(2)]
		private IItemInspectFinishEffect FinishEffect;

		// Token: 0x0401EDCE RID: 126414
		[Nullable(2)]
		private UTraceLineElement LineElement;

		// Token: 0x0401EDCF RID: 126415
		[Nullable(2)]
		private Action<bool> OnFinishItemInspect;

		// Token: 0x0401EDD0 RID: 126416
		[Nullable(2)]
		private static ItemInspectModel _Instance;
	}
}
