using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedCloth
{
	// Token: 0x02003CD2 RID: 15570
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth.BP_BatchedCloth_C")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2124)]
	public class BP_BatchedCloth_C : AKuroCSStaticBatchCloth, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E97 RID: 151191 RVA: 0x0094BDAC File Offset: 0x00949FAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BatchedCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth.BP_BatchedCloth_C");
			}
			return BP_BatchedCloth_C._ClassPtr;
		}

		// Token: 0x06024E98 RID: 151192 RVA: 0x0094BDD0 File Offset: 0x00949FD0
		public BP_BatchedCloth_C() : this(BuiltinUtils.AllocNativeUObject(BP_BatchedCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E99 RID: 151193 RVA: 0x0094BDF8 File Offset: 0x00949FF8
		[NullableContext(1)]
		public BP_BatchedCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BatchedCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06024E9A RID: 151194 RVA: 0x0094BE2B File Offset: 0x0094A02B
		// (set) Token: 0x06024E9B RID: 151195 RVA: 0x0094BE3F File Offset: 0x0094A03F
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06024E9C RID: 151196 RVA: 0x0094BE54 File Offset: 0x0094A054
		// (set) Token: 0x06024E9D RID: 151197 RVA: 0x0094BE68 File Offset: 0x0094A068
		public unsafe UStaticMeshComponent SM_ClothController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06024E9E RID: 151198 RVA: 0x0094BE7D File Offset: 0x0094A07D
		// (set) Token: 0x06024E9F RID: 151199 RVA: 0x0094BE91 File Offset: 0x0094A091
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06024EA0 RID: 151200 RVA: 0x0094BEA6 File Offset: 0x0094A0A6
		// (set) Token: 0x06024EA1 RID: 151201 RVA: 0x0094BEB6 File Offset: 0x0094A0B6
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x06024EA2 RID: 151202 RVA: 0x0094BEC7 File Offset: 0x0094A0C7
		// (set) Token: 0x06024EA3 RID: 151203 RVA: 0x0094BED7 File Offset: 0x0094A0D7
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x06024EA4 RID: 151204 RVA: 0x0094BEE8 File Offset: 0x0094A0E8
		// (set) Token: 0x06024EA5 RID: 151205 RVA: 0x0094BEFC File Offset: 0x0094A0FC
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x06024EA6 RID: 151206 RVA: 0x0094BF11 File Offset: 0x0094A111
		// (set) Token: 0x06024EA7 RID: 151207 RVA: 0x0094BF25 File Offset: 0x0094A125
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x06024EA8 RID: 151208 RVA: 0x0094BF3A File Offset: 0x0094A13A
		// (set) Token: 0x06024EA9 RID: 151209 RVA: 0x0094BF4A File Offset: 0x0094A14A
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x06024EAA RID: 151210 RVA: 0x0094BF5B File Offset: 0x0094A15B
		// (set) Token: 0x06024EAB RID: 151211 RVA: 0x0094BF6B File Offset: 0x0094A16B
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06024EAC RID: 151212 RVA: 0x0094BF7C File Offset: 0x0094A17C
		// (set) Token: 0x06024EAD RID: 151213 RVA: 0x0094BF8C File Offset: 0x0094A18C
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x06024EAE RID: 151214 RVA: 0x0094BF9D File Offset: 0x0094A19D
		// (set) Token: 0x06024EAF RID: 151215 RVA: 0x0094BFAD File Offset: 0x0094A1AD
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x06024EB0 RID: 151216 RVA: 0x0094BFBE File Offset: 0x0094A1BE
		// (set) Token: 0x06024EB1 RID: 151217 RVA: 0x0094BFCE File Offset: 0x0094A1CE
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x06024EB2 RID: 151218 RVA: 0x0094BFDF File Offset: 0x0094A1DF
		// (set) Token: 0x06024EB3 RID: 151219 RVA: 0x0094BFEF File Offset: 0x0094A1EF
		public unsafe bool debugWindField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x06024EB4 RID: 151220 RVA: 0x0094C000 File Offset: 0x0094A200
		// (set) Token: 0x06024EB5 RID: 151221 RVA: 0x0094C014 File Offset: 0x0094A214
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x06024EB6 RID: 151222 RVA: 0x0094C029 File Offset: 0x0094A229
		// (set) Token: 0x06024EB7 RID: 151223 RVA: 0x0094C03D File Offset: 0x0094A23D
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x06024EB8 RID: 151224 RVA: 0x0094C052 File Offset: 0x0094A252
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawParticlesOffline_2s_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__DrawParticlesOffline_2s__NativeFunctionPtr, null);
		}

		// Token: 0x06024EB9 RID: 151225 RVA: 0x0094C066 File Offset: 0x0094A266
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024EBA RID: 151226 RVA: 0x0094C07A File Offset: 0x0094A27A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024EBB RID: 151227 RVA: 0x0094C08F File Offset: 0x0094A28F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024EBC RID: 151228 RVA: 0x0094C0A3 File Offset: 0x0094A2A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024EBD RID: 151229 RVA: 0x0094C0B8 File Offset: 0x0094A2B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BatchedCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EBE RID: 151230 RVA: 0x0094C100 File Offset: 0x0094A300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BatchedCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024EBF RID: 151231 RVA: 0x0094C148 File Offset: 0x0094A348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EC0 RID: 151232 RVA: 0x0094C194 File Offset: 0x0094A394
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BatchedCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024EC1 RID: 151233 RVA: 0x0094C1E0 File Offset: 0x0094A3E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EC2 RID: 151234 RVA: 0x0094C29C File Offset: 0x0094A49C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EC3 RID: 151235 RVA: 0x0094C325 File Offset: 0x0094A525
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024EC4 RID: 151236 RVA: 0x0094C33C File Offset: 0x0094A53C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BatchedCloth_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BatchedCloth_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BatchedCloth_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EC5 RID: 151237 RVA: 0x0094C39F File Offset: 0x0094A59F
		protected BP_BatchedCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125A5 RID: 75173
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth.BP_BatchedCloth_C";

		// Token: 0x040125A6 RID: 75174
		private static IntPtr _ClassPtr;

		// Token: 0x040125A7 RID: 75175
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125A8 RID: 75176
		internal static int __PropertyOffset_1;

		// Token: 0x040125A9 RID: 75177
		internal static int __PropertyOffset_2;

		// Token: 0x040125AA RID: 75178
		internal static int __PropertyOffset_3;

		// Token: 0x040125AB RID: 75179
		internal static int __PropertyOffset_4;

		// Token: 0x040125AC RID: 75180
		internal static int __PropertyOffset_5;

		// Token: 0x040125AD RID: 75181
		internal static int __PropertyOffset_6;

		// Token: 0x040125AE RID: 75182
		internal static int __PropertyOffset_7;

		// Token: 0x040125AF RID: 75183
		internal static int __PropertyOffset_8;

		// Token: 0x040125B0 RID: 75184
		internal static int __PropertyOffset_9;

		// Token: 0x040125B1 RID: 75185
		internal static int __PropertyOffset_10;

		// Token: 0x040125B2 RID: 75186
		internal static int __PropertyOffset_11;

		// Token: 0x040125B3 RID: 75187
		internal static int __PropertyOffset_12;

		// Token: 0x040125B4 RID: 75188
		internal static int __PropertyOffset_13;

		// Token: 0x040125B5 RID: 75189
		internal static int __PropertyOffset_14;

		// Token: 0x040125B6 RID: 75190
		internal static int __PropertyOffset_15;

		// Token: 0x040125B7 RID: 75191
		private static IntPtr __DrawParticlesOffline_2s__NativeFunctionPtr;

		// Token: 0x040125B8 RID: 75192
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040125B9 RID: 75193
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040125BA RID: 75194
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040125BB RID: 75195
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040125BC RID: 75196
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125BD RID: 75197
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125BE RID: 75198
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040125BF RID: 75199
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009F8A RID: 40842
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319AC RID: 203180
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F8B RID: 40843
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040319AD RID: 203181
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F8C RID: 40844
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319AE RID: 203182
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319AF RID: 203183
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319B0 RID: 203184
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319B1 RID: 203185
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040319B2 RID: 203186
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040319B3 RID: 203187
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F8D RID: 40845
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319B4 RID: 203188
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319B5 RID: 203189
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319B6 RID: 203190
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319B7 RID: 203191
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F8E RID: 40846
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040319B8 RID: 203192
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040319B9 RID: 203193
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040319BA RID: 203194
			[FieldOffset(32)]
			public int Id;
		}
	}
}
