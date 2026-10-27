using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B74 RID: 15220
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_1.BP_DollItem_2_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_2_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DF8 RID: 138744 RVA: 0x008F843A File Offset: 0x008F663A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_2_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_1.BP_DollItem_2_1_C");
			}
			return BP_DollItem_2_1_C._ClassPtr;
		}

		// Token: 0x06021DF9 RID: 138745 RVA: 0x008F8460 File Offset: 0x008F6660
		public BP_DollItem_2_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DFA RID: 138746 RVA: 0x008F8488 File Offset: 0x008F6688
		[NullableContext(1)]
		public BP_DollItem_2_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x06021DFB RID: 138747 RVA: 0x008F84BB File Offset: 0x008F66BB
		// (set) Token: 0x06021DFC RID: 138748 RVA: 0x008F84CF File Offset: 0x008F66CF
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x06021DFD RID: 138749 RVA: 0x008F84E4 File Offset: 0x008F66E4
		// (set) Token: 0x06021DFE RID: 138750 RVA: 0x008F84F8 File Offset: 0x008F66F8
		public unsafe USkeletalMeshComponent EpropJiwawa02Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021DFF RID: 138751 RVA: 0x008F850D File Offset: 0x008F670D
		protected BP_DollItem_2_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108D7 RID: 67799
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_1.BP_DollItem_2_1_C";

		// Token: 0x040108D8 RID: 67800
		private static IntPtr _ClassPtr;

		// Token: 0x040108D9 RID: 67801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108DA RID: 67802
		internal static int __PropertyOffset_0;

		// Token: 0x040108DB RID: 67803
		internal new static int __PropertyOffset_1;
	}
}
