using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AA8 RID: 15016
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugger.BP_TrailDebugger_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class BP_TrailDebugger_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602024A RID: 131658 RVA: 0x008CAD73 File Offset: 0x008C8F73
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDebugger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugger.BP_TrailDebugger_C");
			}
			return BP_TrailDebugger_C._ClassPtr;
		}

		// Token: 0x0602024B RID: 131659 RVA: 0x008CAD98 File Offset: 0x008C8F98
		public BP_TrailDebugger_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDebugger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602024C RID: 131660 RVA: 0x008CADC0 File Offset: 0x008C8FC0
		[NullableContext(1)]
		public BP_TrailDebugger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDebugger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0602024D RID: 131661 RVA: 0x008CADF3 File Offset: 0x008C8FF3
		// (set) Token: 0x0602024E RID: 131662 RVA: 0x008CAE07 File Offset: 0x008C9007
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0602024F RID: 131663 RVA: 0x008CAE1C File Offset: 0x008C901C
		// (set) Token: 0x06020250 RID: 131664 RVA: 0x008CAE30 File Offset: 0x008C9030
		public unsafe UTextRenderComponent TextRender4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x06020251 RID: 131665 RVA: 0x008CAE45 File Offset: 0x008C9045
		// (set) Token: 0x06020252 RID: 131666 RVA: 0x008CAE59 File Offset: 0x008C9059
		public unsafe UTextRenderComponent TextRender3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x06020253 RID: 131667 RVA: 0x008CAE6E File Offset: 0x008C906E
		// (set) Token: 0x06020254 RID: 131668 RVA: 0x008CAE82 File Offset: 0x008C9082
		public unsafe UTextRenderComponent TextRender2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x06020255 RID: 131669 RVA: 0x008CAE97 File Offset: 0x008C9097
		// (set) Token: 0x06020256 RID: 131670 RVA: 0x008CAEAB File Offset: 0x008C90AB
		public unsafe UTextRenderComponent TextRender1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x06020257 RID: 131671 RVA: 0x008CAEC0 File Offset: 0x008C90C0
		// (set) Token: 0x06020258 RID: 131672 RVA: 0x008CAED4 File Offset: 0x008C90D4
		public unsafe UTextRenderComponent TextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x06020259 RID: 131673 RVA: 0x008CAEE9 File Offset: 0x008C90E9
		// (set) Token: 0x0602025A RID: 131674 RVA: 0x008CAEFD File Offset: 0x008C90FD
		public unsafe UStaticMeshComponent Plane4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0602025B RID: 131675 RVA: 0x008CAF12 File Offset: 0x008C9112
		// (set) Token: 0x0602025C RID: 131676 RVA: 0x008CAF26 File Offset: 0x008C9126
		public unsafe UStaticMeshComponent Plane3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0602025D RID: 131677 RVA: 0x008CAF3B File Offset: 0x008C913B
		// (set) Token: 0x0602025E RID: 131678 RVA: 0x008CAF4F File Offset: 0x008C914F
		public unsafe UStaticMeshComponent Plane2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0602025F RID: 131679 RVA: 0x008CAF64 File Offset: 0x008C9164
		// (set) Token: 0x06020260 RID: 131680 RVA: 0x008CAF78 File Offset: 0x008C9178
		public unsafe UStaticMeshComponent Plane1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x06020261 RID: 131681 RVA: 0x008CAF8D File Offset: 0x008C918D
		// (set) Token: 0x06020262 RID: 131682 RVA: 0x008CAFA1 File Offset: 0x008C91A1
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x06020263 RID: 131683 RVA: 0x008CAFB6 File Offset: 0x008C91B6
		// (set) Token: 0x06020264 RID: 131684 RVA: 0x008CAFCA File Offset: 0x008C91CA
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x06020265 RID: 131685 RVA: 0x008CAFDF File Offset: 0x008C91DF
		// (set) Token: 0x06020266 RID: 131686 RVA: 0x008CAFF3 File Offset: 0x008C91F3
		public unsafe BP_TrailSensorActor_C Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailSensorActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugger_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x06020267 RID: 131687 RVA: 0x008CB008 File Offset: 0x008C9208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMat(UTexture Texture, UPrimitiveComponent Plane)
		{
			BP_TrailDebugger_C.__SetMat_FunctionParams* ptr = stackalloc BP_TrailDebugger_C.__SetMat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_TrailDebugger_C.__SetMat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDebugger_C.__SetMat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->Plane = ((Plane != null) ? Plane.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDebugger_C.__SetMat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020268 RID: 131688 RVA: 0x008CB073 File Offset: 0x008C9273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDebugger_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020269 RID: 131689 RVA: 0x008CB087 File Offset: 0x008C9287
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDebugger_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602026A RID: 131690 RVA: 0x008CB09C File Offset: 0x008C929C
		protected BP_TrailDebugger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F878 RID: 63608
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugger.BP_TrailDebugger_C";

		// Token: 0x0400F879 RID: 63609
		private static IntPtr _ClassPtr;

		// Token: 0x0400F87A RID: 63610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F87B RID: 63611
		internal static int __PropertyOffset_1;

		// Token: 0x0400F87C RID: 63612
		internal static int __PropertyOffset_2;

		// Token: 0x0400F87D RID: 63613
		internal static int __PropertyOffset_3;

		// Token: 0x0400F87E RID: 63614
		internal static int __PropertyOffset_4;

		// Token: 0x0400F87F RID: 63615
		internal static int __PropertyOffset_5;

		// Token: 0x0400F880 RID: 63616
		internal static int __PropertyOffset_6;

		// Token: 0x0400F881 RID: 63617
		internal static int __PropertyOffset_7;

		// Token: 0x0400F882 RID: 63618
		internal static int __PropertyOffset_8;

		// Token: 0x0400F883 RID: 63619
		internal static int __PropertyOffset_9;

		// Token: 0x0400F884 RID: 63620
		internal static int __PropertyOffset_10;

		// Token: 0x0400F885 RID: 63621
		internal static int __PropertyOffset_11;

		// Token: 0x0400F886 RID: 63622
		internal static int __PropertyOffset_12;

		// Token: 0x0400F887 RID: 63623
		internal static int __PropertyOffset_13;

		// Token: 0x0400F888 RID: 63624
		private static IntPtr __SetMat_NativeFunctionPtr;

		// Token: 0x0400F889 RID: 63625
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B81 RID: 39809
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetMat_FunctionParams
		{
			// Token: 0x040311CC RID: 201164
			[FieldOffset(0)]
			public IntPtr Texture;

			// Token: 0x040311CD RID: 201165
			[FieldOffset(8)]
			public IntPtr Plane;
		}
	}
}
