using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003182 RID: 12674
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SQtaResultAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F441 RID: 128065 RVA: 0x00929F4D File Offset: 0x0092814D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaResultAction._ScriptStructPtr != 0) ? SQtaResultAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction", ref SQtaResultAction._ScriptStructPtr);
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0601F442 RID: 128066 RVA: 0x00929F71 File Offset: 0x00928171
		// (set) Token: 0x0601F443 RID: 128067 RVA: 0x00929F85 File Offset: 0x00928185
		public unsafe TEnumAsByte<EQtaResultType> ResultType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_ResultType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_ResultType) = value;
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0601F444 RID: 128068 RVA: 0x00929F9C File Offset: 0x0092819C
		// (set) Token: 0x0601F445 RID: 128069 RVA: 0x00929FDF File Offset: 0x009281DF
		[Nullable(1)]
		public TArray<SBattleQteAction> Actions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SBattleQteAction> result;
				if ((result = this._Actions) == null)
				{
					result = (this._Actions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_Actions, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Actions.CopyAssign(value);
			}
		}

		// Token: 0x0601F446 RID: 128070 RVA: 0x00929FED File Offset: 0x009281ED
		public SQtaResultAction()
		{
		}

		// Token: 0x0601F447 RID: 128071 RVA: 0x00929FF5 File Offset: 0x009281F5
		protected override IntPtr GetUStructPtr()
		{
			return SQtaResultAction.StaticStruct();
		}

		// Token: 0x0601F448 RID: 128072 RVA: 0x0092A001 File Offset: 0x00928201
		[NullableContext(2)]
		public SQtaResultAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F449 RID: 128073 RVA: 0x0092A00B File Offset: 0x0092820B
		public SQtaResultAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F44A RID: 128074 RVA: 0x0092A016 File Offset: 0x00928216
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaResultAction(Pointer, false, true);
		}

		// Token: 0x0601F44B RID: 128075 RVA: 0x0092A020 File Offset: 0x00928220
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaResultAction(Pointer, MemoryOwner);
		}

		// Token: 0x04010BB3 RID: 68531
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction";

		// Token: 0x04010BB4 RID: 68532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BB5 RID: 68533
		internal static int __PropertyOffset_ResultType;

		// Token: 0x04010BB6 RID: 68534
		internal static int __PropertyOffset_Actions;

		// Token: 0x04010BB7 RID: 68535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _Actions;
	}
}
