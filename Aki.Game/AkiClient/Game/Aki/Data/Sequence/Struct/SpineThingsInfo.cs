using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Sequence.Struct
{
	// Token: 0x02003172 RID: 12658
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 17)]
	public class SpineThingsInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3A1 RID: 127905 RVA: 0x009290CA File Offset: 0x009272CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SpineThingsInfo._ScriptStructPtr != 0) ? SpineThingsInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo", ref SpineThingsInfo._ScriptStructPtr);
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0601F3A2 RID: 127906 RVA: 0x009290EE File Offset: 0x009272EE
		// (set) Token: 0x0601F3A3 RID: 127907 RVA: 0x00929102 File Offset: 0x00927302
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SpineThingsInfo.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SpineThingsInfo.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0601F3A4 RID: 127908 RVA: 0x00929117 File Offset: 0x00927317
		// (set) Token: 0x0601F3A5 RID: 127909 RVA: 0x00929127 File Offset: 0x00927327
		public unsafe bool NeedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SpineThingsInfo.__PropertyOffset_NeedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SpineThingsInfo.__PropertyOffset_NeedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F3A6 RID: 127910 RVA: 0x00929138 File Offset: 0x00927338
		public SpineThingsInfo()
		{
		}

		// Token: 0x0601F3A7 RID: 127911 RVA: 0x00929140 File Offset: 0x00927340
		protected override IntPtr GetUStructPtr()
		{
			return SpineThingsInfo.StaticStruct();
		}

		// Token: 0x0601F3A8 RID: 127912 RVA: 0x0092914C File Offset: 0x0092734C
		[NullableContext(2)]
		public SpineThingsInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3A9 RID: 127913 RVA: 0x00929156 File Offset: 0x00927356
		public SpineThingsInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3AA RID: 127914 RVA: 0x00929161 File Offset: 0x00927361
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SpineThingsInfo(Pointer, false, true);
		}

		// Token: 0x0601F3AB RID: 127915 RVA: 0x0092916B File Offset: 0x0092736B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SpineThingsInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010B33 RID: 68403
		public const string __ObjectPath = "/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo";

		// Token: 0x04010B34 RID: 68404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B35 RID: 68405
		internal static int __PropertyOffset_Name;

		// Token: 0x04010B36 RID: 68406
		internal static int __PropertyOffset_NeedLoop;
	}
}
