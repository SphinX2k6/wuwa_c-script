using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x02003FA2 RID: 16290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/PuertsRef.PuertsRef_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PuertsRef_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060299DA RID: 170458 RVA: 0x009C8B43 File Offset: 0x009C6D43
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PuertsRef_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Common/Struct/PuertsRef.PuertsRef_C");
			}
			return PuertsRef_C._ClassPtr;
		}

		// Token: 0x060299DB RID: 170459 RVA: 0x009C8B68 File Offset: 0x009C6D68
		public PuertsRef_C() : this(BuiltinUtils.AllocNativeUObject(PuertsRef_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060299DC RID: 170460 RVA: 0x009C8B90 File Offset: 0x009C6D90
		public PuertsRef_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PuertsRef_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006439 RID: 25657
		// (get) Token: 0x060299DD RID: 170461 RVA: 0x009C8BC4 File Offset: 0x009C6DC4
		// (set) Token: 0x060299DE RID: 170462 RVA: 0x009C8BFD File Offset: 0x009C6DFD
		public SCharacterLocationsAndRadius NewVar_0
		{
			get
			{
				base.FastCheckIsValid();
				SCharacterLocationsAndRadius result;
				if ((result = this._NewVar_0) == null)
				{
					result = (this._NewVar_0 = new SCharacterLocationsAndRadius(base.NativePtr + (IntPtr)PuertsRef_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCharacterLocationsAndRadius.StaticStruct(), base.NativePtr + (IntPtr)PuertsRef_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060299DF RID: 170463 RVA: 0x009C8C1E File Offset: 0x009C6E1E
		protected PuertsRef_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155AD RID: 87469
		public new const string __ObjectPath = "/Game/Aki/Data/Common/Struct/PuertsRef.PuertsRef_C";

		// Token: 0x040155AE RID: 87470
		private static IntPtr _ClassPtr;

		// Token: 0x040155AF RID: 87471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155B0 RID: 87472
		internal static int __PropertyOffset_0;

		// Token: 0x040155B1 RID: 87473
		[Nullable(2)]
		private SCharacterLocationsAndRadius _NewVar_0;
	}
}
