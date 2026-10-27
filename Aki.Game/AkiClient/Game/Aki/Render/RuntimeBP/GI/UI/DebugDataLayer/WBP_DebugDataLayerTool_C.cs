using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugDataLayer
{
	// Token: 0x02003D3F RID: 15679
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerTool.WBP_DebugDataLayerTool_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class WBP_DebugDataLayerTool_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026155 RID: 155989 RVA: 0x0096AF97 File Offset: 0x00969197
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugDataLayerTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerTool.WBP_DebugDataLayerTool_C");
			}
			return WBP_DebugDataLayerTool_C._ClassPtr;
		}

		// Token: 0x06026156 RID: 155990 RVA: 0x0096AFBC File Offset: 0x009691BC
		public WBP_DebugDataLayerTool_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugDataLayerTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026157 RID: 155991 RVA: 0x0096AFE4 File Offset: 0x009691E4
		[NullableContext(1)]
		public WBP_DebugDataLayerTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugDataLayerTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x06026158 RID: 155992 RVA: 0x0096B017 File Offset: 0x00969217
		// (set) Token: 0x06026159 RID: 155993 RVA: 0x0096B02B File Offset: 0x0096922B
		public unsafe UButton Button_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x0602615A RID: 155994 RVA: 0x0096B040 File Offset: 0x00969240
		// (set) Token: 0x0602615B RID: 155995 RVA: 0x0096B054 File Offset: 0x00969254
		public unsafe UImage Image_50
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x0602615C RID: 155996 RVA: 0x0096B069 File Offset: 0x00969269
		// (set) Token: 0x0602615D RID: 155997 RVA: 0x0096B07D File Offset: 0x0096927D
		public unsafe UListView VIew
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UListView>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerTool_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x0602615E RID: 155998 RVA: 0x0096B094 File Offset: 0x00969294
		// (set) Token: 0x0602615F RID: 155999 RVA: 0x0096B0CD File Offset: 0x009692CD
		[Nullable(1)]
		public TArray<string> AllDataLayers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AllDataLayers) == null)
				{
					result = (this._AllDataLayers = new TArray<string>(base.NativePtr + (IntPtr)WBP_DebugDataLayerTool_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x06026160 RID: 156000 RVA: 0x0096B0DB File Offset: 0x009692DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerTool_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06026161 RID: 156001 RVA: 0x0096B0EF File Offset: 0x009692EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerTool_C.__BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026162 RID: 156002 RVA: 0x0096B103 File Offset: 0x00969303
		protected WBP_DebugDataLayerTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013107 RID: 78087
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerTool.WBP_DebugDataLayerTool_C";

		// Token: 0x04013108 RID: 78088
		private static IntPtr _ClassPtr;

		// Token: 0x04013109 RID: 78089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401310A RID: 78090
		internal static int __PropertyOffset_1;

		// Token: 0x0401310B RID: 78091
		internal static int __PropertyOffset_2;

		// Token: 0x0401310C RID: 78092
		internal static int __PropertyOffset_3;

		// Token: 0x0401310D RID: 78093
		internal static int __PropertyOffset_4;

		// Token: 0x0401310E RID: 78094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AllDataLayers;

		// Token: 0x0401310F RID: 78095
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04013110 RID: 78096
		private static IntPtr __BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;
	}
}
