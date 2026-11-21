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

// Token: 0x0200282B RID: 10283
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C")]
public class TsDataLayerTransitionTrigger : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029C8 RID: 10696
	// (get) Token: 0x06019E5A RID: 106074 RVA: 0x007FBB4E File Offset: 0x007F9D4E
	// (set) Token: 0x06019E5B RID: 106075 RVA: 0x007FBB5E File Offset: 0x007F9D5E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool FunctionEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_FunctionEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_FunctionEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029C9 RID: 10697
	// (get) Token: 0x06019E5C RID: 106076 RVA: 0x007FBB6F File Offset: 0x007F9D6F
	// (set) Token: 0x06019E5D RID: 106077 RVA: 0x007FBB7F File Offset: 0x007F9D7F
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe bool TriggerState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_TriggerState) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_TriggerState) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029CA RID: 10698
	// (get) Token: 0x06019E5E RID: 106078 RVA: 0x007FBB90 File Offset: 0x007F9D90
	// (set) Token: 0x06019E5F RID: 106079 RVA: 0x007FBBA0 File Offset: 0x007F9DA0
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe bool UseTransitionWhenTeleport
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_UseTransitionWhenTeleport) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_UseTransitionWhenTeleport) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029CB RID: 10699
	// (get) Token: 0x06019E60 RID: 106080 RVA: 0x007FBBB1 File Offset: 0x007F9DB1
	// (set) Token: 0x06019E61 RID: 106081 RVA: 0x007FBBC5 File Offset: 0x007F9DC5
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe AVolume Volume
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AVolume>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_Volume);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_Volume, value);
		}
	}

	// Token: 0x170029CC RID: 10700
	// (get) Token: 0x06019E62 RID: 106082 RVA: 0x007FBBDC File Offset: 0x007F9DDC
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	protected TMap<FName, bool> DatalayerStateMap
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TMap<FName, bool> result;
			if ((result = this._DatalayerStateMap) == null)
			{
				result = (this._DatalayerStateMap = new TMap<FName, bool>(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_DatalayerStateMap, this));
			}
			return result;
		}
	}

	// Token: 0x170029CD RID: 10701
	// (get) Token: 0x06019E63 RID: 106083 RVA: 0x007FBC15 File Offset: 0x007F9E15
	// (set) Token: 0x06019E64 RID: 106084 RVA: 0x007FBC29 File Offset: 0x007F9E29
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe UKuroSceneMatModifyDataAsset MatForActivatingDataLayers
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroSceneMatModifyDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_MatForActivatingDataLayers);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_MatForActivatingDataLayers, value);
		}
	}

	// Token: 0x170029CE RID: 10702
	// (get) Token: 0x06019E65 RID: 106085 RVA: 0x007FBC3E File Offset: 0x007F9E3E
	// (set) Token: 0x06019E66 RID: 106086 RVA: 0x007FBC52 File Offset: 0x007F9E52
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe UKuroSceneMatModifyDataAsset MatForDeactivatingDataLayers
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroSceneMatModifyDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_MatForDeactivatingDataLayers);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_MatForDeactivatingDataLayers, value);
		}
	}

	// Token: 0x170029CF RID: 10703
	// (get) Token: 0x06019E67 RID: 106087 RVA: 0x007FBC67 File Offset: 0x007F9E67
	// (set) Token: 0x06019E68 RID: 106088 RVA: 0x007FBC7B File Offset: 0x007F9E7B
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe ULevelSequence SeqForSourceIn
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_SeqForSourceIn);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_SeqForSourceIn, value);
		}
	}

	// Token: 0x170029D0 RID: 10704
	// (get) Token: 0x06019E69 RID: 106089 RVA: 0x007FBC90 File Offset: 0x007F9E90
	// (set) Token: 0x06019E6A RID: 106090 RVA: 0x007FBCA4 File Offset: 0x007F9EA4
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceIn
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)), value);
		}
	}

	// Token: 0x170029D1 RID: 10705
	// (get) Token: 0x06019E6B RID: 106091 RVA: 0x007FBCB9 File Offset: 0x007F9EB9
	// (set) Token: 0x06019E6C RID: 106092 RVA: 0x007FBCCD File Offset: 0x007F9ECD
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe ULevelSequence SeqForSourceOut
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_SeqForSourceOut);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_SeqForSourceOut, value);
		}
	}

	// Token: 0x170029D2 RID: 10706
	// (get) Token: 0x06019E6D RID: 106093 RVA: 0x007FBCE2 File Offset: 0x007F9EE2
	// (set) Token: 0x06019E6E RID: 106094 RVA: 0x007FBCF6 File Offset: 0x007F9EF6
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceOut
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)), value);
		}
	}

	// Token: 0x06019E6F RID: 106095 RVA: 0x007FBD0C File Offset: 0x007F9F0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			this.SetMatForActivatingDataLayers_Implementation(asset);
			return;
		}
		TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019E70 RID: 106096 RVA: 0x007FBDA6 File Offset: 0x007F9FA6
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

	// Token: 0x06019E71 RID: 106097 RVA: 0x007FBDD8 File Offset: 0x007F9FD8
	public void SetMatForActivatingDataLayersByPath(string path)
	{
		this.MatForActivatingDataLayers = null;
		this.MatPathForActivatingDataLayers = path;
		if (this.MatForActivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForActivatingDataLayersLoadingHandle);
			this.MatForActivatingDataLayersLoadingHandle = -1;
		}
		if (path != null)
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

	// Token: 0x06019E72 RID: 106098 RVA: 0x007FBE58 File Offset: 0x007FA058
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForActivatingDataLayersSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			return this.WasMatForActivatingDataLayersSet_Implementation();
		}
		TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019E73 RID: 106099 RVA: 0x007FBEE2 File Offset: 0x007FA0E2
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

	// Token: 0x06019E74 RID: 106100 RVA: 0x007FBF14 File Offset: 0x007FA114
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			this.SetMatForDeactivatingDataLayers_Implementation(asset);
			return;
		}
		TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019E75 RID: 106101 RVA: 0x007FBFAE File Offset: 0x007FA1AE
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

	// Token: 0x06019E76 RID: 106102 RVA: 0x007FBFE0 File Offset: 0x007FA1E0
	public void SetMatForDeactivatingDataLayersByPath(string path)
	{
		this.MatForDeactivatingDataLayers = null;
		this.MatPathForDeactivatingDataLayers = path;
		if (this.MatForDeactivatingDataLayersLoadingHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MatForDeactivatingDataLayersLoadingHandle);
			this.MatForDeactivatingDataLayersLoadingHandle = -1;
		}
		if (path != null)
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

	// Token: 0x06019E77 RID: 106103 RVA: 0x007FC060 File Offset: 0x007FA260
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForDeactivatingDataLayersSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			return this.WasMatForDeactivatingDataLayersSet_Implementation();
		}
		TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019E78 RID: 106104 RVA: 0x007FC0EA File Offset: 0x007FA2EA
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

	// Token: 0x06019E79 RID: 106105 RVA: 0x007FC11C File Offset: 0x007FA31C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetSeqForSourceIn"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			this.SetSeqForSourceIn_Implementation(asset, beforeModifyMatMark);
			return;
		}
		TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->beforeModifyMatMark), beforeModifyMatMark);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019E7A RID: 106106 RVA: 0x007FC1C4 File Offset: 0x007FA3C4
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

	// Token: 0x06019E7B RID: 106107 RVA: 0x007FC1FC File Offset: 0x007FA3FC
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
		if (path != null)
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

	// Token: 0x06019E7C RID: 106108 RVA: 0x007FC290 File Offset: 0x007FA490
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceInSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			return this.WasSeqForSourceInSet_Implementation();
		}
		TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019E7D RID: 106109 RVA: 0x007FC31A File Offset: 0x007FA51A
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

	// Token: 0x06019E7E RID: 106110 RVA: 0x007FC34C File Offset: 0x007FA54C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetSeqForSourceOut"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			this.SetSeqForSourceOut_Implementation(asset, beforeModifyMatMark);
			return;
		}
		TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->beforeModifyMatMark), beforeModifyMatMark);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019E7F RID: 106111 RVA: 0x007FC3F4 File Offset: 0x007FA5F4
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

	// Token: 0x06019E80 RID: 106112 RVA: 0x007FC42C File Offset: 0x007FA62C
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
		if (path != null)
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

	// Token: 0x06019E81 RID: 106113 RVA: 0x007FC4C0 File Offset: 0x007FA6C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceOutSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDataLayerTransitionTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), TsDataLayerTransitionTrigger.StaticClass(), out intPtr, out num))
		{
			return this.WasSeqForSourceOutSet_Implementation();
		}
		TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* ptr = stackalloc TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019E82 RID: 106114 RVA: 0x007FC54A File Offset: 0x007FA74A
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

	// Token: 0x06019E83 RID: 106115 RVA: 0x007FC57C File Offset: 0x007FA77C
	public override void ReceiveBeginPlay()
	{
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(this);
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			return;
		}
		this.InitVolume();
	}

	// Token: 0x06019E84 RID: 106116 RVA: 0x007FC5A0 File Offset: 0x007FA7A0
	private void InitVolume()
	{
		if (this.Volume == null)
		{
			return;
		}
		AVolume volume = this.Volume;
		if (volume != null)
		{
			volume.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnVolumeActorBeginOverlapHandle));
		}
		AVolume volume2 = this.Volume;
		if (volume2 != null)
		{
			volume2.OnActorEndOverlap.Add(new Action<AActor, AActor>(this.OnVolumeActorEndOverlapHandle));
		}
		AVolume volume3 = this.Volume;
		if (volume3 != null)
		{
			volume3.OnEndPlay.Add(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnVolumeEndPlayHandle));
		}
		AVolume volume4 = this.Volume;
		if (volume4 != null && volume4.IsOverlappingActor(RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined()))
		{
			this.TriggerState = true;
			this.OnTriggerStateChanged();
		}
	}

	// Token: 0x06019E85 RID: 106117 RVA: 0x007FC648 File Offset: 0x007FA848
	[NullableContext(0)]
	private void OnVolumeEndPlayHandle([Nullable(2)] AActor actor, TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		AVolume volume = this.Volume;
		if (volume != null)
		{
			volume.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.OnVolumeActorBeginOverlapHandle));
		}
		AVolume volume2 = this.Volume;
		if (volume2 == null)
		{
			return;
		}
		volume2.OnActorEndOverlap.Remove(new Action<AActor, AActor>(this.OnVolumeActorEndOverlapHandle));
	}

	// Token: 0x06019E86 RID: 106118 RVA: 0x007FC698 File Offset: 0x007FA898
	private void OnVolumeActorBeginOverlapHandle(AActor overlappedActor, AActor otherActor)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined())
		{
			return;
		}
		this.TriggerState = true;
		this.OnTriggerStateChanged();
	}

	// Token: 0x06019E87 RID: 106119 RVA: 0x007FC6B5 File Offset: 0x007FA8B5
	private void OnVolumeActorEndOverlapHandle(AActor overlappedActor, AActor otherActor)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined())
		{
			return;
		}
		this.TriggerState = false;
		this.OnTriggerStateChanged();
	}

	// Token: 0x06019E88 RID: 106120 RVA: 0x007FC6D4 File Offset: 0x007FA8D4
	public unsafe void OnTriggerStateChanged()
	{
		if (!this.FunctionEnable)
		{
			return;
		}
		HashSet<FName> hashSet = new HashSet<FName>();
		HashSet<FName> hashSet2 = new HashSet<FName>();
		foreach (KeyValuePair<FName, bool> keyValuePair in this.DatalayerStateMap)
		{
			FName fname;
			bool flag;
			keyValuePair.Deconstruct(out fname, out flag);
			FName item = fname;
			bool flag2 = flag;
			if (this.TriggerState ? flag2 : (!flag2))
			{
				hashSet.Add(item);
			}
			else
			{
				hashSet2.Add(item);
			}
		}
		if (hashSet.Count > 0 && hashSet2.Count > 0 && this.WasMatForActivatingDataLayersSet() && this.WasMatForDeactivatingDataLayersSet() && (this.TriggerState ? this.WasSeqForSourceInSet() : this.WasSeqForSourceOutSet()))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TriggerVolume;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[TsDataLayerTransitionTrigger] 暂时不支持同时控制DataLayer显示的过渡和DataLayer隐藏的过渡, 可能存在表现问题, 请检查配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this.Volume));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TriggerState", this.TriggerState);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (((hashSet.Count > 0 && this.WasMatForActivatingDataLayersSet()) || (hashSet2.Count > 0 && this.WasMatForDeactivatingDataLayersSet())) && !(this.TriggerState ? this.WasSeqForSourceInSet() : this.WasSeqForSourceOutSet()))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TriggerVolume;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[TsDataLayerTransitionTrigger] 设置了过渡DA和DataLayer, 但是没有设置过渡Seq, 可能存在表现问题, 请检查配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this.Volume));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TriggerState", this.TriggerState);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		DataLayersTransitionTask dataLayersTransitionTask = new DataLayersTransitionTask();
		dataLayersTransitionTask.ToActivateDataLayerNames = hashSet;
		dataLayersTransitionTask.ToDeactivateDataLayerNames = hashSet2;
		if (this.UseTransitionWhenTeleport || (!TeleportModel.Instance.IsTeleport && !GameModeModel.Instance.Loading))
		{
			dataLayersTransitionTask.MatDataForActivating = this.MatForActivatingDataLayers;
			dataLayersTransitionTask.MatPathForActivating = this.MatPathForActivatingDataLayers;
			dataLayersTransitionTask.MatDataForActivatingLoaded = (this.MatForActivatingDataLayersLoadingHandle == -1);
			dataLayersTransitionTask.MatDataForDeactivating = this.MatForDeactivatingDataLayers;
			dataLayersTransitionTask.MatPathForDeactivating = this.MatPathForDeactivatingDataLayers;
			dataLayersTransitionTask.MatDataForDeactivatingLoaded = (this.MatForDeactivatingDataLayersLoadingHandle == -1);
			if (this.TriggerState)
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
		dataLayersTransitionTask.ShouldWaitDataLayersActivateFinish = true;
		dataLayersTransitionTask.TaskFinishCallback = new Action<DataLayersTransitionTask, bool>(this.OnTransitionTaskFinish);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.TriggerVolume;
		ELogAuthor author3 = ELogAuthor.ZYL;
		string message3 = "[TsDataLayerTransitionTrigger] 添加DataLayer过渡切换Task";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Volume", UKismetSystemLibrary.GetPathName(this.Volume));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("TriggerState", this.TriggerState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("DataLayersToActivate", dataLayersTransitionTask.ToActivateDataLayerNames);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("DataLayersToDeactivate", dataLayersTransitionTask.ToDeactivateDataLayerNames);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
		this.TransitionTaskQueue.Push(dataLayersTransitionTask);
		this.TryStartNextTask();
	}

	// Token: 0x06019E89 RID: 106121 RVA: 0x007FCA84 File Offset: 0x007FAC84
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

	// Token: 0x06019E8A RID: 106122 RVA: 0x007FCAD7 File Offset: 0x007FACD7
	[NullableContext(1)]
	private void OnTransitionTaskFinish(DataLayersTransitionTask task, bool success)
	{
		this.ExecutingTransitionTasks.Remove(task);
		this.TryStartNextTask();
	}

	// Token: 0x06019E8B RID: 106123 RVA: 0x007FCAEC File Offset: 0x007FACEC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDataLayerTransitionTrigger._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C");
		}
		return TsDataLayerTransitionTrigger._ClassPtr;
	}

	// Token: 0x06019E8C RID: 106124 RVA: 0x007FCB10 File Offset: 0x007FAD10
	public TsDataLayerTransitionTrigger() : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E8D RID: 106125 RVA: 0x007FCB38 File Offset: 0x007FAD38
	[NullableContext(1)]
	public TsDataLayerTransitionTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E8E RID: 106126 RVA: 0x007FCB6B File Offset: 0x007FAD6B
	protected TsDataLayerTransitionTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170029D3 RID: 10707
	// (get) Token: 0x06019E8F RID: 106127 RVA: 0x007FCBA7 File Offset: 0x007FADA7
	public unsafe USceneComponent DefaultSceneRoot
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06019E90 RID: 106128 RVA: 0x007FCBBC File Offset: 0x007FADBC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06019E91 RID: 106129 RVA: 0x007FCBDC File Offset: 0x007FADDC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x06019E92 RID: 106130 RVA: 0x007FCBEC File Offset: 0x007FADEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06019E93 RID: 106131 RVA: 0x007FCC0C File Offset: 0x007FAE0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x06019E94 RID: 106132 RVA: 0x007FCC1C File Offset: 0x007FAE1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceIn_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x06019E95 RID: 106133 RVA: 0x007FCC4A File Offset: 0x007FAE4A
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceInSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x06019E96 RID: 106134 RVA: 0x007FCC58 File Offset: 0x007FAE58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceOut_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x06019E97 RID: 106135 RVA: 0x007FCC86 File Offset: 0x007FAE86
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x0400E347 RID: 58183
	private string MatPathForActivatingDataLayers;

	// Token: 0x0400E348 RID: 58184
	private int MatForActivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400E349 RID: 58185
	private string MatPathForDeactivatingDataLayers;

	// Token: 0x0400E34A RID: 58186
	private int MatForDeactivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400E34B RID: 58187
	private string SeqPathForSourceIn;

	// Token: 0x0400E34C RID: 58188
	private int SeqForSourceInLoadingHandle = -1;

	// Token: 0x0400E34D RID: 58189
	private string SeqPathForSourceOut;

	// Token: 0x0400E34E RID: 58190
	private int SeqForSourceOutLoadingHandle = -1;

	// Token: 0x0400E34F RID: 58191
	[Nullable(1)]
	private readonly Queue<DataLayersTransitionTask> TransitionTaskQueue = new Queue<DataLayersTransitionTask>(4);

	// Token: 0x0400E350 RID: 58192
	[Nullable(1)]
	private readonly HashSet<DataLayersTransitionTask> ExecutingTransitionTasks = new HashSet<DataLayersTransitionTask>();

	// Token: 0x0400E351 RID: 58193
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C";

	// Token: 0x0400E352 RID: 58194
	private static IntPtr _ClassPtr;

	// Token: 0x0400E353 RID: 58195
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E354 RID: 58196
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E355 RID: 58197
	private static int __PropertyOffset_FunctionEnable;

	// Token: 0x0400E356 RID: 58198
	private static int __PropertyOffset_TriggerState;

	// Token: 0x0400E357 RID: 58199
	private static int __PropertyOffset_UseTransitionWhenTeleport;

	// Token: 0x0400E358 RID: 58200
	private static int __PropertyOffset_Volume;

	// Token: 0x0400E359 RID: 58201
	private static int __PropertyOffset_DatalayerStateMap;

	// Token: 0x0400E35A RID: 58202
	private TMap<FName, bool> _DatalayerStateMap;

	// Token: 0x0400E35B RID: 58203
	private static int __PropertyOffset_MatForActivatingDataLayers;

	// Token: 0x0400E35C RID: 58204
	private static int __PropertyOffset_MatForDeactivatingDataLayers;

	// Token: 0x0400E35D RID: 58205
	private static int __PropertyOffset_SeqForSourceIn;

	// Token: 0x0400E35E RID: 58206
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceIn;

	// Token: 0x0400E35F RID: 58207
	private static int __PropertyOffset_SeqForSourceOut;

	// Token: 0x0400E360 RID: 58208
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceOut;

	// Token: 0x02008974 RID: 35188
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForActivatingDataLayers_FunctionParams
	{
		// Token: 0x0402BD10 RID: 179472
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x02008975 RID: 35189
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForActivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0402BD11 RID: 179473
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008976 RID: 35190
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForDeactivatingDataLayers_FunctionParams
	{
		// Token: 0x0402BD12 RID: 179474
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x02008977 RID: 35191
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForDeactivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0402BD13 RID: 179475
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008978 RID: 35192
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceIn_FunctionParams
	{
		// Token: 0x0402BD14 RID: 179476
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BD15 RID: 179477
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02008979 RID: 35193
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceInSet_FunctionParams
	{
		// Token: 0x0402BD16 RID: 179478
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x0200897A RID: 35194
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceOut_FunctionParams
	{
		// Token: 0x0402BD17 RID: 179479
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BD18 RID: 179480
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x0200897B RID: 35195
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceOutSet_FunctionParams
	{
		// Token: 0x0402BD19 RID: 179481
		[FieldOffset(0)]
		public bool __Result;
	}
}
