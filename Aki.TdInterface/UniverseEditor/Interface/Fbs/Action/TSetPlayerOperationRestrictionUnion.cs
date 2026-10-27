using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007787 RID: 30599
	public class TSetPlayerOperationRestrictionUnion
	{
		// Token: 0x1700E69D RID: 59037
		// (get) Token: 0x060378DC RID: 227548 RVA: 0x00784590 File Offset: 0x00782790
		// (set) Token: 0x060378DD RID: 227549 RVA: 0x00784598 File Offset: 0x00782798
		public TSetPlayerOperationRestriction Type { get; set; }

		// Token: 0x1700E69E RID: 59038
		// (get) Token: 0x060378DE RID: 227550 RVA: 0x007845A1 File Offset: 0x007827A1
		// (set) Token: 0x060378DF RID: 227551 RVA: 0x007845A9 File Offset: 0x007827A9
		public object Value { get; set; }

		// Token: 0x060378E0 RID: 227552 RVA: 0x007845B2 File Offset: 0x007827B2
		public TSetPlayerOperationRestrictionUnion()
		{
			this.Type = TSetPlayerOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x060378E1 RID: 227553 RVA: 0x007845C8 File Offset: 0x007827C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378E2 RID: 227554 RVA: 0x007845DA File Offset: 0x007827DA
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x060378E3 RID: 227555 RVA: 0x007845E2 File Offset: 0x007827E2
		public static TSetPlayerOperationRestrictionUnion FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x060378E4 RID: 227556 RVA: 0x007845F7 File Offset: 0x007827F7
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x060378E5 RID: 227557 RVA: 0x007845FF File Offset: 0x007827FF
		public static TSetPlayerOperationRestrictionUnion FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x060378E6 RID: 227558 RVA: 0x00784614 File Offset: 0x00782814
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x060378E7 RID: 227559 RVA: 0x0078461C File Offset: 0x0078281C
		public static TSetPlayerOperationRestrictionUnion FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x060378E8 RID: 227560 RVA: 0x00784634 File Offset: 0x00782834
		public static int Pack(FlatBufferBuilder builder, TSetPlayerOperationRestrictionUnion _o)
		{
			switch (_o.Type)
			{
			case TSetPlayerOperationRestriction.IDisableAllPlayerOperation:
				return IDisableAllPlayerOperation.Pack(builder, _o.AsIDisableAllPlayerOperation()).Value;
			case TSetPlayerOperationRestriction.IDisableModulePlayerOperation:
				return IDisableModulePlayerOperation.Pack(builder, _o.AsIDisableModulePlayerOperation()).Value;
			case TSetPlayerOperationRestriction.IEnableAllPlayerOperation:
				return IEnableAllPlayerOperation.Pack(builder, _o.AsIEnableAllPlayerOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
