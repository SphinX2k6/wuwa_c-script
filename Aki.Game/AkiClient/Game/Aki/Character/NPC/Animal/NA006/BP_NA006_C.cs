using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006
{
	// Token: 0x0200423C RID: 16956
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006/BP_NA006.BP_NA006_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA006_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEE8 RID: 179944 RVA: 0x00A0F3F0 File Offset: 0x00A0D5F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA006_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006.BP_NA006_C");
			}
			return BP_NA006_C._ClassPtr;
		}

		// Token: 0x0602BEE9 RID: 179945 RVA: 0x00A0F414 File Offset: 0x00A0D614
		public BP_NA006_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA006_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEEA RID: 179946 RVA: 0x00A0F43C File Offset: 0x00A0D63C
		[NullableContext(1)]
		public BP_NA006_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA006_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CFF RID: 27903
		// (get) Token: 0x0602BEEB RID: 179947 RVA: 0x00A0F46F File Offset: 0x00A0D66F
		// (set) Token: 0x0602BEEC RID: 179948 RVA: 0x00A0F483 File Offset: 0x00A0D683
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BEED RID: 179949 RVA: 0x00A0F498 File Offset: 0x00A0D698
		protected BP_NA006_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EF5 RID: 93941
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006.BP_NA006_C";

		// Token: 0x04016EF6 RID: 93942
		private static IntPtr _ClassPtr;

		// Token: 0x04016EF7 RID: 93943
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016EF8 RID: 93944
		internal new static int __PropertyOffset_0;
	}
}
