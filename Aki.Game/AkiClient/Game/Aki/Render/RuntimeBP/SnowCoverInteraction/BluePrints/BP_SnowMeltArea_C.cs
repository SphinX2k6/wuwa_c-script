using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003AD1 RID: 15057
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowMeltArea.BP_SnowMeltArea_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1485)]
	public class BP_SnowMeltArea_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602070E RID: 132878 RVA: 0x008D2CB4 File Offset: 0x008D0EB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowMeltArea_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowMeltArea.BP_SnowMeltArea_C");
			}
			return BP_SnowMeltArea_C._ClassPtr;
		}

		// Token: 0x0602070F RID: 132879 RVA: 0x008D2CD8 File Offset: 0x008D0ED8
		public BP_SnowMeltArea_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowMeltArea_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020710 RID: 132880 RVA: 0x008D2D00 File Offset: 0x008D0F00
		[NullableContext(1)]
		public BP_SnowMeltArea_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowMeltArea_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06020711 RID: 132881 RVA: 0x008D2D33 File Offset: 0x008D0F33
		// (set) Token: 0x06020712 RID: 132882 RVA: 0x008D2D47 File Offset: 0x008D0F47
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowMeltArea_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowMeltArea_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06020713 RID: 132883 RVA: 0x008D2D5C File Offset: 0x008D0F5C
		// (set) Token: 0x06020714 RID: 132884 RVA: 0x008D2D70 File Offset: 0x008D0F70
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowMeltArea_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowMeltArea_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06020715 RID: 132885 RVA: 0x008D2D85 File Offset: 0x008D0F85
		// (set) Token: 0x06020716 RID: 132886 RVA: 0x008D2D95 File Offset: 0x008D0F95
		public unsafe float 融化程度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06020717 RID: 132887 RVA: 0x008D2DA6 File Offset: 0x008D0FA6
		// (set) Token: 0x06020718 RID: 132888 RVA: 0x008D2DB6 File Offset: 0x008D0FB6
		public unsafe float 融化范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06020719 RID: 132889 RVA: 0x008D2DC7 File Offset: 0x008D0FC7
		// (set) Token: 0x0602071A RID: 132890 RVA: 0x008D2DD7 File Offset: 0x008D0FD7
		public unsafe float 融化过渡距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0602071B RID: 132891 RVA: 0x008D2DE8 File Offset: 0x008D0FE8
		// (set) Token: 0x0602071C RID: 132892 RVA: 0x008D2DF8 File Offset: 0x008D0FF8
		public unsafe bool OnMeltPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowMeltArea_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602071D RID: 132893 RVA: 0x008D2E09 File Offset: 0x008D1009
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowMeltArea_C.__SetMPC_NativeFunctionPtr, null);
		}

		// Token: 0x0602071E RID: 132894 RVA: 0x008D2E1D File Offset: 0x008D101D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowMeltArea_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602071F RID: 132895 RVA: 0x008D2E31 File Offset: 0x008D1031
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowMeltArea_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020720 RID: 132896 RVA: 0x008D2E48 File Offset: 0x008D1048
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowMeltArea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowMeltArea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowMeltArea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowMeltArea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowMeltArea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020721 RID: 132897 RVA: 0x008D2E90 File Offset: 0x008D1090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowMeltArea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowMeltArea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowMeltArea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowMeltArea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowMeltArea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020722 RID: 132898 RVA: 0x008D2ED8 File Offset: 0x008D10D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SnowMeltArea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowMeltArea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowMeltArea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowMeltArea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowMeltArea_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020723 RID: 132899 RVA: 0x008D2F20 File Offset: 0x008D1120
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SnowMeltArea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowMeltArea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowMeltArea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowMeltArea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowMeltArea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020724 RID: 132900 RVA: 0x008D2F67 File Offset: 0x008D1167
		protected BP_SnowMeltArea_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB5C RID: 64348
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowMeltArea.BP_SnowMeltArea_C";

		// Token: 0x0400FB5D RID: 64349
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB5E RID: 64350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB5F RID: 64351
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB60 RID: 64352
		internal static int __PropertyOffset_2;

		// Token: 0x0400FB61 RID: 64353
		internal static int __PropertyOffset_3;

		// Token: 0x0400FB62 RID: 64354
		internal static int __PropertyOffset_4;

		// Token: 0x0400FB63 RID: 64355
		internal static int __PropertyOffset_5;

		// Token: 0x0400FB64 RID: 64356
		internal static int __PropertyOffset_6;

		// Token: 0x0400FB65 RID: 64357
		private static IntPtr __SetMPC_NativeFunctionPtr;

		// Token: 0x0400FB66 RID: 64358
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FB67 RID: 64359
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FB68 RID: 64360
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009BB7 RID: 39863
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031235 RID: 201269
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BB8 RID: 39864
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031236 RID: 201270
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
