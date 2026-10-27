using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA070
{
	// Token: 0x020041B2 RID: 16818
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA070/BP_NA070.BP_NA070_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA070_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC2A RID: 179242 RVA: 0x00A09B34 File Offset: 0x00A07D34
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA070_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA070/BP_NA070.BP_NA070_C");
			}
			return BP_NA070_C._ClassPtr;
		}

		// Token: 0x0602BC2B RID: 179243 RVA: 0x00A09B58 File Offset: 0x00A07D58
		public BP_NA070_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA070_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC2C RID: 179244 RVA: 0x00A09B80 File Offset: 0x00A07D80
		[NullableContext(1)]
		public BP_NA070_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA070_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CCB RID: 27851
		// (get) Token: 0x0602BC2D RID: 179245 RVA: 0x00A09BB3 File Offset: 0x00A07DB3
		// (set) Token: 0x0602BC2E RID: 179246 RVA: 0x00A09BC7 File Offset: 0x00A07DC7
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA070_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA070_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BC2F RID: 179247 RVA: 0x00A09BDC File Offset: 0x00A07DDC
		protected BP_NA070_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D00 RID: 93440
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA070/BP_NA070.BP_NA070_C";

		// Token: 0x04016D01 RID: 93441
		private static IntPtr _ClassPtr;

		// Token: 0x04016D02 RID: 93442
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D03 RID: 93443
		internal new static int __PropertyOffset_0;
	}
}
