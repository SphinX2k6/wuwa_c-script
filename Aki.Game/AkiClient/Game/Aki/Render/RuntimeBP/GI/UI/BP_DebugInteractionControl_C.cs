using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI
{
	// Token: 0x02003D36 RID: 15670
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugInteractionControl.BP_DebugInteractionControl_C")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class BP_DebugInteractionControl_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602608B RID: 155787 RVA: 0x00969718 File Offset: 0x00967918
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DebugInteractionControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugInteractionControl.BP_DebugInteractionControl_C");
			}
			return BP_DebugInteractionControl_C._ClassPtr;
		}

		// Token: 0x0602608C RID: 155788 RVA: 0x0096973C File Offset: 0x0096793C
		public BP_DebugInteractionControl_C() : this(BuiltinUtils.AllocNativeUObject(BP_DebugInteractionControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602608D RID: 155789 RVA: 0x00969764 File Offset: 0x00967964
		[NullableContext(1)]
		public BP_DebugInteractionControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DebugInteractionControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x0602608E RID: 155790 RVA: 0x00969797 File Offset: 0x00967997
		// (set) Token: 0x0602608F RID: 155791 RVA: 0x009697AB File Offset: 0x009679AB
		public unsafe UButton Btn_停止水模拟
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x06026090 RID: 155792 RVA: 0x009697C0 File Offset: 0x009679C0
		// (set) Token: 0x06026091 RID: 155793 RVA: 0x009697D4 File Offset: 0x009679D4
		public unsafe UButton Btn_停止草模拟
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x06026092 RID: 155794 RVA: 0x009697E9 File Offset: 0x009679E9
		// (set) Token: 0x06026093 RID: 155795 RVA: 0x009697FD File Offset: 0x009679FD
		public unsafe UButton Btn_允许水模拟
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x06026094 RID: 155796 RVA: 0x00969812 File Offset: 0x00967A12
		// (set) Token: 0x06026095 RID: 155797 RVA: 0x00969826 File Offset: 0x00967A26
		public unsafe UButton Btn_允许草模拟
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x06026096 RID: 155798 RVA: 0x0096983B File Offset: 0x00967A3B
		// (set) Token: 0x06026097 RID: 155799 RVA: 0x0096984F File Offset: 0x00967A4F
		public unsafe UButton Btn_启用水交互物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x06026098 RID: 155800 RVA: 0x00969864 File Offset: 0x00967A64
		// (set) Token: 0x06026099 RID: 155801 RVA: 0x00969878 File Offset: 0x00967A78
		public unsafe UButton Btn_启用草交互物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x0602609A RID: 155802 RVA: 0x0096988D File Offset: 0x00967A8D
		// (set) Token: 0x0602609B RID: 155803 RVA: 0x009698A1 File Offset: 0x00967AA1
		public unsafe UButton Btn_屏蔽水交互物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x0602609C RID: 155804 RVA: 0x009698B6 File Offset: 0x00967AB6
		// (set) Token: 0x0602609D RID: 155805 RVA: 0x009698CA File Offset: 0x00967ACA
		public unsafe UButton Btn_屏蔽草交互物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x0602609E RID: 155806 RVA: 0x009698DF File Offset: 0x00967ADF
		// (set) Token: 0x0602609F RID: 155807 RVA: 0x009698F3 File Offset: 0x00967AF3
		public unsafe UButton Button_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x060260A0 RID: 155808 RVA: 0x00969908 File Offset: 0x00967B08
		// (set) Token: 0x060260A1 RID: 155809 RVA: 0x0096991C File Offset: 0x00967B1C
		public unsafe KuroImage_C KuroImage_C_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x060260A2 RID: 155810 RVA: 0x00969931 File Offset: 0x00967B31
		// (set) Token: 0x060260A3 RID: 155811 RVA: 0x00969945 File Offset: 0x00967B45
		public unsafe PDA_InteractionGlobalConfig_C InteractionGlobalConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_InteractionGlobalConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugInteractionControl_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x060260A4 RID: 155812 RVA: 0x0096995A File Offset: 0x00967B5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Button_0_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Button_0_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260A5 RID: 155813 RVA: 0x0096996E File Offset: 0x00967B6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_开启场景水交互_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_开启场景水交互_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260A6 RID: 155814 RVA: 0x00969982 File Offset: 0x00967B82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_关闭场景水交互_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_关闭场景水交互_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260A7 RID: 155815 RVA: 0x00969996 File Offset: 0x00967B96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_屏蔽草交互物_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_屏蔽草交互物_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260A8 RID: 155816 RVA: 0x009699AA File Offset: 0x00967BAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_启用草交互物_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_启用草交互物_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260A9 RID: 155817 RVA: 0x009699BE File Offset: 0x00967BBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_停止水模拟_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_停止水模拟_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260AA RID: 155818 RVA: 0x009699D2 File Offset: 0x00967BD2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_停止草模拟_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_停止草模拟_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260AB RID: 155819 RVA: 0x009699E6 File Offset: 0x00967BE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_允许水模拟_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_允许水模拟_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260AC RID: 155820 RVA: 0x009699FA File Offset: 0x00967BFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_DebugInteractionControl_Btn_允许草模拟_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugInteractionControl_C.__BndEvt__BP_DebugInteractionControl_Btn_允许草模拟_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x060260AD RID: 155821 RVA: 0x00969A0E File Offset: 0x00967C0E
		protected BP_DebugInteractionControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401308B RID: 77963
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/BP_DebugInteractionControl.BP_DebugInteractionControl_C";

		// Token: 0x0401308C RID: 77964
		private static IntPtr _ClassPtr;

		// Token: 0x0401308D RID: 77965
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401308E RID: 77966
		internal static int __PropertyOffset_1;

		// Token: 0x0401308F RID: 77967
		internal static int __PropertyOffset_2;

		// Token: 0x04013090 RID: 77968
		internal static int __PropertyOffset_3;

		// Token: 0x04013091 RID: 77969
		internal static int __PropertyOffset_4;

		// Token: 0x04013092 RID: 77970
		internal static int __PropertyOffset_5;

		// Token: 0x04013093 RID: 77971
		internal static int __PropertyOffset_6;

		// Token: 0x04013094 RID: 77972
		internal static int __PropertyOffset_7;

		// Token: 0x04013095 RID: 77973
		internal static int __PropertyOffset_8;

		// Token: 0x04013096 RID: 77974
		internal static int __PropertyOffset_9;

		// Token: 0x04013097 RID: 77975
		internal static int __PropertyOffset_10;

		// Token: 0x04013098 RID: 77976
		internal static int __PropertyOffset_11;

		// Token: 0x04013099 RID: 77977
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Button_0_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309A RID: 77978
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_开启场景水交互_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309B RID: 77979
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_关闭场景水交互_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309C RID: 77980
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_屏蔽草交互物_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309D RID: 77981
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_启用草交互物_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309E RID: 77982
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_停止水模拟_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401309F RID: 77983
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_停止草模拟_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040130A0 RID: 77984
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_允许水模拟_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040130A1 RID: 77985
		private static IntPtr __BndEvt__BP_DebugInteractionControl_Btn_允许草模拟_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;
	}
}
