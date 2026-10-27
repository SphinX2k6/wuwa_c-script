using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.PathDrivenActor
{
	// Token: 0x02003E5E RID: 15966
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_ExplosiveBarrel_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028242 RID: 164418 RVA: 0x009A5167 File Offset: 0x009A3367
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ExplosiveBarrel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C");
			}
			return BP_ExplosiveBarrel_C._ClassPtr;
		}

		// Token: 0x06028243 RID: 164419 RVA: 0x009A518C File Offset: 0x009A338C
		public BP_ExplosiveBarrel_C() : this(BuiltinUtils.AllocNativeUObject(BP_ExplosiveBarrel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028244 RID: 164420 RVA: 0x009A51B4 File Offset: 0x009A33B4
		[NullableContext(1)]
		public BP_ExplosiveBarrel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ExplosiveBarrel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x06028245 RID: 164421 RVA: 0x009A51E7 File Offset: 0x009A33E7
		// (set) Token: 0x06028246 RID: 164422 RVA: 0x009A51FB File Offset: 0x009A33FB
		public unsafe UNiagaraComponent NS_Fx_Sl2_3_5_MZ_Baozhatong_Trail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x06028247 RID: 164423 RVA: 0x009A5210 File Offset: 0x009A3410
		// (set) Token: 0x06028248 RID: 164424 RVA: 0x009A5224 File Offset: 0x009A3424
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x06028249 RID: 164425 RVA: 0x009A5239 File Offset: 0x009A3439
		// (set) Token: 0x0602824A RID: 164426 RVA: 0x009A524D File Offset: 0x009A344D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExplosiveBarrel_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x0602824B RID: 164427 RVA: 0x009A5262 File Offset: 0x009A3462
		// (set) Token: 0x0602824C RID: 164428 RVA: 0x009A5272 File Offset: 0x009A3472
		public unsafe float BarrelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x0602824D RID: 164429 RVA: 0x009A5283 File Offset: 0x009A3483
		// (set) Token: 0x0602824E RID: 164430 RVA: 0x009A5297 File Offset: 0x009A3497
		[Nullable(1)]
		public unsafe string AudioEvent
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_4)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x0602824F RID: 164431 RVA: 0x009A52AC File Offset: 0x009A34AC
		// (set) Token: 0x06028250 RID: 164432 RVA: 0x009A52C1 File Offset: 0x009A34C1
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> ExplodeEffectAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_5, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ExplosiveBarrel_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028251 RID: 164433 RVA: 0x009A52E6 File Offset: 0x009A34E6
		protected BP_ExplosiveBarrel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146E3 RID: 83683
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/PathDrivenActor/BP_ExplosiveBarrel.BP_ExplosiveBarrel_C";

		// Token: 0x040146E4 RID: 83684
		private static IntPtr _ClassPtr;

		// Token: 0x040146E5 RID: 83685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146E6 RID: 83686
		internal static int __PropertyOffset_0;

		// Token: 0x040146E7 RID: 83687
		internal static int __PropertyOffset_1;

		// Token: 0x040146E8 RID: 83688
		internal static int __PropertyOffset_2;

		// Token: 0x040146E9 RID: 83689
		internal static int __PropertyOffset_3;

		// Token: 0x040146EA RID: 83690
		internal static int __PropertyOffset_4;

		// Token: 0x040146EB RID: 83691
		internal static int __PropertyOffset_5;
	}
}
