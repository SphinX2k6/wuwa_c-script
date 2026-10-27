using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroBillboardClouds
{
	// Token: 0x02003C98 RID: 15512
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroBillboardClouds/BP_BillboardClouds.BP_BillboardClouds_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1114)]
	public class BP_BillboardClouds_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024564 RID: 148836 RVA: 0x0093BC56 File Offset: 0x00939E56
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BillboardClouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroBillboardClouds/BP_BillboardClouds.BP_BillboardClouds_C");
			}
			return BP_BillboardClouds_C._ClassPtr;
		}

		// Token: 0x06024565 RID: 148837 RVA: 0x0093BC7C File Offset: 0x00939E7C
		public BP_BillboardClouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_BillboardClouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024566 RID: 148838 RVA: 0x0093BCA4 File Offset: 0x00939EA4
		[NullableContext(1)]
		public BP_BillboardClouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BillboardClouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x06024567 RID: 148839 RVA: 0x0093BCD7 File Offset: 0x00939ED7
		// (set) Token: 0x06024568 RID: 148840 RVA: 0x0093BCEB File Offset: 0x00939EEB
		public unsafe UNiagaraComponent NS_BillboardClouds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x06024569 RID: 148841 RVA: 0x0093BD00 File Offset: 0x00939F00
		// (set) Token: 0x0602456A RID: 148842 RVA: 0x0093BD14 File Offset: 0x00939F14
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x0602456B RID: 148843 RVA: 0x0093BD29 File Offset: 0x00939F29
		// (set) Token: 0x0602456C RID: 148844 RVA: 0x0093BD39 File Offset: 0x00939F39
		public unsafe float Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x0602456D RID: 148845 RVA: 0x0093BD4A File Offset: 0x00939F4A
		// (set) Token: 0x0602456E RID: 148846 RVA: 0x0093BD5A File Offset: 0x00939F5A
		public unsafe float lifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x0602456F RID: 148847 RVA: 0x0093BD6B File Offset: 0x00939F6B
		// (set) Token: 0x06024570 RID: 148848 RVA: 0x0093BD7B File Offset: 0x00939F7B
		public unsafe float CloudScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x06024571 RID: 148849 RVA: 0x0093BD8C File Offset: 0x00939F8C
		// (set) Token: 0x06024572 RID: 148850 RVA: 0x0093BD9C File Offset: 0x00939F9C
		public unsafe float CloudMinAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x06024573 RID: 148851 RVA: 0x0093BDAD File Offset: 0x00939FAD
		// (set) Token: 0x06024574 RID: 148852 RVA: 0x0093BDBD File Offset: 0x00939FBD
		public unsafe float CloudMaxAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x06024575 RID: 148853 RVA: 0x0093BDCE File Offset: 0x00939FCE
		// (set) Token: 0x06024576 RID: 148854 RVA: 0x0093BDDE File Offset: 0x00939FDE
		public unsafe float CloudSpriteSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x06024577 RID: 148855 RVA: 0x0093BDEF File Offset: 0x00939FEF
		// (set) Token: 0x06024578 RID: 148856 RVA: 0x0093BDFF File Offset: 0x00939FFF
		public unsafe float CloudSpriteSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x06024579 RID: 148857 RVA: 0x0093BE10 File Offset: 0x0093A010
		// (set) Token: 0x0602457A RID: 148858 RVA: 0x0093BE24 File Offset: 0x0093A024
		public unsafe UHoudiniPointCache houd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BillboardClouds_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x0602457B RID: 148859 RVA: 0x0093BE39 File Offset: 0x0093A039
		// (set) Token: 0x0602457C RID: 148860 RVA: 0x0093BE49 File Offset: 0x0093A049
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x0602457D RID: 148861 RVA: 0x0093BE5A File Offset: 0x0093A05A
		// (set) Token: 0x0602457E RID: 148862 RVA: 0x0093BE6A File Offset: 0x0093A06A
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BillboardClouds_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602457F RID: 148863 RVA: 0x0093BE7B File Offset: 0x0093A07B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BillboardClouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024580 RID: 148864 RVA: 0x0093BE8F File Offset: 0x0093A08F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BillboardClouds_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024581 RID: 148865 RVA: 0x0093BEA4 File Offset: 0x0093A0A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BillboardClouds_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024582 RID: 148866 RVA: 0x0093BEB8 File Offset: 0x0093A0B8
		protected BP_BillboardClouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401205E RID: 73822
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroBillboardClouds/BP_BillboardClouds.BP_BillboardClouds_C";

		// Token: 0x0401205F RID: 73823
		private static IntPtr _ClassPtr;

		// Token: 0x04012060 RID: 73824
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012061 RID: 73825
		internal static int __PropertyOffset_1;

		// Token: 0x04012062 RID: 73826
		internal static int __PropertyOffset_2;

		// Token: 0x04012063 RID: 73827
		internal static int __PropertyOffset_3;

		// Token: 0x04012064 RID: 73828
		internal static int __PropertyOffset_4;

		// Token: 0x04012065 RID: 73829
		internal static int __PropertyOffset_5;

		// Token: 0x04012066 RID: 73830
		internal static int __PropertyOffset_6;

		// Token: 0x04012067 RID: 73831
		internal static int __PropertyOffset_7;

		// Token: 0x04012068 RID: 73832
		internal static int __PropertyOffset_8;

		// Token: 0x04012069 RID: 73833
		internal static int __PropertyOffset_9;

		// Token: 0x0401206A RID: 73834
		internal static int __PropertyOffset_10;

		// Token: 0x0401206B RID: 73835
		internal static int __PropertyOffset_11;

		// Token: 0x0401206C RID: 73836
		internal static int __PropertyOffset_12;

		// Token: 0x0401206D RID: 73837
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401206E RID: 73838
		private static IntPtr __EditorTick_NativeFunctionPtr;
	}
}
