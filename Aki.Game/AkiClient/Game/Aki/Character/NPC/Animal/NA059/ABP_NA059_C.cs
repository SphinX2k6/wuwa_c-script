using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA059
{
	// Token: 0x020041D6 RID: 16854
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059.ABP_NA059_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA059_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCFA RID: 179450 RVA: 0x00A0B387 File Offset: 0x00A09587
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA059_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059.ABP_NA059_C");
			}
			return ABP_NA059_C._ClassPtr;
		}

		// Token: 0x0602BCFB RID: 179451 RVA: 0x00A0B3AC File Offset: 0x00A095AC
		public ABP_NA059_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA059_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCFC RID: 179452 RVA: 0x00A0B3D4 File Offset: 0x00A095D4
		[NullableContext(1)]
		public ABP_NA059_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA059_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCFD RID: 179453 RVA: 0x00A0B407 File Offset: 0x00A09607
		protected ABP_NA059_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D8C RID: 93580
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059.ABP_NA059_C";

		// Token: 0x04016D8D RID: 93581
		private static IntPtr _ClassPtr;

		// Token: 0x04016D8E RID: 93582
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
