using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436B RID: 17259
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_BindStateCollisionChannel_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBB8 RID: 183224 RVA: 0x00A27165 File Offset: 0x00A25365
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateCollisionChannel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C");
			}
			return BP_SM_BindStateCollisionChannel_C._ClassPtr;
		}

		// Token: 0x0602CBB9 RID: 183225 RVA: 0x00A2718C File Offset: 0x00A2538C
		public BP_SM_BindStateCollisionChannel_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCollisionChannel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBBA RID: 183226 RVA: 0x00A271B4 File Offset: 0x00A253B4
		[NullableContext(1)]
		public BP_SM_BindStateCollisionChannel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCollisionChannel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700709E RID: 28830
		// (get) Token: 0x0602CBBB RID: 183227 RVA: 0x00A271E8 File Offset: 0x00A253E8
		// (set) Token: 0x0602CBBC RID: 183228 RVA: 0x00A27221 File Offset: 0x00A25421
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECollisionChannel>> IgnoreChannels
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECollisionChannel>> result;
				if ((result = this._IgnoreChannels) == null)
				{
					result = (this._IgnoreChannels = new TArray<TEnumAsByte<ECollisionChannel>>(base.NativePtr + (IntPtr)BP_SM_BindStateCollisionChannel_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.IgnoreChannels.CopyAssign(value);
			}
		}

		// Token: 0x0602CBBD RID: 183229 RVA: 0x00A2722F File Offset: 0x00A2542F
		protected BP_SM_BindStateCollisionChannel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401796D RID: 96621
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C";

		// Token: 0x0401796E RID: 96622
		private static IntPtr _ClassPtr;

		// Token: 0x0401796F RID: 96623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017970 RID: 96624
		internal static int __PropertyOffset_0;

		// Token: 0x04017971 RID: 96625
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECollisionChannel>> _IgnoreChannels;
	}
}
