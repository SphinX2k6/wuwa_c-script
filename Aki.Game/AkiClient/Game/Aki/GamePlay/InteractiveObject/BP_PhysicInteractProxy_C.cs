using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003151 RID: 12625
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class BP_PhysicInteractProxy_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0DE RID: 127198 RVA: 0x009254CA File Offset: 0x009236CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicInteractProxy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C");
			}
			return BP_PhysicInteractProxy_C._ClassPtr;
		}

		// Token: 0x0601F0DF RID: 127199 RVA: 0x009254F0 File Offset: 0x009236F0
		public BP_PhysicInteractProxy_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicInteractProxy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0E0 RID: 127200 RVA: 0x00925518 File Offset: 0x00923718
		[NullableContext(1)]
		public BP_PhysicInteractProxy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicInteractProxy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0601F0E1 RID: 127201 RVA: 0x0092554B File Offset: 0x0092374B
		// (set) Token: 0x0601F0E2 RID: 127202 RVA: 0x0092555F File Offset: 0x0092375F
		[Nullable(2)]
		public unsafe UCapsuleComponent Capsule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicInteractProxy_C.__PropertyOffset_Capsule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicInteractProxy_C.__PropertyOffset_Capsule, value);
			}
		}

		// Token: 0x0601F0E3 RID: 127203 RVA: 0x00925574 File Offset: 0x00923774
		[SkipLocalsInit]
		public unsafe virtual void SetRadiusAndHeight(float radius, float height)
		{
			BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams* ptr = stackalloc BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicInteractProxy_C.__SetRadiusAndHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->radius = radius;
			ptr->height = height;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicInteractProxy_C.__SetRadiusAndHeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F0E4 RID: 127204 RVA: 0x009255C1 File Offset: 0x009237C1
		protected BP_PhysicInteractProxy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010971 RID: 67953
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C";

		// Token: 0x04010972 RID: 67954
		private static IntPtr _ClassPtr;

		// Token: 0x04010973 RID: 67955
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010974 RID: 67956
		internal static int __PropertyOffset_Capsule;

		// Token: 0x04010975 RID: 67957
		private static IntPtr __SetRadiusAndHeight_NativeFunctionPtr;

		// Token: 0x02008F22 RID: 36642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRadiusAndHeight_FunctionParams
		{
			// Token: 0x0402CC53 RID: 183379
			[FieldOffset(0)]
			public float radius;

			// Token: 0x0402CC54 RID: 183380
			[FieldOffset(4)]
			public float height;
		}
	}
}
