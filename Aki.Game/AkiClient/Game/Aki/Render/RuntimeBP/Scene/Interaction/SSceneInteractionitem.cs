using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C3 RID: 12483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 529)]
	public class SSceneInteractionitem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E02F RID: 122927 RVA: 0x009085C0 File Offset: 0x009067C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionitem._ScriptStructPtr != 0) ? SSceneInteractionitem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem", ref SSceneInteractionitem._ScriptStructPtr);
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0601E030 RID: 122928 RVA: 0x009085E4 File Offset: 0x009067E4
		// (set) Token: 0x0601E031 RID: 122929 RVA: 0x009085F8 File Offset: 0x009067F8
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneInteractionitem.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneInteractionitem.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0601E032 RID: 122930 RVA: 0x00908610 File Offset: 0x00906810
		// (set) Token: 0x0601E033 RID: 122931 RVA: 0x00908653 File Offset: 0x00906853
		public SSceneInteractionSequence Sequence
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionSequence result;
				if ((result = this._Sequence) == null)
				{
					result = (this._Sequence = new SSceneInteractionSequence(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_Sequence, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionSequence.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_Sequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0601E034 RID: 122932 RVA: 0x00908674 File Offset: 0x00906874
		// (set) Token: 0x0601E035 RID: 122933 RVA: 0x009086B7 File Offset: 0x009068B7
		public SSceneInteractionMontage AnimMontage
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionMontage result;
				if ((result = this._AnimMontage) == null)
				{
					result = (this._AnimMontage = new SSceneInteractionMontage(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_AnimMontage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionMontage.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_AnimMontage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0601E036 RID: 122934 RVA: 0x009086D8 File Offset: 0x009068D8
		// (set) Token: 0x0601E037 RID: 122935 RVA: 0x0090871B File Offset: 0x0090691B
		public TArray<BP_EffectActor_C> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_Effects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0601E038 RID: 122936 RVA: 0x0090872C File Offset: 0x0090692C
		// (set) Token: 0x0601E039 RID: 122937 RVA: 0x0090876F File Offset: 0x0090696F
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_Actors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0601E03A RID: 122938 RVA: 0x00908780 File Offset: 0x00906980
		// (set) Token: 0x0601E03B RID: 122939 RVA: 0x009087C3 File Offset: 0x009069C3
		public TArray<AActor> HideActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HideActors) == null)
				{
					result = (this._HideActors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_HideActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HideActors.CopyAssign(value);
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0601E03C RID: 122940 RVA: 0x009087D4 File Offset: 0x009069D4
		// (set) Token: 0x0601E03D RID: 122941 RVA: 0x00908817 File Offset: 0x00906A17
		public TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> TransitionMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> result;
				if ((result = this._TransitionMap) == null)
				{
					result = (this._TransitionMap = new TMap<EKuroSceneInteractionState, EKuroSceneInteractionState>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_TransitionMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionMap.CopyAssign(value);
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0601E03E RID: 122942 RVA: 0x00908828 File Offset: 0x00906A28
		// (set) Token: 0x0601E03F RID: 122943 RVA: 0x0090886B File Offset: 0x00906A6B
		public TArray<SSceneInteractionMaterialController> MaterialControllers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionMaterialController> result;
				if ((result = this._MaterialControllers) == null)
				{
					result = (this._MaterialControllers = new TArray<SSceneInteractionMaterialController>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_MaterialControllers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialControllers.CopyAssign(value);
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0601E040 RID: 122944 RVA: 0x0090887C File Offset: 0x00906A7C
		// (set) Token: 0x0601E041 RID: 122945 RVA: 0x009088BF File Offset: 0x00906ABF
		public SSceneInteractionAudio AkEvent
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionAudio result;
				if ((result = this._AkEvent) == null)
				{
					result = (this._AkEvent = new SSceneInteractionAudio(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_AkEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionAudio.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_AkEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0601E042 RID: 122946 RVA: 0x009088E0 File Offset: 0x00906AE0
		// (set) Token: 0x0601E043 RID: 122947 RVA: 0x00908923 File Offset: 0x00906B23
		public TArray<SStateBasedEffect> StateBasedEffect
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SStateBasedEffect> result;
				if ((result = this._StateBasedEffect) == null)
				{
					result = (this._StateBasedEffect = new TArray<SStateBasedEffect>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_StateBasedEffect, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StateBasedEffect.CopyAssign(value);
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0601E044 RID: 122948 RVA: 0x00908931 File Offset: 0x00906B31
		// (set) Token: 0x0601E045 RID: 122949 RVA: 0x00908941 File Offset: 0x00906B41
		public unsafe bool IsForceSetState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_IsForceSetState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_IsForceSetState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0601E046 RID: 122950 RVA: 0x00908952 File Offset: 0x00906B52
		// (set) Token: 0x0601E047 RID: 122951 RVA: 0x00908966 File Offset: 0x00906B66
		[Nullable(2)]
		public unsafe PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_CharacterDataGroupForOrgan);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_CharacterDataGroupForOrgan, value);
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0601E048 RID: 122952 RVA: 0x0090897C File Offset: 0x00906B7C
		// (set) Token: 0x0601E049 RID: 122953 RVA: 0x009089BF File Offset: 0x00906BBF
		public TArray<SSceneInteractionCrossStateEffect> CrossStateEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionCrossStateEffect> result;
				if ((result = this._CrossStateEffects) == null)
				{
					result = (this._CrossStateEffects = new TArray<SSceneInteractionCrossStateEffect>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_CrossStateEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CrossStateEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0601E04A RID: 122954 RVA: 0x009089CD File Offset: 0x00906BCD
		// (set) Token: 0x0601E04B RID: 122955 RVA: 0x009089DD File Offset: 0x00906BDD
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_TransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_TransitionTime) = value;
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0601E04C RID: 122956 RVA: 0x009089EE File Offset: 0x00906BEE
		// (set) Token: 0x0601E04D RID: 122957 RVA: 0x009089FE File Offset: 0x00906BFE
		public unsafe bool NeedExpressionAnyway
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_NeedExpressionAnyway) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_NeedExpressionAnyway) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0601E04E RID: 122958 RVA: 0x00908A0F File Offset: 0x00906C0F
		// (set) Token: 0x0601E04F RID: 122959 RVA: 0x00908A23 File Offset: 0x00906C23
		[Nullable(2)]
		public unsafe BP_MaterialRuntimeParUpdate_C BP_MaterialRuntimeParUpdate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MaterialRuntimeParUpdate_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_BP_MaterialRuntimeParUpdate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_BP_MaterialRuntimeParUpdate, value);
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0601E050 RID: 122960 RVA: 0x00908A38 File Offset: 0x00906C38
		// (set) Token: 0x0601E051 RID: 122961 RVA: 0x00908A7B File Offset: 0x00906C7B
		public SSceneInteractionActorSkeletalMeshDestructible SkeletalMeshDestructible
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionActorSkeletalMeshDestructible result;
				if ((result = this._SkeletalMeshDestructible) == null)
				{
					result = (this._SkeletalMeshDestructible = new SSceneInteractionActorSkeletalMeshDestructible(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_SkeletalMeshDestructible, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionActorSkeletalMeshDestructible.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_SkeletalMeshDestructible, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0601E052 RID: 122962 RVA: 0x00908A9C File Offset: 0x00906C9C
		// (set) Token: 0x0601E053 RID: 122963 RVA: 0x00908ADF File Offset: 0x00906CDF
		public TMap<AActor, FCollisionProfileName> EnterStateActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._EnterStateActorCollisionProfile) == null)
				{
					result = (this._EnterStateActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_EnterStateActorCollisionProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnterStateActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0601E054 RID: 122964 RVA: 0x00908AF0 File Offset: 0x00906CF0
		// (set) Token: 0x0601E055 RID: 122965 RVA: 0x00908B33 File Offset: 0x00906D33
		public TMap<AActor, FCollisionProfileName> ExitStateActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._ExitStateActorCollisionProfile) == null)
				{
					result = (this._ExitStateActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_ExitStateActorCollisionProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExitStateActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0601E056 RID: 122966 RVA: 0x00908B41 File Offset: 0x00906D41
		// (set) Token: 0x0601E057 RID: 122967 RVA: 0x00908B51 File Offset: 0x00906D51
		public unsafe bool WaitForPlayableFinished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_WaitForPlayableFinished) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_WaitForPlayableFinished) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E058 RID: 122968 RVA: 0x00908B62 File Offset: 0x00906D62
		public SSceneInteractionitem()
		{
		}

		// Token: 0x0601E059 RID: 122969 RVA: 0x00908B6A File Offset: 0x00906D6A
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionitem.StaticStruct();
		}

		// Token: 0x0601E05A RID: 122970 RVA: 0x00908B76 File Offset: 0x00906D76
		[NullableContext(2)]
		public SSceneInteractionitem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E05B RID: 122971 RVA: 0x00908B80 File Offset: 0x00906D80
		public SSceneInteractionitem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E05C RID: 122972 RVA: 0x00908B8B File Offset: 0x00906D8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionitem(Pointer, false, true);
		}

		// Token: 0x0601E05D RID: 122973 RVA: 0x00908B95 File Offset: 0x00906D95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionitem(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDBB RID: 64955
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem";

		// Token: 0x0400FDBC RID: 64956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDBD RID: 64957
		internal static int __PropertyOffset_Name;

		// Token: 0x0400FDBE RID: 64958
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0400FDBF RID: 64959
		[Nullable(2)]
		private SSceneInteractionSequence _Sequence;

		// Token: 0x0400FDC0 RID: 64960
		internal static int __PropertyOffset_AnimMontage;

		// Token: 0x0400FDC1 RID: 64961
		[Nullable(2)]
		private SSceneInteractionMontage _AnimMontage;

		// Token: 0x0400FDC2 RID: 64962
		internal static int __PropertyOffset_Effects;

		// Token: 0x0400FDC3 RID: 64963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _Effects;

		// Token: 0x0400FDC4 RID: 64964
		internal static int __PropertyOffset_Actors;

		// Token: 0x0400FDC5 RID: 64965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x0400FDC6 RID: 64966
		internal static int __PropertyOffset_HideActors;

		// Token: 0x0400FDC7 RID: 64967
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HideActors;

		// Token: 0x0400FDC8 RID: 64968
		internal static int __PropertyOffset_TransitionMap;

		// Token: 0x0400FDC9 RID: 64969
		[Nullable(2)]
		private TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> _TransitionMap;

		// Token: 0x0400FDCA RID: 64970
		internal static int __PropertyOffset_MaterialControllers;

		// Token: 0x0400FDCB RID: 64971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionMaterialController> _MaterialControllers;

		// Token: 0x0400FDCC RID: 64972
		internal static int __PropertyOffset_AkEvent;

		// Token: 0x0400FDCD RID: 64973
		[Nullable(2)]
		private SSceneInteractionAudio _AkEvent;

		// Token: 0x0400FDCE RID: 64974
		internal static int __PropertyOffset_StateBasedEffect;

		// Token: 0x0400FDCF RID: 64975
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SStateBasedEffect> _StateBasedEffect;

		// Token: 0x0400FDD0 RID: 64976
		internal static int __PropertyOffset_IsForceSetState;

		// Token: 0x0400FDD1 RID: 64977
		internal static int __PropertyOffset_CharacterDataGroupForOrgan;

		// Token: 0x0400FDD2 RID: 64978
		internal static int __PropertyOffset_CrossStateEffects;

		// Token: 0x0400FDD3 RID: 64979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionCrossStateEffect> _CrossStateEffects;

		// Token: 0x0400FDD4 RID: 64980
		internal static int __PropertyOffset_TransitionTime;

		// Token: 0x0400FDD5 RID: 64981
		internal static int __PropertyOffset_NeedExpressionAnyway;

		// Token: 0x0400FDD6 RID: 64982
		internal static int __PropertyOffset_BP_MaterialRuntimeParUpdate;

		// Token: 0x0400FDD7 RID: 64983
		internal static int __PropertyOffset_SkeletalMeshDestructible;

		// Token: 0x0400FDD8 RID: 64984
		[Nullable(2)]
		private SSceneInteractionActorSkeletalMeshDestructible _SkeletalMeshDestructible;

		// Token: 0x0400FDD9 RID: 64985
		internal static int __PropertyOffset_EnterStateActorCollisionProfile;

		// Token: 0x0400FDDA RID: 64986
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _EnterStateActorCollisionProfile;

		// Token: 0x0400FDDB RID: 64987
		internal static int __PropertyOffset_ExitStateActorCollisionProfile;

		// Token: 0x0400FDDC RID: 64988
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _ExitStateActorCollisionProfile;

		// Token: 0x0400FDDD RID: 64989
		internal static int __PropertyOffset_WaitForPlayableFinished;
	}
}
