using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004133 RID: 16691
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Aim.GA_Floater_Aim_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Floater_Aim_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B05B RID: 176219 RVA: 0x009F333D File Offset: 0x009F153D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Floater_Aim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Aim.GA_Floater_Aim_C");
			}
			return GA_Floater_Aim_C._ClassPtr;
		}

		// Token: 0x0602B05C RID: 176220 RVA: 0x009F3364 File Offset: 0x009F1564
		public GA_Floater_Aim_C() : this(BuiltinUtils.AllocNativeUObject(GA_Floater_Aim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B05D RID: 176221 RVA: 0x009F338C File Offset: 0x009F158C
		[NullableContext(1)]
		public GA_Floater_Aim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Floater_Aim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B05E RID: 176222 RVA: 0x009F33C0 File Offset: 0x009F15C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_8B6138384F011AC35A3A6290139F19F4(in FGameplayTag Tag)
		{
			GA_Floater_Aim_C.__Added_8B6138384F011AC35A3A6290139F19F4_FunctionParams* ptr = stackalloc GA_Floater_Aim_C.__Added_8B6138384F011AC35A3A6290139F19F4_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Floater_Aim_C.__Added_8B6138384F011AC35A3A6290139F19F4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Floater_Aim_C.__Added_8B6138384F011AC35A3A6290139F19F4_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Floater_Aim_C.__Added_8B6138384F011AC35A3A6290139F19F4_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B05F RID: 176223 RVA: 0x009F340B File Offset: 0x009F160B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Floater_Aim_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B060 RID: 176224 RVA: 0x009F341F File Offset: 0x009F161F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Floater_Aim_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B061 RID: 176225 RVA: 0x009F3434 File Offset: 0x009F1634
		protected GA_Floater_Aim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401650B RID: 91403
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Floater_Aim.GA_Floater_Aim_C";

		// Token: 0x0401650C RID: 91404
		private static IntPtr _ClassPtr;

		// Token: 0x0401650D RID: 91405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401650E RID: 91406
		private static IntPtr __Added_8B6138384F011AC35A3A6290139F19F4_NativeFunctionPtr;

		// Token: 0x0401650F RID: 91407
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A460 RID: 42080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_8B6138384F011AC35A3A6290139F19F4_FunctionParams
		{
			// Token: 0x040322A4 RID: 205476
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
