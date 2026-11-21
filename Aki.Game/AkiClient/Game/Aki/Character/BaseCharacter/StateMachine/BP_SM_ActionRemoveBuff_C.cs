using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003380 RID: 13184
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ActionRemoveBuff_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602177A RID: 137082 RVA: 0x00961644 File Offset: 0x0095F844
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionRemoveBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C");
			}
			return BP_SM_ActionRemoveBuff_C._ClassPtr;
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x00961668 File Offset: 0x0095F868
		public BP_SM_ActionRemoveBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602177C RID: 137084 RVA: 0x00961690 File Offset: 0x0095F890
		[NullableContext(1)]
		public BP_SM_ActionRemoveBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x0602177D RID: 137085 RVA: 0x009616C3 File Offset: 0x0095F8C3
		// (set) Token: 0x0602177E RID: 137086 RVA: 0x009616D3 File Offset: 0x0095F8D3
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveBuff_C.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveBuff_C.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x009616E4 File Offset: 0x0095F8E4
		protected BP_SM_ActionRemoveBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124B4 RID: 74932
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C";

		// Token: 0x040124B5 RID: 74933
		private static IntPtr _ClassPtr;

		// Token: 0x040124B6 RID: 74934
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124B7 RID: 74935
		internal static int __PropertyOffset_BuffId;
	}
}
