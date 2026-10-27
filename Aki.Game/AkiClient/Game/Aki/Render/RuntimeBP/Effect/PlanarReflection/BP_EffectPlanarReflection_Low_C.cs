using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.PlanarReflection
{
	// Token: 0x02003DD5 RID: 15829
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Low.BP_EffectPlanarReflection_Low_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_EffectPlanarReflection_Low_C : BP_EffectPlanarReflection_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277A5 RID: 161701 RVA: 0x009928FB File Offset: 0x00990AFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectPlanarReflection_Low_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Low.BP_EffectPlanarReflection_Low_C");
			}
			return BP_EffectPlanarReflection_Low_C._ClassPtr;
		}

		// Token: 0x060277A6 RID: 161702 RVA: 0x00992920 File Offset: 0x00990B20
		public BP_EffectPlanarReflection_Low_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Low_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277A7 RID: 161703 RVA: 0x00992948 File Offset: 0x00990B48
		[NullableContext(1)]
		public BP_EffectPlanarReflection_Low_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Low_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x060277A8 RID: 161704 RVA: 0x0099297B File Offset: 0x00990B7B
		// (set) Token: 0x060277A9 RID: 161705 RVA: 0x0099298F File Offset: 0x00990B8F
		public unsafe UStaticMeshComponent Sphere_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Low_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Low_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x060277AA RID: 161706 RVA: 0x009929A4 File Offset: 0x00990BA4
		// (set) Token: 0x060277AB RID: 161707 RVA: 0x009929B8 File Offset: 0x00990BB8
		public unsafe UStaticMeshComponent Plane_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Low_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Low_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060277AC RID: 161708 RVA: 0x009929CD File Offset: 0x00990BCD
		protected BP_EffectPlanarReflection_Low_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F1E RID: 81694
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Low.BP_EffectPlanarReflection_Low_C";

		// Token: 0x04013F1F RID: 81695
		private static IntPtr _ClassPtr;

		// Token: 0x04013F20 RID: 81696
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F21 RID: 81697
		internal new static int __PropertyOffset_0;

		// Token: 0x04013F22 RID: 81698
		internal new static int __PropertyOffset_1;
	}
}
