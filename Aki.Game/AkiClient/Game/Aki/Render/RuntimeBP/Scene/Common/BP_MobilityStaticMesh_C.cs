using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B61 RID: 15201
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_MobilityStaticMesh.BP_MobilityStaticMesh_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_MobilityStaticMesh_C : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021BB5 RID: 138165 RVA: 0x008F45B8 File Offset: 0x008F27B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MobilityStaticMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_MobilityStaticMesh.BP_MobilityStaticMesh_C");
			}
			return BP_MobilityStaticMesh_C._ClassPtr;
		}

		// Token: 0x06021BB6 RID: 138166 RVA: 0x008F45DC File Offset: 0x008F27DC
		public BP_MobilityStaticMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_MobilityStaticMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BB7 RID: 138167 RVA: 0x008F4604 File Offset: 0x008F2804
		[NullableContext(1)]
		public BP_MobilityStaticMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MobilityStaticMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021BB8 RID: 138168 RVA: 0x008F4637 File Offset: 0x008F2837
		protected BP_MobilityStaticMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010761 RID: 67425
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_MobilityStaticMesh.BP_MobilityStaticMesh_C";

		// Token: 0x04010762 RID: 67426
		private static IntPtr _ClassPtr;

		// Token: 0x04010763 RID: 67427
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
