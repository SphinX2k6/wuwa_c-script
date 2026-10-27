using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001646 RID: 5702
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableSplineMoveModel : ActionParams
	{
		// Token: 0x06007C7D RID: 31869 RVA: 0x0012B4EC File Offset: 0x001296EC
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

		// Token: 0x06007C7E RID: 31870 RVA: 0x0012B524 File Offset: 0x00129724
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

		// Token: 0x06007C7F RID: 31871 RVA: 0x0012B537 File Offset: 0x00129737
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

		// Token: 0x06007C80 RID: 31872 RVA: 0x0012B54A File Offset: 0x0012974A
		public EnableSplineMoveModel_SetValue ToSetValue()
		{
			return new EnableSplineMoveModel_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x0012B55D File Offset: 0x0012975D
		// (set) Token: 0x06007C82 RID: 31874 RVA: 0x0012B584 File Offset: 0x00129784
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

		// Token: 0x04004C74 RID: 19572
		[Nullable(2)]
		protected new EnableSplineMoveModel FbInstance;

		// Token: 0x04004C75 RID: 19573
		[Nullable(2)]
		protected EnableSplineMoveModel_SetValue PocoInterface;
	}
}
