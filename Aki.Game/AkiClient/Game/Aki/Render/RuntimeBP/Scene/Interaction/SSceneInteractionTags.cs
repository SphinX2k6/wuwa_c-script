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
	// Token: 0x020030C7 RID: 12487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class SSceneInteractionTags : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E08D RID: 123021 RVA: 0x00908EC5 File Offset: 0x009070C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionTags._ScriptStructPtr != 0) ? SSceneInteractionTags._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags", ref SSceneInteractionTags._ScriptStructPtr);
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0601E08E RID: 123022 RVA: 0x00908EEC File Offset: 0x009070EC
		// (set) Token: 0x0601E08F RID: 123023 RVA: 0x00908F2F File Offset: 0x0090712F
		public TArray<BP_EffectActor_C> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_Effects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0601E090 RID: 123024 RVA: 0x00908F40 File Offset: 0x00907140
		// (set) Token: 0x0601E091 RID: 123025 RVA: 0x00908F83 File Offset: 0x00907183
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_Actors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0601E092 RID: 123026 RVA: 0x00908F94 File Offset: 0x00907194
		// (set) Token: 0x0601E093 RID: 123027 RVA: 0x00908FD7 File Offset: 0x009071D7
		public TArray<AActor> HideActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HideActors) == null)
				{
					result = (this._HideActors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_HideActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HideActors.CopyAssign(value);
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0601E094 RID: 123028 RVA: 0x00908FE8 File Offset: 0x009071E8
		// (set) Token: 0x0601E095 RID: 123029 RVA: 0x0090902B File Offset: 0x0090722B
		public TArray<SSceneInteractionMaterialController> MaterialControllers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSceneInteractionMaterialController> result;
				if ((result = this._MaterialControllers) == null)
				{
					result = (this._MaterialControllers = new TArray<SSceneInteractionMaterialController>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_MaterialControllers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialControllers.CopyAssign(value);
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0601E096 RID: 123030 RVA: 0x0090903C File Offset: 0x0090723C
		// (set) Token: 0x0601E097 RID: 123031 RVA: 0x0090907F File Offset: 0x0090727F
		public TArray<BP_EffectActor_C> SpecilEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._SpecilEffects) == null)
				{
					result = (this._SpecilEffects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_SpecilEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecilEffects.CopyAssign(value);
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0601E098 RID: 123032 RVA: 0x00909090 File Offset: 0x00907290
		// (set) Token: 0x0601E099 RID: 123033 RVA: 0x009090D3 File Offset: 0x009072D3
		public SSceneInteractionSequence Sequence
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionSequence result;
				if ((result = this._Sequence) == null)
				{
					result = (this._Sequence = new SSceneInteractionSequence(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_Sequence, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionSequence.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_Sequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0601E09A RID: 123034 RVA: 0x009090F4 File Offset: 0x009072F4
		// (set) Token: 0x0601E09B RID: 123035 RVA: 0x00909137 File Offset: 0x00907337
		public TArray<BP_EffectActor_C> EndEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._EndEffects) == null)
				{
					result = (this._EndEffects = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_EndEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndEffects.CopyAssign(value);
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0601E09C RID: 123036 RVA: 0x00909148 File Offset: 0x00907348
		// (set) Token: 0x0601E09D RID: 123037 RVA: 0x0090918B File Offset: 0x0090738B
		public SSceneInteractionAudio AkEvent
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionAudio result;
				if ((result = this._AkEvent) == null)
				{
					result = (this._AkEvent = new SSceneInteractionAudio(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_AkEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionAudio.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_AkEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0601E09E RID: 123038 RVA: 0x009091AC File Offset: 0x009073AC
		// (set) Token: 0x0601E09F RID: 123039 RVA: 0x009091EF File Offset: 0x009073EF
		public TArray<AKuroDestructibleActor> SkeletalMeshDestructibleActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._SkeletalMeshDestructibleActors) == null)
				{
					result = (this._SkeletalMeshDestructibleActors = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_SkeletalMeshDestructibleActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshDestructibleActors.CopyAssign(value);
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0601E0A0 RID: 123040 RVA: 0x00909200 File Offset: 0x00907400
		// (set) Token: 0x0601E0A1 RID: 123041 RVA: 0x00909243 File Offset: 0x00907443
		public SSceneInteractionDestructibleInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionDestructibleInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new SSceneInteractionDestructibleInfo(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_HitInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionDestructibleInfo.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0601E0A2 RID: 123042 RVA: 0x00909264 File Offset: 0x00907464
		// (set) Token: 0x0601E0A3 RID: 123043 RVA: 0x009092A7 File Offset: 0x009074A7
		public TMap<AActor, FCollisionProfileName> AddTagActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._AddTagActorCollisionProfile) == null)
				{
					result = (this._AddTagActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_AddTagActorCollisionProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTagActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0601E0A4 RID: 123044 RVA: 0x009092B8 File Offset: 0x009074B8
		// (set) Token: 0x0601E0A5 RID: 123045 RVA: 0x009092FB File Offset: 0x009074FB
		public TMap<AActor, FCollisionProfileName> RemoveTagActorCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FCollisionProfileName> result;
				if ((result = this._RemoveTagActorCollisionProfile) == null)
				{
					result = (this._RemoveTagActorCollisionProfile = new TMap<AActor, FCollisionProfileName>(base.NativePtr + (IntPtr)SSceneInteractionTags.__PropertyOffset_RemoveTagActorCollisionProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTagActorCollisionProfile.CopyAssign(value);
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0601E0A6 RID: 123046 RVA: 0x00909309 File Offset: 0x00907509
		// (set) Token: 0x0601E0A7 RID: 123047 RVA: 0x0090931D File Offset: 0x0090751D
		[Nullable(2)]
		public unsafe PD_CharacterControllerDataGroup_C CharacterDataGroupForOrgan
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionTags.__PropertyOffset_CharacterDataGroupForOrgan);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionTags.__PropertyOffset_CharacterDataGroupForOrgan, value);
			}
		}

		// Token: 0x0601E0A8 RID: 123048 RVA: 0x00909332 File Offset: 0x00907532
		public SSceneInteractionTags()
		{
		}

		// Token: 0x0601E0A9 RID: 123049 RVA: 0x0090933A File Offset: 0x0090753A
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionTags.StaticStruct();
		}

		// Token: 0x0601E0AA RID: 123050 RVA: 0x00909346 File Offset: 0x00907546
		[NullableContext(2)]
		public SSceneInteractionTags(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0AB RID: 123051 RVA: 0x00909350 File Offset: 0x00907550
		public SSceneInteractionTags(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0AC RID: 123052 RVA: 0x0090935B File Offset: 0x0090755B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionTags(Pointer, false, true);
		}

		// Token: 0x0601E0AD RID: 123053 RVA: 0x00909365 File Offset: 0x00907565
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionTags(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDF2 RID: 65010
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionTags.SSceneInteractionTags";

		// Token: 0x0400FDF3 RID: 65011
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDF4 RID: 65012
		internal static int __PropertyOffset_Effects;

		// Token: 0x0400FDF5 RID: 65013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _Effects;

		// Token: 0x0400FDF6 RID: 65014
		internal static int __PropertyOffset_Actors;

		// Token: 0x0400FDF7 RID: 65015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x0400FDF8 RID: 65016
		internal static int __PropertyOffset_HideActors;

		// Token: 0x0400FDF9 RID: 65017
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HideActors;

		// Token: 0x0400FDFA RID: 65018
		internal static int __PropertyOffset_MaterialControllers;

		// Token: 0x0400FDFB RID: 65019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSceneInteractionMaterialController> _MaterialControllers;

		// Token: 0x0400FDFC RID: 65020
		internal static int __PropertyOffset_SpecilEffects;

		// Token: 0x0400FDFD RID: 65021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _SpecilEffects;

		// Token: 0x0400FDFE RID: 65022
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0400FDFF RID: 65023
		[Nullable(2)]
		private SSceneInteractionSequence _Sequence;

		// Token: 0x0400FE00 RID: 65024
		internal static int __PropertyOffset_EndEffects;

		// Token: 0x0400FE01 RID: 65025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _EndEffects;

		// Token: 0x0400FE02 RID: 65026
		internal static int __PropertyOffset_AkEvent;

		// Token: 0x0400FE03 RID: 65027
		[Nullable(2)]
		private SSceneInteractionAudio _AkEvent;

		// Token: 0x0400FE04 RID: 65028
		internal static int __PropertyOffset_SkeletalMeshDestructibleActors;

		// Token: 0x0400FE05 RID: 65029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _SkeletalMeshDestructibleActors;

		// Token: 0x0400FE06 RID: 65030
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x0400FE07 RID: 65031
		[Nullable(2)]
		private SSceneInteractionDestructibleInfo _HitInfo;

		// Token: 0x0400FE08 RID: 65032
		internal static int __PropertyOffset_AddTagActorCollisionProfile;

		// Token: 0x0400FE09 RID: 65033
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _AddTagActorCollisionProfile;

		// Token: 0x0400FE0A RID: 65034
		internal static int __PropertyOffset_RemoveTagActorCollisionProfile;

		// Token: 0x0400FE0B RID: 65035
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, FCollisionProfileName> _RemoveTagActorCollisionProfile;

		// Token: 0x0400FE0C RID: 65036
		internal static int __PropertyOffset_CharacterDataGroupForOrgan;
	}
}
