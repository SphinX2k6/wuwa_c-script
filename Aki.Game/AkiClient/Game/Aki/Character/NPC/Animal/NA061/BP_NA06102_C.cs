using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA061
{
	// Token: 0x020041D2 RID: 16850
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA061/BP_NA06102.BP_NA06102_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_NA06102_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCDC RID: 179420 RVA: 0x00A0B044 File Offset: 0x00A09244
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA06102_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA061/BP_NA06102.BP_NA06102_C");
			}
			return BP_NA06102_C._ClassPtr;
		}

		// Token: 0x0602BCDD RID: 179421 RVA: 0x00A0B068 File Offset: 0x00A09268
		public BP_NA06102_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA06102_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCDE RID: 179422 RVA: 0x00A0B090 File Offset: 0x00A09290
		[NullableContext(1)]
		public BP_NA06102_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA06102_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CDE RID: 27870
		// (get) Token: 0x0602BCDF RID: 179423 RVA: 0x00A0B0C3 File Offset: 0x00A092C3
		// (set) Token: 0x0602BCE0 RID: 179424 RVA: 0x00A0B0D7 File Offset: 0x00A092D7
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA06102_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA06102_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BCE1 RID: 179425 RVA: 0x00A0B0EC File Offset: 0x00A092EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA06102_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BCE2 RID: 179426 RVA: 0x00A0B100 File Offset: 0x00A09300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA06102_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BCE3 RID: 179427 RVA: 0x00A0B115 File Offset: 0x00A09315
		protected BP_NA06102_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D79 RID: 93561
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA061/BP_NA06102.BP_NA06102_C";

		// Token: 0x04016D7A RID: 93562
		private static IntPtr _ClassPtr;

		// Token: 0x04016D7B RID: 93563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D7C RID: 93564
		internal static int __PropertyOffset_1;

		// Token: 0x04016D7D RID: 93565
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
