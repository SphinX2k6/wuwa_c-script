using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6F RID: 16239
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SOcclusionDitherConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029684 RID: 169604 RVA: 0x009C3742 File Offset: 0x009C1942
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SOcclusionDitherConfig._ScriptStructPtr != 0) ? SOcclusionDitherConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig", ref SOcclusionDitherConfig._ScriptStructPtr);
		}

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x06029685 RID: 169605 RVA: 0x009C3766 File Offset: 0x009C1966
		// (set) Token: 0x06029686 RID: 169606 RVA: 0x009C3776 File Offset: 0x009C1976
		public unsafe bool bEnableOcclusionDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700630D RID: 25357
		// (get) Token: 0x06029687 RID: 169607 RVA: 0x009C3787 File Offset: 0x009C1987
		// (set) Token: 0x06029688 RID: 169608 RVA: 0x009C3797 File Offset: 0x009C1997
		public unsafe float OcclusionDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700630E RID: 25358
		// (get) Token: 0x06029689 RID: 169609 RVA: 0x009C37A8 File Offset: 0x009C19A8
		// (set) Token: 0x0602968A RID: 169610 RVA: 0x009C37B8 File Offset: 0x009C19B8
		public unsafe float OcclusionDitherInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700630F RID: 25359
		// (get) Token: 0x0602968B RID: 169611 RVA: 0x009C37C9 File Offset: 0x009C19C9
		// (set) Token: 0x0602968C RID: 169612 RVA: 0x009C37DD File Offset: 0x009C19DD
		public unsafe FGameplayTag IgnoreOcclusionDitherTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602968D RID: 169613 RVA: 0x009C37F2 File Offset: 0x009C19F2
		public SOcclusionDitherConfig()
		{
		}

		// Token: 0x0602968E RID: 169614 RVA: 0x009C37FA File Offset: 0x009C19FA
		public SOcclusionDitherConfig(bool bEnableOcclusionDither, float OcclusionDitherValue, float OcclusionDitherInterpSpeed, FGameplayTag IgnoreOcclusionDitherTag)
		{
			this.bEnableOcclusionDither = bEnableOcclusionDither;
			this.OcclusionDitherValue = OcclusionDitherValue;
			this.OcclusionDitherInterpSpeed = OcclusionDitherInterpSpeed;
			this.IgnoreOcclusionDitherTag = IgnoreOcclusionDitherTag;
		}

		// Token: 0x0602968F RID: 169615 RVA: 0x009C381F File Offset: 0x009C1A1F
		protected override IntPtr GetUStructPtr()
		{
			return SOcclusionDitherConfig.StaticStruct();
		}

		// Token: 0x06029690 RID: 169616 RVA: 0x009C382B File Offset: 0x009C1A2B
		[NullableContext(2)]
		public SOcclusionDitherConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029691 RID: 169617 RVA: 0x009C3835 File Offset: 0x009C1A35
		public SOcclusionDitherConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029692 RID: 169618 RVA: 0x009C3840 File Offset: 0x009C1A40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SOcclusionDitherConfig(Pointer, false, true);
		}

		// Token: 0x06029693 RID: 169619 RVA: 0x009C384A File Offset: 0x009C1A4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SOcclusionDitherConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015377 RID: 86903
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig";

		// Token: 0x04015378 RID: 86904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015379 RID: 86905
		internal static int __PropertyOffset_0;

		// Token: 0x0401537A RID: 86906
		internal static int __PropertyOffset_1;

		// Token: 0x0401537B RID: 86907
		internal static int __PropertyOffset_2;

		// Token: 0x0401537C RID: 86908
		internal static int __PropertyOffset_3;
	}
}
