using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Kpose.Blueprint
{
	// Token: 0x020032CB RID: 13003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public class BP_KposeBase_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020EFB RID: 134907 RVA: 0x00952E59 File Offset: 0x00951059
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KposeBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C");
			}
			return BP_KposeBase_C._ClassPtr;
		}

		// Token: 0x06020EFC RID: 134908 RVA: 0x00952E80 File Offset: 0x00951080
		public BP_KposeBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_KposeBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020EFD RID: 134909 RVA: 0x00952EA8 File Offset: 0x009510A8
		public BP_KposeBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KposeBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x06020EFE RID: 134910 RVA: 0x00952EDB File Offset: 0x009510DB
		// (set) Token: 0x06020EFF RID: 134911 RVA: 0x00952EEF File Offset: 0x009510EF
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_KuroPostProcess);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x06020F00 RID: 134912 RVA: 0x00952F04 File Offset: 0x00951104
		// (set) Token: 0x06020F01 RID: 134913 RVA: 0x00952F18 File Offset: 0x00951118
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x06020F02 RID: 134914 RVA: 0x00952F2D File Offset: 0x0095112D
		// (set) Token: 0x06020F03 RID: 134915 RVA: 0x00952F3D File Offset: 0x0095113D
		public unsafe bool IsInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_IsInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_IsInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x06020F04 RID: 134916 RVA: 0x00952F4E File Offset: 0x0095114E
		// (set) Token: 0x06020F05 RID: 134917 RVA: 0x00952F5E File Offset: 0x0095115E
		public unsafe float MaterialPlayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_MaterialPlayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_MaterialPlayTime) = value;
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x06020F06 RID: 134918 RVA: 0x00952F70 File Offset: 0x00951170
		// (set) Token: 0x06020F07 RID: 134919 RVA: 0x00952FA9 File Offset: 0x009511A9
		public TArray<int> CachedHandles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CachedHandles) == null)
				{
					result = (this._CachedHandles = new TArray<int>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_CachedHandles, this));
				}
				return result;
			}
			set
			{
				this.CachedHandles.CopyAssign(value);
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x06020F08 RID: 134920 RVA: 0x00952FB8 File Offset: 0x009511B8
		// (set) Token: 0x06020F09 RID: 134921 RVA: 0x00952FF1 File Offset: 0x009511F1
		public TArray<UMaterialInstanceDynamic> DynamicMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterials) == null)
				{
					result = (this._DynamicMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_DynamicMaterials, this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x06020F0A RID: 134922 RVA: 0x00952FFF File Offset: 0x009511FF
		// (set) Token: 0x06020F0B RID: 134923 RVA: 0x0095300F File Offset: 0x0095120F
		public unsafe float PassTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_PassTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_PassTime) = value;
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x06020F0C RID: 134924 RVA: 0x00953020 File Offset: 0x00951220
		// (set) Token: 0x06020F0D RID: 134925 RVA: 0x00953059 File Offset: 0x00951259
		public TMap<FName, float> TempFloatValue
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TempFloatValue) == null)
				{
					result = (this._TempFloatValue = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_TempFloatValue, this));
				}
				return result;
			}
			set
			{
				this.TempFloatValue.CopyAssign(value);
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x06020F0E RID: 134926 RVA: 0x00953068 File Offset: 0x00951268
		// (set) Token: 0x06020F0F RID: 134927 RVA: 0x009530A1 File Offset: 0x009512A1
		public TMap<FName, FLinearColor> TempColorValue
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TempColorValue) == null)
				{
					result = (this._TempColorValue = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_TempColorValue, this));
				}
				return result;
			}
			set
			{
				this.TempColorValue.CopyAssign(value);
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x06020F10 RID: 134928 RVA: 0x009530AF File Offset: 0x009512AF
		// (set) Token: 0x06020F11 RID: 134929 RVA: 0x009530BF File Offset: 0x009512BF
		public unsafe float TimeNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_TimeNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_TimeNormalized) = value;
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x06020F12 RID: 134930 RVA: 0x009530D0 File Offset: 0x009512D0
		// (set) Token: 0x06020F13 RID: 134931 RVA: 0x009530E4 File Offset: 0x009512E4
		[Nullable(2)]
		public unsafe UStaticMesh PlatformStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_PlatformStaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_PlatformStaticMesh, value);
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x06020F14 RID: 134932 RVA: 0x009530F9 File Offset: 0x009512F9
		// (set) Token: 0x06020F15 RID: 134933 RVA: 0x0095310D File Offset: 0x0095130D
		public unsafe string MaterialPrefix1_不可修改_
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_KposeBase_C.__PropertyOffset_MaterialPrefix1_不可修改_)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_KposeBase_C.__PropertyOffset_MaterialPrefix1_不可修改_)), value);
			}
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x06020F16 RID: 134934 RVA: 0x00953122 File Offset: 0x00951322
		// (set) Token: 0x06020F17 RID: 134935 RVA: 0x00953132 File Offset: 0x00951332
		public unsafe int CameraArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_CameraArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_CameraArmLength) = value;
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x06020F18 RID: 134936 RVA: 0x00953143 File Offset: 0x00951343
		// (set) Token: 0x06020F19 RID: 134937 RVA: 0x00953157 File Offset: 0x00951357
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset DA_UIWeather
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_DA_UIWeather);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_DA_UIWeather, value);
			}
		}

		// Token: 0x06020F1A RID: 134938 RVA: 0x0095316C File Offset: 0x0095136C
		[SkipLocalsInit]
		public virtual void ChangePlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ChangePlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06020F1B RID: 134939 RVA: 0x00953180 File Offset: 0x00951380
		[SkipLocalsInit]
		public virtual void PlayEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020F1C RID: 134940 RVA: 0x00953194 File Offset: 0x00951394
		[SkipLocalsInit]
		public virtual void PlayStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020F1D RID: 134941 RVA: 0x009531A8 File Offset: 0x009513A8
		[SkipLocalsInit]
		public unsafe virtual void PlayEffect(TSoftObjectPtr<UEffectModelBase> EffectData, [Nullable(2)] USkeletalMeshComponent Component, FName AttachSocket, FTransform Transform)
		{
			BP_KposeBase_C.__PlayEffect_FunctionParams* ptr = stackalloc BP_KposeBase_C.__PlayEffect_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_KposeBase_C.__PlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			if (EffectData != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->EffectData, EffectData.NativePtr, 1);
			}
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			ptr->AttachSocket = AttachSocket;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020F1E RID: 134942 RVA: 0x0095323C File Offset: 0x0095143C
		[SkipLocalsInit]
		public virtual void StopEffects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__StopEffects_NativeFunctionPtr, null);
		}

		// Token: 0x06020F1F RID: 134943 RVA: 0x00953250 File Offset: 0x00951450
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020F20 RID: 134944 RVA: 0x00953264 File Offset: 0x00951464
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020F21 RID: 134945 RVA: 0x00953278 File Offset: 0x00951478
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020F22 RID: 134946 RVA: 0x0095328C File Offset: 0x0095148C
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020F23 RID: 134947 RVA: 0x009532A0 File Offset: 0x009514A0
		[SkipLocalsInit]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x06020F24 RID: 134948 RVA: 0x009532B4 File Offset: 0x009514B4
		[SkipLocalsInit]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x06020F25 RID: 134949 RVA: 0x009532C8 File Offset: 0x009514C8
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KposeBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F26 RID: 134950 RVA: 0x00953314 File Offset: 0x00951514
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KposeBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F27 RID: 134951 RVA: 0x00953360 File Offset: 0x00951560
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KposeBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F28 RID: 134952 RVA: 0x009533A8 File Offset: 0x009515A8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KposeBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F29 RID: 134953 RVA: 0x009533EE File Offset: 0x009515EE
		protected BP_KposeBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D72 RID: 73074
		public new const string __ObjectPath = "/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C";

		// Token: 0x04011D73 RID: 73075
		private static IntPtr _ClassPtr;

		// Token: 0x04011D74 RID: 73076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D75 RID: 73077
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x04011D76 RID: 73078
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04011D77 RID: 73079
		internal static int __PropertyOffset_IsInEditor;

		// Token: 0x04011D78 RID: 73080
		internal static int __PropertyOffset_MaterialPlayTime;

		// Token: 0x04011D79 RID: 73081
		internal static int __PropertyOffset_CachedHandles;

		// Token: 0x04011D7A RID: 73082
		[Nullable(2)]
		private TArray<int> _CachedHandles;

		// Token: 0x04011D7B RID: 73083
		internal static int __PropertyOffset_DynamicMaterials;

		// Token: 0x04011D7C RID: 73084
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterials;

		// Token: 0x04011D7D RID: 73085
		internal static int __PropertyOffset_PassTime;

		// Token: 0x04011D7E RID: 73086
		internal static int __PropertyOffset_TempFloatValue;

		// Token: 0x04011D7F RID: 73087
		[Nullable(2)]
		private TMap<FName, float> _TempFloatValue;

		// Token: 0x04011D80 RID: 73088
		internal static int __PropertyOffset_TempColorValue;

		// Token: 0x04011D81 RID: 73089
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TempColorValue;

		// Token: 0x04011D82 RID: 73090
		internal static int __PropertyOffset_TimeNormalized;

		// Token: 0x04011D83 RID: 73091
		internal static int __PropertyOffset_PlatformStaticMesh;

		// Token: 0x04011D84 RID: 73092
		internal static int __PropertyOffset_MaterialPrefix1_不可修改_;

		// Token: 0x04011D85 RID: 73093
		internal static int __PropertyOffset_CameraArmLength;

		// Token: 0x04011D86 RID: 73094
		internal static int __PropertyOffset_DA_UIWeather;

		// Token: 0x04011D87 RID: 73095
		private static IntPtr __ChangePlatform_NativeFunctionPtr;

		// Token: 0x04011D88 RID: 73096
		private static IntPtr __PlayEnd_NativeFunctionPtr;

		// Token: 0x04011D89 RID: 73097
		private static IntPtr __PlayStart_NativeFunctionPtr;

		// Token: 0x04011D8A RID: 73098
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x04011D8B RID: 73099
		private static IntPtr __StopEffects_NativeFunctionPtr;

		// Token: 0x04011D8C RID: 73100
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011D8D RID: 73101
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011D8E RID: 73102
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x04011D8F RID: 73103
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011D90 RID: 73104
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008FEB RID: 36843
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __PlayEffect_FunctionParams
		{
			// Token: 0x0402CD9A RID: 183706
			[FieldOffset(0)]
			public byte EffectData;

			// Token: 0x0402CD9B RID: 183707
			[FieldOffset(48)]
			public IntPtr Component;

			// Token: 0x0402CD9C RID: 183708
			[FieldOffset(56)]
			public FName AttachSocket;

			// Token: 0x0402CD9D RID: 183709
			[FieldOffset(80)]
			public FTransform Transform;
		}

		// Token: 0x02008FEC RID: 36844
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CD9E RID: 183710
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02008FED RID: 36845
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CD9F RID: 183711
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
