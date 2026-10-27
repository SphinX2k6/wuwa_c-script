using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x0200421F RID: 16927
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/BP_NA018.BP_NA018_C")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2296)]
	public class BP_NA018_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE62 RID: 179810 RVA: 0x00A0E208 File Offset: 0x00A0C408
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA018_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/BP_NA018.BP_NA018_C");
			}
			return BP_NA018_C._ClassPtr;
		}

		// Token: 0x0602BE63 RID: 179811 RVA: 0x00A0E22C File Offset: 0x00A0C42C
		public BP_NA018_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA018_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE64 RID: 179812 RVA: 0x00A0E254 File Offset: 0x00A0C454
		public BP_NA018_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA018_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF8 RID: 27896
		// (get) Token: 0x0602BE65 RID: 179813 RVA: 0x00A0E287 File Offset: 0x00A0C487
		// (set) Token: 0x0602BE66 RID: 179814 RVA: 0x00A0E29B File Offset: 0x00A0C49B
		[Nullable(2)]
		public unsafe UCapsuleComponent Bip001Spine1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA018_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA018_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006CF9 RID: 27897
		// (get) Token: 0x0602BE67 RID: 179815 RVA: 0x00A0E2B0 File Offset: 0x00A0C4B0
		// (set) Token: 0x0602BE68 RID: 179816 RVA: 0x00A0E2C4 File Offset: 0x00A0C4C4
		[Nullable(2)]
		public unsafe UCapsuleComponent Bip001Head
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA018_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA018_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CFA RID: 27898
		// (get) Token: 0x0602BE69 RID: 179817 RVA: 0x00A0E2DC File Offset: 0x00A0C4DC
		// (set) Token: 0x0602BE6A RID: 179818 RVA: 0x00A0E315 File Offset: 0x00A0C515
		public TArray<string> SocketNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SocketNames) == null)
				{
					result = (this._SocketNames = new TArray<string>(base.NativePtr + (IntPtr)BP_NA018_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.SocketNames.CopyAssign(value);
			}
		}

		// Token: 0x17006CFB RID: 27899
		// (get) Token: 0x0602BE6B RID: 179819 RVA: 0x00A0E324 File Offset: 0x00A0C524
		// (set) Token: 0x0602BE6C RID: 179820 RVA: 0x00A0E35D File Offset: 0x00A0C55D
		public TArray<FVector> Size
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Size) == null)
				{
					result = (this._Size = new TArray<FVector>(base.NativePtr + (IntPtr)BP_NA018_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Size.CopyAssign(value);
			}
		}

		// Token: 0x0602BE6D RID: 179821 RVA: 0x00A0E36B File Offset: 0x00A0C56B
		protected BP_NA018_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E93 RID: 93843
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/BP_NA018.BP_NA018_C";

		// Token: 0x04016E94 RID: 93844
		private static IntPtr _ClassPtr;

		// Token: 0x04016E95 RID: 93845
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E96 RID: 93846
		internal new static int __PropertyOffset_0;

		// Token: 0x04016E97 RID: 93847
		internal static int __PropertyOffset_1;

		// Token: 0x04016E98 RID: 93848
		internal static int __PropertyOffset_2;

		// Token: 0x04016E99 RID: 93849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SocketNames;

		// Token: 0x04016E9A RID: 93850
		internal static int __PropertyOffset_3;

		// Token: 0x04016E9B RID: 93851
		[Nullable(2)]
		private TArray<FVector> _Size;
	}
}
