using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C2B RID: 15403
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_Runtime.PCG_RoadSpline_Runtime_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class PCG_RoadSpline_Runtime_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023615 RID: 144917 RVA: 0x009228CB File Offset: 0x00920ACB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PCG_RoadSpline_Runtime_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_Runtime.PCG_RoadSpline_Runtime_C");
			}
			return PCG_RoadSpline_Runtime_C._ClassPtr;
		}

		// Token: 0x06023616 RID: 144918 RVA: 0x009228F0 File Offset: 0x00920AF0
		public PCG_RoadSpline_Runtime_C() : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_Runtime_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023617 RID: 144919 RVA: 0x00922918 File Offset: 0x00920B18
		[NullableContext(1)]
		public PCG_RoadSpline_Runtime_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_Runtime_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x06023618 RID: 144920 RVA: 0x0092294B File Offset: 0x00920B4B
		// (set) Token: 0x06023619 RID: 144921 RVA: 0x0092295F File Offset: 0x00920B5F
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0602361A RID: 144922 RVA: 0x00922974 File Offset: 0x00920B74
		// (set) Token: 0x0602361B RID: 144923 RVA: 0x00922988 File Offset: 0x00920B88
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x0602361C RID: 144924 RVA: 0x0092299D File Offset: 0x00920B9D
		// (set) Token: 0x0602361D RID: 144925 RVA: 0x009229B1 File Offset: 0x00920BB1
		public unsafe UStaticMesh 预览模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_Runtime_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0602361E RID: 144926 RVA: 0x009229C6 File Offset: 0x00920BC6
		// (set) Token: 0x0602361F RID: 144927 RVA: 0x009229D6 File Offset: 0x00920BD6
		public unsafe float 宽度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x06023620 RID: 144928 RVA: 0x009229E7 File Offset: 0x00920BE7
		// (set) Token: 0x06023621 RID: 144929 RVA: 0x009229F7 File Offset: 0x00920BF7
		public unsafe float 长度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x06023622 RID: 144930 RVA: 0x00922A08 File Offset: 0x00920C08
		// (set) Token: 0x06023623 RID: 144931 RVA: 0x00922A18 File Offset: 0x00920C18
		public unsafe bool 均匀分布
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x06023624 RID: 144932 RVA: 0x00922A29 File Offset: 0x00920C29
		// (set) Token: 0x06023625 RID: 144933 RVA: 0x00922A39 File Offset: 0x00920C39
		public unsafe float 分布缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_Runtime_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06023626 RID: 144934 RVA: 0x00922A4A File Offset: 0x00920C4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateMeshByLenght()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_Runtime_C.__GenerateMeshByLenght_NativeFunctionPtr, null);
		}

		// Token: 0x06023627 RID: 144935 RVA: 0x00922A5E File Offset: 0x00920C5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateMeshByPoint()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_Runtime_C.__GenerateMeshByPoint_NativeFunctionPtr, null);
		}

		// Token: 0x06023628 RID: 144936 RVA: 0x00922A72 File Offset: 0x00920C72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_Runtime_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023629 RID: 144937 RVA: 0x00922A86 File Offset: 0x00920C86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PCG_RoadSpline_Runtime_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602362A RID: 144938 RVA: 0x00922A9B File Offset: 0x00920C9B
		protected PCG_RoadSpline_Runtime_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011761 RID: 71521
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_Runtime.PCG_RoadSpline_Runtime_C";

		// Token: 0x04011762 RID: 71522
		private static IntPtr _ClassPtr;

		// Token: 0x04011763 RID: 71523
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011764 RID: 71524
		internal static int __PropertyOffset_0;

		// Token: 0x04011765 RID: 71525
		internal static int __PropertyOffset_1;

		// Token: 0x04011766 RID: 71526
		internal static int __PropertyOffset_2;

		// Token: 0x04011767 RID: 71527
		internal static int __PropertyOffset_3;

		// Token: 0x04011768 RID: 71528
		internal static int __PropertyOffset_4;

		// Token: 0x04011769 RID: 71529
		internal static int __PropertyOffset_5;

		// Token: 0x0401176A RID: 71530
		internal static int __PropertyOffset_6;

		// Token: 0x0401176B RID: 71531
		private static IntPtr __GenerateMeshByLenght_NativeFunctionPtr;

		// Token: 0x0401176C RID: 71532
		private static IntPtr __GenerateMeshByPoint_NativeFunctionPtr;

		// Token: 0x0401176D RID: 71533
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
