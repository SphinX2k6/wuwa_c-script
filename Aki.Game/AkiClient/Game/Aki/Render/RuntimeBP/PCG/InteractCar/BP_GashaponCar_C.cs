using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.InteractCar
{
	// Token: 0x02003C9B RID: 15515
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/InteractCar/BP_GashaponCar.BP_GashaponCar_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1582)]
	public class BP_GashaponCar_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245CF RID: 148943 RVA: 0x0093C89F File Offset: 0x0093AA9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GashaponCar_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/InteractCar/BP_GashaponCar.BP_GashaponCar_C");
			}
			return BP_GashaponCar_C._ClassPtr;
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x0093C8C4 File Offset: 0x0093AAC4
		public BP_GashaponCar_C() : this(BuiltinUtils.AllocNativeUObject(BP_GashaponCar_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x0093C8EC File Offset: 0x0093AAEC
		[NullableContext(1)]
		public BP_GashaponCar_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GashaponCar_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x060245D2 RID: 148946 RVA: 0x0093C91F File Offset: 0x0093AB1F
		// (set) Token: 0x060245D3 RID: 148947 RVA: 0x0093C933 File Offset: 0x0093AB33
		public unsafe UStaticMeshComponent InnerSphere2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x060245D4 RID: 148948 RVA: 0x0093C948 File Offset: 0x0093AB48
		// (set) Token: 0x060245D5 RID: 148949 RVA: 0x0093C95C File Offset: 0x0093AB5C
		public unsafe UStaticMeshComponent InnerSphere1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x060245D6 RID: 148950 RVA: 0x0093C971 File Offset: 0x0093AB71
		// (set) Token: 0x060245D7 RID: 148951 RVA: 0x0093C985 File Offset: 0x0093AB85
		public unsafe UStaticMeshComponent InnerSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x060245D8 RID: 148952 RVA: 0x0093C99A File Offset: 0x0093AB9A
		// (set) Token: 0x060245D9 RID: 148953 RVA: 0x0093C9AE File Offset: 0x0093ABAE
		public unsafe UStaticMeshComponent SM_Col_Car_03AM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x060245DA RID: 148954 RVA: 0x0093C9C3 File Offset: 0x0093ABC3
		// (set) Token: 0x060245DB RID: 148955 RVA: 0x0093C9D7 File Offset: 0x0093ABD7
		public unsafe UStaticMeshComponent OutputLocation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x060245DC RID: 148956 RVA: 0x0093C9EC File Offset: 0x0093ABEC
		// (set) Token: 0x060245DD RID: 148957 RVA: 0x0093CA00 File Offset: 0x0093AC00
		public unsafe USphereComponent StartLocation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x060245DE RID: 148958 RVA: 0x0093CA15 File Offset: 0x0093AC15
		// (set) Token: 0x060245DF RID: 148959 RVA: 0x0093CA29 File Offset: 0x0093AC29
		public unsafe USphereComponent WaitLocation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x060245E0 RID: 148960 RVA: 0x0093CA3E File Offset: 0x0093AC3E
		// (set) Token: 0x060245E1 RID: 148961 RVA: 0x0093CA52 File Offset: 0x0093AC52
		public unsafe UStaticMeshComponent WaitMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x060245E2 RID: 148962 RVA: 0x0093CA67 File Offset: 0x0093AC67
		// (set) Token: 0x060245E3 RID: 148963 RVA: 0x0093CA7B File Offset: 0x0093AC7B
		public unsafe UStaticMeshComponent SM_Col_Car_03AM_BP
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x060245E4 RID: 148964 RVA: 0x0093CA90 File Offset: 0x0093AC90
		// (set) Token: 0x060245E5 RID: 148965 RVA: 0x0093CAA4 File Offset: 0x0093ACA4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x060245E6 RID: 148966 RVA: 0x0093CAB9 File Offset: 0x0093ACB9
		// (set) Token: 0x060245E7 RID: 148967 RVA: 0x0093CAC9 File Offset: 0x0093ACC9
		public unsafe float Timeline_0_NewTrack_1_FE9F8C634D2F625B15B8BBB79A742339
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x060245E8 RID: 148968 RVA: 0x0093CADA File Offset: 0x0093ACDA
		// (set) Token: 0x060245E9 RID: 148969 RVA: 0x0093CAEE File Offset: 0x0093ACEE
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_FE9F8C634D2F625B15B8BBB79A742339
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x060245EA RID: 148970 RVA: 0x0093CB03 File Offset: 0x0093AD03
		// (set) Token: 0x060245EB RID: 148971 RVA: 0x0093CB17 File Offset: 0x0093AD17
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GashaponCar_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x060245EC RID: 148972 RVA: 0x0093CB2C File Offset: 0x0093AD2C
		// (set) Token: 0x060245ED RID: 148973 RVA: 0x0093CB65 File Offset: 0x0093AD65
		[Nullable(1)]
		public TArray<UStaticMesh> SphereList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._SphereList) == null)
				{
					result = (this._SphereList = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SphereList.CopyAssign(value);
			}
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x060245EE RID: 148974 RVA: 0x0093CB73 File Offset: 0x0093AD73
		// (set) Token: 0x060245EF RID: 148975 RVA: 0x0093CB83 File Offset: 0x0093AD83
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x060245F0 RID: 148976 RVA: 0x0093CB94 File Offset: 0x0093AD94
		// (set) Token: 0x060245F1 RID: 148977 RVA: 0x0093CBA4 File Offset: 0x0093ADA4
		public unsafe float SphereDestroyTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x060245F2 RID: 148978 RVA: 0x0093CBB5 File Offset: 0x0093ADB5
		// (set) Token: 0x060245F3 RID: 148979 RVA: 0x0093CBC5 File Offset: 0x0093ADC5
		public unsafe int RandomIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x060245F4 RID: 148980 RVA: 0x0093CBD6 File Offset: 0x0093ADD6
		// (set) Token: 0x060245F5 RID: 148981 RVA: 0x0093CBE6 File Offset: 0x0093ADE6
		public unsafe bool StartReload
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x060245F6 RID: 148982 RVA: 0x0093CBF7 File Offset: 0x0093ADF7
		// (set) Token: 0x060245F7 RID: 148983 RVA: 0x0093CC07 File Offset: 0x0093AE07
		public unsafe float ReloadTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x060245F8 RID: 148984 RVA: 0x0093CC18 File Offset: 0x0093AE18
		// (set) Token: 0x060245F9 RID: 148985 RVA: 0x0093CC28 File Offset: 0x0093AE28
		public unsafe bool IsFirstHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x060245FA RID: 148986 RVA: 0x0093CC39 File Offset: 0x0093AE39
		// (set) Token: 0x060245FB RID: 148987 RVA: 0x0093CC49 File Offset: 0x0093AE49
		public unsafe bool HitCarMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GashaponCar_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x060245FC RID: 148988 RVA: 0x0093CC5A File Offset: 0x0093AE5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GashaponCar_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060245FD RID: 148989 RVA: 0x0093CC6E File Offset: 0x0093AE6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GashaponCar_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060245FE RID: 148990 RVA: 0x0093CC84 File Offset: 0x0093AE84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GashaponCar_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GashaponCar_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GashaponCar_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GashaponCar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GashaponCar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245FF RID: 148991 RVA: 0x0093CCCC File Offset: 0x0093AECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GashaponCar_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GashaponCar_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GashaponCar_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GashaponCar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GashaponCar_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024600 RID: 148992 RVA: 0x0093CD13 File Offset: 0x0093AF13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GashaponCar_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024601 RID: 148993 RVA: 0x0093CD27 File Offset: 0x0093AF27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GashaponCar_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024602 RID: 148994 RVA: 0x0093CD3C File Offset: 0x0093AF3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_GashaponCar_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_GashaponCar_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_GashaponCar_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GashaponCar_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GashaponCar_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024603 RID: 148995 RVA: 0x0093CD9F File Offset: 0x0093AF9F
		protected BP_GashaponCar_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401209D RID: 73885
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/InteractCar/BP_GashaponCar.BP_GashaponCar_C";

		// Token: 0x0401209E RID: 73886
		private static IntPtr _ClassPtr;

		// Token: 0x0401209F RID: 73887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040120A0 RID: 73888
		internal static int __PropertyOffset_1;

		// Token: 0x040120A1 RID: 73889
		internal static int __PropertyOffset_2;

		// Token: 0x040120A2 RID: 73890
		internal static int __PropertyOffset_3;

		// Token: 0x040120A3 RID: 73891
		internal static int __PropertyOffset_4;

		// Token: 0x040120A4 RID: 73892
		internal static int __PropertyOffset_5;

		// Token: 0x040120A5 RID: 73893
		internal static int __PropertyOffset_6;

		// Token: 0x040120A6 RID: 73894
		internal static int __PropertyOffset_7;

		// Token: 0x040120A7 RID: 73895
		internal static int __PropertyOffset_8;

		// Token: 0x040120A8 RID: 73896
		internal static int __PropertyOffset_9;

		// Token: 0x040120A9 RID: 73897
		internal static int __PropertyOffset_10;

		// Token: 0x040120AA RID: 73898
		internal static int __PropertyOffset_11;

		// Token: 0x040120AB RID: 73899
		internal static int __PropertyOffset_12;

		// Token: 0x040120AC RID: 73900
		internal static int __PropertyOffset_13;

		// Token: 0x040120AD RID: 73901
		internal static int __PropertyOffset_14;

		// Token: 0x040120AE RID: 73902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _SphereList;

		// Token: 0x040120AF RID: 73903
		internal static int __PropertyOffset_15;

		// Token: 0x040120B0 RID: 73904
		internal static int __PropertyOffset_16;

		// Token: 0x040120B1 RID: 73905
		internal static int __PropertyOffset_17;

		// Token: 0x040120B2 RID: 73906
		internal static int __PropertyOffset_18;

		// Token: 0x040120B3 RID: 73907
		internal static int __PropertyOffset_19;

		// Token: 0x040120B4 RID: 73908
		internal static int __PropertyOffset_20;

		// Token: 0x040120B5 RID: 73909
		internal static int __PropertyOffset_21;

		// Token: 0x040120B6 RID: 73910
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040120B7 RID: 73911
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040120B8 RID: 73912
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040120B9 RID: 73913
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040120BA RID: 73914
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009F0B RID: 40715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031853 RID: 202835
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F0C RID: 40716
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031854 RID: 202836
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031855 RID: 202837
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031856 RID: 202838
			[FieldOffset(32)]
			public int Id;
		}
	}
}
