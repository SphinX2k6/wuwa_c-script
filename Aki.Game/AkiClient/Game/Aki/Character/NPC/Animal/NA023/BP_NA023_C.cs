using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA023
{
	// Token: 0x0200421A RID: 16922
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA023/BP_NA023.BP_NA023_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA023_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE4C RID: 179788 RVA: 0x00A0DF34 File Offset: 0x00A0C134
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA023_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA023/BP_NA023.BP_NA023_C");
			}
			return BP_NA023_C._ClassPtr;
		}

		// Token: 0x0602BE4D RID: 179789 RVA: 0x00A0DF58 File Offset: 0x00A0C158
		public BP_NA023_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA023_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE4E RID: 179790 RVA: 0x00A0DF80 File Offset: 0x00A0C180
		[NullableContext(1)]
		public BP_NA023_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA023_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF7 RID: 27895
		// (get) Token: 0x0602BE4F RID: 179791 RVA: 0x00A0DFB3 File Offset: 0x00A0C1B3
		// (set) Token: 0x0602BE50 RID: 179792 RVA: 0x00A0DFC7 File Offset: 0x00A0C1C7
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA023_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA023_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BE51 RID: 179793 RVA: 0x00A0DFDC File Offset: 0x00A0C1DC
		protected BP_NA023_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E83 RID: 93827
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA023/BP_NA023.BP_NA023_C";

		// Token: 0x04016E84 RID: 93828
		private static IntPtr _ClassPtr;

		// Token: 0x04016E85 RID: 93829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E86 RID: 93830
		internal new static int __PropertyOffset_0;
	}
}
