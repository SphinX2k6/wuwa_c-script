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
	// Token: 0x02003B49 RID: 15177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 529)]
	public class SSceneInteractionitem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021983 RID: 137603 RVA: 0x008F05E6 File Offset: 0x008EE7E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionitem._ScriptStructPtr != 0) ? SSceneInteractionitem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem", ref SSceneInteractionitem._ScriptStructPtr);
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x06021984 RID: 137604 RVA: 0x008F060A File Offset: 0x008EE80A
		// (set) Token: 0x06021985 RID: 137605 RVA: 0x008F061E File Offset: 0x008EE81E
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneInteractionitem.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneInteractionitem.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x06021986 RID: 137606 RVA: 0x008F0634 File Offset: 0x008EE834
		// (set) Token: 0x06021987 RID: 137607 RVA: 0x008F0677 File Offset: 0x008EE877
		public SSceneInteractionSequence Sequence
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionSequence result;
				if ((result = this._Sequence) == null)
				{
					result = (this._Sequence = new SSceneInteractionSequence(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionSequence.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x06021988 RID: 137608 RVA: 0x008F0698 File Offset: 0x008EE898
		// (set) Token: 0x06021989 RID: 137609 RVA: 0x008F06DB File Offset: 0x008EE8DB
		public SSceneInteractionMontage AnimMontage
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionMontage result;
				if ((result = this._AnimMontage) == null)
				{
					result = (this._AnimMontage = new SSceneInteractionMontage(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionMontage.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0602198A RID: 137610 RVA: 0x008F06FC File Offset: 0x008EE8FC
		// (set) Token: 0x0602198B RID: 137611 RVA: 0x008F073F File Offset: 0x008EE93F
		public TArray<BP_EffectActor_C> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0602198C RID: 137612 RVA: 0x008F0750 File Offset: 0x008EE950
		// (set) Token: 0x0602198D RID: 137613 RVA: 0x008F0793 File Offset: 0x008EE993
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0602198E RID: 137614 RVA: 0x008F07A4 File Offset: 0x008EE9A4
		// (set) Token: 0x0602198F RID: 137615 RVA: 0x008F07E7 File Offset: 0x008EE9E7
		public TArray<AActor> HideActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HideActors) == null)
				{
					result = (this._HideActors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HideActors.CopyAssign(value);
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x06021990 RID: 137616 RVA: 0x008F07F8 File Offset: 0x008EE9F8
		// (set) Token: 0x06021991 RID: 137617 RVA: 0x008F083B File Offset: 0x008EEA3B
		public TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> TransitionMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> result;
				if ((result = this._TransitionMap) == null)
				{
					result = (this._TransitionMap = new TMap<EKuroSceneInteractionState, EKuroSceneInteractionState>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionMap.CopyAssign(value);
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x06021992 RID: 137618 RVA: 0x008F084C File Offset: 0x008EEA4C
		// (set) Token: 0x06021993 RID: 137619 RVA: 0x008F088F File Offset: 0x008EEA8F
		public TArray<SSceneInteractionMaterialController> MaterialControllers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionMaterialController> result;
				if ((result = this._MaterialControllers) == null)
				{
					result = (this._MaterialControllers = new TArray<SSceneInteractionMaterialController>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialControllers.CopyAssign(value);
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x06021994 RID: 137620 RVA: 0x008F08A0 File Offset: 0x008EEAA0
		// (set) Token: 0x06021995 RID: 137621 RVA: 0x008F08E3 File Offset: 0x008EEAE3
		public SSceneInteractionAudio AkEvent
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionAudio result;
				if ((result = this._AkEvent) == null)
				{
					result = (this._AkEvent = new SSceneInteractionAudio(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionAudio.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x06021996 RID: 137622 RVA: 0x008F0904 File Offset: 0x008EEB04
		// (set) Token: 0x06021997 RID: 137623 RVA: 0x008F0947 File Offset: 0x008EEB47
		public TArray<SStateBasedEffect> StateBasedEffect
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SStateBasedEffect> result;
				if ((result = this._StateBasedEffect) == null)
				{
					result = (this._StateBasedEffect = new TArray<SStateBasedEffect>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StateBasedEffect.CopyAssign(value);
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x06021998 RID: 137624 RVA: 0x008F0955 File Offset: 0x008EEB55
		// (set) Token: 0x06021999 RID: 137625 RVA: 0x008F0965 File Offset: 0x008EEB65
		public unsafe bool IsForceSetState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0602199A RID: 137626 RVA: 0x008F0976 File Offset: 0x008EEB76
		// (set) Token: 0x0602199B RID: 137627 RVA: 0x008F098A File Offset: 0x008EEB8A
		[Nullable(2)]
		public unsafe PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0602199C RID: 137628 RVA: 0x008F09A0 File Offset: 0x008EEBA0
		// (set) Token: 0x0602199D RID: 137629 RVA: 0x008F09E3 File Offset: 0x008EEBE3
		public TArray<SSceneInteractionitemIndestructibleEffectsParameters> IndestructibleEffectsParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionitemIndestructibleEffectsParameters> result;
				if ((result = this._IndestructibleEffectsParameters) == null)
				{
					result = (this._IndestructibleEffectsParameters = new TArray<SSceneInteractionitemIndestructibleEffectsParameters>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IndestructibleEffectsParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0602199E RID: 137630 RVA: 0x008F09F4 File Offset: 0x008EEBF4
		// (set) Token: 0x0602199F RID: 137631 RVA: 0x008F0A37 File Offset: 0x008EEC37
		public TArray<SSceneInteractionCrossStateEffect> CrossStateEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionCrossStateEffect> result;
				if ((result = this._CrossStateEffects) == null)
				{
					result = (this._CrossStateEffects = new TArray<SSceneInteractionCrossStateEffect>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CrossStateEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x060219A0 RID: 137632 RVA: 0x008F0A45 File Offset: 0x008EEC45
		// (set) Token: 0x060219A1 RID: 137633 RVA: 0x008F0A55 File Offset: 0x008EEC55
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x060219A2 RID: 137634 RVA: 0x008F0A66 File Offset: 0x008EEC66
		// (set) Token: 0x060219A3 RID: 137635 RVA: 0x008F0A76 File Offset: 0x008EEC76
		public unsafe bool NeedExpressionAnyway
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x060219A4 RID: 137636 RVA: 0x008F0A87 File Offset: 0x008EEC87
		// (set) Token: 0x060219A5 RID: 137637 RVA: 0x008F0A9B File Offset: 0x008EEC9B
		[Nullable(2)]
		public unsafe BP_MaterialRuntimeParUpdate_C BP_MaterialRuntimeParUpdate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MaterialRuntimeParUpdate_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionitem.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x060219A6 RID: 137638 RVA: 0x008F0AB0 File Offset: 0x008EECB0
		// (set) Token: 0x060219A7 RID: 137639 RVA: 0x008F0AF3 File Offset: 0x008EECF3
		public SSceneInteractionActorSkeletalMeshDestructible SkeletalMeshDestructible
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionActorSkeletalMeshDestructible result;
				if ((result = this._SkeletalMeshDestructible) == null)
				{
					result = (this._SkeletalMeshDestructible = new SSceneInteractionActorSkeletalMeshDestructible(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionActorSkeletalMeshDestructible.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x060219A8 RID: 137640 RVA: 0x008F0B14 File Offset: 0x008EED14
		// (set) Token: 0x060219A9 RID: 137641 RVA: 0x008F0B57 File Offset: 0x008EED57
		public TMap<AActor, FCollisionProfileName> EnterStateActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._EnterStateActorCollisionProfile) == null)
				{
					result = (this._EnterStateActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnterStateActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x060219AA RID: 137642 RVA: 0x008F0B68 File Offset: 0x008EED68
		// (set) Token: 0x060219AB RID: 137643 RVA: 0x008F0BAB File Offset: 0x008EEDAB
		public TMap<AActor, FCollisionProfileName> ExitStateActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._ExitStateActorCollisionProfile) == null)
				{
					result = (this._ExitStateActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_19, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExitStateActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x060219AC RID: 137644 RVA: 0x008F0BB9 File Offset: 0x008EEDB9
		// (set) Token: 0x060219AD RID: 137645 RVA: 0x008F0BC9 File Offset: 0x008EEDC9
		public unsafe bool WaitForPlayableFinished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitem.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x060219AE RID: 137646 RVA: 0x008F0BDA File Offset: 0x008EEDDA
		public SSceneInteractionitem()
		{
		}

		// Token: 0x060219AF RID: 137647 RVA: 0x008F0BE4 File Offset: 0x008EEDE4
		public SSceneInteractionitem(string Name, SSceneInteractionSequence Sequence, SSceneInteractionMontage AnimMontage, TArray<BP_EffectActor_C> Effects, TArray<AActor> Actors, TArray<AActor> HideActors, TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> TransitionMap, TArray<SSceneInteractionMaterialController> MaterialControllers, SSceneInteractionAudio AkEvent, TArray<SStateBasedEffect> StateBasedEffect, bool IsForceSetState, PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan, TArray<SSceneInteractionitemIndestructibleEffectsParameters> IndestructibleEffectsParameters, TArray<SSceneInteractionCrossStateEffect> CrossStateEffects, float TransitionTime, bool NeedExpressionAnyway, BP_MaterialRuntimeParUpdate_C BP_MaterialRuntimeParUpdate, SSceneInteractionActorSkeletalMeshDestructible SkeletalMeshDestructible, TMap<AActor, FCollisionProfileName> EnterStateActorCollisionProfile, TMap<AActor, FCollisionProfileName> ExitStateActorCollisionProfile, bool WaitForPlayableFinished)
		{
			this.Name = Name;
			this.Sequence = Sequence;
			this.AnimMontage = AnimMontage;
			this.Effects = Effects;
			this.Actors = Actors;
			this.HideActors = HideActors;
			this.TransitionMap = TransitionMap;
			this.MaterialControllers = MaterialControllers;
			this.AkEvent = AkEvent;
			this.StateBasedEffect = StateBasedEffect;
			this.IsForceSetState = IsForceSetState;
			this.CharacterDataGroupForOrgan = CharacterDataGroupForOrgan;
			this.IndestructibleEffectsParameters = IndestructibleEffectsParameters;
			this.CrossStateEffects = CrossStateEffects;
			this.TransitionTime = TransitionTime;
			this.NeedExpressionAnyway = NeedExpressionAnyway;
			this.BP_MaterialRuntimeParUpdate = BP_MaterialRuntimeParUpdate;
			this.SkeletalMeshDestructible = SkeletalMeshDestructible;
			this.EnterStateActorCollisionProfile = EnterStateActorCollisionProfile;
			this.ExitStateActorCollisionProfile = ExitStateActorCollisionProfile;
			this.WaitForPlayableFinished = WaitForPlayableFinished;
		}

		// Token: 0x060219B0 RID: 137648 RVA: 0x008F0C9C File Offset: 0x008EEE9C
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionitem.StaticStruct();
		}

		// Token: 0x060219B1 RID: 137649 RVA: 0x008F0CA8 File Offset: 0x008EEEA8
		[NullableContext(2)]
		public SSceneInteractionitem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219B2 RID: 137650 RVA: 0x008F0CB2 File Offset: 0x008EEEB2
		public SSceneInteractionitem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219B3 RID: 137651 RVA: 0x008F0CBD File Offset: 0x008EEEBD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionitem(Pointer, false, true);
		}

		// Token: 0x060219B4 RID: 137652 RVA: 0x008F0CC7 File Offset: 0x008EEEC7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionitem(Pointer, MemoryOwner);
		}

		// Token: 0x04010609 RID: 67081
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitem.SSceneInteractionitem";

		// Token: 0x0401060A RID: 67082
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401060B RID: 67083
		internal static int __PropertyOffset_0;

		// Token: 0x0401060C RID: 67084
		internal static int __PropertyOffset_1;

		// Token: 0x0401060D RID: 67085
		[Nullable(2)]
		private SSceneInteractionSequence _Sequence;

		// Token: 0x0401060E RID: 67086
		internal static int __PropertyOffset_2;

		// Token: 0x0401060F RID: 67087
		[Nullable(2)]
		private SSceneInteractionMontage _AnimMontage;

		// Token: 0x04010610 RID: 67088
		internal static int __PropertyOffset_3;

		// Token: 0x04010611 RID: 67089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _Effects;

		// Token: 0x04010612 RID: 67090
		internal static int __PropertyOffset_4;

		// Token: 0x04010613 RID: 67091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x04010614 RID: 67092
		internal static int __PropertyOffset_5;

		// Token: 0x04010615 RID: 67093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HideActors;

		// Token: 0x04010616 RID: 67094
		internal static int __PropertyOffset_6;

		// Token: 0x04010617 RID: 67095
		[Nullable(2)]
		private TMap<EKuroSceneInteractionState, EKuroSceneInteractionState> _TransitionMap;

		// Token: 0x04010618 RID: 67096
		internal static int __PropertyOffset_7;

		// Token: 0x04010619 RID: 67097
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionMaterialController> _MaterialControllers;

		// Token: 0x0401061A RID: 67098
		internal static int __PropertyOffset_8;

		// Token: 0x0401061B RID: 67099
		[Nullable(2)]
		private SSceneInteractionAudio _AkEvent;

		// Token: 0x0401061C RID: 67100
		internal static int __PropertyOffset_9;

		// Token: 0x0401061D RID: 67101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SStateBasedEffect> _StateBasedEffect;

		// Token: 0x0401061E RID: 67102
		internal static int __PropertyOffset_10;

		// Token: 0x0401061F RID: 67103
		internal static int __PropertyOffset_11;

		// Token: 0x04010620 RID: 67104
		internal static int __PropertyOffset_12;

		// Token: 0x04010621 RID: 67105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionitemIndestructibleEffectsParameters> _IndestructibleEffectsParameters;

		// Token: 0x04010622 RID: 67106
		internal static int __PropertyOffset_13;

		// Token: 0x04010623 RID: 67107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionCrossStateEffect> _CrossStateEffects;

		// Token: 0x04010624 RID: 67108
		internal static int __PropertyOffset_14;

		// Token: 0x04010625 RID: 67109
		internal static int __PropertyOffset_15;

		// Token: 0x04010626 RID: 67110
		internal static int __PropertyOffset_16;

		// Token: 0x04010627 RID: 67111
		internal static int __PropertyOffset_17;

		// Token: 0x04010628 RID: 67112
		[Nullable(2)]
		private SSceneInteractionActorSkeletalMeshDestructible _SkeletalMeshDestructible;

		// Token: 0x04010629 RID: 67113
		internal static int __PropertyOffset_18;

		// Token: 0x0401062A RID: 67114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _EnterStateActorCollisionProfile;

		// Token: 0x0401062B RID: 67115
		internal static int __PropertyOffset_19;

		// Token: 0x0401062C RID: 67116
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _ExitStateActorCollisionProfile;

		// Token: 0x0401062D RID: 67117
		internal static int __PropertyOffset_20;
	}
}
