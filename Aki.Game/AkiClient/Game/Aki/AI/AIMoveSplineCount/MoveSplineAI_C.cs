using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIMoveSplineCount
{
	// Token: 0x0200443B RID: 17467
	[UnrealObjectPath("/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class MoveSplineAI_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D37A RID: 185210 RVA: 0x00A36681 File Offset: 0x00A34881
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MoveSplineAI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C");
			}
			return MoveSplineAI_C._ClassPtr;
		}

		// Token: 0x0602D37B RID: 185211 RVA: 0x00A366A8 File Offset: 0x00A348A8
		public MoveSplineAI_C() : this(BuiltinUtils.AllocNativeUObject(MoveSplineAI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D37C RID: 185212 RVA: 0x00A366D0 File Offset: 0x00A348D0
		[NullableContext(1)]
		public MoveSplineAI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MoveSplineAI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D37D RID: 185213 RVA: 0x00A36704 File Offset: 0x00A34904
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DCS_Demo(float DeltaSeconds, TsBaseCharacter 跟随角色, USplineComponent 移动样条, float 当前样条位置, float 样条速度, int 飞行模式, float 操作上下偏移, float 操作左右偏移, float 转向速度, FVector 追踪坐标, UObject __WorldContext, ref float 样条位置, ref float 旋转速度累加值)
		{
			MoveSplineAI_C.StaticClass();
			MoveSplineAI_C.__DCS_Demo_FunctionParams* ptr = stackalloc MoveSplineAI_C.__DCS_Demo_FunctionParams[(UIntPtr)1207] + 15L / (long)sizeof(MoveSplineAI_C.__DCS_Demo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MoveSplineAI_C.__DCS_Demo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->跟随角色 = ((跟随角色 != null) ? 跟随角色.NativePtr : IntPtr.Zero);
			ptr->移动样条 = ((移动样条 != null) ? 移动样条.NativePtr : IntPtr.Zero);
			ptr->当前样条位置 = 当前样条位置;
			ptr->样条速度 = 样条速度;
			ptr->飞行模式 = 飞行模式;
			ptr->操作上下偏移 = 操作上下偏移;
			ptr->操作左右偏移 = 操作左右偏移;
			ptr->转向速度 = 转向速度;
			ptr->追踪坐标 = 追踪坐标;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->样条位置 = 样条位置;
			ptr->旋转速度累加值 = 旋转速度累加值;
			UnrealReflectionUtils.CallVirtualUFunction(MoveSplineAI_C._ClassDefaultObjectPtr, MoveSplineAI_C.__DCS_Demo_NativeFunctionPtr, (void*)ptr);
			样条位置 = ptr->样条位置;
			旋转速度累加值 = ptr->旋转速度累加值;
		}

		// Token: 0x0602D37E RID: 185214 RVA: 0x00A367F4 File Offset: 0x00A349F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void 元素球跟随(float DeltaSeconds, AActor 特效对象, TsBaseCharacter 跟随角色, UKuroMoveSplineComponent 移动样条, float 当前样条位置, float 样条速度, float 旋转速度, float 旋转速度累加, bool 王府开关, UObject __WorldContext, ref float 样条位置, ref float 旋转速度累加值, ref bool 上行下行)
		{
			MoveSplineAI_C.StaticClass();
			MoveSplineAI_C.__元素球跟随_FunctionParams* ptr = stackalloc MoveSplineAI_C.__元素球跟随_FunctionParams[(UIntPtr)959] + 15L / (long)sizeof(MoveSplineAI_C.__元素球跟随_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MoveSplineAI_C.__元素球跟随_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->特效对象 = ((特效对象 != null) ? 特效对象.NativePtr : IntPtr.Zero);
			ptr->跟随角色 = ((跟随角色 != null) ? 跟随角色.NativePtr : IntPtr.Zero);
			ptr->移动样条 = ((移动样条 != null) ? 移动样条.NativePtr : IntPtr.Zero);
			ptr->当前样条位置 = 当前样条位置;
			ptr->样条速度 = 样条速度;
			ptr->旋转速度 = 旋转速度;
			ptr->旋转速度累加 = 旋转速度累加;
			ptr->王府开关 = 王府开关;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->样条位置 = 样条位置;
			ptr->旋转速度累加值 = 旋转速度累加值;
			ptr->上行下行 = 上行下行;
			UnrealReflectionUtils.CallVirtualUFunction(MoveSplineAI_C._ClassDefaultObjectPtr, MoveSplineAI_C.__元素球跟随_NativeFunctionPtr, (void*)ptr);
			样条位置 = ptr->样条位置;
			旋转速度累加值 = ptr->旋转速度累加值;
			上行下行 = ptr->上行下行;
		}

		// Token: 0x0602D37F RID: 185215 RVA: 0x00A368FA File Offset: 0x00A34AFA
		protected MoveSplineAI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04018099 RID: 98457
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C";

		// Token: 0x0401809A RID: 98458
		private static IntPtr _ClassPtr;

		// Token: 0x0401809B RID: 98459
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401809C RID: 98460
		private static IntPtr __DCS_Demo_NativeFunctionPtr;

		// Token: 0x0401809D RID: 98461
		private static IntPtr __元素球跟随_NativeFunctionPtr;

		// Token: 0x0200A6EF RID: 42735
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1192)]
		protected ref struct __DCS_Demo_FunctionParams
		{
			// Token: 0x040326E3 RID: 206563
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040326E4 RID: 206564
			[FieldOffset(8)]
			public IntPtr 跟随角色;

			// Token: 0x040326E5 RID: 206565
			[FieldOffset(16)]
			public IntPtr 移动样条;

			// Token: 0x040326E6 RID: 206566
			[FieldOffset(24)]
			public float 当前样条位置;

			// Token: 0x040326E7 RID: 206567
			[FieldOffset(28)]
			public float 样条速度;

			// Token: 0x040326E8 RID: 206568
			[FieldOffset(32)]
			public int 飞行模式;

			// Token: 0x040326E9 RID: 206569
			[FieldOffset(36)]
			public float 操作上下偏移;

			// Token: 0x040326EA RID: 206570
			[FieldOffset(40)]
			public float 操作左右偏移;

			// Token: 0x040326EB RID: 206571
			[FieldOffset(44)]
			public float 转向速度;

			// Token: 0x040326EC RID: 206572
			[FieldOffset(48)]
			public FVector 追踪坐标;

			// Token: 0x040326ED RID: 206573
			[FieldOffset(64)]
			public IntPtr __WorldContext;

			// Token: 0x040326EE RID: 206574
			[FieldOffset(72)]
			public float 样条位置;

			// Token: 0x040326EF RID: 206575
			[FieldOffset(76)]
			public float 旋转速度累加值;
		}

		// Token: 0x0200A6F0 RID: 42736
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __元素球跟随_FunctionParams
		{
			// Token: 0x040326F0 RID: 206576
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040326F1 RID: 206577
			[FieldOffset(8)]
			public IntPtr 特效对象;

			// Token: 0x040326F2 RID: 206578
			[FieldOffset(16)]
			public IntPtr 跟随角色;

			// Token: 0x040326F3 RID: 206579
			[FieldOffset(24)]
			public IntPtr 移动样条;

			// Token: 0x040326F4 RID: 206580
			[FieldOffset(32)]
			public float 当前样条位置;

			// Token: 0x040326F5 RID: 206581
			[FieldOffset(36)]
			public float 样条速度;

			// Token: 0x040326F6 RID: 206582
			[FieldOffset(40)]
			public float 旋转速度;

			// Token: 0x040326F7 RID: 206583
			[FieldOffset(44)]
			public float 旋转速度累加;

			// Token: 0x040326F8 RID: 206584
			[FieldOffset(48)]
			public bool 王府开关;

			// Token: 0x040326F9 RID: 206585
			[FieldOffset(56)]
			public IntPtr __WorldContext;

			// Token: 0x040326FA RID: 206586
			[FieldOffset(64)]
			public float 样条位置;

			// Token: 0x040326FB RID: 206587
			[FieldOffset(68)]
			public float 旋转速度累加值;

			// Token: 0x040326FC RID: 206588
			[FieldOffset(72)]
			public bool 上行下行;
		}
	}
}
