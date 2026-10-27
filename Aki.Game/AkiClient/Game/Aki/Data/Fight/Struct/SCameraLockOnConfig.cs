using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F60 RID: 16224
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SCameraLockOnConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602954E RID: 169294 RVA: 0x009C1888 File Offset: 0x009BFA88
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraLockOnConfig._ScriptStructPtr != 0) ? SCameraLockOnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig", ref SCameraLockOnConfig._ScriptStructPtr);
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x0602954F RID: 169295 RVA: 0x009C18AC File Offset: 0x009BFAAC
		// (set) Token: 0x06029550 RID: 169296 RVA: 0x009C18BC File Offset: 0x009BFABC
		public unsafe bool IsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraLockOnConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraLockOnConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x06029551 RID: 169297 RVA: 0x009C18CD File Offset: 0x009BFACD
		// (set) Token: 0x06029552 RID: 169298 RVA: 0x009C18E1 File Offset: 0x009BFAE1
		public unsafe string CameraLockOnBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraLockOnConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraLockOnConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06029553 RID: 169299 RVA: 0x009C18F6 File Offset: 0x009BFAF6
		public SCameraLockOnConfig()
		{
		}

		// Token: 0x06029554 RID: 169300 RVA: 0x009C18FE File Offset: 0x009BFAFE
		public SCameraLockOnConfig(bool IsEnabled, string CameraLockOnBoneName)
		{
			this.IsEnabled = IsEnabled;
			this.CameraLockOnBoneName = CameraLockOnBoneName;
		}

		// Token: 0x06029555 RID: 169301 RVA: 0x009C1914 File Offset: 0x009BFB14
		protected override IntPtr GetUStructPtr()
		{
			return SCameraLockOnConfig.StaticStruct();
		}

		// Token: 0x06029556 RID: 169302 RVA: 0x009C1920 File Offset: 0x009BFB20
		[NullableContext(2)]
		public SCameraLockOnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029557 RID: 169303 RVA: 0x009C192A File Offset: 0x009BFB2A
		public SCameraLockOnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029558 RID: 169304 RVA: 0x009C1935 File Offset: 0x009BFB35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraLockOnConfig(Pointer, false, true);
		}

		// Token: 0x06029559 RID: 169305 RVA: 0x009C193F File Offset: 0x009BFB3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraLockOnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040152D8 RID: 86744
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig";

		// Token: 0x040152D9 RID: 86745
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152DA RID: 86746
		internal static int __PropertyOffset_0;

		// Token: 0x040152DB RID: 86747
		internal static int __PropertyOffset_1;
	}
}
