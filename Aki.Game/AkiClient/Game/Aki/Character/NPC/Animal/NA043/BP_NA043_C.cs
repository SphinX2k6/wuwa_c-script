using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA043
{
	// Token: 0x020041FA RID: 16890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA043/BP_NA043.BP_NA043_C")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2296)]
	public class BP_NA043_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDAB RID: 179627 RVA: 0x00A0C954 File Offset: 0x00A0AB54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA043_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA043/BP_NA043.BP_NA043_C");
			}
			return BP_NA043_C._ClassPtr;
		}

		// Token: 0x0602BDAC RID: 179628 RVA: 0x00A0C978 File Offset: 0x00A0AB78
		public BP_NA043_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA043_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDAD RID: 179629 RVA: 0x00A0C9A0 File Offset: 0x00A0ABA0
		public BP_NA043_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA043_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CEB RID: 27883
		// (get) Token: 0x0602BDAE RID: 179630 RVA: 0x00A0C9D3 File Offset: 0x00A0ABD3
		// (set) Token: 0x0602BDAF RID: 179631 RVA: 0x00A0C9E7 File Offset: 0x00A0ABE7
		[Nullable(2)]
		public unsafe UCapsuleComponent Bip001Spine1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA043_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA043_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006CEC RID: 27884
		// (get) Token: 0x0602BDB0 RID: 179632 RVA: 0x00A0C9FC File Offset: 0x00A0ABFC
		// (set) Token: 0x0602BDB1 RID: 179633 RVA: 0x00A0CA10 File Offset: 0x00A0AC10
		[Nullable(2)]
		public unsafe UCapsuleComponent Bip001Head
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA043_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA043_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CED RID: 27885
		// (get) Token: 0x0602BDB2 RID: 179634 RVA: 0x00A0CA28 File Offset: 0x00A0AC28
		// (set) Token: 0x0602BDB3 RID: 179635 RVA: 0x00A0CA61 File Offset: 0x00A0AC61
		public TArray<string> SocketNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SocketNames) == null)
				{
					result = (this._SocketNames = new TArray<string>(base.NativePtr + (IntPtr)BP_NA043_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.SocketNames.CopyAssign(value);
			}
		}

		// Token: 0x17006CEE RID: 27886
		// (get) Token: 0x0602BDB4 RID: 179636 RVA: 0x00A0CA70 File Offset: 0x00A0AC70
		// (set) Token: 0x0602BDB5 RID: 179637 RVA: 0x00A0CAA9 File Offset: 0x00A0ACA9
		public TArray<FVector> Size
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Size) == null)
				{
					result = (this._Size = new TArray<FVector>(base.NativePtr + (IntPtr)BP_NA043_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Size.CopyAssign(value);
			}
		}

		// Token: 0x0602BDB6 RID: 179638 RVA: 0x00A0CAB7 File Offset: 0x00A0ACB7
		protected BP_NA043_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E0B RID: 93707
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA043/BP_NA043.BP_NA043_C";

		// Token: 0x04016E0C RID: 93708
		private static IntPtr _ClassPtr;

		// Token: 0x04016E0D RID: 93709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E0E RID: 93710
		internal new static int __PropertyOffset_0;

		// Token: 0x04016E0F RID: 93711
		internal static int __PropertyOffset_1;

		// Token: 0x04016E10 RID: 93712
		internal static int __PropertyOffset_2;

		// Token: 0x04016E11 RID: 93713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SocketNames;

		// Token: 0x04016E12 RID: 93714
		internal static int __PropertyOffset_3;

		// Token: 0x04016E13 RID: 93715
		[Nullable(2)]
		private TArray<FVector> _Size;
	}
}
