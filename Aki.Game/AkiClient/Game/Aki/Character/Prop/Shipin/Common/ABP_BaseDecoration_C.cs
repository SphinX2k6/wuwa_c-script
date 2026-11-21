using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Prop.Shipin.Common
{
	// Token: 0x020032AE RID: 12974
	[UnrealObjectPath("/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C")]
	[UnrealStructLayout(11264, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 11256)]
	public class ABP_BaseDecoration_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A3D RID: 133693 RVA: 0x0094BAE7 File Offset: 0x00949CE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseDecoration_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C");
			}
			return ABP_BaseDecoration_C._ClassPtr;
		}

		// Token: 0x06020A3E RID: 133694 RVA: 0x0094BB0C File Offset: 0x00949D0C
		public ABP_BaseDecoration_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseDecoration_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A3F RID: 133695 RVA: 0x0094BB34 File Offset: 0x00949D34
		[NullableContext(1)]
		public ABP_BaseDecoration_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseDecoration_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x06020A40 RID: 133696 RVA: 0x0094BB67 File Offset: 0x00949D67
		// (set) Token: 0x06020A41 RID: 133697 RVA: 0x0094BB77 File Offset: 0x00949D77
		public unsafe bool bFollowOwner
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_bFollowOwner) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_bFollowOwner) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x06020A42 RID: 133698 RVA: 0x0094BB88 File Offset: 0x00949D88
		// (set) Token: 0x06020A43 RID: 133699 RVA: 0x0094BB98 File Offset: 0x00949D98
		public unsafe bool bUseAllAnims
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_bUseAllAnims) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_bUseAllAnims) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x06020A44 RID: 133700 RVA: 0x0094BBA9 File Offset: 0x00949DA9
		// (set) Token: 0x06020A45 RID: 133701 RVA: 0x0094BBBD File Offset: 0x00949DBD
		[Nullable(2)]
		public unsafe TsBaseCharacter 当前角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseDecoration_C.__PropertyOffset_当前角色);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseDecoration_C.__PropertyOffset_当前角色, value);
			}
		}

		// Token: 0x06020A46 RID: 133702 RVA: 0x0094BBD4 File Offset: 0x00949DD4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void SetExtraFollowOwner(UAnimInstance Owner)
		{
			ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams* ptr = stackalloc ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseDecoration_C.__SetExtraFollowOwner_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseDecoration_C.__SetExtraFollowOwner_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A47 RID: 133703 RVA: 0x0094BC29 File Offset: 0x00949E29
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseDecoration_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020A48 RID: 133704 RVA: 0x0094BC3D File Offset: 0x00949E3D
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseDecoration_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020A49 RID: 133705 RVA: 0x0094BC51 File Offset: 0x00949E51
		protected ABP_BaseDecoration_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A71 RID: 72305
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C";

		// Token: 0x04011A72 RID: 72306
		private static IntPtr _ClassPtr;

		// Token: 0x04011A73 RID: 72307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A74 RID: 72308
		internal static int __PropertyOffset_bFollowOwner;

		// Token: 0x04011A75 RID: 72309
		internal static int __PropertyOffset_bUseAllAnims;

		// Token: 0x04011A76 RID: 72310
		internal static int __PropertyOffset_当前角色;

		// Token: 0x04011A77 RID: 72311
		private static IntPtr __SetExtraFollowOwner_NativeFunctionPtr;

		// Token: 0x04011A78 RID: 72312
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x02008FA0 RID: 36768
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetExtraFollowOwner_FunctionParams
		{
			// Token: 0x0402CD40 RID: 183616
			[FieldOffset(0)]
			public IntPtr Owner;
		}
	}
}
