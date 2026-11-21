using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032CA RID: 13002
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SAiLevelVar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020EEE RID: 134894 RVA: 0x00952D86 File Offset: 0x00950F86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiLevelVar._ScriptStructPtr != 0) ? SAiLevelVar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar", ref SAiLevelVar._ScriptStructPtr);
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x06020EEF RID: 134895 RVA: 0x00952DAA File Offset: 0x00950FAA
		// (set) Token: 0x06020EF0 RID: 134896 RVA: 0x00952DBE File Offset: 0x00950FBE
		public unsafe TEnumAsByte<EAiLevelVarSource> VarSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_VarSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_VarSource) = value;
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x06020EF1 RID: 134897 RVA: 0x00952DD3 File Offset: 0x00950FD3
		// (set) Token: 0x06020EF2 RID: 134898 RVA: 0x00952DE7 File Offset: 0x00950FE7
		[Nullable(1)]
		public unsafe string VarName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAiLevelVar.__PropertyOffset_VarName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAiLevelVar.__PropertyOffset_VarName)), value);
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x06020EF3 RID: 134899 RVA: 0x00952DFC File Offset: 0x00950FFC
		// (set) Token: 0x06020EF4 RID: 134900 RVA: 0x00952E0C File Offset: 0x0095100C
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x06020EF5 RID: 134901 RVA: 0x00952E1D File Offset: 0x0095101D
		public SAiLevelVar()
		{
		}

		// Token: 0x06020EF6 RID: 134902 RVA: 0x00952E25 File Offset: 0x00951025
		protected override IntPtr GetUStructPtr()
		{
			return SAiLevelVar.StaticStruct();
		}

		// Token: 0x06020EF7 RID: 134903 RVA: 0x00952E31 File Offset: 0x00951031
		[NullableContext(2)]
		public SAiLevelVar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x00952E3B File Offset: 0x0095103B
		public SAiLevelVar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020EF9 RID: 134905 RVA: 0x00952E46 File Offset: 0x00951046
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiLevelVar(Pointer, false, true);
		}

		// Token: 0x06020EFA RID: 134906 RVA: 0x00952E50 File Offset: 0x00951050
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiLevelVar(Pointer, MemoryOwner);
		}

		// Token: 0x04011D6D RID: 73069
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar";

		// Token: 0x04011D6E RID: 73070
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011D6F RID: 73071
		internal static int __PropertyOffset_VarSource;

		// Token: 0x04011D70 RID: 73072
		internal static int __PropertyOffset_VarName;

		// Token: 0x04011D71 RID: 73073
		internal static int __PropertyOffset_Id;
	}
}
