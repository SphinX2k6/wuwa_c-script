using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436C RID: 17260
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_BindStateCue_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBBE RID: 183230 RVA: 0x00A27238 File Offset: 0x00A25438
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateCue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C");
			}
			return BP_SM_BindStateCue_C._ClassPtr;
		}

		// Token: 0x0602CBBF RID: 183231 RVA: 0x00A2725C File Offset: 0x00A2545C
		public BP_SM_BindStateCue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBC0 RID: 183232 RVA: 0x00A27284 File Offset: 0x00A25484
		public BP_SM_BindStateCue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700709F RID: 28831
		// (get) Token: 0x0602CBC1 RID: 183233 RVA: 0x00A272B8 File Offset: 0x00A254B8
		// (set) Token: 0x0602CBC2 RID: 183234 RVA: 0x00A272F1 File Offset: 0x00A254F1
		public TArray<long> CueIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._CueIds) == null)
				{
					result = (this._CueIds = new TArray<long>(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.CueIds.CopyAssign(value);
			}
		}

		// Token: 0x170070A0 RID: 28832
		// (get) Token: 0x0602CBC3 RID: 183235 RVA: 0x00A272FF File Offset: 0x00A254FF
		// (set) Token: 0x0602CBC4 RID: 183236 RVA: 0x00A2730F File Offset: 0x00A2550F
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070A1 RID: 28833
		// (get) Token: 0x0602CBC5 RID: 183237 RVA: 0x00A27320 File Offset: 0x00A25520
		// (set) Token: 0x0602CBC6 RID: 183238 RVA: 0x00A27334 File Offset: 0x00A25534
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateCue_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CBC7 RID: 183239 RVA: 0x00A27349 File Offset: 0x00A25549
		protected BP_SM_BindStateCue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017972 RID: 96626
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCue.BP_SM_BindStateCue_C";

		// Token: 0x04017973 RID: 96627
		private static IntPtr _ClassPtr;

		// Token: 0x04017974 RID: 96628
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017975 RID: 96629
		internal static int __PropertyOffset_0;

		// Token: 0x04017976 RID: 96630
		[Nullable(2)]
		private TArray<long> _CueIds;

		// Token: 0x04017977 RID: 96631
		internal static int __PropertyOffset_1;

		// Token: 0x04017978 RID: 96632
		internal static int __PropertyOffset_2;
	}
}
