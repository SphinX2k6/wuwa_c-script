using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004284 RID: 17028
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/CharacterData.CharacterData_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 116)]
	public class CharacterData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C372 RID: 181106 RVA: 0x00A1A3C0 File Offset: 0x00A185C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CharacterData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/CharacterData.CharacterData_C");
			}
			return CharacterData_C._ClassPtr;
		}

		// Token: 0x0602C373 RID: 181107 RVA: 0x00A1A3E4 File Offset: 0x00A185E4
		public CharacterData_C() : this(BuiltinUtils.AllocNativeUObject(CharacterData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C374 RID: 181108 RVA: 0x00A1A40C File Offset: 0x00A1860C
		public CharacterData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x0602C375 RID: 181109 RVA: 0x00A1A43F File Offset: 0x00A1863F
		// (set) Token: 0x0602C376 RID: 181110 RVA: 0x00A1A453 File Offset: 0x00A18653
		public unsafe string 名字
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)CharacterData_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)CharacterData_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x0602C377 RID: 181111 RVA: 0x00A1A468 File Offset: 0x00A18668
		// (set) Token: 0x0602C378 RID: 181112 RVA: 0x00A1A478 File Offset: 0x00A18678
		public unsafe int 生命
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x0602C379 RID: 181113 RVA: 0x00A1A489 File Offset: 0x00A18689
		// (set) Token: 0x0602C37A RID: 181114 RVA: 0x00A1A499 File Offset: 0x00A18699
		public unsafe float 攻击力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E38 RID: 28216
		// (get) Token: 0x0602C37B RID: 181115 RVA: 0x00A1A4AA File Offset: 0x00A186AA
		// (set) Token: 0x0602C37C RID: 181116 RVA: 0x00A1A4BA File Offset: 0x00A186BA
		public unsafe float 防御力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E39 RID: 28217
		// (get) Token: 0x0602C37D RID: 181117 RVA: 0x00A1A4CB File Offset: 0x00A186CB
		// (set) Token: 0x0602C37E RID: 181118 RVA: 0x00A1A4DB File Offset: 0x00A186DB
		public unsafe float 体力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006E3A RID: 28218
		// (get) Token: 0x0602C37F RID: 181119 RVA: 0x00A1A4EC File Offset: 0x00A186EC
		// (set) Token: 0x0602C380 RID: 181120 RVA: 0x00A1A4FC File Offset: 0x00A186FC
		public unsafe int npc类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CharacterData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602C381 RID: 181121 RVA: 0x00A1A50D File Offset: 0x00A1870D
		protected CharacterData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017252 RID: 94802
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/CharacterData.CharacterData_C";

		// Token: 0x04017253 RID: 94803
		private static IntPtr _ClassPtr;

		// Token: 0x04017254 RID: 94804
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017255 RID: 94805
		internal static int __PropertyOffset_0;

		// Token: 0x04017256 RID: 94806
		internal static int __PropertyOffset_1;

		// Token: 0x04017257 RID: 94807
		internal static int __PropertyOffset_2;

		// Token: 0x04017258 RID: 94808
		internal static int __PropertyOffset_3;

		// Token: 0x04017259 RID: 94809
		internal static int __PropertyOffset_4;

		// Token: 0x0401725A RID: 94810
		internal static int __PropertyOffset_5;
	}
}
