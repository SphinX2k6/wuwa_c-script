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

// Token: 0x020032BA RID: 12986
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C")]
public class TsDataLayerTransitionTrigger : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026DB RID: 9947
	// (get) Token: 0x0601C219 RID: 115225 RVA: 0x007D4A52 File Offset: 0x007D2C52
	// (set) Token: 0x0601C21A RID: 115226 RVA: 0x007D4A62 File Offset: 0x007D2C62
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

	// Token: 0x170026DC RID: 9948
	// (get) Token: 0x0601C21B RID: 115227 RVA: 0x007D4A73 File Offset: 0x007D2C73
	// (set) Token: 0x0601C21C RID: 115228 RVA: 0x007D4A83 File Offset: 0x007D2C83
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

	// Token: 0x170026DD RID: 9949
	// (get) Token: 0x0601C21D RID: 115229 RVA: 0x007D4A94 File Offset: 0x007D2C94
	// (set) Token: 0x0601C21E RID: 115230 RVA: 0x007D4AA4 File Offset: 0x007D2CA4
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

	// Token: 0x170026DE RID: 9950
	// (get) Token: 0x0601C21F RID: 115231 RVA: 0x007D4AB5 File Offset: 0x007D2CB5
	// (set) Token: 0x0601C220 RID: 115232 RVA: 0x007D4AC9 File Offset: 0x007D2CC9
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

	// Token: 0x170026DF RID: 9951
	// (get) Token: 0x0601C221 RID: 115233 RVA: 0x007D4AE0 File Offset: 0x007D2CE0
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

	// Token: 0x170026E0 RID: 9952
	// (get) Token: 0x0601C222 RID: 115234 RVA: 0x007D4B19 File Offset: 0x007D2D19
	// (set) Token: 0x0601C223 RID: 115235 RVA: 0x007D4B2D File Offset: 0x007D2D2D
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

	// Token: 0x170026E1 RID: 9953
	// (get) Token: 0x0601C224 RID: 115236 RVA: 0x007D4B42 File Offset: 0x007D2D42
	// (set) Token: 0x0601C225 RID: 115237 RVA: 0x007D4B56 File Offset: 0x007D2D56
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

	// Token: 0x170026E2 RID: 9954
	// (get) Token: 0x0601C226 RID: 115238 RVA: 0x007D4B6B File Offset: 0x007D2D6B
	// (set) Token: 0x0601C227 RID: 115239 RVA: 0x007D4B7F File Offset: 0x007D2D7F
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

	// Token: 0x170026E3 RID: 9955
	// (get) Token: 0x0601C228 RID: 115240 RVA: 0x007D4B94 File Offset: 0x007D2D94
	// (set) Token: 0x0601C229 RID: 115241 RVA: 0x007D4BA8 File Offset: 0x007D2DA8
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

	// Token: 0x170026E4 RID: 9956
	// (get) Token: 0x0601C22A RID: 115242 RVA: 0x007D4BBD File Offset: 0x007D2DBD
	// (set) Token: 0x0601C22B RID: 115243 RVA: 0x007D4BD1 File Offset: 0x007D2DD1
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

	// Token: 0x170026E5 RID: 9957
	// (get) Token: 0x0601C22C RID: 115244 RVA: 0x007D4BE6 File Offset: 0x007D2DE6
	// (set) Token: 0x0601C22D RID: 115245 RVA: 0x007D4BFA File Offset: 0x007D2DFA
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

	// Token: 0x0601C22E RID: 115246 RVA: 0x007D4C10 File Offset: 0x007D2E10
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C22F RID: 115247 RVA: 0x007D4C94 File Offset: 0x007D2E94
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

	// Token: 0x0601C230 RID: 115248 RVA: 0x007D4CC4 File Offset: 0x007D2EC4
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

	// Token: 0x0601C231 RID: 115249 RVA: 0x007D4D44 File Offset: 0x007D2F44
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForActivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L);
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

	// Token: 0x0601C232 RID: 115250 RVA: 0x007D4DB9 File Offset: 0x007D2FB9
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

	// Token: 0x0601C233 RID: 115251 RVA: 0x007D4DEC File Offset: 0x007D2FEC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C234 RID: 115252 RVA: 0x007D4E70 File Offset: 0x007D3070
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

	// Token: 0x0601C235 RID: 115253 RVA: 0x007D4EA0 File Offset: 0x007D30A0
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

	// Token: 0x0601C236 RID: 115254 RVA: 0x007D4F20 File Offset: 0x007D3120
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForDeactivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L);
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

	// Token: 0x0601C237 RID: 115255 RVA: 0x007D4F95 File Offset: 0x007D3195
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

	// Token: 0x0601C238 RID: 115256 RVA: 0x007D4FC8 File Offset: 0x007D31C8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceIn"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams) & -16L);
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

	// Token: 0x0601C239 RID: 115257 RVA: 0x007D5059 File Offset: 0x007D3259
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

	// Token: 0x0601C23A RID: 115258 RVA: 0x007D5090 File Offset: 0x007D3290
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

	// Token: 0x0601C23B RID: 115259 RVA: 0x007D5124 File Offset: 0x007D3324
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceInSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams) & -16L);
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

	// Token: 0x0601C23C RID: 115260 RVA: 0x007D5199 File Offset: 0x007D3399
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

	// Token: 0x0601C23D RID: 115261 RVA: 0x007D51CC File Offset: 0x007D33CC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceOut"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams) & -16L);
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

	// Token: 0x0601C23E RID: 115262 RVA: 0x007D525D File Offset: 0x007D345D
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

	// Token: 0x0601C23F RID: 115263 RVA: 0x007D5294 File Offset: 0x007D3494
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

	// Token: 0x0601C240 RID: 115264 RVA: 0x007D5328 File Offset: 0x007D3528
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceOutSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams) & -16L);
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

	// Token: 0x0601C241 RID: 115265 RVA: 0x007D539D File Offset: 0x007D359D
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

	// Token: 0x0601C242 RID: 115266 RVA: 0x007D53D0 File Offset: 0x007D35D0
	public override void ReceiveBeginPlay()
	{
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(this);
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			return;
		}
		this.InitVolume();
	}

	// Token: 0x0601C243 RID: 115267 RVA: 0x007D53F4 File Offset: 0x007D35F4
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

	// Token: 0x0601C244 RID: 115268 RVA: 0x007D549C File Offset: 0x007D369C
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

	// Token: 0x0601C245 RID: 115269 RVA: 0x007D54EC File Offset: 0x007D36EC
	private void OnVolumeActorBeginOverlapHandle(AActor overlappedActor, AActor otherActor)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined())
		{
			return;
		}
		this.TriggerState = true;
		this.OnTriggerStateChanged();
	}

	// Token: 0x0601C246 RID: 115270 RVA: 0x007D5509 File Offset: 0x007D3709
	private void OnVolumeActorEndOverlapHandle(AActor overlappedActor, AActor otherActor)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined())
		{
			return;
		}
		this.TriggerState = false;
		this.OnTriggerStateChanged();
	}

	// Token: 0x0601C247 RID: 115271 RVA: 0x007D5528 File Offset: 0x007D3728
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

	// Token: 0x0601C248 RID: 115272 RVA: 0x007D58D8 File Offset: 0x007D3AD8
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

	// Token: 0x0601C249 RID: 115273 RVA: 0x007D592B File Offset: 0x007D3B2B
	[NullableContext(1)]
	private void OnTransitionTaskFinish(DataLayersTransitionTask task, bool success)
	{
		this.ExecutingTransitionTasks.Remove(task);
		this.TryStartNextTask();
	}

	// Token: 0x0601C24A RID: 115274 RVA: 0x007D5940 File Offset: 0x007D3B40
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDataLayerTransitionTrigger._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C");
		}
		return TsDataLayerTransitionTrigger._ClassPtr;
	}

	// Token: 0x0601C24B RID: 115275 RVA: 0x007D5964 File Offset: 0x007D3B64
	public TsDataLayerTransitionTrigger() : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C24C RID: 115276 RVA: 0x007D598C File Offset: 0x007D3B8C
	[NullableContext(1)]
	public TsDataLayerTransitionTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C24D RID: 115277 RVA: 0x007D59BF File Offset: 0x007D3BBF
	protected TsDataLayerTransitionTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170026E6 RID: 9958
	// (get) Token: 0x0601C24E RID: 115278 RVA: 0x007D59FB File Offset: 0x007D3BFB
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsDataLayerTransitionTrigger.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x170026E7 RID: 9959
	// (get) Token: 0x0601C24F RID: 115279 RVA: 0x007D5A0B File Offset: 0x007D3C0B
	public unsafe USceneComponent DefaultSceneRoot
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsDataLayerTransitionTrigger.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601C250 RID: 115280 RVA: 0x007D5A20 File Offset: 0x007D3C20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C251 RID: 115281 RVA: 0x007D5A40 File Offset: 0x007D3C40
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C252 RID: 115282 RVA: 0x007D5A50 File Offset: 0x007D3C50
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C253 RID: 115283 RVA: 0x007D5A70 File Offset: 0x007D3C70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C254 RID: 115284 RVA: 0x007D5A80 File Offset: 0x007D3C80
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceIn_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C255 RID: 115285 RVA: 0x007D5AAE File Offset: 0x007D3CAE
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceInSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x0601C256 RID: 115286 RVA: 0x007D5ABC File Offset: 0x007D3CBC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceOut_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C257 RID: 115287 RVA: 0x007D5AEA File Offset: 0x007D3CEA
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x0400DEA1 RID: 56993
	private string MatPathForActivatingDataLayers;

	// Token: 0x0400DEA2 RID: 56994
	private int MatForActivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400DEA3 RID: 56995
	private string MatPathForDeactivatingDataLayers;

	// Token: 0x0400DEA4 RID: 56996
	private int MatForDeactivatingDataLayersLoadingHandle = -1;

	// Token: 0x0400DEA5 RID: 56997
	private string SeqPathForSourceIn;

	// Token: 0x0400DEA6 RID: 56998
	private int SeqForSourceInLoadingHandle = -1;

	// Token: 0x0400DEA7 RID: 56999
	private string SeqPathForSourceOut;

	// Token: 0x0400DEA8 RID: 57000
	private int SeqForSourceOutLoadingHandle = -1;

	// Token: 0x0400DEA9 RID: 57001
	[Nullable(1)]
	private readonly Queue<DataLayersTransitionTask> TransitionTaskQueue = new Queue<DataLayersTransitionTask>(4);

	// Token: 0x0400DEAA RID: 57002
	[Nullable(1)]
	private readonly HashSet<DataLayersTransitionTask> ExecutingTransitionTasks = new HashSet<DataLayersTransitionTask>();

	// Token: 0x0400DEAB RID: 57003
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsDataLayerTransitionTrigger.TsDataLayerTransitionTrigger_C";

	// Token: 0x0400DEAC RID: 57004
	private static IntPtr _ClassPtr;

	// Token: 0x0400DEAD RID: 57005
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DEAE RID: 57006
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400DEAF RID: 57007
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400DEB0 RID: 57008
	private static int __PropertyOffset_FunctionEnable;

	// Token: 0x0400DEB1 RID: 57009
	private static int __PropertyOffset_TriggerState;

	// Token: 0x0400DEB2 RID: 57010
	private static int __PropertyOffset_UseTransitionWhenTeleport;

	// Token: 0x0400DEB3 RID: 57011
	private static int __PropertyOffset_Volume;

	// Token: 0x0400DEB4 RID: 57012
	private static int __PropertyOffset_DatalayerStateMap;

	// Token: 0x0400DEB5 RID: 57013
	private TMap<FName, bool> _DatalayerStateMap;

	// Token: 0x0400DEB6 RID: 57014
	private static int __PropertyOffset_MatForActivatingDataLayers;

	// Token: 0x0400DEB7 RID: 57015
	private static int __PropertyOffset_MatForDeactivatingDataLayers;

	// Token: 0x0400DEB8 RID: 57016
	private static int __PropertyOffset_SeqForSourceIn;

	// Token: 0x0400DEB9 RID: 57017
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceIn;

	// Token: 0x0400DEBA RID: 57018
	private static int __PropertyOffset_SeqForSourceOut;

	// Token: 0x0400DEBB RID: 57019
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceOut;

	// Token: 0x0200974D RID: 38733
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForActivatingDataLayers_FunctionParams
	{
		// Token: 0x04030679 RID: 198265
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x0200974E RID: 38734
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForActivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0403067A RID: 198266
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x0200974F RID: 38735
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForDeactivatingDataLayers_FunctionParams
	{
		// Token: 0x0403067B RID: 198267
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x02009750 RID: 38736
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForDeactivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0403067C RID: 198268
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02009751 RID: 38737
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceIn_FunctionParams
	{
		// Token: 0x0403067D RID: 198269
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0403067E RID: 198270
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02009752 RID: 38738
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceInSet_FunctionParams
	{
		// Token: 0x0403067F RID: 198271
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02009753 RID: 38739
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceOut_FunctionParams
	{
		// Token: 0x04030680 RID: 198272
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x04030681 RID: 198273
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02009754 RID: 38740
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceOutSet_FunctionParams
	{
		// Token: 0x04030682 RID: 198274
		[FieldOffset(0)]
		public bool __Result;
	}
}
