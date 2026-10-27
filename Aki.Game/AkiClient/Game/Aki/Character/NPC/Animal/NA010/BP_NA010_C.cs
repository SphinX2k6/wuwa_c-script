using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA010
{
	// Token: 0x02004233 RID: 16947
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA010/BP_NA010.BP_NA010_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA010_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEC2 RID: 179906 RVA: 0x00A0EEFC File Offset: 0x00A0D0FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA010_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA010/BP_NA010.BP_NA010_C");
			}
			return BP_NA010_C._ClassPtr;
		}

		// Token: 0x0602BEC3 RID: 179907 RVA: 0x00A0EF20 File Offset: 0x00A0D120
		public BP_NA010_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA010_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEC4 RID: 179908 RVA: 0x00A0EF48 File Offset: 0x00A0D148
		[NullableContext(1)]
		public BP_NA010_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA010_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CFE RID: 27902
		// (get) Token: 0x0602BEC5 RID: 179909 RVA: 0x00A0EF7B File Offset: 0x00A0D17B
		// (set) Token: 0x0602BEC6 RID: 179910 RVA: 0x00A0EF8F File Offset: 0x00A0D18F
		[Nullable(2)]
		public unsafe UCapsuleComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA010_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA010_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BEC7 RID: 179911 RVA: 0x00A0EFA4 File Offset: 0x00A0D1A4
		protected BP_NA010_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ED9 RID: 93913
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA010/BP_NA010.BP_NA010_C";

		// Token: 0x04016EDA RID: 93914
		private static IntPtr _ClassPtr;

		// Token: 0x04016EDB RID: 93915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016EDC RID: 93916
		internal new static int __PropertyOffset_0;
	}
}
