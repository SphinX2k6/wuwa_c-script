using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x0200310A RID: 12554
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class SceneEffectStatePostVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBBC RID: 125884 RVA: 0x0091BA12 File Offset: 0x00919C12
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SceneEffectStatePostVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C");
			}
			return SceneEffectStatePostVolume_C._ClassPtr;
		}

		// Token: 0x0601EBBD RID: 125885 RVA: 0x0091BA38 File Offset: 0x00919C38
		public SceneEffectStatePostVolume_C() : this(BuiltinUtils.AllocNativeUObject(SceneEffectStatePostVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBBE RID: 125886 RVA: 0x0091BA60 File Offset: 0x00919C60
		[NullableContext(1)]
		public SceneEffectStatePostVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneEffectStatePostVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0601EBBF RID: 125887 RVA: 0x0091BA93 File Offset: 0x00919C93
		// (set) Token: 0x0601EBC0 RID: 125888 RVA: 0x0091BAA7 File Offset: 0x00919CA7
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_KuroPostProcess);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0601EBC1 RID: 125889 RVA: 0x0091BABC File Offset: 0x00919CBC
		// (set) Token: 0x0601EBC2 RID: 125890 RVA: 0x0091BAD0 File Offset: 0x00919CD0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0601EBC3 RID: 125891 RVA: 0x0091BAE5 File Offset: 0x00919CE5
		// (set) Token: 0x0601EBC4 RID: 125892 RVA: 0x0091BAF5 File Offset: 0x00919CF5
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_Enabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_Enabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0601EBC5 RID: 125893 RVA: 0x0091BB06 File Offset: 0x00919D06
		// (set) Token: 0x0601EBC6 RID: 125894 RVA: 0x0091BB16 File Offset: 0x00919D16
		public unsafe float value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_value) = value;
			}
		}

		// Token: 0x0601EBC7 RID: 125895 RVA: 0x0091BB27 File Offset: 0x00919D27
		[SkipLocalsInit]
		public virtual void SetToxicFog_Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetToxicFog_Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0601EBC8 RID: 125896 RVA: 0x0091BB3B File Offset: 0x00919D3B
		[SkipLocalsInit]
		public virtual void SetWall_Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetWall_Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0601EBC9 RID: 125897 RVA: 0x0091BB50 File Offset: 0x00919D50
		[SkipLocalsInit]
		public unsafe virtual void SetEffect(float Value)
		{
			SceneEffectStatePostVolume_C.__SetEffect_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetEffect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EBCA RID: 125898 RVA: 0x0091BB96 File Offset: 0x00919D96
		[SkipLocalsInit]
		public virtual void DisableVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__DisableVolume_NativeFunctionPtr, null);
		}

		// Token: 0x0601EBCB RID: 125899 RVA: 0x0091BBAA File Offset: 0x00919DAA
		[SkipLocalsInit]
		public virtual void EnableVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__EnableVolume_NativeFunctionPtr, null);
		}

		// Token: 0x0601EBCC RID: 125900 RVA: 0x0091BBC0 File Offset: 0x00919DC0
		[SkipLocalsInit]
		public unsafe virtual void SetToxicFog(float Value)
		{
			SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetToxicFog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetToxicFog_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EBCD RID: 125901 RVA: 0x0091BC08 File Offset: 0x00919E08
		[SkipLocalsInit]
		public unsafe virtual void SetAirWall(float value)
		{
			SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetAirWall_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetAirWall_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EBCE RID: 125902 RVA: 0x0091BC4E File Offset: 0x00919E4E
		protected SceneEffectStatePostVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010501 RID: 66817
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C";

		// Token: 0x04010502 RID: 66818
		private static IntPtr _ClassPtr;

		// Token: 0x04010503 RID: 66819
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010504 RID: 66820
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x04010505 RID: 66821
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010506 RID: 66822
		internal static int __PropertyOffset_Enabled;

		// Token: 0x04010507 RID: 66823
		internal static int __PropertyOffset_value;

		// Token: 0x04010508 RID: 66824
		private static IntPtr __SetToxicFog_Debug_NativeFunctionPtr;

		// Token: 0x04010509 RID: 66825
		private static IntPtr __SetWall_Debug_NativeFunctionPtr;

		// Token: 0x0401050A RID: 66826
		private static IntPtr __SetEffect_NativeFunctionPtr;

		// Token: 0x0401050B RID: 66827
		private static IntPtr __DisableVolume_NativeFunctionPtr;

		// Token: 0x0401050C RID: 66828
		private static IntPtr __EnableVolume_NativeFunctionPtr;

		// Token: 0x0401050D RID: 66829
		private static IntPtr __SetToxicFog_NativeFunctionPtr;

		// Token: 0x0401050E RID: 66830
		private static IntPtr __SetAirWall_NativeFunctionPtr;

		// Token: 0x02008EC2 RID: 36546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetEffect_FunctionParams
		{
			// Token: 0x0402CB61 RID: 183137
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02008EC3 RID: 36547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetToxicFog_FunctionParams
		{
			// Token: 0x0402CB62 RID: 183138
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02008EC4 RID: 36548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetAirWall_FunctionParams
		{
			// Token: 0x0402CB63 RID: 183139
			[FieldOffset(0)]
			public float value;
		}
	}
}
