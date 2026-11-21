using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338E RID: 13198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_BindStateDeathMontageByTag_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217E6 RID: 137190 RVA: 0x009621A6 File Offset: 0x009603A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDeathMontageByTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C");
			}
			return BP_SM_BindStateDeathMontageByTag_C._ClassPtr;
		}

		// Token: 0x060217E7 RID: 137191 RVA: 0x009621CC File Offset: 0x009603CC
		public BP_SM_BindStateDeathMontageByTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontageByTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217E8 RID: 137192 RVA: 0x009621F4 File Offset: 0x009603F4
		public BP_SM_BindStateDeathMontageByTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontageByTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x060217E9 RID: 137193 RVA: 0x00962228 File Offset: 0x00960428
		// (set) Token: 0x060217EA RID: 137194 RVA: 0x00962261 File Offset: 0x00960461
		public TArray<FGameplayTag> MontageTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._MontageTags) == null)
				{
					result = (this._MontageTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontageByTag_C.__PropertyOffset_MontageTags, this));
				}
				return result;
			}
			set
			{
				this.MontageTags.CopyAssign(value);
			}
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x060217EB RID: 137195 RVA: 0x00962270 File Offset: 0x00960470
		// (set) Token: 0x060217EC RID: 137196 RVA: 0x009622A9 File Offset: 0x009604A9
		public TArray<string> TagMontageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TagMontageNames) == null)
				{
					result = (this._TagMontageNames = new TArray<string>(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontageByTag_C.__PropertyOffset_TagMontageNames, this));
				}
				return result;
			}
			set
			{
				this.TagMontageNames.CopyAssign(value);
			}
		}

		// Token: 0x060217ED RID: 137197 RVA: 0x009622B7 File Offset: 0x009604B7
		protected BP_SM_BindStateDeathMontageByTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124FA RID: 75002
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C";

		// Token: 0x040124FB RID: 75003
		private static IntPtr _ClassPtr;

		// Token: 0x040124FC RID: 75004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124FD RID: 75005
		internal static int __PropertyOffset_MontageTags;

		// Token: 0x040124FE RID: 75006
		[Nullable(2)]
		private TArray<FGameplayTag> _MontageTags;

		// Token: 0x040124FF RID: 75007
		internal static int __PropertyOffset_TagMontageNames;

		// Token: 0x04012500 RID: 75008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TagMontageNames;
	}
}
