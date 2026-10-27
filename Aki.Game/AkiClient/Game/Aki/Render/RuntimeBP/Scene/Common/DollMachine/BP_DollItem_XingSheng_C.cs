using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8F RID: 15247
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng.BP_DollItem_XingSheng_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_DollItem_XingSheng_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F18 RID: 139032 RVA: 0x008FA2B9 File Offset: 0x008F84B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_XingSheng_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng.BP_DollItem_XingSheng_C");
			}
			return BP_DollItem_XingSheng_C._ClassPtr;
		}

		// Token: 0x06021F19 RID: 139033 RVA: 0x008FA2E0 File Offset: 0x008F84E0
		public BP_DollItem_XingSheng_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_XingSheng_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F1A RID: 139034 RVA: 0x008FA308 File Offset: 0x008F8508
		[NullableContext(1)]
		public BP_DollItem_XingSheng_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_XingSheng_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x06021F1B RID: 139035 RVA: 0x008FA33B File Offset: 0x008F853B
		// (set) Token: 0x06021F1C RID: 139036 RVA: 0x008FA34F File Offset: 0x008F854F
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_XingSheng_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_XingSheng_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F1D RID: 139037 RVA: 0x008FA364 File Offset: 0x008F8564
		protected BP_DollItem_XingSheng_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010985 RID: 67973
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_XingSheng.BP_DollItem_XingSheng_C";

		// Token: 0x04010986 RID: 67974
		private static IntPtr _ClassPtr;

		// Token: 0x04010987 RID: 67975
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010988 RID: 67976
		internal static int __PropertyOffset_0;
	}
}
