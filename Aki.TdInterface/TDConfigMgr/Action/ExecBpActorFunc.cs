using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001888 RID: 6280
	public class ExecBpActorFunc : ActionParams
	{
		// Token: 0x060083E5 RID: 33765 RVA: 0x0013B474 File Offset: 0x00139674
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

		// Token: 0x060083E6 RID: 33766 RVA: 0x0013B4AC File Offset: 0x001396AC
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

		// Token: 0x060083E7 RID: 33767 RVA: 0x0013B4BF File Offset: 0x001396BF
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

		// Token: 0x060083E8 RID: 33768 RVA: 0x0013B4D2 File Offset: 0x001396D2
		public ExecBpActorFunc_SetValue ToSetValue()
		{
			return new ExecBpActorFunc_SetValue
			{
				ExecFuncType = this.ExecFuncType
			};
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x060083E9 RID: 33769 RVA: 0x0013B4E5 File Offset: 0x001396E5
		// (set) Token: 0x060083EA RID: 33770 RVA: 0x0013B50C File Offset: 0x0013970C
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

		// Token: 0x0400540B RID: 21515
		[Nullable(2)]
		protected new ExecBpActorFunc FbInstance;

		// Token: 0x0400540C RID: 21516
		[Nullable(2)]
		protected ExecBpActorFunc_SetValue PocoInterface;
	}
}
