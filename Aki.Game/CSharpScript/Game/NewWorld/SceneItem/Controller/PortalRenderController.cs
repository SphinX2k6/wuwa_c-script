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
	// Token: 0x020062EC RID: 25324
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PortalRenderController : ControllerBase
	{
		// Token: 0x0603D3D1 RID: 250833 RVA: 0x011AE300 File Offset: 0x011AC500
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

		// Token: 0x0603D3D2 RID: 250834 RVA: 0x011AE424 File Offset: 0x011AC624
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

		// Token: 0x0603D3D3 RID: 250835 RVA: 0x011AE584 File Offset: 0x011AC784
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

		// Token: 0x0603D3D4 RID: 250836 RVA: 0x011AE5C4 File Offset: 0x011AC7C4
		public void SetCaptureEnabled(int handle, bool enabled)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.FindCaptureEntry(handle);
			if (portalRenderCaptureEntry == null)
			{
				return;
			}
			portalRenderCaptureEntry.Enabled = enabled;
		}

		// Token: 0x0603D3D5 RID: 250837 RVA: 0x011AE5E4 File Offset: 0x011AC7E4
		public void SetCaptureMaxViewDistance(int handle, float maxViewDistance)
		{
			PortalRenderCaptureEntry portalRenderCaptureEntry = this.FindCaptureEntry(handle);
			if (portalRenderCaptureEntry == null)
			{
				return;
			}
			portalRenderCaptureEntry.MaxViewDistance = maxViewDistance;
		}

		// Token: 0x0603D3D6 RID: 250838 RVA: 0x011AE604 File Offset: 0x011AC804
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

		// Token: 0x0603D3D7 RID: 250839 RVA: 0x011AE6E0 File Offset: 0x011AC8E0
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

		// Token: 0x0603D3D8 RID: 250840 RVA: 0x011AE74C File Offset: 0x011AC94C
		protected unsafe override void OnTick(float delta)
		{
			for (int i = this.RetiringRenderTargets.Count - 1; i >= 0; i--)
			{
				ValueTuple<UTextureRenderTarget2D, int> valueTuple = this.RetiringRenderTargets[i];
				if (!EffectSystem.Instance.IsValid(valueTuple.Item2))
				{
					if (valueTuple.Item1.IsValid())
					{
						UKismetRenderingLibrary.ReleaseRenderTarget2D(valueTuple.Item1);
					}
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

		// Token: 0x0603D3D9 RID: 250841 RVA: 0x011AE8F0 File Offset: 0x011ACAF0
		protected override bool OnClear()
		{
			foreach (PortalRenderCaptureEntry entry in this.CaptureEntries)
			{
				this.ReleaseDynamicRenderTarget(entry);
			}
			this.CaptureEntries.Clear();
			foreach (ValueTuple<UTextureRenderTarget2D, int> valueTuple in this.RetiringRenderTargets)
			{
				if (valueTuple.Item1.IsValid())
				{
					UKismetRenderingLibrary.ReleaseRenderTarget2D(valueTuple.Item1);
				}
			}
			this.RetiringRenderTargets.Clear();
			this.TryReleaseRenderTargetPool();
			this.RoundRobinIndex = 0;
			this.NextCaptureHandle = 1;
			return true;
		}

		// Token: 0x0603D3DA RID: 250842 RVA: 0x011AE9C4 File Offset: 0x011ACBC4
		protected override bool OnLeaveLevel()
		{
			foreach (PortalRenderCaptureEntry entry in this.CaptureEntries)
			{
				this.ReleaseDynamicRenderTarget(entry);
			}
			this.CaptureEntries.Clear();
			foreach (ValueTuple<UTextureRenderTarget2D, int> valueTuple in this.RetiringRenderTargets)
			{
				if (valueTuple.Item1.IsValid())
				{
					UKismetRenderingLibrary.ReleaseRenderTarget2D(valueTuple.Item1);
				}
			}
			this.RetiringRenderTargets.Clear();
			this.TryReleaseRenderTargetPool();
			this.RoundRobinIndex = 0;
			return true;
		}

		// Token: 0x0603D3DB RID: 250843 RVA: 0x011AEA90 File Offset: 0x011ACC90
		private void ReleaseDynamicRenderTarget(PortalRenderCaptureEntry entry)
		{
			UTextureRenderTarget2D rt = entry.Rt;
			if (!entry.IsDynamicRt || rt == null)
			{
				return;
			}
			if (entry.Params.Capture.IsValid() && entry.Params.Capture.TextureTarget == rt)
			{
				entry.Params.Capture.TextureTarget = null;
			}
			if (rt.IsValid())
			{
				UKismetRenderingLibrary.ReleaseRenderTarget2D(rt);
			}
			entry.Rt = null;
			entry.IsDynamicRt = false;
		}

		// Token: 0x0603D3DC RID: 250844 RVA: 0x011AEB04 File Offset: 0x011ACD04
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

		// Token: 0x0603D3DD RID: 250845 RVA: 0x011AEBC0 File Offset: 0x011ACDC0
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

		// Token: 0x0603D3DE RID: 250846 RVA: 0x011AEC4C File Offset: 0x011ACE4C
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

		// Token: 0x0603D3DF RID: 250847 RVA: 0x011AED4C File Offset: 0x011ACF4C
		[NullableContext(2)]
		private PortalRenderCaptureEntry FindCaptureEntry(int handle)
		{
			return this.CaptureEntries.Find((PortalRenderCaptureEntry e) => e.Handle == handle);
		}

		// Token: 0x0603D3E0 RID: 250848 RVA: 0x011AED80 File Offset: 0x011ACF80
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

		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x0603D3E1 RID: 250849 RVA: 0x011AEDF6 File Offset: 0x011ACFF6
		public static PortalRenderController Instance
		{
			get
			{
				return PortalRenderController._Instance;
			}
		}

		// Token: 0x0603D3E2 RID: 250850 RVA: 0x011AEDFD File Offset: 0x011ACFFD
		public static PortalRenderController GetOrCreateInstance()
		{
			if (PortalRenderController._Instance == null)
			{
				PortalRenderController.CreateInstance();
			}
			return PortalRenderController._Instance;
		}

		// Token: 0x0603D3E3 RID: 250851 RVA: 0x011AEE11 File Offset: 0x011AD011
		public static bool CreateInstance()
		{
			if (PortalRenderController._Instance != null)
			{
				return true;
			}
			PortalRenderController._Instance = new PortalRenderController();
			return true;
		}

		// Token: 0x0603D3E4 RID: 250852 RVA: 0x011AEE27 File Offset: 0x011AD027
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D3E5 RID: 250853 RVA: 0x011AEE29 File Offset: 0x011AD029
		public static void ResetStaticDefaultValue()
		{
			PortalRenderController._Instance = null;
		}

		// Token: 0x0603D3E6 RID: 250854 RVA: 0x011AEE31 File Offset: 0x011AD031
		static PortalRenderController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalRenderController.CreateStaticDefaultValue), new Action(PortalRenderController.ResetStaticDefaultValue));
		}

		// Token: 0x040207A7 RID: 133031
		public int MaxCaptureUpdatesPerTick = 1;

		// Token: 0x040207A8 RID: 133032
		public bool EnableRenderTargetPoolAdjustment;

		// Token: 0x040207A9 RID: 133033
		public bool UseOffAxisProjection = true;

		// Token: 0x040207AA RID: 133034
		public bool CaptureDebugEnabled;

		// Token: 0x040207AB RID: 133035
		private const int DEFAULT_RENDER_TARGET_SIZE = 64;

		// Token: 0x040207AC RID: 133036
		private const float DEFAULT_MAX_VIEW_DISTANCE = 1f;

		// Token: 0x040207AD RID: 133037
		private const int CAPTURE_RENDER_TARGET_POOL_MIN = 600;

		// Token: 0x040207AE RID: 133038
		private const string RENDER_TARGET_POOL_MIN_CVAR = "r.RenderTargetPoolMin";

		// Token: 0x040207AF RID: 133039
		private readonly List<PortalRenderCaptureEntry> CaptureEntries = new List<PortalRenderCaptureEntry>();

		// Token: 0x040207B0 RID: 133040
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

		// Token: 0x040207B1 RID: 133041
		private int NextCaptureHandle = 1;

		// Token: 0x040207B2 RID: 133042
		private int RoundRobinIndex;

		// Token: 0x040207B3 RID: 133043
		private int? RenderTargetPoolMinBeforeCapture;

		// Token: 0x040207B4 RID: 133044
		private readonly Transform TmpCameraTrans = Transform.Create();

		// Token: 0x040207B5 RID: 133045
		private readonly Vector TmpLoc = Vector.Create();

		// Token: 0x040207B6 RID: 133046
		private readonly Rotator TmpRot = Rotator.Create();

		// Token: 0x040207B7 RID: 133047
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040207B8 RID: 133048
		[Nullable(2)]
		private static PortalRenderController _Instance;
	}
}
