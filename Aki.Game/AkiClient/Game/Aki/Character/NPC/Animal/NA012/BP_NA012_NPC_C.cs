using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x02004230 RID: 16944
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_NPC.BP_NA012_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA012_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEB2 RID: 179890 RVA: 0x00A0ECAC File Offset: 0x00A0CEAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA012_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_NPC.BP_NA012_NPC_C");
			}
			return BP_NA012_NPC_C._ClassPtr;
		}

		// Token: 0x0602BEB3 RID: 179891 RVA: 0x00A0ECD0 File Offset: 0x00A0CED0
		public BP_NA012_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA012_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEB4 RID: 179892 RVA: 0x00A0ECF8 File Offset: 0x00A0CEF8
		[NullableContext(1)]
		public BP_NA012_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA012_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEB5 RID: 179893 RVA: 0x00A0ED2B File Offset: 0x00A0CF2B
		protected BP_NA012_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ECE RID: 93902
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_NPC.BP_NA012_NPC_C";

		// Token: 0x04016ECF RID: 93903
		private static IntPtr _ClassPtr;

		// Token: 0x04016ED0 RID: 93904
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
