using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003E63 RID: 15971
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_PhysicsAttachedBase_C : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602829F RID: 164511 RVA: 0x009A5A4E File Offset: 0x009A3C4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsAttachedBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C");
			}
			return BP_PhysicsAttachedBase_C._ClassPtr;
		}

		// Token: 0x060282A0 RID: 164512 RVA: 0x009A5A74 File Offset: 0x009A3C74
		public BP_PhysicsAttachedBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsAttachedBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060282A1 RID: 164513 RVA: 0x009A5A9C File Offset: 0x009A3C9C
		[NullableContext(1)]
		public BP_PhysicsAttachedBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsAttachedBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060282A2 RID: 164514 RVA: 0x009A5ACF File Offset: 0x009A3CCF
		protected BP_PhysicsAttachedBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014715 RID: 83733
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsAttachedBase.BP_PhysicsAttachedBase_C";

		// Token: 0x04014716 RID: 83734
		private static IntPtr _ClassPtr;

		// Token: 0x04014717 RID: 83735
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
