using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003339 RID: 13113
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class SBatchBulletPositionSpline : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602121F RID: 135711 RVA: 0x00959F82 File Offset: 0x00958182
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionSpline._ScriptStructPtr != 0) ? SBatchBulletPositionSpline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline", ref SBatchBulletPositionSpline._ScriptStructPtr);
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x06021220 RID: 135712 RVA: 0x00959FA6 File Offset: 0x009581A6
		// (set) Token: 0x06021221 RID: 135713 RVA: 0x00959FC5 File Offset: 0x009581C5
		public TSoftClassPtr<BP_BasePathLineBullet_C> SplineClass
		{
			get
			{
				return new TSoftClassPtr<BP_BasePathLineBullet_C>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_SplineClass, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_SplineClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x06021222 RID: 135714 RVA: 0x00959FEA File Offset: 0x009581EA
		// (set) Token: 0x06021223 RID: 135715 RVA: 0x00959FFE File Offset: 0x009581FE
		public unsafe string StartKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_StartKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_StartKey)), value);
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x06021224 RID: 135716 RVA: 0x0095A013 File Offset: 0x00958213
		// (set) Token: 0x06021225 RID: 135717 RVA: 0x0095A027 File Offset: 0x00958227
		public unsafe string EndKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EndKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EndKey)), value);
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x06021226 RID: 135718 RVA: 0x0095A03C File Offset: 0x0095823C
		// (set) Token: 0x06021227 RID: 135719 RVA: 0x0095A050 File Offset: 0x00958250
		public unsafe string RotatorKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_RotatorKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_RotatorKey)), value);
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x06021228 RID: 135720 RVA: 0x0095A065 File Offset: 0x00958265
		// (set) Token: 0x06021229 RID: 135721 RVA: 0x0095A079 File Offset: 0x00958279
		public unsafe string DurationKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DurationKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DurationKey)), value);
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0602122A RID: 135722 RVA: 0x0095A08E File Offset: 0x0095828E
		// (set) Token: 0x0602122B RID: 135723 RVA: 0x0095A09E File Offset: 0x0095829E
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0602122C RID: 135724 RVA: 0x0095A0AF File Offset: 0x009582AF
		// (set) Token: 0x0602122D RID: 135725 RVA: 0x0095A0BF File Offset: 0x009582BF
		public unsafe bool DestroyAllOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DestroyAllOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DestroyAllOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0602122E RID: 135726 RVA: 0x0095A0D0 File Offset: 0x009582D0
		// (set) Token: 0x0602122F RID: 135727 RVA: 0x0095A0E0 File Offset: 0x009582E0
		public unsafe bool DestroySummonBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DestroySummonBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_DestroySummonBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x06021230 RID: 135728 RVA: 0x0095A0F1 File Offset: 0x009582F1
		// (set) Token: 0x06021231 RID: 135729 RVA: 0x0095A105 File Offset: 0x00958305
		public unsafe string BulletIdOfEnd
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_BulletIdOfEnd)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_BulletIdOfEnd)), value);
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x06021232 RID: 135730 RVA: 0x0095A11A File Offset: 0x0095831A
		// (set) Token: 0x06021233 RID: 135731 RVA: 0x0095A139 File Offset: 0x00958339
		public TSoftObjectPtr<UEffectModelBase> EffectOfEnd
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EffectOfEnd, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EffectOfEnd, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x06021234 RID: 135732 RVA: 0x0095A15E File Offset: 0x0095835E
		// (set) Token: 0x06021235 RID: 135733 RVA: 0x0095A172 File Offset: 0x00958372
		public unsafe string BulletIdOnBreak
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_BulletIdOnBreak)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_BulletIdOnBreak)), value);
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x06021236 RID: 135734 RVA: 0x0095A187 File Offset: 0x00958387
		// (set) Token: 0x06021237 RID: 135735 RVA: 0x0095A1A6 File Offset: 0x009583A6
		public TSoftObjectPtr<UEffectModelBase> EffectOnBreak
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EffectOnBreak, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_EffectOnBreak, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021238 RID: 135736 RVA: 0x0095A1CB File Offset: 0x009583CB
		public SBatchBulletPositionSpline()
		{
		}

		// Token: 0x06021239 RID: 135737 RVA: 0x0095A1D3 File Offset: 0x009583D3
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionSpline.StaticStruct();
		}

		// Token: 0x0602123A RID: 135738 RVA: 0x0095A1DF File Offset: 0x009583DF
		[NullableContext(2)]
		public SBatchBulletPositionSpline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602123B RID: 135739 RVA: 0x0095A1E9 File Offset: 0x009583E9
		public SBatchBulletPositionSpline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602123C RID: 135740 RVA: 0x0095A1F4 File Offset: 0x009583F4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionSpline(Pointer, false, true);
		}

		// Token: 0x0602123D RID: 135741 RVA: 0x0095A1FE File Offset: 0x009583FE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionSpline(Pointer, MemoryOwner);
		}

		// Token: 0x040121DB RID: 74203
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline";

		// Token: 0x040121DC RID: 74204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121DD RID: 74205
		internal static int __PropertyOffset_SplineClass;

		// Token: 0x040121DE RID: 74206
		internal static int __PropertyOffset_StartKey;

		// Token: 0x040121DF RID: 74207
		internal static int __PropertyOffset_EndKey;

		// Token: 0x040121E0 RID: 74208
		internal static int __PropertyOffset_RotatorKey;

		// Token: 0x040121E1 RID: 74209
		internal static int __PropertyOffset_DurationKey;

		// Token: 0x040121E2 RID: 74210
		internal static int __PropertyOffset_Delay;

		// Token: 0x040121E3 RID: 74211
		internal static int __PropertyOffset_DestroyAllOnEnd;

		// Token: 0x040121E4 RID: 74212
		internal static int __PropertyOffset_DestroySummonBullet;

		// Token: 0x040121E5 RID: 74213
		internal static int __PropertyOffset_BulletIdOfEnd;

		// Token: 0x040121E6 RID: 74214
		internal static int __PropertyOffset_EffectOfEnd;

		// Token: 0x040121E7 RID: 74215
		internal static int __PropertyOffset_BulletIdOnBreak;

		// Token: 0x040121E8 RID: 74216
		internal static int __PropertyOffset_EffectOnBreak;
	}
}
