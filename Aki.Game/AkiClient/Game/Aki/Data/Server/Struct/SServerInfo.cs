using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Server.Struct
{
	// Token: 0x02003171 RID: 12657
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SServerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F38C RID: 127884 RVA: 0x00928F63 File Offset: 0x00927163
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SServerInfo._ScriptStructPtr != 0) ? SServerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo", ref SServerInfo._ScriptStructPtr);
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0601F38D RID: 127885 RVA: 0x00928F87 File Offset: 0x00927187
		// (set) Token: 0x0601F38E RID: 127886 RVA: 0x00928F9B File Offset: 0x0092719B
		public unsafe string IP
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_IP)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_IP)), value);
			}
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0601F38F RID: 127887 RVA: 0x00928FB0 File Offset: 0x009271B0
		// (set) Token: 0x0601F390 RID: 127888 RVA: 0x00928FC4 File Offset: 0x009271C4
		public unsafe string Port
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Port)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Port)), value);
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0601F391 RID: 127889 RVA: 0x00928FD9 File Offset: 0x009271D9
		// (set) Token: 0x0601F392 RID: 127890 RVA: 0x00928FED File Offset: 0x009271ED
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0601F393 RID: 127891 RVA: 0x00929002 File Offset: 0x00927202
		// (set) Token: 0x0601F394 RID: 127892 RVA: 0x00929016 File Offset: 0x00927216
		public unsafe string Stream
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Stream)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_Stream)), value);
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0601F395 RID: 127893 RVA: 0x0092902B File Offset: 0x0092722B
		// (set) Token: 0x0601F396 RID: 127894 RVA: 0x0092903B File Offset: 0x0092723B
		public unsafe bool Editor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Editor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Editor) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0601F397 RID: 127895 RVA: 0x0092904C File Offset: 0x0092724C
		// (set) Token: 0x0601F398 RID: 127896 RVA: 0x0092905C File Offset: 0x0092725C
		public unsafe bool Package
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Package) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Package) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0601F399 RID: 127897 RVA: 0x0092906D File Offset: 0x0092726D
		// (set) Token: 0x0601F39A RID: 127898 RVA: 0x0092907D File Offset: 0x0092727D
		public unsafe int Order
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Order);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_Order) = value;
			}
		}

		// Token: 0x0601F39B RID: 127899 RVA: 0x0092908E File Offset: 0x0092728E
		public SServerInfo()
		{
		}

		// Token: 0x0601F39C RID: 127900 RVA: 0x00929096 File Offset: 0x00927296
		protected override IntPtr GetUStructPtr()
		{
			return SServerInfo.StaticStruct();
		}

		// Token: 0x0601F39D RID: 127901 RVA: 0x009290A2 File Offset: 0x009272A2
		[NullableContext(2)]
		public SServerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F39E RID: 127902 RVA: 0x009290AC File Offset: 0x009272AC
		public SServerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F39F RID: 127903 RVA: 0x009290B7 File Offset: 0x009272B7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SServerInfo(Pointer, false, true);
		}

		// Token: 0x0601F3A0 RID: 127904 RVA: 0x009290C1 File Offset: 0x009272C1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SServerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010B2A RID: 68394
		public const string __ObjectPath = "/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo";

		// Token: 0x04010B2B RID: 68395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B2C RID: 68396
		internal static int __PropertyOffset_IP;

		// Token: 0x04010B2D RID: 68397
		internal static int __PropertyOffset_Port;

		// Token: 0x04010B2E RID: 68398
		internal static int __PropertyOffset_Name;

		// Token: 0x04010B2F RID: 68399
		internal static int __PropertyOffset_Stream;

		// Token: 0x04010B30 RID: 68400
		internal static int __PropertyOffset_Editor;

		// Token: 0x04010B31 RID: 68401
		internal static int __PropertyOffset_Package;

		// Token: 0x04010B32 RID: 68402
		internal static int __PropertyOffset_Order;
	}
}
