using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020032C1 RID: 12993
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_BaseAnimal_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E91 RID: 134801 RVA: 0x00952427 File Offset: 0x00950627
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C");
			}
			return BP_BaseAnimal_C._ClassPtr;
		}

		// Token: 0x06020E92 RID: 134802 RVA: 0x0095244C File Offset: 0x0095064C
		public BP_BaseAnimal_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E93 RID: 134803 RVA: 0x00952474 File Offset: 0x00950674
		[NullableContext(1)]
		public BP_BaseAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x06020E94 RID: 134804 RVA: 0x009524A7 File Offset: 0x009506A7
		// (set) Token: 0x06020E95 RID: 134805 RVA: 0x009524BB File Offset: 0x009506BB
		[Nullable(2)]
		public unsafe UCurveFloat TurnSpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseAnimal_C.__PropertyOffset_TurnSpeedCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseAnimal_C.__PropertyOffset_TurnSpeedCurve, value);
			}
		}

		// Token: 0x06020E96 RID: 134806 RVA: 0x009524D0 File Offset: 0x009506D0
		protected BP_BaseAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D15 RID: 72981
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C";

		// Token: 0x04011D16 RID: 72982
		private static IntPtr _ClassPtr;

		// Token: 0x04011D17 RID: 72983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D18 RID: 72984
		internal static int __PropertyOffset_TurnSpeedCurve;
	}
}
