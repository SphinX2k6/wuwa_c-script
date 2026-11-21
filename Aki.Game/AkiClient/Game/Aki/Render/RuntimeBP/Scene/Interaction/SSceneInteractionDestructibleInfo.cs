using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C2 RID: 12482
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SSceneInteractionDestructibleInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E024 RID: 122916 RVA: 0x009084D1 File Offset: 0x009066D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionDestructibleInfo._ScriptStructPtr != 0) ? SSceneInteractionDestructibleInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo", ref SSceneInteractionDestructibleInfo._ScriptStructPtr);
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0601E025 RID: 122917 RVA: 0x009084F5 File Offset: 0x009066F5
		// (set) Token: 0x0601E026 RID: 122918 RVA: 0x00908509 File Offset: 0x00906709
		public unsafe TEnumAsByte<BPELevelPrefabDestructibleHitInfo> HitType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_HitType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_HitType) = value;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0601E027 RID: 122919 RVA: 0x00908520 File Offset: 0x00906720
		// (set) Token: 0x0601E028 RID: 122920 RVA: 0x00908563 File Offset: 0x00906763
		[Nullable(1)]
		public SFloatRangeWithCurve ImpulseStrengthFloatRange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SFloatRangeWithCurve result;
				if ((result = this._ImpulseStrengthFloatRange) == null)
				{
					result = (this._ImpulseStrengthFloatRange = new SFloatRangeWithCurve(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_ImpulseStrengthFloatRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatRangeWithCurve.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_ImpulseStrengthFloatRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E029 RID: 122921 RVA: 0x00908584 File Offset: 0x00906784
		public SSceneInteractionDestructibleInfo()
		{
		}

		// Token: 0x0601E02A RID: 122922 RVA: 0x0090858C File Offset: 0x0090678C
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionDestructibleInfo.StaticStruct();
		}

		// Token: 0x0601E02B RID: 122923 RVA: 0x00908598 File Offset: 0x00906798
		[NullableContext(2)]
		public SSceneInteractionDestructibleInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E02C RID: 122924 RVA: 0x009085A2 File Offset: 0x009067A2
		public SSceneInteractionDestructibleInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E02D RID: 122925 RVA: 0x009085AD File Offset: 0x009067AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionDestructibleInfo(Pointer, false, true);
		}

		// Token: 0x0601E02E RID: 122926 RVA: 0x009085B7 File Offset: 0x009067B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionDestructibleInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDB6 RID: 64950
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo";

		// Token: 0x0400FDB7 RID: 64951
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDB8 RID: 64952
		internal static int __PropertyOffset_HitType;

		// Token: 0x0400FDB9 RID: 64953
		internal static int __PropertyOffset_ImpulseStrengthFloatRange;

		// Token: 0x0400FDBA RID: 64954
		[Nullable(2)]
		private SFloatRangeWithCurve _ImpulseStrengthFloatRange;
	}
}
