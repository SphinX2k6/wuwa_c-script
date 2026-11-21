using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030BF RID: 12479
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SSceneInteractionActorSkeletalMeshDestructible : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DFFF RID: 122879 RVA: 0x009081EE File Offset: 0x009063EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr != 0) ? SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible", ref SSceneInteractionActorSkeletalMeshDestructible._ScriptStructPtr);
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0601E000 RID: 122880 RVA: 0x00908214 File Offset: 0x00906414
		// (set) Token: 0x0601E001 RID: 122881 RVA: 0x00908257 File Offset: 0x00906457
		public TArray<AKuroDestructibleActor> PlayDestructionAllImmediately
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._PlayDestructionAllImmediately) == null)
				{
					result = (this._PlayDestructionAllImmediately = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_PlayDestructionAllImmediately, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlayDestructionAllImmediately.CopyAssign(value);
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0601E002 RID: 122882 RVA: 0x00908268 File Offset: 0x00906468
		// (set) Token: 0x0601E003 RID: 122883 RVA: 0x009082AB File Offset: 0x009064AB
		public TArray<AKuroDestructibleActor> CanPlayDestructionWhenHit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroDestructibleActor> result;
				if ((result = this._CanPlayDestructionWhenHit) == null)
				{
					result = (this._CanPlayDestructionWhenHit = new TArray<AKuroDestructibleActor>(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_CanPlayDestructionWhenHit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CanPlayDestructionWhenHit.CopyAssign(value);
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0601E004 RID: 122884 RVA: 0x009082BC File Offset: 0x009064BC
		// (set) Token: 0x0601E005 RID: 122885 RVA: 0x009082FF File Offset: 0x009064FF
		public SSceneInteractionDestructibleInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionDestructibleInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new SSceneInteractionDestructibleInfo(base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_HitInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionDestructibleInfo.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionActorSkeletalMeshDestructible.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E006 RID: 122886 RVA: 0x00908320 File Offset: 0x00906520
		public SSceneInteractionActorSkeletalMeshDestructible()
		{
		}

		// Token: 0x0601E007 RID: 122887 RVA: 0x00908328 File Offset: 0x00906528
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionActorSkeletalMeshDestructible.StaticStruct();
		}

		// Token: 0x0601E008 RID: 122888 RVA: 0x00908334 File Offset: 0x00906534
		[NullableContext(2)]
		public SSceneInteractionActorSkeletalMeshDestructible(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E009 RID: 122889 RVA: 0x0090833E File Offset: 0x0090653E
		public SSceneInteractionActorSkeletalMeshDestructible(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E00A RID: 122890 RVA: 0x00908349 File Offset: 0x00906549
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionActorSkeletalMeshDestructible(Pointer, false, true);
		}

		// Token: 0x0601E00B RID: 122891 RVA: 0x00908353 File Offset: 0x00906553
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionActorSkeletalMeshDestructible(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDA5 RID: 64933
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorSkeletalmeshDestructible.SSceneInteractionActorSkeletalMeshDestructible";

		// Token: 0x0400FDA6 RID: 64934
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDA7 RID: 64935
		internal static int __PropertyOffset_PlayDestructionAllImmediately;

		// Token: 0x0400FDA8 RID: 64936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _PlayDestructionAllImmediately;

		// Token: 0x0400FDA9 RID: 64937
		internal static int __PropertyOffset_CanPlayDestructionWhenHit;

		// Token: 0x0400FDAA RID: 64938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroDestructibleActor> _CanPlayDestructionWhenHit;

		// Token: 0x0400FDAB RID: 64939
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x0400FDAC RID: 64940
		[Nullable(2)]
		private SSceneInteractionDestructibleInfo _HitInfo;
	}
}
