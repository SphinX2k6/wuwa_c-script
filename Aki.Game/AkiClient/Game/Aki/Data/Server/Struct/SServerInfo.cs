using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Server.Struct
{
	// Token: 0x02003E97 RID: 16023
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SServerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602881D RID: 165917 RVA: 0x009AE073 File Offset: 0x009AC273
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SServerInfo._ScriptStructPtr != 0) ? SServerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo", ref SServerInfo._ScriptStructPtr);
		}

		// Token: 0x17005E3B RID: 24123
		// (get) Token: 0x0602881E RID: 165918 RVA: 0x009AE097 File Offset: 0x009AC297
		// (set) Token: 0x0602881F RID: 165919 RVA: 0x009AE0AB File Offset: 0x009AC2AB
		public unsafe string IP
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x06028820 RID: 165920 RVA: 0x009AE0C0 File Offset: 0x009AC2C0
		// (set) Token: 0x06028821 RID: 165921 RVA: 0x009AE0D4 File Offset: 0x009AC2D4
		public unsafe string Port
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x06028822 RID: 165922 RVA: 0x009AE0E9 File Offset: 0x009AC2E9
		// (set) Token: 0x06028823 RID: 165923 RVA: 0x009AE0FD File Offset: 0x009AC2FD
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x06028824 RID: 165924 RVA: 0x009AE112 File Offset: 0x009AC312
		// (set) Token: 0x06028825 RID: 165925 RVA: 0x009AE126 File Offset: 0x009AC326
		public unsafe string Stream
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SServerInfo.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005E3F RID: 24127
		// (get) Token: 0x06028826 RID: 165926 RVA: 0x009AE13B File Offset: 0x009AC33B
		// (set) Token: 0x06028827 RID: 165927 RVA: 0x009AE14B File Offset: 0x009AC34B
		public unsafe bool Editor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E40 RID: 24128
		// (get) Token: 0x06028828 RID: 165928 RVA: 0x009AE15C File Offset: 0x009AC35C
		// (set) Token: 0x06028829 RID: 165929 RVA: 0x009AE16C File Offset: 0x009AC36C
		public unsafe bool Package
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x0602882A RID: 165930 RVA: 0x009AE17D File Offset: 0x009AC37D
		// (set) Token: 0x0602882B RID: 165931 RVA: 0x009AE18D File Offset: 0x009AC38D
		public unsafe int Order
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SServerInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602882C RID: 165932 RVA: 0x009AE19E File Offset: 0x009AC39E
		public SServerInfo()
		{
		}

		// Token: 0x0602882D RID: 165933 RVA: 0x009AE1A6 File Offset: 0x009AC3A6
		public SServerInfo(string IP, string Port, string Name, string Stream, bool Editor, bool Package, int Order)
		{
			this.IP = IP;
			this.Port = Port;
			this.Name = Name;
			this.Stream = Stream;
			this.Editor = Editor;
			this.Package = Package;
			this.Order = Order;
		}

		// Token: 0x0602882E RID: 165934 RVA: 0x009AE1E3 File Offset: 0x009AC3E3
		protected override IntPtr GetUStructPtr()
		{
			return SServerInfo.StaticStruct();
		}

		// Token: 0x0602882F RID: 165935 RVA: 0x009AE1EF File Offset: 0x009AC3EF
		[NullableContext(2)]
		public SServerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028830 RID: 165936 RVA: 0x009AE1F9 File Offset: 0x009AC3F9
		public SServerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028831 RID: 165937 RVA: 0x009AE204 File Offset: 0x009AC404
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SServerInfo(Pointer, false, true);
		}

		// Token: 0x06028832 RID: 165938 RVA: 0x009AE20E File Offset: 0x009AC40E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SServerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014A9A RID: 84634
		public const string __ObjectPath = "/Game/Aki/Data/Server/Struct/SServerInfo.SServerInfo";

		// Token: 0x04014A9B RID: 84635
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014A9C RID: 84636
		internal static int __PropertyOffset_0;

		// Token: 0x04014A9D RID: 84637
		internal static int __PropertyOffset_1;

		// Token: 0x04014A9E RID: 84638
		internal static int __PropertyOffset_2;

		// Token: 0x04014A9F RID: 84639
		internal static int __PropertyOffset_3;

		// Token: 0x04014AA0 RID: 84640
		internal static int __PropertyOffset_4;

		// Token: 0x04014AA1 RID: 84641
		internal static int __PropertyOffset_5;

		// Token: 0x04014AA2 RID: 84642
		internal static int __PropertyOffset_6;
	}
}
