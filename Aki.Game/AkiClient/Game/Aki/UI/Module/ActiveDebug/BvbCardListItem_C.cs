using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DD RID: 14813
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbCardListItem.BvbCardListItem_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class BvbCardListItem_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFDF RID: 126943 RVA: 0x008A6D3E File Offset: 0x008A4F3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BvbCardListItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/BvbCardListItem.BvbCardListItem_C");
			}
			return BvbCardListItem_C._ClassPtr;
		}

		// Token: 0x0601EFE0 RID: 126944 RVA: 0x008A6D64 File Offset: 0x008A4F64
		public BvbCardListItem_C() : this(BuiltinUtils.AllocNativeUObject(BvbCardListItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFE1 RID: 126945 RVA: 0x008A6D8C File Offset: 0x008A4F8C
		[NullableContext(1)]
		public BvbCardListItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BvbCardListItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0601EFE2 RID: 126946 RVA: 0x008A6DBF File Offset: 0x008A4FBF
		// (set) Token: 0x0601EFE3 RID: 126947 RVA: 0x008A6DD3 File Offset: 0x008A4FD3
		public unsafe UButton BtnArrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0601EFE4 RID: 126948 RVA: 0x008A6DE8 File Offset: 0x008A4FE8
		// (set) Token: 0x0601EFE5 RID: 126949 RVA: 0x008A6DFC File Offset: 0x008A4FFC
		public unsafe UVerticalBox Content
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0601EFE6 RID: 126950 RVA: 0x008A6E11 File Offset: 0x008A5011
		// (set) Token: 0x0601EFE7 RID: 126951 RVA: 0x008A6E25 File Offset: 0x008A5025
		public unsafe UVerticalBox PnlLayout
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVerticalBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0601EFE8 RID: 126952 RVA: 0x008A6E3A File Offset: 0x008A503A
		// (set) Token: 0x0601EFE9 RID: 126953 RVA: 0x008A6E4E File Offset: 0x008A504E
		public unsafe UImage TexTitleBg_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0601EFEA RID: 126954 RVA: 0x008A6E63 File Offset: 0x008A5063
		// (set) Token: 0x0601EFEB RID: 126955 RVA: 0x008A6E77 File Offset: 0x008A5077
		public unsafe UTextBlock TxtTitle_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbCardListItem_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0601EFEC RID: 126956 RVA: 0x008A6E8C File Offset: 0x008A508C
		// (set) Token: 0x0601EFED RID: 126957 RVA: 0x008A6EC5 File Offset: 0x008A50C5
		[Nullable(1)]
		public TArray<BvbCardItem_C> CardItemList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItem_C> result;
				if ((result = this._CardItemList) == null)
				{
					result = (this._CardItemList = new TArray<BvbCardItem_C>(base.NativePtr + (IntPtr)BvbCardListItem_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CardItemList.CopyAssign(value);
			}
		}

		// Token: 0x0601EFEE RID: 126958 RVA: 0x008A6ED4 File Offset: 0x008A50D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetTitle(string Title)
		{
			BvbCardListItem_C.__SetTitle_FunctionParams* ptr = stackalloc BvbCardListItem_C.__SetTitle_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BvbCardListItem_C.__SetTitle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbCardListItem_C.__SetTitle_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Title), Title);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardListItem_C.__SetTitle_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbCardListItem_C.__SetTitle_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFEF RID: 126959 RVA: 0x008A6F31 File Offset: 0x008A5131
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFlodBtnClick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardListItem_C.__OnFlodBtnClick_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFF0 RID: 126960 RVA: 0x008A6F48 File Offset: 0x008A5148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RefreshCardItemList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BvbCardItemData> CardItemDataList)
		{
			BvbCardListItem_C.__RefreshCardItemList_FunctionParams* ptr = stackalloc BvbCardListItem_C.__RefreshCardItemList_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BvbCardListItem_C.__RefreshCardItemList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbCardListItem_C.__RefreshCardItemList_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BvbCardItemData> tarray = CardItemDataList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CardItemDataList);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardListItem_C.__RefreshCardItemList_NativeFunctionPtr, (void*)ptr);
			TArray<BvbCardItemData> tarray2 = CardItemDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CardItemDataList);
			}
			UnrealReflectionUtils.DestroyStruct(BvbCardListItem_C.__RefreshCardItemList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFF1 RID: 126961 RVA: 0x008A6FC0 File Offset: 0x008A51C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateCardItem()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardListItem_C.__CreateCardItem_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFF2 RID: 126962 RVA: 0x008A6FD4 File Offset: 0x008A51D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BvbCardListItem_BtnArrow_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbCardListItem_C.__BndEvt__BvbCardListItem_BtnArrow_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFF3 RID: 126963 RVA: 0x008A6FE8 File Offset: 0x008A51E8
		protected BvbCardListItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED58 RID: 60760
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbCardListItem.BvbCardListItem_C";

		// Token: 0x0400ED59 RID: 60761
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED5A RID: 60762
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED5B RID: 60763
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED5C RID: 60764
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED5D RID: 60765
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED5E RID: 60766
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED5F RID: 60767
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED60 RID: 60768
		internal static int __PropertyOffset_6;

		// Token: 0x0400ED61 RID: 60769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItem_C> _CardItemList;

		// Token: 0x0400ED62 RID: 60770
		private static IntPtr __SetTitle_NativeFunctionPtr;

		// Token: 0x0400ED63 RID: 60771
		private static IntPtr __OnFlodBtnClick_NativeFunctionPtr;

		// Token: 0x0400ED64 RID: 60772
		private static IntPtr __RefreshCardItemList_NativeFunctionPtr;

		// Token: 0x0400ED65 RID: 60773
		private static IntPtr __CreateCardItem_NativeFunctionPtr;

		// Token: 0x0400ED66 RID: 60774
		private static IntPtr __BndEvt__BvbCardListItem_BtnArrow_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x020099D3 RID: 39379
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetTitle_FunctionParams
		{
			// Token: 0x04030EA0 RID: 200352
			[FieldOffset(0)]
			public FString Title;
		}

		// Token: 0x020099D4 RID: 39380
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __RefreshCardItemList_FunctionParams
		{
			// Token: 0x04030EA1 RID: 200353
			[FieldOffset(0)]
			public byte CardItemDataList;
		}
	}
}
