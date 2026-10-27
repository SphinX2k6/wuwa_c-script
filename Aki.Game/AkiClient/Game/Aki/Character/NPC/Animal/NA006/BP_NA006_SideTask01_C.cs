using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006
{
	// Token: 0x0200423E RID: 16958
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_SideTask01.BP_NA006_SideTask01_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA006_SideTask01_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEF4 RID: 179956 RVA: 0x00A0F555 File Offset: 0x00A0D755
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA006_SideTask01_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_SideTask01.BP_NA006_SideTask01_C");
			}
			return BP_NA006_SideTask01_C._ClassPtr;
		}

		// Token: 0x0602BEF5 RID: 179957 RVA: 0x00A0F57C File Offset: 0x00A0D77C
		public BP_NA006_SideTask01_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA006_SideTask01_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEF6 RID: 179958 RVA: 0x00A0F5A4 File Offset: 0x00A0D7A4
		[NullableContext(1)]
		public BP_NA006_SideTask01_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA006_SideTask01_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D01 RID: 27905
		// (get) Token: 0x0602BEF7 RID: 179959 RVA: 0x00A0F5D7 File Offset: 0x00A0D7D7
		// (set) Token: 0x0602BEF8 RID: 179960 RVA: 0x00A0F5EB File Offset: 0x00A0D7EB
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_SideTask01_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_SideTask01_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BEF9 RID: 179961 RVA: 0x00A0F600 File Offset: 0x00A0D800
		protected BP_NA006_SideTask01_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EFD RID: 93949
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_SideTask01.BP_NA006_SideTask01_C";

		// Token: 0x04016EFE RID: 93950
		private static IntPtr _ClassPtr;

		// Token: 0x04016EFF RID: 93951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F00 RID: 93952
		internal new static int __PropertyOffset_0;
	}
}
