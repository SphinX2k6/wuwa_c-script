using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA062
{
	// Token: 0x020041CC RID: 16844
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062.ABP_NA062_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA062_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCBE RID: 179390 RVA: 0x00A0AC94 File Offset: 0x00A08E94
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA062_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062.ABP_NA062_C");
			}
			return ABP_NA062_C._ClassPtr;
		}

		// Token: 0x0602BCBF RID: 179391 RVA: 0x00A0ACB8 File Offset: 0x00A08EB8
		public ABP_NA062_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA062_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCC0 RID: 179392 RVA: 0x00A0ACE0 File Offset: 0x00A08EE0
		[NullableContext(1)]
		public ABP_NA062_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA062_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCC1 RID: 179393 RVA: 0x00A0AD13 File Offset: 0x00A08F13
		protected ABP_NA062_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D64 RID: 93540
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062.ABP_NA062_C";

		// Token: 0x04016D65 RID: 93541
		private static IntPtr _ClassPtr;

		// Token: 0x04016D66 RID: 93542
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
