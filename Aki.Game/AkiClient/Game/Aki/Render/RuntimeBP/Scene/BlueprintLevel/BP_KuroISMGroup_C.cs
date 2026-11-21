using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.BlueprintLevel
{
	// Token: 0x020030D2 RID: 12498
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class BP_KuroISMGroup_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E15F RID: 123231 RVA: 0x0090A9C9 File Offset: 0x00908BC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroISMGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C");
			}
			return BP_KuroISMGroup_C._ClassPtr;
		}

		// Token: 0x0601E160 RID: 123232 RVA: 0x0090A9F0 File Offset: 0x00908BF0
		public BP_KuroISMGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroISMGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E161 RID: 123233 RVA: 0x0090AA18 File Offset: 0x00908C18
		[NullableContext(1)]
		public BP_KuroISMGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroISMGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0601E162 RID: 123234 RVA: 0x0090AA4B File Offset: 0x00908C4B
		// (set) Token: 0x0601E163 RID: 123235 RVA: 0x0090AA5F File Offset: 0x00908C5F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroISMGroup_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroISMGroup_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0601E164 RID: 123236 RVA: 0x0090AA74 File Offset: 0x00908C74
		// (set) Token: 0x0601E165 RID: 123237 RVA: 0x0090AA84 File Offset: 0x00908C84
		public unsafe bool HideLogicallyOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_HideLogicallyOnBeginPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_HideLogicallyOnBeginPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0601E166 RID: 123238 RVA: 0x0090AA95 File Offset: 0x00908C95
		// (set) Token: 0x0601E167 RID: 123239 RVA: 0x0090AAA5 File Offset: 0x00908CA5
		public unsafe float DitherProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_DitherProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_DitherProgress) = value;
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0601E168 RID: 123240 RVA: 0x0090AAB6 File Offset: 0x00908CB6
		// (set) Token: 0x0601E169 RID: 123241 RVA: 0x0090AAC6 File Offset: 0x00908CC6
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0601E16A RID: 123242 RVA: 0x0090AAD7 File Offset: 0x00908CD7
		// (set) Token: 0x0601E16B RID: 123243 RVA: 0x0090AAE7 File Offset: 0x00908CE7
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_IsTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_IsTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0601E16C RID: 123244 RVA: 0x0090AAF8 File Offset: 0x00908CF8
		// (set) Token: 0x0601E16D RID: 123245 RVA: 0x0090AB08 File Offset: 0x00908D08
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_DeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_DeltaSeconds) = value;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0601E16E RID: 123246 RVA: 0x0090AB19 File Offset: 0x00908D19
		// (set) Token: 0x0601E16F RID: 123247 RVA: 0x0090AB29 File Offset: 0x00908D29
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0601E170 RID: 123248 RVA: 0x0090AB3A File Offset: 0x00908D3A
		// (set) Token: 0x0601E171 RID: 123249 RVA: 0x0090AB4A File Offset: 0x00908D4A
		public unsafe bool IsShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_IsShow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_IsShow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0601E172 RID: 123250 RVA: 0x0090AB5B File Offset: 0x00908D5B
		// (set) Token: 0x0601E173 RID: 123251 RVA: 0x0090AB6F File Offset: 0x00908D6F
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0601E174 RID: 123252 RVA: 0x0090AB84 File Offset: 0x00908D84
		// (set) Token: 0x0601E175 RID: 123253 RVA: 0x0090AB94 File Offset: 0x00908D94
		public unsafe float FloatPar_Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_FloatPar_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_FloatPar_Start) = value;
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0601E176 RID: 123254 RVA: 0x0090ABA5 File Offset: 0x00908DA5
		// (set) Token: 0x0601E177 RID: 123255 RVA: 0x0090ABB5 File Offset: 0x00908DB5
		public unsafe float FloatPar_End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_FloatPar_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_FloatPar_End) = value;
			}
		}

		// Token: 0x0601E178 RID: 123256 RVA: 0x0090ABC8 File Offset: 0x00908DC8
		[SkipLocalsInit]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_KuroISMGroup_C.__Timer_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroISMGroup_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x0601E179 RID: 123257 RVA: 0x0090AC18 File Offset: 0x00908E18
		[SkipLocalsInit]
		public unsafe virtual void MaterialParameterGradient(float DeltalTime)
		{
			BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams[(UIntPtr)295] + 15L / (long)sizeof(BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__MaterialParameterGradient_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltalTime = DeltalTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__MaterialParameterGradient_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E17A RID: 123258 RVA: 0x0090AC61 File Offset: 0x00908E61
		[SkipLocalsInit]
		public virtual void SeyLogicallyShowForAllChildren()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__SeyLogicallyShowForAllChildren_NativeFunctionPtr, null);
		}

		// Token: 0x0601E17B RID: 123259 RVA: 0x0090AC75 File Offset: 0x00908E75
		[SkipLocalsInit]
		public virtual void SeyLogicallyHiddenForAllChildren()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__SeyLogicallyHiddenForAllChildren_NativeFunctionPtr, null);
		}

		// Token: 0x0601E17C RID: 123260 RVA: 0x0090AC89 File Offset: 0x00908E89
		[SkipLocalsInit]
		public virtual void EditorValidCheck()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__EditorValidCheck_NativeFunctionPtr, null);
		}

		// Token: 0x0601E17D RID: 123261 RVA: 0x0090ACA0 File Offset: 0x00908EA0
		[SkipLocalsInit]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_KuroISMGroup_C.__IsEditor_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__IsEditor_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_KuroISMGroup_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0601E17E RID: 123262 RVA: 0x0090ACEF File Offset: 0x00908EEF
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E17F RID: 123263 RVA: 0x0090AD03 File Offset: 0x00908F03
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E180 RID: 123264 RVA: 0x0090AD17 File Offset: 0x00908F17
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E181 RID: 123265 RVA: 0x0090AD2B File Offset: 0x00908F2B
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E182 RID: 123266 RVA: 0x0090AD40 File Offset: 0x00908F40
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroISMGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroISMGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E183 RID: 123267 RVA: 0x0090AD88 File Offset: 0x00908F88
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroISMGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroISMGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E184 RID: 123268 RVA: 0x0090ADCE File Offset: 0x00908FCE
		protected BP_KuroISMGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE81 RID: 65153
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C";

		// Token: 0x0400FE82 RID: 65154
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE83 RID: 65155
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE84 RID: 65156
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FE85 RID: 65157
		internal static int __PropertyOffset_HideLogicallyOnBeginPlay;

		// Token: 0x0400FE86 RID: 65158
		internal static int __PropertyOffset_DitherProgress;

		// Token: 0x0400FE87 RID: 65159
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400FE88 RID: 65160
		internal static int __PropertyOffset_IsTick;

		// Token: 0x0400FE89 RID: 65161
		internal static int __PropertyOffset_DeltaSeconds;

		// Token: 0x0400FE8A RID: 65162
		internal static int __PropertyOffset_Time;

		// Token: 0x0400FE8B RID: 65163
		internal static int __PropertyOffset_IsShow;

		// Token: 0x0400FE8C RID: 65164
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400FE8D RID: 65165
		internal static int __PropertyOffset_FloatPar_Start;

		// Token: 0x0400FE8E RID: 65166
		internal static int __PropertyOffset_FloatPar_End;

		// Token: 0x0400FE8F RID: 65167
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0400FE90 RID: 65168
		private static IntPtr __MaterialParameterGradient_NativeFunctionPtr;

		// Token: 0x0400FE91 RID: 65169
		private static IntPtr __SeyLogicallyShowForAllChildren_NativeFunctionPtr;

		// Token: 0x0400FE92 RID: 65170
		private static IntPtr __SeyLogicallyHiddenForAllChildren_NativeFunctionPtr;

		// Token: 0x0400FE93 RID: 65171
		private static IntPtr __EditorValidCheck_NativeFunctionPtr;

		// Token: 0x0400FE94 RID: 65172
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x0400FE95 RID: 65173
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE96 RID: 65174
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE97 RID: 65175
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008E19 RID: 36377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x0402CA58 RID: 182872
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02008E1A RID: 36378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 280)]
		protected ref struct __MaterialParameterGradient_FunctionParams
		{
			// Token: 0x0402CA59 RID: 182873
			[FieldOffset(0)]
			public float DeltalTime;
		}

		// Token: 0x02008E1B RID: 36379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x0402CA5A RID: 182874
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02008E1C RID: 36380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA5B RID: 182875
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
