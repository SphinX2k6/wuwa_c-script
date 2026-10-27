using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004336 RID: 17206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SSkillTrigger : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C9F0 RID: 182768 RVA: 0x00A243E4 File Offset: 0x00A225E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillTrigger._ScriptStructPtr != 0) ? SSkillTrigger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger", ref SSkillTrigger._ScriptStructPtr);
		}

		// Token: 0x1700703D RID: 28733
		// (get) Token: 0x0602C9F1 RID: 182769 RVA: 0x00A24408 File Offset: 0x00A22608
		// (set) Token: 0x0602C9F2 RID: 182770 RVA: 0x00A2441C File Offset: 0x00A2261C
		public unsafe string TriggerType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700703E RID: 28734
		// (get) Token: 0x0602C9F3 RID: 182771 RVA: 0x00A24434 File Offset: 0x00A22634
		// (set) Token: 0x0602C9F4 RID: 182772 RVA: 0x00A24477 File Offset: 0x00A22677
		public TArray<string> TriggerPreset
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TriggerPreset) == null)
				{
					result = (this._TriggerPreset = new TArray<string>(base.NativePtr + (IntPtr)SSkillTrigger.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TriggerPreset.CopyAssign(value);
			}
		}

		// Token: 0x1700703F RID: 28735
		// (get) Token: 0x0602C9F5 RID: 182773 RVA: 0x00A24485 File Offset: 0x00A22685
		// (set) Token: 0x0602C9F6 RID: 182774 RVA: 0x00A24499 File Offset: 0x00A22699
		public unsafe string TriggerParams
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17007040 RID: 28736
		// (get) Token: 0x0602C9F7 RID: 182775 RVA: 0x00A244AE File Offset: 0x00A226AE
		// (set) Token: 0x0602C9F8 RID: 182776 RVA: 0x00A244C2 File Offset: 0x00A226C2
		public unsafe string TriggerFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17007041 RID: 28737
		// (get) Token: 0x0602C9F9 RID: 182777 RVA: 0x00A244D7 File Offset: 0x00A226D7
		// (set) Token: 0x0602C9FA RID: 182778 RVA: 0x00A244EB File Offset: 0x00A226EB
		public unsafe string TriggerTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17007042 RID: 28738
		// (get) Token: 0x0602C9FB RID: 182779 RVA: 0x00A24500 File Offset: 0x00A22700
		// (set) Token: 0x0602C9FC RID: 182780 RVA: 0x00A24514 File Offset: 0x00A22714
		public unsafe string TriggerTargetSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x0602C9FD RID: 182781 RVA: 0x00A24529 File Offset: 0x00A22729
		public SSkillTrigger()
		{
		}

		// Token: 0x0602C9FE RID: 182782 RVA: 0x00A24531 File Offset: 0x00A22731
		public SSkillTrigger(string TriggerType, TArray<string> TriggerPreset, string TriggerParams, string TriggerFormula, string TriggerTarget, string TriggerTargetSocket)
		{
			this.TriggerType = TriggerType;
			this.TriggerPreset = TriggerPreset;
			this.TriggerParams = TriggerParams;
			this.TriggerFormula = TriggerFormula;
			this.TriggerTarget = TriggerTarget;
			this.TriggerTargetSocket = TriggerTargetSocket;
		}

		// Token: 0x0602C9FF RID: 182783 RVA: 0x00A24566 File Offset: 0x00A22766
		protected override IntPtr GetUStructPtr()
		{
			return SSkillTrigger.StaticStruct();
		}

		// Token: 0x0602CA00 RID: 182784 RVA: 0x00A24572 File Offset: 0x00A22772
		[NullableContext(2)]
		public SSkillTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA01 RID: 182785 RVA: 0x00A2457C File Offset: 0x00A2277C
		public SSkillTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA02 RID: 182786 RVA: 0x00A24587 File Offset: 0x00A22787
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillTrigger(Pointer, false, true);
		}

		// Token: 0x0602CA03 RID: 182787 RVA: 0x00A24591 File Offset: 0x00A22791
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillTrigger(Pointer, MemoryOwner);
		}

		// Token: 0x0401785C RID: 96348
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger";

		// Token: 0x0401785D RID: 96349
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401785E RID: 96350
		internal static int __PropertyOffset_0;

		// Token: 0x0401785F RID: 96351
		internal static int __PropertyOffset_1;

		// Token: 0x04017860 RID: 96352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TriggerPreset;

		// Token: 0x04017861 RID: 96353
		internal static int __PropertyOffset_2;

		// Token: 0x04017862 RID: 96354
		internal static int __PropertyOffset_3;

		// Token: 0x04017863 RID: 96355
		internal static int __PropertyOffset_4;

		// Token: 0x04017864 RID: 96356
		internal static int __PropertyOffset_5;
	}
}
