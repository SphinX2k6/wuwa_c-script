using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338D RID: 13197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_BindStateCue_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217DC RID: 137180 RVA: 0x0096208C File Offset: 0x0096028C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateCue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C");
			}
			return BP_SM_BindStateCue_C._ClassPtr;
		}

		// Token: 0x060217DD RID: 137181 RVA: 0x009620B0 File Offset: 0x009602B0
		public BP_SM_BindStateCue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217DE RID: 137182 RVA: 0x009620D8 File Offset: 0x009602D8
		public BP_SM_BindStateCue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x060217DF RID: 137183 RVA: 0x0096210C File Offset: 0x0096030C
		// (set) Token: 0x060217E0 RID: 137184 RVA: 0x00962145 File Offset: 0x00960345
		public TArray<long> CueIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._CueIds) == null)
				{
					result = (this._CueIds = new TArray<long>(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_CueIds, this));
				}
				return result;
			}
			set
			{
				this.CueIds.CopyAssign(value);
			}
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x060217E1 RID: 137185 RVA: 0x00962153 File Offset: 0x00960353
		// (set) Token: 0x060217E2 RID: 137186 RVA: 0x00962163 File Offset: 0x00960363
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_加载期间隐藏模型) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_加载期间隐藏模型) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x060217E3 RID: 137187 RVA: 0x00962174 File Offset: 0x00960374
		// (set) Token: 0x060217E4 RID: 137188 RVA: 0x00962188 File Offset: 0x00960388
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_ConfigReplaceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_ConfigReplaceTag) = value;
			}
		}

		// Token: 0x060217E5 RID: 137189 RVA: 0x0096219D File Offset: 0x0096039D
		protected BP_SM_BindStateCue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124F3 RID: 74995
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C";

		// Token: 0x040124F4 RID: 74996
		private static IntPtr _ClassPtr;

		// Token: 0x040124F5 RID: 74997
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124F6 RID: 74998
		internal static int __PropertyOffset_CueIds;

		// Token: 0x040124F7 RID: 74999
		[Nullable(2)]
		private TArray<long> _CueIds;

		// Token: 0x040124F8 RID: 75000
		internal static int __PropertyOffset_加载期间隐藏模型;

		// Token: 0x040124F9 RID: 75001
		internal static int __PropertyOffset_ConfigReplaceTag;
	}
}
