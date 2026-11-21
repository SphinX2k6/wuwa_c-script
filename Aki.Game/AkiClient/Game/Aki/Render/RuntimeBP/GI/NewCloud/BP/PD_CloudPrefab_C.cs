using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x020030FB RID: 12539
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class PD_CloudPrefab_C : UKuroPDCloudPrefab, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E9F8 RID: 125432 RVA: 0x00918953 File Offset: 0x00916B53
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CloudPrefab_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C");
			}
			return PD_CloudPrefab_C._ClassPtr;
		}

		// Token: 0x0601E9F9 RID: 125433 RVA: 0x00918978 File Offset: 0x00916B78
		public PD_CloudPrefab_C() : this(BuiltinUtils.AllocNativeUObject(PD_CloudPrefab_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E9FA RID: 125434 RVA: 0x009189A0 File Offset: 0x00916BA0
		[NullableContext(1)]
		public PD_CloudPrefab_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CloudPrefab_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E9FB RID: 125435 RVA: 0x009189D3 File Offset: 0x00916BD3
		protected PD_CloudPrefab_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103F0 RID: 66544
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C";

		// Token: 0x040103F1 RID: 66545
		private static IntPtr _ClassPtr;

		// Token: 0x040103F2 RID: 66546
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
