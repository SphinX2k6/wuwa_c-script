using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.PlanarReflection
{
	// Token: 0x02003DD6 RID: 15830
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Middle.BP_EffectPlanarReflection_Middle_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_EffectPlanarReflection_Middle_C : BP_EffectPlanarReflection_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277AD RID: 161709 RVA: 0x009929D6 File Offset: 0x00990BD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectPlanarReflection_Middle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Middle.BP_EffectPlanarReflection_Middle_C");
			}
			return BP_EffectPlanarReflection_Middle_C._ClassPtr;
		}

		// Token: 0x060277AE RID: 161710 RVA: 0x009929FC File Offset: 0x00990BFC
		public BP_EffectPlanarReflection_Middle_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Middle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277AF RID: 161711 RVA: 0x00992A24 File Offset: 0x00990C24
		[NullableContext(1)]
		public BP_EffectPlanarReflection_Middle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Middle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x060277B0 RID: 161712 RVA: 0x00992A57 File Offset: 0x00990C57
		// (set) Token: 0x060277B1 RID: 161713 RVA: 0x00992A6B File Offset: 0x00990C6B
		public unsafe UStaticMeshComponent Sphere_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Middle_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Middle_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x060277B2 RID: 161714 RVA: 0x00992A80 File Offset: 0x00990C80
		// (set) Token: 0x060277B3 RID: 161715 RVA: 0x00992A94 File Offset: 0x00990C94
		public unsafe UStaticMeshComponent Plane_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Middle_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Middle_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060277B4 RID: 161716 RVA: 0x00992AA9 File Offset: 0x00990CA9
		protected BP_EffectPlanarReflection_Middle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F23 RID: 81699
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Middle.BP_EffectPlanarReflection_Middle_C";

		// Token: 0x04013F24 RID: 81700
		private static IntPtr _ClassPtr;

		// Token: 0x04013F25 RID: 81701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F26 RID: 81702
		internal new static int __PropertyOffset_0;

		// Token: 0x04013F27 RID: 81703
		internal new static int __PropertyOffset_1;
	}
}
