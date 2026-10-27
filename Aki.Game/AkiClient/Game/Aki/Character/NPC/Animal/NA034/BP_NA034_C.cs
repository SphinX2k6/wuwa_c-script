using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA034
{
	// Token: 0x02004211 RID: 16913
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA034/BP_NA034.BP_NA034_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA034_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE24 RID: 179748 RVA: 0x00A0DA14 File Offset: 0x00A0BC14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA034_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA034/BP_NA034.BP_NA034_C");
			}
			return BP_NA034_C._ClassPtr;
		}

		// Token: 0x0602BE25 RID: 179749 RVA: 0x00A0DA38 File Offset: 0x00A0BC38
		public BP_NA034_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA034_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE26 RID: 179750 RVA: 0x00A0DA60 File Offset: 0x00A0BC60
		[NullableContext(1)]
		public BP_NA034_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA034_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF5 RID: 27893
		// (get) Token: 0x0602BE27 RID: 179751 RVA: 0x00A0DA93 File Offset: 0x00A0BC93
		// (set) Token: 0x0602BE28 RID: 179752 RVA: 0x00A0DAA7 File Offset: 0x00A0BCA7
		[Nullable(2)]
		public unsafe UCapsuleComponent Bip001Head
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA034_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA034_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BE29 RID: 179753 RVA: 0x00A0DABC File Offset: 0x00A0BCBC
		protected BP_NA034_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E66 RID: 93798
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA034/BP_NA034.BP_NA034_C";

		// Token: 0x04016E67 RID: 93799
		private static IntPtr _ClassPtr;

		// Token: 0x04016E68 RID: 93800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E69 RID: 93801
		internal new static int __PropertyOffset_0;
	}
}
