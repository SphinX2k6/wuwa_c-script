using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435A RID: 17242
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 76)]
	public class BP_SM_ActionCue_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB42 RID: 183106 RVA: 0x00A264A5 File Offset: 0x00A246A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionCue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C");
			}
			return BP_SM_ActionCue_C._ClassPtr;
		}

		// Token: 0x0602CB43 RID: 183107 RVA: 0x00A264CC File Offset: 0x00A246CC
		public BP_SM_ActionCue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB44 RID: 183108 RVA: 0x00A264F4 File Offset: 0x00A246F4
		public BP_SM_ActionCue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007085 RID: 28805
		// (get) Token: 0x0602CB45 RID: 183109 RVA: 0x00A26528 File Offset: 0x00A24728
		// (set) Token: 0x0602CB46 RID: 183110 RVA: 0x00A26561 File Offset: 0x00A24761
		public TArray<long> CueIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._CueIds) == null)
				{
					result = (this._CueIds = new TArray<long>(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.CueIds.CopyAssign(value);
			}
		}

		// Token: 0x17007086 RID: 28806
		// (get) Token: 0x0602CB47 RID: 183111 RVA: 0x00A2656F File Offset: 0x00A2476F
		// (set) Token: 0x0602CB48 RID: 183112 RVA: 0x00A26583 File Offset: 0x00A24783
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602CB49 RID: 183113 RVA: 0x00A26598 File Offset: 0x00A24798
		protected BP_SM_ActionCue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017920 RID: 96544
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C";

		// Token: 0x04017921 RID: 96545
		private static IntPtr _ClassPtr;

		// Token: 0x04017922 RID: 96546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017923 RID: 96547
		internal static int __PropertyOffset_0;

		// Token: 0x04017924 RID: 96548
		[Nullable(2)]
		private TArray<long> _CueIds;

		// Token: 0x04017925 RID: 96549
		internal static int __PropertyOffset_1;
	}
}
