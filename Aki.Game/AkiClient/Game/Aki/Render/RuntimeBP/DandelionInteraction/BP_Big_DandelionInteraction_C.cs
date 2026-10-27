using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DandelionInteraction
{
	// Token: 0x02003DE7 RID: 15847
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Big_DandelionInteraction.BP_Big_DandelionInteraction_C")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1641)]
	public class BP_Big_DandelionInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602787A RID: 161914 RVA: 0x00993ED1 File Offset: 0x009920D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Big_DandelionInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Big_DandelionInteraction.BP_Big_DandelionInteraction_C");
			}
			return BP_Big_DandelionInteraction_C._ClassPtr;
		}

		// Token: 0x0602787B RID: 161915 RVA: 0x00993EF8 File Offset: 0x009920F8
		public BP_Big_DandelionInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_Big_DandelionInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602787C RID: 161916 RVA: 0x00993F20 File Offset: 0x00992120
		[NullableContext(1)]
		public BP_Big_DandelionInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Big_DandelionInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700589D RID: 22685
		// (get) Token: 0x0602787D RID: 161917 RVA: 0x00993F53 File Offset: 0x00992153
		// (set) Token: 0x0602787E RID: 161918 RVA: 0x00993F67 File Offset: 0x00992167
		public unsafe USkeletalMeshComponent SkeletalMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700589E RID: 22686
		// (get) Token: 0x0602787F RID: 161919 RVA: 0x00993F7C File Offset: 0x0099217C
		// (set) Token: 0x06027880 RID: 161920 RVA: 0x00993F90 File Offset: 0x00992190
		public unsafe UStaticMeshComponent StaticMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700589F RID: 22687
		// (get) Token: 0x06027881 RID: 161921 RVA: 0x00993FA5 File Offset: 0x009921A5
		// (set) Token: 0x06027882 RID: 161922 RVA: 0x00993FB9 File Offset: 0x009921B9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170058A0 RID: 22688
		// (get) Token: 0x06027883 RID: 161923 RVA: 0x00993FCE File Offset: 0x009921CE
		// (set) Token: 0x06027884 RID: 161924 RVA: 0x00993FE2 File Offset: 0x009921E2
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x06027885 RID: 161925 RVA: 0x00993FF7 File Offset: 0x009921F7
		// (set) Token: 0x06027886 RID: 161926 RVA: 0x00994007 File Offset: 0x00992207
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x06027887 RID: 161927 RVA: 0x00994018 File Offset: 0x00992218
		// (set) Token: 0x06027888 RID: 161928 RVA: 0x00994028 File Offset: 0x00992228
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x06027889 RID: 161929 RVA: 0x00994039 File Offset: 0x00992239
		// (set) Token: 0x0602788A RID: 161930 RVA: 0x0099404D File Offset: 0x0099224D
		public unsafe FTransform CharacterTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x0602788B RID: 161931 RVA: 0x00994064 File Offset: 0x00992264
		// (set) Token: 0x0602788C RID: 161932 RVA: 0x0099409D File Offset: 0x0099229D
		[Nullable(1)]
		public TArray<float> Primitive_Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Primitive_Data) == null)
				{
					result = (this._Primitive_Data = new TArray<float>(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Primitive_Data.CopyAssign(value);
			}
		}

		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x0602788D RID: 161933 RVA: 0x009940AB File Offset: 0x009922AB
		// (set) Token: 0x0602788E RID: 161934 RVA: 0x009940BB File Offset: 0x009922BB
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x0602788F RID: 161935 RVA: 0x009940CC File Offset: 0x009922CC
		// (set) Token: 0x06027890 RID: 161936 RVA: 0x009940DC File Offset: 0x009922DC
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x06027891 RID: 161937 RVA: 0x009940ED File Offset: 0x009922ED
		// (set) Token: 0x06027892 RID: 161938 RVA: 0x009940FD File Offset: 0x009922FD
		public unsafe float TickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x06027893 RID: 161939 RVA: 0x0099410E File Offset: 0x0099230E
		// (set) Token: 0x06027894 RID: 161940 RVA: 0x00994122 File Offset: 0x00992322
		public unsafe UNiagaraSystem NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Big_DandelionInteraction_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x06027895 RID: 161941 RVA: 0x00994138 File Offset: 0x00992338
		// (set) Token: 0x06027896 RID: 161942 RVA: 0x00994171 File Offset: 0x00992371
		[Nullable(1)]
		public TArray<FName> ParentSocketNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ParentSocketNames) == null)
				{
					result = (this._ParentSocketNames = new TArray<FName>(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParentSocketNames.CopyAssign(value);
			}
		}

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x06027897 RID: 161943 RVA: 0x0099417F File Offset: 0x0099237F
		// (set) Token: 0x06027898 RID: 161944 RVA: 0x00994193 File Offset: 0x00992393
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x06027899 RID: 161945 RVA: 0x009941A8 File Offset: 0x009923A8
		// (set) Token: 0x0602789A RID: 161946 RVA: 0x009941BC File Offset: 0x009923BC
		public unsafe FVector WaeponVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x0602789B RID: 161947 RVA: 0x009941D1 File Offset: 0x009923D1
		// (set) Token: 0x0602789C RID: 161948 RVA: 0x009941E1 File Offset: 0x009923E1
		public unsafe bool OpenWeaponInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x0602789D RID: 161949 RVA: 0x009941F4 File Offset: 0x009923F4
		// (set) Token: 0x0602789E RID: 161950 RVA: 0x0099422D File Offset: 0x0099242D
		[Nullable(1)]
		public TArray<UNiagaraComponent> NiagaraSystemArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraSystemArray) == null)
				{
					result = (this._NiagaraSystemArray = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NiagaraSystemArray.CopyAssign(value);
			}
		}

		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x0602789F RID: 161951 RVA: 0x0099423B File Offset: 0x0099243B
		// (set) Token: 0x060278A0 RID: 161952 RVA: 0x0099424B File Offset: 0x0099244B
		public unsafe bool NiagaraActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Big_DandelionInteraction_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x060278A1 RID: 161953 RVA: 0x0099425C File Offset: 0x0099245C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetNiagaraArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__SetNiagaraArray_NativeFunctionPtr, null);
		}

		// Token: 0x060278A2 RID: 161954 RVA: 0x00994270 File Offset: 0x00992470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__UpdateNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x060278A3 RID: 161955 RVA: 0x00994284 File Offset: 0x00992484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeActiveFoliageNum(float ChangeNum)
		{
			BP_Big_DandelionInteraction_C.__ChangeActiveFoliageNum_FunctionParams* ptr = stackalloc BP_Big_DandelionInteraction_C.__ChangeActiveFoliageNum_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Big_DandelionInteraction_C.__ChangeActiveFoliageNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Big_DandelionInteraction_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChangeNum = ChangeNum;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060278A4 RID: 161956 RVA: 0x009942CA File Offset: 0x009924CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitialData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__InitialData_NativeFunctionPtr, null);
		}

		// Token: 0x060278A5 RID: 161957 RVA: 0x009942DE File Offset: 0x009924DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060278A6 RID: 161958 RVA: 0x009942F2 File Offset: 0x009924F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060278A7 RID: 161959 RVA: 0x00994307 File Offset: 0x00992507
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060278A8 RID: 161960 RVA: 0x0099431B File Offset: 0x0099251B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060278A9 RID: 161961 RVA: 0x00994330 File Offset: 0x00992530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x060278AA RID: 161962 RVA: 0x00994344 File Offset: 0x00992544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Big_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060278AB RID: 161963 RVA: 0x0099438C File Offset: 0x0099258C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Big_DandelionInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Big_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060278AC RID: 161964 RVA: 0x009943D4 File Offset: 0x009925D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CallChange(float Weight)
		{
			BP_Big_DandelionInteraction_C.__CallChange_FunctionParams* ptr = stackalloc BP_Big_DandelionInteraction_C.__CallChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Big_DandelionInteraction_C.__CallChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Big_DandelionInteraction_C.__CallChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Big_DandelionInteraction_C.__CallChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060278AD RID: 161965 RVA: 0x0099441A File Offset: 0x0099261A
		protected BP_Big_DandelionInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013FC5 RID: 81861
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Big_DandelionInteraction.BP_Big_DandelionInteraction_C";

		// Token: 0x04013FC6 RID: 81862
		private static IntPtr _ClassPtr;

		// Token: 0x04013FC7 RID: 81863
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013FC8 RID: 81864
		internal static int __PropertyOffset_1;

		// Token: 0x04013FC9 RID: 81865
		internal static int __PropertyOffset_2;

		// Token: 0x04013FCA RID: 81866
		internal static int __PropertyOffset_3;

		// Token: 0x04013FCB RID: 81867
		internal static int __PropertyOffset_4;

		// Token: 0x04013FCC RID: 81868
		internal static int __PropertyOffset_5;

		// Token: 0x04013FCD RID: 81869
		internal static int __PropertyOffset_6;

		// Token: 0x04013FCE RID: 81870
		internal static int __PropertyOffset_7;

		// Token: 0x04013FCF RID: 81871
		internal static int __PropertyOffset_8;

		// Token: 0x04013FD0 RID: 81872
		private TArray<float> _Primitive_Data;

		// Token: 0x04013FD1 RID: 81873
		internal static int __PropertyOffset_9;

		// Token: 0x04013FD2 RID: 81874
		internal static int __PropertyOffset_10;

		// Token: 0x04013FD3 RID: 81875
		internal static int __PropertyOffset_11;

		// Token: 0x04013FD4 RID: 81876
		internal static int __PropertyOffset_12;

		// Token: 0x04013FD5 RID: 81877
		internal static int __PropertyOffset_13;

		// Token: 0x04013FD6 RID: 81878
		private TArray<FName> _ParentSocketNames;

		// Token: 0x04013FD7 RID: 81879
		internal static int __PropertyOffset_14;

		// Token: 0x04013FD8 RID: 81880
		internal static int __PropertyOffset_15;

		// Token: 0x04013FD9 RID: 81881
		internal static int __PropertyOffset_16;

		// Token: 0x04013FDA RID: 81882
		internal static int __PropertyOffset_17;

		// Token: 0x04013FDB RID: 81883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraSystemArray;

		// Token: 0x04013FDC RID: 81884
		internal static int __PropertyOffset_18;

		// Token: 0x04013FDD RID: 81885
		private static IntPtr __SetNiagaraArray_NativeFunctionPtr;

		// Token: 0x04013FDE RID: 81886
		private static IntPtr __UpdateNiagara_NativeFunctionPtr;

		// Token: 0x04013FDF RID: 81887
		private static IntPtr __ChangeActiveFoliageNum_NativeFunctionPtr;

		// Token: 0x04013FE0 RID: 81888
		private static IntPtr __InitialData_NativeFunctionPtr;

		// Token: 0x04013FE1 RID: 81889
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013FE2 RID: 81890
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013FE3 RID: 81891
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x04013FE4 RID: 81892
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013FE5 RID: 81893
		private static IntPtr __CallChange_NativeFunctionPtr;

		// Token: 0x0200A246 RID: 41542
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChangeActiveFoliageNum_FunctionParams
		{
			// Token: 0x04031ED7 RID: 204503
			[FieldOffset(0)]
			public float ChangeNum;
		}

		// Token: 0x0200A247 RID: 41543
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ED8 RID: 204504
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A248 RID: 41544
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CallChange_FunctionParams
		{
			// Token: 0x04031ED9 RID: 204505
			[FieldOffset(0)]
			public float Weight;
		}
	}
}
