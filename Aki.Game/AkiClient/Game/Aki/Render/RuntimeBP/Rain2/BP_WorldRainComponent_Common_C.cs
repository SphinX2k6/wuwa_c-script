using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BC5 RID: 15301
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_WorldRainComponent_Common.BP_WorldRainComponent_Common_C")]
	[UnrealStructLayout(880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 872)]
	public class BP_WorldRainComponent_Common_C : UKuroWorldRainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022499 RID: 140441 RVA: 0x00904950 File Offset: 0x00902B50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WorldRainComponent_Common_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_WorldRainComponent_Common.BP_WorldRainComponent_Common_C");
			}
			return BP_WorldRainComponent_Common_C._ClassPtr;
		}

		// Token: 0x0602249A RID: 140442 RVA: 0x00904974 File Offset: 0x00902B74
		public BP_WorldRainComponent_Common_C() : this(BuiltinUtils.AllocNativeUObject(BP_WorldRainComponent_Common_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602249B RID: 140443 RVA: 0x0090499C File Offset: 0x00902B9C
		[NullableContext(1)]
		public BP_WorldRainComponent_Common_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WorldRainComponent_Common_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0602249C RID: 140444 RVA: 0x009049CF File Offset: 0x00902BCF
		// (set) Token: 0x0602249D RID: 140445 RVA: 0x009049E3 File Offset: 0x00902BE3
		public unsafe UClusteredStuffDataAsset ClusteredStuff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0602249E RID: 140446 RVA: 0x009049F8 File Offset: 0x00902BF8
		// (set) Token: 0x0602249F RID: 140447 RVA: 0x00904A0C File Offset: 0x00902C0C
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x060224A0 RID: 140448 RVA: 0x00904A21 File Offset: 0x00902C21
		// (set) Token: 0x060224A1 RID: 140449 RVA: 0x00904A35 File Offset: 0x00902C35
		[Nullable(1)]
		public unsafe string CommandOnStart
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WorldRainComponent_Common_C.__PropertyOffset_3)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WorldRainComponent_Common_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x060224A2 RID: 140450 RVA: 0x00904A4A File Offset: 0x00902C4A
		// (set) Token: 0x060224A3 RID: 140451 RVA: 0x00904A5E File Offset: 0x00902C5E
		[Nullable(1)]
		public unsafe string CommandOnDeactivate
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WorldRainComponent_Common_C.__PropertyOffset_4)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WorldRainComponent_Common_C.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x060224A4 RID: 140452 RVA: 0x00904A73 File Offset: 0x00902C73
		// (set) Token: 0x060224A5 RID: 140453 RVA: 0x00904A87 File Offset: 0x00902C87
		public unsafe EffectScreenPlayData_C ScreenEffectToPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WorldRainComponent_Common_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060224A6 RID: 140454 RVA: 0x00904A9C File Offset: 0x00902C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnReceiveStartRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WorldRainComponent_Common_C.__OnReceiveStartRain_NativeFunctionPtr, null);
		}

		// Token: 0x060224A7 RID: 140455 RVA: 0x00904AB0 File Offset: 0x00902CB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnReceiveStartRain_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WorldRainComponent_Common_C.__OnReceiveStartRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060224A8 RID: 140456 RVA: 0x00904AC5 File Offset: 0x00902CC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnReceiveDeactivateRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WorldRainComponent_Common_C.__OnReceiveDeactivateRain_NativeFunctionPtr, null);
		}

		// Token: 0x060224A9 RID: 140457 RVA: 0x00904AD9 File Offset: 0x00902CD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnReceiveDeactivateRain_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WorldRainComponent_Common_C.__OnReceiveDeactivateRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060224AA RID: 140458 RVA: 0x00904AEE File Offset: 0x00902CEE
		protected BP_WorldRainComponent_Common_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010CF3 RID: 68851
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_WorldRainComponent_Common.BP_WorldRainComponent_Common_C";

		// Token: 0x04010CF4 RID: 68852
		private static IntPtr _ClassPtr;

		// Token: 0x04010CF5 RID: 68853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010CF6 RID: 68854
		internal static int __PropertyOffset_1;

		// Token: 0x04010CF7 RID: 68855
		internal static int __PropertyOffset_2;

		// Token: 0x04010CF8 RID: 68856
		internal static int __PropertyOffset_3;

		// Token: 0x04010CF9 RID: 68857
		internal static int __PropertyOffset_4;

		// Token: 0x04010CFA RID: 68858
		internal static int __PropertyOffset_5;

		// Token: 0x04010CFB RID: 68859
		private static IntPtr __OnReceiveStartRain_NativeFunctionPtr;

		// Token: 0x04010CFC RID: 68860
		private static IntPtr __OnReceiveDeactivateRain_NativeFunctionPtr;
	}
}
