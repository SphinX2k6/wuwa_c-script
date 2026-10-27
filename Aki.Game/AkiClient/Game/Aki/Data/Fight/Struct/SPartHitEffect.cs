using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F70 RID: 16240
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 209)]
	public class SPartHitEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029694 RID: 169620 RVA: 0x009C3853 File Offset: 0x009C1A53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPartHitEffect._ScriptStructPtr != 0) ? SPartHitEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect", ref SPartHitEffect._ScriptStructPtr);
		}

		// Token: 0x17006310 RID: 25360
		// (get) Token: 0x06029695 RID: 169621 RVA: 0x009C3877 File Offset: 0x009C1A77
		// (set) Token: 0x06029696 RID: 169622 RVA: 0x009C388B File Offset: 0x009C1A8B
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPartHitEffect.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPartHitEffect.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006311 RID: 25361
		// (get) Token: 0x06029697 RID: 169623 RVA: 0x009C38A0 File Offset: 0x009C1AA0
		// (set) Token: 0x06029698 RID: 169624 RVA: 0x009C38B0 File Offset: 0x009C1AB0
		public unsafe bool IsBlockPawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006312 RID: 25362
		// (get) Token: 0x06029699 RID: 169625 RVA: 0x009C38C1 File Offset: 0x009C1AC1
		// (set) Token: 0x0602969A RID: 169626 RVA: 0x009C38D1 File Offset: 0x009C1AD1
		public unsafe bool IsBulletDetect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006313 RID: 25363
		// (get) Token: 0x0602969B RID: 169627 RVA: 0x009C38E2 File Offset: 0x009C1AE2
		// (set) Token: 0x0602969C RID: 169628 RVA: 0x009C38F2 File Offset: 0x009C1AF2
		public unsafe bool IsBlockCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006314 RID: 25364
		// (get) Token: 0x0602969D RID: 169629 RVA: 0x009C3903 File Offset: 0x009C1B03
		// (set) Token: 0x0602969E RID: 169630 RVA: 0x009C3913 File Offset: 0x009C1B13
		public unsafe bool IsActiveOcclusionDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006315 RID: 25365
		// (get) Token: 0x0602969F RID: 169631 RVA: 0x009C3924 File Offset: 0x009C1B24
		// (set) Token: 0x060296A0 RID: 169632 RVA: 0x009C3934 File Offset: 0x009C1B34
		public unsafe bool IsIgnoreAllChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x060296A1 RID: 169633 RVA: 0x009C3945 File Offset: 0x009C1B45
		// (set) Token: 0x060296A2 RID: 169634 RVA: 0x009C3959 File Offset: 0x009C1B59
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x060296A3 RID: 169635 RVA: 0x009C396E File Offset: 0x009C1B6E
		// (set) Token: 0x060296A4 RID: 169636 RVA: 0x009C3982 File Offset: 0x009C1B82
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x060296A5 RID: 169637 RVA: 0x009C3997 File Offset: 0x009C1B97
		// (set) Token: 0x060296A6 RID: 169638 RVA: 0x009C39AB File Offset: 0x009C1BAB
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x060296A7 RID: 169639 RVA: 0x009C39C0 File Offset: 0x009C1BC0
		// (set) Token: 0x060296A8 RID: 169640 RVA: 0x009C39DF File Offset: 0x009C1BDF
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_9, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700631A RID: 25370
		// (get) Token: 0x060296A9 RID: 169641 RVA: 0x009C3A04 File Offset: 0x009C1C04
		// (set) Token: 0x060296AA RID: 169642 RVA: 0x009C3A23 File Offset: 0x009C1C23
		public TSoftObjectPtr<PD_CharacterControllerData_C> MaterialEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_10, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x060296AB RID: 169643 RVA: 0x009C3A48 File Offset: 0x009C1C48
		// (set) Token: 0x060296AC RID: 169644 RVA: 0x009C3A67 File Offset: 0x009C1C67
		public TSoftObjectPtr<EffectModelAudio> Audio
		{
			get
			{
				return new TSoftObjectPtr<EffectModelAudio>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x060296AD RID: 169645 RVA: 0x009C3A8C File Offset: 0x009C1C8C
		// (set) Token: 0x060296AE RID: 169646 RVA: 0x009C3A9C File Offset: 0x009C1C9C
		public unsafe bool ReplaceBulletHitEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x060296AF RID: 169647 RVA: 0x009C3AAD File Offset: 0x009C1CAD
		public SPartHitEffect()
		{
		}

		// Token: 0x060296B0 RID: 169648 RVA: 0x009C3AB8 File Offset: 0x009C1CB8
		public SPartHitEffect(string BoneName, bool IsBlockPawn, bool IsBulletDetect, bool IsBlockCamera, bool IsActiveOcclusionDither, bool IsIgnoreAllChannel, FVector Size, FVector Location, FRotator Rotation, TSoftObjectPtr<UEffectModelBase> Effect, TSoftObjectPtr<PD_CharacterControllerData_C> MaterialEffect, TSoftObjectPtr<EffectModelAudio> Audio, bool ReplaceBulletHitEffect)
		{
			this.BoneName = BoneName;
			this.IsBlockPawn = IsBlockPawn;
			this.IsBulletDetect = IsBulletDetect;
			this.IsBlockCamera = IsBlockCamera;
			this.IsActiveOcclusionDither = IsActiveOcclusionDither;
			this.IsIgnoreAllChannel = IsIgnoreAllChannel;
			this.Size = Size;
			this.Location = Location;
			this.Rotation = Rotation;
			this.Effect = Effect;
			this.MaterialEffect = MaterialEffect;
			this.Audio = Audio;
			this.ReplaceBulletHitEffect = ReplaceBulletHitEffect;
		}

		// Token: 0x060296B1 RID: 169649 RVA: 0x009C3B30 File Offset: 0x009C1D30
		protected override IntPtr GetUStructPtr()
		{
			return SPartHitEffect.StaticStruct();
		}

		// Token: 0x060296B2 RID: 169650 RVA: 0x009C3B3C File Offset: 0x009C1D3C
		[NullableContext(2)]
		public SPartHitEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060296B3 RID: 169651 RVA: 0x009C3B46 File Offset: 0x009C1D46
		public SPartHitEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060296B4 RID: 169652 RVA: 0x009C3B51 File Offset: 0x009C1D51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPartHitEffect(Pointer, false, true);
		}

		// Token: 0x060296B5 RID: 169653 RVA: 0x009C3B5B File Offset: 0x009C1D5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPartHitEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0401537D RID: 86909
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect";

		// Token: 0x0401537E RID: 86910
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401537F RID: 86911
		internal static int __PropertyOffset_0;

		// Token: 0x04015380 RID: 86912
		internal static int __PropertyOffset_1;

		// Token: 0x04015381 RID: 86913
		internal static int __PropertyOffset_2;

		// Token: 0x04015382 RID: 86914
		internal static int __PropertyOffset_3;

		// Token: 0x04015383 RID: 86915
		internal static int __PropertyOffset_4;

		// Token: 0x04015384 RID: 86916
		internal static int __PropertyOffset_5;

		// Token: 0x04015385 RID: 86917
		internal static int __PropertyOffset_6;

		// Token: 0x04015386 RID: 86918
		internal static int __PropertyOffset_7;

		// Token: 0x04015387 RID: 86919
		internal static int __PropertyOffset_8;

		// Token: 0x04015388 RID: 86920
		internal static int __PropertyOffset_9;

		// Token: 0x04015389 RID: 86921
		internal static int __PropertyOffset_10;

		// Token: 0x0401538A RID: 86922
		internal static int __PropertyOffset_11;

		// Token: 0x0401538B RID: 86923
		internal static int __PropertyOffset_12;
	}
}
