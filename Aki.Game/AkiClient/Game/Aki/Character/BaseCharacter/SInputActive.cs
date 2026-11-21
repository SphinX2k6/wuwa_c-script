using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003356 RID: 13142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SInputActive : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021474 RID: 136308 RVA: 0x0095D0F7 File Offset: 0x0095B2F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputActive._ScriptStructPtr != 0) ? SInputActive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive", ref SInputActive._ScriptStructPtr);
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x06021475 RID: 136309 RVA: 0x0095D11C File Offset: 0x0095B31C
		// (set) Token: 0x06021476 RID: 136310 RVA: 0x0095D15F File Offset: 0x0095B35F
		public TArray<SInputActiveCondition> InputActiveConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputActiveCondition> result;
				if ((result = this._InputActiveConditionGroup) == null)
				{
					result = (this._InputActiveConditionGroup = new TArray<SInputActiveCondition>(base.NativePtr + (IntPtr)SInputActive.__PropertyOffset_InputActiveConditionGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputActiveConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x06021477 RID: 136311 RVA: 0x0095D16D File Offset: 0x0095B36D
		// (set) Token: 0x06021478 RID: 136312 RVA: 0x0095D181 File Offset: 0x0095B381
		public unsafe string InputActiveConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputActive.__PropertyOffset_InputActiveConditionFormula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputActive.__PropertyOffset_InputActiveConditionFormula)), value);
			}
		}

		// Token: 0x06021479 RID: 136313 RVA: 0x0095D196 File Offset: 0x0095B396
		public SInputActive()
		{
		}

		// Token: 0x0602147A RID: 136314 RVA: 0x0095D19E File Offset: 0x0095B39E
		protected override IntPtr GetUStructPtr()
		{
			return SInputActive.StaticStruct();
		}

		// Token: 0x0602147B RID: 136315 RVA: 0x0095D1AA File Offset: 0x0095B3AA
		[NullableContext(2)]
		public SInputActive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x0095D1B4 File Offset: 0x0095B3B4
		public SInputActive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602147D RID: 136317 RVA: 0x0095D1BF File Offset: 0x0095B3BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputActive(Pointer, false, true);
		}

		// Token: 0x0602147E RID: 136318 RVA: 0x0095D1C9 File Offset: 0x0095B3C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputActive(Pointer, MemoryOwner);
		}

		// Token: 0x0401230B RID: 74507
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive";

		// Token: 0x0401230C RID: 74508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401230D RID: 74509
		internal static int __PropertyOffset_InputActiveConditionGroup;

		// Token: 0x0401230E RID: 74510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInputActiveCondition> _InputActiveConditionGroup;

		// Token: 0x0401230F RID: 74511
		internal static int __PropertyOffset_InputActiveConditionFormula;
	}
}
