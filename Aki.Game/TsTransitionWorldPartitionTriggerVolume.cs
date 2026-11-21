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

// Token: 0x0200282D RID: 10285
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C")]
public class TsTransitionWorldPartitionTriggerVolume : AWorldPartitionTriggerVolume, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029DB RID: 10715
	// (get) Token: 0x06019EAC RID: 106156 RVA: 0x007FCF18 File Offset: 0x007FB118
	// (set) Token: 0x06019EAD RID: 106157 RVA: 0x007FCF28 File Offset: 0x007FB128
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

	// Token: 0x170029DC RID: 10716
	// (get) Token: 0x06019EAE RID: 106158 RVA: 0x007FCF39 File Offset: 0x007FB139
	// (set) Token: 0x06019EAF RID: 106159 RVA: 0x007FCF49 File Offset: 0x007FB149
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

	// Token: 0x170029DD RID: 10717
	// (get) Token: 0x06019EB0 RID: 106160 RVA: 0x007FCF5C File Offset: 0x007FB15C
	// (set) Token: 0x06019EB1 RID: 106161 RVA: 0x007FCF95 File Offset: 0x007FB195
	[UProperty(EPropertyFlags.CPF_None)]
	protected TSoftObjectPtr<UKuroSceneMatModifyDataAsset> MatForActivatingDataLayers
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UKuroSceneMatModifyDataAsset> result;
			if ((result = this._MatForActivatingDataLayers) == null)
			{
				result = (this._MatForActivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForActivatingDataLayers, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForActivatingDataLayers, 1);
		}
	}

	// Token: 0x170029DE RID: 10718
	// (get) Token: 0x06019EB2 RID: 106162 RVA: 0x007FCFBC File Offset: 0x007FB1BC
	// (set) Token: 0x06019EB3 RID: 106163 RVA: 0x007FCFF5 File Offset: 0x007FB1F5
	[UProperty(EPropertyFlags.CPF_None)]
	protected TSoftObjectPtr<UKuroSceneMatModifyDataAsset> MatForDeactivatingDataLayers
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UKuroSceneMatModifyDataAsset> result;
			if ((result = this._MatForDeactivatingDataLayers) == null)
			{
				result = (this._MatForDeactivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForDeactivatingDataLayers, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_MatForDeactivatingDataLayers, 1);
		}
	}

	// Token: 0x170029DF RID: 10719
	// (get) Token: 0x06019EB4 RID: 106164 RVA: 0x007FD01C File Offset: 0x007FB21C
	// (set) Token: 0x06019EB5 RID: 106165 RVA: 0x007FD055 File Offset: 0x007FB255
	[UProperty(EPropertyFlags.CPF_None)]
	protected TSoftObjectPtr<ULevelSequence> SeqForSourceIn
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<ULevelSequence> result;
			if ((result = this._SeqForSourceIn) == null)
			{
				result = (this._SeqForSourceIn = new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceIn, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceIn, 1);
		}
	}

	// Token: 0x170029E0 RID: 10720
	// (get) Token: 0x06019EB6 RID: 106166 RVA: 0x007FD07A File Offset: 0x007FB27A
	// (set) Token: 0x06019EB7 RID: 106167 RVA: 0x007FD08E File Offset: 0x007FB28E
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceIn
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceIn)), value);
		}
	}

	// Token: 0x170029E1 RID: 10721
	// (get) Token: 0x06019EB8 RID: 106168 RVA: 0x007FD0A4 File Offset: 0x007FB2A4
	// (set) Token: 0x06019EB9 RID: 106169 RVA: 0x007FD0DD File Offset: 0x007FB2DD
	[UProperty(EPropertyFlags.CPF_None)]
	protected TSoftObjectPtr<ULevelSequence> SeqForSourceOut
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<ULevelSequence> result;
			if ((result = this._SeqForSourceOut) == null)
			{
				result = (this._SeqForSourceOut = new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceOut, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqForSourceOut, 1);
		}
	}

	// Token: 0x170029E2 RID: 10722
	// (get) Token: 0x06019EBA RID: 106170 RVA: 0x007FD102 File Offset: 0x007FB302
	// (set) Token: 0x06019EBB RID: 106171 RVA: 0x007FD116 File Offset: 0x007FB316
	[UProperty(EPropertyFlags.CPF_None)]
	protected unsafe string SeqMarkBeforeModifyMatForSourceOut
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTransitionWorldPartitionTriggerVolume.__PropertyOffset_SeqMarkBeforeModifyMatForSourceOut)), value);
		}
	}

	// Token: 0x170029E3 RID: 10723
	// (get) Token: 0x06019EBC RID: 106172 RVA: 0x007FD12B File Offset: 0x007FB32B
	// (set) Token: 0x06019EBD RID: 106173 RVA: 0x007FD13B File Offset: 0x007FB33B
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

	// Token: 0x170029E4 RID: 10724
	// (get) Token: 0x06019EBE RID: 106174 RVA: 0x007FD14C File Offset: 0x007FB34C
	// (set) Token: 0x06019EBF RID: 106175 RVA: 0x007FD15C File Offset: 0x007FB35C
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

	// Token: 0x06019EC0 RID: 106176 RVA: 0x007FD170 File Offset: 0x007FB370
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.SetMatForActivatingDataLayers_Implementation(asset);
			return;
		}
		TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019EC1 RID: 106177 RVA: 0x007FD20A File Offset: 0x007FB40A
	[NullableContext(2)]
	protected void SetMatForActivatingDataLayers_Implementation(UKuroSceneMatModifyDataAsset asset)
	{
		this.MatForActivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(asset);
	}

	// Token: 0x06019EC2 RID: 106178 RVA: 0x007FD218 File Offset: 0x007FB418
	[NullableContext(2)]
	public void SetMatForActivatingDataLayersByPath(string path)
	{
		this.MatForActivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(path ?? "");
	}

	// Token: 0x06019EC3 RID: 106179 RVA: 0x007FD230 File Offset: 0x007FB430
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForActivatingDataLayersSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			return this.WasMatForActivatingDataLayersSet_Implementation();
		}
		TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019EC4 RID: 106180 RVA: 0x007FD2BA File Offset: 0x007FB4BA
	protected bool WasMatForActivatingDataLayersSet_Implementation()
	{
		return this.MatForActivatingDataLayers != null && ObjectUtils.SoftObjectReferenceValid<UKuroSceneMatModifyDataAsset>(this.MatForActivatingDataLayers);
	}

	// Token: 0x06019EC5 RID: 106181 RVA: 0x007FD2D8 File Offset: 0x007FB4D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.SetMatForDeactivatingDataLayers_Implementation(asset);
			return;
		}
		TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019EC6 RID: 106182 RVA: 0x007FD372 File Offset: 0x007FB572
	[NullableContext(2)]
	protected void SetMatForDeactivatingDataLayers_Implementation(UKuroSceneMatModifyDataAsset asset)
	{
		this.MatForDeactivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(asset);
	}

	// Token: 0x06019EC7 RID: 106183 RVA: 0x007FD380 File Offset: 0x007FB580
	[NullableContext(2)]
	public void SetMatForDeactivatingDataLayersByPath(string path)
	{
		this.MatForDeactivatingDataLayers = new TSoftObjectPtr<UKuroSceneMatModifyDataAsset>(path ?? "");
	}

	// Token: 0x06019EC8 RID: 106184 RVA: 0x007FD398 File Offset: 0x007FB598
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasMatForDeactivatingDataLayersSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			return this.WasMatForDeactivatingDataLayersSet_Implementation();
		}
		TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019EC9 RID: 106185 RVA: 0x007FD422 File Offset: 0x007FB622
	protected bool WasMatForDeactivatingDataLayersSet_Implementation()
	{
		return this.MatForDeactivatingDataLayers != null && ObjectUtils.SoftObjectReferenceValid<UKuroSceneMatModifyDataAsset>(this.MatForDeactivatingDataLayers);
	}

	// Token: 0x06019ECA RID: 106186 RVA: 0x007FD440 File Offset: 0x007FB640
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetSeqForSourceIn"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.SetSeqForSourceIn_Implementation(asset, beforeModifyMatMark);
			return;
		}
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->beforeModifyMatMark), beforeModifyMatMark);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019ECB RID: 106187 RVA: 0x007FD4E8 File Offset: 0x007FB6E8
	protected void SetSeqForSourceIn_Implementation([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		this.SeqForSourceIn = new TSoftObjectPtr<ULevelSequence>(asset);
		this.SeqMarkBeforeModifyMatForSourceIn = beforeModifyMatMark;
	}

	// Token: 0x06019ECC RID: 106188 RVA: 0x007FD4FD File Offset: 0x007FB6FD
	public void SetSeqForSourceInByPath([Nullable(2)] string path, string beforeModifyMatMark = "")
	{
		this.SeqForSourceIn = new TSoftObjectPtr<ULevelSequence>(path ?? "");
		this.SeqMarkBeforeModifyMatForSourceIn = beforeModifyMatMark;
	}

	// Token: 0x06019ECD RID: 106189 RVA: 0x007FD51C File Offset: 0x007FB71C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceInSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			return this.WasSeqForSourceInSet_Implementation();
		}
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019ECE RID: 106190 RVA: 0x007FD5A6 File Offset: 0x007FB7A6
	protected bool WasSeqForSourceInSet_Implementation()
	{
		return this.SeqForSourceIn != null && ObjectUtils.SoftObjectReferenceValid<ULevelSequence>(this.SeqForSourceIn);
	}

	// Token: 0x06019ECF RID: 106191 RVA: 0x007FD5C4 File Offset: 0x007FB7C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetSeqForSourceOut"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.SetSeqForSourceOut_Implementation(asset, beforeModifyMatMark);
			return;
		}
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		FString.CopyFrom((void*)(&ptr->beforeModifyMatMark), beforeModifyMatMark);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019ED0 RID: 106192 RVA: 0x007FD66C File Offset: 0x007FB86C
	protected void SetSeqForSourceOut_Implementation([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		this.SeqForSourceOut = new TSoftObjectPtr<ULevelSequence>(asset);
		this.SeqMarkBeforeModifyMatForSourceOut = beforeModifyMatMark;
	}

	// Token: 0x06019ED1 RID: 106193 RVA: 0x007FD681 File Offset: 0x007FB881
	public void SetSeqForSourceOutByPath([Nullable(2)] string path, string beforeModifyMatMark = "")
	{
		this.SeqForSourceOut = new TSoftObjectPtr<ULevelSequence>(path ?? "");
		this.SeqMarkBeforeModifyMatForSourceOut = beforeModifyMatMark;
	}

	// Token: 0x06019ED2 RID: 106194 RVA: 0x007FD6A0 File Offset: 0x007FB8A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool WasSeqForSourceOutSet()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			return this.WasSeqForSourceOutSet_Implementation();
		}
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* ptr = stackalloc TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06019ED3 RID: 106195 RVA: 0x007FD72A File Offset: 0x007FB92A
	protected bool WasSeqForSourceOutSet_Implementation()
	{
		return this.SeqForSourceOut != null && ObjectUtils.SoftObjectReferenceValid<ULevelSequence>(this.SeqForSourceOut);
	}

	// Token: 0x06019ED4 RID: 106196 RVA: 0x007FD748 File Offset: 0x007FB948
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnStateChanged()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnStateChanged"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnStateChanged_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019ED5 RID: 106197 RVA: 0x007FD7A4 File Offset: 0x007FB9A4
	protected unsafe override void OnStateChanged_Implementation()
	{
		if (!this.FunctionEnable || this.IsEndingPlay)
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
			if (hashSet.Count > 0 && this.WasMatForActivatingDataLayersSet())
			{
				dataLayersTransitionTask.MatPathForActivating = this.MatForActivatingDataLayers.ToAssetPathName();
			}
			if (hashSet2.Count > 0 && this.WasMatForDeactivatingDataLayersSet())
			{
				dataLayersTransitionTask.MatPathForDeactivating = this.MatForDeactivatingDataLayers.ToAssetPathName();
			}
			if (base.State == EWorldPartitionTriggerVolumeState.StreamingSourceIn)
			{
				if (this.WasSeqForSourceInSet())
				{
					dataLayersTransitionTask.SeqPath = this.SeqForSourceIn.ToAssetPathName();
				}
				dataLayersTransitionTask.SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMatForSourceIn;
			}
			else
			{
				if (this.WasSeqForSourceOutSet())
				{
					dataLayersTransitionTask.SeqPath = this.SeqForSourceOut.ToAssetPathName();
				}
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

	// Token: 0x06019ED6 RID: 106198 RVA: 0x007FDCD8 File Offset: 0x007FBED8
	private void TryStartNextTask()
	{
		if (this.IsEndingPlay || this.ExecutingTransitionTasks.Count > 0)
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

	// Token: 0x06019ED7 RID: 106199 RVA: 0x007FDD33 File Offset: 0x007FBF33
	private void OnTransitionTaskFinish(DataLayersTransitionTask task, bool success)
	{
		task.MatDataForActivating = null;
		task.MatDataForDeactivating = null;
		task.SeqData = null;
		task.TaskFinishCallback = null;
		this.ExecutingTransitionTasks.Remove(task);
		if (!this.IsEndingPlay)
		{
			this.TryStartNextTask();
		}
	}

	// Token: 0x06019ED8 RID: 106200 RVA: 0x007FDD6C File Offset: 0x007FBF6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTransitionWorldPartitionTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsTransitionWorldPartitionTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019ED9 RID: 106201 RVA: 0x007FDDFC File Offset: 0x007FBFFC
	protected void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		this.IsEndingPlay = true;
		this.TransitionTaskQueue.Clear();
		foreach (DataLayersTransitionTask dataLayersTransitionTask in new List<DataLayersTransitionTask>(this.ExecutingTransitionTasks))
		{
			dataLayersTransitionTask.AbortTask();
		}
	}

	// Token: 0x06019EDA RID: 106202 RVA: 0x007FDE64 File Offset: 0x007FC064
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTransitionWorldPartitionTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C");
		}
		return TsTransitionWorldPartitionTriggerVolume._ClassPtr;
	}

	// Token: 0x06019EDB RID: 106203 RVA: 0x007FDE88 File Offset: 0x007FC088
	public TsTransitionWorldPartitionTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019EDC RID: 106204 RVA: 0x007FDEB0 File Offset: 0x007FC0B0
	public TsTransitionWorldPartitionTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019EDD RID: 106205 RVA: 0x007FDEE3 File Offset: 0x007FC0E3
	protected TsTransitionWorldPartitionTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019EDE RID: 106206 RVA: 0x007FDF04 File Offset: 0x007FC104
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06019EDF RID: 106207 RVA: 0x007FDF24 File Offset: 0x007FC124
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x06019EE0 RID: 106208 RVA: 0x007FDF34 File Offset: 0x007FC134
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		this.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06019EE1 RID: 106209 RVA: 0x007FDF54 File Offset: 0x007FC154
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x06019EE2 RID: 106210 RVA: 0x007FDF64 File Offset: 0x007FC164
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceIn_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x06019EE3 RID: 106211 RVA: 0x007FDF92 File Offset: 0x007FC192
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceInSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x06019EE4 RID: 106212 RVA: 0x007FDFA0 File Offset: 0x007FC1A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetSeqForSourceOut_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		this.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x06019EE5 RID: 106213 RVA: 0x007FDFCE File Offset: 0x007FC1CE
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = this.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x06019EE6 RID: 106214 RVA: 0x007FDFDC File Offset: 0x007FC1DC
	protected virtual void __CPPCALL_OnStateChanged_Implementation()
	{
		this.OnStateChanged_Implementation();
	}

	// Token: 0x06019EE7 RID: 106215 RVA: 0x007FDFE4 File Offset: 0x007FC1E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400E36B RID: 58219
	private readonly Queue<DataLayersTransitionTask> TransitionTaskQueue = new Queue<DataLayersTransitionTask>(4);

	// Token: 0x0400E36C RID: 58220
	private readonly HashSet<DataLayersTransitionTask> ExecutingTransitionTasks = new HashSet<DataLayersTransitionTask>();

	// Token: 0x0400E36D RID: 58221
	private bool IsEndingPlay;

	// Token: 0x0400E36E RID: 58222
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTransitionWorldPartitionTriggerVolume.TsTransitionWorldPartitionTriggerVolume_C";

	// Token: 0x0400E36F RID: 58223
	private static IntPtr _ClassPtr;

	// Token: 0x0400E370 RID: 58224
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E371 RID: 58225
	private static int __PropertyOffset_FunctionEnable;

	// Token: 0x0400E372 RID: 58226
	private static int __PropertyOffset_UseTransitionWhenTeleport;

	// Token: 0x0400E373 RID: 58227
	private static int __PropertyOffset_MatForActivatingDataLayers;

	// Token: 0x0400E374 RID: 58228
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UKuroSceneMatModifyDataAsset> _MatForActivatingDataLayers;

	// Token: 0x0400E375 RID: 58229
	private static int __PropertyOffset_MatForDeactivatingDataLayers;

	// Token: 0x0400E376 RID: 58230
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UKuroSceneMatModifyDataAsset> _MatForDeactivatingDataLayers;

	// Token: 0x0400E377 RID: 58231
	private static int __PropertyOffset_SeqForSourceIn;

	// Token: 0x0400E378 RID: 58232
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<ULevelSequence> _SeqForSourceIn;

	// Token: 0x0400E379 RID: 58233
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceIn;

	// Token: 0x0400E37A RID: 58234
	private static int __PropertyOffset_SeqForSourceOut;

	// Token: 0x0400E37B RID: 58235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<ULevelSequence> _SeqForSourceOut;

	// Token: 0x0400E37C RID: 58236
	private static int __PropertyOffset_SeqMarkBeforeModifyMatForSourceOut;

	// Token: 0x0400E37D RID: 58237
	private static int __PropertyOffset_WaitDataLayerStreamingRadius;

	// Token: 0x0400E37E RID: 58238
	private static int __PropertyOffset_MaxTimeForWaitDataLayerActivateFinish;

	// Token: 0x02008980 RID: 35200
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForActivatingDataLayers_FunctionParams
	{
		// Token: 0x0402BD24 RID: 179492
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x02008981 RID: 35201
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForActivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0402BD25 RID: 179493
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008982 RID: 35202
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetMatForDeactivatingDataLayers_FunctionParams
	{
		// Token: 0x0402BD26 RID: 179494
		[FieldOffset(0)]
		public IntPtr asset;
	}

	// Token: 0x02008983 RID: 35203
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasMatForDeactivatingDataLayersSet_FunctionParams
	{
		// Token: 0x0402BD27 RID: 179495
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008984 RID: 35204
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceIn_FunctionParams
	{
		// Token: 0x0402BD28 RID: 179496
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BD29 RID: 179497
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02008985 RID: 35205
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceInSet_FunctionParams
	{
		// Token: 0x0402BD2A RID: 179498
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008986 RID: 35206
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSeqForSourceOut_FunctionParams
	{
		// Token: 0x0402BD2B RID: 179499
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BD2C RID: 179500
		[FieldOffset(8)]
		public FString beforeModifyMatMark;
	}

	// Token: 0x02008987 RID: 35207
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __WasSeqForSourceOutSet_FunctionParams
	{
		// Token: 0x0402BD2D RID: 179501
		[FieldOffset(0)]
		public bool __Result;
	}
}
