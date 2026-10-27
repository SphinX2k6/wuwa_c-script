using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Montage.Struct
{
	// Token: 0x02003EF5 RID: 16117
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Montage/Struct/SMontageRes.SMontageRes")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SMontageRes : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028D10 RID: 167184 RVA: 0x009B5460 File Offset: 0x009B3660
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMontageRes._ScriptStructPtr != 0) ? SMontageRes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Montage/Struct/SMontageRes.SMontageRes", ref SMontageRes._ScriptStructPtr);
		}

		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x06028D11 RID: 167185 RVA: 0x009B5484 File Offset: 0x009B3684
		// (set) Token: 0x06028D12 RID: 167186 RVA: 0x009B5498 File Offset: 0x009B3698
		[Nullable(2)]
		public unsafe UAnimMontage Montage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + SMontageRes.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMontageRes.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x06028D13 RID: 167187 RVA: 0x009B54AD File Offset: 0x009B36AD
		// (set) Token: 0x06028D14 RID: 167188 RVA: 0x009B54C1 File Offset: 0x009B36C1
		public unsafe string Des
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SMontageRes.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SMontageRes.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06028D15 RID: 167189 RVA: 0x009B54D6 File Offset: 0x009B36D6
		public SMontageRes()
		{
		}

		// Token: 0x06028D16 RID: 167190 RVA: 0x009B54DE File Offset: 0x009B36DE
		public SMontageRes(UAnimMontage Montage, string Des)
		{
			this.Montage = Montage;
			this.Des = Des;
		}

		// Token: 0x06028D17 RID: 167191 RVA: 0x009B54F4 File Offset: 0x009B36F4
		protected override IntPtr GetUStructPtr()
		{
			return SMontageRes.StaticStruct();
		}

		// Token: 0x06028D18 RID: 167192 RVA: 0x009B5500 File Offset: 0x009B3700
		[NullableContext(2)]
		public SMontageRes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028D19 RID: 167193 RVA: 0x009B550A File Offset: 0x009B370A
		public SMontageRes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028D1A RID: 167194 RVA: 0x009B5515 File Offset: 0x009B3715
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMontageRes(Pointer, false, true);
		}

		// Token: 0x06028D1B RID: 167195 RVA: 0x009B551F File Offset: 0x009B371F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMontageRes(Pointer, MemoryOwner);
		}

		// Token: 0x04014DED RID: 85485
		public const string __ObjectPath = "/Game/Aki/Data/Montage/Struct/SMontageRes.SMontageRes";

		// Token: 0x04014DEE RID: 85486
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DEF RID: 85487
		internal static int __PropertyOffset_0;

		// Token: 0x04014DF0 RID: 85488
		internal static int __PropertyOffset_1;
	}
}
