using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x0200442B RID: 17451
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_AudioEventTrigger.BP_AudioEventTrigger_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1097)]
	public class BP_AudioEventTrigger_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D214 RID: 184852 RVA: 0x00A34120 File Offset: 0x00A32320
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AudioEventTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_AudioEventTrigger.BP_AudioEventTrigger_C");
			}
			return BP_AudioEventTrigger_C._ClassPtr;
		}

		// Token: 0x0602D215 RID: 184853 RVA: 0x00A34144 File Offset: 0x00A32344
		public BP_AudioEventTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_AudioEventTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D216 RID: 184854 RVA: 0x00A3416C File Offset: 0x00A3236C
		[NullableContext(1)]
		public BP_AudioEventTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AudioEventTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007229 RID: 29225
		// (get) Token: 0x0602D217 RID: 184855 RVA: 0x00A3419F File Offset: 0x00A3239F
		// (set) Token: 0x0602D218 RID: 184856 RVA: 0x00A341B3 File Offset: 0x00A323B3
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700722A RID: 29226
		// (get) Token: 0x0602D219 RID: 184857 RVA: 0x00A341C8 File Offset: 0x00A323C8
		// (set) Token: 0x0602D21A RID: 184858 RVA: 0x00A341DC File Offset: 0x00A323DC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700722B RID: 29227
		// (get) Token: 0x0602D21B RID: 184859 RVA: 0x00A341F1 File Offset: 0x00A323F1
		// (set) Token: 0x0602D21C RID: 184860 RVA: 0x00A34205 File Offset: 0x00A32405
		public unsafe ATriggerVolume TriggerVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ATriggerVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700722C RID: 29228
		// (get) Token: 0x0602D21D RID: 184861 RVA: 0x00A3421A File Offset: 0x00A3241A
		// (set) Token: 0x0602D21E RID: 184862 RVA: 0x00A3422E File Offset: 0x00A3242E
		public unsafe UAkAudioEvent AudioEvent_In
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700722D RID: 29229
		// (get) Token: 0x0602D21F RID: 184863 RVA: 0x00A34243 File Offset: 0x00A32443
		// (set) Token: 0x0602D220 RID: 184864 RVA: 0x00A34257 File Offset: 0x00A32457
		public unsafe UAkAudioEvent AudioEvent_Out
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioEventTrigger_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700722E RID: 29230
		// (get) Token: 0x0602D221 RID: 184865 RVA: 0x00A3426C File Offset: 0x00A3246C
		// (set) Token: 0x0602D222 RID: 184866 RVA: 0x00A3427C File Offset: 0x00A3247C
		public unsafe bool IsOverlapping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioEventTrigger_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioEventTrigger_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602D223 RID: 184867 RVA: 0x00A3428D File Offset: 0x00A3248D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioEventTrigger_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602D224 RID: 184868 RVA: 0x00A342A1 File Offset: 0x00A324A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioEventTrigger_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D225 RID: 184869 RVA: 0x00A342B8 File Offset: 0x00A324B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioEventTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioEventTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D226 RID: 184870 RVA: 0x00A34300 File Offset: 0x00A32500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioEventTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioEventTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioEventTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D227 RID: 184871 RVA: 0x00A34347 File Offset: 0x00A32547
		protected BP_AudioEventTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F9A RID: 98202
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_AudioEventTrigger.BP_AudioEventTrigger_C";

		// Token: 0x04017F9B RID: 98203
		private static IntPtr _ClassPtr;

		// Token: 0x04017F9C RID: 98204
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017F9D RID: 98205
		internal static int __PropertyOffset_1;

		// Token: 0x04017F9E RID: 98206
		internal static int __PropertyOffset_2;

		// Token: 0x04017F9F RID: 98207
		internal static int __PropertyOffset_3;

		// Token: 0x04017FA0 RID: 98208
		internal static int __PropertyOffset_4;

		// Token: 0x04017FA1 RID: 98209
		internal static int __PropertyOffset_5;

		// Token: 0x04017FA2 RID: 98210
		internal static int __PropertyOffset_6;

		// Token: 0x04017FA3 RID: 98211
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04017FA4 RID: 98212
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A6D9 RID: 42713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040326C0 RID: 206528
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
