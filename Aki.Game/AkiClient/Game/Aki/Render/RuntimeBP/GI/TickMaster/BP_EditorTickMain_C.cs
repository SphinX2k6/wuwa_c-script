using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.TickMaster
{
	// Token: 0x02003D42 RID: 15682
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/TickMaster/BP_EditorTickMain.BP_EditorTickMain_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_EditorTickMain_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_EditorTickMaster_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602617D RID: 156029 RVA: 0x0096B452 File Offset: 0x00969652
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EditorTickMain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/TickMaster/BP_EditorTickMain.BP_EditorTickMain_C");
			}
			return BP_EditorTickMain_C._ClassPtr;
		}

		// Token: 0x0602617E RID: 156030 RVA: 0x0096B478 File Offset: 0x00969678
		public BP_EditorTickMain_C() : this(BuiltinUtils.AllocNativeUObject(BP_EditorTickMain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602617F RID: 156031 RVA: 0x0096B4A0 File Offset: 0x009696A0
		[NullableContext(1)]
		public BP_EditorTickMain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EditorTickMain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x06026180 RID: 156032 RVA: 0x0096B4D3 File Offset: 0x009696D3
		// (set) Token: 0x06026181 RID: 156033 RVA: 0x0096B4E7 File Offset: 0x009696E7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EditorTickMain_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EditorTickMain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x06026182 RID: 156034 RVA: 0x0096B4FC File Offset: 0x009696FC
		// (set) Token: 0x06026183 RID: 156035 RVA: 0x0096B535 File Offset: 0x00969735
		[Nullable(1)]
		public TArray<AActor> CallingActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._CallingActors) == null)
				{
					result = (this._CallingActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_EditorTickMain_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CallingActors.CopyAssign(value);
			}
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x06026184 RID: 156036 RVA: 0x0096B543 File Offset: 0x00969743
		// (set) Token: 0x06026185 RID: 156037 RVA: 0x0096B557 File Offset: 0x00969757
		public unsafe FColor Tick_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EditorTickMain_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EditorTickMain_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06026186 RID: 156038 RVA: 0x0096B56C File Offset: 0x0096976C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EditorTickMain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026187 RID: 156039 RVA: 0x0096B580 File Offset: 0x00969780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EditorTickMain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026188 RID: 156040 RVA: 0x0096B598 File Offset: 0x00969798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EditorTickMaster(float DeltaTime)
		{
			BP_EditorTickMain_C.__EditorTickMaster_FunctionParams* ptr = stackalloc BP_EditorTickMain_C.__EditorTickMaster_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EditorTickMain_C.__EditorTickMaster_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EditorTickMain_C.__EditorTickMaster_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EditorTickMain_C.__EditorTickMaster_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026189 RID: 156041 RVA: 0x0096B5E0 File Offset: 0x009697E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_EditorTickMain_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EditorTickMain_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EditorTickMain_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EditorTickMain_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EditorTickMain_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602618A RID: 156042 RVA: 0x0096B628 File Offset: 0x00969828
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_EditorTickMain_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EditorTickMain_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EditorTickMain_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EditorTickMain_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EditorTickMain_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602618B RID: 156043 RVA: 0x0096B66F File Offset: 0x0096986F
		protected BP_EditorTickMain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013121 RID: 78113
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/TickMaster/BP_EditorTickMain.BP_EditorTickMain_C";

		// Token: 0x04013122 RID: 78114
		private static IntPtr _ClassPtr;

		// Token: 0x04013123 RID: 78115
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013124 RID: 78116
		internal static int __PropertyOffset_1;

		// Token: 0x04013125 RID: 78117
		internal static int __PropertyOffset_2;

		// Token: 0x04013126 RID: 78118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _CallingActors;

		// Token: 0x04013127 RID: 78119
		internal static int __PropertyOffset_3;

		// Token: 0x04013128 RID: 78120
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013129 RID: 78121
		private static IntPtr __EditorTickMaster_NativeFunctionPtr;

		// Token: 0x0401312A RID: 78122
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A099 RID: 41113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTickMaster_FunctionParams
		{
			// Token: 0x04031B97 RID: 203671
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A09A RID: 41114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031B98 RID: 203672
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
