using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B48 RID: 15176
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SSceneInteractionDestructibleInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021977 RID: 137591 RVA: 0x008F04E1 File Offset: 0x008EE6E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionDestructibleInfo._ScriptStructPtr != 0) ? SSceneInteractionDestructibleInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo", ref SSceneInteractionDestructibleInfo._ScriptStructPtr);
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x06021978 RID: 137592 RVA: 0x008F0505 File Offset: 0x008EE705
		// (set) Token: 0x06021979 RID: 137593 RVA: 0x008F0519 File Offset: 0x008EE719
		public unsafe TEnumAsByte<BPELevelPrefabDestructibleHitInfo> HitType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0602197A RID: 137594 RVA: 0x008F0530 File Offset: 0x008EE730
		// (set) Token: 0x0602197B RID: 137595 RVA: 0x008F0573 File Offset: 0x008EE773
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
					result = (this._ImpulseStrengthFloatRange = new SFloatRangeWithCurve(base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatRangeWithCurve.StaticStruct(), base.NativePtr + (IntPtr)SSceneInteractionDestructibleInfo.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602197C RID: 137596 RVA: 0x008F0594 File Offset: 0x008EE794
		public SSceneInteractionDestructibleInfo()
		{
		}

		// Token: 0x0602197D RID: 137597 RVA: 0x008F059C File Offset: 0x008EE79C
		public SSceneInteractionDestructibleInfo(TEnumAsByte<BPELevelPrefabDestructibleHitInfo> HitType, [Nullable(1)] SFloatRangeWithCurve ImpulseStrengthFloatRange)
		{
			this.HitType = HitType;
			this.ImpulseStrengthFloatRange = ImpulseStrengthFloatRange;
		}

		// Token: 0x0602197E RID: 137598 RVA: 0x008F05B2 File Offset: 0x008EE7B2
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionDestructibleInfo.StaticStruct();
		}

		// Token: 0x0602197F RID: 137599 RVA: 0x008F05BE File Offset: 0x008EE7BE
		[NullableContext(2)]
		public SSceneInteractionDestructibleInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021980 RID: 137600 RVA: 0x008F05C8 File Offset: 0x008EE7C8
		public SSceneInteractionDestructibleInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021981 RID: 137601 RVA: 0x008F05D3 File Offset: 0x008EE7D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionDestructibleInfo(Pointer, false, true);
		}

		// Token: 0x06021982 RID: 137602 RVA: 0x008F05DD File Offset: 0x008EE7DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionDestructibleInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010604 RID: 67076
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionDestructibleInfo.SSceneInteractionDestructibleInfo";

		// Token: 0x04010605 RID: 67077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010606 RID: 67078
		internal static int __PropertyOffset_0;

		// Token: 0x04010607 RID: 67079
		internal static int __PropertyOffset_1;

		// Token: 0x04010608 RID: 67080
		[Nullable(2)]
		private SFloatRangeWithCurve _ImpulseStrengthFloatRange;
	}
}
