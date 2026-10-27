using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8B RID: 15243
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi.BP_DollItem_BeiBi_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_DollItem_BeiBi_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EBC RID: 138940 RVA: 0x008F99EE File Offset: 0x008F7BEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_BeiBi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi.BP_DollItem_BeiBi_C");
			}
			return BP_DollItem_BeiBi_C._ClassPtr;
		}

		// Token: 0x06021EBD RID: 138941 RVA: 0x008F9A14 File Offset: 0x008F7C14
		public BP_DollItem_BeiBi_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_BeiBi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EBE RID: 138942 RVA: 0x008F9A3C File Offset: 0x008F7C3C
		[NullableContext(1)]
		public BP_DollItem_BeiBi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_BeiBi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x06021EBF RID: 138943 RVA: 0x008F9A6F File Offset: 0x008F7C6F
		// (set) Token: 0x06021EC0 RID: 138944 RVA: 0x008F9A83 File Offset: 0x008F7C83
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021EC1 RID: 138945 RVA: 0x008F9A98 File Offset: 0x008F7C98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_BeiBi_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021EC2 RID: 138946 RVA: 0x008F9AAC File Offset: 0x008F7CAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_BeiBi_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021EC3 RID: 138947 RVA: 0x008F9AC1 File Offset: 0x008F7CC1
		protected BP_DollItem_BeiBi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010953 RID: 67923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi.BP_DollItem_BeiBi_C";

		// Token: 0x04010954 RID: 67924
		private static IntPtr _ClassPtr;

		// Token: 0x04010955 RID: 67925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010956 RID: 67926
		internal new static int __PropertyOffset_1;

		// Token: 0x04010957 RID: 67927
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
