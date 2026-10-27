using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DataLayerSwitch;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032BC RID: 12988
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C")]
public class TsTransitionWorldPartitionTriggerVolume : AWorldPartitionTriggerVolume, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026EF RID: 9967
	// (get) Token: 0x0601C26C RID: 115308 RVA: 0x007D5D7C File Offset: 0x007D3F7C
	// (set) Token: 0x0601C26D RID: 115309 RVA: 0x007D5D8C File Offset: 0x007D3F8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool FunctionEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_FunctionEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_FunctionEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x170026F0 RID: 9968
	// (get) Token: 0x0601C26E RID: 115310 RVA: 0x007D5D9D File Offset: 0x007D3F9D
	// (set) Token: 0x0601C26F RID: 115311 RVA: 0x007D5DAD File Offset: 0x007D3FAD
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe bool UseTransitionWhenTeleport
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_UseTransitionWhenTeleport) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_UseTransitionWhenTeleport) = (value ? 1 : 0);
		}
	}

	// Token: 0x170026F1 RID: 9969
	// (get) Token: 0x0601C270 RID: 115312 RVA: 0x007D5DBE File Offset: 0x007D3FBE
	// (set) Token: 0x0601C271 RID: 115313 RVA: 0x007D5DD2 File Offset: 0x007D3FD2
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe UKuroSceneMatModifyDataAsset MatForActivatingDataLayers
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroSceneMatModifyDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForActivatingDataLayers);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForActivatingDataLayers, value);
		}
	}

	// Token: 0x170026F2 RID: 9970
	// (get) Token: 0x0601C272 RID: 115314 RVA: 0x007D5DE7 File Offset: 0x007D3FE7
	// (set) Token: 0x0601C273 RID: 115315 RVA: 0x007D5DFB File Offset: 0x007D3FFB
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe UKuroSceneMatModifyDataAsset MatForDeactivatingDataLayers
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroSceneMatModifyDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForDeactivatingDataLayers);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForDeactivatingDataLayers, value);
		}
	}

	// Token: 0x170026F3 RID: 9971
	// (get) Token: 0x0601C274 RID: 115316 RVA: 0x007D5E10 File Offset: 0x007D4010
	// (set) Token: 0x0601C275 RID: 115317 RVA: 0x007D5E24 File Offset: 0x007D4024
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe ULevelSequence SeqForSourceIn
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceIn);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceIn, value);
		}
	}

	// Token: 0x170026F4 RID: 9972
	// (get) Token: 0x0601C276 RID: 115318 RVA: 0x007D5E39 File Offset: 0x007D4039
	// (set) Token: 0x0601C277 RID: 115319 RVA: 0x007D5E4D File Offset: 0x007D404D
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceIn
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)), value);
		}
	}

	// Token: 0x170026F5 RID: 9973
	// (get) Token: 0x0601C278 RID: 115320 RVA: 0x007D5E62 File Offset: 0x007D4062
	// (set) Token: 0x0601C279 RID: 115321 RVA: 0x007D5E76 File Offset: 0x007D4076
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe ULevelSequence SeqForSourceOut
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceOut);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceOut, value);
		}
	}

	// Token: 0x170026F6 RID: 9974
	// (get) Token: 0x0601C27A RID: 115322 RVA: 0x007D5E8B File Offset: 0x007D408B
	// (set) Token: 0x0601C27B RID: 115323 RVA: 0x007D5E9F File Offset: 0x007D409F
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceOut
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)), value);
		}
	}

	// Token: 0x170026F7 RID: 9975
	// (get) Token: 0x0601C27C RID: 115324 RVA: 0x007D5EB4 File Offset: 0x007D40B4
	// (set) Token: 0x0601C27D RID: 115325 RVA: 0x007D5EC4 File Offset: 0x007D40C4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WaitDataLayerStreamingRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_WaitDataLayerStreamingRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_WaitDataLayerStreamingRadius) = value;
		}
	}

	// Token: 0x170026F8 RID: 9976
	// (get) Token: 0x0601C27E RID: 115326 RVA: 0x007D5ED5 File Offset: 0x007D40D5
	// (set) Token: 0x0601C27F RID: 115327 RVA: 0x007D5EE5 File Offset: 0x007D40E5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxTimeForWaitDataLayerActivateFinish
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MaxTimeForWaitDataLayerActivateFinish);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MaxTimeForWaitDataLayerActivateFinish) = value;
		}
	}

	// Token: 0x0601C280 RID: 115328 RVA: 0x007D5EF8 File Offset: 0x007D40F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C281 RID: 115329 RVA: 0x007D5F7C File Offset: 0x007D417C
	protected void SetMatForActivatingDataLayers_Implementation(UKuroSceneMatModifyDataAsset asset)
	{
		this.MatForActivatingDataLayers = asset;
		this.MatPathForActivatingDataLayers = null;
		if (this.MatForActivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForActivatingDataLayersLoadingHandle);
			this.MatForActivatingDataLayersLoadingHandle = -1;
		}
	}

	// Token: 0x0601C282 RID: 115330 RVA: 0x007D5FAC File Offset: 0x007D41AC
	public void SetMatForActivatingDataLayersByPath(string path)
	{
		this.MatForActivatingDataLayers = null;
		this.MatPathForActivatingDataLayers = path;
		if (this.MatForActivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForActivatingDataLayersLoadingHandle);
			this.MatForActivatingDataLayersLoadingHandle = -1;
		}
		if (!string.IsNullOrEmpty(path))
		{
			bool loadCallbackCalled = false;
			int matForActivatingDataLayersLoadingHandle = ResourceSystem.Instance.LoadAsync<UKuroSceneMatModifyDataAsset>(path, delegate([Nullable(2)] UKuroSceneMatModifyDataAsset asset, string _)
			{
				loadCallbackCalled = true;
				this.MatForActivatingDataLayersLoadingHandle = -1;
				this.SetMatForActivatingDataLayers(asset);
			}, 100, "js_undefined");
			if (!loadCallbackCalled)
			{
				this.MatForActivatingDataLayersLoadingHandle = matForActivatingDataLayersLoadingHandle;
			}
		}
	}

	// Token: 0x0601C283 RID: 115331 RVA: 0x007D6034 File Offset: 0x007D4234
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForActivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C284 RID: 115332 RVA: 0x007D60A9 File Offset: 0x007D42A9
	protected bool WasMatForActivatingDataLayersSet_Implementation()
	{
		if (this.MatForActivatingDataLayersLoadingHandle != -1)
		{
			string matPathForActivatingDataLayers = this.MatPathForActivatingDataLayers;
			return matPathForActivatingDataLayers != null && matPathForActivatingDataLayers.Length > 0;
		}
		UKuroSceneMatModifyDataAsset matForActivatingDataLayers = this.MatForActivatingDataLayers;
		return matForActivatingDataLayers != null && matForActivatingDataLayers.IsValid();
	}

	// Token: 0x0601C285 RID: 115333 RVA: 0x007D60DC File Offset: 0x007D42DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C286 RID: 115334 RVA: 0x007D6160 File Offset: 0x007D4360
	protected void SetMatForDeactivatingDataLayers_Implementation(UKuroSceneMatModifyDataAsset asset)
	{
		this.MatForDeactivatingDataLayers = asset;
		this.MatPathForDeactivatingDataLayers = null;
		if (this.MatForDeactivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForDeactivatingDataLayersLoadingHandle);
			this.MatForDeactivatingDataLayersLoadingHandle = -1;
		}
	}

	// Token: 0x0601C287 RID: 115335 RVA: 0x007D6190 File Offset: 0x007D4390
	public void SetMatForDeactivatingDataLayersByPath(string path)
	{
		this.MatForDeactivatingDataLayers = null;
		this.MatPathForDeactivatingDataLayers = path;
		if (this.MatForDeactivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForDeactivatingDataLayersLoadingHandle);
			this.MatForDeactivatingDataLayersLoadingHandle = -1;
		}
		if (!string.IsNullOrEmpty(path))
		{
			bool loadCallbackCalled = false;
			int matForDeactivatingDataLayersLoadingHandle = ResourceSystem.Instance.LoadAsync<UKuroSceneMatModifyDataAsset>(path, delegate([Nullable(2)] UKuroSceneMatModifyDataAsset asset, string _)
			{
				loadCallbackCalled = true;
				this.MatForDeactivatingDataLayersLoadingHandle = -1;
				this.SetMatForDeactivatingDataLayers(asset);
			}, 100, "js_undefined");
			if (!loadCallbackCalled)
			{
				this.MatForDeactivatingDataLayersLoadingHandle = matForDeactivatingDataLayersLoadingHandle;
			}
		}
	}

	// Token: 0x0601C288 RID: 115336 RVA: 0x007D6218 File Offset: 0x007D4418
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForDeactivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C289 RID: 115337 RVA: 0x007D628D File Offset: 0x007D448D
	protected bool WasMatForDeactivatingDataLayersSet_Implementation()
	{
		if (this.MatForDeactivatingDataLayersLoadingHandle != -1)
		{
			string matPathForDeactivatingDataLayers = this.MatPathForDeactivatingDataLayers;
			return matPathForDeactivatingDataLayers != null && matPathForDeactivatingDataLayers.Length > 0;
		}
		UKuroSceneMatModifyDataAsset matForDeactivatingDataLayers = this.MatForDeactivatingDataLayers;
		return matForDeactivatingDataLayers != null && matForDeactivatingDataLayers.IsValid();
	}

	// Token: 0x0601C28A RID: 115338 RVA: 0x007D62C0 File Offset: 0x007D44C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceIn"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->beforeModifyMatMark), beforeModifyMatMark);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C28B RID: 115339 RVA: 0x007D6351 File Offset: 0x007D4551
	[NullableContext(1)]
	protected void SetSeqForSourceIn_Implementation([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		this.SeqForSourceIn = asset;
		this.SeqPathForSourceIn = null;
		this.SeqMarkBeforeModifyMatForSourceIn = beforeModifyMatMark;
		if (this.SeqForSourceInLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.SeqForSourceInLoadingHandle);
			this.SeqForSourceInLoadingHandle = -1;
		}
	}

	// Token: 0x0601C28C RID: 115340 RVA: 0x007D6388 File Offset: 0x007D4588
	[NullableContext(1)]
	public void SetSeqForSourceInByPath([Nullable(2)] string path, string beforeModifyMatMark = "")
	{
		this.SeqForSourceIn = null;
		this.SeqPathForSourceIn = path;
		this.SeqMarkBeforeModifyMatForSourceIn = beforeModifyMatMark;
		if (this.SeqForSourceInLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.SeqForSourceInLoadingHandle);
			this.SeqForSourceInLoadingHandle = -1;
		}
		if (!string.IsNullOrEmpty(path))
		{
			bool loadCallbackCalled = false;
			int seqForSourceInLoadingHandle = ResourceSystem.Instance.LoadAsync<ULevelSequence>(path, delegate([Nullable(2)] ULevelSequence asset, string _)
			{
				loadCallbackCalled = true;
				this.SeqForSourceInLoadingHandle = -1;
				this.SetSeqForSourceIn(asset, beforeModifyMatMark);
			}, 100, "js_undefined");
			if (!loadCallbackCalled)
			{
				this.SeqForSourceInLoadingHandle = seqForSourceInLoadingHandle;
			}
		}
	}

	// Token: 0x0601C28D RID: 115341 RVA: 0x007D6420 File Offset: 0x007D4620
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceInSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C28E RID: 115342 RVA: 0x007D6495 File Offset: 0x007D4695
	protected bool WasSeqForSourceInSet_Implementation()
	{
		if (this.SeqForSourceInLoadingHandle != -1)
		{
			string seqPathForSourceIn = this.SeqPathForSourceIn;
			return seqPathForSourceIn != null && seqPathForSourceIn.Length > 0;
		}
		ULevelSequence seqForSourceIn = this.SeqForSourceIn;
		return seqForSourceIn != null && seqForSourceIn.IsValid();
	}

	// Token: 0x0601C28F RID: 115343 RVA: 0x007D64C8 File Offset: 0x007D46C8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceOut"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->beforeModifyMatMark), beforeModifyMatMark);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C290 RID: 115344 RVA: 0x007D6559 File Offset: 0x007D4759
	[NullableContext(1)]
	protected void SetSeqForSourceOut_Implementation([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		this.SeqForSourceOut = asset;
		this.SeqPathForSourceOut = null;
		this.SeqMarkBeforeModifyMatForSourceOut = beforeModifyMatMark;
		if (this.SeqForSourceOutLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.SeqForSourceOutLoadingHandle);
			this.SeqForSourceOutLoadingHandle = -1;
		}
	}

	// Token: 0x0601C291 RID: 115345 RVA: 0x007D6590 File Offset: 0x007D4790
	[NullableContext(1)]
	public void SetSeqForSourceOutByPath([Nullable(2)] string path, string beforeModifyMatMark = "")
	{
		this.SeqForSourceOut = null;
		this.SeqPathForSourceOut = path;
		this.SeqMarkBeforeModifyMatForSourceOut = beforeModifyMatMark;
		if (this.SeqForSourceOutLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.SeqForSourceOutLoadingHandle);
			this.SeqForSourceOutLoadingHandle = -1;
		}
		if (!string.IsNullOrEmpty(path))
		{
			bool loadCallbackCalled = false;
			int seqForSourceOutLoadingHandle = ResourceSystem.Instance.LoadAsync<ULevelSequence>(path, delegate([Nullable(2)] ULevelSequence asset, string _)
			{
				loadCallbackCalled = true;
				this.SeqForSourceOutLoadingHandle = -1;
				this.SetSeqForSourceOut(asset, beforeModifyMatMark);
			}, 100, "js_undefined");
			if (!loadCallbackCalled)
			{
				this.SeqForSourceOutLoadingHandle = seqForSourceOutLoadingHandle;
			}
		}
	}

	// Token: 0x0601C292 RID: 115346 RVA: 0x007D6628 File Offset: 0x007D4828
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceOutSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C293 RID: 115347 RVA: 0x007D669D File Offset: 0x007D489D
	protected bool WasSeqForSourceOutSet_Implementation()
	{
		if (this.SeqForSourceOutLoadingHandle != -1)
		{
			string seqPathForSourceOut = this.SeqPathForSourceOut;
			return seqPathForSourceOut != null && seqPathForSourceOut.Length > 0;
		}
		ULevelSequence seqForSourceOut = this.SeqForSourceOut;
		return seqForSourceOut != null && seqForSourceOut.IsValid();
	}

	// Token: 0x0601C294 RID: 115348 RVA: 0x007D66D0 File Offset: 0x007D48D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnStateChanged()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnStateChanged"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C295 RID: 115349 RVA: 0x007D6740 File Offset: 0x007D4940
	protected unsafe override void OnStateChanged_Implementation()
	{
		if (!this.FunctionEnable)
		{
			return;
		}
		HashSet<FName> hashSet = new HashSet<FName>();
		HashSet<FName> hashSet2 = new HashSet<FName>();
		foreach (KeyValuePair<FName, bool> keyValuePair in base.DatalayerStateMap)
		{
			FName fname;
			bool flag;
			keyValuePair.Deconstruct(out fname, out flag);
			FName item = fname;
			bool flag2 = flag;
			if ((base.State == EWorldPartitionTriggerVolumeState.StreamingSourceIn) ? flag2 : (!flag2))
			{
				hashSet.Add(item);
			}
			else
			{
				hashSet2.Add(item);
			}
			string text = item.ToString();
			if (!text.Contains("DLV"))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TriggerVolume;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[TsTransitionWorldPartitionTriggerVolume] 使用TsTransitionWorldPartitionTriggerVolume控制非DLV的Datalayer, 可能存在冲突, 请检查配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("State", base.State);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DatalayerLabel", text);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
		if (hashSet.Count > 0 && hashSet2.Count > 0 && this.WasMatForActivatingDataLayersSet() && this.WasMatForDeactivatingDataLayersSet() && ((base.State == EWorldPartitionTriggerVolumeState.StreamingSourceIn) ? this.WasSeqForSourceInSet() : this.WasSeqForSourceOutSet()))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TriggerVolume;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[TsTransitionWorldPartitionTriggerVolume] 暂时不支持同时控制DataLayer显示的过渡和DataLayer隐藏的过渡, 可能存在表现问题, 请检查配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("State", base.State);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		if (((hashSet.Count > 0 && this.WasMatForActivatingDataLayersSet()) || (hashSet2.Count > 0 && this.WasMatForDeactivatingDataLayersSet())) && !((base.State == EWorldPartitionTriggerVolumeState.StreamingSourceIn) ? this.WasSeqForSourceInSet() : this.WasSeqForSourceOutSet()))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.TriggerVolume;
			ELogAuthor author3 = ELogAuthor.ZYL;
			string message3 = "[TsTransitionWorldPartitionTriggerVolume] 设置了过渡DA和DataLayer, 但是没有设置过渡Seq, 可能存在表现问题, 请检查配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("State", base.State);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
		}
		bool flag3 = true;
		if (TeleportModel.Instance.IsTeleport || GameModeModel.Instance.Loading)
		{
			if (this.UseTransitionWhenTeleport)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.TriggerVolume;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[TsTransitionWorldPartitionTriggerVolume] 正在进行传送或加载, 根据配置仍使用过渡效果, 可能存在表现问题, 请检查配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("State", base.State);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				flag3 = true;
			}
			else
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.TriggerVolume;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[TsTransitionWorldPartitionTriggerVolume] 正在进行传送或加载, 根据配置忽略过渡效果";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("State", base.State);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
				flag3 = false;
			}
		}
		DataLayersTransitionTask dataLayersTransitionTask = new DataLayersTransitionTask();
		dataLayersTransitionTask.ToActivateDataLayerNames = hashSet;
		dataLayersTransitionTask.ToDeactivateDataLayerNames = hashSet2;
		if (flag3)
		{
			dataLayersTransitionTask.MatDataForActivating = this.MatForActivatingDataLayers;
			dataLayersTransitionTask.MatPathForActivating = this.MatPathForActivatingDataLayers;
			dataLayersTransitionTask.MatDataForActivatingLoaded = (this.MatForActivatingDataLayersLoadingHandle == -1);
			dataLayersTransitionTask.MatDataForDeactivating = this.MatForDeactivatingDataLayers;
			dataLayersTransitionTask.MatPathForDeactivating = this.MatPathForDeactivatingDataLayers;
			dataLayersTransitionTask.MatDataForDeactivatingLoaded = (this.MatForDeactivatingDataLayersLoadingHandle == -1);
			if (base.State == EWorldPartitionTriggerVolumeState.StreamingSourceIn)
			{
				dataLayersTransitionTask.SeqData = this.SeqForSourceIn;
				dataLayersTransitionTask.SeqPath = this.SeqPathForSourceIn;
				dataLayersTransitionTask.SeqDataLoaded = (this.SeqForSourceInLoadingHandle == -1);
				dataLayersTransitionTask.SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMatForSourceIn;
			}
			else
			{
				dataLayersTransitionTask.SeqData = this.SeqForSourceOut;
				dataLayersTransitionTask.SeqPath = this.SeqPathForSourceOut;
				dataLayersTransitionTask.SeqDataLoaded = (this.SeqForSourceOutLoadingHandle == -1);
				dataLayersTransitionTask.SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMatForSourceOut;
			}
		}
		dataLayersTransitionTask.ShouldWaitDataLayersActivateFinish = (this.WaitDataLayerStreamingRadius > 0f);
		dataLayersTransitionTask.WaitDataLayerStreamingRadius = MathUtils.Instance.Clamp(this.WaitDataLayerStreamingRadius, 0f, 7000f);
		dataLayersTransitionTask.MaxTimeForWaitDataLayerActivateFinish = this.MaxTimeForWaitDataLayerActivateFinish;
		dataLayersTransitionTask.ShouldModifyBudgetDuringWaitDataLayerActivateFinish = true;
		dataLayersTransitionTask.TaskFinishCallback = new Action<DataLayersTransitionTask, bool>(this.OnTransitionTaskFinish);
		Log instance6 = Log.Instance;
		ELogModule module6 = ELogModule.TriggerVolume;
		ELogAuthor author6 = ELogAuthor.ZYL;
		string message6 = "[TsTransitionWorldPartitionTriggerVolume] 添加DataLayer过渡切换Task";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("State", base.State);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 2) = new ValueTuple<string, object>("DataLayersToActivate", dataLayersTransitionTask.ToActivateDataLayerNames);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 3) = new ValueTuple<string, object>("DataLayersToDeactivate", dataLayersTransitionTask.ToDeactivateDataLayerNames);
		instance6.Info(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 4));
		this.TransitionTaskQueue.Push(dataLayersTransitionTask);
		this.TryStartNextTask();
	}

	// Token: 0x0601C296 RID: 115350 RVA: 0x007D6C90 File Offset: 0x007D4E90
	private void TryStartNextTask()
	{
		if (this.ExecutingTransitionTasks.Count > 0)
		{
			return;
		}
		DataLayersTransitionTask dataLayersTransitionTask = null;
		while (!this.TransitionTaskQueue.Empty && dataLayersTransitionTask == null)
		{
			dataLayersTransitionTask = this.TransitionTaskQueue.Pop();
		}
		if (dataLayersTransitionTask == null)
		{
			return;
		}
		this.ExecutingTransitionTasks.Add(dataLayersTransitionTask);
		dataLayersTransitionTask.StartTask();
	}

	// Token: 0x0601C297 RID: 115351 RVA: 0x007D6CE3 File Offset: 0x007D4EE3
	[NullableContext(1)]
	private void OnTransitionTaskFinish(DataLayersTransitionTask task, bool success)
	{
		this.ExecutingTransitionTasks.Remove(task);
		this.TryStartNextTask();
	}

	// Token: 0x0601C298 RID: 115352 RVA: 0x007D6CF8 File Offset: 0x007D4EF8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTransitionWorldPartitionTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C");
		}
		return TsTransitionWorldPartitionTriggerVolume._ClassPtr;
	}

	// Token: 0x0601C299 RID: 115353 RVA: 0x007D6D1C File Offset: 0x007D4F1C
	public TsTransitionWorldPartitionTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C29A RID: 115354 RVA: 0x007D6D44 File Offset: 0x007D4F44
	[NullableContext(1)]
	public TsTransitionWorldPartitionTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C29B RID: 115355 RVA: 0x007D6D77 File Offset: 0x007D4F77
	protected TsTransitionWorldPartitionTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C29C RID: 115356 RVA: 0x007D6DB4 File Offset: 0x007D4FB4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C29D RID: 115357 RVA: 0x007D6DD4 File Offset: 0x007D4FD4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C29E RID: 115358 RVA: 0x007D6DE4 File Offset: 0x007D4FE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C29F RID: 115359 RVA: 0x007D6E04 File Offset: 0x007D5004
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C2A0 RID: 115360 RVA: 0x007D6E14 File Offset: 0x007D5014
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceIn_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C2A1 RID: 115361 RVA: 0x007D6E42 File Offset: 0x007D5042
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceInSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x0601C2A2 RID: 115362 RVA: 0x007D6E50 File Offset: 0x007D5050
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceOut_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C2A3 RID: 115363 RVA: 0x007D6E7E File Offset: 0x007D507E
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x0601C2A4 RID: 115364 RVA: 0x007D6E8C File Offset: 0x007D508C
	protected virtual void __CPPCALL_OnStateChanged_Implementation()
	{
		this.OnStateChanged_Implementation();
	}

	// Token: 0x0400DEC6 RID: 57030
	private string MatPathForActivatingDataLayers;

	// Token: 0x0400DEC7 RID: 57031
	private int MatForActivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400DEC8 RID: 57032
	private string MatPathForDeactivatingDataLayers;

	// Token: 0x0400DEC9 RID: 57033
	private int MatForDeactivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400DECA RID: 57034
	private string SeqPathForSourceIn;

	// Token: 0x0400DECB RID: 57035
	private int SeqForSourceInLoadingHandle = -1;

	// Token: 0x0400DECC RID: 57036
	private string SeqPathForSourceOut;

	// Token: 0x0400DECD RID: 57037
	private int SeqForSourceOutLoadingHandle = -1;

	// Token: 0x0400DECE RID: 57038
	[Nullable(1)]
	private readonly Queue<DataLayersTransitionTask> TransitionTaskQueue = new Queue<DataLayersTransitionTask>(4);

	// Token: 0x0400DECF RID: 57039
	[Nullable(1)]
	private readonly HashSet<DataLayersTransitionTask> ExecutingTransitionTasks = new HashSet<DataLayersTransitionTask>();

	// Token: 0x0400DED0 RID: 57040
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C";

	// Token: 0x0400DED1 RID: 57041
	private static IntPtr _ClassPtr;

	// Token: 0x0400DED2 RID: 57042
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DED3 RID: 57043
	private static int __PropertyOffset_FunctionEnable;

	// Token: 0x0400DED4 RID: 57044
	private static int __PropertyOffset_UseTransitionWhenTeleport;

	// Token: 0x0400DED5 RID: 57045
	private static int __PropertyOffset_MatForActivatingDataLayers;

	// Token: 0x0400DED6 RID: 57046
	private static int __PropertyOffset_MatForDeactivatingDataLayers;

	// Token: 0x0400DED7 RID: 57047
	private static int __PropertyOffset_SeqForSourceIn;

	// Token: 0x0400DED8 RID: 57048
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceIn;

	// Token: 0x0400DED9 RID: 57049
	private static int __PropertyOffset_SeqForSourceOut;

	// Token: 0x0400DEDA RID: 57050
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceOut;

	// Token: 0x0400DEDB RID: 57051
	private static int __PropertyOffset_WaitDataLayerStreamingRadius;

	// Token: 0x0400DEDC RID: 57052
	private static int __PropertyOffset_MaxTimeForWaitDataLayerActivateFinish;

	// Token: 0x02009759 RID: 38745
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForActivatingDataLayers_FunctionParams
	{
		// Token: 0x0403068D RID: 198285
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x0200975A RID: 38746
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForActivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0403068E RID: 198286
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x0200975B RID: 38747
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForDeactivatingDataLayers_FunctionParams
	{
		// Token: 0x0403068F RID: 198287
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x0200975C RID: 38748
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForDeactivatingDataLayersSet_FunctionParams
	{
		// Token: 0x04030690 RID: 198288
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x0200975D RID: 38749
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceIn_FunctionParams
	{
		// Token: 0x04030691 RID: 198289
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x04030692 RID: 198290
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x0200975E RID: 38750
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceInSet_FunctionParams
	{
		// Token: 0x04030693 RID: 198291
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x0200975F RID: 38751
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceOut_FunctionParams
	{
		// Token: 0x04030694 RID: 198292
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x04030695 RID: 198293
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02009760 RID: 38752
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceOutSet_FunctionParams
	{
		// Token: 0x04030696 RID: 198294
		[FieldOffset(0)]
		public bool __Result;
	}
}
