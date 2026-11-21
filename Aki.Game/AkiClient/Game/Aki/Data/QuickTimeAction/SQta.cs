using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x0200317B RID: 12667
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQta.SQta")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 300)]
	public class SQta : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3B4 RID: 127924 RVA: 0x0092928C File Offset: 0x0092748C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQta._ScriptStructPtr != 0) ? SQta._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQta.SQta", ref SQta._ScriptStructPtr);
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0601F3B5 RID: 127925 RVA: 0x009292B0 File Offset: 0x009274B0
		// (set) Token: 0x0601F3B6 RID: 127926 RVA: 0x009292C4 File Offset: 0x009274C4
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQta.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQta.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0601F3B7 RID: 127927 RVA: 0x009292D9 File Offset: 0x009274D9
		// (set) Token: 0x0601F3B8 RID: 127928 RVA: 0x009292E9 File Offset: 0x009274E9
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0601F3B9 RID: 127929 RVA: 0x009292FA File Offset: 0x009274FA
		// (set) Token: 0x0601F3BA RID: 127930 RVA: 0x0092930A File Offset: 0x0092750A
		public unsafe bool AutonomousOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_AutonomousOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_AutonomousOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0601F3BB RID: 127931 RVA: 0x0092931C File Offset: 0x0092751C
		// (set) Token: 0x0601F3BC RID: 127932 RVA: 0x0092935F File Offset: 0x0092755F
		public SQtaCondition ActiveCondition
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCondition result;
				if ((result = this._ActiveCondition) == null)
				{
					result = (this._ActiveCondition = new SQtaCondition(base.NativePtr + (IntPtr)SQta.__PropertyOffset_ActiveCondition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCondition.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_ActiveCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0601F3BD RID: 127933 RVA: 0x00929380 File Offset: 0x00927580
		// (set) Token: 0x0601F3BE RID: 127934 RVA: 0x009293C3 File Offset: 0x009275C3
		public SQtaCondition DeactiveCondition
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCondition result;
				if ((result = this._DeactiveCondition) == null)
				{
					result = (this._DeactiveCondition = new SQtaCondition(base.NativePtr + (IntPtr)SQta.__PropertyOffset_DeactiveCondition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCondition.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_DeactiveCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0601F3BF RID: 127935 RVA: 0x009293E4 File Offset: 0x009275E4
		// (set) Token: 0x0601F3C0 RID: 127936 RVA: 0x00929427 File Offset: 0x00927627
		public SQtaBase BaseConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaBase result;
				if ((result = this._BaseConfig) == null)
				{
					result = (this._BaseConfig = new SQtaBase(base.NativePtr + (IntPtr)SQta.__PropertyOffset_BaseConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaBase.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_BaseConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0601F3C1 RID: 127937 RVA: 0x00929448 File Offset: 0x00927648
		// (set) Token: 0x0601F3C2 RID: 127938 RVA: 0x0092948B File Offset: 0x0092768B
		public TArray<SQtaPrompt> Prompt
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaPrompt> result;
				if ((result = this._Prompt) == null)
				{
					result = (this._Prompt = new TArray<SQtaPrompt>(base.NativePtr + (IntPtr)SQta.__PropertyOffset_Prompt, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Prompt.CopyAssign(value);
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0601F3C3 RID: 127939 RVA: 0x0092949C File Offset: 0x0092769C
		// (set) Token: 0x0601F3C4 RID: 127940 RVA: 0x009294DF File Offset: 0x009276DF
		public TArray<SQtaResultAction> ResultAction
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaResultAction> result;
				if ((result = this._ResultAction) == null)
				{
					result = (this._ResultAction = new TArray<SQtaResultAction>(base.NativePtr + (IntPtr)SQta.__PropertyOffset_ResultAction, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ResultAction.CopyAssign(value);
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0601F3C5 RID: 127941 RVA: 0x009294ED File Offset: 0x009276ED
		// (set) Token: 0x0601F3C6 RID: 127942 RVA: 0x009294FD File Offset: 0x009276FD
		public unsafe bool EndActiveSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_EndActiveSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_EndActiveSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0601F3C7 RID: 127943 RVA: 0x0092950E File Offset: 0x0092770E
		// (set) Token: 0x0601F3C8 RID: 127944 RVA: 0x0092951E File Offset: 0x0092771E
		public unsafe bool EndSkillWhenDeactive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_EndSkillWhenDeactive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_EndSkillWhenDeactive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0601F3C9 RID: 127945 RVA: 0x0092952F File Offset: 0x0092772F
		// (set) Token: 0x0601F3CA RID: 127946 RVA: 0x0092953F File Offset: 0x0092773F
		public unsafe bool HandleFailWhenInvalidStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_HandleFailWhenInvalidStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_HandleFailWhenInvalidStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0601F3CB RID: 127947 RVA: 0x00929550 File Offset: 0x00927750
		// (set) Token: 0x0601F3CC RID: 127948 RVA: 0x00929560 File Offset: 0x00927760
		public unsafe bool StopWhenFightInputBlocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_StopWhenFightInputBlocked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_StopWhenFightInputBlocked) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x00929571 File Offset: 0x00927771
		public SQta()
		{
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x00929579 File Offset: 0x00927779
		protected override IntPtr GetUStructPtr()
		{
			return SQta.StaticStruct();
		}

		// Token: 0x0601F3CF RID: 127951 RVA: 0x00929585 File Offset: 0x00927785
		[NullableContext(2)]
		public SQta(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3D0 RID: 127952 RVA: 0x0092958F File Offset: 0x0092778F
		public SQta(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3D1 RID: 127953 RVA: 0x0092959A File Offset: 0x0092779A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQta(Pointer, false, true);
		}

		// Token: 0x0601F3D2 RID: 127954 RVA: 0x009295A4 File Offset: 0x009277A4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQta(Pointer, MemoryOwner);
		}

		// Token: 0x04010B69 RID: 68457
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQta.SQta";

		// Token: 0x04010B6A RID: 68458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B6B RID: 68459
		internal static int __PropertyOffset_Desc;

		// Token: 0x04010B6C RID: 68460
		internal static int __PropertyOffset_Priority;

		// Token: 0x04010B6D RID: 68461
		internal static int __PropertyOffset_AutonomousOnly;

		// Token: 0x04010B6E RID: 68462
		internal static int __PropertyOffset_ActiveCondition;

		// Token: 0x04010B6F RID: 68463
		[Nullable(2)]
		private SQtaCondition _ActiveCondition;

		// Token: 0x04010B70 RID: 68464
		internal static int __PropertyOffset_DeactiveCondition;

		// Token: 0x04010B71 RID: 68465
		[Nullable(2)]
		private SQtaCondition _DeactiveCondition;

		// Token: 0x04010B72 RID: 68466
		internal static int __PropertyOffset_BaseConfig;

		// Token: 0x04010B73 RID: 68467
		[Nullable(2)]
		private SQtaBase _BaseConfig;

		// Token: 0x04010B74 RID: 68468
		internal static int __PropertyOffset_Prompt;

		// Token: 0x04010B75 RID: 68469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaPrompt> _Prompt;

		// Token: 0x04010B76 RID: 68470
		internal static int __PropertyOffset_ResultAction;

		// Token: 0x04010B77 RID: 68471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaResultAction> _ResultAction;

		// Token: 0x04010B78 RID: 68472
		internal static int __PropertyOffset_EndActiveSkill;

		// Token: 0x04010B79 RID: 68473
		internal static int __PropertyOffset_EndSkillWhenDeactive;

		// Token: 0x04010B7A RID: 68474
		internal static int __PropertyOffset_HandleFailWhenInvalidStop;

		// Token: 0x04010B7B RID: 68475
		internal static int __PropertyOffset_StopWhenFightInputBlocked;
	}
}
