using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B99 RID: 15257
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_2.BP_E_DollItem_7_2_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_7_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F6B RID: 139115 RVA: 0x008FAC0D File Offset: 0x008F8E0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_7_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_2.BP_E_DollItem_7_2_C");
			}
			return BP_E_DollItem_7_2_C._ClassPtr;
		}

		// Token: 0x06021F6C RID: 139116 RVA: 0x008FAC34 File Offset: 0x008F8E34
		public BP_E_DollItem_7_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_7_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F6D RID: 139117 RVA: 0x008FAC5C File Offset: 0x008F8E5C
		[NullableContext(1)]
		public BP_E_DollItem_7_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_7_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06021F6E RID: 139118 RVA: 0x008FAC8F File Offset: 0x008F8E8F
		// (set) Token: 0x06021F6F RID: 139119 RVA: 0x008FACA3 File Offset: 0x008F8EA3
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa07Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_7_2_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_7_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F70 RID: 139120 RVA: 0x008FACB8 File Offset: 0x008F8EB8
		protected BP_E_DollItem_7_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109BC RID: 68028
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_2.BP_E_DollItem_7_2_C";

		// Token: 0x040109BD RID: 68029
		private static IntPtr _ClassPtr;

		// Token: 0x040109BE RID: 68030
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109BF RID: 68031
		internal static int __PropertyOffset_0;
	}
}
