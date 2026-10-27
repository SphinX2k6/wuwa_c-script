using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767E RID: 30334
	public class TClientSetPlayerOperationRestrictionUnion
	{
		// Token: 0x1700E5E7 RID: 58855
		// (get) Token: 0x06037326 RID: 226086 RVA: 0x0077B4A2 File Offset: 0x007796A2
		// (set) Token: 0x06037327 RID: 226087 RVA: 0x0077B4AA File Offset: 0x007796AA
		public TClientSetPlayerOperationRestriction Type { get; set; }

		// Token: 0x1700E5E8 RID: 58856
		// (get) Token: 0x06037328 RID: 226088 RVA: 0x0077B4B3 File Offset: 0x007796B3
		// (set) Token: 0x06037329 RID: 226089 RVA: 0x0077B4BB File Offset: 0x007796BB
		public object Value { get; set; }

		// Token: 0x0603732A RID: 226090 RVA: 0x0077B4C4 File Offset: 0x007796C4
		public TClientSetPlayerOperationRestrictionUnion()
		{
			this.Type = TClientSetPlayerOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x0603732B RID: 226091 RVA: 0x0077B4DA File Offset: 0x007796DA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603732C RID: 226092 RVA: 0x0077B4EC File Offset: 0x007796EC
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0603732D RID: 226093 RVA: 0x0077B4F4 File Offset: 0x007796F4
		public static TClientSetPlayerOperationRestrictionUnion FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0603732E RID: 226094 RVA: 0x0077B509 File Offset: 0x00779709
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0603732F RID: 226095 RVA: 0x0077B511 File Offset: 0x00779711
		public static TClientSetPlayerOperationRestrictionUnion FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x06037330 RID: 226096 RVA: 0x0077B526 File Offset: 0x00779726
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x06037331 RID: 226097 RVA: 0x0077B52E File Offset: 0x0077972E
		public static TClientSetPlayerOperationRestrictionUnion FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x06037332 RID: 226098 RVA: 0x0077B544 File Offset: 0x00779744
		public static int Pack(FlatBufferBuilder builder, TClientSetPlayerOperationRestrictionUnion _o)
		{
			switch (_o.Type)
			{
			case TClientSetPlayerOperationRestriction.IClientDisableAllPlayerOperation:
				return IClientDisableAllPlayerOperation.Pack(builder, _o.AsIClientDisableAllPlayerOperation()).Value;
			case TClientSetPlayerOperationRestriction.IClientDisableModulePlayerOperation:
				return IClientDisableModulePlayerOperation.Pack(builder, _o.AsIClientDisableModulePlayerOperation()).Value;
			case TClientSetPlayerOperationRestriction.IClientEnableAllPlayerOperation:
				return IClientEnableAllPlayerOperation.Pack(builder, _o.AsIClientEnableAllPlayerOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
