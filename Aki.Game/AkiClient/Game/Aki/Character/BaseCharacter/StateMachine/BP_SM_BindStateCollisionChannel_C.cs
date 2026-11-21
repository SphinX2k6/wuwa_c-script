using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338C RID: 13196
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_BindStateCollisionChannel_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217D6 RID: 137174 RVA: 0x00961FB9 File Offset: 0x009601B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateCollisionChannel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C");
			}
			return BP_SM_BindStateCollisionChannel_C._ClassPtr;
		}

		// Token: 0x060217D7 RID: 137175 RVA: 0x00961FE0 File Offset: 0x009601E0
		public BP_SM_BindStateCollisionChannel_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCollisionChannel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217D8 RID: 137176 RVA: 0x00962008 File Offset: 0x00960208
		[NullableContext(1)]
		public BP_SM_BindStateCollisionChannel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateCollisionChannel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x060217D9 RID: 137177 RVA: 0x0096203C File Offset: 0x0096023C
		// (set) Token: 0x060217DA RID: 137178 RVA: 0x00962075 File Offset: 0x00960275
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
					result = (this._IgnoreChannels = new TArray<TEnumAsByte<ECollisionChannel>>(base.NativePtr + (IntPtr)BP_SM_BindStateCollisionChannel_C.__PropertyOffset_IgnoreChannels, this));
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

		// Token: 0x060217DB RID: 137179 RVA: 0x00962083 File Offset: 0x00960283
		protected BP_SM_BindStateCollisionChannel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124EE RID: 74990
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateCollisionChannel.BP_SM_BindStateCollisionChannel_C";

		// Token: 0x040124EF RID: 74991
		private static IntPtr _ClassPtr;

		// Token: 0x040124F0 RID: 74992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124F1 RID: 74993
		internal static int __PropertyOffset_IgnoreChannels;

		// Token: 0x040124F2 RID: 74994
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECollisionChannel>> _IgnoreChannels;
	}
}
