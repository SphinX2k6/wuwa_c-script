using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PlayerInterface.Struct
{
	// Token: 0x02003EE0 RID: 16096
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/PlayerInterface/Struct/SPlayerInterfaceInfo.SPlayerInterfaceInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SPlayerInterfaceInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028BDD RID: 166877 RVA: 0x009B38A0 File Offset: 0x009B1AA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPlayerInterfaceInfo._ScriptStructPtr != 0) ? SPlayerInterfaceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PlayerInterface/Struct/SPlayerInterfaceInfo.SPlayerInterfaceInfo", ref SPlayerInterfaceInfo._ScriptStructPtr);
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x06028BDE RID: 166878 RVA: 0x009B38C4 File Offset: 0x009B1AC4
		// (set) Token: 0x06028BDF RID: 166879 RVA: 0x009B38D8 File Offset: 0x009B1AD8
		public unsafe FName 接口名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPlayerInterfaceInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPlayerInterfaceInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x06028BE0 RID: 166880 RVA: 0x009B38ED File Offset: 0x009B1AED
		// (set) Token: 0x06028BE1 RID: 166881 RVA: 0x009B3901 File Offset: 0x009B1B01
		public unsafe string 函数名称
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerInterfaceInfo.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerInterfaceInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06028BE2 RID: 166882 RVA: 0x009B3916 File Offset: 0x009B1B16
		public SPlayerInterfaceInfo()
		{
		}

		// Token: 0x06028BE3 RID: 166883 RVA: 0x009B391E File Offset: 0x009B1B1E
		public SPlayerInterfaceInfo(FName 接口名称, string 函数名称)
		{
			this.接口名称 = 接口名称;
			this.函数名称 = 函数名称;
		}

		// Token: 0x06028BE4 RID: 166884 RVA: 0x009B3934 File Offset: 0x009B1B34
		protected override IntPtr GetUStructPtr()
		{
			return SPlayerInterfaceInfo.StaticStruct();
		}

		// Token: 0x06028BE5 RID: 166885 RVA: 0x009B3940 File Offset: 0x009B1B40
		[NullableContext(2)]
		public SPlayerInterfaceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028BE6 RID: 166886 RVA: 0x009B394A File Offset: 0x009B1B4A
		public SPlayerInterfaceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028BE7 RID: 166887 RVA: 0x009B3955 File Offset: 0x009B1B55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPlayerInterfaceInfo(Pointer, false, true);
		}

		// Token: 0x06028BE8 RID: 166888 RVA: 0x009B395F File Offset: 0x009B1B5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPlayerInterfaceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014D2C RID: 85292
		public const string __ObjectPath = "/Game/Aki/Data/PlayerInterface/Struct/SPlayerInterfaceInfo.SPlayerInterfaceInfo";

		// Token: 0x04014D2D RID: 85293
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D2E RID: 85294
		internal static int __PropertyOffset_0;

		// Token: 0x04014D2F RID: 85295
		internal static int __PropertyOffset_1;
	}
}
