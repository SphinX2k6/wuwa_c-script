using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FBC RID: 16316
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SCameraDebugTool_ControllerModification : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C49 RID: 171081 RVA: 0x009CC15C File Offset: 0x009CA35C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_ControllerModification._ScriptStructPtr != 0) ? SCameraDebugTool_ControllerModification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification", ref SCameraDebugTool_ControllerModification._ScriptStructPtr);
		}

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x06029C4A RID: 171082 RVA: 0x009CC180 File Offset: 0x009CA380
		// (set) Token: 0x06029C4B RID: 171083 RVA: 0x009CC194 File Offset: 0x009CA394
		public unsafe string ControllerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006530 RID: 25904
		// (get) Token: 0x06029C4C RID: 171084 RVA: 0x009CC1A9 File Offset: 0x009CA3A9
		// (set) Token: 0x06029C4D RID: 171085 RVA: 0x009CC1BD File Offset: 0x009CA3BD
		public unsafe string PropertyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006531 RID: 25905
		// (get) Token: 0x06029C4E RID: 171086 RVA: 0x009CC1D2 File Offset: 0x009CA3D2
		// (set) Token: 0x06029C4F RID: 171087 RVA: 0x009CC1E6 File Offset: 0x009CA3E6
		public unsafe string OldValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006532 RID: 25906
		// (get) Token: 0x06029C50 RID: 171088 RVA: 0x009CC1FB File Offset: 0x009CA3FB
		// (set) Token: 0x06029C51 RID: 171089 RVA: 0x009CC20F File Offset: 0x009CA40F
		public unsafe string NewValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_ControllerModification.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x06029C52 RID: 171090 RVA: 0x009CC224 File Offset: 0x009CA424
		public SCameraDebugTool_ControllerModification()
		{
		}

		// Token: 0x06029C53 RID: 171091 RVA: 0x009CC22C File Offset: 0x009CA42C
		public SCameraDebugTool_ControllerModification(string ControllerName, string PropertyName, string OldValue, string NewValue)
		{
			this.ControllerName = ControllerName;
			this.PropertyName = PropertyName;
			this.OldValue = OldValue;
			this.NewValue = NewValue;
		}

		// Token: 0x06029C54 RID: 171092 RVA: 0x009CC251 File Offset: 0x009CA451
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_ControllerModification.StaticStruct();
		}

		// Token: 0x06029C55 RID: 171093 RVA: 0x009CC25D File Offset: 0x009CA45D
		[NullableContext(2)]
		public SCameraDebugTool_ControllerModification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C56 RID: 171094 RVA: 0x009CC267 File Offset: 0x009CA467
		public SCameraDebugTool_ControllerModification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C57 RID: 171095 RVA: 0x009CC272 File Offset: 0x009CA472
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_ControllerModification(Pointer, false, true);
		}

		// Token: 0x06029C58 RID: 171096 RVA: 0x009CC27C File Offset: 0x009CA47C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_ControllerModification(Pointer, MemoryOwner);
		}

		// Token: 0x04015732 RID: 87858
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_ControllerModification.SCameraDebugTool_ControllerModification";

		// Token: 0x04015733 RID: 87859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015734 RID: 87860
		internal static int __PropertyOffset_0;

		// Token: 0x04015735 RID: 87861
		internal static int __PropertyOffset_1;

		// Token: 0x04015736 RID: 87862
		internal static int __PropertyOffset_2;

		// Token: 0x04015737 RID: 87863
		internal static int __PropertyOffset_3;
	}
}
