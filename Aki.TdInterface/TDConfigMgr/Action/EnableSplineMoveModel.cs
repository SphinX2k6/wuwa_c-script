using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017B3 RID: 6067
	public class EnableSplineMoveModel : ActionParams
	{
		// Token: 0x0600835B RID: 33627 RVA: 0x0013A598 File Offset: 0x00138798
		private EnableSplineMoveModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableSplineMoveModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableSplineMoveModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableSplineMoveModel_SetValue());
			}
			return result;
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0013A5D0 File Offset: 0x001387D0
		public static EnableSplineMoveModel Create([Nullable(2)] EnableSplineMoveModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSplineMoveModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0013A5E3 File Offset: 0x001387E3
		public static EnableSplineMoveModel CreateFromSetValue([Nullable(2)] EnableSplineMoveModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableSplineMoveModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0013A5F6 File Offset: 0x001387F6
		public EnableSplineMoveModel_SetValue ToSetValue()
		{
			return new EnableSplineMoveModel_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x0013A609 File Offset: 0x00138809
		// (set) Token: 0x06008360 RID: 33632 RVA: 0x0013A630 File Offset: 0x00138830
		public virtual ISplineMoveConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				EnableSplineMoveModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04005068 RID: 20584
		[Nullable(2)]
		protected new EnableSplineMoveModel FbInstance;

		// Token: 0x04005069 RID: 20585
		[Nullable(2)]
		protected EnableSplineMoveModel_SetValue PocoInterface;
	}
}
