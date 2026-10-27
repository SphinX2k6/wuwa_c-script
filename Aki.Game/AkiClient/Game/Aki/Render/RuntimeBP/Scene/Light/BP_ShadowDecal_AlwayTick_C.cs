using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1A RID: 15130
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal_AlwayTick.BP_ShadowDecal_AlwayTick_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1212)]
	public class BP_ShadowDecal_AlwayTick_C : AKuroDecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021197 RID: 135575 RVA: 0x008E4E18 File Offset: 0x008E3018
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ShadowDecal_AlwayTick_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal_AlwayTick.BP_ShadowDecal_AlwayTick_C");
			}
			return BP_ShadowDecal_AlwayTick_C._ClassPtr;
		}

		// Token: 0x06021198 RID: 135576 RVA: 0x008E4E3C File Offset: 0x008E303C
		public BP_ShadowDecal_AlwayTick_C() : this(BuiltinUtils.AllocNativeUObject(BP_ShadowDecal_AlwayTick_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021199 RID: 135577 RVA: 0x008E4E64 File Offset: 0x008E3064
		[NullableContext(1)]
		public BP_ShadowDecal_AlwayTick_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ShadowDecal_AlwayTick_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0602119A RID: 135578 RVA: 0x008E4E97 File Offset: 0x008E3097
		// (set) Token: 0x0602119B RID: 135579 RVA: 0x008E4EAB File Offset: 0x008E30AB
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0602119C RID: 135580 RVA: 0x008E4EC0 File Offset: 0x008E30C0
		// (set) Token: 0x0602119D RID: 135581 RVA: 0x008E4ED4 File Offset: 0x008E30D4
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0602119E RID: 135582 RVA: 0x008E4EE9 File Offset: 0x008E30E9
		// (set) Token: 0x0602119F RID: 135583 RVA: 0x008E4EFD File Offset: 0x008E30FD
		public unsafe UTexture2D ShadowTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x060211A0 RID: 135584 RVA: 0x008E4F12 File Offset: 0x008E3112
		// (set) Token: 0x060211A1 RID: 135585 RVA: 0x008E4F22 File Offset: 0x008E3122
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x060211A2 RID: 135586 RVA: 0x008E4F33 File Offset: 0x008E3133
		// (set) Token: 0x060211A3 RID: 135587 RVA: 0x008E4F43 File Offset: 0x008E3143
		public unsafe float InvShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x060211A4 RID: 135588 RVA: 0x008E4F54 File Offset: 0x008E3154
		// (set) Token: 0x060211A5 RID: 135589 RVA: 0x008E4F68 File Offset: 0x008E3168
		public unsafe UTexture2D EvolutionaryTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_AlwayTick_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x060211A6 RID: 135590 RVA: 0x008E4F7D File Offset: 0x008E317D
		// (set) Token: 0x060211A7 RID: 135591 RVA: 0x008E4F8D File Offset: 0x008E318D
		public unsafe float EvolutionaryIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x060211A8 RID: 135592 RVA: 0x008E4F9E File Offset: 0x008E319E
		// (set) Token: 0x060211A9 RID: 135593 RVA: 0x008E4FAE File Offset: 0x008E31AE
		public unsafe float EvolutionaryRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x060211AA RID: 135594 RVA: 0x008E4FBF File Offset: 0x008E31BF
		// (set) Token: 0x060211AB RID: 135595 RVA: 0x008E4FCF File Offset: 0x008E31CF
		public unsafe float EvolutionaryDirectional_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x060211AC RID: 135596 RVA: 0x008E4FE0 File Offset: 0x008E31E0
		// (set) Token: 0x060211AD RID: 135597 RVA: 0x008E4FF0 File Offset: 0x008E31F0
		public unsafe float EvolutionaryDirectional_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x060211AE RID: 135598 RVA: 0x008E5001 File Offset: 0x008E3201
		// (set) Token: 0x060211AF RID: 135599 RVA: 0x008E5011 File Offset: 0x008E3211
		public unsafe float MobileShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x060211B0 RID: 135600 RVA: 0x008E5022 File Offset: 0x008E3222
		// (set) Token: 0x060211B1 RID: 135601 RVA: 0x008E5032 File Offset: 0x008E3232
		public unsafe int DALayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x060211B2 RID: 135602 RVA: 0x008E5043 File Offset: 0x008E3243
		// (set) Token: 0x060211B3 RID: 135603 RVA: 0x008E5057 File Offset: 0x008E3257
		public unsafe FName MPC_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x060211B4 RID: 135604 RVA: 0x008E506C File Offset: 0x008E326C
		// (set) Token: 0x060211B5 RID: 135605 RVA: 0x008E507C File Offset: 0x008E327C
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x060211B6 RID: 135606 RVA: 0x008E508D File Offset: 0x008E328D
		// (set) Token: 0x060211B7 RID: 135607 RVA: 0x008E509D File Offset: 0x008E329D
		public unsafe float RestoreVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x060211B8 RID: 135608 RVA: 0x008E50AE File Offset: 0x008E32AE
		// (set) Token: 0x060211B9 RID: 135609 RVA: 0x008E50BE File Offset: 0x008E32BE
		public unsafe float DeltaTimeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x060211BA RID: 135610 RVA: 0x008E50CF File Offset: 0x008E32CF
		// (set) Token: 0x060211BB RID: 135611 RVA: 0x008E50DF File Offset: 0x008E32DF
		public unsafe float WindIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x060211BC RID: 135612 RVA: 0x008E50F0 File Offset: 0x008E32F0
		// (set) Token: 0x060211BD RID: 135613 RVA: 0x008E5100 File Offset: 0x008E3300
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x060211BE RID: 135614 RVA: 0x008E5111 File Offset: 0x008E3311
		// (set) Token: 0x060211BF RID: 135615 RVA: 0x008E5121 File Offset: 0x008E3321
		public unsafe float WindDir_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x060211C0 RID: 135616 RVA: 0x008E5132 File Offset: 0x008E3332
		// (set) Token: 0x060211C1 RID: 135617 RVA: 0x008E5142 File Offset: 0x008E3342
		public unsafe float WindDir_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x060211C2 RID: 135618 RVA: 0x008E5153 File Offset: 0x008E3353
		// (set) Token: 0x060211C3 RID: 135619 RVA: 0x008E5163 File Offset: 0x008E3363
		public unsafe float StrenghtAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x060211C4 RID: 135620 RVA: 0x008E5174 File Offset: 0x008E3374
		// (set) Token: 0x060211C5 RID: 135621 RVA: 0x008E5184 File Offset: 0x008E3384
		public unsafe float WindRandomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x060211C6 RID: 135622 RVA: 0x008E5195 File Offset: 0x008E3395
		// (set) Token: 0x060211C7 RID: 135623 RVA: 0x008E51A5 File Offset: 0x008E33A5
		public unsafe float WindRandomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_AlwayTick_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x060211C8 RID: 135624 RVA: 0x008E51B6 File Offset: 0x008E33B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FromDa()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_AlwayTick_C.__FromDa_NativeFunctionPtr, null);
		}

		// Token: 0x060211C9 RID: 135625 RVA: 0x008E51CA File Offset: 0x008E33CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_AlwayTick_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060211CA RID: 135626 RVA: 0x008E51DE File Offset: 0x008E33DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowDecal_AlwayTick_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060211CB RID: 135627 RVA: 0x008E51F4 File Offset: 0x008E33F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_AlwayTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_AlwayTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060211CC RID: 135628 RVA: 0x008E523C File Offset: 0x008E343C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_AlwayTick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_AlwayTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowDecal_AlwayTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060211CD RID: 135629 RVA: 0x008E5283 File Offset: 0x008E3483
		protected BP_ShadowDecal_AlwayTick_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101AF RID: 65967
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal_AlwayTick.BP_ShadowDecal_AlwayTick_C";

		// Token: 0x040101B0 RID: 65968
		private static IntPtr _ClassPtr;

		// Token: 0x040101B1 RID: 65969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101B2 RID: 65970
		internal static int __PropertyOffset_1;

		// Token: 0x040101B3 RID: 65971
		internal static int __PropertyOffset_2;

		// Token: 0x040101B4 RID: 65972
		internal static int __PropertyOffset_3;

		// Token: 0x040101B5 RID: 65973
		internal static int __PropertyOffset_4;

		// Token: 0x040101B6 RID: 65974
		internal static int __PropertyOffset_5;

		// Token: 0x040101B7 RID: 65975
		internal static int __PropertyOffset_6;

		// Token: 0x040101B8 RID: 65976
		internal static int __PropertyOffset_7;

		// Token: 0x040101B9 RID: 65977
		internal static int __PropertyOffset_8;

		// Token: 0x040101BA RID: 65978
		internal static int __PropertyOffset_9;

		// Token: 0x040101BB RID: 65979
		internal static int __PropertyOffset_10;

		// Token: 0x040101BC RID: 65980
		internal static int __PropertyOffset_11;

		// Token: 0x040101BD RID: 65981
		internal static int __PropertyOffset_12;

		// Token: 0x040101BE RID: 65982
		internal static int __PropertyOffset_13;

		// Token: 0x040101BF RID: 65983
		internal static int __PropertyOffset_14;

		// Token: 0x040101C0 RID: 65984
		internal static int __PropertyOffset_15;

		// Token: 0x040101C1 RID: 65985
		internal static int __PropertyOffset_16;

		// Token: 0x040101C2 RID: 65986
		internal static int __PropertyOffset_17;

		// Token: 0x040101C3 RID: 65987
		internal static int __PropertyOffset_18;

		// Token: 0x040101C4 RID: 65988
		internal static int __PropertyOffset_19;

		// Token: 0x040101C5 RID: 65989
		internal static int __PropertyOffset_20;

		// Token: 0x040101C6 RID: 65990
		internal static int __PropertyOffset_21;

		// Token: 0x040101C7 RID: 65991
		internal static int __PropertyOffset_22;

		// Token: 0x040101C8 RID: 65992
		internal static int __PropertyOffset_23;

		// Token: 0x040101C9 RID: 65993
		private static IntPtr __FromDa_NativeFunctionPtr;

		// Token: 0x040101CA RID: 65994
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040101CB RID: 65995
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C6F RID: 40047
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403132D RID: 201517
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
