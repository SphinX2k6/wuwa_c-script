using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA069
{
	// Token: 0x020041B5 RID: 16821
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA069/BP_NA069.BP_NA069_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA069_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC38 RID: 179256 RVA: 0x00A09CF8 File Offset: 0x00A07EF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA069_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA069/BP_NA069.BP_NA069_C");
			}
			return BP_NA069_C._ClassPtr;
		}

		// Token: 0x0602BC39 RID: 179257 RVA: 0x00A09D1C File Offset: 0x00A07F1C
		public BP_NA069_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA069_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC3A RID: 179258 RVA: 0x00A09D44 File Offset: 0x00A07F44
		[NullableContext(1)]
		public BP_NA069_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA069_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CCC RID: 27852
		// (get) Token: 0x0602BC3B RID: 179259 RVA: 0x00A09D77 File Offset: 0x00A07F77
		// (set) Token: 0x0602BC3C RID: 179260 RVA: 0x00A09D8B File Offset: 0x00A07F8B
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA069_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA069_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CCD RID: 27853
		// (get) Token: 0x0602BC3D RID: 179261 RVA: 0x00A09DA0 File Offset: 0x00A07FA0
		// (set) Token: 0x0602BC3E RID: 179262 RVA: 0x00A09DB4 File Offset: 0x00A07FB4
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA069_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA069_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BC3F RID: 179263 RVA: 0x00A09DC9 File Offset: 0x00A07FC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA069_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BC40 RID: 179264 RVA: 0x00A09DDD File Offset: 0x00A07FDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA069_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BC41 RID: 179265 RVA: 0x00A09DF2 File Offset: 0x00A07FF2
		protected BP_NA069_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D0A RID: 93450
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA069/BP_NA069.BP_NA069_C";

		// Token: 0x04016D0B RID: 93451
		private static IntPtr _ClassPtr;

		// Token: 0x04016D0C RID: 93452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D0D RID: 93453
		internal static int __PropertyOffset_1;

		// Token: 0x04016D0E RID: 93454
		internal static int __PropertyOffset_2;

		// Token: 0x04016D0F RID: 93455
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
