using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA071
{
	// Token: 0x020041AC RID: 16812
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071.ABP_NA071_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA071_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC12 RID: 179218 RVA: 0x00A09804 File Offset: 0x00A07A04
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA071_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071.ABP_NA071_C");
			}
			return ABP_NA071_C._ClassPtr;
		}

		// Token: 0x0602BC13 RID: 179219 RVA: 0x00A09828 File Offset: 0x00A07A28
		public ABP_NA071_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA071_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC14 RID: 179220 RVA: 0x00A09850 File Offset: 0x00A07A50
		[NullableContext(1)]
		public ABP_NA071_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA071_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC15 RID: 179221 RVA: 0x00A09883 File Offset: 0x00A07A83
		protected ABP_NA071_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CEE RID: 93422
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071.ABP_NA071_C";

		// Token: 0x04016CEF RID: 93423
		private static IntPtr _ClassPtr;

		// Token: 0x04016CF0 RID: 93424
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
