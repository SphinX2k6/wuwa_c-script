using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.Input
{
	// Token: 0x02004061 RID: 16481
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/Input/BP_InputComponent_Motorcycle.BP_InputComponent_Motorcycle_C")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 610)]
	public class BP_InputComponent_Motorcycle_C : BP_InputComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A545 RID: 173381 RVA: 0x009DCE41 File Offset: 0x009DB041
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InputComponent_Motorcycle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/Input/BP_InputComponent_Motorcycle.BP_InputComponent_Motorcycle_C");
			}
			return BP_InputComponent_Motorcycle_C._ClassPtr;
		}

		// Token: 0x0602A546 RID: 173382 RVA: 0x009DCE68 File Offset: 0x009DB068
		public BP_InputComponent_Motorcycle_C() : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_Motorcycle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A547 RID: 173383 RVA: 0x009DCE90 File Offset: 0x009DB090
		[NullableContext(1)]
		public BP_InputComponent_Motorcycle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_Motorcycle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x0602A548 RID: 173384 RVA: 0x009DCEC3 File Offset: 0x009DB0C3
		// (set) Token: 0x0602A549 RID: 173385 RVA: 0x009DCED3 File Offset: 0x009DB0D3
		public unsafe bool 按下跳跃时在地面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_Motorcycle_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_Motorcycle_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x0602A54A RID: 173386 RVA: 0x009DCEE4 File Offset: 0x009DB0E4
		// (set) Token: 0x0602A54B RID: 173387 RVA: 0x009DCEF4 File Offset: 0x009DB0F4
		public unsafe bool 已释放蓄力跳
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_Motorcycle_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_Motorcycle_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A54C RID: 173388 RVA: 0x009DCF08 File Offset: 0x009DB108
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 走跑切换抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__走跑切换抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__走跑切换抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__走跑切换抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A54D RID: 173389 RVA: 0x009DCF5C File Offset: 0x009DB15C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 大招抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__大招抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__大招抬起_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__大招抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__大招抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__大招抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A54E RID: 173390 RVA: 0x009DCFB4 File Offset: 0x009DB1B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 大招长按(float time)
		{
			BP_InputComponent_Motorcycle_C.__大招长按_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__大招长按_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__大招长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__大招长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__大招长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A54F RID: 173391 RVA: 0x009DD00C File Offset: 0x009DB20C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 大招按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__大招按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__大招按下_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__大招按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__大招按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__大招按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A550 RID: 173392 RVA: 0x009DD064 File Offset: 0x009DB264
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 跳跃抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__跳跃抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__跳跃抬起_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__跳跃抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A551 RID: 173393 RVA: 0x009DD0BC File Offset: 0x009DB2BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 跳跃按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__跳跃按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__跳跃按下_FunctionParams[(UIntPtr)439] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__跳跃按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__跳跃按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__跳跃按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A552 RID: 173394 RVA: 0x009DD114 File Offset: 0x009DB314
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 走跑切换按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__走跑切换按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__走跑切换按下_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__走跑切换按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A553 RID: 173395 RVA: 0x009DD168 File Offset: 0x009DB368
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 瞄准按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__瞄准按下_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A554 RID: 173396 RVA: 0x009DD1BC File Offset: 0x009DB3BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象1抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__幻象1抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__幻象1抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__幻象1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A555 RID: 173397 RVA: 0x009DD210 File Offset: 0x009DB410
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象1按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__幻象1按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__幻象1按下_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__幻象1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__幻象1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__幻象1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A556 RID: 173398 RVA: 0x009DD264 File Offset: 0x009DB464
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__攻击抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__攻击抬起_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__攻击抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__攻击抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__攻击抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A557 RID: 173399 RVA: 0x009DD2BC File Offset: 0x009DB4BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击长按(float time)
		{
			BP_InputComponent_Motorcycle_C.__攻击长按_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__攻击长按_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A558 RID: 173400 RVA: 0x009DD314 File Offset: 0x009DB514
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__攻击按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__攻击按下_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A559 RID: 173401 RVA: 0x009DD36C File Offset: 0x009DB56C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__技能1抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__技能1抬起_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__技能1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__技能1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__技能1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A55A RID: 173402 RVA: 0x009DD3C4 File Offset: 0x009DB5C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1长按(float time)
		{
			BP_InputComponent_Motorcycle_C.__技能1长按_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__技能1长按_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__技能1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__技能1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__技能1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A55B RID: 173403 RVA: 0x009DD41C File Offset: 0x009DB61C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__技能1按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__技能1按下_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A55C RID: 173404 RVA: 0x009DD474 File Offset: 0x009DB674
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 闪避抬起(float time)
		{
			BP_InputComponent_Motorcycle_C.__闪避抬起_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__闪避抬起_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__闪避抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__闪避抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__闪避抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A55D RID: 173405 RVA: 0x009DD4C8 File Offset: 0x009DB6C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 闪避按下(float time)
		{
			BP_InputComponent_Motorcycle_C.__闪避按下_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__闪避按下_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__闪避按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__闪避按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__闪避按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602A55E RID: 173406 RVA: 0x009DD51C File Offset: 0x009DB71C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A55F RID: 173407 RVA: 0x009DD568 File Offset: 0x009DB768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InputComponent_Motorcycle_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A560 RID: 173408 RVA: 0x009DD5B4 File Offset: 0x009DB7B4
		protected BP_InputComponent_Motorcycle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D6C RID: 89452
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/Input/BP_InputComponent_Motorcycle.BP_InputComponent_Motorcycle_C";

		// Token: 0x04015D6D RID: 89453
		private static IntPtr _ClassPtr;

		// Token: 0x04015D6E RID: 89454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D6F RID: 89455
		internal new static int __PropertyOffset_1;

		// Token: 0x04015D70 RID: 89456
		internal new static int __PropertyOffset_2;

		// Token: 0x04015D71 RID: 89457
		private static IntPtr __走跑切换抬起_NativeFunctionPtr;

		// Token: 0x04015D72 RID: 89458
		private static IntPtr __大招抬起_NativeFunctionPtr;

		// Token: 0x04015D73 RID: 89459
		private static IntPtr __大招长按_NativeFunctionPtr;

		// Token: 0x04015D74 RID: 89460
		private static IntPtr __大招按下_NativeFunctionPtr;

		// Token: 0x04015D75 RID: 89461
		private static IntPtr __跳跃抬起_NativeFunctionPtr;

		// Token: 0x04015D76 RID: 89462
		private static IntPtr __跳跃按下_NativeFunctionPtr;

		// Token: 0x04015D77 RID: 89463
		private static IntPtr __走跑切换按下_NativeFunctionPtr;

		// Token: 0x04015D78 RID: 89464
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x04015D79 RID: 89465
		private static IntPtr __幻象1抬起_NativeFunctionPtr;

		// Token: 0x04015D7A RID: 89466
		private static IntPtr __幻象1按下_NativeFunctionPtr;

		// Token: 0x04015D7B RID: 89467
		private static IntPtr __攻击抬起_NativeFunctionPtr;

		// Token: 0x04015D7C RID: 89468
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x04015D7D RID: 89469
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x04015D7E RID: 89470
		private static IntPtr __技能1抬起_NativeFunctionPtr;

		// Token: 0x04015D7F RID: 89471
		private static IntPtr __技能1长按_NativeFunctionPtr;

		// Token: 0x04015D80 RID: 89472
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x04015D81 RID: 89473
		private static IntPtr __闪避抬起_NativeFunctionPtr;

		// Token: 0x04015D82 RID: 89474
		private static IntPtr __闪避按下_NativeFunctionPtr;

		// Token: 0x04015D83 RID: 89475
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A366 RID: 41830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __走跑切换抬起_FunctionParams
		{
			// Token: 0x04032138 RID: 205112
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032139 RID: 205113
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A367 RID: 41831
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected new ref struct __大招抬起_FunctionParams
		{
			// Token: 0x0403213A RID: 205114
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403213B RID: 205115
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A368 RID: 41832
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected new ref struct __大招长按_FunctionParams
		{
			// Token: 0x0403213C RID: 205116
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403213D RID: 205117
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A369 RID: 41833
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected new ref struct __大招按下_FunctionParams
		{
			// Token: 0x0403213E RID: 205118
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403213F RID: 205119
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36A RID: 41834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected new ref struct __跳跃抬起_FunctionParams
		{
			// Token: 0x04032140 RID: 205120
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032141 RID: 205121
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36B RID: 41835
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 424)]
		protected new ref struct __跳跃按下_FunctionParams
		{
			// Token: 0x04032142 RID: 205122
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032143 RID: 205123
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36C RID: 41836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __走跑切换按下_FunctionParams
		{
			// Token: 0x04032144 RID: 205124
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032145 RID: 205125
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36D RID: 41837
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x04032146 RID: 205126
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032147 RID: 205127
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36E RID: 41838
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象1抬起_FunctionParams
		{
			// Token: 0x04032148 RID: 205128
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032149 RID: 205129
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A36F RID: 41839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __幻象1按下_FunctionParams
		{
			// Token: 0x0403214A RID: 205130
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403214B RID: 205131
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A370 RID: 41840
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected new ref struct __攻击抬起_FunctionParams
		{
			// Token: 0x0403214C RID: 205132
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403214D RID: 205133
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A371 RID: 41841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected new ref struct __攻击长按_FunctionParams
		{
			// Token: 0x0403214E RID: 205134
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403214F RID: 205135
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A372 RID: 41842
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected new ref struct __攻击按下_FunctionParams
		{
			// Token: 0x04032150 RID: 205136
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032151 RID: 205137
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A373 RID: 41843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected new ref struct __技能1抬起_FunctionParams
		{
			// Token: 0x04032152 RID: 205138
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032153 RID: 205139
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A374 RID: 41844
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected new ref struct __技能1长按_FunctionParams
		{
			// Token: 0x04032154 RID: 205140
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032155 RID: 205141
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A375 RID: 41845
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected new ref struct __技能1按下_FunctionParams
		{
			// Token: 0x04032156 RID: 205142
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032157 RID: 205143
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A376 RID: 41846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected new ref struct __闪避抬起_FunctionParams
		{
			// Token: 0x04032158 RID: 205144
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032159 RID: 205145
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A377 RID: 41847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected new ref struct __闪避按下_FunctionParams
		{
			// Token: 0x0403215A RID: 205146
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403215B RID: 205147
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A378 RID: 41848
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403215C RID: 205148
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
