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
	// Token: 0x02006DE1 RID: 28129
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemInspectModel : ModelBase
	{
		// Token: 0x060449D8 RID: 281048 RVA: 0x010EF60A File Offset: 0x010ED80A
		protected override bool OnInit()
		{
			this.UiTypeToViewMap[ETextUiType.Astrology] = EUiViewName.AstrologyItemInspectView;
			this.EffectCenter.Init();
			return true;
		}

		// Token: 0x060449D9 RID: 281049 RVA: 0x010EF62C File Offset: 0x010ED82C
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

		// Token: 0x060449DA RID: 281050 RVA: 0x010EF6B6 File Offset: 0x010ED8B6
		public bool IsInitGlobalConfig()
		{
			return this.IsInitGlobal;
		}

		// Token: 0x060449DB RID: 281051 RVA: 0x010EF6BE File Offset: 0x010ED8BE
		public float GetInputSeedLimit()
		{
			return this.InputSeedLimit;
		}

		// Token: 0x060449DC RID: 281052 RVA: 0x010EF6C6 File Offset: 0x010ED8C6
		public float GetRotateInterpSpeed()
		{
			return this.RotateInterpSpeed;
		}

		// Token: 0x060449DD RID: 281053 RVA: 0x010EF6CE File Offset: 0x010ED8CE
		public float GetResetItemRotationSpeed()
		{
			return this.ResetItemRotationSpeed;
		}

		// Token: 0x060449DE RID: 281054 RVA: 0x010EF6D6 File Offset: 0x010ED8D6
		public string GetDarkStageMeshPath()
		{
			return this.DarkStageMeshPath;
		}

		// Token: 0x060449DF RID: 281055 RVA: 0x010EF6DE File Offset: 0x010ED8DE
		public string GetDarkStageMaterialPath()
		{
			return this.DarkStageMaterialPath;
		}

		// Token: 0x060449E0 RID: 281056 RVA: 0x010EF6E6 File Offset: 0x010ED8E6
		public float GetDarkStageScreenDepth()
		{
			return this.DarkStageScreenDepth;
		}

		// Token: 0x060449E1 RID: 281057 RVA: 0x010EF6EE File Offset: 0x010ED8EE
		public float GetDarkStageAlpha()
		{
			return this.DarkStageAlpha;
		}

		// Token: 0x060449E2 RID: 281058 RVA: 0x010EF6F6 File Offset: 0x010ED8F6
		public float GetDarkStageBlendTime()
		{
			return this.DarkStageBlendTime;
		}

		// Token: 0x060449E3 RID: 281059 RVA: 0x010EF6FE File Offset: 0x010ED8FE
		public float GetDarkStageBlendInterval()
		{
			return this.DarkStageBlendInterval;
		}

		// Token: 0x060449E4 RID: 281060 RVA: 0x010EF708 File Offset: 0x010ED908
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

		// Token: 0x060449E5 RID: 281061 RVA: 0x010EF790 File Offset: 0x010ED990
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

		// Token: 0x060449E6 RID: 281062 RVA: 0x010EF8CC File Offset: 0x010EDACC
		public void LoadPrefabReady()
		{
			this.IsItemPrefabReady = true;
		}

		// Token: 0x060449E7 RID: 281063 RVA: 0x010EF8D5 File Offset: 0x010EDAD5
		public void OpenViewReady()
		{
			this.IsOpenViewReady = true;
		}

		// Token: 0x060449E8 RID: 281064 RVA: 0x010EF8DE File Offset: 0x010EDADE
		public bool IsInspectReady()
		{
			return this.IsItemPrefabReady && this.IsOpenViewReady;
		}

		// Token: 0x060449E9 RID: 281065 RVA: 0x010EF8F0 File Offset: 0x010EDAF0
		public EUiViewName? GetViewName()
		{
			return this.CurrentViewName;
		}

		// Token: 0x060449EA RID: 281066 RVA: 0x010EF8F8 File Offset: 0x010EDAF8
		[NullableContext(2)]
		public ItemInspectRangeChecker GetRangeChecker()
		{
			return this.RangeChecker;
		}

		// Token: 0x060449EB RID: 281067 RVA: 0x010EF900 File Offset: 0x010EDB00
		[NullableContext(2)]
		public ItemInspectPointManager GetPointManager()
		{
			return this.PointManager;
		}

		// Token: 0x060449EC RID: 281068 RVA: 0x010EF908 File Offset: 0x010EDB08
		public bool IsStageLifecycleLocked()
		{
			return this.StageLifecycleLocked;
		}

		// Token: 0x060449ED RID: 281069 RVA: 0x010EF910 File Offset: 0x010EDB10
		public void SetStageLifecycleLocked(bool locked)
		{
			this.StageLifecycleLocked = locked;
		}

		// Token: 0x060449EE RID: 281070 RVA: 0x010EF919 File Offset: 0x010EDB19
		public bool IsPendingEnterInitialStage()
		{
			return this.PendingEnterInitialStage;
		}

		// Token: 0x060449EF RID: 281071 RVA: 0x010EF921 File Offset: 0x010EDB21
		public void RequestEnterInitialStage(Action onFinish)
		{
			this.PendingEnterInitialStage = true;
			this.OnEnterInitialStageFinish = onFinish;
		}

		// Token: 0x060449F0 RID: 281072 RVA: 0x010EF931 File Offset: 0x010EDB31
		[NullableContext(2)]
		public Action ConsumeEnterInitialStageRequest()
		{
			this.PendingEnterInitialStage = false;
			Action onEnterInitialStageFinish = this.OnEnterInitialStageFinish;
			this.OnEnterInitialStageFinish = null;
			return onEnterInitialStageFinish;
		}

		// Token: 0x060449F1 RID: 281073 RVA: 0x010EF947 File Offset: 0x010EDB47
		public ItemInspectEffectCenter GetEffectCenter()
		{
			return this.EffectCenter;
		}

		// Token: 0x060449F2 RID: 281074 RVA: 0x010EF94F File Offset: 0x010EDB4F
		public float GetDragSensitivity()
		{
			return this.DragSensitivity;
		}

		// Token: 0x060449F3 RID: 281075 RVA: 0x010EF957 File Offset: 0x010EDB57
		public float GetGamePadSensitivity()
		{
			return this.GamePadSensitivity;
		}

		// Token: 0x060449F4 RID: 281076 RVA: 0x010EF95F File Offset: 0x010EDB5F
		public int GetMaxValidPointCount()
		{
			ItemInspectPointManager pointManager = this.PointManager;
			if (pointManager == null)
			{
				return 0;
			}
			return pointManager.GetMaxValidCount();
		}

		// Token: 0x060449F5 RID: 281077 RVA: 0x010EF972 File Offset: 0x010EDB72
		public int GetCheckedValidPointCount()
		{
			ItemInspectPointManager pointManager = this.PointManager;
			if (pointManager == null)
			{
				return 0;
			}
			return pointManager.GetCheckedValidCount();
		}

		// Token: 0x060449F6 RID: 281078 RVA: 0x010EF985 File Offset: 0x010EDB85
		[NullableContext(2)]
		public IItemInspectFinishEffect GetFinishEffect()
		{
			return this.FinishEffect;
		}

		// Token: 0x060449F7 RID: 281079 RVA: 0x010EF98D File Offset: 0x010EDB8D
		[NullableContext(2)]
		public UTraceLineElement GetLineElement()
		{
			return this.LineElement;
		}

		// Token: 0x060449F8 RID: 281080 RVA: 0x010EF995 File Offset: 0x010EDB95
		[NullableContext(2)]
		public Action<bool> GetFinishCallback()
		{
			return this.OnFinishItemInspect;
		}

		// Token: 0x060449F9 RID: 281081 RVA: 0x010EF9A0 File Offset: 0x010EDBA0
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

		// Token: 0x170099D6 RID: 39382
		// (get) Token: 0x060449FA RID: 281082 RVA: 0x010EFA24 File Offset: 0x010EDC24
		public static ItemInspectModel Instance
		{
			get
			{
				return ItemInspectModel._Instance;
			}
		}

		// Token: 0x060449FB RID: 281083 RVA: 0x010EFA2B File Offset: 0x010EDC2B
		public static ItemInspectModel GetOrCreateInstance()
		{
			if (ItemInspectModel._Instance == null)
			{
				ItemInspectModel.CreateInstance();
			}
			return ItemInspectModel._Instance;
		}

		// Token: 0x060449FC RID: 281084 RVA: 0x010EFA3F File Offset: 0x010EDC3F
		public static bool CreateInstance()
		{
			if (ItemInspectModel._Instance != null)
			{
				return true;
			}
			ItemInspectModel._Instance = new ItemInspectModel();
			return true;
		}

		// Token: 0x060449FD RID: 281085 RVA: 0x010EFA55 File Offset: 0x010EDC55
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060449FE RID: 281086 RVA: 0x010EFA57 File Offset: 0x010EDC57
		public static void ResetStaticDefaultValue()
		{
			ItemInspectModel._Instance = null;
		}

		// Token: 0x060449FF RID: 281087 RVA: 0x010EFA5F File Offset: 0x010EDC5F
		static ItemInspectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemInspectModel.CreateStaticDefaultValue), new Action(ItemInspectModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023AEE RID: 146158
		private const int GAME_PAD_SENSITIVITY = 20;

		// Token: 0x04023AEF RID: 146159
		private bool IsInitGlobal;

		// Token: 0x04023AF0 RID: 146160
		private float InputSeedLimit;

		// Token: 0x04023AF1 RID: 146161
		private float RotateInterpSpeed;

		// Token: 0x04023AF2 RID: 146162
		private float ResetItemRotationSpeed;

		// Token: 0x04023AF3 RID: 146163
		private string DarkStageMeshPath = "";

		// Token: 0x04023AF4 RID: 146164
		private string DarkStageMaterialPath = "";

		// Token: 0x04023AF5 RID: 146165
		private float DarkStageScreenDepth;

		// Token: 0x04023AF6 RID: 146166
		private float DarkStageAlpha;

		// Token: 0x04023AF7 RID: 146167
		private float DarkStageBlendTime;

		// Token: 0x04023AF8 RID: 146168
		private float DarkStageBlendInterval;

		// Token: 0x04023AF9 RID: 146169
		private readonly Dictionary<ETextUiType, EUiViewName> UiTypeToViewMap = new Dictionary<ETextUiType, EUiViewName>();

		// Token: 0x04023AFA RID: 146170
		private readonly ItemInspectEffectCenter EffectCenter = new ItemInspectEffectCenter();

		// Token: 0x04023AFB RID: 146171
		public bool CloseSkipConfirmBox;

		// Token: 0x04023AFC RID: 146172
		public bool OpenRangeDebug;

		// Token: 0x04023AFD RID: 146173
		[Nullable(2)]
		public AActor OriginItemActor;

		// Token: 0x04023AFE RID: 146174
		[Nullable(2)]
		public AStaticMeshActor DarkStageActor;

		// Token: 0x04023AFF RID: 146175
		[Nullable(2)]
		public UMaterialInstanceDynamic DarkStageMaterial;

		// Token: 0x04023B00 RID: 146176
		[Nullable(2)]
		public TimerHandle DarkStageBlendTimer;

		// Token: 0x04023B01 RID: 146177
		public int CurItemId;

		// Token: 0x04023B02 RID: 146178
		public bool ResettingItem;

		// Token: 0x04023B03 RID: 146179
		[Nullable(2)]
		public Action OnResetItemRotationFinish;

		// Token: 0x04023B04 RID: 146180
		public bool FocusRotating;

		// Token: 0x04023B05 RID: 146181
		[Nullable(2)]
		public Action OnFocusRotationFinish;

		// Token: 0x04023B06 RID: 146182
		public readonly Quat FocusTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023B07 RID: 146183
		public float FocusRotationSpeed = 5f;

		// Token: 0x04023B08 RID: 146184
		[Nullable(2)]
		public UCurveFloat FocusRotationSpeedCurve;

		// Token: 0x04023B09 RID: 146185
		public float FocusRotationElapsedTime;

		// Token: 0x04023B0A RID: 146186
		public readonly Vector2D InputDirect = Vector2D.Create();

		// Token: 0x04023B0B RID: 146187
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x04023B0C RID: 146188
		public readonly Rotator TempRotator2 = Rotator.Create();

		// Token: 0x04023B0D RID: 146189
		public readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023B0E RID: 146190
		public readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023B0F RID: 146191
		public readonly Vector TempVector = Vector.Create();

		// Token: 0x04023B10 RID: 146192
		public readonly List<IItemInspectVisiblePointData> VisiblePoints = new List<IItemInspectVisiblePointData>();

		// Token: 0x04023B11 RID: 146193
		public readonly List<IItemInspectVisiblePointData> VisiblePointsPool = new List<IItemInspectVisiblePointData>();

		// Token: 0x04023B12 RID: 146194
		public bool IsDragging;

		// Token: 0x04023B13 RID: 146195
		public bool IsDragSucceed;

		// Token: 0x04023B14 RID: 146196
		public bool IsDragSnapping;

		// Token: 0x04023B15 RID: 146197
		public float DragSnapElapsedSecond;

		// Token: 0x04023B16 RID: 146198
		public readonly Vector DragSnapStartLocation = Vector.Create();

		// Token: 0x04023B17 RID: 146199
		[Nullable(2)]
		public AActor DragItemActor;

		// Token: 0x04023B18 RID: 146200
		[Nullable(2)]
		public AActor DragTargetActor;

		// Token: 0x04023B19 RID: 146201
		public int DragTargetTagId;

		// Token: 0x04023B1A RID: 146202
		public float DragCheckDistance;

		// Token: 0x04023B1B RID: 146203
		public float DragPlaneDepth;

		// Token: 0x04023B1C RID: 146204
		public readonly Vector DragStartLocation = Vector.Create();

		// Token: 0x04023B1D RID: 146205
		public readonly Vector2D DragScreenPos = Vector2D.Create();

		// Token: 0x04023B1E RID: 146206
		public readonly Vector2D DragTargetScreenPos = Vector2D.Create();

		// Token: 0x04023B1F RID: 146207
		public readonly Vector2D DragGamepadInput = Vector2D.Create();

		// Token: 0x04023B20 RID: 146208
		[Nullable(2)]
		public Action<int> OnDragInteractSuccess;

		// Token: 0x04023B21 RID: 146209
		private bool IsItemPrefabReady;

		// Token: 0x04023B22 RID: 146210
		private bool IsOpenViewReady;

		// Token: 0x04023B23 RID: 146211
		[Nullable(2)]
		private ItemInspectRangeChecker RangeChecker;

		// Token: 0x04023B24 RID: 146212
		private EUiViewName? CurrentViewName;

		// Token: 0x04023B25 RID: 146213
		[Nullable(2)]
		private ItemInspectPointManager PointManager;

		// Token: 0x04023B26 RID: 146214
		private bool StageLifecycleLocked = true;

		// Token: 0x04023B27 RID: 146215
		private bool PendingEnterInitialStage;

		// Token: 0x04023B28 RID: 146216
		[Nullable(2)]
		private Action OnEnterInitialStageFinish;

		// Token: 0x04023B29 RID: 146217
		private float DragSensitivity;

		// Token: 0x04023B2A RID: 146218
		private float GamePadSensitivity;

		// Token: 0x04023B2B RID: 146219
		[Nullable(2)]
		private IItemInspectFinishEffect FinishEffect;

		// Token: 0x04023B2C RID: 146220
		[Nullable(2)]
		private UTraceLineElement LineElement;

		// Token: 0x04023B2D RID: 146221
		[Nullable(2)]
		private Action<bool> OnFinishItemInspect;

		// Token: 0x04023B2E RID: 146222
		[Nullable(2)]
		private static ItemInspectModel _Instance;
	}
}
