using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB5 RID: 16053
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SQtaResultAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289A2 RID: 166306 RVA: 0x009B03CA File Offset: 0x009AE5CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaResultAction._ScriptStructPtr != 0) ? SQtaResultAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction", ref SQtaResultAction._ScriptStructPtr);
		}

		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x060289A3 RID: 166307 RVA: 0x009B03EE File Offset: 0x009AE5EE
		// (set) Token: 0x060289A4 RID: 166308 RVA: 0x009B0402 File Offset: 0x009AE602
		public unsafe TEnumAsByte<EQtaResultType> ResultType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x060289A5 RID: 166309 RVA: 0x009B0418 File Offset: 0x009AE618
		// (set) Token: 0x060289A6 RID: 166310 RVA: 0x009B045B File Offset: 0x009AE65B
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
					result = (this._Actions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SQtaResultAction.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Actions.CopyAssign(value);
			}
		}

		// Token: 0x060289A7 RID: 166311 RVA: 0x009B0469 File Offset: 0x009AE669
		public SQtaResultAction()
		{
		}

		// Token: 0x060289A8 RID: 166312 RVA: 0x009B0471 File Offset: 0x009AE671
		public SQtaResultAction(TEnumAsByte<EQtaResultType> ResultType, [Nullable(1)] TArray<SBattleQteAction> Actions)
		{
			this.ResultType = ResultType;
			this.Actions = Actions;
		}

		// Token: 0x060289A9 RID: 166313 RVA: 0x009B0487 File Offset: 0x009AE687
		protected override IntPtr GetUStructPtr()
		{
			return SQtaResultAction.StaticStruct();
		}

		// Token: 0x060289AA RID: 166314 RVA: 0x009B0493 File Offset: 0x009AE693
		[NullableContext(2)]
		public SQtaResultAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060289AB RID: 166315 RVA: 0x009B049D File Offset: 0x009AE69D
		public SQtaResultAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289AC RID: 166316 RVA: 0x009B04A8 File Offset: 0x009AE6A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaResultAction(Pointer, false, true);
		}

		// Token: 0x060289AD RID: 166317 RVA: 0x009B04B2 File Offset: 0x009AE6B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaResultAction(Pointer, MemoryOwner);
		}

		// Token: 0x04014B8B RID: 84875
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaResultAction.SQtaResultAction";

		// Token: 0x04014B8C RID: 84876
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B8D RID: 84877
		internal static int __PropertyOffset_0;

		// Token: 0x04014B8E RID: 84878
		internal static int __PropertyOffset_1;

		// Token: 0x04014B8F RID: 84879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _Actions;
	}
}
