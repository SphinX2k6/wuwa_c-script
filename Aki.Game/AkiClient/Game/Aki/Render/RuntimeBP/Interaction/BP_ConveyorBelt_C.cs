using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F0 RID: 12528
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_ConveyorBelt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E6C6 RID: 124614 RVA: 0x009137C3 File Offset: 0x009119C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ConveyorBelt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C");
			}
			return BP_ConveyorBelt_C._ClassPtr;
		}

		// Token: 0x0601E6C7 RID: 124615 RVA: 0x009137E8 File Offset: 0x009119E8
		public BP_ConveyorBelt_C() : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E6C8 RID: 124616 RVA: 0x00913810 File Offset: 0x00911A10
		[NullableContext(1)]
		public BP_ConveyorBelt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0601E6C9 RID: 124617 RVA: 0x00913843 File Offset: 0x00911A43
		// (set) Token: 0x0601E6CA RID: 124618 RVA: 0x00913857 File Offset: 0x00911A57
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0601E6CB RID: 124619 RVA: 0x0091386C File Offset: 0x00911A6C
		// (set) Token: 0x0601E6CC RID: 124620 RVA: 0x00913880 File Offset: 0x00911A80
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0601E6CD RID: 124621 RVA: 0x00913895 File Offset: 0x00911A95
		// (set) Token: 0x0601E6CE RID: 124622 RVA: 0x009138A9 File Offset: 0x00911AA9
		public unsafe UStaticMesh ConveyorBeltMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltMesh, value);
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0601E6CF RID: 124623 RVA: 0x009138BE File Offset: 0x00911ABE
		// (set) Token: 0x0601E6D0 RID: 124624 RVA: 0x009138CE File Offset: 0x00911ACE
		public unsafe int ConveyorBeltMaterialElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltMaterialElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltMaterialElementIndex) = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0601E6D1 RID: 124625 RVA: 0x009138DF File Offset: 0x00911ADF
		// (set) Token: 0x0601E6D2 RID: 124626 RVA: 0x009138EF File Offset: 0x00911AEF
		public unsafe float RunningSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_RunningSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_RunningSpeed) = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0601E6D3 RID: 124627 RVA: 0x00913900 File Offset: 0x00911B00
		// (set) Token: 0x0601E6D4 RID: 124628 RVA: 0x00913914 File Offset: 0x00911B14
		public unsafe UMaterialInstanceDynamic ConveyorBeltDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_ConveyorBeltDMI, value);
			}
		}

		// Token: 0x0601E6D5 RID: 124629 RVA: 0x00913929 File Offset: 0x00911B29
		[SkipLocalsInit]
		public virtual void CreateDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__CreateDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6D6 RID: 124630 RVA: 0x0091393D File Offset: 0x00911B3D
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6D7 RID: 124631 RVA: 0x00913951 File Offset: 0x00911B51
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6D8 RID: 124632 RVA: 0x00913965 File Offset: 0x00911B65
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6D9 RID: 124633 RVA: 0x00913979 File Offset: 0x00911B79
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6DA RID: 124634 RVA: 0x00913990 File Offset: 0x00911B90
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6DB RID: 124635 RVA: 0x009139D8 File Offset: 0x00911BD8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6DC RID: 124636 RVA: 0x00913A20 File Offset: 0x00911C20
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6DD RID: 124637 RVA: 0x00913A68 File Offset: 0x00911C68
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6DE RID: 124638 RVA: 0x00913AAE File Offset: 0x00911CAE
		protected BP_ConveyorBelt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101CB RID: 65995
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C";

		// Token: 0x040101CC RID: 65996
		private static IntPtr _ClassPtr;

		// Token: 0x040101CD RID: 65997
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101CE RID: 65998
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x040101CF RID: 65999
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040101D0 RID: 66000
		internal static int __PropertyOffset_ConveyorBeltMesh;

		// Token: 0x040101D1 RID: 66001
		internal static int __PropertyOffset_ConveyorBeltMaterialElementIndex;

		// Token: 0x040101D2 RID: 66002
		internal static int __PropertyOffset_RunningSpeed;

		// Token: 0x040101D3 RID: 66003
		internal static int __PropertyOffset_ConveyorBeltDMI;

		// Token: 0x040101D4 RID: 66004
		private static IntPtr __CreateDMI_NativeFunctionPtr;

		// Token: 0x040101D5 RID: 66005
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040101D6 RID: 66006
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040101D7 RID: 66007
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040101D8 RID: 66008
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008E78 RID: 36472
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAC5 RID: 182981
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E79 RID: 36473
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAC6 RID: 182982
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
