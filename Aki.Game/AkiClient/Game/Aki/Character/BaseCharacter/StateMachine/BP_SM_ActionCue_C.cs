using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337B RID: 13179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 76)]
	public class BP_SM_ActionCue_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021760 RID: 137056 RVA: 0x009612F9 File Offset: 0x0095F4F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionCue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C");
			}
			return BP_SM_ActionCue_C._ClassPtr;
		}

		// Token: 0x06021761 RID: 137057 RVA: 0x00961320 File Offset: 0x0095F520
		public BP_SM_ActionCue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021762 RID: 137058 RVA: 0x00961348 File Offset: 0x0095F548
		public BP_SM_ActionCue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionCue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x06021763 RID: 137059 RVA: 0x0096137C File Offset: 0x0095F57C
		// (set) Token: 0x06021764 RID: 137060 RVA: 0x009613B5 File Offset: 0x0095F5B5
		public TArray<long> CueIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._CueIds) == null)
				{
					result = (this._CueIds = new TArray<long>(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_CueIds, this));
				}
				return result;
			}
			set
			{
				this.CueIds.CopyAssign(value);
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x06021765 RID: 137061 RVA: 0x009613C3 File Offset: 0x0095F5C3
		// (set) Token: 0x06021766 RID: 137062 RVA: 0x009613D7 File Offset: 0x0095F5D7
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_ConfigReplaceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionCue_C.__PropertyOffset_ConfigReplaceTag) = value;
			}
		}

		// Token: 0x06021767 RID: 137063 RVA: 0x009613EC File Offset: 0x0095F5EC
		protected BP_SM_ActionCue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124A1 RID: 74913
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionCue.BP_SM_ActionCue_C";

		// Token: 0x040124A2 RID: 74914
		private static IntPtr _ClassPtr;

		// Token: 0x040124A3 RID: 74915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124A4 RID: 74916
		internal static int __PropertyOffset_CueIds;

		// Token: 0x040124A5 RID: 74917
		[Nullable(2)]
		private TArray<long> _CueIds;

		// Token: 0x040124A6 RID: 74918
		internal static int __PropertyOffset_ConfigReplaceTag;
	}
}
