using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004312 RID: 17170
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SEntityProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C69F RID: 181919 RVA: 0x00A1F3C4 File Offset: 0x00A1D5C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityProperty._ScriptStructPtr != 0) ? SEntityProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty", ref SEntityProperty._ScriptStructPtr);
		}

		// Token: 0x17006F22 RID: 28450
		// (get) Token: 0x0602C6A0 RID: 181920 RVA: 0x00A1F3E8 File Offset: 0x00A1D5E8
		// (set) Token: 0x0602C6A1 RID: 181921 RVA: 0x00A1F3FC File Offset: 0x00A1D5FC
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityProperty.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityProperty.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006F23 RID: 28451
		// (get) Token: 0x0602C6A2 RID: 181922 RVA: 0x00A1F411 File Offset: 0x00A1D611
		// (set) Token: 0x0602C6A3 RID: 181923 RVA: 0x00A1F421 File Offset: 0x00A1D621
		public unsafe int 碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F24 RID: 28452
		// (get) Token: 0x0602C6A4 RID: 181924 RVA: 0x00A1F432 File Offset: 0x00A1D632
		// (set) Token: 0x0602C6A5 RID: 181925 RVA: 0x00A1F442 File Offset: 0x00A1D642
		public unsafe int 穿透优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F25 RID: 28453
		// (get) Token: 0x0602C6A6 RID: 181926 RVA: 0x00A1F453 File Offset: 0x00A1D653
		// (set) Token: 0x0602C6A7 RID: 181927 RVA: 0x00A1F463 File Offset: 0x00A1D663
		public unsafe int 受击映射索引ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F26 RID: 28454
		// (get) Token: 0x0602C6A8 RID: 181928 RVA: 0x00A1F474 File Offset: 0x00A1D674
		// (set) Token: 0x0602C6A9 RID: 181929 RVA: 0x00A1F484 File Offset: 0x00A1D684
		public unsafe int 重量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F27 RID: 28455
		// (get) Token: 0x0602C6AA RID: 181930 RVA: 0x00A1F495 File Offset: 0x00A1D695
		// (set) Token: 0x0602C6AB RID: 181931 RVA: 0x00A1F4A5 File Offset: 0x00A1D6A5
		public unsafe int CaughtLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F28 RID: 28456
		// (get) Token: 0x0602C6AC RID: 181932 RVA: 0x00A1F4B6 File Offset: 0x00A1D6B6
		// (set) Token: 0x0602C6AD RID: 181933 RVA: 0x00A1F4C6 File Offset: 0x00A1D6C6
		public unsafe int 子弹受击顿帧时长比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602C6AE RID: 181934 RVA: 0x00A1F4D7 File Offset: 0x00A1D6D7
		public SEntityProperty()
		{
		}

		// Token: 0x0602C6AF RID: 181935 RVA: 0x00A1F4DF File Offset: 0x00A1D6DF
		public SEntityProperty(string 备注, int 碰撞优先级, int 穿透优先级, int 受击映射索引ID, int 重量, int CaughtLevel, int 子弹受击顿帧时长比例)
		{
			this.备注 = 备注;
			this.碰撞优先级 = 碰撞优先级;
			this.穿透优先级 = 穿透优先级;
			this.受击映射索引ID = 受击映射索引ID;
			this.重量 = 重量;
			this.CaughtLevel = CaughtLevel;
			this.子弹受击顿帧时长比例 = 子弹受击顿帧时长比例;
		}

		// Token: 0x0602C6B0 RID: 181936 RVA: 0x00A1F51C File Offset: 0x00A1D71C
		protected override IntPtr GetUStructPtr()
		{
			return SEntityProperty.StaticStruct();
		}

		// Token: 0x0602C6B1 RID: 181937 RVA: 0x00A1F528 File Offset: 0x00A1D728
		[NullableContext(2)]
		public SEntityProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C6B2 RID: 181938 RVA: 0x00A1F532 File Offset: 0x00A1D732
		public SEntityProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C6B3 RID: 181939 RVA: 0x00A1F53D File Offset: 0x00A1D73D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEntityProperty(Pointer, false, true);
		}

		// Token: 0x0602C6B4 RID: 181940 RVA: 0x00A1F547 File Offset: 0x00A1D747
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEntityProperty(Pointer, MemoryOwner);
		}

		// Token: 0x040176AA RID: 95914
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty";

		// Token: 0x040176AB RID: 95915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176AC RID: 95916
		internal static int __PropertyOffset_0;

		// Token: 0x040176AD RID: 95917
		internal static int __PropertyOffset_1;

		// Token: 0x040176AE RID: 95918
		internal static int __PropertyOffset_2;

		// Token: 0x040176AF RID: 95919
		internal static int __PropertyOffset_3;

		// Token: 0x040176B0 RID: 95920
		internal static int __PropertyOffset_4;

		// Token: 0x040176B1 RID: 95921
		internal static int __PropertyOffset_5;

		// Token: 0x040176B2 RID: 95922
		internal static int __PropertyOffset_6;
	}
}
