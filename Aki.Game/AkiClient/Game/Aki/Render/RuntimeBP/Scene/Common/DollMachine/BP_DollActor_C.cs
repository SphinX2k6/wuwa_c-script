using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x020030CD RID: 12493
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_DollActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBPI_DollActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E108 RID: 123144 RVA: 0x00909E4D File Offset: 0x0090804D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C");
			}
			return BP_DollActor_C._ClassPtr;
		}

		// Token: 0x0601E109 RID: 123145 RVA: 0x00909E74 File Offset: 0x00908074
		public BP_DollActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E10A RID: 123146 RVA: 0x00909E9C File Offset: 0x0090809C
		[NullableContext(1)]
		public BP_DollActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0601E10B RID: 123147 RVA: 0x00909ECF File Offset: 0x009080CF
		// (set) Token: 0x0601E10C RID: 123148 RVA: 0x00909EE3 File Offset: 0x009080E3
		[Nullable(2)]
		public unsafe UChildActorComponent PermanentEffect1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_PermanentEffect1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_PermanentEffect1, value);
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0601E10D RID: 123149 RVA: 0x00909EF8 File Offset: 0x009080F8
		// (set) Token: 0x0601E10E RID: 123150 RVA: 0x00909F0C File Offset: 0x0090810C
		[Nullable(2)]
		public unsafe UChildActorComponent PermanentEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_PermanentEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_PermanentEffect, value);
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0601E10F RID: 123151 RVA: 0x00909F21 File Offset: 0x00908121
		// (set) Token: 0x0601E110 RID: 123152 RVA: 0x00909F35 File Offset: 0x00908135
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0601E111 RID: 123153 RVA: 0x00909F4A File Offset: 0x0090814A
		// (set) Token: 0x0601E112 RID: 123154 RVA: 0x00909F5A File Offset: 0x0090815A
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0601E113 RID: 123155 RVA: 0x00909F6B File Offset: 0x0090816B
		// (set) Token: 0x0601E114 RID: 123156 RVA: 0x00909F80 File Offset: 0x00908180
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> GrabEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_GrabEffect, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_GrabEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0601E115 RID: 123157 RVA: 0x00909FA5 File Offset: 0x009081A5
		// (set) Token: 0x0601E116 RID: 123158 RVA: 0x00909FBA File Offset: 0x009081BA
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> GrabEndlessEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_GrabEndlessEffect, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_GrabEndlessEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0601E117 RID: 123159 RVA: 0x00909FDF File Offset: 0x009081DF
		// (set) Token: 0x0601E118 RID: 123160 RVA: 0x00909FF4 File Offset: 0x009081F4
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> SpawnEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_SpawnEffect, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_SpawnEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0601E119 RID: 123161 RVA: 0x0090A019 File Offset: 0x00908219
		// (set) Token: 0x0601E11A RID: 123162 RVA: 0x0090A029 File Offset: 0x00908229
		public unsafe bool MainDoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_MainDoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_MainDoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0601E11B RID: 123163 RVA: 0x0090A03A File Offset: 0x0090823A
		// (set) Token: 0x0601E11C RID: 123164 RVA: 0x0090A04E File Offset: 0x0090824E
		[Nullable(2)]
		public unsafe UAnimSequence DollIdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_DollIdleAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_DollIdleAnim, value);
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0601E11D RID: 123165 RVA: 0x0090A063 File Offset: 0x00908263
		// (set) Token: 0x0601E11E RID: 123166 RVA: 0x0090A077 File Offset: 0x00908277
		[Nullable(2)]
		public unsafe UAnimSequence DollGrabAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_DollGrabAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_DollGrabAnim, value);
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0601E11F RID: 123167 RVA: 0x0090A08C File Offset: 0x0090828C
		// (set) Token: 0x0601E120 RID: 123168 RVA: 0x0090A0C5 File Offset: 0x009082C5
		[Nullable(1)]
		public OnBeginPlay OnBeginPlay
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnBeginPlay result;
				if ((result = this._OnBeginPlay) == null)
				{
					result = (this._OnBeginPlay = new OnBeginPlay(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_OnBeginPlay, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_OnBeginPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601E121 RID: 123169 RVA: 0x0090A0E8 File Offset: 0x009082E8
		[SkipLocalsInit]
		public unsafe virtual void SetSimulatePhysics(bool Enable)
		{
			BP_DollActor_C.__SetSimulatePhysics_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetSimulatePhysics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DollActor_C.__SetSimulatePhysics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetSimulatePhysics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetSimulatePhysics_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E122 RID: 123170 RVA: 0x0090A12E File Offset: 0x0090832E
		[SkipLocalsInit]
		public virtual void PlayGrabAnim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabAnim_NativeFunctionPtr, null);
		}

		// Token: 0x0601E123 RID: 123171 RVA: 0x0090A144 File Offset: 0x00908344
		[SkipLocalsInit]
		public unsafe virtual void TogglePlayIdleAnim(bool toggle)
		{
			BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayIdleAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->toggle = toggle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayIdleAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E124 RID: 123172 RVA: 0x0090A18C File Offset: 0x0090838C
		[SkipLocalsInit]
		public unsafe virtual void EnableRagdoll(bool Enable)
		{
			BP_DollActor_C.__EnableRagdoll_FunctionParams* ptr = stackalloc BP_DollActor_C.__EnableRagdoll_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_DollActor_C.__EnableRagdoll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__EnableRagdoll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__EnableRagdoll_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E125 RID: 123173 RVA: 0x0090A1D8 File Offset: 0x009083D8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void SetPermanentEffect(bool Visibility, string Reason)
		{
			BP_DollActor_C.__SetPermanentEffect_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetPermanentEffect_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_DollActor_C.__SetPermanentEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visibility = Visibility;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E126 RID: 123174 RVA: 0x0090A23C File Offset: 0x0090843C
		[SkipLocalsInit]
		public unsafe virtual void PlayGrabEffectByLocation(FVectorDouble Location)
		{
			BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E127 RID: 123175 RVA: 0x0090A282 File Offset: 0x00908482
		[SkipLocalsInit]
		public virtual void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601E128 RID: 123176 RVA: 0x0090A296 File Offset: 0x00908496
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E129 RID: 123177 RVA: 0x0090A2AA File Offset: 0x009084AA
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E12A RID: 123178 RVA: 0x0090A2C0 File Offset: 0x009084C0
		[SkipLocalsInit]
		public unsafe virtual void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			BP_DollActor_C.__SetVisible_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DollActor_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E12B RID: 123179 RVA: 0x0090A310 File Offset: 0x00908510
		[SkipLocalsInit]
		public unsafe virtual void PlayGrabEffect(bool IsEndless, FVectorDouble Location)
		{
			BP_DollActor_C.__PlayGrabEffect_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E12C RID: 123180 RVA: 0x0090A35D File Offset: 0x0090855D
		[SkipLocalsInit]
		public virtual void PlaySpawnEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlaySpawnEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601E12D RID: 123181 RVA: 0x0090A374 File Offset: 0x00908574
		[SkipLocalsInit]
		public unsafe virtual void SetPhysicsParameters(float AngularDamping, float LineraDamping)
		{
			BP_DollActor_C.__SetPhysicsParameters_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetPhysicsParameters_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__SetPhysicsParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AngularDamping = AngularDamping;
			ptr->LineraDamping = LineraDamping;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E12E RID: 123182 RVA: 0x0090A3C1 File Offset: 0x009085C1
		[SkipLocalsInit]
		public virtual void ResetPhysics()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__ResetPhysics_NativeFunctionPtr, null);
		}

		// Token: 0x0601E12F RID: 123183 RVA: 0x0090A3D8 File Offset: 0x009085D8
		[SkipLocalsInit]
		public unsafe virtual void TogglePlayShow(bool Toggle, float PlayRate)
		{
			BP_DollActor_C.__TogglePlayShow_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Toggle = Toggle;
			ptr->PlayRate = PlayRate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayShow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E130 RID: 123184 RVA: 0x0090A428 File Offset: 0x00908628
		[SkipLocalsInit]
		public unsafe virtual void TogglePlayGrabAnim(bool Enable, float Rate)
		{
			BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			ptr->Rate = Rate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E131 RID: 123185 RVA: 0x0090A478 File Offset: 0x00908678
		[SkipLocalsInit]
		public unsafe virtual void PlayGrabEffectByTransform(bool IsEndless, FTransformDouble Transform)
		{
			BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E132 RID: 123186 RVA: 0x0090A4C5 File Offset: 0x009086C5
		protected BP_DollActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE3D RID: 65085
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C";

		// Token: 0x0400FE3E RID: 65086
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE3F RID: 65087
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE40 RID: 65088
		public static IntPtr __OnBeginPlay__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FE41 RID: 65089
		internal static int __PropertyOffset_PermanentEffect1;

		// Token: 0x0400FE42 RID: 65090
		internal static int __PropertyOffset_PermanentEffect;

		// Token: 0x0400FE43 RID: 65091
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FE44 RID: 65092
		internal static int __PropertyOffset_Id;

		// Token: 0x0400FE45 RID: 65093
		internal static int __PropertyOffset_GrabEffect;

		// Token: 0x0400FE46 RID: 65094
		internal static int __PropertyOffset_GrabEndlessEffect;

		// Token: 0x0400FE47 RID: 65095
		internal static int __PropertyOffset_SpawnEffect;

		// Token: 0x0400FE48 RID: 65096
		internal static int __PropertyOffset_MainDoll;

		// Token: 0x0400FE49 RID: 65097
		internal static int __PropertyOffset_DollIdleAnim;

		// Token: 0x0400FE4A RID: 65098
		internal static int __PropertyOffset_DollGrabAnim;

		// Token: 0x0400FE4B RID: 65099
		internal static int __PropertyOffset_OnBeginPlay;

		// Token: 0x0400FE4C RID: 65100
		[Nullable(2)]
		private OnBeginPlay _OnBeginPlay;

		// Token: 0x0400FE4D RID: 65101
		private static IntPtr __SetSimulatePhysics_NativeFunctionPtr;

		// Token: 0x0400FE4E RID: 65102
		private static IntPtr __PlayGrabAnim_NativeFunctionPtr;

		// Token: 0x0400FE4F RID: 65103
		private static IntPtr __TogglePlayIdleAnim_NativeFunctionPtr;

		// Token: 0x0400FE50 RID: 65104
		private static IntPtr __EnableRagdoll_NativeFunctionPtr;

		// Token: 0x0400FE51 RID: 65105
		private static IntPtr __SetPermanentEffect_NativeFunctionPtr;

		// Token: 0x0400FE52 RID: 65106
		private static IntPtr __PlayGrabEffectByLocation_NativeFunctionPtr;

		// Token: 0x0400FE53 RID: 65107
		private static IntPtr __PlayTimeEffect_NativeFunctionPtr;

		// Token: 0x0400FE54 RID: 65108
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE55 RID: 65109
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x0400FE56 RID: 65110
		private static IntPtr __PlayGrabEffect_NativeFunctionPtr;

		// Token: 0x0400FE57 RID: 65111
		private static IntPtr __PlaySpawnEffect_NativeFunctionPtr;

		// Token: 0x0400FE58 RID: 65112
		private static IntPtr __SetPhysicsParameters_NativeFunctionPtr;

		// Token: 0x0400FE59 RID: 65113
		private static IntPtr __ResetPhysics_NativeFunctionPtr;

		// Token: 0x0400FE5A RID: 65114
		private static IntPtr __TogglePlayShow_NativeFunctionPtr;

		// Token: 0x0400FE5B RID: 65115
		private static IntPtr __TogglePlayGrabAnim_NativeFunctionPtr;

		// Token: 0x0400FE5C RID: 65116
		private static IntPtr __PlayGrabEffectByTransform_NativeFunctionPtr;

		// Token: 0x02008E0B RID: 36363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSimulatePhysics_FunctionParams
		{
			// Token: 0x0402CA42 RID: 182850
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02008E0C RID: 36364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TogglePlayIdleAnim_FunctionParams
		{
			// Token: 0x0402CA43 RID: 182851
			[FieldOffset(0)]
			public bool toggle;
		}

		// Token: 0x02008E0D RID: 36365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __EnableRagdoll_FunctionParams
		{
			// Token: 0x0402CA44 RID: 182852
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02008E0E RID: 36366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetPermanentEffect_FunctionParams
		{
			// Token: 0x0402CA45 RID: 182853
			[FieldOffset(0)]
			public bool Visibility;

			// Token: 0x0402CA46 RID: 182854
			[FieldOffset(8)]
			public FString Reason;
		}

		// Token: 0x02008E0F RID: 36367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayGrabEffectByLocation_FunctionParams
		{
			// Token: 0x0402CA47 RID: 182855
			[FieldOffset(0)]
			public FVectorDouble Location;
		}

		// Token: 0x02008E10 RID: 36368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x0402CA48 RID: 182856
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x0402CA49 RID: 182857
			[FieldOffset(1)]
			public bool TogglePhysics;
		}

		// Token: 0x02008E11 RID: 36369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayGrabEffect_FunctionParams
		{
			// Token: 0x0402CA4A RID: 182858
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x0402CA4B RID: 182859
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x02008E12 RID: 36370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPhysicsParameters_FunctionParams
		{
			// Token: 0x0402CA4C RID: 182860
			[FieldOffset(0)]
			public float AngularDamping;

			// Token: 0x0402CA4D RID: 182861
			[FieldOffset(4)]
			public float LineraDamping;
		}

		// Token: 0x02008E13 RID: 36371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayShow_FunctionParams
		{
			// Token: 0x0402CA4E RID: 182862
			[FieldOffset(0)]
			public bool Toggle;

			// Token: 0x0402CA4F RID: 182863
			[FieldOffset(4)]
			public float PlayRate;
		}

		// Token: 0x02008E14 RID: 36372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayGrabAnim_FunctionParams
		{
			// Token: 0x0402CA50 RID: 182864
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x0402CA51 RID: 182865
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x02008E15 RID: 36373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayGrabEffectByTransform_FunctionParams
		{
			// Token: 0x0402CA52 RID: 182866
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x0402CA53 RID: 182867
			[FieldOffset(16)]
			public FTransformDouble Transform;
		}
	}
}
