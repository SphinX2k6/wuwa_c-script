using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Waterfall.Prefab
{
	// Token: 0x02003BDE RID: 15326
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_01.BP_Wat_Prefab_01_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1092)]
	public class BP_Wat_Prefab_01_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022940 RID: 141632 RVA: 0x0090C8FA File Offset: 0x0090AAFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Wat_Prefab_01_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_01.BP_Wat_Prefab_01_C");
			}
			return BP_Wat_Prefab_01_C._ClassPtr;
		}

		// Token: 0x06022941 RID: 141633 RVA: 0x0090C920 File Offset: 0x0090AB20
		public BP_Wat_Prefab_01_C() : this(BuiltinUtils.AllocNativeUObject(BP_Wat_Prefab_01_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022942 RID: 141634 RVA: 0x0090C948 File Offset: 0x0090AB48
		[NullableContext(1)]
		public BP_Wat_Prefab_01_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Wat_Prefab_01_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x06022943 RID: 141635 RVA: 0x0090C97B File Offset: 0x0090AB7B
		// (set) Token: 0x06022944 RID: 141636 RVA: 0x0090C98F File Offset: 0x0090AB8F
		public unsafe UStaticMeshComponent SM_Wat_Seq_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x06022945 RID: 141637 RVA: 0x0090C9A4 File Offset: 0x0090ABA4
		// (set) Token: 0x06022946 RID: 141638 RVA: 0x0090C9B8 File Offset: 0x0090ABB8
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x06022947 RID: 141639 RVA: 0x0090C9CD File Offset: 0x0090ABCD
		// (set) Token: 0x06022948 RID: 141640 RVA: 0x0090C9E1 File Offset: 0x0090ABE1
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x06022949 RID: 141641 RVA: 0x0090C9F6 File Offset: 0x0090ABF6
		// (set) Token: 0x0602294A RID: 141642 RVA: 0x0090CA0A File Offset: 0x0090AC0A
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0602294B RID: 141643 RVA: 0x0090CA1F File Offset: 0x0090AC1F
		// (set) Token: 0x0602294C RID: 141644 RVA: 0x0090CA33 File Offset: 0x0090AC33
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_01_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0602294D RID: 141645 RVA: 0x0090CA48 File Offset: 0x0090AC48
		// (set) Token: 0x0602294E RID: 141646 RVA: 0x0090CA58 File Offset: 0x0090AC58
		public unsafe float 粒子范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0602294F RID: 141647 RVA: 0x0090CA69 File Offset: 0x0090AC69
		// (set) Token: 0x06022950 RID: 141648 RVA: 0x0090CA79 File Offset: 0x0090AC79
		public unsafe float 粒子寿命
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x06022951 RID: 141649 RVA: 0x0090CA8A File Offset: 0x0090AC8A
		// (set) Token: 0x06022952 RID: 141650 RVA: 0x0090CA9A File Offset: 0x0090AC9A
		public unsafe float 粒子数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_01_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06022953 RID: 141651 RVA: 0x0090CAAB File Offset: 0x0090ACAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wat_Prefab_01_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022954 RID: 141652 RVA: 0x0090CABF File Offset: 0x0090ACBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Wat_Prefab_01_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022955 RID: 141653 RVA: 0x0090CAD4 File Offset: 0x0090ACD4
		protected BP_Wat_Prefab_01_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FB8 RID: 69560
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_01.BP_Wat_Prefab_01_C";

		// Token: 0x04010FB9 RID: 69561
		private static IntPtr _ClassPtr;

		// Token: 0x04010FBA RID: 69562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FBB RID: 69563
		internal static int __PropertyOffset_0;

		// Token: 0x04010FBC RID: 69564
		internal static int __PropertyOffset_1;

		// Token: 0x04010FBD RID: 69565
		internal static int __PropertyOffset_2;

		// Token: 0x04010FBE RID: 69566
		internal static int __PropertyOffset_3;

		// Token: 0x04010FBF RID: 69567
		internal static int __PropertyOffset_4;

		// Token: 0x04010FC0 RID: 69568
		internal static int __PropertyOffset_5;

		// Token: 0x04010FC1 RID: 69569
		internal static int __PropertyOffset_6;

		// Token: 0x04010FC2 RID: 69570
		internal static int __PropertyOffset_7;

		// Token: 0x04010FC3 RID: 69571
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
