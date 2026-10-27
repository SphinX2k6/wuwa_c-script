using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B45 RID: 15173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SSceneInteractionActorSkeletalMeshDestructible : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602194F RID: 137551 RVA: 0x008F01AF File Offset: 0x008EE3AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr != 0) ? SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible", ref SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr);
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x06021950 RID: 137552 RVA: 0x008F01D4 File Offset: 0x008EE3D4
		// (set) Token: 0x06021951 RID: 137553 RVA: 0x008F0217 File Offset: 0x008EE417
		public TArray<AKuroDestructibleActor> PlayDestructionAllImmediately
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._PlayDestructionAllImmediately) == null)
				{
					result = (this._PlayDestructionAllImmediately = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlayDestructionAllImmediately.CopyAssign(value);
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x06021952 RID: 137554 RVA: 0x008F0228 File Offset: 0x008EE428
		// (set) Token: 0x06021953 RID: 137555 RVA: 0x008F026B File Offset: 0x008EE46B
		public TArray<AKuroDestructibleActor> CanPlayDestructionWhenHit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._CanPlayDestructionWhenHit) == null)
				{
					result = (this._CanPlayDestructionWhenHit = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CanPlayDestructionWhenHit.CopyAssign(value);
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x06021954 RID: 137556 RVA: 0x008F027C File Offset: 0x008EE47C
		// (set) Token: 0x06021955 RID: 137557 RVA: 0x008F02BF File Offset: 0x008EE4BF
		public SSceneInteractionDestructibleInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionDestructibleInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new SSceneInteractionDestructibleInfo(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionDestructibleInfo.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021956 RID: 137558 RVA: 0x008F02E0 File Offset: 0x008EE4E0
		public SSceneInteractionActorSkeletalMeshDestructible()
		{
		}

		// Token: 0x06021957 RID: 137559 RVA: 0x008F02E8 File Offset: 0x008EE4E8
		public SSceneInteractionActorSkeletalMeshDestructible(TArray<AKuroDestructibleActor> PlayDestructionAllImmediately, TArray<AKuroDestructibleActor> CanPlayDestructionWhenHit, SSceneInteractionDestructibleInfo HitInfo)
		{
			this.PlayDestructionAllImmediately = PlayDestructionAllImmediately;
			this.CanPlayDestructionWhenHit = CanPlayDestructionWhenHit;
			this.HitInfo = HitInfo;
		}

		// Token: 0x06021958 RID: 137560 RVA: 0x008F0305 File Offset: 0x008EE505
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionActorSkeletalMeshDestructible.StaticStruct();
		}

		// Token: 0x06021959 RID: 137561 RVA: 0x008F0311 File Offset: 0x008EE511
		[NullableContext(2)]
		public SSceneInteractionActorSkeletalMeshDestructible(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602195A RID: 137562 RVA: 0x008F031B File Offset: 0x008EE51B
		public SSceneInteractionActorSkeletalMeshDestructible(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602195B RID: 137563 RVA: 0x008F0326 File Offset: 0x008EE526
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionActorSkeletalMeshDestructible(Pointer, false, true);
		}

		// Token: 0x0602195C RID: 137564 RVA: 0x008F0330 File Offset: 0x008EE530
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionActorSkeletalMeshDestructible(Pointer, MemoryOwner);
		}

		// Token: 0x040105F3 RID: 67059
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible";

		// Token: 0x040105F4 RID: 67060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105F5 RID: 67061
		internal static int __PropertyOffset_0;

		// Token: 0x040105F6 RID: 67062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _PlayDestructionAllImmediately;

		// Token: 0x040105F7 RID: 67063
		internal static int __PropertyOffset_1;

		// Token: 0x040105F8 RID: 67064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _CanPlayDestructionWhenHit;

		// Token: 0x040105F9 RID: 67065
		internal static int __PropertyOffset_2;

		// Token: 0x040105FA RID: 67066
		[Nullable(2)]
		private SSceneInteractionDestructibleInfo _HitInfo;
	}
}
