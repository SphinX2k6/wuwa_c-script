using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB2 RID: 15026
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor.BP_TrailDrawActor_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1057)]
	public class BP_TrailDrawActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020352 RID: 131922 RVA: 0x008CCA1E File Offset: 0x008CAC1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDrawActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor.BP_TrailDrawActor_C");
			}
			return BP_TrailDrawActor_C._ClassPtr;
		}

		// Token: 0x06020353 RID: 131923 RVA: 0x008CCA44 File Offset: 0x008CAC44
		public BP_TrailDrawActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020354 RID: 131924 RVA: 0x008CCA6C File Offset: 0x008CAC6C
		[NullableContext(1)]
		public BP_TrailDrawActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06020355 RID: 131925 RVA: 0x008CCA9F File Offset: 0x008CAC9F
		// (set) Token: 0x06020356 RID: 131926 RVA: 0x008CCAB3 File Offset: 0x008CACB3
		public unsafe BP_TrailDrawComponent_C DrawComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailDrawComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x06020357 RID: 131927 RVA: 0x008CCAC8 File Offset: 0x008CACC8
		// (set) Token: 0x06020358 RID: 131928 RVA: 0x008CCADC File Offset: 0x008CACDC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x06020359 RID: 131929 RVA: 0x008CCAF1 File Offset: 0x008CACF1
		// (set) Token: 0x0602035A RID: 131930 RVA: 0x008CCB01 File Offset: 0x008CAD01
		public unsafe bool IsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602035B RID: 131931 RVA: 0x008CCB14 File Offset: 0x008CAD14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEnable(ref bool Ret)
		{
			BP_TrailDrawActor_C.__IsEnable_FunctionParams* ptr = stackalloc BP_TrailDrawActor_C.__IsEnable_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_TrailDrawActor_C.__IsEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawActor_C.__IsEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ret = Ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawActor_C.__IsEnable_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
		}

		// Token: 0x0602035C RID: 131932 RVA: 0x008CCB63 File Offset: 0x008CAD63
		protected BP_TrailDrawActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F91B RID: 63771
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor.BP_TrailDrawActor_C";

		// Token: 0x0400F91C RID: 63772
		private static IntPtr _ClassPtr;

		// Token: 0x0400F91D RID: 63773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F91E RID: 63774
		internal static int __PropertyOffset_0;

		// Token: 0x0400F91F RID: 63775
		internal static int __PropertyOffset_1;

		// Token: 0x0400F920 RID: 63776
		internal static int __PropertyOffset_2;

		// Token: 0x0400F921 RID: 63777
		private static IntPtr __IsEnable_NativeFunctionPtr;

		// Token: 0x02009B92 RID: 39826
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __IsEnable_FunctionParams
		{
			// Token: 0x040311E5 RID: 201189
			[FieldOffset(0)]
			public bool Ret;
		}
	}
}
