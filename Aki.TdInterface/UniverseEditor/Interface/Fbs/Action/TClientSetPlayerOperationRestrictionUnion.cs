using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E8C RID: 32396
	public class TClientSetPlayerOperationRestrictionUnion
	{
		// Token: 0x1700F225 RID: 61989
		// (get) Token: 0x0603A7CD RID: 239565 RVA: 0x007DF5EA File Offset: 0x007DD7EA
		// (set) Token: 0x0603A7CE RID: 239566 RVA: 0x007DF5F2 File Offset: 0x007DD7F2
		public TClientSetPlayerOperationRestriction Type { get; set; }

		// Token: 0x1700F226 RID: 61990
		// (get) Token: 0x0603A7CF RID: 239567 RVA: 0x007DF5FB File Offset: 0x007DD7FB
		// (set) Token: 0x0603A7D0 RID: 239568 RVA: 0x007DF603 File Offset: 0x007DD803
		public object Value { get; set; }

		// Token: 0x0603A7D1 RID: 239569 RVA: 0x007DF60C File Offset: 0x007DD80C
		public TClientSetPlayerOperationRestrictionUnion()
		{
			this.Type = TClientSetPlayerOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7D2 RID: 239570 RVA: 0x007DF622 File Offset: 0x007DD822
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7D3 RID: 239571 RVA: 0x007DF634 File Offset: 0x007DD834
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0603A7D4 RID: 239572 RVA: 0x007DF63C File Offset: 0x007DD83C
		public static TClientSetPlayerOperationRestrictionUnion FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0603A7D5 RID: 239573 RVA: 0x007DF651 File Offset: 0x007DD851
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0603A7D6 RID: 239574 RVA: 0x007DF659 File Offset: 0x007DD859
		public static TClientSetPlayerOperationRestrictionUnion FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x0603A7D7 RID: 239575 RVA: 0x007DF66E File Offset: 0x007DD86E
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x0603A7D8 RID: 239576 RVA: 0x007DF676 File Offset: 0x007DD876
		public static TClientSetPlayerOperationRestrictionUnion FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new TClientSetPlayerOperationRestrictionUnion
			{
				Type = TClientSetPlayerOperationRestriction.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x0603A7D9 RID: 239577 RVA: 0x007DF68C File Offset: 0x007DD88C
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
