using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonPet
{
	// Token: 0x02004246 RID: 16966
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_CommonPet_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF35 RID: 180021 RVA: 0x00A0FEB5 File Offset: 0x00A0E0B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonPet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C");
			}
			return BP_CommonPet_C._ClassPtr;
		}

		// Token: 0x0602BF36 RID: 180022 RVA: 0x00A0FEDC File Offset: 0x00A0E0DC
		public BP_CommonPet_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonPet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF37 RID: 180023 RVA: 0x00A0FF04 File Offset: 0x00A0E104
		[NullableContext(1)]
		public BP_CommonPet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonPet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D0A RID: 27914
		// (get) Token: 0x0602BF38 RID: 180024 RVA: 0x00A0FF37 File Offset: 0x00A0E137
		// (set) Token: 0x0602BF39 RID: 180025 RVA: 0x00A0FF4B File Offset: 0x00A0E14B
		[Nullable(2)]
		public unsafe UBoxComponent BlurCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonPet_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonPet_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BF3A RID: 180026 RVA: 0x00A0FF60 File Offset: 0x00A0E160
		protected BP_CommonPet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F29 RID: 93993
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonPet/BP_CommonPet.BP_CommonPet_C";

		// Token: 0x04016F2A RID: 93994
		private static IntPtr _ClassPtr;

		// Token: 0x04016F2B RID: 93995
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F2C RID: 93996
		internal new static int __PropertyOffset_0;
	}
}
