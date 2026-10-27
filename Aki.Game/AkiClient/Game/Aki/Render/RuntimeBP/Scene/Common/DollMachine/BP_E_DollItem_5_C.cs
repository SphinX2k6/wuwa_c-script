using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B96 RID: 15254
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_5.BP_E_DollItem_5_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_5_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F59 RID: 139097 RVA: 0x008FA9F1 File Offset: 0x008F8BF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_5.BP_E_DollItem_5_C");
			}
			return BP_E_DollItem_5_C._ClassPtr;
		}

		// Token: 0x06021F5A RID: 139098 RVA: 0x008FAA18 File Offset: 0x008F8C18
		public BP_E_DollItem_5_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F5B RID: 139099 RVA: 0x008FAA40 File Offset: 0x008F8C40
		[NullableContext(1)]
		public BP_E_DollItem_5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06021F5C RID: 139100 RVA: 0x008FAA73 File Offset: 0x008F8C73
		// (set) Token: 0x06021F5D RID: 139101 RVA: 0x008FAA87 File Offset: 0x008F8C87
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa05Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_5_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_5_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F5E RID: 139102 RVA: 0x008FAA9C File Offset: 0x008F8C9C
		protected BP_E_DollItem_5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109B0 RID: 68016
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_5.BP_E_DollItem_5_C";

		// Token: 0x040109B1 RID: 68017
		private static IntPtr _ClassPtr;

		// Token: 0x040109B2 RID: 68018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109B3 RID: 68019
		internal static int __PropertyOffset_0;
	}
}
