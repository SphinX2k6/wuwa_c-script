using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA002
{
	// Token: 0x02004241 RID: 16961
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA002/ABP_NA002.ABP_NA002_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA002_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF02 RID: 179970 RVA: 0x00A0F71C File Offset: 0x00A0D91C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA002_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA002/ABP_NA002.ABP_NA002_C");
			}
			return ABP_NA002_C._ClassPtr;
		}

		// Token: 0x0602BF03 RID: 179971 RVA: 0x00A0F740 File Offset: 0x00A0D940
		public ABP_NA002_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA002_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF04 RID: 179972 RVA: 0x00A0F768 File Offset: 0x00A0D968
		[NullableContext(1)]
		public ABP_NA002_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA002_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF05 RID: 179973 RVA: 0x00A0F79B File Offset: 0x00A0D99B
		protected ABP_NA002_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F07 RID: 93959
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA002/ABP_NA002.ABP_NA002_C";

		// Token: 0x04016F08 RID: 93960
		private static IntPtr _ClassPtr;

		// Token: 0x04016F09 RID: 93961
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
