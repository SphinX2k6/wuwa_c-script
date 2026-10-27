using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DC RID: 14812
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbCardItem.BvbCardItem_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class BvbCardItem_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFC0 RID: 126912 RVA: 0x008A69A6 File Offset: 0x008A4BA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BvbCardItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/BvbCardItem.BvbCardItem_C");
			}
			return BvbCardItem_C._ClassPtr;
		}

		// Token: 0x0601EFC1 RID: 126913 RVA: 0x008A69CC File Offset: 0x008A4BCC
		public BvbCardItem_C() : this(BuiltinUtils.AllocNativeUObject(BvbCardItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFC2 RID: 126914 RVA: 0x008A69F4 File Offset: 0x008A4BF4
		[NullableContext(1)]
		public BvbCardItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BvbCardItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0601EFC3 RID: 126915 RVA: 0x008A6A27 File Offset: 0x008A4C27
		// (set) Token: 0x0601EFC4 RID: 126916 RVA: 0x008A6A3B File Offset: 0x008A4C3B
		public unsafe UButton BtnArrow_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0601EFC5 RID: 126917 RVA: 0x008A6A50 File Offset: 0x008A4C50
		// (set) Token: 0x0601EFC6 RID: 126918 RVA: 0x008A6A64 File Offset: 0x008A4C64
		public unsafe UBorder ContentBorder
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBorder>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0601EFC7 RID: 126919 RVA: 0x008A6A79 File Offset: 0x008A4C79
		// (set) Token: 0x0601EFC8 RID: 126920 RVA: 0x008A6A8D File Offset: 0x008A4C8D
		public unsafe UVerticalBox PnlLayout
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0601EFC9 RID: 126921 RVA: 0x008A6AA2 File Offset: 0x008A4CA2
		// (set) Token: 0x0601EFCA RID: 126922 RVA: 0x008A6AB6 File Offset: 0x008A4CB6
		public unsafe UImage TexTitleBg_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0601EFCB RID: 126923 RVA: 0x008A6ACB File Offset: 0x008A4CCB
		// (set) Token: 0x0601EFCC RID: 126924 RVA: 0x008A6ADF File Offset: 0x008A4CDF
		public unsafe UTextBlock TxtCostAll
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0601EFCD RID: 126925 RVA: 0x008A6AF4 File Offset: 0x008A4CF4
		// (set) Token: 0x0601EFCE RID: 126926 RVA: 0x008A6B08 File Offset: 0x008A4D08
		public unsafe UTextBlock TxtDesc
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0601EFCF RID: 126927 RVA: 0x008A6B1D File Offset: 0x008A4D1D
		// (set) Token: 0x0601EFD0 RID: 126928 RVA: 0x008A6B31 File Offset: 0x008A4D31
		public unsafe UTextBlock TxtElementAll
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0601EFD1 RID: 126929 RVA: 0x008A6B46 File Offset: 0x008A4D46
		// (set) Token: 0x0601EFD2 RID: 126930 RVA: 0x008A6B5A File Offset: 0x008A4D5A
		public unsafe UTextBlock TxtPowerAll
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0601EFD3 RID: 126931 RVA: 0x008A6B6F File Offset: 0x008A4D6F
		// (set) Token: 0x0601EFD4 RID: 126932 RVA: 0x008A6B83 File Offset: 0x008A4D83
		public unsafe UTextBlock TxtTitle_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0601EFD5 RID: 126933 RVA: 0x008A6B98 File Offset: 0x008A4D98
		// (set) Token: 0x0601EFD6 RID: 126934 RVA: 0x008A6BAC File Offset: 0x008A4DAC
		public unsafe UVerticalBox VerticalBox_434
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardItem_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0601EFD7 RID: 126935 RVA: 0x008A6BC4 File Offset: 0x008A4DC4
		// (set) Token: 0x0601EFD8 RID: 126936 RVA: 0x008A6BFD File Offset: 0x008A4DFD
		[Nullable(1)]
		public TArray<BvbEffectItem_C> EffectItemList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BvbEffectItem_C> result;
				if ((result = this._EffectItemList) == null)
				{
					result = (this._EffectItemList = new TArray<BvbEffectItem_C>(base.NativePtr + (IntPtr)BvbCardItem_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EffectItemList.CopyAssign(value);
			}
		}

		// Token: 0x0601EFD9 RID: 126937 RVA: 0x008A6C0B File Offset: 0x008A4E0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFlodBtnClick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardItem_C.__OnFlodBtnClick_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFDA RID: 126938 RVA: 0x008A6C20 File Offset: 0x008A4E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RefreshEffectItemList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BvbEffectItemData> EffectItemDataList)
		{
			BvbCardItem_C.__RefreshEffectItemList_FunctionParams* ptr = stackalloc BvbCardItem_C.__RefreshEffectItemList_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BvbCardItem_C.__RefreshEffectItemList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbCardItem_C.__RefreshEffectItemList_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BvbEffectItemData> tarray = EffectItemDataList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->EffectItemDataList);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardItem_C.__RefreshEffectItemList_NativeFunctionPtr, (void*)ptr);
			TArray<BvbEffectItemData> tarray2 = EffectItemDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->EffectItemDataList);
			}
			UnrealReflectionUtils.DestroyStruct(BvbCardItem_C.__RefreshEffectItemList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFDB RID: 126939 RVA: 0x008A6C98 File Offset: 0x008A4E98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateEffectItem()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardItem_C.__CreateEffectItem_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFDC RID: 126940 RVA: 0x008A6CAC File Offset: 0x008A4EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh(BvbCardItemData CardItemData)
		{
			BvbCardItem_C.__Refresh_FunctionParams* ptr = stackalloc BvbCardItem_C.__Refresh_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BvbCardItem_C.__Refresh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbCardItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
			if (CardItemData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(BvbCardItemData.StaticStruct(), &ptr->CardItemData, CardItemData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardItem_C.__Refresh_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbCardItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFDD RID: 126941 RVA: 0x008A6D21 File Offset: 0x008A4F21
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BvbCardItem_BtnArrow_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardItem_C.__BndEvt__BvbCardItem_BtnArrow_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFDE RID: 126942 RVA: 0x008A6D35 File Offset: 0x008A4F35
		protected BvbCardItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED44 RID: 60740
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbCardItem.BvbCardItem_C";

		// Token: 0x0400ED45 RID: 60741
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED46 RID: 60742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED47 RID: 60743
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED48 RID: 60744
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED49 RID: 60745
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED4A RID: 60746
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED4B RID: 60747
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED4C RID: 60748
		internal static int __PropertyOffset_6;

		// Token: 0x0400ED4D RID: 60749
		internal static int __PropertyOffset_7;

		// Token: 0x0400ED4E RID: 60750
		internal static int __PropertyOffset_8;

		// Token: 0x0400ED4F RID: 60751
		internal static int __PropertyOffset_9;

		// Token: 0x0400ED50 RID: 60752
		internal static int __PropertyOffset_10;

		// Token: 0x0400ED51 RID: 60753
		internal static int __PropertyOffset_11;

		// Token: 0x0400ED52 RID: 60754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbEffectItem_C> _EffectItemList;

		// Token: 0x0400ED53 RID: 60755
		private static IntPtr __OnFlodBtnClick_NativeFunctionPtr;

		// Token: 0x0400ED54 RID: 60756
		private static IntPtr __RefreshEffectItemList_NativeFunctionPtr;

		// Token: 0x0400ED55 RID: 60757
		private static IntPtr __CreateEffectItem_NativeFunctionPtr;

		// Token: 0x0400ED56 RID: 60758
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400ED57 RID: 60759
		private static IntPtr __BndEvt__BvbCardItem_BtnArrow_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x020099D1 RID: 39377
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __RefreshEffectItemList_FunctionParams
		{
			// Token: 0x04030E9E RID: 200350
			[FieldOffset(0)]
			public byte EffectItemDataList;
		}

		// Token: 0x020099D2 RID: 39378
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __Refresh_FunctionParams
		{
			// Token: 0x04030E9F RID: 200351
			[FieldOffset(0)]
			public byte CardItemData;
		}
	}
}
