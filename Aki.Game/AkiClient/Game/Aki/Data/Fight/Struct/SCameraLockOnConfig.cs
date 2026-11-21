using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003202 RID: 12802
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SCameraLockOnConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDED RID: 130541 RVA: 0x00937D25 File Offset: 0x00935F25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraLockOnConfig._ScriptStructPtr != 0) ? SCameraLockOnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig", ref SCameraLockOnConfig._ScriptStructPtr);
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0601FDEE RID: 130542 RVA: 0x00937D49 File Offset: 0x00935F49
		// (set) Token: 0x0601FDEF RID: 130543 RVA: 0x00937D59 File Offset: 0x00935F59
		public unsafe bool IsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraLockOnConfig.__PropertyOffset_IsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraLockOnConfig.__PropertyOffset_IsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0601FDF0 RID: 130544 RVA: 0x00937D6A File Offset: 0x00935F6A
		// (set) Token: 0x0601FDF1 RID: 130545 RVA: 0x00937D7E File Offset: 0x00935F7E
		public unsafe string CameraLockOnBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraLockOnConfig.__PropertyOffset_CameraLockOnBoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraLockOnConfig.__PropertyOffset_CameraLockOnBoneName)), value);
			}
		}

		// Token: 0x0601FDF2 RID: 130546 RVA: 0x00937D93 File Offset: 0x00935F93
		public SCameraLockOnConfig()
		{
		}

		// Token: 0x0601FDF3 RID: 130547 RVA: 0x00937D9B File Offset: 0x00935F9B
		protected override IntPtr GetUStructPtr()
		{
			return SCameraLockOnConfig.StaticStruct();
		}

		// Token: 0x0601FDF4 RID: 130548 RVA: 0x00937DA7 File Offset: 0x00935FA7
		[NullableContext(2)]
		public SCameraLockOnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDF5 RID: 130549 RVA: 0x00937DB1 File Offset: 0x00935FB1
		public SCameraLockOnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDF6 RID: 130550 RVA: 0x00937DBC File Offset: 0x00935FBC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraLockOnConfig(Pointer, false, true);
		}

		// Token: 0x0601FDF7 RID: 130551 RVA: 0x00937DC6 File Offset: 0x00935FC6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraLockOnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040111D7 RID: 70103
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCameraLockOnConfig.SCameraLockOnConfig";

		// Token: 0x040111D8 RID: 70104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111D9 RID: 70105
		internal static int __PropertyOffset_IsEnabled;

		// Token: 0x040111DA RID: 70106
		internal static int __PropertyOffset_CameraLockOnBoneName;
	}
}
