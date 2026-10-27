using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugWuYinQu
{
	// Token: 0x02003D39 RID: 15673
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQu.WBP_DebugWuYinQu_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class WBP_DebugWuYinQu_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260CB RID: 155851 RVA: 0x00969E07 File Offset: 0x00968007
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugWuYinQu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQu.WBP_DebugWuYinQu_C");
			}
			return WBP_DebugWuYinQu_C._ClassPtr;
		}

		// Token: 0x060260CC RID: 155852 RVA: 0x00969E2C File Offset: 0x0096802C
		public WBP_DebugWuYinQu_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugWuYinQu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260CD RID: 155853 RVA: 0x00969E54 File Offset: 0x00968054
		[NullableContext(1)]
		public WBP_DebugWuYinQu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugWuYinQu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x060260CE RID: 155854 RVA: 0x00969E87 File Offset: 0x00968087
		// (set) Token: 0x060260CF RID: 155855 RVA: 0x00969E9B File Offset: 0x0096809B
		public unsafe UButton BtnClose
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x060260D0 RID: 155856 RVA: 0x00969EB0 File Offset: 0x009680B0
		// (set) Token: 0x060260D1 RID: 155857 RVA: 0x00969EC4 File Offset: 0x009680C4
		public unsafe KuroImage_C KuroImage_C_76
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x060260D2 RID: 155858 RVA: 0x00969ED9 File Offset: 0x009680D9
		// (set) Token: 0x060260D3 RID: 155859 RVA: 0x00969EED File Offset: 0x009680ED
		public unsafe UTextBlock TxtCurActiveActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x060260D4 RID: 155860 RVA: 0x00969F02 File Offset: 0x00968102
		// (set) Token: 0x060260D5 RID: 155861 RVA: 0x00969F16 File Offset: 0x00968116
		public unsafe UTextBlock TxtCurActiveState_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQu_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x060260D6 RID: 155862 RVA: 0x00969F2B File Offset: 0x0096812B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQu_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x060260D7 RID: 155863 RVA: 0x00969F3F File Offset: 0x0096813F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQu_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x060260D8 RID: 155864 RVA: 0x00969F54 File Offset: 0x00968154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugWuYinQu_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugWuYinQu_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugWuYinQu_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQu_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQu_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060260D9 RID: 155865 RVA: 0x00969FBC File Offset: 0x009681BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugWuYinQu_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugWuYinQu_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugWuYinQu_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQu_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugWuYinQu_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060260DA RID: 155866 RVA: 0x0096A025 File Offset: 0x00968225
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugWuYinQu_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQu_C.__BndEvt__BP_DebugWuYinQu_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260DB RID: 155867 RVA: 0x0096A039 File Offset: 0x00968239
		protected WBP_DebugWuYinQu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130B3 RID: 78003
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQu.WBP_DebugWuYinQu_C";

		// Token: 0x040130B4 RID: 78004
		private static IntPtr _ClassPtr;

		// Token: 0x040130B5 RID: 78005
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130B6 RID: 78006
		internal static int __PropertyOffset_1;

		// Token: 0x040130B7 RID: 78007
		internal static int __PropertyOffset_2;

		// Token: 0x040130B8 RID: 78008
		internal static int __PropertyOffset_3;

		// Token: 0x040130B9 RID: 78009
		internal static int __PropertyOffset_4;

		// Token: 0x040130BA RID: 78010
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x040130BB RID: 78011
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040130BC RID: 78012
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x040130BD RID: 78013
		private static IntPtr __BndEvt__BP_DebugWuYinQu_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A08C RID: 41100
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031B85 RID: 203653
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031B86 RID: 203654
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
