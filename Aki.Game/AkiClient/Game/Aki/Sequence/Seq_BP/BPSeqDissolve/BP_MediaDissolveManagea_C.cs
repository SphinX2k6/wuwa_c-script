using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve
{
	// Token: 0x0200306E RID: 12398
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1577)]
	public class BP_MediaDissolveManagea_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7B4 RID: 120756 RVA: 0x008F8B33 File Offset: 0x008F6D33
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MediaDissolveManagea_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C");
			}
			return BP_MediaDissolveManagea_C._ClassPtr;
		}

		// Token: 0x0601D7B5 RID: 120757 RVA: 0x008F8B58 File Offset: 0x008F6D58
		public BP_MediaDissolveManagea_C() : this(BuiltinUtils.AllocNativeUObject(BP_MediaDissolveManagea_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7B6 RID: 120758 RVA: 0x008F8B80 File Offset: 0x008F6D80
		[NullableContext(1)]
		public BP_MediaDissolveManagea_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MediaDissolveManagea_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0601D7B7 RID: 120759 RVA: 0x008F8BB3 File Offset: 0x008F6DB3
		// (set) Token: 0x0601D7B8 RID: 120760 RVA: 0x008F8BC7 File Offset: 0x008F6DC7
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_KuroPostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0601D7B9 RID: 120761 RVA: 0x008F8BDC File Offset: 0x008F6DDC
		// (set) Token: 0x0601D7BA RID: 120762 RVA: 0x008F8BF0 File Offset: 0x008F6DF0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0601D7BB RID: 120763 RVA: 0x008F8C05 File Offset: 0x008F6E05
		// (set) Token: 0x0601D7BC RID: 120764 RVA: 0x008F8C19 File Offset: 0x008F6E19
		public unsafe UMediaSource MainMediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MainMediaSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MainMediaSource, value);
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0601D7BD RID: 120765 RVA: 0x008F8C2E File Offset: 0x008F6E2E
		// (set) Token: 0x0601D7BE RID: 120766 RVA: 0x008F8C42 File Offset: 0x008F6E42
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0601D7BF RID: 120767 RVA: 0x008F8C57 File Offset: 0x008F6E57
		// (set) Token: 0x0601D7C0 RID: 120768 RVA: 0x008F8C6B File Offset: 0x008F6E6B
		public unsafe UMediaTexture MediaPlayerTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MediaPlayerTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_MediaPlayerTex, value);
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0601D7C1 RID: 120769 RVA: 0x008F8C80 File Offset: 0x008F6E80
		// (set) Token: 0x0601D7C2 RID: 120770 RVA: 0x008F8C94 File Offset: 0x008F6E94
		public unsafe UMaterial PostMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_PostMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_PostMaterial, value);
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0601D7C3 RID: 120771 RVA: 0x008F8CA9 File Offset: 0x008F6EA9
		// (set) Token: 0x0601D7C4 RID: 120772 RVA: 0x008F8CBD File Offset: 0x008F6EBD
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_DynamicMaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_DynamicMaterialInstance, value);
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0601D7C5 RID: 120773 RVA: 0x008F8CD2 File Offset: 0x008F6ED2
		// (set) Token: 0x0601D7C6 RID: 120774 RVA: 0x008F8CE2 File Offset: 0x008F6EE2
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0601D7C7 RID: 120775 RVA: 0x008F8CF3 File Offset: 0x008F6EF3
		// (set) Token: 0x0601D7C8 RID: 120776 RVA: 0x008F8D03 File Offset: 0x008F6F03
		public unsafe float MediaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_MediaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_MediaScale) = value;
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0601D7C9 RID: 120777 RVA: 0x008F8D14 File Offset: 0x008F6F14
		// (set) Token: 0x0601D7CA RID: 120778 RVA: 0x008F8D24 File Offset: 0x008F6F24
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Opacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Opacity) = value;
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0601D7CB RID: 120779 RVA: 0x008F8D35 File Offset: 0x008F6F35
		// (set) Token: 0x0601D7CC RID: 120780 RVA: 0x008F8D45 File Offset: 0x008F6F45
		public unsafe float SphereSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_SphereSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_SphereSize) = value;
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0601D7CD RID: 120781 RVA: 0x008F8D56 File Offset: 0x008F6F56
		// (set) Token: 0x0601D7CE RID: 120782 RVA: 0x008F8D66 File Offset: 0x008F6F66
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0601D7CF RID: 120783 RVA: 0x008F8D77 File Offset: 0x008F6F77
		// (set) Token: 0x0601D7D0 RID: 120784 RVA: 0x008F8D87 File Offset: 0x008F6F87
		public unsafe float OutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_OutSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_OutSpeed) = value;
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0601D7D1 RID: 120785 RVA: 0x008F8D98 File Offset: 0x008F6F98
		// (set) Token: 0x0601D7D2 RID: 120786 RVA: 0x008F8DAC File Offset: 0x008F6FAC
		public unsafe FVector2D CenterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_CenterPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_CenterPos) = value;
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0601D7D3 RID: 120787 RVA: 0x008F8DC1 File Offset: 0x008F6FC1
		// (set) Token: 0x0601D7D4 RID: 120788 RVA: 0x008F8DD1 File Offset: 0x008F6FD1
		public unsafe bool IsMaterialTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsMaterialTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsMaterialTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0601D7D5 RID: 120789 RVA: 0x008F8DE2 File Offset: 0x008F6FE2
		// (set) Token: 0x0601D7D6 RID: 120790 RVA: 0x008F8DF2 File Offset: 0x008F6FF2
		public unsafe bool IsChangeSceneColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsChangeSceneColorTint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsChangeSceneColorTint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0601D7D7 RID: 120791 RVA: 0x008F8E03 File Offset: 0x008F7003
		// (set) Token: 0x0601D7D8 RID: 120792 RVA: 0x008F8E13 File Offset: 0x008F7013
		public unsafe bool Is_Open
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Is_Open) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Is_Open) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0601D7D9 RID: 120793 RVA: 0x008F8E24 File Offset: 0x008F7024
		// (set) Token: 0x0601D7DA RID: 120794 RVA: 0x008F8E34 File Offset: 0x008F7034
		public unsafe bool Sphere_Or_Full_Screen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Sphere_Or_Full_Screen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Sphere_Or_Full_Screen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0601D7DB RID: 120795 RVA: 0x008F8E45 File Offset: 0x008F7045
		// (set) Token: 0x0601D7DC RID: 120796 RVA: 0x008F8E59 File Offset: 0x008F7059
		[Nullable(1)]
		public unsafe string Name
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Name)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0601D7DD RID: 120797 RVA: 0x008F8E6E File Offset: 0x008F706E
		// (set) Token: 0x0601D7DE RID: 120798 RVA: 0x008F8E7E File Offset: 0x008F707E
		public unsafe float FadeinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_FadeinTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_FadeinTime) = value;
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0601D7DF RID: 120799 RVA: 0x008F8E8F File Offset: 0x008F708F
		// (set) Token: 0x0601D7E0 RID: 120800 RVA: 0x008F8E9F File Offset: 0x008F709F
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0601D7E1 RID: 120801 RVA: 0x008F8EB0 File Offset: 0x008F70B0
		// (set) Token: 0x0601D7E2 RID: 120802 RVA: 0x008F8EC0 File Offset: 0x008F70C0
		public unsafe bool IsReadyToPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsReadyToPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_IsReadyToPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D7E3 RID: 120803 RVA: 0x008F8ED4 File Offset: 0x008F70D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void PlayEffect(string Name, FVector2D CenterPos, float MediaScale, float FadeinTime, float FadeOutTime, [Nullable(2)] UMediaSource MediaSource, bool SphereOrFullScreen)
		{
			BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->CenterPos = CenterPos;
			ptr->MediaScale = MediaScale;
			ptr->FadeinTime = FadeinTime;
			ptr->FadeOutTime = FadeOutTime;
			ptr->MediaSource = ((MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
			ptr->SphereOrFullScreen = SphereOrFullScreen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D7E4 RID: 120804 RVA: 0x008F8F70 File Offset: 0x008F7170
		[SkipLocalsInit]
		public unsafe virtual void SetOpacity(UMaterialInstanceDynamic MaterialInstanceDynamic, bool IsOpen)
		{
			BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__SetOpacity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstanceDynamic = ((MaterialInstanceDynamic != null) ? MaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			ptr->IsOpen = IsOpen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__SetOpacity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7E5 RID: 120805 RVA: 0x008F8FCC File Offset: 0x008F71CC
		[SkipLocalsInit]
		public virtual void Set_Post_Material()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__Set_Post_Material_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7E6 RID: 120806 RVA: 0x008F8FE0 File Offset: 0x008F71E0
		[SkipLocalsInit]
		public unsafe virtual void Play(UMediaSource MediaSource, ref UMediaPlayer MediaPlayer)
		{
			BP_MediaDissolveManagea_C.__Play_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__Play_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MediaSource = ((MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
			ref BP_MediaDissolveManagea_C.__Play_FunctionParams ptr2 = ref *ptr;
			UMediaPlayer umediaPlayer = MediaPlayer;
			ptr2.MediaPlayer = ((umediaPlayer != null) ? umediaPlayer.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__Play_NativeFunctionPtr, (void*)ptr);
			MediaPlayer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(ptr->MediaPlayer);
		}

		// Token: 0x0601D7E7 RID: 120807 RVA: 0x008F905A File Offset: 0x008F725A
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7E8 RID: 120808 RVA: 0x008F906E File Offset: 0x008F726E
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7E9 RID: 120809 RVA: 0x008F9082 File Offset: 0x008F7282
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7EA RID: 120810 RVA: 0x008F9096 File Offset: 0x008F7296
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7EB RID: 120811 RVA: 0x008F90AC File Offset: 0x008F72AC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7EC RID: 120812 RVA: 0x008F90F4 File Offset: 0x008F72F4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7ED RID: 120813 RVA: 0x008F913A File Offset: 0x008F733A
		[SkipLocalsInit]
		public virtual void OnVideoEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OnVideoEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7EE RID: 120814 RVA: 0x008F9150 File Offset: 0x008F7350
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7EF RID: 120815 RVA: 0x008F9198 File Offset: 0x008F7398
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7F0 RID: 120816 RVA: 0x008F91DE File Offset: 0x008F73DE
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7F1 RID: 120817 RVA: 0x008F91F2 File Offset: 0x008F73F2
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7F2 RID: 120818 RVA: 0x008F9208 File Offset: 0x008F7408
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void OnMediaOpened(string OpenedUrl)
		{
			BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OpenedUrl), OpenedUrl);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D7F3 RID: 120819 RVA: 0x008F9268 File Offset: 0x008F7468
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void OpenFailed(string FailedUrl)
		{
			BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FailedUrl), FailedUrl);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D7F4 RID: 120820 RVA: 0x008F92C5 File Offset: 0x008F74C5
		protected BP_MediaDissolveManagea_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F864 RID: 63588
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C";

		// Token: 0x0400F865 RID: 63589
		private static IntPtr _ClassPtr;

		// Token: 0x0400F866 RID: 63590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F867 RID: 63591
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x0400F868 RID: 63592
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F869 RID: 63593
		internal static int __PropertyOffset_MainMediaSource;

		// Token: 0x0400F86A RID: 63594
		internal static int __PropertyOffset_MediaPlayer;

		// Token: 0x0400F86B RID: 63595
		internal static int __PropertyOffset_MediaPlayerTex;

		// Token: 0x0400F86C RID: 63596
		internal static int __PropertyOffset_PostMaterial;

		// Token: 0x0400F86D RID: 63597
		internal static int __PropertyOffset_DynamicMaterialInstance;

		// Token: 0x0400F86E RID: 63598
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400F86F RID: 63599
		internal static int __PropertyOffset_MediaScale;

		// Token: 0x0400F870 RID: 63600
		internal static int __PropertyOffset_Opacity;

		// Token: 0x0400F871 RID: 63601
		internal static int __PropertyOffset_SphereSize;

		// Token: 0x0400F872 RID: 63602
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400F873 RID: 63603
		internal static int __PropertyOffset_OutSpeed;

		// Token: 0x0400F874 RID: 63604
		internal static int __PropertyOffset_CenterPos;

		// Token: 0x0400F875 RID: 63605
		internal static int __PropertyOffset_IsMaterialTick;

		// Token: 0x0400F876 RID: 63606
		internal static int __PropertyOffset_IsChangeSceneColorTint;

		// Token: 0x0400F877 RID: 63607
		internal static int __PropertyOffset_Is_Open;

		// Token: 0x0400F878 RID: 63608
		internal static int __PropertyOffset_Sphere_Or_Full_Screen;

		// Token: 0x0400F879 RID: 63609
		internal static int __PropertyOffset_Name;

		// Token: 0x0400F87A RID: 63610
		internal static int __PropertyOffset_FadeinTime;

		// Token: 0x0400F87B RID: 63611
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400F87C RID: 63612
		internal static int __PropertyOffset_IsReadyToPlay;

		// Token: 0x0400F87D RID: 63613
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x0400F87E RID: 63614
		private static IntPtr __SetOpacity_NativeFunctionPtr;

		// Token: 0x0400F87F RID: 63615
		private static IntPtr __Set_Post_Material_NativeFunctionPtr;

		// Token: 0x0400F880 RID: 63616
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x0400F881 RID: 63617
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F882 RID: 63618
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F883 RID: 63619
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F884 RID: 63620
		private static IntPtr __OnVideoEnd_NativeFunctionPtr;

		// Token: 0x0400F885 RID: 63621
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F886 RID: 63622
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400F887 RID: 63623
		private static IntPtr __OnMediaOpened_NativeFunctionPtr;

		// Token: 0x0400F888 RID: 63624
		private static IntPtr __OpenFailed_NativeFunctionPtr;

		// Token: 0x02008D34 RID: 36148
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayEffect_FunctionParams
		{
			// Token: 0x0402C897 RID: 182423
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0402C898 RID: 182424
			[FieldOffset(16)]
			public FVector2D CenterPos;

			// Token: 0x0402C899 RID: 182425
			[FieldOffset(24)]
			public float MediaScale;

			// Token: 0x0402C89A RID: 182426
			[FieldOffset(28)]
			public float FadeinTime;

			// Token: 0x0402C89B RID: 182427
			[FieldOffset(32)]
			public float FadeOutTime;

			// Token: 0x0402C89C RID: 182428
			[FieldOffset(40)]
			public IntPtr MediaSource;

			// Token: 0x0402C89D RID: 182429
			[FieldOffset(48)]
			public bool SphereOrFullScreen;
		}

		// Token: 0x02008D35 RID: 36149
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetOpacity_FunctionParams
		{
			// Token: 0x0402C89E RID: 182430
			[FieldOffset(0)]
			public IntPtr MaterialInstanceDynamic;

			// Token: 0x0402C89F RID: 182431
			[FieldOffset(8)]
			public bool IsOpen;
		}

		// Token: 0x02008D36 RID: 36150
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x0402C8A0 RID: 182432
			[FieldOffset(0)]
			public IntPtr MediaSource;

			// Token: 0x0402C8A1 RID: 182433
			[FieldOffset(8)]
			public IntPtr MediaPlayer;
		}

		// Token: 0x02008D37 RID: 36151
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C8A2 RID: 182434
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D38 RID: 36152
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C8A3 RID: 182435
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D39 RID: 36153
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMediaOpened_FunctionParams
		{
			// Token: 0x0402C8A4 RID: 182436
			[FieldOffset(0)]
			public FString OpenedUrl;
		}

		// Token: 0x02008D3A RID: 36154
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenFailed_FunctionParams
		{
			// Token: 0x0402C8A5 RID: 182437
			[FieldOffset(0)]
			public FString FailedUrl;
		}
	}
}
