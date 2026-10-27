using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7C RID: 15228
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_3.BP_DollItem_4_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_4_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E3A RID: 138810 RVA: 0x008F8B43 File Offset: 0x008F6D43
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_4_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_3.BP_DollItem_4_3_C");
			}
			return BP_DollItem_4_3_C._ClassPtr;
		}

		// Token: 0x06021E3B RID: 138811 RVA: 0x008F8B68 File Offset: 0x008F6D68
		public BP_DollItem_4_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E3C RID: 138812 RVA: 0x008F8B90 File Offset: 0x008F6D90
		[NullableContext(1)]
		public BP_DollItem_4_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x06021E3D RID: 138813 RVA: 0x008F8BC3 File Offset: 0x008F6DC3
		// (set) Token: 0x06021E3E RID: 138814 RVA: 0x008F8BD7 File Offset: 0x008F6DD7
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x06021E3F RID: 138815 RVA: 0x008F8BEC File Offset: 0x008F6DEC
		// (set) Token: 0x06021E40 RID: 138816 RVA: 0x008F8C00 File Offset: 0x008F6E00
		public unsafe USkeletalMeshComponent EpropJiwawa04PoolMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E41 RID: 138817 RVA: 0x008F8C15 File Offset: 0x008F6E15
		protected BP_DollItem_4_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010900 RID: 67840
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_3.BP_DollItem_4_3_C";

		// Token: 0x04010901 RID: 67841
		private static IntPtr _ClassPtr;

		// Token: 0x04010902 RID: 67842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010903 RID: 67843
		internal static int __PropertyOffset_0;

		// Token: 0x04010904 RID: 67844
		internal new static int __PropertyOffset_1;
	}
}
