using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436D RID: 17261
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_BindStateDeathMontageByTag_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBC8 RID: 183240 RVA: 0x00A27352 File Offset: 0x00A25552
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDeathMontageByTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C");
			}
			return BP_SM_BindStateDeathMontageByTag_C._ClassPtr;
		}

		// Token: 0x0602CBC9 RID: 183241 RVA: 0x00A27378 File Offset: 0x00A25578
		public BP_SM_BindStateDeathMontageByTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontageByTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBCA RID: 183242 RVA: 0x00A273A0 File Offset: 0x00A255A0
		public BP_SM_BindStateDeathMontageByTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontageByTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070A2 RID: 28834
		// (get) Token: 0x0602CBCB RID: 183243 RVA: 0x00A273D4 File Offset: 0x00A255D4
		// (set) Token: 0x0602CBCC RID: 183244 RVA: 0x00A2740D File Offset: 0x00A2560D
		public TArray<FGameplayTag> MontageTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._MontageTags) == null)
				{
					result = (this._MontageTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontageByTag_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MontageTags.CopyAssign(value);
			}
		}

		// Token: 0x170070A3 RID: 28835
		// (get) Token: 0x0602CBCD RID: 183245 RVA: 0x00A2741C File Offset: 0x00A2561C
		// (set) Token: 0x0602CBCE RID: 183246 RVA: 0x00A27455 File Offset: 0x00A25655
		public TArray<string> TagMontageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TagMontageNames) == null)
				{
					result = (this._TagMontageNames = new TArray<string>(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontageByTag_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.TagMontageNames.CopyAssign(value);
			}
		}

		// Token: 0x0602CBCF RID: 183247 RVA: 0x00A27463 File Offset: 0x00A25663
		protected BP_SM_BindStateDeathMontageByTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017979 RID: 96633
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontageByTag.BP_SM_BindStateDeathMontageByTag_C";

		// Token: 0x0401797A RID: 96634
		private static IntPtr _ClassPtr;

		// Token: 0x0401797B RID: 96635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401797C RID: 96636
		internal static int __PropertyOffset_0;

		// Token: 0x0401797D RID: 96637
		[Nullable(2)]
		private TArray<FGameplayTag> _MontageTags;

		// Token: 0x0401797E RID: 96638
		internal static int __PropertyOffset_1;

		// Token: 0x0401797F RID: 96639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TagMontageNames;
	}
}
