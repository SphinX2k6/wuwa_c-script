using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIMoveSplineCount
{
	// Token: 0x02003402 RID: 13314
	[UnrealObjectPath("/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class MoveSplineAI_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CBE RID: 138430 RVA: 0x0096B4C1 File Offset: 0x009696C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MoveSplineAI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C");
			}
			return MoveSplineAI_C._ClassPtr;
		}

		// Token: 0x06021CBF RID: 138431 RVA: 0x0096B4E8 File Offset: 0x009696E8
		public MoveSplineAI_C() : this(BuiltinUtils.AllocNativeUObject(MoveSplineAI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CC0 RID: 138432 RVA: 0x0096B510 File Offset: 0x00969710
		[NullableContext(1)]
		public MoveSplineAI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MoveSplineAI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021CC1 RID: 138433 RVA: 0x0096B544 File Offset: 0x00969744
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CC2 RID: 138434 RVA: 0x0096B634 File Offset: 0x00969834
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CC3 RID: 138435 RVA: 0x0096B73A File Offset: 0x0096993A
		protected MoveSplineAI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A28 RID: 76328
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/AI/AIMoveSplineCount/MoveSplineAI.MoveSplineAI_C";

		// Token: 0x04012A29 RID: 76329
		private static IntPtr _ClassPtr;

		// Token: 0x04012A2A RID: 76330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A2B RID: 76331
		private static IntPtr __DCS_Demo_NativeFunctionPtr;

		// Token: 0x04012A2C RID: 76332
		private static IntPtr __元素球跟随_NativeFunctionPtr;

		// Token: 0x020090E7 RID: 37095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1192)]
		protected ref struct __DCS_Demo_FunctionParams
		{
			// Token: 0x0402CF97 RID: 184215
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x0402CF98 RID: 184216
			[FieldOffset(8)]
			public IntPtr 跟随角色;

			// Token: 0x0402CF99 RID: 184217
			[FieldOffset(16)]
			public IntPtr 移动样条;

			// Token: 0x0402CF9A RID: 184218
			[FieldOffset(24)]
			public float 当前样条位置;

			// Token: 0x0402CF9B RID: 184219
			[FieldOffset(28)]
			public float 样条速度;

			// Token: 0x0402CF9C RID: 184220
			[FieldOffset(32)]
			public int 飞行模式;

			// Token: 0x0402CF9D RID: 184221
			[FieldOffset(36)]
			public float 操作上下偏移;

			// Token: 0x0402CF9E RID: 184222
			[FieldOffset(40)]
			public float 操作左右偏移;

			// Token: 0x0402CF9F RID: 184223
			[FieldOffset(44)]
			public float 转向速度;

			// Token: 0x0402CFA0 RID: 184224
			[FieldOffset(48)]
			public FVector 追踪坐标;

			// Token: 0x0402CFA1 RID: 184225
			[FieldOffset(64)]
			public IntPtr __WorldContext;

			// Token: 0x0402CFA2 RID: 184226
			[FieldOffset(72)]
			public float 样条位置;

			// Token: 0x0402CFA3 RID: 184227
			[FieldOffset(76)]
			public float 旋转速度累加值;
		}

		// Token: 0x020090E8 RID: 37096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __元素球跟随_FunctionParams
		{
			// Token: 0x0402CFA4 RID: 184228
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x0402CFA5 RID: 184229
			[FieldOffset(8)]
			public IntPtr 特效对象;

			// Token: 0x0402CFA6 RID: 184230
			[FieldOffset(16)]
			public IntPtr 跟随角色;

			// Token: 0x0402CFA7 RID: 184231
			[FieldOffset(24)]
			public IntPtr 移动样条;

			// Token: 0x0402CFA8 RID: 184232
			[FieldOffset(32)]
			public float 当前样条位置;

			// Token: 0x0402CFA9 RID: 184233
			[FieldOffset(36)]
			public float 样条速度;

			// Token: 0x0402CFAA RID: 184234
			[FieldOffset(40)]
			public float 旋转速度;

			// Token: 0x0402CFAB RID: 184235
			[FieldOffset(44)]
			public float 旋转速度累加;

			// Token: 0x0402CFAC RID: 184236
			[FieldOffset(48)]
			public bool 王府开关;

			// Token: 0x0402CFAD RID: 184237
			[FieldOffset(56)]
			public IntPtr __WorldContext;

			// Token: 0x0402CFAE RID: 184238
			[FieldOffset(64)]
			public float 样条位置;

			// Token: 0x0402CFAF RID: 184239
			[FieldOffset(68)]
			public float 旋转速度累加值;

			// Token: 0x0402CFB0 RID: 184240
			[FieldOffset(72)]
			public bool 上行下行;
		}
	}
}
