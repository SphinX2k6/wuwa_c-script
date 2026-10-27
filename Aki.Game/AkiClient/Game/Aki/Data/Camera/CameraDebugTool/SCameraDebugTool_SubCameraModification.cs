using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FBD RID: 16317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SCameraDebugTool_SubCameraModification : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C59 RID: 171097 RVA: 0x009CC285 File Offset: 0x009CA485
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_SubCameraModification._ScriptStructPtr != 0) ? SCameraDebugTool_SubCameraModification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification", ref SCameraDebugTool_SubCameraModification._ScriptStructPtr);
		}

		// Token: 0x17006533 RID: 25907
		// (get) Token: 0x06029C5A RID: 171098 RVA: 0x009CC2A9 File Offset: 0x009CA4A9
		// (set) Token: 0x06029C5B RID: 171099 RVA: 0x009CC2BD File Offset: 0x009CA4BD
		public unsafe string CameraTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006534 RID: 25908
		// (get) Token: 0x06029C5C RID: 171100 RVA: 0x009CC2D2 File Offset: 0x009CA4D2
		// (set) Token: 0x06029C5D RID: 171101 RVA: 0x009CC2E6 File Offset: 0x009CA4E6
		public unsafe string CameraType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006535 RID: 25909
		// (get) Token: 0x06029C5E RID: 171102 RVA: 0x009CC2FB File Offset: 0x009CA4FB
		// (set) Token: 0x06029C5F RID: 171103 RVA: 0x009CC30B File Offset: 0x009CA50B
		public unsafe int CameraPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006536 RID: 25910
		// (get) Token: 0x06029C60 RID: 171104 RVA: 0x009CC31C File Offset: 0x009CA51C
		// (set) Token: 0x06029C61 RID: 171105 RVA: 0x009CC35F File Offset: 0x009CA55F
		public TArray<SCameraDebugTool_CameraProperty> ModifiedProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_CameraProperty> result;
				if ((result = this._ModifiedProperties) == null)
				{
					result = (this._ModifiedProperties = new TArray<SCameraDebugTool_CameraProperty>(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedProperties.CopyAssign(value);
			}
		}

		// Token: 0x06029C62 RID: 171106 RVA: 0x009CC36D File Offset: 0x009CA56D
		public SCameraDebugTool_SubCameraModification()
		{
		}

		// Token: 0x06029C63 RID: 171107 RVA: 0x009CC375 File Offset: 0x009CA575
		public SCameraDebugTool_SubCameraModification(string CameraTag, string CameraType, int CameraPriority, TArray<SCameraDebugTool_CameraProperty> ModifiedProperties)
		{
			this.CameraTag = CameraTag;
			this.CameraType = CameraType;
			this.CameraPriority = CameraPriority;
			this.ModifiedProperties = ModifiedProperties;
		}

		// Token: 0x06029C64 RID: 171108 RVA: 0x009CC39A File Offset: 0x009CA59A
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_SubCameraModification.StaticStruct();
		}

		// Token: 0x06029C65 RID: 171109 RVA: 0x009CC3A6 File Offset: 0x009CA5A6
		[NullableContext(2)]
		public SCameraDebugTool_SubCameraModification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C66 RID: 171110 RVA: 0x009CC3B0 File Offset: 0x009CA5B0
		public SCameraDebugTool_SubCameraModification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C67 RID: 171111 RVA: 0x009CC3BB File Offset: 0x009CA5BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_SubCameraModification(Pointer, false, true);
		}

		// Token: 0x06029C68 RID: 171112 RVA: 0x009CC3C5 File Offset: 0x009CA5C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_SubCameraModification(Pointer, MemoryOwner);
		}

		// Token: 0x04015738 RID: 87864
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification";

		// Token: 0x04015739 RID: 87865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401573A RID: 87866
		internal static int __PropertyOffset_0;

		// Token: 0x0401573B RID: 87867
		internal static int __PropertyOffset_1;

		// Token: 0x0401573C RID: 87868
		internal static int __PropertyOffset_2;

		// Token: 0x0401573D RID: 87869
		internal static int __PropertyOffset_3;

		// Token: 0x0401573E RID: 87870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_CameraProperty> _ModifiedProperties;
	}
}
