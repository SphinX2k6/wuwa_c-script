using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039E2 RID: 14818
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItem.BvbPlayerItem_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class BvbPlayerItem_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F038 RID: 127032 RVA: 0x008A77C2 File Offset: 0x008A59C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BvbPlayerItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItem.BvbPlayerItem_C");
			}
			return BvbPlayerItem_C._ClassPtr;
		}

		// Token: 0x0601F039 RID: 127033 RVA: 0x008A77E8 File Offset: 0x008A59E8
		public BvbPlayerItem_C() : this(BuiltinUtils.AllocNativeUObject(BvbPlayerItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F03A RID: 127034 RVA: 0x008A7810 File Offset: 0x008A5A10
		[NullableContext(1)]
		public BvbPlayerItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BvbPlayerItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0601F03B RID: 127035 RVA: 0x008A7843 File Offset: 0x008A5A43
		// (set) Token: 0x0601F03C RID: 127036 RVA: 0x008A7857 File Offset: 0x008A5A57
		public unsafe BvbCardListItem_C BvbCardListItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BvbCardListItem_C>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0601F03D RID: 127037 RVA: 0x008A786C File Offset: 0x008A5A6C
		// (set) Token: 0x0601F03E RID: 127038 RVA: 0x008A7880 File Offset: 0x008A5A80
		public unsafe BvbCardListItem_C BvbCardListItem_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BvbCardListItem_C>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0601F03F RID: 127039 RVA: 0x008A7895 File Offset: 0x008A5A95
		// (set) Token: 0x0601F040 RID: 127040 RVA: 0x008A78A9 File Offset: 0x008A5AA9
		public unsafe BvbCardListItem_C BvbCardListItem_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BvbCardListItem_C>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0601F041 RID: 127041 RVA: 0x008A78BE File Offset: 0x008A5ABE
		// (set) Token: 0x0601F042 RID: 127042 RVA: 0x008A78D2 File Offset: 0x008A5AD2
		public unsafe UScrollBox ScrollBox_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UScrollBox>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0601F043 RID: 127043 RVA: 0x008A78E7 File Offset: 0x008A5AE7
		// (set) Token: 0x0601F044 RID: 127044 RVA: 0x008A78FB File Offset: 0x008A5AFB
		public unsafe UImage TexBg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0601F045 RID: 127045 RVA: 0x008A7910 File Offset: 0x008A5B10
		// (set) Token: 0x0601F046 RID: 127046 RVA: 0x008A7924 File Offset: 0x008A5B24
		public unsafe UImage TexTitleBg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0601F047 RID: 127047 RVA: 0x008A7939 File Offset: 0x008A5B39
		// (set) Token: 0x0601F048 RID: 127048 RVA: 0x008A794D File Offset: 0x008A5B4D
		public unsafe UTextBlock TxtTitle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BvbPlayerItem_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x0601F049 RID: 127049 RVA: 0x008A7964 File Offset: 0x008A5B64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetTiltle(string Title)
		{
			BvbPlayerItem_C.__SetTiltle_FunctionParams* ptr = stackalloc BvbPlayerItem_C.__SetTiltle_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BvbPlayerItem_C.__SetTiltle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbPlayerItem_C.__SetTiltle_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Title), Title);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbPlayerItem_C.__SetTiltle_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbPlayerItem_C.__SetTiltle_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F04A RID: 127050 RVA: 0x008A79C4 File Offset: 0x008A5BC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh(BvbPlayerItemData PlayerItemData)
		{
			BvbPlayerItem_C.__Refresh_FunctionParams* ptr = stackalloc BvbPlayerItem_C.__Refresh_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BvbPlayerItem_C.__Refresh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BvbPlayerItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
			if (PlayerItemData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(BvbPlayerItemData.StaticStruct(), &ptr->PlayerItemData, PlayerItemData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbPlayerItem_C.__Refresh_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BvbPlayerItem_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F04B RID: 127051 RVA: 0x008A7A36 File Offset: 0x008A5C36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BvbPlayerItem_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x0601F04C RID: 127052 RVA: 0x008A7A4A File Offset: 0x008A5C4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BvbPlayerItem_C.__Construct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F04D RID: 127053 RVA: 0x008A7A5F File Offset: 0x008A5C5F
		protected BvbPlayerItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED91 RID: 60817
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItem.BvbPlayerItem_C";

		// Token: 0x0400ED92 RID: 60818
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED93 RID: 60819
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED94 RID: 60820
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED95 RID: 60821
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED96 RID: 60822
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED97 RID: 60823
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED98 RID: 60824
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED99 RID: 60825
		internal static int __PropertyOffset_6;

		// Token: 0x0400ED9A RID: 60826
		internal static int __PropertyOffset_7;

		// Token: 0x0400ED9B RID: 60827
		private static IntPtr __SetTiltle_NativeFunctionPtr;

		// Token: 0x0400ED9C RID: 60828
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400ED9D RID: 60829
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x020099D8 RID: 39384
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetTiltle_FunctionParams
		{
			// Token: 0x04030EA7 RID: 200359
			[FieldOffset(0)]
			public FString Title;
		}

		// Token: 0x020099D9 RID: 39385
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __Refresh_FunctionParams
		{
			// Token: 0x04030EA8 RID: 200360
			[FieldOffset(0)]
			public byte PlayerItemData;
		}
	}
}
