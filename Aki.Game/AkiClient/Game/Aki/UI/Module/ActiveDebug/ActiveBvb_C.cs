using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DA RID: 14810
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/ActiveBvb.ActiveBvb_C")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class ActiveBvb_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF9F RID: 126879 RVA: 0x008A6630 File Offset: 0x008A4830
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ActiveBvb_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/ActiveDebug/ActiveBvb.ActiveBvb_C");
			}
			return ActiveBvb_C._ClassPtr;
		}

		// Token: 0x0601EFA0 RID: 126880 RVA: 0x008A6654 File Offset: 0x008A4854
		public ActiveBvb_C() : this(BuiltinUtils.AllocNativeUObject(ActiveBvb_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFA1 RID: 126881 RVA: 0x008A667C File Offset: 0x008A487C
		[NullableContext(1)]
		public ActiveBvb_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ActiveBvb_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0601EFA2 RID: 126882 RVA: 0x008A66AF File Offset: 0x008A48AF
		// (set) Token: 0x0601EFA3 RID: 126883 RVA: 0x008A66C3 File Offset: 0x008A48C3
		public unsafe BvbPlayerItem_C BvbNpcItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BvbPlayerItem_C>(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0601EFA4 RID: 126884 RVA: 0x008A66D8 File Offset: 0x008A48D8
		// (set) Token: 0x0601EFA5 RID: 126885 RVA: 0x008A66EC File Offset: 0x008A48EC
		public unsafe BvbPlayerItem_C BvbPlayerItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BvbPlayerItem_C>(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0601EFA6 RID: 126886 RVA: 0x008A6701 File Offset: 0x008A4901
		// (set) Token: 0x0601EFA7 RID: 126887 RVA: 0x008A6715 File Offset: 0x008A4915
		public unsafe UImage TexMainBg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ActiveBvb_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0601EFA8 RID: 126888 RVA: 0x008A672C File Offset: 0x008A492C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh(BvbPlayerItemData PlayerItemData, BvbPlayerItemData NpcItemData)
		{
			ActiveBvb_C.__Refresh_FunctionParams* ptr = stackalloc ActiveBvb_C.__Refresh_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ActiveBvb_C.__Refresh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ActiveBvb_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
			if (PlayerItemData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(BvbPlayerItemData.StaticStruct(), &ptr->PlayerItemData, PlayerItemData.NativePtr, 1, false);
			}
			if (NpcItemData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(BvbPlayerItemData.StaticStruct(), &ptr->NpcItemData, NpcItemData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ActiveBvb_C.__Refresh_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ActiveBvb_C.__Refresh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFA9 RID: 126889 RVA: 0x008A67C0 File Offset: 0x008A49C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ActiveBvb_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x0601EFAA RID: 126890 RVA: 0x008A67D4 File Offset: 0x008A49D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ActiveBvb_C.__Construct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601EFAB RID: 126891 RVA: 0x008A67E9 File Offset: 0x008A49E9
		protected ActiveBvb_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED33 RID: 60723
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/ActiveBvb.ActiveBvb_C";

		// Token: 0x0400ED34 RID: 60724
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED35 RID: 60725
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED36 RID: 60726
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED37 RID: 60727
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED38 RID: 60728
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED39 RID: 60729
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400ED3A RID: 60730
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x020099D0 RID: 39376
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Refresh_FunctionParams
		{
			// Token: 0x04030E9C RID: 200348
			[FieldOffset(0)]
			public byte PlayerItemData;

			// Token: 0x04030E9D RID: 200349
			[FieldOffset(48)]
			public byte NpcItemData;
		}
	}
}
