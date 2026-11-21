using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.PathDrivenActor
{
	// Token: 0x0200314E RID: 12622
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_ExplosiveBarrel_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0B8 RID: 127160 RVA: 0x00925084 File Offset: 0x00923284
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ExplosiveBarrel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C");
			}
			return BP_ExplosiveBarrel_C._ClassPtr;
		}

		// Token: 0x0601F0B9 RID: 127161 RVA: 0x009250A8 File Offset: 0x009232A8
		public BP_ExplosiveBarrel_C() : this(BuiltinUtils.AllocNativeUObject(BP_ExplosiveBarrel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0BA RID: 127162 RVA: 0x009250D0 File Offset: 0x009232D0
		[NullableContext(1)]
		public BP_ExplosiveBarrel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ExplosiveBarrel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0601F0BB RID: 127163 RVA: 0x00925103 File Offset: 0x00923303
		// (set) Token: 0x0601F0BC RID: 127164 RVA: 0x00925117 File Offset: 0x00923317
		public unsafe UNiagaraComponent NS_Fx_Sl2_3_5_MZ_Baozhatong_Trail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_NS_Fx_Sl2_3_5_MZ_Baozhatong_Trail);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_NS_Fx_Sl2_3_5_MZ_Baozhatong_Trail, value);
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0601F0BD RID: 127165 RVA: 0x0092512C File Offset: 0x0092332C
		// (set) Token: 0x0601F0BE RID: 127166 RVA: 0x00925140 File Offset: 0x00923340
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0601F0BF RID: 127167 RVA: 0x00925155 File Offset: 0x00923355
		// (set) Token: 0x0601F0C0 RID: 127168 RVA: 0x00925169 File Offset: 0x00923369
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0601F0C1 RID: 127169 RVA: 0x0092517E File Offset: 0x0092337E
		// (set) Token: 0x0601F0C2 RID: 127170 RVA: 0x0092518E File Offset: 0x0092338E
		public unsafe float BarrelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_BarrelRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_BarrelRadius) = value;
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0601F0C3 RID: 127171 RVA: 0x0092519F File Offset: 0x0092339F
		// (set) Token: 0x0601F0C4 RID: 127172 RVA: 0x009251B3 File Offset: 0x009233B3
		[Nullable(1)]
		public unsafe string AudioEvent
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_AudioEvent)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_AudioEvent)), value);
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0601F0C5 RID: 127173 RVA: 0x009251C8 File Offset: 0x009233C8
		// (set) Token: 0x0601F0C6 RID: 127174 RVA: 0x009251DD File Offset: 0x009233DD
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> ExplodeEffectAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_ExplodeEffectAsset, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_ExplodeEffectAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x00925202 File Offset: 0x00923402
		protected BP_ExplosiveBarrel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401095D RID: 67933
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C";

		// Token: 0x0401095E RID: 67934
		private static IntPtr _ClassPtr;

		// Token: 0x0401095F RID: 67935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010960 RID: 67936
		internal static int __PropertyOffset_NS_Fx_Sl2_3_5_MZ_Baozhatong_Trail;

		// Token: 0x04010961 RID: 67937
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04010962 RID: 67938
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010963 RID: 67939
		internal static int __PropertyOffset_BarrelRadius;

		// Token: 0x04010964 RID: 67940
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x04010965 RID: 67941
		internal static int __PropertyOffset_ExplodeEffectAsset;
	}
}
