using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA032
{
	// Token: 0x02004213 RID: 16915
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA032/BP_NA032.BP_NA032_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA032_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE2E RID: 179758 RVA: 0x00A0DB50 File Offset: 0x00A0BD50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA032_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA032/BP_NA032.BP_NA032_C");
			}
			return BP_NA032_C._ClassPtr;
		}

		// Token: 0x0602BE2F RID: 179759 RVA: 0x00A0DB74 File Offset: 0x00A0BD74
		public BP_NA032_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA032_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE30 RID: 179760 RVA: 0x00A0DB9C File Offset: 0x00A0BD9C
		[NullableContext(1)]
		public BP_NA032_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA032_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE31 RID: 179761 RVA: 0x00A0DBCF File Offset: 0x00A0BDCF
		protected BP_NA032_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E6D RID: 93805
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA032/BP_NA032.BP_NA032_C";

		// Token: 0x04016E6E RID: 93806
		private static IntPtr _ClassPtr;

		// Token: 0x04016E6F RID: 93807
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
