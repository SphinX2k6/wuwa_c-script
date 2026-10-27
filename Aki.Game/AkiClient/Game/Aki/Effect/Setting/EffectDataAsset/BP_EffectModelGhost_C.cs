using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E71 RID: 15985
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGhost.BP_EffectModelGhost_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class BP_EffectModelGhost_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060283F9 RID: 164857 RVA: 0x009A783D File Offset: 0x009A5A3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelGhost_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGhost.BP_EffectModelGhost_C");
			}
			return BP_EffectModelGhost_C._ClassPtr;
		}

		// Token: 0x060283FA RID: 164858 RVA: 0x009A7864 File Offset: 0x009A5A64
		public BP_EffectModelGhost_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelGhost_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x009A788C File Offset: 0x009A5A8C
		[NullableContext(1)]
		public BP_EffectModelGhost_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelGhost_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x060283FC RID: 164860 RVA: 0x009A78BF File Offset: 0x009A5ABF
		// (set) Token: 0x060283FD RID: 164861 RVA: 0x009A78D3 File Offset: 0x009A5AD3
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelGhost_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelGhost_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x060283FE RID: 164862 RVA: 0x009A78E8 File Offset: 0x009A5AE8
		// (set) Token: 0x060283FF RID: 164863 RVA: 0x009A78FC File Offset: 0x009A5AFC
		public unsafe UMaterialInterface MaterialRef
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelGhost_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelGhost_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06028400 RID: 164864 RVA: 0x009A7911 File Offset: 0x009A5B11
		protected BP_EffectModelGhost_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147E1 RID: 83937
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGhost.BP_EffectModelGhost_C";

		// Token: 0x040147E2 RID: 83938
		private static IntPtr _ClassPtr;

		// Token: 0x040147E3 RID: 83939
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147E4 RID: 83940
		internal new static int __PropertyOffset_0;

		// Token: 0x040147E5 RID: 83941
		internal new static int __PropertyOffset_1;
	}
}
