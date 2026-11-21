using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.NPC.LevelAiBtTree
{
	// Token: 0x020031B4 RID: 12724
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 101)]
	public class SVarRefContext : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F6B2 RID: 128690 RVA: 0x0092D5D9 File Offset: 0x0092B7D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVarRefContext._ScriptStructPtr != 0) ? SVarRefContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext", ref SVarRefContext._ScriptStructPtr);
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0601F6B3 RID: 128691 RVA: 0x0092D5FD File Offset: 0x0092B7FD
		// (set) Token: 0x0601F6B4 RID: 128692 RVA: 0x0092D611 File Offset: 0x0092B811
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0601F6B5 RID: 128693 RVA: 0x0092D626 File Offset: 0x0092B826
		// (set) Token: 0x0601F6B6 RID: 128694 RVA: 0x0092D63A File Offset: 0x0092B83A
		public unsafe string VarRefSource
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_VarRefSource)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_VarRefSource)), value);
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0601F6B7 RID: 128695 RVA: 0x0092D64F File Offset: 0x0092B84F
		// (set) Token: 0x0601F6B8 RID: 128696 RVA: 0x0092D663 File Offset: 0x0092B863
		public unsafe string VarRefType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_VarRefType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_VarRefType)), value);
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0601F6B9 RID: 128697 RVA: 0x0092D678 File Offset: 0x0092B878
		// (set) Token: 0x0601F6BA RID: 128698 RVA: 0x0092D688 File Offset: 0x0092B888
		public unsafe int RefId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_RefId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_RefId) = value;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0601F6BB RID: 128699 RVA: 0x0092D699 File Offset: 0x0092B899
		// (set) Token: 0x0601F6BC RID: 128700 RVA: 0x0092D6AD File Offset: 0x0092B8AD
		public unsafe string Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_Key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_Key)), value);
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0601F6BD RID: 128701 RVA: 0x0092D6C2 File Offset: 0x0092B8C2
		// (set) Token: 0x0601F6BE RID: 128702 RVA: 0x0092D6D6 File Offset: 0x0092B8D6
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_StringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0601F6BF RID: 128703 RVA: 0x0092D6EB File Offset: 0x0092B8EB
		// (set) Token: 0x0601F6C0 RID: 128704 RVA: 0x0092D6FB File Offset: 0x0092B8FB
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_BoolValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_BoolValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0601F6C1 RID: 128705 RVA: 0x0092D70C File Offset: 0x0092B90C
		// (set) Token: 0x0601F6C2 RID: 128706 RVA: 0x0092D71C File Offset: 0x0092B91C
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0601F6C3 RID: 128707 RVA: 0x0092D72D File Offset: 0x0092B92D
		// (set) Token: 0x0601F6C4 RID: 128708 RVA: 0x0092D73D File Offset: 0x0092B93D
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0601F6C5 RID: 128709 RVA: 0x0092D74E File Offset: 0x0092B94E
		// (set) Token: 0x0601F6C6 RID: 128710 RVA: 0x0092D75E File Offset: 0x0092B95E
		public unsafe bool IsClientVariable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_IsClientVariable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_IsClientVariable) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F6C7 RID: 128711 RVA: 0x0092D76F File Offset: 0x0092B96F
		public SVarRefContext()
		{
		}

		// Token: 0x0601F6C8 RID: 128712 RVA: 0x0092D777 File Offset: 0x0092B977
		protected override IntPtr GetUStructPtr()
		{
			return SVarRefContext.StaticStruct();
		}

		// Token: 0x0601F6C9 RID: 128713 RVA: 0x0092D783 File Offset: 0x0092B983
		[NullableContext(2)]
		public SVarRefContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6CA RID: 128714 RVA: 0x0092D78D File Offset: 0x0092B98D
		public SVarRefContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6CB RID: 128715 RVA: 0x0092D798 File Offset: 0x0092B998
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVarRefContext(Pointer, false, true);
		}

		// Token: 0x0601F6CC RID: 128716 RVA: 0x0092D7A2 File Offset: 0x0092B9A2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVarRefContext(Pointer, MemoryOwner);
		}

		// Token: 0x04010D93 RID: 69011
		public const string __ObjectPath = "/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext";

		// Token: 0x04010D94 RID: 69012
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D95 RID: 69013
		internal static int __PropertyOffset_Type;

		// Token: 0x04010D96 RID: 69014
		internal static int __PropertyOffset_VarRefSource;

		// Token: 0x04010D97 RID: 69015
		internal static int __PropertyOffset_VarRefType;

		// Token: 0x04010D98 RID: 69016
		internal static int __PropertyOffset_RefId;

		// Token: 0x04010D99 RID: 69017
		internal static int __PropertyOffset_Key;

		// Token: 0x04010D9A RID: 69018
		internal static int __PropertyOffset_StringValue;

		// Token: 0x04010D9B RID: 69019
		internal static int __PropertyOffset_BoolValue;

		// Token: 0x04010D9C RID: 69020
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x04010D9D RID: 69021
		internal static int __PropertyOffset_IntValue;

		// Token: 0x04010D9E RID: 69022
		internal static int __PropertyOffset_IsClientVariable;
	}
}
