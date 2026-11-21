using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320F RID: 12815
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SOcclusionDitherConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FEFC RID: 130812 RVA: 0x009395C5 File Offset: 0x009377C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SOcclusionDitherConfig._ScriptStructPtr != 0) ? SOcclusionDitherConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig", ref SOcclusionDitherConfig._ScriptStructPtr);
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0601FEFD RID: 130813 RVA: 0x009395E9 File Offset: 0x009377E9
		// (set) Token: 0x0601FEFE RID: 130814 RVA: 0x009395F9 File Offset: 0x009377F9
		public unsafe bool bEnableOcclusionDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_bEnableOcclusionDither) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_bEnableOcclusionDither) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0601FEFF RID: 130815 RVA: 0x0093960A File Offset: 0x0093780A
		// (set) Token: 0x0601FF00 RID: 130816 RVA: 0x0093961A File Offset: 0x0093781A
		public unsafe float OcclusionDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_OcclusionDitherValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_OcclusionDitherValue) = value;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0601FF01 RID: 130817 RVA: 0x0093962B File Offset: 0x0093782B
		// (set) Token: 0x0601FF02 RID: 130818 RVA: 0x0093963B File Offset: 0x0093783B
		public unsafe float OcclusionDitherInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_OcclusionDitherInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_OcclusionDitherInterpSpeed) = value;
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0601FF03 RID: 130819 RVA: 0x0093964C File Offset: 0x0093784C
		// (set) Token: 0x0601FF04 RID: 130820 RVA: 0x00939660 File Offset: 0x00937860
		public unsafe FGameplayTag IgnoreOcclusionDitherTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_IgnoreOcclusionDitherTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SOcclusionDitherConfig.__PropertyOffset_IgnoreOcclusionDitherTag) = value;
			}
		}

		// Token: 0x0601FF05 RID: 130821 RVA: 0x00939675 File Offset: 0x00937875
		public SOcclusionDitherConfig()
		{
		}

		// Token: 0x0601FF06 RID: 130822 RVA: 0x0093967D File Offset: 0x0093787D
		protected override IntPtr GetUStructPtr()
		{
			return SOcclusionDitherConfig.StaticStruct();
		}

		// Token: 0x0601FF07 RID: 130823 RVA: 0x00939689 File Offset: 0x00937889
		[NullableContext(2)]
		public SOcclusionDitherConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FF08 RID: 130824 RVA: 0x00939693 File Offset: 0x00937893
		public SOcclusionDitherConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FF09 RID: 130825 RVA: 0x0093969E File Offset: 0x0093789E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SOcclusionDitherConfig(Pointer, false, true);
		}

		// Token: 0x0601FF0A RID: 130826 RVA: 0x009396A8 File Offset: 0x009378A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SOcclusionDitherConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011268 RID: 70248
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SOcclusionDitherConfig.SOcclusionDitherConfig";

		// Token: 0x04011269 RID: 70249
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401126A RID: 70250
		internal static int __PropertyOffset_bEnableOcclusionDither;

		// Token: 0x0401126B RID: 70251
		internal static int __PropertyOffset_OcclusionDitherValue;

		// Token: 0x0401126C RID: 70252
		internal static int __PropertyOffset_OcclusionDitherInterpSpeed;

		// Token: 0x0401126D RID: 70253
		internal static int __PropertyOffset_IgnoreOcclusionDitherTag;
	}
}
