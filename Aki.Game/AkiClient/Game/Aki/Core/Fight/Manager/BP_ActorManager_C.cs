using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200401B RID: 16411
	[UnrealObjectPath("/Game/Aki/Core/Fight/Manager/BP_ActorManager.BP_ActorManager_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_ActorManager_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A146 RID: 172358 RVA: 0x009D5200 File Offset: 0x009D3400
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ActorManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/Manager/BP_ActorManager.BP_ActorManager_C");
			}
			return BP_ActorManager_C._ClassPtr;
		}

		// Token: 0x0602A147 RID: 172359 RVA: 0x009D5224 File Offset: 0x009D3424
		public BP_ActorManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_ActorManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A148 RID: 172360 RVA: 0x009D524C File Offset: 0x009D344C
		[NullableContext(1)]
		public BP_ActorManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ActorManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A149 RID: 172361 RVA: 0x009D527F File Offset: 0x009D347F
		protected BP_ActorManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015ABD RID: 88765
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_ActorManager.BP_ActorManager_C";

		// Token: 0x04015ABE RID: 88766
		private static IntPtr _ClassPtr;

		// Token: 0x04015ABF RID: 88767
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
