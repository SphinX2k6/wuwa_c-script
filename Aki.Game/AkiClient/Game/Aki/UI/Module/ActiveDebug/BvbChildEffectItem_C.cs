using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DE RID: 14814
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbChildEffectItem.BvbChildEffectItem_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BvbChildEffectItem_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFF4 RID: 126964 RVA: 0x008A6FF1 File Offset: 0x008A51F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BvbChildEffectItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/BvbChildEffectItem.BvbChildEffectItem_C");
			}
			return BvbChildEffectItem_C._ClassPtr;
		}

		// Token: 0x0601EFF5 RID: 126965 RVA: 0x008A7018 File Offset: 0x008A5218
		public BvbChildEffectItem_C() : this(BuiltinUtils.AllocNativeUObject(BvbChildEffectItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFF6 RID: 126966 RVA: 0x008A7040 File Offset: 0x008A5240
		[NullableContext(1)]
		public BvbChildEffectItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BvbChildEffectItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0601EFF7 RID: 126967 RVA: 0x008A7073 File Offset: 0x008A5273
		// (set) Token: 0x0601EFF8 RID: 126968 RVA: 0x008A7087 File Offset: 0x008A5287
		public unsafe UButton BtnArrow_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0601EFF9 RID: 126969 RVA: 0x008A709C File Offset: 0x008A529C
		// (set) Token: 0x0601EFFA RID: 126970 RVA: 0x008A70B0 File Offset: 0x008A52B0
		public unsafe UVerticalBox PnlHideInfo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0601EFFB RID: 126971 RVA: 0x008A70C5 File Offset: 0x008A52C5
		// (set) Token: 0x0601EFFC RID: 126972 RVA: 0x008A70D9 File Offset: 0x008A52D9
		public unsafe UImage TexTitleBg_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0601EFFD RID: 126973 RVA: 0x008A70EE File Offset: 0x008A52EE
		// (set) Token: 0x0601EFFE RID: 126974 RVA: 0x008A7102 File Offset: 0x008A5302
		public unsafe UTextBlock TxtDesc
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0601EFFF RID: 126975 RVA: 0x008A7117 File Offset: 0x008A5317
		// (set) Token: 0x0601F000 RID: 126976 RVA: 0x008A712B File Offset: 0x008A532B
		public unsafe UTextBlock TxtTitle_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbChildEffectItem_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x0601F001 RID: 126977 RVA: 0x008A7140 File Offset: 0x008A5340
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh(string Title, string Desc)
		{
			BvbChildEffectItem_C.__Refresh_FunctionParams* ptr = stackalloc BvbChildEffectItem_C.__Refresh_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BvbChildEffectItem_C.__Refresh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbChildEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Title), Title);
			FString.CopyFrom((void*)(&ptr->Desc), Desc);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbChildEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbChildEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F002 RID: 126978 RVA: 0x008A71AD File Offset: 0x008A53AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFlodBtnClick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbChildEffectItem_C.__OnFlodBtnClick_NativeFunctionPtr, null);
		}

		// Token: 0x0601F003 RID: 126979 RVA: 0x008A71C1 File Offset: 0x008A53C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbChildEffectItem_C.__BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0601F004 RID: 126980 RVA: 0x008A71D5 File Offset: 0x008A53D5
		protected BvbChildEffectItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED67 RID: 60775
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbChildEffectItem.BvbChildEffectItem_C";

		// Token: 0x0400ED68 RID: 60776
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED69 RID: 60777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED6A RID: 60778
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED6B RID: 60779
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED6C RID: 60780
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED6D RID: 60781
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED6E RID: 60782
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED6F RID: 60783
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400ED70 RID: 60784
		private static IntPtr __OnFlodBtnClick_NativeFunctionPtr;

		// Token: 0x0400ED71 RID: 60785
		private static IntPtr __BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x020099D5 RID: 39381
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Refresh_FunctionParams
		{
			// Token: 0x04030EA2 RID: 200354
			[FieldOffset(0)]
			public FString Title;

			// Token: 0x04030EA3 RID: 200355
			[FieldOffset(16)]
			public FString Desc;
		}
	}
}
