using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA058
{
	// Token: 0x020041DB RID: 16859
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA058/ABP_NA058.ABP_NA058_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA058_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD20 RID: 179488 RVA: 0x00A0B7A3 File Offset: 0x00A099A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA058_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA058/ABP_NA058.ABP_NA058_C");
			}
			return ABP_NA058_C._ClassPtr;
		}

		// Token: 0x0602BD21 RID: 179489 RVA: 0x00A0B7C8 File Offset: 0x00A099C8
		public ABP_NA058_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA058_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD22 RID: 179490 RVA: 0x00A0B7F0 File Offset: 0x00A099F0
		[NullableContext(1)]
		public ABP_NA058_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA058_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD23 RID: 179491 RVA: 0x00A0B823 File Offset: 0x00A09A23
		protected ABP_NA058_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DA4 RID: 93604
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA058/ABP_NA058.ABP_NA058_C";

		// Token: 0x04016DA5 RID: 93605
		private static IntPtr _ClassPtr;

		// Token: 0x04016DA6 RID: 93606
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
