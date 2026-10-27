using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020041A6 RID: 16806
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_BaseAnimal_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC00 RID: 179200 RVA: 0x00A095B7 File Offset: 0x00A077B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C");
			}
			return BP_BaseAnimal_C._ClassPtr;
		}

		// Token: 0x0602BC01 RID: 179201 RVA: 0x00A095DC File Offset: 0x00A077DC
		public BP_BaseAnimal_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC02 RID: 179202 RVA: 0x00A09604 File Offset: 0x00A07804
		[NullableContext(1)]
		public BP_BaseAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CCA RID: 27850
		// (get) Token: 0x0602BC03 RID: 179203 RVA: 0x00A09637 File Offset: 0x00A07837
		// (set) Token: 0x0602BC04 RID: 179204 RVA: 0x00A0964B File Offset: 0x00A0784B
		[Nullable(2)]
		public unsafe UCurveFloat TurnSpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseAnimal_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseAnimal_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BC05 RID: 179205 RVA: 0x00A09660 File Offset: 0x00A07860
		protected BP_BaseAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CC7 RID: 93383
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/BP_BaseAnimal.BP_BaseAnimal_C";

		// Token: 0x04016CC8 RID: 93384
		private static IntPtr _ClassPtr;

		// Token: 0x04016CC9 RID: 93385
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016CCA RID: 93386
		internal static int __PropertyOffset_0;
	}
}
