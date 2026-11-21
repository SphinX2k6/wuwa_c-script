using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003397 RID: 13207
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_BindStateTag_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602182E RID: 137262 RVA: 0x00962998 File Offset: 0x00960B98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C");
			}
			return BP_SM_BindStateTag_C._ClassPtr;
		}

		// Token: 0x0602182F RID: 137263 RVA: 0x009629BC File Offset: 0x00960BBC
		public BP_SM_BindStateTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021830 RID: 137264 RVA: 0x009629E4 File Offset: 0x00960BE4
		[NullableContext(1)]
		public BP_SM_BindStateTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x06021831 RID: 137265 RVA: 0x00962A17 File Offset: 0x00960C17
		// (set) Token: 0x06021832 RID: 137266 RVA: 0x00962A2B File Offset: 0x00960C2B
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateTag_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateTag_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x06021833 RID: 137267 RVA: 0x00962A40 File Offset: 0x00960C40
		protected BP_SM_BindStateTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401252A RID: 75050
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateTag.BP_SM_BindStateTag_C";

		// Token: 0x0401252B RID: 75051
		private static IntPtr _ClassPtr;

		// Token: 0x0401252C RID: 75052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401252D RID: 75053
		internal static int __PropertyOffset_Tag;
	}
}
