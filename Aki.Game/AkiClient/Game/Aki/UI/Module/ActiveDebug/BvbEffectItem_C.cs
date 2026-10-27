using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039E0 RID: 14816
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbEffectItem.BvbEffectItem_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class BvbEffectItem_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F015 RID: 126997 RVA: 0x008A735A File Offset: 0x008A555A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BvbEffectItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/BvbEffectItem.BvbEffectItem_C");
			}
			return BvbEffectItem_C._ClassPtr;
		}

		// Token: 0x0601F016 RID: 126998 RVA: 0x008A7380 File Offset: 0x008A5580
		public BvbEffectItem_C() : this(BuiltinUtils.AllocNativeUObject(BvbEffectItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F017 RID: 126999 RVA: 0x008A73A8 File Offset: 0x008A55A8
		[NullableContext(1)]
		public BvbEffectItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BvbEffectItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0601F018 RID: 127000 RVA: 0x008A73DB File Offset: 0x008A55DB
		// (set) Token: 0x0601F019 RID: 127001 RVA: 0x008A73EF File Offset: 0x008A55EF
		public unsafe UButton BtnArrow_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0601F01A RID: 127002 RVA: 0x008A7404 File Offset: 0x008A5604
		// (set) Token: 0x0601F01B RID: 127003 RVA: 0x008A7418 File Offset: 0x008A5618
		public unsafe UVerticalBox PnlHideInfo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0601F01C RID: 127004 RVA: 0x008A742D File Offset: 0x008A562D
		// (set) Token: 0x0601F01D RID: 127005 RVA: 0x008A7441 File Offset: 0x008A5641
		public unsafe UImage TexTitleBg_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0601F01E RID: 127006 RVA: 0x008A7456 File Offset: 0x008A5656
		// (set) Token: 0x0601F01F RID: 127007 RVA: 0x008A746A File Offset: 0x008A566A
		public unsafe UTextBlock TxtDesc
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0601F020 RID: 127008 RVA: 0x008A747F File Offset: 0x008A567F
		// (set) Token: 0x0601F021 RID: 127009 RVA: 0x008A7493 File Offset: 0x008A5693
		public unsafe UTextBlock TxtTitle_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbEffectItem_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0601F022 RID: 127010 RVA: 0x008A74A8 File Offset: 0x008A56A8
		// (set) Token: 0x0601F023 RID: 127011 RVA: 0x008A74E1 File Offset: 0x008A56E1
		[Nullable(1)]
		public TArray<BvbChildEffectItem_C> ChildEffectItemList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BvbChildEffectItem_C> result;
				if ((result = this._ChildEffectItemList) == null)
				{
					result = (this._ChildEffectItemList = new TArray<BvbChildEffectItem_C>(base.NativePtr + (IntPtr)BvbEffectItem_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ChildEffectItemList.CopyAssign(value);
			}
		}

		// Token: 0x0601F024 RID: 127012 RVA: 0x008A74EF File Offset: 0x008A56EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateChildEffectItem()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbEffectItem_C.__CreateChildEffectItem_NativeFunctionPtr, null);
		}

		// Token: 0x0601F025 RID: 127013 RVA: 0x008A7504 File Offset: 0x008A5704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RefreshChildEffectList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> TitleList, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> DescList)
		{
			BvbEffectItem_C.__RefreshChildEffectList_FunctionParams* ptr = stackalloc BvbEffectItem_C.__RefreshChildEffectList_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BvbEffectItem_C.__RefreshChildEffectList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbEffectItem_C.__RefreshChildEffectList_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = TitleList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TitleList);
			}
			TArray<string> tarray2 = DescList;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->DescList);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbEffectItem_C.__RefreshChildEffectList_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray3 = TitleList;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->TitleList);
			}
			TArray<string> tarray4 = DescList;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->DescList);
			}
			UnrealReflectionUtils.DestroyStruct(BvbEffectItem_C.__RefreshChildEffectList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F026 RID: 127014 RVA: 0x008A75A4 File Offset: 0x008A57A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh(BvbEffectItemData EffectItemData)
		{
			BvbEffectItem_C.__Refresh_FunctionParams* ptr = stackalloc BvbEffectItem_C.__Refresh_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BvbEffectItem_C.__Refresh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
			if (EffectItemData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(BvbEffectItemData.StaticStruct(), &ptr->EffectItemData, EffectItemData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbEffectItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F027 RID: 127015 RVA: 0x008A7619 File Offset: 0x008A5819
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFlodBtnClick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbEffectItem_C.__OnFlodBtnClick_NativeFunctionPtr, null);
		}

		// Token: 0x0601F028 RID: 127016 RVA: 0x008A762D File Offset: 0x008A582D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbEffectItem_C.__BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0601F029 RID: 127017 RVA: 0x008A7641 File Offset: 0x008A5841
		protected BvbEffectItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED7A RID: 60794
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbEffectItem.BvbEffectItem_C";

		// Token: 0x0400ED7B RID: 60795
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED7C RID: 60796
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED7D RID: 60797
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED7E RID: 60798
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED7F RID: 60799
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED80 RID: 60800
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED81 RID: 60801
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED82 RID: 60802
		internal static int __PropertyOffset_6;

		// Token: 0x0400ED83 RID: 60803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbChildEffectItem_C> _ChildEffectItemList;

		// Token: 0x0400ED84 RID: 60804
		private static IntPtr __CreateChildEffectItem_NativeFunctionPtr;

		// Token: 0x0400ED85 RID: 60805
		private static IntPtr __RefreshChildEffectList_NativeFunctionPtr;

		// Token: 0x0400ED86 RID: 60806
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400ED87 RID: 60807
		private static IntPtr __OnFlodBtnClick_NativeFunctionPtr;

		// Token: 0x0400ED88 RID: 60808
		private static IntPtr __BndEvt__BvbEffectItem_BtnArrow_2_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x020099D6 RID: 39382
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RefreshChildEffectList_FunctionParams
		{
			// Token: 0x04030EA4 RID: 200356
			[FieldOffset(0)]
			public byte TitleList;

			// Token: 0x04030EA5 RID: 200357
			[FieldOffset(16)]
			public byte DescList;
		}

		// Token: 0x020099D7 RID: 39383
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Refresh_FunctionParams
		{
			// Token: 0x04030EA6 RID: 200358
			[FieldOffset(0)]
			public byte EffectItemData;
		}
	}
}
