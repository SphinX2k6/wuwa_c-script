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
	// Token: 0x02003B4F RID: 15183
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class SSceneInteractionTags : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A01 RID: 137729 RVA: 0x008F12CD File Offset: 0x008EF4CD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionTags._ScriptStructPtr != 0) ? SSceneInteractionTags._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags", ref SSceneInteractionTags._ScriptStructPtr);
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x06021A02 RID: 137730 RVA: 0x008F12F4 File Offset: 0x008EF4F4
		// (set) Token: 0x06021A03 RID: 137731 RVA: 0x008F1337 File Offset: 0x008EF537
		public TArray<BP_EffectActor_C> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x06021A04 RID: 137732 RVA: 0x008F1348 File Offset: 0x008EF548
		// (set) Token: 0x06021A05 RID: 137733 RVA: 0x008F138B File Offset: 0x008EF58B
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x06021A06 RID: 137734 RVA: 0x008F139C File Offset: 0x008EF59C
		// (set) Token: 0x06021A07 RID: 137735 RVA: 0x008F13DF File Offset: 0x008EF5DF
		public TArray<AActor> HideActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HideActors) == null)
				{
					result = (this._HideActors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HideActors.CopyAssign(value);
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x06021A08 RID: 137736 RVA: 0x008F13F0 File Offset: 0x008EF5F0
		// (set) Token: 0x06021A09 RID: 137737 RVA: 0x008F1433 File Offset: 0x008EF633
		public TArray<SSceneInteractionMaterialController> MaterialControllers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionMaterialController> result;
				if ((result = this._MaterialControllers) == null)
				{
					result = (this._MaterialControllers = new TArray<SSceneInteractionMaterialController>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialControllers.CopyAssign(value);
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x06021A0A RID: 137738 RVA: 0x008F1444 File Offset: 0x008EF644
		// (set) Token: 0x06021A0B RID: 137739 RVA: 0x008F1487 File Offset: 0x008EF687
		public TArray<SSceneInteractionitemIndestructibleEffectsParameters> IndestructibleEffectsParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionitemIndestructibleEffectsParameters> result;
				if ((result = this._IndestructibleEffectsParameters) == null)
				{
					result = (this._IndestructibleEffectsParameters = new TArray<SSceneInteractionitemIndestructibleEffectsParameters>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IndestructibleEffectsParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x06021A0C RID: 137740 RVA: 0x008F1498 File Offset: 0x008EF698
		// (set) Token: 0x06021A0D RID: 137741 RVA: 0x008F14DB File Offset: 0x008EF6DB
		public TArray<BP_EffectActor_C> SpecilEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._SpecilEffects) == null)
				{
					result = (this._SpecilEffects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecilEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x06021A0E RID: 137742 RVA: 0x008F14EC File Offset: 0x008EF6EC
		// (set) Token: 0x06021A0F RID: 137743 RVA: 0x008F152F File Offset: 0x008EF72F
		public SSceneInteractionSequence Sequence
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionSequence result;
				if ((result = this._Sequence) == null)
				{
					result = (this._Sequence = new SSceneInteractionSequence(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionSequence.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x06021A10 RID: 137744 RVA: 0x008F1550 File Offset: 0x008EF750
		// (set) Token: 0x06021A11 RID: 137745 RVA: 0x008F1593 File Offset: 0x008EF793
		public TArray<BP_EffectActor_C> EndEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._EndEffects) == null)
				{
					result = (this._EndEffects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x06021A12 RID: 137746 RVA: 0x008F15A4 File Offset: 0x008EF7A4
		// (set) Token: 0x06021A13 RID: 137747 RVA: 0x008F15E7 File Offset: 0x008EF7E7
		public SSceneInteractionAudio AkEvent
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionAudio result;
				if ((result = this._AkEvent) == null)
				{
					result = (this._AkEvent = new SSceneInteractionAudio(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionAudio.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x06021A14 RID: 137748 RVA: 0x008F1608 File Offset: 0x008EF808
		// (set) Token: 0x06021A15 RID: 137749 RVA: 0x008F164B File Offset: 0x008EF84B
		public TArray<ADestructibleActor> DestructibleActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ADestructibleActor> result;
				if ((result = this._DestructibleActors) == null)
				{
					result = (this._DestructibleActors = new TArray<ADestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DestructibleActors.CopyAssign(value);
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x06021A16 RID: 137750 RVA: 0x008F165C File Offset: 0x008EF85C
		// (set) Token: 0x06021A17 RID: 137751 RVA: 0x008F169F File Offset: 0x008EF89F
		public TArray<AKuroDestructibleActor> SkeletalMeshDestructibleActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._SkeletalMeshDestructibleActors) == null)
				{
					result = (this._SkeletalMeshDestructibleActors = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshDestructibleActors.CopyAssign(value);
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x06021A18 RID: 137752 RVA: 0x008F16B0 File Offset: 0x008EF8B0
		// (set) Token: 0x06021A19 RID: 137753 RVA: 0x008F16F3 File Offset: 0x008EF8F3
		public SSceneInteractionDestructibleInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionDestructibleInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new SSceneInteractionDestructibleInfo(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionDestructibleInfo.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x06021A1A RID: 137754 RVA: 0x008F1714 File Offset: 0x008EF914
		// (set) Token: 0x06021A1B RID: 137755 RVA: 0x008F1757 File Offset: 0x008EF957
		public TMap<AActor, FCollisionProfileName> AddTagActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._AddTagActorCollisionProfile) == null)
				{
					result = (this._AddTagActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTagActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x06021A1C RID: 137756 RVA: 0x008F1768 File Offset: 0x008EF968
		// (set) Token: 0x06021A1D RID: 137757 RVA: 0x008F17AB File Offset: 0x008EF9AB
		public TMap<AActor, FCollisionProfileName> RemoveTagActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._RemoveTagActorCollisionProfile) == null)
				{
					result = (this._RemoveTagActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTagActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x06021A1E RID: 137758 RVA: 0x008F17B9 File Offset: 0x008EF9B9
		// (set) Token: 0x06021A1F RID: 137759 RVA: 0x008F17CD File Offset: 0x008EF9CD
		[Nullable(2)]
		public unsafe PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionTags.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionTags.__PropertyOffset_14, value);
			}
		}

		// Token: 0x06021A20 RID: 137760 RVA: 0x008F17E2 File Offset: 0x008EF9E2
		public SSceneInteractionTags()
		{
		}

		// Token: 0x06021A21 RID: 137761 RVA: 0x008F17EC File Offset: 0x008EF9EC
		public SSceneInteractionTags(TArray<BP_EffectActor_C> Effects, TArray<AActor> Actors, TArray<AActor> HideActors, TArray<SSceneInteractionMaterialController> MaterialControllers, TArray<SSceneInteractionitemIndestructibleEffectsParameters> IndestructibleEffectsParameters, TArray<BP_EffectActor_C> SpecilEffects, SSceneInteractionSequence Sequence, TArray<BP_EffectActor_C> EndEffects, SSceneInteractionAudio AkEvent, TArray<ADestructibleActor> DestructibleActors, TArray<AKuroDestructibleActor> SkeletalMeshDestructibleActors, SSceneInteractionDestructibleInfo HitInfo, TMap<AActor, FCollisionProfileName> AddTagActorCollisionProfile, TMap<AActor, FCollisionProfileName> RemoveTagActorCollisionProfile, PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan)
		{
			this.Effects = Effects;
			this.Actors = Actors;
			this.HideActors = HideActors;
			this.MaterialControllers = MaterialControllers;
			this.IndestructibleEffectsParameters = IndestructibleEffectsParameters;
			this.SpecilEffects = SpecilEffects;
			this.Sequence = Sequence;
			this.EndEffects = EndEffects;
			this.AkEvent = AkEvent;
			this.DestructibleActors = DestructibleActors;
			this.SkeletalMeshDestructibleActors = SkeletalMeshDestructibleActors;
			this.HitInfo = HitInfo;
			this.AddTagActorCollisionProfile = AddTagActorCollisionProfile;
			this.RemoveTagActorCollisionProfile = RemoveTagActorCollisionProfile;
			this.CharacterDataGroupForOrgan = CharacterDataGroupForOrgan;
		}

		// Token: 0x06021A22 RID: 137762 RVA: 0x008F1874 File Offset: 0x008EFA74
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionTags.StaticStruct();
		}

		// Token: 0x06021A23 RID: 137763 RVA: 0x008F1880 File Offset: 0x008EFA80
		[NullableContext(2)]
		public SSceneInteractionTags(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A24 RID: 137764 RVA: 0x008F188A File Offset: 0x008EFA8A
		public SSceneInteractionTags(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A25 RID: 137765 RVA: 0x008F1895 File Offset: 0x008EFA95
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionTags(Pointer, false, true);
		}

		// Token: 0x06021A26 RID: 137766 RVA: 0x008F189F File Offset: 0x008EFA9F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionTags(Pointer, MemoryOwner);
		}

		// Token: 0x0401064F RID: 67151
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags";

		// Token: 0x04010650 RID: 67152
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010651 RID: 67153
		internal static int __PropertyOffset_0;

		// Token: 0x04010652 RID: 67154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _Effects;

		// Token: 0x04010653 RID: 67155
		internal static int __PropertyOffset_1;

		// Token: 0x04010654 RID: 67156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x04010655 RID: 67157
		internal static int __PropertyOffset_2;

		// Token: 0x04010656 RID: 67158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HideActors;

		// Token: 0x04010657 RID: 67159
		internal static int __PropertyOffset_3;

		// Token: 0x04010658 RID: 67160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionMaterialController> _MaterialControllers;

		// Token: 0x04010659 RID: 67161
		internal static int __PropertyOffset_4;

		// Token: 0x0401065A RID: 67162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionitemIndestructibleEffectsParameters> _IndestructibleEffectsParameters;

		// Token: 0x0401065B RID: 67163
		internal static int __PropertyOffset_5;

		// Token: 0x0401065C RID: 67164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _SpecilEffects;

		// Token: 0x0401065D RID: 67165
		internal static int __PropertyOffset_6;

		// Token: 0x0401065E RID: 67166
		[Nullable(2)]
		private SSceneInteractionSequence _Sequence;

		// Token: 0x0401065F RID: 67167
		internal static int __PropertyOffset_7;

		// Token: 0x04010660 RID: 67168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _EndEffects;

		// Token: 0x04010661 RID: 67169
		internal static int __PropertyOffset_8;

		// Token: 0x04010662 RID: 67170
		[Nullable(2)]
		private SSceneInteractionAudio _AkEvent;

		// Token: 0x04010663 RID: 67171
		internal static int __PropertyOffset_9;

		// Token: 0x04010664 RID: 67172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ADestructibleActor> _DestructibleActors;

		// Token: 0x04010665 RID: 67173
		internal static int __PropertyOffset_10;

		// Token: 0x04010666 RID: 67174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _SkeletalMeshDestructibleActors;

		// Token: 0x04010667 RID: 67175
		internal static int __PropertyOffset_11;

		// Token: 0x04010668 RID: 67176
		[Nullable(2)]
		private SSceneInteractionDestructibleInfo _HitInfo;

		// Token: 0x04010669 RID: 67177
		internal static int __PropertyOffset_12;

		// Token: 0x0401066A RID: 67178
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _AddTagActorCollisionProfile;

		// Token: 0x0401066B RID: 67179
		internal static int __PropertyOffset_13;

		// Token: 0x0401066C RID: 67180
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _RemoveTagActorCollisionProfile;

		// Token: 0x0401066D RID: 67181
		internal static int __PropertyOffset_14;
	}
}
