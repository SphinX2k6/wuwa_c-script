using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B90 RID: 15248
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng_S.BP_DollItem_XingSheng_S_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_DollItem_XingSheng_S_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F1E RID: 139038 RVA: 0x008FA36D File Offset: 0x008F856D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_XingSheng_S_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng_S.BP_DollItem_XingSheng_S_C");
			}
			return BP_DollItem_XingSheng_S_C._ClassPtr;
		}

		// Token: 0x06021F1F RID: 139039 RVA: 0x008FA394 File Offset: 0x008F8594
		public BP_DollItem_XingSheng_S_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_XingSheng_S_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F20 RID: 139040 RVA: 0x008FA3BC File Offset: 0x008F85BC
		[NullableContext(1)]
		public BP_DollItem_XingSheng_S_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_XingSheng_S_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x06021F21 RID: 139041 RVA: 0x008FA3EF File Offset: 0x008F85EF
		// (set) Token: 0x06021F22 RID: 139042 RVA: 0x008FA403 File Offset: 0x008F8603
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_XingSheng_S_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_XingSheng_S_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F23 RID: 139043 RVA: 0x008FA418 File Offset: 0x008F8618
		protected BP_DollItem_XingSheng_S_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010989 RID: 67977
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng_S.BP_DollItem_XingSheng_S_C";

		// Token: 0x0401098A RID: 67978
		private static IntPtr _ClassPtr;

		// Token: 0x0401098B RID: 67979
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401098C RID: 67980
		internal static int __PropertyOffset_0;
	}
}
