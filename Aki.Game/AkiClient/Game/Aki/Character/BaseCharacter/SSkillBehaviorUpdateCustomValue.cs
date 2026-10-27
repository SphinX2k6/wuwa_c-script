using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004331 RID: 17201
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSkillBehaviorUpdateCustomValue : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C948 RID: 182600 RVA: 0x00A2327C File Offset: 0x00A2147C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorUpdateCustomValue._ScriptStructPtr != 0) ? SSkillBehaviorUpdateCustomValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue", ref SSkillBehaviorUpdateCustomValue._ScriptStructPtr);
		}

		// Token: 0x17006FFD RID: 28669
		// (get) Token: 0x0602C949 RID: 182601 RVA: 0x00A232A0 File Offset: 0x00A214A0
		// (set) Token: 0x0602C94A RID: 182602 RVA: 0x00A232E3 File Offset: 0x00A214E3
		public TArray<string> ValueName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ValueName) == null)
				{
					result = (this._ValueName = new TArray<string>(base.NativePtr + (IntPtr)SSkillBehaviorUpdateCustomValue.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ValueName.CopyAssign(value);
			}
		}

		// Token: 0x0602C94B RID: 182603 RVA: 0x00A232F1 File Offset: 0x00A214F1
		public SSkillBehaviorUpdateCustomValue()
		{
		}

		// Token: 0x0602C94C RID: 182604 RVA: 0x00A232F9 File Offset: 0x00A214F9
		public SSkillBehaviorUpdateCustomValue(TArray<string> ValueName)
		{
			this.ValueName = ValueName;
		}

		// Token: 0x0602C94D RID: 182605 RVA: 0x00A23308 File Offset: 0x00A21508
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorUpdateCustomValue.StaticStruct();
		}

		// Token: 0x0602C94E RID: 182606 RVA: 0x00A23314 File Offset: 0x00A21514
		[NullableContext(2)]
		public SSkillBehaviorUpdateCustomValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C94F RID: 182607 RVA: 0x00A2331E File Offset: 0x00A2151E
		public SSkillBehaviorUpdateCustomValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C950 RID: 182608 RVA: 0x00A23329 File Offset: 0x00A21529
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorUpdateCustomValue(Pointer, false, true);
		}

		// Token: 0x0602C951 RID: 182609 RVA: 0x00A23333 File Offset: 0x00A21533
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorUpdateCustomValue(Pointer, MemoryOwner);
		}

		// Token: 0x040177FB RID: 96251
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue";

		// Token: 0x040177FC RID: 96252
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040177FD RID: 96253
		internal static int __PropertyOffset_0;

		// Token: 0x040177FE RID: 96254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ValueName;
	}
}
