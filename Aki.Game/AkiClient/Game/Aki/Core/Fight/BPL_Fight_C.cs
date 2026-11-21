using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003255 RID: 12885
	[UnrealObjectPath("/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_Fight_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202FB RID: 131835 RVA: 0x0093F4D8 File Offset: 0x0093D6D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_Fight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C");
			}
			return BPL_Fight_C._ClassPtr;
		}

		// Token: 0x060202FC RID: 131836 RVA: 0x0093F4FC File Offset: 0x0093D6FC
		public BPL_Fight_C() : this(BuiltinUtils.AllocNativeUObject(BPL_Fight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202FD RID: 131837 RVA: 0x0093F524 File Offset: 0x0093D724
		[NullableContext(1)]
		public BPL_Fight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_Fight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060202FE RID: 131838 RVA: 0x0093F558 File Offset: 0x0093D758
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 反应伤害倍率计算(float 角色1反应精通, float 角色2反应精通, UObject __WorldContext, ref float Result)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__反应伤害倍率计算_FunctionParams* ptr = stackalloc BPL_Fight_C.__反应伤害倍率计算_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BPL_Fight_C.__反应伤害倍率计算_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__反应伤害倍率计算_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色1反应精通 = 角色1反应精通;
			ptr->角色2反应精通 = 角色2反应精通;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__反应伤害倍率计算_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x060202FF RID: 131839 RVA: 0x0093F5D0 File Offset: 0x0093D7D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 删除材质效果(TsBaseCharacter 设置对象_, int Handle_, bool PlayWithEnd, UObject __WorldContext)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__删除材质效果_FunctionParams* ptr = stackalloc BPL_Fight_C.__删除材质效果_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BPL_Fight_C.__删除材质效果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__删除材质效果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->设置对象_ = ((设置对象_ != null) ? 设置对象_.NativePtr : IntPtr.Zero);
			ptr->Handle_ = Handle_;
			ptr->PlayWithEnd = PlayWithEnd;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__删除材质效果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020300 RID: 131840 RVA: 0x0093F650 File Offset: 0x0093D850
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 设置材质效果(TsBaseCharacter 设置对象, PD_CharacterControllerData_C 材质配置, UObject __WorldContext, ref int Handle)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__设置材质效果_FunctionParams* ptr = stackalloc BPL_Fight_C.__设置材质效果_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BPL_Fight_C.__设置材质效果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__设置材质效果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->设置对象 = ((设置对象 != null) ? 设置对象.NativePtr : IntPtr.Zero);
			ptr->材质配置 = ((材质配置 != null) ? 材质配置.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__设置材质效果_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x06020301 RID: 131841 RVA: 0x0093F6E8 File Offset: 0x0093D8E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 获取目标周围坐标点(FRotator 目标旋转, FVectorDouble 目标坐标, float 旋转, float 仰角, float 长度, UObject __WorldContext, ref FVectorDouble 坐标点)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__获取目标周围坐标点_FunctionParams* ptr = stackalloc BPL_Fight_C.__获取目标周围坐标点_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BPL_Fight_C.__获取目标周围坐标点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__获取目标周围坐标点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标旋转 = 目标旋转;
			ptr->目标坐标 = 目标坐标;
			ptr->旋转 = 旋转;
			ptr->仰角 = 仰角;
			ptr->长度 = 长度;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->坐标点 = 坐标点;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__获取目标周围坐标点_NativeFunctionPtr, (void*)ptr);
			坐标点 = ptr->坐标点;
		}

		// Token: 0x06020302 RID: 131842 RVA: 0x0093F788 File Offset: 0x0093D988
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 计算向量曲线值(float 已经经过时间, float 总时间, UCurveVector 向量曲线, UObject __WorldContext, ref FVector 向量值)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__计算向量曲线值_FunctionParams* ptr = stackalloc BPL_Fight_C.__计算向量曲线值_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BPL_Fight_C.__计算向量曲线值_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__计算向量曲线值_NativeFunctionPtr, (void*)ptr, 1);
			ptr->已经经过时间 = 已经经过时间;
			ptr->总时间 = 总时间;
			ptr->向量曲线 = ((向量曲线 != null) ? 向量曲线.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->向量值 = 向量值;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__计算向量曲线值_NativeFunctionPtr, (void*)ptr);
			向量值 = ptr->向量值;
		}

		// Token: 0x06020303 RID: 131843 RVA: 0x0093F820 File Offset: 0x0093DA20
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 计算曲线值(float 已经过时间, float 总时间, UCurveFloat 曲线, UObject __WorldContext, ref float 百分比)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__计算曲线值_FunctionParams* ptr = stackalloc BPL_Fight_C.__计算曲线值_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BPL_Fight_C.__计算曲线值_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__计算曲线值_NativeFunctionPtr, (void*)ptr, 1);
			ptr->已经过时间 = 已经过时间;
			ptr->总时间 = 总时间;
			ptr->曲线 = ((曲线 != null) ? 曲线.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->百分比 = 百分比;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__计算曲线值_NativeFunctionPtr, (void*)ptr);
			百分比 = ptr->百分比;
		}

		// Token: 0x06020304 RID: 131844 RVA: 0x0093F8B0 File Offset: 0x0093DAB0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 角度转化(float Input, UObject __WorldContext, ref float Output)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__角度转化_FunctionParams* ptr = stackalloc BPL_Fight_C.__角度转化_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_Fight_C.__角度转化_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__角度转化_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Input = Input;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Output = Output;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__角度转化_NativeFunctionPtr, (void*)ptr);
			Output = ptr->Output;
		}

		// Token: 0x06020305 RID: 131845 RVA: 0x0093F924 File Offset: 0x0093DB24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool 射线检测(UObject Context, FVectorDouble Start, FVectorDouble End, ETraceTypeQuery TraceChannel, bool bTraceComplex, EDrawDebugTrace DrawDebugType, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime, UObject __WorldContext, ref FHitResult OutHit)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__射线检测_FunctionParams* ptr = stackalloc BPL_Fight_C.__射线检测_FunctionParams[(UIntPtr)439] + 15L / (long)sizeof(BPL_Fight_C.__射线检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__射线检测_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			ptr->Start = Start;
			ptr->End = End;
			ptr->TraceChannel = TraceChannel;
			ptr->bTraceComplex = bTraceComplex;
			ptr->DrawDebugType = DrawDebugType;
			ptr->bIgnoreSelf = bIgnoreSelf;
			ptr->TraceColor = TraceColor;
			ptr->TraceHitColor = TraceHitColor;
			ptr->DrawTime = DrawTime;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (OutHit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->OutHit, OutHit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__射线检测_NativeFunctionPtr, (void*)ptr);
			if (OutHit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), OutHit.NativePtr, &ptr->OutHit, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06020306 RID: 131846 RVA: 0x0093FA3C File Offset: 0x0093DC3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 获取Actor周围坐标点(AActor Actor, float 旋转, float 仰角, float 长度, UObject __WorldContext, ref FVectorDouble 坐标点)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__获取Actor周围坐标点_FunctionParams* ptr = stackalloc BPL_Fight_C.__获取Actor周围坐标点_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BPL_Fight_C.__获取Actor周围坐标点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__获取Actor周围坐标点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->旋转 = 旋转;
			ptr->仰角 = 仰角;
			ptr->长度 = 长度;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->坐标点 = 坐标点;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__获取Actor周围坐标点_NativeFunctionPtr, (void*)ptr);
			坐标点 = ptr->坐标点;
		}

		// Token: 0x06020307 RID: 131847 RVA: 0x0093FAE0 File Offset: 0x0093DCE0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool 是否有标签(TsBaseCharacter 角色, FGameplayTag 标签, UObject __WorldContext)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__是否有标签_FunctionParams* ptr = stackalloc BPL_Fight_C.__是否有标签_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BPL_Fight_C.__是否有标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__是否有标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->标签 = 标签;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__是否有标签_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020308 RID: 131848 RVA: 0x0093FB60 File Offset: 0x0093DD60
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 清除标签(TsBaseCharacter 角色, FGameplayTag 标签, UObject __WorldContext)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__清除标签_FunctionParams* ptr = stackalloc BPL_Fight_C.__清除标签_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BPL_Fight_C.__清除标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__清除标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->标签 = 标签;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__清除标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020309 RID: 131849 RVA: 0x0093FBD8 File Offset: 0x0093DDD8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void 添加标签(TsBaseCharacter 角色, FGameplayTag 标签, UObject __WorldContext)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__添加标签_FunctionParams* ptr = stackalloc BPL_Fight_C.__添加标签_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BPL_Fight_C.__添加标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__添加标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->标签 = 标签;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__添加标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602030A RID: 131850 RVA: 0x0093FC4F File Offset: 0x0093DE4F
		protected BPL_Fight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011543 RID: 70979
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C";

		// Token: 0x04011544 RID: 70980
		private static IntPtr _ClassPtr;

		// Token: 0x04011545 RID: 70981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011546 RID: 70982
		private static IntPtr __反应伤害倍率计算_NativeFunctionPtr;

		// Token: 0x04011547 RID: 70983
		private static IntPtr __删除材质效果_NativeFunctionPtr;

		// Token: 0x04011548 RID: 70984
		private static IntPtr __设置材质效果_NativeFunctionPtr;

		// Token: 0x04011549 RID: 70985
		private static IntPtr __获取目标周围坐标点_NativeFunctionPtr;

		// Token: 0x0401154A RID: 70986
		private static IntPtr __计算向量曲线值_NativeFunctionPtr;

		// Token: 0x0401154B RID: 70987
		private static IntPtr __计算曲线值_NativeFunctionPtr;

		// Token: 0x0401154C RID: 70988
		private static IntPtr __角度转化_NativeFunctionPtr;

		// Token: 0x0401154D RID: 70989
		private static IntPtr __射线检测_NativeFunctionPtr;

		// Token: 0x0401154E RID: 70990
		private static IntPtr __获取Actor周围坐标点_NativeFunctionPtr;

		// Token: 0x0401154F RID: 70991
		private static IntPtr __是否有标签_NativeFunctionPtr;

		// Token: 0x04011550 RID: 70992
		private static IntPtr __清除标签_NativeFunctionPtr;

		// Token: 0x04011551 RID: 70993
		private static IntPtr __添加标签_NativeFunctionPtr;

		// Token: 0x02008F2D RID: 36653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __反应伤害倍率计算_FunctionParams
		{
			// Token: 0x0402CC69 RID: 183401
			[FieldOffset(0)]
			public float 角色1反应精通;

			// Token: 0x0402CC6A RID: 183402
			[FieldOffset(4)]
			public float 角色2反应精通;

			// Token: 0x0402CC6B RID: 183403
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC6C RID: 183404
			[FieldOffset(16)]
			public float Result;
		}

		// Token: 0x02008F2E RID: 36654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __删除材质效果_FunctionParams
		{
			// Token: 0x0402CC6D RID: 183405
			[FieldOffset(0)]
			public IntPtr 设置对象_;

			// Token: 0x0402CC6E RID: 183406
			[FieldOffset(8)]
			public int Handle_;

			// Token: 0x0402CC6F RID: 183407
			[FieldOffset(12)]
			public bool PlayWithEnd;

			// Token: 0x0402CC70 RID: 183408
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F2F RID: 36655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __设置材质效果_FunctionParams
		{
			// Token: 0x0402CC71 RID: 183409
			[FieldOffset(0)]
			public IntPtr 设置对象;

			// Token: 0x0402CC72 RID: 183410
			[FieldOffset(8)]
			public IntPtr 材质配置;

			// Token: 0x0402CC73 RID: 183411
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC74 RID: 183412
			[FieldOffset(24)]
			public int Handle;
		}

		// Token: 0x02008F30 RID: 36656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __获取目标周围坐标点_FunctionParams
		{
			// Token: 0x0402CC75 RID: 183413
			[FieldOffset(0)]
			public FRotator 目标旋转;

			// Token: 0x0402CC76 RID: 183414
			[FieldOffset(16)]
			public FVectorDouble 目标坐标;

			// Token: 0x0402CC77 RID: 183415
			[FieldOffset(40)]
			public float 旋转;

			// Token: 0x0402CC78 RID: 183416
			[FieldOffset(44)]
			public float 仰角;

			// Token: 0x0402CC79 RID: 183417
			[FieldOffset(48)]
			public float 长度;

			// Token: 0x0402CC7A RID: 183418
			[FieldOffset(56)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC7B RID: 183419
			[FieldOffset(64)]
			public FVectorDouble 坐标点;
		}

		// Token: 0x02008F31 RID: 36657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __计算向量曲线值_FunctionParams
		{
			// Token: 0x0402CC7C RID: 183420
			[FieldOffset(0)]
			public float 已经经过时间;

			// Token: 0x0402CC7D RID: 183421
			[FieldOffset(4)]
			public float 总时间;

			// Token: 0x0402CC7E RID: 183422
			[FieldOffset(8)]
			public IntPtr 向量曲线;

			// Token: 0x0402CC7F RID: 183423
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC80 RID: 183424
			[FieldOffset(24)]
			public FVector 向量值;
		}

		// Token: 0x02008F32 RID: 36658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __计算曲线值_FunctionParams
		{
			// Token: 0x0402CC81 RID: 183425
			[FieldOffset(0)]
			public float 已经过时间;

			// Token: 0x0402CC82 RID: 183426
			[FieldOffset(4)]
			public float 总时间;

			// Token: 0x0402CC83 RID: 183427
			[FieldOffset(8)]
			public IntPtr 曲线;

			// Token: 0x0402CC84 RID: 183428
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC85 RID: 183429
			[FieldOffset(24)]
			public float 百分比;
		}

		// Token: 0x02008F33 RID: 36659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __角度转化_FunctionParams
		{
			// Token: 0x0402CC86 RID: 183430
			[FieldOffset(0)]
			public float Input;

			// Token: 0x0402CC87 RID: 183431
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC88 RID: 183432
			[FieldOffset(16)]
			public float Output;
		}

		// Token: 0x02008F34 RID: 36660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 424)]
		protected ref struct __射线检测_FunctionParams
		{
			// Token: 0x0402CC89 RID: 183433
			[FieldOffset(0)]
			public IntPtr Context;

			// Token: 0x0402CC8A RID: 183434
			[FieldOffset(8)]
			public FVectorDouble Start;

			// Token: 0x0402CC8B RID: 183435
			[FieldOffset(32)]
			public FVectorDouble End;

			// Token: 0x0402CC8C RID: 183436
			[FieldOffset(56)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x0402CC8D RID: 183437
			[FieldOffset(57)]
			public bool bTraceComplex;

			// Token: 0x0402CC8E RID: 183438
			[FieldOffset(58)]
			public TEnumAsByte<EDrawDebugTrace> DrawDebugType;

			// Token: 0x0402CC8F RID: 183439
			[FieldOffset(59)]
			public bool bIgnoreSelf;

			// Token: 0x0402CC90 RID: 183440
			[FieldOffset(60)]
			public FLinearColor TraceColor;

			// Token: 0x0402CC91 RID: 183441
			[FieldOffset(76)]
			public FLinearColor TraceHitColor;

			// Token: 0x0402CC92 RID: 183442
			[FieldOffset(92)]
			public float DrawTime;

			// Token: 0x0402CC93 RID: 183443
			[FieldOffset(96)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC94 RID: 183444
			[FieldOffset(104)]
			public byte OutHit;

			// Token: 0x0402CC95 RID: 183445
			[FieldOffset(252)]
			public bool __Result;
		}

		// Token: 0x02008F35 RID: 36661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __获取Actor周围坐标点_FunctionParams
		{
			// Token: 0x0402CC96 RID: 183446
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0402CC97 RID: 183447
			[FieldOffset(8)]
			public float 旋转;

			// Token: 0x0402CC98 RID: 183448
			[FieldOffset(12)]
			public float 仰角;

			// Token: 0x0402CC99 RID: 183449
			[FieldOffset(16)]
			public float 长度;

			// Token: 0x0402CC9A RID: 183450
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC9B RID: 183451
			[FieldOffset(32)]
			public FVectorDouble 坐标点;
		}

		// Token: 0x02008F36 RID: 36662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __是否有标签_FunctionParams
		{
			// Token: 0x0402CC9C RID: 183452
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CC9D RID: 183453
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x0402CC9E RID: 183454
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC9F RID: 183455
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02008F37 RID: 36663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __清除标签_FunctionParams
		{
			// Token: 0x0402CCA0 RID: 183456
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CCA1 RID: 183457
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x0402CCA2 RID: 183458
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F38 RID: 36664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __添加标签_FunctionParams
		{
			// Token: 0x0402CCA3 RID: 183459
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CCA4 RID: 183460
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x0402CCA5 RID: 183461
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}
	}
}
