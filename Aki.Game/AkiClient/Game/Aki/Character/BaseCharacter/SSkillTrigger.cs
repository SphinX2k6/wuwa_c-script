using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336D RID: 13165
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SSkillTrigger : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060216D7 RID: 136919 RVA: 0x009605FE File Offset: 0x0095E7FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillTrigger._ScriptStructPtr != 0) ? SSkillTrigger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger", ref SSkillTrigger._ScriptStructPtr);
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x060216D8 RID: 136920 RVA: 0x00960622 File Offset: 0x0095E822
		// (set) Token: 0x060216D9 RID: 136921 RVA: 0x00960636 File Offset: 0x0095E836
		public unsafe string TriggerType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerType)), value);
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x060216DA RID: 136922 RVA: 0x0096064C File Offset: 0x0095E84C
		// (set) Token: 0x060216DB RID: 136923 RVA: 0x0096068F File Offset: 0x0095E88F
		public TArray<string> TriggerPreset
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TriggerPreset) == null)
				{
					result = (this._TriggerPreset = new TArray<string>(base.NativePtr + (IntPtr)SSkillTrigger.__PropertyOffset_TriggerPreset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TriggerPreset.CopyAssign(value);
			}
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x060216DC RID: 136924 RVA: 0x0096069D File Offset: 0x0095E89D
		// (set) Token: 0x060216DD RID: 136925 RVA: 0x009606B1 File Offset: 0x0095E8B1
		public unsafe string TriggerParams
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerParams)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerParams)), value);
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x060216DE RID: 136926 RVA: 0x009606C6 File Offset: 0x0095E8C6
		// (set) Token: 0x060216DF RID: 136927 RVA: 0x009606DA File Offset: 0x0095E8DA
		public unsafe string TriggerFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerFormula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerFormula)), value);
			}
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x060216E0 RID: 136928 RVA: 0x009606EF File Offset: 0x0095E8EF
		// (set) Token: 0x060216E1 RID: 136929 RVA: 0x00960703 File Offset: 0x0095E903
		public unsafe string TriggerTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerTarget)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerTarget)), value);
			}
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x060216E2 RID: 136930 RVA: 0x00960718 File Offset: 0x0095E918
		// (set) Token: 0x060216E3 RID: 136931 RVA: 0x0096072C File Offset: 0x0095E92C
		public unsafe string TriggerTargetSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerTargetSocket)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTrigger.__PropertyOffset_TriggerTargetSocket)), value);
			}
		}

		// Token: 0x060216E4 RID: 136932 RVA: 0x00960741 File Offset: 0x0095E941
		public SSkillTrigger()
		{
		}

		// Token: 0x060216E5 RID: 136933 RVA: 0x00960749 File Offset: 0x0095E949
		protected override IntPtr GetUStructPtr()
		{
			return SSkillTrigger.StaticStruct();
		}

		// Token: 0x060216E6 RID: 136934 RVA: 0x00960755 File Offset: 0x0095E955
		[NullableContext(2)]
		public SSkillTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216E7 RID: 136935 RVA: 0x0096075F File Offset: 0x0095E95F
		public SSkillTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216E8 RID: 136936 RVA: 0x0096076A File Offset: 0x0095E96A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillTrigger(Pointer, false, true);
		}

		// Token: 0x060216E9 RID: 136937 RVA: 0x00960774 File Offset: 0x0095E974
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillTrigger(Pointer, MemoryOwner);
		}

		// Token: 0x04012453 RID: 74835
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillTrigger.SSkillTrigger";

		// Token: 0x04012454 RID: 74836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012455 RID: 74837
		internal static int __PropertyOffset_TriggerType;

		// Token: 0x04012456 RID: 74838
		internal static int __PropertyOffset_TriggerPreset;

		// Token: 0x04012457 RID: 74839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TriggerPreset;

		// Token: 0x04012458 RID: 74840
		internal static int __PropertyOffset_TriggerParams;

		// Token: 0x04012459 RID: 74841
		internal static int __PropertyOffset_TriggerFormula;

		// Token: 0x0401245A RID: 74842
		internal static int __PropertyOffset_TriggerTarget;

		// Token: 0x0401245B RID: 74843
		internal static int __PropertyOffset_TriggerTargetSocket;
	}
}
