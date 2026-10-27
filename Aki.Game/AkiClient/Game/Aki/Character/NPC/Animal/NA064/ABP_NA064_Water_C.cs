using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA064
{
	// Token: 0x020041C9 RID: 16841
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Water.ABP_NA064_Water_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA064_Water_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCAA RID: 179370 RVA: 0x00A0AA58 File Offset: 0x00A08C58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA064_Water_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Water.ABP_NA064_Water_C");
			}
			return ABP_NA064_Water_C._ClassPtr;
		}

		// Token: 0x0602BCAB RID: 179371 RVA: 0x00A0AA7C File Offset: 0x00A08C7C
		public ABP_NA064_Water_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Water_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCAC RID: 179372 RVA: 0x00A0AAA4 File Offset: 0x00A08CA4
		[NullableContext(1)]
		public ABP_NA064_Water_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Water_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCAD RID: 179373 RVA: 0x00A0AAD7 File Offset: 0x00A08CD7
		protected ABP_NA064_Water_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D57 RID: 93527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Water.ABP_NA064_Water_C";

		// Token: 0x04016D58 RID: 93528
		private static IntPtr _ClassPtr;

		// Token: 0x04016D59 RID: 93529
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
