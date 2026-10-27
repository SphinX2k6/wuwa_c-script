using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006
{
	// Token: 0x0200423D RID: 16957
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_Path.BP_NA006_Path_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA006_Path_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEEE RID: 179950 RVA: 0x00A0F4A1 File Offset: 0x00A0D6A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA006_Path_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_Path.BP_NA006_Path_C");
			}
			return BP_NA006_Path_C._ClassPtr;
		}

		// Token: 0x0602BEEF RID: 179951 RVA: 0x00A0F4C8 File Offset: 0x00A0D6C8
		public BP_NA006_Path_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA006_Path_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEF0 RID: 179952 RVA: 0x00A0F4F0 File Offset: 0x00A0D6F0
		[NullableContext(1)]
		public BP_NA006_Path_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA006_Path_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D00 RID: 27904
		// (get) Token: 0x0602BEF1 RID: 179953 RVA: 0x00A0F523 File Offset: 0x00A0D723
		// (set) Token: 0x0602BEF2 RID: 179954 RVA: 0x00A0F537 File Offset: 0x00A0D737
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_Path_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA006_Path_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BEF3 RID: 179955 RVA: 0x00A0F54C File Offset: 0x00A0D74C
		protected BP_NA006_Path_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EF9 RID: 93945
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006/BP_NA006_Path.BP_NA006_Path_C";

		// Token: 0x04016EFA RID: 93946
		private static IntPtr _ClassPtr;

		// Token: 0x04016EFB RID: 93947
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016EFC RID: 93948
		internal new static int __PropertyOffset_0;
	}
}
