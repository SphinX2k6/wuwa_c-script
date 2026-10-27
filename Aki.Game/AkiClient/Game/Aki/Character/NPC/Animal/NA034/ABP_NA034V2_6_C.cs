using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA034
{
	// Token: 0x0200420F RID: 16911
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034V2_6.ABP_NA034V2_6_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA034V2_6_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE1C RID: 179740 RVA: 0x00A0D904 File Offset: 0x00A0BB04
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA034V2_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034V2_6.ABP_NA034V2_6_C");
			}
			return ABP_NA034V2_6_C._ClassPtr;
		}

		// Token: 0x0602BE1D RID: 179741 RVA: 0x00A0D928 File Offset: 0x00A0BB28
		public ABP_NA034V2_6_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA034V2_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE1E RID: 179742 RVA: 0x00A0D950 File Offset: 0x00A0BB50
		[NullableContext(1)]
		public ABP_NA034V2_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA034V2_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE1F RID: 179743 RVA: 0x00A0D983 File Offset: 0x00A0BB83
		protected ABP_NA034V2_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E60 RID: 93792
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034V2_6.ABP_NA034V2_6_C";

		// Token: 0x04016E61 RID: 93793
		private static IntPtr _ClassPtr;

		// Token: 0x04016E62 RID: 93794
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
