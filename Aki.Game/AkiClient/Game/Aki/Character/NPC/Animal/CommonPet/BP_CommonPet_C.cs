using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonPet
{
	// Token: 0x020032C4 RID: 12996
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_CommonPet_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E97 RID: 134807 RVA: 0x009524D9 File Offset: 0x009506D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonPet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C");
			}
			return BP_CommonPet_C._ClassPtr;
		}

		// Token: 0x06020E98 RID: 134808 RVA: 0x00952500 File Offset: 0x00950700
		public BP_CommonPet_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonPet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E99 RID: 134809 RVA: 0x00952528 File Offset: 0x00950728
		[NullableContext(1)]
		public BP_CommonPet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonPet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x06020E9A RID: 134810 RVA: 0x0095255B File Offset: 0x0095075B
		// (set) Token: 0x06020E9B RID: 134811 RVA: 0x0095256F File Offset: 0x0095076F
		[Nullable(2)]
		public unsafe UBoxComponent BlurCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonPet_C.__PropertyOffset_BlurCollision);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonPet_C.__PropertyOffset_BlurCollision, value);
			}
		}

		// Token: 0x06020E9C RID: 134812 RVA: 0x00952584 File Offset: 0x00950784
		protected BP_CommonPet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D33 RID: 73011
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C";

		// Token: 0x04011D34 RID: 73012
		private static IntPtr _ClassPtr;

		// Token: 0x04011D35 RID: 73013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D36 RID: 73014
		internal static int __PropertyOffset_BlurCollision;
	}
}
