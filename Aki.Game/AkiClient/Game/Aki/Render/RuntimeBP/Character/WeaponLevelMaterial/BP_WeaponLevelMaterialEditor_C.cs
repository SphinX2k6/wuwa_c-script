using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial
{
	// Token: 0x02003DF4 RID: 15860
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/BP_WeaponLevelMaterialEditor.BP_WeaponLevelMaterialEditor_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_WeaponLevelMaterialEditor_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060279AB RID: 162219 RVA: 0x00995DE7 File Offset: 0x00993FE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeaponLevelMaterialEditor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/BP_WeaponLevelMaterialEditor.BP_WeaponLevelMaterialEditor_C");
			}
			return BP_WeaponLevelMaterialEditor_C._ClassPtr;
		}

		// Token: 0x060279AC RID: 162220 RVA: 0x00995E0C File Offset: 0x0099400C
		public BP_WeaponLevelMaterialEditor_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeaponLevelMaterialEditor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060279AD RID: 162221 RVA: 0x00995E34 File Offset: 0x00994034
		[NullableContext(1)]
		public BP_WeaponLevelMaterialEditor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeaponLevelMaterialEditor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x060279AE RID: 162222 RVA: 0x00995E67 File Offset: 0x00994067
		// (set) Token: 0x060279AF RID: 162223 RVA: 0x00995E7B File Offset: 0x0099407B
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x060279B0 RID: 162224 RVA: 0x00995E90 File Offset: 0x00994090
		// (set) Token: 0x060279B1 RID: 162225 RVA: 0x00995EA4 File Offset: 0x009940A4
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x060279B2 RID: 162226 RVA: 0x00995EB9 File Offset: 0x009940B9
		// (set) Token: 0x060279B3 RID: 162227 RVA: 0x00995EC9 File Offset: 0x009940C9
		public unsafe int LevelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponLevelMaterialEditor_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponLevelMaterialEditor_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x060279B4 RID: 162228 RVA: 0x00995EDC File Offset: 0x009940DC
		// (set) Token: 0x060279B5 RID: 162229 RVA: 0x00995F15 File Offset: 0x00994115
		[Nullable(1)]
		public TArray<USkeletalMeshComponent> Components
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)BP_WeaponLevelMaterialEditor_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x060279B6 RID: 162230 RVA: 0x00995F23 File Offset: 0x00994123
		// (set) Token: 0x060279B7 RID: 162231 RVA: 0x00995F37 File Offset: 0x00994137
		public unsafe PD_WeaponLevelMaterialDatas_C Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_WeaponLevelMaterialDatas_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponLevelMaterialEditor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060279B8 RID: 162232 RVA: 0x00995F4C File Offset: 0x0099414C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x060279B9 RID: 162233 RVA: 0x00995F60 File Offset: 0x00994160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060279BA RID: 162234 RVA: 0x00995F74 File Offset: 0x00994174
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060279BB RID: 162235 RVA: 0x00995F8C File Offset: 0x0099418C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponLevelMaterialEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060279BC RID: 162236 RVA: 0x00995FD4 File Offset: 0x009941D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponLevelMaterialEditor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponLevelMaterialEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060279BD RID: 162237 RVA: 0x0099601C File Offset: 0x0099421C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponLevelMaterialEditor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060279BE RID: 162238 RVA: 0x00996064 File Offset: 0x00994264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponLevelMaterialEditor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponLevelMaterialEditor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponLevelMaterialEditor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060279BF RID: 162239 RVA: 0x009960AB File Offset: 0x009942AB
		protected BP_WeaponLevelMaterialEditor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014076 RID: 82038
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/BP_WeaponLevelMaterialEditor.BP_WeaponLevelMaterialEditor_C";

		// Token: 0x04014077 RID: 82039
		private static IntPtr _ClassPtr;

		// Token: 0x04014078 RID: 82040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014079 RID: 82041
		internal static int __PropertyOffset_1;

		// Token: 0x0401407A RID: 82042
		internal static int __PropertyOffset_2;

		// Token: 0x0401407B RID: 82043
		internal static int __PropertyOffset_3;

		// Token: 0x0401407C RID: 82044
		internal static int __PropertyOffset_4;

		// Token: 0x0401407D RID: 82045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _Components;

		// Token: 0x0401407E RID: 82046
		internal static int __PropertyOffset_5;

		// Token: 0x0401407F RID: 82047
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04014080 RID: 82048
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014081 RID: 82049
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014082 RID: 82050
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A253 RID: 41555
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EEE RID: 204526
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A254 RID: 41556
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031EEF RID: 204527
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
