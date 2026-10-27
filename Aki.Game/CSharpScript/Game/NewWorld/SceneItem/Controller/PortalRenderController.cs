using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x02007237 RID: 29239
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PortalRenderController : ControllerBase
	{
		// Token: 0x06047A70 RID: 293488 RVA: 0x01255768 File Offset: 0x01253968
		public int RegisterCapture(PortalRenderCaptureParams @params, int ownerEntityId)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = null;
			int result;
			try
			{
				this.TryAcquireRenderTargetPool();
				UTextureRenderTarget2D utextureRenderTarget2D = UKismetRenderingLibrary.CreateRenderTarget2D(GlobalData.World, 64, 64, ETextureRenderTargetFormat.RTF_RGBA8, new FLinearColor?(new FLinearColor(0f, 0f, 0f, 0f)), false);
				if (utextureRenderTarget2D == null)
				{
					this.TryReleaseRenderTargetPool();
					Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.ZYL, "[PortalRenderController] 创建RT失败,注册捕获取消", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = -1;
				}
				else
				{
					portalRenderCaptureEntry = new PortalRenderCaptureEntry(@params, this.NextCaptureHandle, ownerEntityId, utextureRenderTarget2D, true, null, 1f, false);
					@params.Capture.TextureTarget = utextureRenderTarget2D;
					this.CaptureEntries.Add(portalRenderCaptureEntry);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[PortalRenderController] 注册捕获实例";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Handle", portalRenderCaptureEntry.Handle);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					int nextCaptureHandle = this.NextCaptureHandle;
					this.NextCaptureHandle = nextCaptureHandle + 1;
					result = nextCaptureHandle;
				}
			}
			catch
			{
				if (portalRenderCaptureEntry != null)
				{
					this.CaptureEntries.Remove(portalRenderCaptureEntry);
					this.ReleaseDynamicRenderTarget(portalRenderCaptureEntry);
				}
				this.TryReleaseRenderTargetPool();
				throw;
			}
			return result;
		}

		// Token: 0x06047A71 RID: 293489 RVA: 0x0125588C File Offset: 0x01253A8C
		public void UnregisterCapture(int handle, int retiringEffectHandle = 0)
		{
			int num = this.CaptureEntries.FindIndex((PortalRenderCaptureEntry e) => e.Handle == handle);
			if (num < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[PortalRenderController] 注销捕获实例失败,句柄不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Handle", handle);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.CaptureEntries[num];
			if (portalRenderCaptureEntry.IsDynamicRt && portalRenderCaptureEntry.Rt != null && retiringEffectHandle != 0 && EffectSystem.Instance.IsValid(retiringEffectHandle))
			{
				USceneCaptureComponent2D capture = portalRenderCaptureEntry.Params.Capture;
				if (capture.IsValid())
				{
					capture.bCaptureEveryFrame = false;
					capture.bCaptureOnMovement = false;
					if (capture.TextureTarget == portalRenderCaptureEntry.Rt)
					{
						capture.TextureTarget = null;
					}
				}
				this.RetiringRenderTargets.Add(new ValueTuple<UTextureRenderTarget2D, int>(portalRenderCaptureEntry.Rt, retiringEffectHandle));
				portalRenderCaptureEntry.Rt = null;
				portalRenderCaptureEntry.IsDynamicRt = false;
			}
			else
			{
				this.ReleaseDynamicRenderTarget(portalRenderCaptureEntry);
			}
			this.CaptureEntries.RemoveAt(num);
			this.TryReleaseRenderTargetPool();
			if (this.RoundRobinIndex >= this.CaptureEntries.Count)
			{
				this.RoundRobinIndex = 0;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[PortalRenderController] 注销捕获实例";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Handle", handle);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06047A72 RID: 293490 RVA: 0x012559EC File Offset: 0x01253BEC
		public void SetCaptureRenderTexture(int handle, UTextureRenderTarget2D rt)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.FindCaptureEntry(handle);
			if (portalRenderCaptureEntry == null)
			{
				return;
			}
			this.ReleaseDynamicRenderTarget(portalRenderCaptureEntry);
			portalRenderCaptureEntry.Rt = rt;
			portalRenderCaptureEntry.IsDynamicRt = false;
			portalRenderCaptureEntry.Params.Capture.TextureTarget = rt;
		}

		// Token: 0x06047A73 RID: 293491 RVA: 0x01255A2C File Offset: 0x01253C2C
		public void SetCaptureEnabled(int handle, bool enabled)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.FindCaptureEntry(handle);
			if (portalRenderCaptureEntry == null)
			{
				return;
			}
			portalRenderCaptureEntry.Enabled = enabled;
		}

		// Token: 0x06047A74 RID: 293492 RVA: 0x01255A4C File Offset: 0x01253C4C
		public void SetCaptureMaxViewDistance(int handle, float maxViewDistance)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.FindCaptureEntry(handle);
			if (portalRenderCaptureEntry == null)
			{
				return;
			}
			portalRenderCaptureEntry.MaxViewDistance = maxViewDistance;
		}

		// Token: 0x06047A75 RID: 293493 RVA: 0x01255A6C File Offset: 0x01253C6C
		public void SwitchMeshMaterialTexture(SceneInteractionActor interactionActor, string meshActorKey, string paramName, UTexture texture)
		{
			AStaticMeshActor astaticMeshActor = interactionActor.GetActorByKey(meshActorKey) as AStaticMeshActor;
			UStaticMeshComponent ustaticMeshComponent = (astaticMeshActor != null) ? astaticMeshActor.StaticMeshComponent : null;
			if (ustaticMeshComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[PortalRenderController] 切换Mesh材质纹理失败,取不到StaticMeshComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MeshActorKey", meshActorKey);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UMaterialInterface material = ustaticMeshComponent.GetMaterial(0);
			if (material == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[PortalRenderController] 切换Mesh材质纹理失败,取不到源材质";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MeshActorKey", meshActorKey);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			UMaterialInstanceDynamic umaterialInstanceDynamic = ustaticMeshComponent.CreateDynamicMaterialInstance(0, material, default(FName));
			if (umaterialInstanceDynamic == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[PortalRenderController] 切换Mesh材质纹理失败,创建动态材质失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("MeshActorKey", meshActorKey);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			umaterialInstanceDynamic.SetTextureParameterValue(FNameUtil.GetDynamicFName(paramName).Value, texture);
		}

		// Token: 0x06047A76 RID: 293494 RVA: 0x01255B48 File Offset: 0x01253D48
		public bool SwitchEffectNiagaraTexture(SceneInteractionActor interactionActor, string effectActorKey, string userParameterName, UTexture texture)
		{
			BP_EffectActor_C bp_EffectActor_C = interactionActor.GetActorByKey(effectActorKey) as BP_EffectActor_C;
			if (bp_EffectActor_C == null || !bp_EffectActor_C.IsValid() || bp_EffectActor_C.EffectComponent == 0)
			{
				return false;
			}
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(bp_EffectActor_C.EffectComponent);
			if (!niagaraComponent.IsValid())
			{
				return false;
			}
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self = niagaraComponent;
			FName value = FNameUtil.GetDynamicFName(userParameterName).Value;
			self.SetVariableTypedObject(value, UTexture.StaticClass(), texture);
			return true;
		}

		// Token: 0x06047A77 RID: 293495 RVA: 0x01255BB4 File Offset: 0x01253DB4
		protected unsafe override void OnTick(float delta)
		{
			for (int i = this.RetiringRenderTargets.Count - 1; i >= 0; i--)
			{
				ValueTuple<UTextureRenderTarget2D, int> valueTuple = this.RetiringRenderTargets[i];
				if (!EffectSystem.Instance.IsValid(valueTuple.Item2))
				{
					UKismetRenderingLibrary.ReleaseRenderTarget2D(valueTuple.Item1);
					this.RetiringRenderTargets.RemoveAt(i);
				}
			}
			for (int j = this.CaptureEntries.Count - 1; j >= 0; j--)
			{
				PortalRenderCaptureEntry portalRenderCaptureEntry = this.CaptureEntries[j];
				if (EntitySystem.Instance.Get(portalRenderCaptureEntry.OwnerEntityId) == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[PortalRenderController] 捕获实例所属实体已销毁,自动注销捕获";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Handle", portalRenderCaptureEntry.Handle);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OwnerEntityId", portalRenderCaptureEntry.OwnerEntityId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.UnregisterCapture(portalRenderCaptureEntry.Handle, 0);
				}
			}
			if (this.CaptureEntries.Count == 0)
			{
				this.TryReleaseRenderTargetPool();
				return;
			}
			int num = Math.Min(this.MaxCaptureUpdatesPerTick, this.CaptureEntries.Count);
			for (int k = 0; k < num; k++)
			{
				if (this.RoundRobinIndex >= this.CaptureEntries.Count)
				{
					this.RoundRobinIndex = 0;
				}
				List<PortalRenderCaptureEntry> captureEntries = this.CaptureEntries;
				int roundRobinIndex = this.RoundRobinIndex;
				this.RoundRobinIndex = roundRobinIndex + 1;
				PortalRenderCaptureEntry entry = captureEntries[roundRobinIndex];
				this.UpdateCaptureEntry(entry);
			}
		}

		// Token: 0x06047A78 RID: 293496 RVA: 0x01255D48 File Offset: 0x01253F48
		protected override bool OnClear()
		{
			foreach (PortalRenderCaptureEntry entry in this.CaptureEntries)
			{
				this.ReleaseDynamicRenderTarget(entry);
			}
			this.CaptureEntries.Clear();
			foreach (ValueTuple<UTextureRenderTarget2D, int> valueTuple in this.RetiringRenderTargets)
			{
				UKismetRenderingLibrary.ReleaseRenderTarget2D(valueTuple.Item1);
			}
			this.RetiringRenderTargets.Clear();
			this.TryReleaseRenderTargetPool();
			this.NextCaptureHandle = 1;
			this.RoundRobinIndex = 0;
			return true;
		}

		// Token: 0x06047A79 RID: 293497 RVA: 0x01255E0C File Offset: 0x0125400C
		private void ReleaseDynamicRenderTarget(PortalRenderCaptureEntry entry)
		{
			UTextureRenderTarget2D rt = entry.Rt;
			if (!entry.IsDynamicRt || rt == null)
			{
				return;
			}
			if (entry.Params.Capture.TextureTarget == rt)
			{
				entry.Params.Capture.TextureTarget = null;
			}
			UKismetRenderingLibrary.ReleaseRenderTarget2D(rt);
			entry.Rt = null;
			entry.IsDynamicRt = false;
		}

		// Token: 0x06047A7A RID: 293498 RVA: 0x01255E64 File Offset: 0x01254064
		private unsafe void TryAcquireRenderTargetPool()
		{
			if (!this.EnableRenderTargetPoolAdjustment || this.CaptureEntries.Count != 0 || this.RetiringRenderTargets.Count != 0)
			{
				return;
			}
			int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.RenderTargetPoolMin");
			this.RenderTargetPoolMinBeforeCapture = new int?(consoleVariableIntValue);
			int num = Math.Max(consoleVariableIntValue, 600);
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.RenderTargetPoolMin", num);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[PortalRenderController] 扩大RenderTargetPool";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Before", consoleVariableIntValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("After", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06047A7B RID: 293499 RVA: 0x01255F20 File Offset: 0x01254120
		private void TryReleaseRenderTargetPool()
		{
			if (this.CaptureEntries.Count != 0 || this.RetiringRenderTargets.Count != 0 || this.RenderTargetPoolMinBeforeCapture == null)
			{
				return;
			}
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.RenderTargetPoolMin", this.RenderTargetPoolMinBeforeCapture.Value);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[PortalRenderController] 恢复RenderTargetPool";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", this.RenderTargetPoolMinBeforeCapture.Value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.RenderTargetPoolMinBeforeCapture = null;
		}

		// Token: 0x06047A7C RID: 293500 RVA: 0x01255FAC File Offset: 0x012541AC
		private void UpdateCaptureEntry(PortalRenderCaptureEntry entry)
		{
			Transform playerCameraTransform = this.GetPlayerCameraTransform();
			EPortalCaptureLevel eportalCaptureLevel = PortalUtils.Instance.ComputeCapturePerformanceLevel(entry.Enabled, playerCameraTransform, entry.Params.SourcePortalWorld, null);
			EPortalCaptureLevel? currentLevel = entry.CurrentLevel;
			EPortalCaptureLevel eportalCaptureLevel2 = eportalCaptureLevel;
			if (!(currentLevel.GetValueOrDefault() == eportalCaptureLevel2 & currentLevel != null))
			{
				entry.CurrentLevel = new EPortalCaptureLevel?(eportalCaptureLevel);
				PortalUtils.Instance.ApplyCapturePerformance(entry.Params.Capture, eportalCaptureLevel, entry.MaxViewDistance, null);
			}
			if (this.UseOffAxisProjection)
			{
				PortalUtils.Instance.UpdateCaptureCameraOffAxis(playerCameraTransform, entry.Params.SourcePortalWorld, entry.Params.TargetPortalWorld, entry.Params.SourcePortalBounds, entry.Params.Capture, this.CaptureDebugEnabled);
				return;
			}
			PortalUtils.Instance.UpdateCaptureCamera(playerCameraTransform, entry.Params.SourcePortalWorld, entry.Params.TargetPortalWorld, entry.Params.SourcePortalBounds, entry.Params.Capture, this.CaptureDebugEnabled);
		}

		// Token: 0x06047A7D RID: 293501 RVA: 0x012560AC File Offset: 0x012542AC
		[NullableContext(2)]
		private PortalRenderCaptureEntry FindCaptureEntry(int handle)
		{
			return this.CaptureEntries.Find((PortalRenderCaptureEntry e) => e.Handle == handle);
		}

		// Token: 0x06047A7E RID: 293502 RVA: 0x012560E0 File Offset: 0x012542E0
		private Transform GetPlayerCameraTransform()
		{
			Transform tmpCameraTrans = this.TmpCameraTrans;
			APlayerCameraManager playerCameraManager = UGameplayStatics.GetPlayerCameraManager(GlobalData.World, 0);
			if (playerCameraManager == null)
			{
				tmpCameraTrans.Reset();
				return tmpCameraTrans;
			}
			Vector tmpLoc = this.TmpLoc;
			FVectorDouble fvectorDouble = playerCameraManager.D_GetCameraLocation();
			tmpLoc.FromUeVector(fvectorDouble);
			Rotator tmpRot = this.TmpRot;
			FRotator cameraRotation = playerCameraManager.GetCameraRotation();
			tmpRot.FromUeRotator(cameraRotation);
			tmpCameraTrans.Set(this.TmpLoc, this.TmpRot.Quaternion(this.TmpQuat), Vector.OneVectorProxy);
			return tmpCameraTrans;
		}

		// Token: 0x17009E3E RID: 40510
		// (get) Token: 0x06047A7F RID: 293503 RVA: 0x01256156 File Offset: 0x01254356
		public static PortalRenderController Instance
		{
			get
			{
				return PortalRenderController._Instance;
			}
		}

		// Token: 0x06047A80 RID: 293504 RVA: 0x0125615D File Offset: 0x0125435D
		public static PortalRenderController GetOrCreateInstance()
		{
			if (PortalRenderController._Instance == null)
			{
				PortalRenderController.CreateInstance();
			}
			return PortalRenderController._Instance;
		}

		// Token: 0x06047A81 RID: 293505 RVA: 0x01256171 File Offset: 0x01254371
		public static bool CreateInstance()
		{
			if (PortalRenderController._Instance != null)
			{
				return true;
			}
			PortalRenderController._Instance = new PortalRenderController();
			return true;
		}

		// Token: 0x06047A82 RID: 293506 RVA: 0x01256187 File Offset: 0x01254387
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047A83 RID: 293507 RVA: 0x01256189 File Offset: 0x01254389
		public static void ResetStaticDefaultValue()
		{
			PortalRenderController._Instance = null;
		}

		// Token: 0x06047A84 RID: 293508 RVA: 0x01256191 File Offset: 0x01254391
		static PortalRenderController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalRenderController.CreateStaticDefaultValue), new Action(PortalRenderController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B38 RID: 154424
		public int MaxCaptureUpdatesPerTick = 1;

		// Token: 0x04025B39 RID: 154425
		public bool EnableRenderTargetPoolAdjustment;

		// Token: 0x04025B3A RID: 154426
		public bool UseOffAxisProjection = true;

		// Token: 0x04025B3B RID: 154427
		public bool CaptureDebugEnabled;

		// Token: 0x04025B3C RID: 154428
		private const int DEFAULT_RENDER_TARGET_SIZE = 64;

		// Token: 0x04025B3D RID: 154429
		private const float DEFAULT_MAX_VIEW_DISTANCE = 1f;

		// Token: 0x04025B3E RID: 154430
		private const int CAPTURE_RENDER_TARGET_POOL_MIN = 600;

		// Token: 0x04025B3F RID: 154431
		private const string RENDER_TARGET_POOL_MIN_CVAR = "r.RenderTargetPoolMin";

		// Token: 0x04025B40 RID: 154432
		private readonly List<PortalRenderCaptureEntry> CaptureEntries = new List<PortalRenderCaptureEntry>();

		// Token: 0x04025B41 RID: 154433
		[TupleElementNames(new string[]
		{
			"Rt",
			"EffectHandle"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<UTextureRenderTarget2D, int>> RetiringRenderTargets = new List<ValueTuple<UTextureRenderTarget2D, int>>();

		// Token: 0x04025B42 RID: 154434
		private int NextCaptureHandle = 1;

		// Token: 0x04025B43 RID: 154435
		private int RoundRobinIndex;

		// Token: 0x04025B44 RID: 154436
		private int? RenderTargetPoolMinBeforeCapture;

		// Token: 0x04025B45 RID: 154437
		private readonly Transform TmpCameraTrans = Transform.Create();

		// Token: 0x04025B46 RID: 154438
		private readonly Vector TmpLoc = Vector.Create();

		// Token: 0x04025B47 RID: 154439
		private readonly Rotator TmpRot = Rotator.Create();

		// Token: 0x04025B48 RID: 154440
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04025B49 RID: 154441
		[Nullable(2)]
		private static PortalRenderController _Instance;
	}
}
