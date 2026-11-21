using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FBF RID: 32703
	public class TSetPlayerOperationRestrictionUnion
	{
		// Token: 0x1700F2F7 RID: 62199
		// (get) Token: 0x0603AE57 RID: 241239 RVA: 0x007E9A92 File Offset: 0x007E7C92
		// (set) Token: 0x0603AE58 RID: 241240 RVA: 0x007E9A9A File Offset: 0x007E7C9A
		public TSetPlayerOperationRestriction Type { get; set; }

		// Token: 0x1700F2F8 RID: 62200
		// (get) Token: 0x0603AE59 RID: 241241 RVA: 0x007E9AA3 File Offset: 0x007E7CA3
		// (set) Token: 0x0603AE5A RID: 241242 RVA: 0x007E9AAB File Offset: 0x007E7CAB
		public object Value { get; set; }

		// Token: 0x0603AE5B RID: 241243 RVA: 0x007E9AB4 File Offset: 0x007E7CB4
		public TSetPlayerOperationRestrictionUnion()
		{
			this.Type = TSetPlayerOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE5C RID: 241244 RVA: 0x007E9ACA File Offset: 0x007E7CCA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE5D RID: 241245 RVA: 0x007E9ADC File Offset: 0x007E7CDC
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x0603AE5E RID: 241246 RVA: 0x007E9AE4 File Offset: 0x007E7CE4
		public static TSetPlayerOperationRestrictionUnion FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x0603AE5F RID: 241247 RVA: 0x007E9AF9 File Offset: 0x007E7CF9
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x0603AE60 RID: 241248 RVA: 0x007E9B01 File Offset: 0x007E7D01
		public static TSetPlayerOperationRestrictionUnion FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x0603AE61 RID: 241249 RVA: 0x007E9B16 File Offset: 0x007E7D16
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x0603AE62 RID: 241250 RVA: 0x007E9B1E File Offset: 0x007E7D1E
		public static TSetPlayerOperationRestrictionUnion FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new TSetPlayerOperationRestrictionUnion
			{
				Type = TSetPlayerOperationRestriction.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x0603AE63 RID: 241251 RVA: 0x007E9B34 File Offset: 0x007E7D34
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
