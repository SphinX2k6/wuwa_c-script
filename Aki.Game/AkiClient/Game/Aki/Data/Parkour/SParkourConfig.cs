using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Parkour
{
	// Token: 0x020031AD RID: 12717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SParkourConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F66D RID: 128621 RVA: 0x0092CFD7 File Offset: 0x0092B1D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SParkourConfig._ScriptStructPtr != 0) ? SParkourConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig", ref SParkourConfig._ScriptStructPtr);
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0601F66E RID: 128622 RVA: 0x0092CFFB File Offset: 0x0092B1FB
		// (set) Token: 0x0601F66F RID: 128623 RVA: 0x0092D00F File Offset: 0x0092B20F
		public unsafe FName ConfigName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_ConfigName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_ConfigName) = value;
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0601F670 RID: 128624 RVA: 0x0092D024 File Offset: 0x0092B224
		// (set) Token: 0x0601F671 RID: 128625 RVA: 0x0092D034 File Offset: 0x0092B234
		public unsafe bool IstoStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_IstoStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_IstoStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0601F672 RID: 128626 RVA: 0x0092D045 File Offset: 0x0092B245
		// (set) Token: 0x0601F673 RID: 128627 RVA: 0x0092D055 File Offset: 0x0092B255
		public unsafe bool IsRequireToEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_IsRequireToEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_IsRequireToEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0601F674 RID: 128628 RVA: 0x0092D066 File Offset: 0x0092B266
		// (set) Token: 0x0601F675 RID: 128629 RVA: 0x0092D076 File Offset: 0x0092B276
		public unsafe int CheckPointsRequire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointsRequire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointsRequire) = value;
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0601F676 RID: 128630 RVA: 0x0092D087 File Offset: 0x0092B287
		// (set) Token: 0x0601F677 RID: 128631 RVA: 0x0092D0A6 File Offset: 0x0092B2A6
		public TSoftObjectPtr<UEffectModelBase> CheckPointResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointResource, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointResource, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0601F678 RID: 128632 RVA: 0x0092D0CB File Offset: 0x0092B2CB
		// (set) Token: 0x0601F679 RID: 128633 RVA: 0x0092D0EA File Offset: 0x0092B2EA
		public TSoftObjectPtr<UEffectModelBase> CheckPointsDestroyRes
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointsDestroyRes, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_CheckPointsDestroyRes, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0601F67A RID: 128634 RVA: 0x0092D10F File Offset: 0x0092B30F
		// (set) Token: 0x0601F67B RID: 128635 RVA: 0x0092D12E File Offset: 0x0092B32E
		public TSoftObjectPtr<UEffectModelBase> StartResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_StartResource, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_StartResource, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0601F67C RID: 128636 RVA: 0x0092D153 File Offset: 0x0092B353
		// (set) Token: 0x0601F67D RID: 128637 RVA: 0x0092D172 File Offset: 0x0092B372
		public TSoftObjectPtr<UEffectModelBase> EndResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_EndResource, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_EndResource, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0601F67E RID: 128638 RVA: 0x0092D197 File Offset: 0x0092B397
		// (set) Token: 0x0601F67F RID: 128639 RVA: 0x0092D1A7 File Offset: 0x0092B3A7
		public unsafe float DefaultBuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_DefaultBuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_DefaultBuffId) = value;
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0601F680 RID: 128640 RVA: 0x0092D1B8 File Offset: 0x0092B3B8
		// (set) Token: 0x0601F681 RID: 128641 RVA: 0x0092D1C8 File Offset: 0x0092B3C8
		public unsafe float DefaultModifiedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_DefaultModifiedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_DefaultModifiedTime) = value;
			}
		}

		// Token: 0x0601F682 RID: 128642 RVA: 0x0092D1D9 File Offset: 0x0092B3D9
		public SParkourConfig()
		{
		}

		// Token: 0x0601F683 RID: 128643 RVA: 0x0092D1E1 File Offset: 0x0092B3E1
		protected override IntPtr GetUStructPtr()
		{
			return SParkourConfig.StaticStruct();
		}

		// Token: 0x0601F684 RID: 128644 RVA: 0x0092D1ED File Offset: 0x0092B3ED
		[NullableContext(2)]
		public SParkourConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F685 RID: 128645 RVA: 0x0092D1F7 File Offset: 0x0092B3F7
		public SParkourConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F686 RID: 128646 RVA: 0x0092D202 File Offset: 0x0092B402
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SParkourConfig(Pointer, false, true);
		}

		// Token: 0x0601F687 RID: 128647 RVA: 0x0092D20C File Offset: 0x0092B40C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SParkourConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010D52 RID: 68946
		public const string __ObjectPath = "/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig";

		// Token: 0x04010D53 RID: 68947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D54 RID: 68948
		internal static int __PropertyOffset_ConfigName;

		// Token: 0x04010D55 RID: 68949
		internal static int __PropertyOffset_IstoStart;

		// Token: 0x04010D56 RID: 68950
		internal static int __PropertyOffset_IsRequireToEnd;

		// Token: 0x04010D57 RID: 68951
		internal static int __PropertyOffset_CheckPointsRequire;

		// Token: 0x04010D58 RID: 68952
		internal static int __PropertyOffset_CheckPointResource;

		// Token: 0x04010D59 RID: 68953
		internal static int __PropertyOffset_CheckPointsDestroyRes;

		// Token: 0x04010D5A RID: 68954
		internal static int __PropertyOffset_StartResource;

		// Token: 0x04010D5B RID: 68955
		internal static int __PropertyOffset_EndResource;

		// Token: 0x04010D5C RID: 68956
		internal static int __PropertyOffset_DefaultBuffId;

		// Token: 0x04010D5D RID: 68957
		internal static int __PropertyOffset_DefaultModifiedTime;
	}
}
