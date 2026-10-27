using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA066
{
	// Token: 0x020041C1 RID: 16833
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA066/BP_NA066.BP_NA066_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class BP_NA066_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC7A RID: 179322 RVA: 0x00A0A4CC File Offset: 0x00A086CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA066_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA066/BP_NA066.BP_NA066_C");
			}
			return BP_NA066_C._ClassPtr;
		}

		// Token: 0x0602BC7B RID: 179323 RVA: 0x00A0A4F0 File Offset: 0x00A086F0
		public BP_NA066_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA066_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC7C RID: 179324 RVA: 0x00A0A518 File Offset: 0x00A08718
		[NullableContext(1)]
		public BP_NA066_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA066_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CD3 RID: 27859
		// (get) Token: 0x0602BC7D RID: 179325 RVA: 0x00A0A54B File Offset: 0x00A0874B
		// (set) Token: 0x0602BC7E RID: 179326 RVA: 0x00A0A55F File Offset: 0x00A0875F
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CD4 RID: 27860
		// (get) Token: 0x0602BC7F RID: 179327 RVA: 0x00A0A574 File Offset: 0x00A08774
		// (set) Token: 0x0602BC80 RID: 179328 RVA: 0x00A0A588 File Offset: 0x00A08788
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006CD5 RID: 27861
		// (get) Token: 0x0602BC81 RID: 179329 RVA: 0x00A0A59D File Offset: 0x00A0879D
		// (set) Token: 0x0602BC82 RID: 179330 RVA: 0x00A0A5B1 File Offset: 0x00A087B1
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602BC83 RID: 179331 RVA: 0x00A0A5C6 File Offset: 0x00A087C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA066_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BC84 RID: 179332 RVA: 0x00A0A5DA File Offset: 0x00A087DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA066_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BC85 RID: 179333 RVA: 0x00A0A5EF File Offset: 0x00A087EF
		protected BP_NA066_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D37 RID: 93495
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA066/BP_NA066.BP_NA066_C";

		// Token: 0x04016D38 RID: 93496
		private static IntPtr _ClassPtr;

		// Token: 0x04016D39 RID: 93497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D3A RID: 93498
		internal static int __PropertyOffset_1;

		// Token: 0x04016D3B RID: 93499
		internal static int __PropertyOffset_2;

		// Token: 0x04016D3C RID: 93500
		internal static int __PropertyOffset_3;

		// Token: 0x04016D3D RID: 93501
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
