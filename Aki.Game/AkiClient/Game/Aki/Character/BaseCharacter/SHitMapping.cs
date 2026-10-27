using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431C RID: 17180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SHitMapping : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C77E RID: 182142 RVA: 0x00A20750 File Offset: 0x00A1E950
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitMapping._ScriptStructPtr != 0) ? SHitMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping", ref SHitMapping._ScriptStructPtr);
		}

		// Token: 0x17006F6A RID: 28522
		// (get) Token: 0x0602C77F RID: 182143 RVA: 0x00A20774 File Offset: 0x00A1E974
		// (set) Token: 0x0602C780 RID: 182144 RVA: 0x00A20784 File Offset: 0x00A1E984
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F6B RID: 28523
		// (get) Token: 0x0602C781 RID: 182145 RVA: 0x00A20798 File Offset: 0x00A1E998
		// (set) Token: 0x0602C782 RID: 182146 RVA: 0x00A207DB File Offset: 0x00A1E9DB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EHitAnim>> 映射表
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EHitAnim>> result;
				if ((result = this._映射表) == null)
				{
					result = (this._映射表 = new TArray<TEnumAsByte<EHitAnim>>(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.映射表.CopyAssign(value);
			}
		}

		// Token: 0x17006F6C RID: 28524
		// (get) Token: 0x0602C783 RID: 182147 RVA: 0x00A207E9 File Offset: 0x00A1E9E9
		// (set) Token: 0x0602C784 RID: 182148 RVA: 0x00A207FD File Offset: 0x00A1E9FD
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SHitMapping.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SHitMapping.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x0602C785 RID: 182149 RVA: 0x00A20812 File Offset: 0x00A1EA12
		public SHitMapping()
		{
		}

		// Token: 0x0602C786 RID: 182150 RVA: 0x00A2081A File Offset: 0x00A1EA1A
		public SHitMapping(int ID, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EHitAnim>> 映射表, string 备注)
		{
			this.ID = ID;
			this.映射表 = 映射表;
			this.备注 = 备注;
		}

		// Token: 0x0602C787 RID: 182151 RVA: 0x00A20837 File Offset: 0x00A1EA37
		protected override IntPtr GetUStructPtr()
		{
			return SHitMapping.StaticStruct();
		}

		// Token: 0x0602C788 RID: 182152 RVA: 0x00A20843 File Offset: 0x00A1EA43
		[NullableContext(2)]
		public SHitMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C789 RID: 182153 RVA: 0x00A2084D File Offset: 0x00A1EA4D
		public SHitMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C78A RID: 182154 RVA: 0x00A20858 File Offset: 0x00A1EA58
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitMapping(Pointer, false, true);
		}

		// Token: 0x0602C78B RID: 182155 RVA: 0x00A20862 File Offset: 0x00A1EA62
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04017714 RID: 96020
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping";

		// Token: 0x04017715 RID: 96021
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017716 RID: 96022
		internal static int __PropertyOffset_0;

		// Token: 0x04017717 RID: 96023
		internal static int __PropertyOffset_1;

		// Token: 0x04017718 RID: 96024
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EHitAnim>> _映射表;

		// Token: 0x04017719 RID: 96025
		internal static int __PropertyOffset_2;
	}
}
