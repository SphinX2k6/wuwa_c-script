using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BPWindBell
{
	// Token: 0x02003CCD RID: 15565
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type1.BP_Windbell_35_type1_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_Windbell_35_type1_C : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024DC2 RID: 150978 RVA: 0x0094A387 File Offset: 0x00948587
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Windbell_35_type1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type1.BP_Windbell_35_type1_C");
			}
			return BP_Windbell_35_type1_C._ClassPtr;
		}

		// Token: 0x06024DC3 RID: 150979 RVA: 0x0094A3AC File Offset: 0x009485AC
		public BP_Windbell_35_type1_C() : this(BuiltinUtils.AllocNativeUObject(BP_Windbell_35_type1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024DC4 RID: 150980 RVA: 0x0094A3D4 File Offset: 0x009485D4
		[NullableContext(1)]
		public BP_Windbell_35_type1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Windbell_35_type1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x06024DC5 RID: 150981 RVA: 0x0094A407 File Offset: 0x00948607
		// (set) Token: 0x06024DC6 RID: 150982 RVA: 0x0094A41B File Offset: 0x0094861B
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x06024DC7 RID: 150983 RVA: 0x0094A430 File Offset: 0x00948630
		// (set) Token: 0x06024DC8 RID: 150984 RVA: 0x0094A444 File Offset: 0x00948644
		public unsafe UCableComponent Cable6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x06024DC9 RID: 150985 RVA: 0x0094A459 File Offset: 0x00948659
		// (set) Token: 0x06024DCA RID: 150986 RVA: 0x0094A46D File Offset: 0x0094866D
		public unsafe UStaticMeshComponent Box3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x06024DCB RID: 150987 RVA: 0x0094A482 File Offset: 0x00948682
		// (set) Token: 0x06024DCC RID: 150988 RVA: 0x0094A496 File Offset: 0x00948696
		public unsafe UStaticMeshComponent Box4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x06024DCD RID: 150989 RVA: 0x0094A4AB File Offset: 0x009486AB
		// (set) Token: 0x06024DCE RID: 150990 RVA: 0x0094A4BF File Offset: 0x009486BF
		public unsafe UStaticMeshComponent Box1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x06024DCF RID: 150991 RVA: 0x0094A4D4 File Offset: 0x009486D4
		// (set) Token: 0x06024DD0 RID: 150992 RVA: 0x0094A4E8 File Offset: 0x009486E8
		public unsafe UStaticMeshComponent Box2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x06024DD1 RID: 150993 RVA: 0x0094A4FD File Offset: 0x009486FD
		// (set) Token: 0x06024DD2 RID: 150994 RVA: 0x0094A511 File Offset: 0x00948711
		public unsafe UStaticMeshComponent Box5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x06024DD3 RID: 150995 RVA: 0x0094A526 File Offset: 0x00948726
		// (set) Token: 0x06024DD4 RID: 150996 RVA: 0x0094A53A File Offset: 0x0094873A
		public unsafe UStaticMeshComponent Box_main2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x06024DD5 RID: 150997 RVA: 0x0094A54F File Offset: 0x0094874F
		// (set) Token: 0x06024DD6 RID: 150998 RVA: 0x0094A563 File Offset: 0x00948763
		public unsafe UStaticMeshComponent Box_main
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x06024DD7 RID: 150999 RVA: 0x0094A578 File Offset: 0x00948778
		// (set) Token: 0x06024DD8 RID: 151000 RVA: 0x0094A58C File Offset: 0x0094878C
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x06024DD9 RID: 151001 RVA: 0x0094A5A1 File Offset: 0x009487A1
		// (set) Token: 0x06024DDA RID: 151002 RVA: 0x0094A5B5 File Offset: 0x009487B5
		public unsafe UCableComponent Cable3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x06024DDB RID: 151003 RVA: 0x0094A5CA File Offset: 0x009487CA
		// (set) Token: 0x06024DDC RID: 151004 RVA: 0x0094A5DE File Offset: 0x009487DE
		public unsafe UCableComponent Cable4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x06024DDD RID: 151005 RVA: 0x0094A5F3 File Offset: 0x009487F3
		// (set) Token: 0x06024DDE RID: 151006 RVA: 0x0094A607 File Offset: 0x00948807
		public unsafe UCableComponent Cable5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x06024DDF RID: 151007 RVA: 0x0094A61C File Offset: 0x0094881C
		// (set) Token: 0x06024DE0 RID: 151008 RVA: 0x0094A630 File Offset: 0x00948830
		public unsafe UCableComponent Cable2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x06024DE1 RID: 151009 RVA: 0x0094A645 File Offset: 0x00948845
		// (set) Token: 0x06024DE2 RID: 151010 RVA: 0x0094A659 File Offset: 0x00948859
		public unsafe UCableComponent Cable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x06024DE3 RID: 151011 RVA: 0x0094A66E File Offset: 0x0094886E
		// (set) Token: 0x06024DE4 RID: 151012 RVA: 0x0094A682 File Offset: 0x00948882
		public unsafe UPhysicsConstraintComponent PhysicsConstraint_main
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x06024DE5 RID: 151013 RVA: 0x0094A697 File Offset: 0x00948897
		// (set) Token: 0x06024DE6 RID: 151014 RVA: 0x0094A6AB File Offset: 0x009488AB
		public unsafe UBoxComponent Box1_Bend
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x06024DE7 RID: 151015 RVA: 0x0094A6C0 File Offset: 0x009488C0
		// (set) Token: 0x06024DE8 RID: 151016 RVA: 0x0094A6D4 File Offset: 0x009488D4
		public unsafe UPhysicsConstraintComponent PhysicsConstraint5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x06024DE9 RID: 151017 RVA: 0x0094A6E9 File Offset: 0x009488E9
		// (set) Token: 0x06024DEA RID: 151018 RVA: 0x0094A6FD File Offset: 0x009488FD
		public unsafe UPhysicsConstraintComponent PhysicsConstraint4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x06024DEB RID: 151019 RVA: 0x0094A712 File Offset: 0x00948912
		// (set) Token: 0x06024DEC RID: 151020 RVA: 0x0094A726 File Offset: 0x00948926
		public unsafe UPhysicsConstraintComponent PhysicsConstraint3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x06024DED RID: 151021 RVA: 0x0094A73B File Offset: 0x0094893B
		// (set) Token: 0x06024DEE RID: 151022 RVA: 0x0094A74F File Offset: 0x0094894F
		public unsafe UPhysicsConstraintComponent PhysicsConstraint2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x06024DEF RID: 151023 RVA: 0x0094A764 File Offset: 0x00948964
		// (set) Token: 0x06024DF0 RID: 151024 RVA: 0x0094A778 File Offset: 0x00948978
		public unsafe UPhysicsConstraintComponent PhysicsConstraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type1_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x06024DF1 RID: 151025 RVA: 0x0094A78D File Offset: 0x0094898D
		// (set) Token: 0x06024DF2 RID: 151026 RVA: 0x0094A79D File Offset: 0x0094899D
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x06024DF3 RID: 151027 RVA: 0x0094A7B0 File Offset: 0x009489B0
		// (set) Token: 0x06024DF4 RID: 151028 RVA: 0x0094A7E9 File Offset: 0x009489E9
		[Nullable(1)]
		public TArray<UCableComponent> CablesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UCableComponent> result;
				if ((result = this._CablesArr) == null)
				{
					result = (this._CablesArr = new TArray<UCableComponent>(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CablesArr.CopyAssign(value);
			}
		}

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x06024DF5 RID: 151029 RVA: 0x0094A7F7 File Offset: 0x009489F7
		// (set) Token: 0x06024DF6 RID: 151030 RVA: 0x0094A807 File Offset: 0x00948A07
		public unsafe bool playerInRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x06024DF7 RID: 151031 RVA: 0x0094A818 File Offset: 0x00948A18
		// (set) Token: 0x06024DF8 RID: 151032 RVA: 0x0094A828 File Offset: 0x00948A28
		public unsafe bool alreadySimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x06024DF9 RID: 151033 RVA: 0x0094A83C File Offset: 0x00948A3C
		// (set) Token: 0x06024DFA RID: 151034 RVA: 0x0094A875 File Offset: 0x00948A75
		[Nullable(1)]
		public TArray<UStaticMeshComponent> SMCArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMCArr) == null)
				{
					result = (this._SMCArr = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMCArr.CopyAssign(value);
			}
		}

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x06024DFB RID: 151035 RVA: 0x0094A883 File Offset: 0x00948A83
		// (set) Token: 0x06024DFC RID: 151036 RVA: 0x0094A893 File Offset: 0x00948A93
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x06024DFD RID: 151037 RVA: 0x0094A8A4 File Offset: 0x00948AA4
		// (set) Token: 0x06024DFE RID: 151038 RVA: 0x0094A8B8 File Offset: 0x00948AB8
		public unsafe FVector worldPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type1_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x06024DFF RID: 151039 RVA: 0x0094A8CD File Offset: 0x00948ACD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024E00 RID: 151040 RVA: 0x0094A8E1 File Offset: 0x00948AE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E01 RID: 151041 RVA: 0x0094A8F8 File Offset: 0x00948AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E02 RID: 151042 RVA: 0x0094A940 File Offset: 0x00948B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024E03 RID: 151043 RVA: 0x0094A988 File Offset: 0x00948B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E04 RID: 151044 RVA: 0x0094AA44 File Offset: 0x00948C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E05 RID: 151045 RVA: 0x0094AACD File Offset: 0x00948CCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ClosePhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ClosePhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x06024E06 RID: 151046 RVA: 0x0094AAE1 File Offset: 0x00948CE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ClosePhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type1_C.__ClosePhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E07 RID: 151047 RVA: 0x0094AAF6 File Offset: 0x00948CF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OpenPhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__OpenPhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x06024E08 RID: 151048 RVA: 0x0094AB0A File Offset: 0x00948D0A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OpenPhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type1_C.__OpenPhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E09 RID: 151049 RVA: 0x0094AB20 File Offset: 0x00948D20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type1_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E0A RID: 151050 RVA: 0x0094AB74 File Offset: 0x00948D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Windbell_35_type1_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type1_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type1_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024E0B RID: 151051 RVA: 0x0094ABC7 File Offset: 0x00948DC7
		protected BP_Windbell_35_type1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401252B RID: 75051
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type1.BP_Windbell_35_type1_C";

		// Token: 0x0401252C RID: 75052
		private static IntPtr _ClassPtr;

		// Token: 0x0401252D RID: 75053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401252E RID: 75054
		internal static int __PropertyOffset_1;

		// Token: 0x0401252F RID: 75055
		internal static int __PropertyOffset_2;

		// Token: 0x04012530 RID: 75056
		internal static int __PropertyOffset_3;

		// Token: 0x04012531 RID: 75057
		internal static int __PropertyOffset_4;

		// Token: 0x04012532 RID: 75058
		internal static int __PropertyOffset_5;

		// Token: 0x04012533 RID: 75059
		internal static int __PropertyOffset_6;

		// Token: 0x04012534 RID: 75060
		internal static int __PropertyOffset_7;

		// Token: 0x04012535 RID: 75061
		internal static int __PropertyOffset_8;

		// Token: 0x04012536 RID: 75062
		internal static int __PropertyOffset_9;

		// Token: 0x04012537 RID: 75063
		internal static int __PropertyOffset_10;

		// Token: 0x04012538 RID: 75064
		internal static int __PropertyOffset_11;

		// Token: 0x04012539 RID: 75065
		internal static int __PropertyOffset_12;

		// Token: 0x0401253A RID: 75066
		internal static int __PropertyOffset_13;

		// Token: 0x0401253B RID: 75067
		internal static int __PropertyOffset_14;

		// Token: 0x0401253C RID: 75068
		internal static int __PropertyOffset_15;

		// Token: 0x0401253D RID: 75069
		internal static int __PropertyOffset_16;

		// Token: 0x0401253E RID: 75070
		internal static int __PropertyOffset_17;

		// Token: 0x0401253F RID: 75071
		internal static int __PropertyOffset_18;

		// Token: 0x04012540 RID: 75072
		internal static int __PropertyOffset_19;

		// Token: 0x04012541 RID: 75073
		internal static int __PropertyOffset_20;

		// Token: 0x04012542 RID: 75074
		internal static int __PropertyOffset_21;

		// Token: 0x04012543 RID: 75075
		internal static int __PropertyOffset_22;

		// Token: 0x04012544 RID: 75076
		internal static int __PropertyOffset_23;

		// Token: 0x04012545 RID: 75077
		internal static int __PropertyOffset_24;

		// Token: 0x04012546 RID: 75078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCableComponent> _CablesArr;

		// Token: 0x04012547 RID: 75079
		internal static int __PropertyOffset_25;

		// Token: 0x04012548 RID: 75080
		internal static int __PropertyOffset_26;

		// Token: 0x04012549 RID: 75081
		internal static int __PropertyOffset_27;

		// Token: 0x0401254A RID: 75082
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMCArr;

		// Token: 0x0401254B RID: 75083
		internal static int __PropertyOffset_28;

		// Token: 0x0401254C RID: 75084
		internal static int __PropertyOffset_29;

		// Token: 0x0401254D RID: 75085
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401254E RID: 75086
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401254F RID: 75087
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012550 RID: 75088
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012551 RID: 75089
		private static IntPtr __ClosePhysicsVisibility_NativeFunctionPtr;

		// Token: 0x04012552 RID: 75090
		private static IntPtr __OpenPhysicsVisibility_NativeFunctionPtr;

		// Token: 0x04012553 RID: 75091
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x02009F7C RID: 40828
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031983 RID: 203139
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F7D RID: 40829
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031984 RID: 203140
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031985 RID: 203141
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031986 RID: 203142
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031987 RID: 203143
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031988 RID: 203144
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031989 RID: 203145
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F7E RID: 40830
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403198A RID: 203146
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403198B RID: 203147
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403198C RID: 203148
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403198D RID: 203149
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F7F RID: 40831
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x0403198E RID: 203150
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x0403198F RID: 203151
			[FieldOffset(12)]
			public bool bWorldShift;
		}
	}
}
