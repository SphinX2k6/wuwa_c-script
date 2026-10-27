using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.AreaLightManager.Asset;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.AreaLightManager
{
	// Token: 0x02003BA6 RID: 15270
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaLightManager.BP_AreaLightManager_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1148)]
	public class BP_AreaLightManager_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022050 RID: 139344 RVA: 0x008FCDD5 File Offset: 0x008FAFD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AreaLightManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaLightManager.BP_AreaLightManager_C");
			}
			return BP_AreaLightManager_C._ClassPtr;
		}

		// Token: 0x06022051 RID: 139345 RVA: 0x008FCDFC File Offset: 0x008FAFFC
		public BP_AreaLightManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_AreaLightManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022052 RID: 139346 RVA: 0x008FCE24 File Offset: 0x008FB024
		[NullableContext(1)]
		public BP_AreaLightManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AreaLightManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x06022053 RID: 139347 RVA: 0x008FCE57 File Offset: 0x008FB057
		// (set) Token: 0x06022054 RID: 139348 RVA: 0x008FCE6B File Offset: 0x008FB06B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaLightManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaLightManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x06022055 RID: 139349 RVA: 0x008FCE80 File Offset: 0x008FB080
		// (set) Token: 0x06022056 RID: 139350 RVA: 0x008FCEB9 File Offset: 0x008FB0B9
		[Nullable(1)]
		public TMap<int, SAreaAdjacencyList> AreaAdjacencyList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, SAreaAdjacencyList> result;
				if ((result = this._AreaAdjacencyList) == null)
				{
					result = (this._AreaAdjacencyList = new TMap<int, SAreaAdjacencyList>(base.NativePtr + (IntPtr)BP_AreaLightManager_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AreaAdjacencyList.CopyAssign(value);
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x06022057 RID: 139351 RVA: 0x008FCEC7 File Offset: 0x008FB0C7
		// (set) Token: 0x06022058 RID: 139352 RVA: 0x008FCED7 File Offset: 0x008FB0D7
		public unsafe int Player_in_Area_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AreaLightManager_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AreaLightManager_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06022059 RID: 139353 RVA: 0x008FCEE8 File Offset: 0x008FB0E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckPlatform([Nullable(2)] AActor WordlContext, string Tag, ref bool bSaveLight)
		{
			BP_AreaLightManager_C.__CheckPlatform_FunctionParams* ptr = stackalloc BP_AreaLightManager_C.__CheckPlatform_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_AreaLightManager_C.__CheckPlatform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaLightManager_C.__CheckPlatform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WordlContext = ((WordlContext != null) ? WordlContext.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			ptr->bSaveLight = bSaveLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaLightManager_C.__CheckPlatform_NativeFunctionPtr, (void*)ptr);
			bSaveLight = ptr->bSaveLight;
			UnrealReflectionUtils.DestroyStruct(BP_AreaLightManager_C.__CheckPlatform_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602205A RID: 139354 RVA: 0x008FCF6C File Offset: 0x008FB16C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAreaIndexFromTag(string Tag, ref int AreaIndex)
		{
			BP_AreaLightManager_C.__GetAreaIndexFromTag_FunctionParams* ptr = stackalloc BP_AreaLightManager_C.__GetAreaIndexFromTag_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_AreaLightManager_C.__GetAreaIndexFromTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaLightManager_C.__GetAreaIndexFromTag_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			ptr->AreaIndex = AreaIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaLightManager_C.__GetAreaIndexFromTag_NativeFunctionPtr, (void*)ptr);
			AreaIndex = ptr->AreaIndex;
			UnrealReflectionUtils.DestroyStruct(BP_AreaLightManager_C.__GetAreaIndexFromTag_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602205B RID: 139355 RVA: 0x008FCFDC File Offset: 0x008FB1DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddAreaAdjacencyList(int Key, int Value)
		{
			BP_AreaLightManager_C.__AddAreaAdjacencyList_FunctionParams* ptr = stackalloc BP_AreaLightManager_C.__AddAreaAdjacencyList_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_AreaLightManager_C.__AddAreaAdjacencyList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaLightManager_C.__AddAreaAdjacencyList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Key = Key;
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaLightManager_C.__AddAreaAdjacencyList_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602205C RID: 139356 RVA: 0x008FD02C File Offset: 0x008FB22C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HandlePlayerCrossArea(int PlayerInAreaIndex)
		{
			BP_AreaLightManager_C.__HandlePlayerCrossArea_FunctionParams* ptr = stackalloc BP_AreaLightManager_C.__HandlePlayerCrossArea_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_AreaLightManager_C.__HandlePlayerCrossArea_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaLightManager_C.__HandlePlayerCrossArea_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerInAreaIndex = PlayerInAreaIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaLightManager_C.__HandlePlayerCrossArea_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602205D RID: 139357 RVA: 0x008FD075 File Offset: 0x008FB275
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaLightManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602205E RID: 139358 RVA: 0x008FD089 File Offset: 0x008FB289
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AreaLightManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602205F RID: 139359 RVA: 0x008FD09E File Offset: 0x008FB29E
		protected BP_AreaLightManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A5A RID: 68186
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaLightManager.BP_AreaLightManager_C";

		// Token: 0x04010A5B RID: 68187
		private static IntPtr _ClassPtr;

		// Token: 0x04010A5C RID: 68188
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A5D RID: 68189
		internal static int __PropertyOffset_1;

		// Token: 0x04010A5E RID: 68190
		internal static int __PropertyOffset_2;

		// Token: 0x04010A5F RID: 68191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SAreaAdjacencyList> _AreaAdjacencyList;

		// Token: 0x04010A60 RID: 68192
		internal static int __PropertyOffset_3;

		// Token: 0x04010A61 RID: 68193
		private static IntPtr __CheckPlatform_NativeFunctionPtr;

		// Token: 0x04010A62 RID: 68194
		private static IntPtr __GetAreaIndexFromTag_NativeFunctionPtr;

		// Token: 0x04010A63 RID: 68195
		private static IntPtr __AddAreaAdjacencyList_NativeFunctionPtr;

		// Token: 0x04010A64 RID: 68196
		private static IntPtr __HandlePlayerCrossArea_NativeFunctionPtr;

		// Token: 0x04010A65 RID: 68197
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009D14 RID: 40212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CheckPlatform_FunctionParams
		{
			// Token: 0x0403143A RID: 201786
			[FieldOffset(0)]
			public IntPtr WordlContext;

			// Token: 0x0403143B RID: 201787
			[FieldOffset(8)]
			public FString Tag;

			// Token: 0x0403143C RID: 201788
			[FieldOffset(24)]
			public bool bSaveLight;
		}

		// Token: 0x02009D15 RID: 40213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetAreaIndexFromTag_FunctionParams
		{
			// Token: 0x0403143D RID: 201789
			[FieldOffset(0)]
			public FString Tag;

			// Token: 0x0403143E RID: 201790
			[FieldOffset(16)]
			public int AreaIndex;
		}

		// Token: 0x02009D16 RID: 40214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __AddAreaAdjacencyList_FunctionParams
		{
			// Token: 0x0403143F RID: 201791
			[FieldOffset(0)]
			public int Key;

			// Token: 0x04031440 RID: 201792
			[FieldOffset(4)]
			public int Value;
		}

		// Token: 0x02009D17 RID: 40215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __HandlePlayerCrossArea_FunctionParams
		{
			// Token: 0x04031441 RID: 201793
			[FieldOffset(0)]
			public int PlayerInAreaIndex;
		}
	}
}
