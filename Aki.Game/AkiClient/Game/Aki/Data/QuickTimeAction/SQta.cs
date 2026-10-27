using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EAE RID: 16046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQta.SQta")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 300)]
	public class SQta : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602890E RID: 166158 RVA: 0x009AF558 File Offset: 0x009AD758
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQta._ScriptStructPtr != 0) ? SQta._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQta.SQta", ref SQta._ScriptStructPtr);
		}

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x0602890F RID: 166159 RVA: 0x009AF57C File Offset: 0x009AD77C
		// (set) Token: 0x06028910 RID: 166160 RVA: 0x009AF590 File Offset: 0x009AD790
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQta.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQta.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x06028911 RID: 166161 RVA: 0x009AF5A5 File Offset: 0x009AD7A5
		// (set) Token: 0x06028912 RID: 166162 RVA: 0x009AF5B5 File Offset: 0x009AD7B5
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x06028913 RID: 166163 RVA: 0x009AF5C6 File Offset: 0x009AD7C6
		// (set) Token: 0x06028914 RID: 166164 RVA: 0x009AF5D6 File Offset: 0x009AD7D6
		public unsafe bool AutonomousOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x06028915 RID: 166165 RVA: 0x009AF5E8 File Offset: 0x009AD7E8
		// (set) Token: 0x06028916 RID: 166166 RVA: 0x009AF62B File Offset: 0x009AD82B
		public SQtaCondition ActiveCondition
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCondition result;
				if ((result = this._ActiveCondition) == null)
				{
					result = (this._ActiveCondition = new SQtaCondition(base.NativePtr + (IntPtr)SQta.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCondition.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x06028917 RID: 166167 RVA: 0x009AF64C File Offset: 0x009AD84C
		// (set) Token: 0x06028918 RID: 166168 RVA: 0x009AF68F File Offset: 0x009AD88F
		public SQtaCondition DeactiveCondition
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCondition result;
				if ((result = this._DeactiveCondition) == null)
				{
					result = (this._DeactiveCondition = new SQtaCondition(base.NativePtr + (IntPtr)SQta.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCondition.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x06028919 RID: 166169 RVA: 0x009AF6B0 File Offset: 0x009AD8B0
		// (set) Token: 0x0602891A RID: 166170 RVA: 0x009AF6F3 File Offset: 0x009AD8F3
		public SQtaBase BaseConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaBase result;
				if ((result = this._BaseConfig) == null)
				{
					result = (this._BaseConfig = new SQtaBase(base.NativePtr + (IntPtr)SQta.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaBase.StaticStruct(), base.NativePtr + (IntPtr)SQta.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0602891B RID: 166171 RVA: 0x009AF714 File Offset: 0x009AD914
		// (set) Token: 0x0602891C RID: 166172 RVA: 0x009AF757 File Offset: 0x009AD957
		public TArray<SQtaPrompt> Prompt
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaPrompt> result;
				if ((result = this._Prompt) == null)
				{
					result = (this._Prompt = new TArray<SQtaPrompt>(base.NativePtr + (IntPtr)SQta.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Prompt.CopyAssign(value);
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0602891D RID: 166173 RVA: 0x009AF768 File Offset: 0x009AD968
		// (set) Token: 0x0602891E RID: 166174 RVA: 0x009AF7AB File Offset: 0x009AD9AB
		public TArray<SQtaResultAction> ResultAction
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SQtaResultAction> result;
				if ((result = this._ResultAction) == null)
				{
					result = (this._ResultAction = new TArray<SQtaResultAction>(base.NativePtr + (IntPtr)SQta.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ResultAction.CopyAssign(value);
			}
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0602891F RID: 166175 RVA: 0x009AF7B9 File Offset: 0x009AD9B9
		// (set) Token: 0x06028920 RID: 166176 RVA: 0x009AF7C9 File Offset: 0x009AD9C9
		public unsafe bool EndActiveSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x06028921 RID: 166177 RVA: 0x009AF7DA File Offset: 0x009AD9DA
		// (set) Token: 0x06028922 RID: 166178 RVA: 0x009AF7EA File Offset: 0x009AD9EA
		public unsafe bool EndSkillWhenDeactive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x06028923 RID: 166179 RVA: 0x009AF7FB File Offset: 0x009AD9FB
		// (set) Token: 0x06028924 RID: 166180 RVA: 0x009AF80B File Offset: 0x009ADA0B
		public unsafe bool HandleFailWhenInvalidStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x06028925 RID: 166181 RVA: 0x009AF81C File Offset: 0x009ADA1C
		// (set) Token: 0x06028926 RID: 166182 RVA: 0x009AF82C File Offset: 0x009ADA2C
		public unsafe bool StopWhenFightInputBlocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQta.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQta.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028927 RID: 166183 RVA: 0x009AF83D File Offset: 0x009ADA3D
		public SQta()
		{
		}

		// Token: 0x06028928 RID: 166184 RVA: 0x009AF848 File Offset: 0x009ADA48
		public SQta(string Desc, int Priority, bool AutonomousOnly, SQtaCondition ActiveCondition, SQtaCondition DeactiveCondition, SQtaBase BaseConfig, TArray<SQtaPrompt> Prompt, TArray<SQtaResultAction> ResultAction, bool EndActiveSkill, bool EndSkillWhenDeactive, bool HandleFailWhenInvalidStop, bool StopWhenFightInputBlocked)
		{
			this.Desc = Desc;
			this.Priority = Priority;
			this.AutonomousOnly = AutonomousOnly;
			this.ActiveCondition = ActiveCondition;
			this.DeactiveCondition = DeactiveCondition;
			this.BaseConfig = BaseConfig;
			this.Prompt = Prompt;
			this.ResultAction = ResultAction;
			this.EndActiveSkill = EndActiveSkill;
			this.EndSkillWhenDeactive = EndSkillWhenDeactive;
			this.HandleFailWhenInvalidStop = HandleFailWhenInvalidStop;
			this.StopWhenFightInputBlocked = StopWhenFightInputBlocked;
		}

		// Token: 0x06028929 RID: 166185 RVA: 0x009AF8B8 File Offset: 0x009ADAB8
		protected override IntPtr GetUStructPtr()
		{
			return SQta.StaticStruct();
		}

		// Token: 0x0602892A RID: 166186 RVA: 0x009AF8C4 File Offset: 0x009ADAC4
		[NullableContext(2)]
		public SQta(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602892B RID: 166187 RVA: 0x009AF8CE File Offset: 0x009ADACE
		public SQta(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602892C RID: 166188 RVA: 0x009AF8D9 File Offset: 0x009ADAD9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQta(Pointer, false, true);
		}

		// Token: 0x0602892D RID: 166189 RVA: 0x009AF8E3 File Offset: 0x009ADAE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQta(Pointer, MemoryOwner);
		}

		// Token: 0x04014B41 RID: 84801
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQta.SQta";

		// Token: 0x04014B42 RID: 84802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B43 RID: 84803
		internal static int __PropertyOffset_0;

		// Token: 0x04014B44 RID: 84804
		internal static int __PropertyOffset_1;

		// Token: 0x04014B45 RID: 84805
		internal static int __PropertyOffset_2;

		// Token: 0x04014B46 RID: 84806
		internal static int __PropertyOffset_3;

		// Token: 0x04014B47 RID: 84807
		[Nullable(2)]
		private SQtaCondition _ActiveCondition;

		// Token: 0x04014B48 RID: 84808
		internal static int __PropertyOffset_4;

		// Token: 0x04014B49 RID: 84809
		[Nullable(2)]
		private SQtaCondition _DeactiveCondition;

		// Token: 0x04014B4A RID: 84810
		internal static int __PropertyOffset_5;

		// Token: 0x04014B4B RID: 84811
		[Nullable(2)]
		private SQtaBase _BaseConfig;

		// Token: 0x04014B4C RID: 84812
		internal static int __PropertyOffset_6;

		// Token: 0x04014B4D RID: 84813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaPrompt> _Prompt;

		// Token: 0x04014B4E RID: 84814
		internal static int __PropertyOffset_7;

		// Token: 0x04014B4F RID: 84815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQtaResultAction> _ResultAction;

		// Token: 0x04014B50 RID: 84816
		internal static int __PropertyOffset_8;

		// Token: 0x04014B51 RID: 84817
		internal static int __PropertyOffset_9;

		// Token: 0x04014B52 RID: 84818
		internal static int __PropertyOffset_10;

		// Token: 0x04014B53 RID: 84819
		internal static int __PropertyOffset_11;
	}
}
