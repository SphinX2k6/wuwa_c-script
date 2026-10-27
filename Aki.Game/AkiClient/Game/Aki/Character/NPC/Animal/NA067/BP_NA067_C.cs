using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA067
{
	// Token: 0x020041BD RID: 16829
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA067/BP_NA067.BP_NA067_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA067_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC6A RID: 179306 RVA: 0x00A0A2AC File Offset: 0x00A084AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA067_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA067/BP_NA067.BP_NA067_C");
			}
			return BP_NA067_C._ClassPtr;
		}

		// Token: 0x0602BC6B RID: 179307 RVA: 0x00A0A2D0 File Offset: 0x00A084D0
		public BP_NA067_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA067_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC6C RID: 179308 RVA: 0x00A0A2F8 File Offset: 0x00A084F8
		[NullableContext(1)]
		public BP_NA067_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA067_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC6D RID: 179309 RVA: 0x00A0A32B File Offset: 0x00A0852B
		protected BP_NA067_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D2B RID: 93483
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA067/BP_NA067.BP_NA067_C";

		// Token: 0x04016D2C RID: 93484
		private static IntPtr _ClassPtr;

		// Token: 0x04016D2D RID: 93485
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
