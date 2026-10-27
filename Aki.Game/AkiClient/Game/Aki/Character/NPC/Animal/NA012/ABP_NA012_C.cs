using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x0200422D RID: 16941
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012.ABP_NA012_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA012_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEA6 RID: 179878 RVA: 0x00A0EB14 File Offset: 0x00A0CD14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA012_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012.ABP_NA012_C");
			}
			return ABP_NA012_C._ClassPtr;
		}

		// Token: 0x0602BEA7 RID: 179879 RVA: 0x00A0EB38 File Offset: 0x00A0CD38
		public ABP_NA012_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEA8 RID: 179880 RVA: 0x00A0EB60 File Offset: 0x00A0CD60
		[NullableContext(1)]
		public ABP_NA012_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEA9 RID: 179881 RVA: 0x00A0EB93 File Offset: 0x00A0CD93
		protected ABP_NA012_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EC5 RID: 93893
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012.ABP_NA012_C";

		// Token: 0x04016EC6 RID: 93894
		private static IntPtr _ClassPtr;

		// Token: 0x04016EC7 RID: 93895
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
