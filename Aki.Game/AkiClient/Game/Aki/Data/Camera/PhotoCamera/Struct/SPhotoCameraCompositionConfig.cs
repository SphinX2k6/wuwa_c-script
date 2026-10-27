using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x02003FB4 RID: 16308
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SPhotoCameraCompositionConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029BB6 RID: 170934 RVA: 0x009CB484 File Offset: 0x009C9684
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraCompositionConfig._ScriptStructPtr != 0) ? SPhotoCameraCompositionConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig", ref SPhotoCameraCompositionConfig._ScriptStructPtr);
		}

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x06029BB7 RID: 170935 RVA: 0x009CB4A8 File Offset: 0x009C96A8
		// (set) Token: 0x06029BB8 RID: 170936 RVA: 0x009CB4B8 File Offset: 0x009C96B8
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x06029BB9 RID: 170937 RVA: 0x009CB4C9 File Offset: 0x009C96C9
		// (set) Token: 0x06029BBA RID: 170938 RVA: 0x009CB4D9 File Offset: 0x009C96D9
		public unsafe float BaseAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x06029BBB RID: 170939 RVA: 0x009CB4EA File Offset: 0x009C96EA
		// (set) Token: 0x06029BBC RID: 170940 RVA: 0x009CB4FA File Offset: 0x009C96FA
		public unsafe float MaxCompensateDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x06029BBD RID: 170941 RVA: 0x009CB50B File Offset: 0x009C970B
		// (set) Token: 0x06029BBE RID: 170942 RVA: 0x009CB51B File Offset: 0x009C971B
		public unsafe float MinAnchorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x06029BBF RID: 170943 RVA: 0x009CB52C File Offset: 0x009C972C
		// (set) Token: 0x06029BC0 RID: 170944 RVA: 0x009CB540 File Offset: 0x009C9740
		public unsafe FVectorDouble AnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06029BC1 RID: 170945 RVA: 0x009CB555 File Offset: 0x009C9755
		public SPhotoCameraCompositionConfig()
		{
		}

		// Token: 0x06029BC2 RID: 170946 RVA: 0x009CB55D File Offset: 0x009C975D
		public SPhotoCameraCompositionConfig(bool Enable, float BaseAspectRatio, float MaxCompensateDegree, float MinAnchorDistance, FVectorDouble AnchorOffset)
		{
			this.Enable = Enable;
			this.BaseAspectRatio = BaseAspectRatio;
			this.MaxCompensateDegree = MaxCompensateDegree;
			this.MinAnchorDistance = MinAnchorDistance;
			this.AnchorOffset = AnchorOffset;
		}

		// Token: 0x06029BC3 RID: 170947 RVA: 0x009CB58A File Offset: 0x009C978A
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraCompositionConfig.StaticStruct();
		}

		// Token: 0x06029BC4 RID: 170948 RVA: 0x009CB596 File Offset: 0x009C9796
		[NullableContext(2)]
		public SPhotoCameraCompositionConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029BC5 RID: 170949 RVA: 0x009CB5A0 File Offset: 0x009C97A0
		public SPhotoCameraCompositionConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029BC6 RID: 170950 RVA: 0x009CB5AB File Offset: 0x009C97AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraCompositionConfig(Pointer, false, true);
		}

		// Token: 0x06029BC7 RID: 170951 RVA: 0x009CB5B5 File Offset: 0x009C97B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraCompositionConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040156EB RID: 87787
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig";

		// Token: 0x040156EC RID: 87788
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156ED RID: 87789
		internal static int __PropertyOffset_0;

		// Token: 0x040156EE RID: 87790
		internal static int __PropertyOffset_1;

		// Token: 0x040156EF RID: 87791
		internal static int __PropertyOffset_2;

		// Token: 0x040156F0 RID: 87792
		internal static int __PropertyOffset_3;

		// Token: 0x040156F1 RID: 87793
		internal static int __PropertyOffset_4;
	}
}
