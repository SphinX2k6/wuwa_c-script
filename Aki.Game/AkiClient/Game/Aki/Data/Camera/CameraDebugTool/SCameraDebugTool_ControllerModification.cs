using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003244 RID: 12868
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SCameraDebugTool_ControllerModification : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020271 RID: 131697 RVA: 0x0093E83A File Offset: 0x0093CA3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_ControllerModification._ScriptStructPtr != 0) ? SCameraDebugTool_ControllerModification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification", ref SCameraDebugTool_ControllerModification._ScriptStructPtr);
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x06020272 RID: 131698 RVA: 0x0093E85E File Offset: 0x0093CA5E
		// (set) Token: 0x06020273 RID: 131699 RVA: 0x0093E872 File Offset: 0x0093CA72
		public unsafe string ControllerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_ControllerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_ControllerName)), value);
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x06020274 RID: 131700 RVA: 0x0093E887 File Offset: 0x0093CA87
		// (set) Token: 0x06020275 RID: 131701 RVA: 0x0093E89B File Offset: 0x0093CA9B
		public unsafe string PropertyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_PropertyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_PropertyName)), value);
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x06020276 RID: 131702 RVA: 0x0093E8B0 File Offset: 0x0093CAB0
		// (set) Token: 0x06020277 RID: 131703 RVA: 0x0093E8C4 File Offset: 0x0093CAC4
		public unsafe string OldValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_OldValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_OldValue)), value);
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x06020278 RID: 131704 RVA: 0x0093E8D9 File Offset: 0x0093CAD9
		// (set) Token: 0x06020279 RID: 131705 RVA: 0x0093E8ED File Offset: 0x0093CAED
		public unsafe string NewValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_NewValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_NewValue)), value);
			}
		}

		// Token: 0x0602027A RID: 131706 RVA: 0x0093E902 File Offset: 0x0093CB02
		public SCameraDebugTool_ControllerModification()
		{
		}

		// Token: 0x0602027B RID: 131707 RVA: 0x0093E90A File Offset: 0x0093CB0A
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_ControllerModification.StaticStruct();
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x0093E916 File Offset: 0x0093CB16
		[NullableContext(2)]
		public SCameraDebugTool_ControllerModification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x0093E920 File Offset: 0x0093CB20
		public SCameraDebugTool_ControllerModification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602027E RID: 131710 RVA: 0x0093E92B File Offset: 0x0093CB2B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_ControllerModification(Pointer, false, true);
		}

		// Token: 0x0602027F RID: 131711 RVA: 0x0093E935 File Offset: 0x0093CB35
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_ControllerModification(Pointer, MemoryOwner);
		}

		// Token: 0x040114DA RID: 70874
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification";

		// Token: 0x040114DB RID: 70875
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114DC RID: 70876
		internal static int __PropertyOffset_ControllerName;

		// Token: 0x040114DD RID: 70877
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x040114DE RID: 70878
		internal static int __PropertyOffset_OldValue;

		// Token: 0x040114DF RID: 70879
		internal static int __PropertyOffset_NewValue;
	}
}
