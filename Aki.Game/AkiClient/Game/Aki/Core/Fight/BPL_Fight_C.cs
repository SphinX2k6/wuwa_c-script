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
	// Token: 0x02003FEC RID: 16364
	[UnrealObjectPath("/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_Fight_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F00 RID: 171776 RVA: 0x009D0F7F File Offset: 0x009CF17F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_Fight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C");
			}
			return BPL_Fight_C._ClassPtr;
		}

		// Token: 0x06029F01 RID: 171777 RVA: 0x009D0FA4 File Offset: 0x009CF1A4
		public BPL_Fight_C() : this(BuiltinUtils.AllocNativeUObject(BPL_Fight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F02 RID: 171778 RVA: 0x009D0FCC File Offset: 0x009CF1CC
		[NullableContext(1)]
		public BPL_Fight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_Fight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06029F03 RID: 171779 RVA: 0x009D1000 File Offset: 0x009CF200
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F04 RID: 171780 RVA: 0x009D1078 File Offset: 0x009CF278
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F05 RID: 171781 RVA: 0x009D10F8 File Offset: 0x009CF2F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F06 RID: 171782 RVA: 0x009D1190 File Offset: 0x009CF390
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 使用GE(TsBaseCharacter 使用者, TsBaseCharacter 目标, int GE的等级, FGameplayTagContainer 添加AssetTags, FGameplayTagContainer 添加GrantedTags, int 层数, float Duration, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GE的类型, FKuroGameplayParameterContainer GE的参数, UObject __WorldContext, ref FActiveGameplayEffectHandle ActiveHandle)
		{
			BPL_Fight_C.__使用GE_FunctionParams* ptr = stackalloc BPL_Fight_C.__使用GE_FunctionParams[(UIntPtr)479] + 15L / (long)sizeof(BPL_Fight_C.__使用GE_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__使用GE_NativeFunctionPtr, (void*)ptr, 1);
			ptr->使用者 = ((使用者 != null) ? 使用者.NativePtr : IntPtr.Zero);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->GE的等级 = GE的等级;
			if (添加AssetTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->添加AssetTags, 添加AssetTags.NativePtr, 1, false);
			}
			if (添加GrantedTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->添加GrantedTags, 添加GrantedTags.NativePtr, 1, false);
			}
			ptr->层数 = 层数;
			ptr->Duration = Duration;
			ptr->GE的类型 = GE的类型;
			if (GE的参数 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGameplayParameterContainer.StaticStruct(), &ptr->GE的参数, GE的参数.NativePtr, 1, false);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPL_Fight_C.__使用GE_NativeFunctionPtr, (void*)ptr);
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), ActiveHandle.NativePtr, &ptr->ActiveHandle, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_Fight_C.__使用GE_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029F07 RID: 171783 RVA: 0x009D1300 File Offset: 0x009CF500
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F08 RID: 171784 RVA: 0x009D13A0 File Offset: 0x009CF5A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F09 RID: 171785 RVA: 0x009D1438 File Offset: 0x009CF638
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F0A RID: 171786 RVA: 0x009D14C8 File Offset: 0x009CF6C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F0B RID: 171787 RVA: 0x009D153C File Offset: 0x009CF73C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F0C RID: 171788 RVA: 0x009D1654 File Offset: 0x009CF854
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F0D RID: 171789 RVA: 0x009D16F8 File Offset: 0x009CF8F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void 获取游戏实例(UObject __WorldContext, ref BP_MainGameInstance_C AsBP_Main_Game_Instance)
		{
			BPL_Fight_C.StaticClass();
			BPL_Fight_C.__获取游戏实例_FunctionParams* ptr = stackalloc BPL_Fight_C.__获取游戏实例_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_Fight_C.__获取游戏实例_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Fight_C.__获取游戏实例_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref BPL_Fight_C.__获取游戏实例_FunctionParams ptr2 = ref *ptr;
			BP_MainGameInstance_C bp_MainGameInstance_C = AsBP_Main_Game_Instance;
			ptr2.AsBP_Main_Game_Instance = ((bp_MainGameInstance_C != null) ? bp_MainGameInstance_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Fight_C._ClassDefaultObjectPtr, BPL_Fight_C.__获取游戏实例_NativeFunctionPtr, (void*)ptr);
			AsBP_Main_Game_Instance = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_MainGameInstance_C>(ptr->AsBP_Main_Game_Instance);
		}

		// Token: 0x06029F0E RID: 171790 RVA: 0x009D1778 File Offset: 0x009CF978
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F0F RID: 171791 RVA: 0x009D17F8 File Offset: 0x009CF9F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F10 RID: 171792 RVA: 0x009D1870 File Offset: 0x009CFA70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06029F11 RID: 171793 RVA: 0x009D18E7 File Offset: 0x009CFAE7
		protected BPL_Fight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158C3 RID: 88259
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BPL_Fight.BPL_Fight_C";

		// Token: 0x040158C4 RID: 88260
		private static IntPtr _ClassPtr;

		// Token: 0x040158C5 RID: 88261
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158C6 RID: 88262
		private static IntPtr __反应伤害倍率计算_NativeFunctionPtr;

		// Token: 0x040158C7 RID: 88263
		private static IntPtr __删除材质效果_NativeFunctionPtr;

		// Token: 0x040158C8 RID: 88264
		private static IntPtr __设置材质效果_NativeFunctionPtr;

		// Token: 0x040158C9 RID: 88265
		private static IntPtr __使用GE_NativeFunctionPtr;

		// Token: 0x040158CA RID: 88266
		private static IntPtr __获取目标周围坐标点_NativeFunctionPtr;

		// Token: 0x040158CB RID: 88267
		private static IntPtr __计算向量曲线值_NativeFunctionPtr;

		// Token: 0x040158CC RID: 88268
		private static IntPtr __计算曲线值_NativeFunctionPtr;

		// Token: 0x040158CD RID: 88269
		private static IntPtr __角度转化_NativeFunctionPtr;

		// Token: 0x040158CE RID: 88270
		private static IntPtr __射线检测_NativeFunctionPtr;

		// Token: 0x040158CF RID: 88271
		private static IntPtr __获取Actor周围坐标点_NativeFunctionPtr;

		// Token: 0x040158D0 RID: 88272
		private static IntPtr __获取游戏实例_NativeFunctionPtr;

		// Token: 0x040158D1 RID: 88273
		private static IntPtr __是否有标签_NativeFunctionPtr;

		// Token: 0x040158D2 RID: 88274
		private static IntPtr __清除标签_NativeFunctionPtr;

		// Token: 0x040158D3 RID: 88275
		private static IntPtr __添加标签_NativeFunctionPtr;

		// Token: 0x0200A30D RID: 41741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __反应伤害倍率计算_FunctionParams
		{
			// Token: 0x04032084 RID: 204932
			[FieldOffset(0)]
			public float 角色1反应精通;

			// Token: 0x04032085 RID: 204933
			[FieldOffset(4)]
			public float 角色2反应精通;

			// Token: 0x04032086 RID: 204934
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04032087 RID: 204935
			[FieldOffset(16)]
			public float Result;
		}

		// Token: 0x0200A30E RID: 41742
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __删除材质效果_FunctionParams
		{
			// Token: 0x04032088 RID: 204936
			[FieldOffset(0)]
			public IntPtr 设置对象_;

			// Token: 0x04032089 RID: 204937
			[FieldOffset(8)]
			public int Handle_;

			// Token: 0x0403208A RID: 204938
			[FieldOffset(12)]
			public bool PlayWithEnd;

			// Token: 0x0403208B RID: 204939
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A30F RID: 41743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __设置材质效果_FunctionParams
		{
			// Token: 0x0403208C RID: 204940
			[FieldOffset(0)]
			public IntPtr 设置对象;

			// Token: 0x0403208D RID: 204941
			[FieldOffset(8)]
			public IntPtr 材质配置;

			// Token: 0x0403208E RID: 204942
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0403208F RID: 204943
			[FieldOffset(24)]
			public int Handle;
		}

		// Token: 0x0200A310 RID: 41744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 464)]
		protected ref struct __使用GE_FunctionParams
		{
			// Token: 0x04032090 RID: 204944
			[FieldOffset(0)]
			public IntPtr 使用者;

			// Token: 0x04032091 RID: 204945
			[FieldOffset(8)]
			public IntPtr 目标;

			// Token: 0x04032092 RID: 204946
			[FieldOffset(16)]
			public int GE的等级;

			// Token: 0x04032093 RID: 204947
			[FieldOffset(24)]
			public byte 添加AssetTags;

			// Token: 0x04032094 RID: 204948
			[FieldOffset(56)]
			public byte 添加GrantedTags;

			// Token: 0x04032095 RID: 204949
			[FieldOffset(88)]
			public int 层数;

			// Token: 0x04032096 RID: 204950
			[FieldOffset(92)]
			public float Duration;

			// Token: 0x04032097 RID: 204951
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(96)]
			public TSubclassOf<UGameplayEffect> GE的类型;

			// Token: 0x04032098 RID: 204952
			[FieldOffset(104)]
			public byte GE的参数;

			// Token: 0x04032099 RID: 204953
			[FieldOffset(120)]
			public IntPtr __WorldContext;

			// Token: 0x0403209A RID: 204954
			[FieldOffset(128)]
			public byte ActiveHandle;
		}

		// Token: 0x0200A311 RID: 41745
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __获取目标周围坐标点_FunctionParams
		{
			// Token: 0x0403209B RID: 204955
			[FieldOffset(0)]
			public FRotator 目标旋转;

			// Token: 0x0403209C RID: 204956
			[FieldOffset(16)]
			public FVectorDouble 目标坐标;

			// Token: 0x0403209D RID: 204957
			[FieldOffset(40)]
			public float 旋转;

			// Token: 0x0403209E RID: 204958
			[FieldOffset(44)]
			public float 仰角;

			// Token: 0x0403209F RID: 204959
			[FieldOffset(48)]
			public float 长度;

			// Token: 0x040320A0 RID: 204960
			[FieldOffset(56)]
			public IntPtr __WorldContext;

			// Token: 0x040320A1 RID: 204961
			[FieldOffset(64)]
			public FVectorDouble 坐标点;
		}

		// Token: 0x0200A312 RID: 41746
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __计算向量曲线值_FunctionParams
		{
			// Token: 0x040320A2 RID: 204962
			[FieldOffset(0)]
			public float 已经经过时间;

			// Token: 0x040320A3 RID: 204963
			[FieldOffset(4)]
			public float 总时间;

			// Token: 0x040320A4 RID: 204964
			[FieldOffset(8)]
			public IntPtr 向量曲线;

			// Token: 0x040320A5 RID: 204965
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040320A6 RID: 204966
			[FieldOffset(24)]
			public FVector 向量值;
		}

		// Token: 0x0200A313 RID: 41747
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __计算曲线值_FunctionParams
		{
			// Token: 0x040320A7 RID: 204967
			[FieldOffset(0)]
			public float 已经过时间;

			// Token: 0x040320A8 RID: 204968
			[FieldOffset(4)]
			public float 总时间;

			// Token: 0x040320A9 RID: 204969
			[FieldOffset(8)]
			public IntPtr 曲线;

			// Token: 0x040320AA RID: 204970
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040320AB RID: 204971
			[FieldOffset(24)]
			public float 百分比;
		}

		// Token: 0x0200A314 RID: 41748
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __角度转化_FunctionParams
		{
			// Token: 0x040320AC RID: 204972
			[FieldOffset(0)]
			public float Input;

			// Token: 0x040320AD RID: 204973
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x040320AE RID: 204974
			[FieldOffset(16)]
			public float Output;
		}

		// Token: 0x0200A315 RID: 41749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 424)]
		protected ref struct __射线检测_FunctionParams
		{
			// Token: 0x040320AF RID: 204975
			[FieldOffset(0)]
			public IntPtr Context;

			// Token: 0x040320B0 RID: 204976
			[FieldOffset(8)]
			public FVectorDouble Start;

			// Token: 0x040320B1 RID: 204977
			[FieldOffset(32)]
			public FVectorDouble End;

			// Token: 0x040320B2 RID: 204978
			[FieldOffset(56)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x040320B3 RID: 204979
			[FieldOffset(57)]
			public bool bTraceComplex;

			// Token: 0x040320B4 RID: 204980
			[FieldOffset(58)]
			public TEnumAsByte<EDrawDebugTrace> DrawDebugType;

			// Token: 0x040320B5 RID: 204981
			[FieldOffset(59)]
			public bool bIgnoreSelf;

			// Token: 0x040320B6 RID: 204982
			[FieldOffset(60)]
			public FLinearColor TraceColor;

			// Token: 0x040320B7 RID: 204983
			[FieldOffset(76)]
			public FLinearColor TraceHitColor;

			// Token: 0x040320B8 RID: 204984
			[FieldOffset(92)]
			public float DrawTime;

			// Token: 0x040320B9 RID: 204985
			[FieldOffset(96)]
			public IntPtr __WorldContext;

			// Token: 0x040320BA RID: 204986
			[FieldOffset(104)]
			public byte OutHit;

			// Token: 0x040320BB RID: 204987
			[FieldOffset(252)]
			public bool __Result;
		}

		// Token: 0x0200A316 RID: 41750
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __获取Actor周围坐标点_FunctionParams
		{
			// Token: 0x040320BC RID: 204988
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040320BD RID: 204989
			[FieldOffset(8)]
			public float 旋转;

			// Token: 0x040320BE RID: 204990
			[FieldOffset(12)]
			public float 仰角;

			// Token: 0x040320BF RID: 204991
			[FieldOffset(16)]
			public float 长度;

			// Token: 0x040320C0 RID: 204992
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x040320C1 RID: 204993
			[FieldOffset(32)]
			public FVectorDouble 坐标点;
		}

		// Token: 0x0200A317 RID: 41751
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取游戏实例_FunctionParams
		{
			// Token: 0x040320C2 RID: 204994
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x040320C3 RID: 204995
			[FieldOffset(8)]
			public IntPtr AsBP_Main_Game_Instance;
		}

		// Token: 0x0200A318 RID: 41752
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __是否有标签_FunctionParams
		{
			// Token: 0x040320C4 RID: 204996
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040320C5 RID: 204997
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x040320C6 RID: 204998
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x040320C7 RID: 204999
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x0200A319 RID: 41753
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __清除标签_FunctionParams
		{
			// Token: 0x040320C8 RID: 205000
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040320C9 RID: 205001
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x040320CA RID: 205002
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A31A RID: 41754
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __添加标签_FunctionParams
		{
			// Token: 0x040320CB RID: 205003
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040320CC RID: 205004
			[FieldOffset(8)]
			public FGameplayTag 标签;

			// Token: 0x040320CD RID: 205005
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}
	}
}
