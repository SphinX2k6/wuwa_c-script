using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B12 RID: 15122
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1145)]
	public class BP_LightsGroup_C : AActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602102C RID: 135212 RVA: 0x008E283E File Offset: 0x008E0A3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightsGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C");
			}
			return BP_LightsGroup_C._ClassPtr;
		}

		// Token: 0x0602102D RID: 135213 RVA: 0x008E2862 File Offset: 0x008E0A62
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_LightsGroup_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602102E RID: 135214 RVA: 0x008E286C File Offset: 0x008E0A6C
		public BP_LightsGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightsGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602102F RID: 135215 RVA: 0x008E2894 File Offset: 0x008E0A94
		[NullableContext(1)]
		public BP_LightsGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightsGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x06021030 RID: 135216 RVA: 0x008E28C7 File Offset: 0x008E0AC7
		// (set) Token: 0x06021031 RID: 135217 RVA: 0x008E28DB File Offset: 0x008E0ADB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightsGroup_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightsGroup_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x06021032 RID: 135218 RVA: 0x008E28F0 File Offset: 0x008E0AF0
		// (set) Token: 0x06021033 RID: 135219 RVA: 0x008E2900 File Offset: 0x008E0B00
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x06021034 RID: 135220 RVA: 0x008E2911 File Offset: 0x008E0B11
		// (set) Token: 0x06021035 RID: 135221 RVA: 0x008E2921 File Offset: 0x008E0B21
		public unsafe bool TurnOffOrOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x06021036 RID: 135222 RVA: 0x008E2932 File Offset: 0x008E0B32
		// (set) Token: 0x06021037 RID: 135223 RVA: 0x008E2942 File Offset: 0x008E0B42
		public unsafe bool UseSimpleToggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x06021038 RID: 135224 RVA: 0x008E2953 File Offset: 0x008E0B53
		// (set) Token: 0x06021039 RID: 135225 RVA: 0x008E2963 File Offset: 0x008E0B63
		public unsafe bool UseColorChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0602103A RID: 135226 RVA: 0x008E2974 File Offset: 0x008E0B74
		// (set) Token: 0x0602103B RID: 135227 RVA: 0x008E2984 File Offset: 0x008E0B84
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0602103C RID: 135228 RVA: 0x008E2995 File Offset: 0x008E0B95
		// (set) Token: 0x0602103D RID: 135229 RVA: 0x008E29A5 File Offset: 0x008E0BA5
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0602103E RID: 135230 RVA: 0x008E29B6 File Offset: 0x008E0BB6
		// (set) Token: 0x0602103F RID: 135231 RVA: 0x008E29C6 File Offset: 0x008E0BC6
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x06021040 RID: 135232 RVA: 0x008E29D8 File Offset: 0x008E0BD8
		// (set) Token: 0x06021041 RID: 135233 RVA: 0x008E2A11 File Offset: 0x008E0C11
		[Nullable(1)]
		public TArray<float> LightsIntensity
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LightsIntensity) == null)
				{
					result = (this._LightsIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightsIntensity.CopyAssign(value);
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x06021042 RID: 135234 RVA: 0x008E2A1F File Offset: 0x008E0C1F
		// (set) Token: 0x06021043 RID: 135235 RVA: 0x008E2A33 File Offset: 0x008E0C33
		public unsafe FLinearColor ColorOriginal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x06021044 RID: 135236 RVA: 0x008E2A48 File Offset: 0x008E0C48
		// (set) Token: 0x06021045 RID: 135237 RVA: 0x008E2A5C File Offset: 0x008E0C5C
		public unsafe FLinearColor ColorTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x06021046 RID: 135238 RVA: 0x008E2A71 File Offset: 0x008E0C71
		// (set) Token: 0x06021047 RID: 135239 RVA: 0x008E2A85 File Offset: 0x008E0C85
		[Nullable(1)]
		public unsafe string Test
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LightsGroup_C.__PropertyOffset_12)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LightsGroup_C.__PropertyOffset_12)), value);
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x06021048 RID: 135240 RVA: 0x008E2A9A File Offset: 0x008E0C9A
		// (set) Token: 0x06021049 RID: 135241 RVA: 0x008E2AAA File Offset: 0x008E0CAA
		public unsafe bool EnableLightsOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602104A RID: 135242 RVA: 0x008E2ABC File Offset: 0x008E0CBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602104B RID: 135243 RVA: 0x008E2B04 File Offset: 0x008E0D04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602104C RID: 135244 RVA: 0x008E2B4C File Offset: 0x008E0D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LightsColorChange(float ElapsedTime, FLinearColor ColorOriginal, FLinearColor ColorTarget)
		{
			BP_LightsGroup_C.__LightsColorChange_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__LightsColorChange_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_LightsGroup_C.__LightsColorChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__LightsColorChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			ptr->ColorOriginal = ColorOriginal;
			ptr->ColorTarget = ColorTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__LightsColorChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602104D RID: 135245 RVA: 0x008E2BA3 File Offset: 0x008E0DA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ToggleLightsColorChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLightsColorChange_NativeFunctionPtr, null);
		}

		// Token: 0x0602104E RID: 135246 RVA: 0x008E2BB7 File Offset: 0x008E0DB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetLightsIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__GetLightsIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x0602104F RID: 135247 RVA: 0x008E2BCC File Offset: 0x008E0DCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_LightsGroup_C.__Timer_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_LightsGroup_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x06021050 RID: 135248 RVA: 0x008E2C1C File Offset: 0x008E0E1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TurnOnLights(float ElapsedTime)
		{
			BP_LightsGroup_C.__TurnOnLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__TurnOnLights_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_LightsGroup_C.__TurnOnLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__TurnOnLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__TurnOnLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021051 RID: 135249 RVA: 0x008E2C64 File Offset: 0x008E0E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TurnOffLights(float ElapsedTime)
		{
			BP_LightsGroup_C.__TurnOffLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__TurnOffLights_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_LightsGroup_C.__TurnOffLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__TurnOffLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__TurnOffLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021052 RID: 135250 RVA: 0x008E2CAA File Offset: 0x008E0EAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ToggleLightsIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLightsIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x06021053 RID: 135251 RVA: 0x008E2CC0 File Offset: 0x008E0EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ToggleLights(bool inEnable)
		{
			BP_LightsGroup_C.__ToggleLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ToggleLights_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_LightsGroup_C.__ToggleLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ToggleLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inEnable = inEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021054 RID: 135252 RVA: 0x008E2D09 File Offset: 0x008E0F09
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021055 RID: 135253 RVA: 0x008E2D1D File Offset: 0x008E0F1D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021056 RID: 135254 RVA: 0x008E2D34 File Offset: 0x008E0F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightsGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021057 RID: 135255 RVA: 0x008E2D7C File Offset: 0x008E0F7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightsGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021058 RID: 135256 RVA: 0x008E2DC3 File Offset: 0x008E0FC3
		protected BP_LightsGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100DB RID: 65755
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040100DC RID: 65756
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C";

		// Token: 0x040100DD RID: 65757
		private static IntPtr _ClassPtr;

		// Token: 0x040100DE RID: 65758
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100DF RID: 65759
		internal static int __PropertyOffset_1;

		// Token: 0x040100E0 RID: 65760
		internal static int __PropertyOffset_2;

		// Token: 0x040100E1 RID: 65761
		internal static int __PropertyOffset_3;

		// Token: 0x040100E2 RID: 65762
		internal static int __PropertyOffset_4;

		// Token: 0x040100E3 RID: 65763
		internal static int __PropertyOffset_5;

		// Token: 0x040100E4 RID: 65764
		internal static int __PropertyOffset_6;

		// Token: 0x040100E5 RID: 65765
		internal static int __PropertyOffset_7;

		// Token: 0x040100E6 RID: 65766
		internal static int __PropertyOffset_8;

		// Token: 0x040100E7 RID: 65767
		internal static int __PropertyOffset_9;

		// Token: 0x040100E8 RID: 65768
		[Nullable(2)]
		private TArray<float> _LightsIntensity;

		// Token: 0x040100E9 RID: 65769
		internal static int __PropertyOffset_10;

		// Token: 0x040100EA RID: 65770
		internal static int __PropertyOffset_11;

		// Token: 0x040100EB RID: 65771
		internal static int __PropertyOffset_12;

		// Token: 0x040100EC RID: 65772
		internal static int __PropertyOffset_13;

		// Token: 0x040100ED RID: 65773
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040100EE RID: 65774
		private static IntPtr __LightsColorChange_NativeFunctionPtr;

		// Token: 0x040100EF RID: 65775
		private static IntPtr __ToggleLightsColorChange_NativeFunctionPtr;

		// Token: 0x040100F0 RID: 65776
		private static IntPtr __GetLightsIntensity_NativeFunctionPtr;

		// Token: 0x040100F1 RID: 65777
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x040100F2 RID: 65778
		private static IntPtr __TurnOnLights_NativeFunctionPtr;

		// Token: 0x040100F3 RID: 65779
		private static IntPtr __TurnOffLights_NativeFunctionPtr;

		// Token: 0x040100F4 RID: 65780
		private static IntPtr __ToggleLightsIntensity_NativeFunctionPtr;

		// Token: 0x040100F5 RID: 65781
		private static IntPtr __ToggleLights_NativeFunctionPtr;

		// Token: 0x040100F6 RID: 65782
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040100F7 RID: 65783
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C5A RID: 40026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031316 RID: 201494
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C5B RID: 40027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LightsColorChange_FunctionParams
		{
			// Token: 0x04031317 RID: 201495
			[FieldOffset(0)]
			public float ElapsedTime;

			// Token: 0x04031318 RID: 201496
			[FieldOffset(4)]
			public FLinearColor ColorOriginal;

			// Token: 0x04031319 RID: 201497
			[FieldOffset(20)]
			public FLinearColor ColorTarget;
		}

		// Token: 0x02009C5C RID: 40028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x0403131A RID: 201498
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02009C5D RID: 40029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __TurnOnLights_FunctionParams
		{
			// Token: 0x0403131B RID: 201499
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02009C5E RID: 40030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __TurnOffLights_FunctionParams
		{
			// Token: 0x0403131C RID: 201500
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02009C5F RID: 40031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __ToggleLights_FunctionParams
		{
			// Token: 0x0403131D RID: 201501
			[FieldOffset(0)]
			public bool inEnable;
		}

		// Token: 0x02009C60 RID: 40032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403131E RID: 201502
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
