using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003152 RID: 12626
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_PhysicsAttachedBase_C : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0E5 RID: 127205 RVA: 0x009255CA File Offset: 0x009237CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsAttachedBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C");
			}
			return BP_PhysicsAttachedBase_C._ClassPtr;
		}

		// Token: 0x0601F0E6 RID: 127206 RVA: 0x009255F0 File Offset: 0x009237F0
		public BP_PhysicsAttachedBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsAttachedBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0E7 RID: 127207 RVA: 0x00925618 File Offset: 0x00923818
		[NullableContext(1)]
		public BP_PhysicsAttachedBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsAttachedBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F0E8 RID: 127208 RVA: 0x0092564B File Offset: 0x0092384B
		protected BP_PhysicsAttachedBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010976 RID: 67958
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C";

		// Token: 0x04010977 RID: 67959
		private static IntPtr _ClassPtr;

		// Token: 0x04010978 RID: 67960
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
