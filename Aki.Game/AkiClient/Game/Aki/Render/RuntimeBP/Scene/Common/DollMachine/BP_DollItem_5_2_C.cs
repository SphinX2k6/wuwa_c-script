using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7E RID: 15230
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_2.BP_DollItem_5_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_5_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E4A RID: 138826 RVA: 0x008F8CFA File Offset: 0x008F6EFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_5_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_2.BP_DollItem_5_2_C");
			}
			return BP_DollItem_5_2_C._ClassPtr;
		}

		// Token: 0x06021E4B RID: 138827 RVA: 0x008F8D20 File Offset: 0x008F6F20
		public BP_DollItem_5_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E4C RID: 138828 RVA: 0x008F8D48 File Offset: 0x008F6F48
		[NullableContext(1)]
		public BP_DollItem_5_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x06021E4D RID: 138829 RVA: 0x008F8D7B File Offset: 0x008F6F7B
		// (set) Token: 0x06021E4E RID: 138830 RVA: 0x008F8D8F File Offset: 0x008F6F8F
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x06021E4F RID: 138831 RVA: 0x008F8DA4 File Offset: 0x008F6FA4
		// (set) Token: 0x06021E50 RID: 138832 RVA: 0x008F8DB8 File Offset: 0x008F6FB8
		public unsafe USkeletalMeshComponent EpropJiwawa05BallMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E51 RID: 138833 RVA: 0x008F8DCD File Offset: 0x008F6FCD
		protected BP_DollItem_5_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401090A RID: 67850
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_2.BP_DollItem_5_2_C";

		// Token: 0x0401090B RID: 67851
		private static IntPtr _ClassPtr;

		// Token: 0x0401090C RID: 67852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401090D RID: 67853
		internal static int __PropertyOffset_0;

		// Token: 0x0401090E RID: 67854
		internal new static int __PropertyOffset_1;
	}
}
