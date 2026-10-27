using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GB
{
	// Token: 0x02004428 RID: 17448
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GB/BP_BulletLogicBase.BP_BulletLogicBase_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_BulletLogicBase_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D19C RID: 184732 RVA: 0x00A31470 File Offset: 0x00A2F670
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BulletLogicBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GB/BP_BulletLogicBase.BP_BulletLogicBase_C");
			}
			return BP_BulletLogicBase_C._ClassPtr;
		}

		// Token: 0x0602D19D RID: 184733 RVA: 0x00A31494 File Offset: 0x00A2F694
		public BP_BulletLogicBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_BulletLogicBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D19E RID: 184734 RVA: 0x00A314BC File Offset: 0x00A2F6BC
		[NullableContext(1)]
		public BP_BulletLogicBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BulletLogicBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D19F RID: 184735 RVA: 0x00A314F0 File Offset: 0x00A2F6F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 子弹范围内吸附(UObject 子弹, float 吸附速度)
		{
			BP_BulletLogicBase_C.__子弹范围内吸附_FunctionParams* ptr = stackalloc BP_BulletLogicBase_C.__子弹范围内吸附_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BulletLogicBase_C.__子弹范围内吸附_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletLogicBase_C.__子弹范围内吸附_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹 = ((子弹 != null) ? 子弹.NativePtr : IntPtr.Zero);
			ptr->吸附速度 = 吸附速度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletLogicBase_C.__子弹范围内吸附_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1A0 RID: 184736 RVA: 0x00A3154C File Offset: 0x00A2F74C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 执行(TsBaseCharacter 攻击者, TsBaseCharacter 受击者, SBulletDataMain 子弹数据, UObject 子弹)
		{
			BP_BulletLogicBase_C.__执行_FunctionParams* ptr = stackalloc BP_BulletLogicBase_C.__执行_FunctionParams[(UIntPtr)743] + 15L / (long)sizeof(BP_BulletLogicBase_C.__执行_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletLogicBase_C.__执行_NativeFunctionPtr, (void*)ptr, 1);
			ptr->攻击者 = ((攻击者 != null) ? 攻击者.NativePtr : IntPtr.Zero);
			ptr->受击者 = ((受击者 != null) ? 受击者.NativePtr : IntPtr.Zero);
			if (子弹数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMain.StaticStruct(), &ptr->子弹数据, 子弹数据.NativePtr, 1, false);
			}
			ptr->子弹 = ((子弹 != null) ? 子弹.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletLogicBase_C.__执行_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_BulletLogicBase_C.__执行_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D1A1 RID: 184737 RVA: 0x00A31605 File Offset: 0x00A2F805
		protected BP_BulletLogicBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F2C RID: 98092
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GB/BP_BulletLogicBase.BP_BulletLogicBase_C";

		// Token: 0x04017F2D RID: 98093
		private static IntPtr _ClassPtr;

		// Token: 0x04017F2E RID: 98094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017F2F RID: 98095
		private static IntPtr __子弹范围内吸附_NativeFunctionPtr;

		// Token: 0x04017F30 RID: 98096
		private static IntPtr __执行_NativeFunctionPtr;

		// Token: 0x0200A67C RID: 42620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __子弹范围内吸附_FunctionParams
		{
			// Token: 0x040325CC RID: 206284
			[FieldOffset(0)]
			public IntPtr 子弹;

			// Token: 0x040325CD RID: 206285
			[FieldOffset(8)]
			public float 吸附速度;
		}

		// Token: 0x0200A67D RID: 42621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 728)]
		protected ref struct __执行_FunctionParams
		{
			// Token: 0x040325CE RID: 206286
			[FieldOffset(0)]
			public IntPtr 攻击者;

			// Token: 0x040325CF RID: 206287
			[FieldOffset(8)]
			public IntPtr 受击者;

			// Token: 0x040325D0 RID: 206288
			[FieldOffset(16)]
			public byte 子弹数据;

			// Token: 0x040325D1 RID: 206289
			[FieldOffset(720)]
			public IntPtr 子弹;
		}
	}
}
