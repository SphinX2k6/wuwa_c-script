using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004225 RID: 16933
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015.ABP_NA015_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA015_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE82 RID: 179842 RVA: 0x00A0E61C File Offset: 0x00A0C81C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA015_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015.ABP_NA015_C");
			}
			return ABP_NA015_C._ClassPtr;
		}

		// Token: 0x0602BE83 RID: 179843 RVA: 0x00A0E640 File Offset: 0x00A0C840
		public ABP_NA015_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE84 RID: 179844 RVA: 0x00A0E668 File Offset: 0x00A0C868
		[NullableContext(1)]
		public ABP_NA015_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE85 RID: 179845 RVA: 0x00A0E69B File Offset: 0x00A0C89B
		protected ABP_NA015_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EAB RID: 93867
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015.ABP_NA015_C";

		// Token: 0x04016EAC RID: 93868
		private static IntPtr _ClassPtr;

		// Token: 0x04016EAD RID: 93869
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
