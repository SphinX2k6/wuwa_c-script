using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA026
{
	// Token: 0x02004218 RID: 16920
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA026/BP_NA026.BP_NA026_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA026_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE42 RID: 179778 RVA: 0x00A0DDF8 File Offset: 0x00A0BFF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA026_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA026/BP_NA026.BP_NA026_C");
			}
			return BP_NA026_C._ClassPtr;
		}

		// Token: 0x0602BE43 RID: 179779 RVA: 0x00A0DE1C File Offset: 0x00A0C01C
		public BP_NA026_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA026_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE44 RID: 179780 RVA: 0x00A0DE44 File Offset: 0x00A0C044
		[NullableContext(1)]
		public BP_NA026_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA026_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF6 RID: 27894
		// (get) Token: 0x0602BE45 RID: 179781 RVA: 0x00A0DE77 File Offset: 0x00A0C077
		// (set) Token: 0x0602BE46 RID: 179782 RVA: 0x00A0DE8B File Offset: 0x00A0C08B
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA026_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA026_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BE47 RID: 179783 RVA: 0x00A0DEA0 File Offset: 0x00A0C0A0
		protected BP_NA026_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E7C RID: 93820
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA026/BP_NA026.BP_NA026_C";

		// Token: 0x04016E7D RID: 93821
		private static IntPtr _ClassPtr;

		// Token: 0x04016E7E RID: 93822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E7F RID: 93823
		internal new static int __PropertyOffset_0;
	}
}
