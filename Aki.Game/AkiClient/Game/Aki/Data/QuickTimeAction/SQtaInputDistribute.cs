using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB2 RID: 16050
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute")]
	[UnrealStructLayout(5, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5)]
	public class SQtaInputDistribute : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028970 RID: 166256 RVA: 0x009AFF58 File Offset: 0x009AE158
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaInputDistribute._ScriptStructPtr != 0) ? SQtaInputDistribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute", ref SQtaInputDistribute._ScriptStructPtr);
		}

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x06028971 RID: 166257 RVA: 0x009AFF7C File Offset: 0x009AE17C
		// (set) Token: 0x06028972 RID: 166258 RVA: 0x009AFF8C File Offset: 0x009AE18C
		public unsafe bool FightInputRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x06028973 RID: 166259 RVA: 0x009AFF9D File Offset: 0x009AE19D
		// (set) Token: 0x06028974 RID: 166260 RVA: 0x009AFFAD File Offset: 0x009AE1AD
		public unsafe bool FightActionInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x06028975 RID: 166261 RVA: 0x009AFFBE File Offset: 0x009AE1BE
		// (set) Token: 0x06028976 RID: 166262 RVA: 0x009AFFCE File Offset: 0x009AE1CE
		public unsafe bool FightAxisInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x06028977 RID: 166263 RVA: 0x009AFFDF File Offset: 0x009AE1DF
		// (set) Token: 0x06028978 RID: 166264 RVA: 0x009AFFEF File Offset: 0x009AE1EF
		public unsafe bool InteractionRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x06028979 RID: 166265 RVA: 0x009B0000 File Offset: 0x009AE200
		// (set) Token: 0x0602897A RID: 166266 RVA: 0x009B0010 File Offset: 0x009AE210
		public unsafe bool UiInputRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602897B RID: 166267 RVA: 0x009B0021 File Offset: 0x009AE221
		public SQtaInputDistribute()
		{
		}

		// Token: 0x0602897C RID: 166268 RVA: 0x009B0029 File Offset: 0x009AE229
		public SQtaInputDistribute(bool FightInputRoot, bool FightActionInput, bool FightAxisInput, bool InteractionRoot, bool UiInputRoot)
		{
			this.FightInputRoot = FightInputRoot;
			this.FightActionInput = FightActionInput;
			this.FightAxisInput = FightAxisInput;
			this.InteractionRoot = InteractionRoot;
			this.UiInputRoot = UiInputRoot;
		}

		// Token: 0x0602897D RID: 166269 RVA: 0x009B0056 File Offset: 0x009AE256
		protected override IntPtr GetUStructPtr()
		{
			return SQtaInputDistribute.StaticStruct();
		}

		// Token: 0x0602897E RID: 166270 RVA: 0x009B0062 File Offset: 0x009AE262
		[NullableContext(2)]
		public SQtaInputDistribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602897F RID: 166271 RVA: 0x009B006C File Offset: 0x009AE26C
		public SQtaInputDistribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028980 RID: 166272 RVA: 0x009B0077 File Offset: 0x009AE277
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaInputDistribute(Pointer, false, true);
		}

		// Token: 0x06028981 RID: 166273 RVA: 0x009B0081 File Offset: 0x009AE281
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaInputDistribute(Pointer, MemoryOwner);
		}

		// Token: 0x04014B76 RID: 84854
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute";

		// Token: 0x04014B77 RID: 84855
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B78 RID: 84856
		internal static int __PropertyOffset_0;

		// Token: 0x04014B79 RID: 84857
		internal static int __PropertyOffset_1;

		// Token: 0x04014B7A RID: 84858
		internal static int __PropertyOffset_2;

		// Token: 0x04014B7B RID: 84859
		internal static int __PropertyOffset_3;

		// Token: 0x04014B7C RID: 84860
		internal static int __PropertyOffset_4;
	}
}
