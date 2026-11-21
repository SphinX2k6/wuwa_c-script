using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003210 RID: 12816
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 209)]
	public class SPartHitEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FF0B RID: 130827 RVA: 0x009396B1 File Offset: 0x009378B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPartHitEffect._ScriptStructPtr != 0) ? SPartHitEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect", ref SPartHitEffect._ScriptStructPtr);
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0601FF0C RID: 130828 RVA: 0x009396D5 File Offset: 0x009378D5
		// (set) Token: 0x0601FF0D RID: 130829 RVA: 0x009396E9 File Offset: 0x009378E9
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPartHitEffect.__PropertyOffset_BoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPartHitEffect.__PropertyOffset_BoneName)), value);
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0601FF0E RID: 130830 RVA: 0x009396FE File Offset: 0x009378FE
		// (set) Token: 0x0601FF0F RID: 130831 RVA: 0x0093970E File Offset: 0x0093790E
		public unsafe bool IsBlockPawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBlockPawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBlockPawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0601FF10 RID: 130832 RVA: 0x0093971F File Offset: 0x0093791F
		// (set) Token: 0x0601FF11 RID: 130833 RVA: 0x0093972F File Offset: 0x0093792F
		public unsafe bool IsBulletDetect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBulletDetect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBulletDetect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0601FF12 RID: 130834 RVA: 0x00939740 File Offset: 0x00937940
		// (set) Token: 0x0601FF13 RID: 130835 RVA: 0x00939750 File Offset: 0x00937950
		public unsafe bool IsBlockCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBlockCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsBlockCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0601FF14 RID: 130836 RVA: 0x00939761 File Offset: 0x00937961
		// (set) Token: 0x0601FF15 RID: 130837 RVA: 0x00939771 File Offset: 0x00937971
		public unsafe bool IsActiveOcclusionDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsActiveOcclusionDither) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsActiveOcclusionDither) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0601FF16 RID: 130838 RVA: 0x00939782 File Offset: 0x00937982
		// (set) Token: 0x0601FF17 RID: 130839 RVA: 0x00939792 File Offset: 0x00937992
		public unsafe bool IsIgnoreAllChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsIgnoreAllChannel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_IsIgnoreAllChannel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0601FF18 RID: 130840 RVA: 0x009397A3 File Offset: 0x009379A3
		// (set) Token: 0x0601FF19 RID: 130841 RVA: 0x009397B7 File Offset: 0x009379B7
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0601FF1A RID: 130842 RVA: 0x009397CC File Offset: 0x009379CC
		// (set) Token: 0x0601FF1B RID: 130843 RVA: 0x009397E0 File Offset: 0x009379E0
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0601FF1C RID: 130844 RVA: 0x009397F5 File Offset: 0x009379F5
		// (set) Token: 0x0601FF1D RID: 130845 RVA: 0x00939809 File Offset: 0x00937A09
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0601FF1E RID: 130846 RVA: 0x0093981E File Offset: 0x00937A1E
		// (set) Token: 0x0601FF1F RID: 130847 RVA: 0x0093983D File Offset: 0x00937A3D
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Effect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Effect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0601FF20 RID: 130848 RVA: 0x00939862 File Offset: 0x00937A62
		// (set) Token: 0x0601FF21 RID: 130849 RVA: 0x00939881 File Offset: 0x00937A81
		public TSoftObjectPtr<PD_CharacterControllerData_C> MaterialEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_MaterialEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_MaterialEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0601FF22 RID: 130850 RVA: 0x009398A6 File Offset: 0x00937AA6
		// (set) Token: 0x0601FF23 RID: 130851 RVA: 0x009398C5 File Offset: 0x00937AC5
		public TSoftObjectPtr<EffectModelAudio> Audio
		{
			get
			{
				return new TSoftObjectPtr<EffectModelAudio>(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Audio, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_Audio, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0601FF24 RID: 130852 RVA: 0x009398EA File Offset: 0x00937AEA
		// (set) Token: 0x0601FF25 RID: 130853 RVA: 0x009398FA File Offset: 0x00937AFA
		public unsafe bool ReplaceBulletHitEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_ReplaceBulletHitEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPartHitEffect.__PropertyOffset_ReplaceBulletHitEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FF26 RID: 130854 RVA: 0x0093990B File Offset: 0x00937B0B
		public SPartHitEffect()
		{
		}

		// Token: 0x0601FF27 RID: 130855 RVA: 0x00939913 File Offset: 0x00937B13
		protected override IntPtr GetUStructPtr()
		{
			return SPartHitEffect.StaticStruct();
		}

		// Token: 0x0601FF28 RID: 130856 RVA: 0x0093991F File Offset: 0x00937B1F
		[NullableContext(2)]
		public SPartHitEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FF29 RID: 130857 RVA: 0x00939929 File Offset: 0x00937B29
		public SPartHitEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FF2A RID: 130858 RVA: 0x00939934 File Offset: 0x00937B34
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPartHitEffect(Pointer, false, true);
		}

		// Token: 0x0601FF2B RID: 130859 RVA: 0x0093993E File Offset: 0x00937B3E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPartHitEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0401126E RID: 70254
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SPartHitEffect.SPartHitEffect";

		// Token: 0x0401126F RID: 70255
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011270 RID: 70256
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04011271 RID: 70257
		internal static int __PropertyOffset_IsBlockPawn;

		// Token: 0x04011272 RID: 70258
		internal static int __PropertyOffset_IsBulletDetect;

		// Token: 0x04011273 RID: 70259
		internal static int __PropertyOffset_IsBlockCamera;

		// Token: 0x04011274 RID: 70260
		internal static int __PropertyOffset_IsActiveOcclusionDither;

		// Token: 0x04011275 RID: 70261
		internal static int __PropertyOffset_IsIgnoreAllChannel;

		// Token: 0x04011276 RID: 70262
		internal static int __PropertyOffset_Size;

		// Token: 0x04011277 RID: 70263
		internal static int __PropertyOffset_Location;

		// Token: 0x04011278 RID: 70264
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04011279 RID: 70265
		internal static int __PropertyOffset_Effect;

		// Token: 0x0401127A RID: 70266
		internal static int __PropertyOffset_MaterialEffect;

		// Token: 0x0401127B RID: 70267
		internal static int __PropertyOffset_Audio;

		// Token: 0x0401127C RID: 70268
		internal static int __PropertyOffset_ReplaceBulletHitEffect;
	}
}
