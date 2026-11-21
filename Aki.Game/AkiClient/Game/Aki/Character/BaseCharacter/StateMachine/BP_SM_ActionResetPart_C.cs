using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003382 RID: 13186
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_ActionResetPart_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021788 RID: 137096 RVA: 0x009617C2 File Offset: 0x0095F9C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionResetPart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C");
			}
			return BP_SM_ActionResetPart_C._ClassPtr;
		}

		// Token: 0x06021789 RID: 137097 RVA: 0x009617E8 File Offset: 0x0095F9E8
		public BP_SM_ActionResetPart_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetPart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602178A RID: 137098 RVA: 0x00961810 File Offset: 0x0095FA10
		public BP_SM_ActionResetPart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetPart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x0602178B RID: 137099 RVA: 0x00961843 File Offset: 0x0095FA43
		// (set) Token: 0x0602178C RID: 137100 RVA: 0x00961857 File Offset: 0x0095FA57
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x0602178D RID: 137101 RVA: 0x0096186C File Offset: 0x0095FA6C
		// (set) Token: 0x0602178E RID: 137102 RVA: 0x0096187C File Offset: 0x0095FA7C
		public unsafe bool 重置激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_重置激活) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_重置激活) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x0602178F RID: 137103 RVA: 0x0096188D File Offset: 0x0095FA8D
		// (set) Token: 0x06021790 RID: 137104 RVA: 0x0096189D File Offset: 0x0095FA9D
		public unsafe bool 重置血量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_重置血量) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_重置血量) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021791 RID: 137105 RVA: 0x009618AE File Offset: 0x0095FAAE
		protected BP_SM_ActionResetPart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124BD RID: 74941
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C";

		// Token: 0x040124BE RID: 74942
		private static IntPtr _ClassPtr;

		// Token: 0x040124BF RID: 74943
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124C0 RID: 74944
		internal static int __PropertyOffset_部位名;

		// Token: 0x040124C1 RID: 74945
		internal static int __PropertyOffset_重置激活;

		// Token: 0x040124C2 RID: 74946
		internal static int __PropertyOffset_重置血量;
	}
}
