using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003E62 RID: 15970
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class BP_PhysicInteractProxy_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028298 RID: 164504 RVA: 0x009A594E File Offset: 0x009A3B4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicInteractProxy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C");
			}
			return BP_PhysicInteractProxy_C._ClassPtr;
		}

		// Token: 0x06028299 RID: 164505 RVA: 0x009A5974 File Offset: 0x009A3B74
		public BP_PhysicInteractProxy_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicInteractProxy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602829A RID: 164506 RVA: 0x009A599C File Offset: 0x009A3B9C
		[NullableContext(1)]
		public BP_PhysicInteractProxy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicInteractProxy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x0602829B RID: 164507 RVA: 0x009A59CF File Offset: 0x009A3BCF
		// (set) Token: 0x0602829C RID: 164508 RVA: 0x009A59E3 File Offset: 0x009A3BE3
		[Nullable(2)]
		public unsafe UCapsuleComponent Capsule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicInteractProxy_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicInteractProxy_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602829D RID: 164509 RVA: 0x009A59F8 File Offset: 0x009A3BF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetRadiusAndHeight(float radius, float height)
		{
			BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams* ptr = stackalloc BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_PhysicInteractProxy_C.__SetRadiusAndHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicInteractProxy_C.__SetRadiusAndHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->radius = radius;
			ptr->height = height;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicInteractProxy_C.__SetRadiusAndHeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602829E RID: 164510 RVA: 0x009A5A45 File Offset: 0x009A3C45
		protected BP_PhysicInteractProxy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014710 RID: 83728
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicInteractProxy.BP_PhysicInteractProxy_C";

		// Token: 0x04014711 RID: 83729
		private static IntPtr _ClassPtr;

		// Token: 0x04014712 RID: 83730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014713 RID: 83731
		internal static int __PropertyOffset_0;

		// Token: 0x04014714 RID: 83732
		private static IntPtr __SetRadiusAndHeight_NativeFunctionPtr;

		// Token: 0x0200A2CF RID: 41679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRadiusAndHeight_FunctionParams
		{
			// Token: 0x04032010 RID: 204816
			[FieldOffset(0)]
			public float radius;

			// Token: 0x04032011 RID: 204817
			[FieldOffset(4)]
			public float height;
		}
	}
}
