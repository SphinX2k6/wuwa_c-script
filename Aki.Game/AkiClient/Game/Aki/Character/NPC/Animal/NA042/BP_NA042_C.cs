using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA042
{
	// Token: 0x020041FD RID: 16893
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA042/BP_NA042.BP_NA042_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA042_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDBF RID: 179647 RVA: 0x00A0CBD0 File Offset: 0x00A0ADD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA042_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA042/BP_NA042.BP_NA042_C");
			}
			return BP_NA042_C._ClassPtr;
		}

		// Token: 0x0602BDC0 RID: 179648 RVA: 0x00A0CBF4 File Offset: 0x00A0ADF4
		public BP_NA042_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA042_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDC1 RID: 179649 RVA: 0x00A0CC1C File Offset: 0x00A0AE1C
		public BP_NA042_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA042_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CEF RID: 27887
		// (get) Token: 0x0602BDC2 RID: 179650 RVA: 0x00A0CC50 File Offset: 0x00A0AE50
		// (set) Token: 0x0602BDC3 RID: 179651 RVA: 0x00A0CC89 File Offset: 0x00A0AE89
		public TArray<string> SocketNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SocketNames) == null)
				{
					result = (this._SocketNames = new TArray<string>(base.NativePtr + (IntPtr)BP_NA042_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SocketNames.CopyAssign(value);
			}
		}

		// Token: 0x17006CF0 RID: 27888
		// (get) Token: 0x0602BDC4 RID: 179652 RVA: 0x00A0CC98 File Offset: 0x00A0AE98
		// (set) Token: 0x0602BDC5 RID: 179653 RVA: 0x00A0CCD1 File Offset: 0x00A0AED1
		public TArray<FVector> Size
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Size) == null)
				{
					result = (this._Size = new TArray<FVector>(base.NativePtr + (IntPtr)BP_NA042_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Size.CopyAssign(value);
			}
		}

		// Token: 0x0602BDC6 RID: 179654 RVA: 0x00A0CCDF File Offset: 0x00A0AEDF
		protected BP_NA042_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E1A RID: 93722
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA042/BP_NA042.BP_NA042_C";

		// Token: 0x04016E1B RID: 93723
		private static IntPtr _ClassPtr;

		// Token: 0x04016E1C RID: 93724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E1D RID: 93725
		internal new static int __PropertyOffset_0;

		// Token: 0x04016E1E RID: 93726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SocketNames;

		// Token: 0x04016E1F RID: 93727
		internal static int __PropertyOffset_1;

		// Token: 0x04016E20 RID: 93728
		[Nullable(2)]
		private TArray<FVector> _Size;
	}
}
