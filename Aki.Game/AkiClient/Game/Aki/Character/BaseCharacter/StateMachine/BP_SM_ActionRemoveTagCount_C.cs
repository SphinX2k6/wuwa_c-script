using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003381 RID: 13185
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionRemoveTagCount_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021780 RID: 137088 RVA: 0x009616ED File Offset: 0x0095F8ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionRemoveTagCount_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C");
			}
			return BP_SM_ActionRemoveTagCount_C._ClassPtr;
		}

		// Token: 0x06021781 RID: 137089 RVA: 0x00961714 File Offset: 0x0095F914
		public BP_SM_ActionRemoveTagCount_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveTagCount_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021782 RID: 137090 RVA: 0x0096173C File Offset: 0x0095F93C
		[NullableContext(1)]
		public BP_SM_ActionRemoveTagCount_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveTagCount_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x06021783 RID: 137091 RVA: 0x0096176F File Offset: 0x0095F96F
		// (set) Token: 0x06021784 RID: 137092 RVA: 0x00961783 File Offset: 0x0095F983
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x06021785 RID: 137093 RVA: 0x00961798 File Offset: 0x0095F998
		// (set) Token: 0x06021786 RID: 137094 RVA: 0x009617A8 File Offset: 0x0095F9A8
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x009617B9 File Offset: 0x0095F9B9
		protected BP_SM_ActionRemoveTagCount_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124B8 RID: 74936
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C";

		// Token: 0x040124B9 RID: 74937
		private static IntPtr _ClassPtr;

		// Token: 0x040124BA RID: 74938
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124BB RID: 74939
		internal static int __PropertyOffset_Tag;

		// Token: 0x040124BC RID: 74940
		internal static int __PropertyOffset_Count;
	}
}
