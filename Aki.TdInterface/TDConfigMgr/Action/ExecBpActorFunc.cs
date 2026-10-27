using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200170B RID: 5899
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecBpActorFunc : ActionParams
	{
		// Token: 0x06007D07 RID: 32007 RVA: 0x0012C3C8 File Offset: 0x0012A5C8
		private ExecBpActorFunc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecBpActorFunc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecBpActorFunc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecBpActorFunc_SetValue());
			}
			return result;
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0012C400 File Offset: 0x0012A600
		public static ExecBpActorFunc Create([Nullable(2)] ExecBpActorFunc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecBpActorFunc
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x0012C413 File Offset: 0x0012A613
		public static ExecBpActorFunc CreateFromSetValue([Nullable(2)] ExecBpActorFunc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecBpActorFunc
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x0012C426 File Offset: 0x0012A626
		public ExecBpActorFunc_SetValue ToSetValue()
		{
			return new ExecBpActorFunc_SetValue
			{
				ExecFuncType = this.ExecFuncType
			};
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x0012C439 File Offset: 0x0012A639
		// (set) Token: 0x06007D0C RID: 32012 RVA: 0x0012C460 File Offset: 0x0012A660
		public virtual IBpActorFuncTypeBase ExecFuncType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExecFuncType;
				}
				ExecBpActorFunc_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExecFuncType;
			}
			set
			{
				this.GetOrCreatePoco().ExecFuncType = value;
			}
		}

		// Token: 0x04004FDC RID: 20444
		[Nullable(2)]
		protected new ExecBpActorFunc FbInstance;

		// Token: 0x04004FDD RID: 20445
		[Nullable(2)]
		protected ExecBpActorFunc_SetValue PocoInterface;
	}
}
