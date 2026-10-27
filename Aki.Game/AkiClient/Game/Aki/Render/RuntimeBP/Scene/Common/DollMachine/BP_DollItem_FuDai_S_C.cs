using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8E RID: 15246
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai_S.BP_DollItem_FuDai_S_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_DollItem_FuDai_S_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F12 RID: 139026 RVA: 0x008FA208 File Offset: 0x008F8408
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_FuDai_S_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai_S.BP_DollItem_FuDai_S_C");
			}
			return BP_DollItem_FuDai_S_C._ClassPtr;
		}

		// Token: 0x06021F13 RID: 139027 RVA: 0x008FA22C File Offset: 0x008F842C
		public BP_DollItem_FuDai_S_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_FuDai_S_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F14 RID: 139028 RVA: 0x008FA254 File Offset: 0x008F8454
		[NullableContext(1)]
		public BP_DollItem_FuDai_S_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_FuDai_S_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x06021F15 RID: 139029 RVA: 0x008FA287 File Offset: 0x008F8487
		// (set) Token: 0x06021F16 RID: 139030 RVA: 0x008FA29B File Offset: 0x008F849B
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_S_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_S_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F17 RID: 139031 RVA: 0x008FA2B0 File Offset: 0x008F84B0
		protected BP_DollItem_FuDai_S_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010981 RID: 67969
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai_S.BP_DollItem_FuDai_S_C";

		// Token: 0x04010982 RID: 67970
		private static IntPtr _ClassPtr;

		// Token: 0x04010983 RID: 67971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010984 RID: 67972
		internal static int __PropertyOffset_0;
	}
}
