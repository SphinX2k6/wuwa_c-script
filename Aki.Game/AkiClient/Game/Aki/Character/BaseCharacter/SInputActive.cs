using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431E RID: 17182
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SInputActive : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C79E RID: 182174 RVA: 0x00A209AD File Offset: 0x00A1EBAD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputActive._ScriptStructPtr != 0) ? SInputActive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive", ref SInputActive._ScriptStructPtr);
		}

		// Token: 0x17006F72 RID: 28530
		// (get) Token: 0x0602C79F RID: 182175 RVA: 0x00A209D4 File Offset: 0x00A1EBD4
		// (set) Token: 0x0602C7A0 RID: 182176 RVA: 0x00A20A17 File Offset: 0x00A1EC17
		public TArray<SInputActiveCondition> InputActiveConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputActiveCondition> result;
				if ((result = this._InputActiveConditionGroup) == null)
				{
					result = (this._InputActiveConditionGroup = new TArray<SInputActiveCondition>(base.NativePtr + (IntPtr)SInputActive.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputActiveConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x17006F73 RID: 28531
		// (get) Token: 0x0602C7A1 RID: 182177 RVA: 0x00A20A25 File Offset: 0x00A1EC25
		// (set) Token: 0x0602C7A2 RID: 182178 RVA: 0x00A20A39 File Offset: 0x00A1EC39
		public unsafe string InputActiveConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputActive.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputActive.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x0602C7A3 RID: 182179 RVA: 0x00A20A4E File Offset: 0x00A1EC4E
		public SInputActive()
		{
		}

		// Token: 0x0602C7A4 RID: 182180 RVA: 0x00A20A56 File Offset: 0x00A1EC56
		public SInputActive(TArray<SInputActiveCondition> InputActiveConditionGroup, string InputActiveConditionFormula)
		{
			this.InputActiveConditionGroup = InputActiveConditionGroup;
			this.InputActiveConditionFormula = InputActiveConditionFormula;
		}

		// Token: 0x0602C7A5 RID: 182181 RVA: 0x00A20A6C File Offset: 0x00A1EC6C
		protected override IntPtr GetUStructPtr()
		{
			return SInputActive.StaticStruct();
		}

		// Token: 0x0602C7A6 RID: 182182 RVA: 0x00A20A78 File Offset: 0x00A1EC78
		[NullableContext(2)]
		public SInputActive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C7A7 RID: 182183 RVA: 0x00A20A82 File Offset: 0x00A1EC82
		public SInputActive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C7A8 RID: 182184 RVA: 0x00A20A8D File Offset: 0x00A1EC8D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputActive(Pointer, false, true);
		}

		// Token: 0x0602C7A9 RID: 182185 RVA: 0x00A20A97 File Offset: 0x00A1EC97
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputActive(Pointer, MemoryOwner);
		}

		// Token: 0x04017721 RID: 96033
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SInputActive.SInputActive";

		// Token: 0x04017722 RID: 96034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017723 RID: 96035
		internal static int __PropertyOffset_0;

		// Token: 0x04017724 RID: 96036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInputActiveCondition> _InputActiveConditionGroup;

		// Token: 0x04017725 RID: 96037
		internal static int __PropertyOffset_1;
	}
}
