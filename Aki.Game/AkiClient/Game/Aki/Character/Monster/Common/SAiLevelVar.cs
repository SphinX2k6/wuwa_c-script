using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x02004252 RID: 16978
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SAiLevelVar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602BFB9 RID: 180153 RVA: 0x00A10F6B File Offset: 0x00A0F16B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiLevelVar._ScriptStructPtr != 0) ? SAiLevelVar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar", ref SAiLevelVar._ScriptStructPtr);
		}

		// Token: 0x17006D2A RID: 27946
		// (get) Token: 0x0602BFBA RID: 180154 RVA: 0x00A10F8F File Offset: 0x00A0F18F
		// (set) Token: 0x0602BFBB RID: 180155 RVA: 0x00A10FA3 File Offset: 0x00A0F1A3
		public unsafe TEnumAsByte<EAiLevelVarSource> VarSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006D2B RID: 27947
		// (get) Token: 0x0602BFBC RID: 180156 RVA: 0x00A10FB8 File Offset: 0x00A0F1B8
		// (set) Token: 0x0602BFBD RID: 180157 RVA: 0x00A10FCC File Offset: 0x00A0F1CC
		[Nullable(1)]
		public unsafe string VarName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAiLevelVar.__PropertyOffset_1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAiLevelVar.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006D2C RID: 27948
		// (get) Token: 0x0602BFBE RID: 180158 RVA: 0x00A10FE1 File Offset: 0x00A0F1E1
		// (set) Token: 0x0602BFBF RID: 180159 RVA: 0x00A10FF1 File Offset: 0x00A0F1F1
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiLevelVar.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602BFC0 RID: 180160 RVA: 0x00A11002 File Offset: 0x00A0F202
		public SAiLevelVar()
		{
		}

		// Token: 0x0602BFC1 RID: 180161 RVA: 0x00A1100A File Offset: 0x00A0F20A
		public SAiLevelVar(TEnumAsByte<EAiLevelVarSource> VarSource, [Nullable(1)] string VarName, int Id)
		{
			this.VarSource = VarSource;
			this.VarName = VarName;
			this.Id = Id;
		}

		// Token: 0x0602BFC2 RID: 180162 RVA: 0x00A11027 File Offset: 0x00A0F227
		protected override IntPtr GetUStructPtr()
		{
			return SAiLevelVar.StaticStruct();
		}

		// Token: 0x0602BFC3 RID: 180163 RVA: 0x00A11033 File Offset: 0x00A0F233
		[NullableContext(2)]
		public SAiLevelVar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602BFC4 RID: 180164 RVA: 0x00A1103D File Offset: 0x00A0F23D
		public SAiLevelVar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602BFC5 RID: 180165 RVA: 0x00A11048 File Offset: 0x00A0F248
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiLevelVar(Pointer, false, true);
		}

		// Token: 0x0602BFC6 RID: 180166 RVA: 0x00A11052 File Offset: 0x00A0F252
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiLevelVar(Pointer, MemoryOwner);
		}

		// Token: 0x04016F8F RID: 94095
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiLevelVar.SAiLevelVar";

		// Token: 0x04016F90 RID: 94096
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016F91 RID: 94097
		internal static int __PropertyOffset_0;

		// Token: 0x04016F92 RID: 94098
		internal static int __PropertyOffset_1;

		// Token: 0x04016F93 RID: 94099
		internal static int __PropertyOffset_2;
	}
}
