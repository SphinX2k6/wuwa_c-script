using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7E RID: 7294
	public class IGmActionContext : IActionContextType
	{
		// Token: 0x06009B02 RID: 39682 RVA: 0x001665CC File Offset: 0x001647CC
		private IGmActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGmActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGmActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGmActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x00166604 File Offset: 0x00164804
		public static IGmActionContext Create([Nullable(2)] IGmActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGmActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x00166617 File Offset: 0x00164817
		public static IGmActionContext CreateFromSetValue([Nullable(2)] IGmActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGmActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x0016662A File Offset: 0x0016482A
		public new IGmActionContext_SetValue ToSetValue()
		{
			return new IGmActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x0016663D File Offset: 0x0016483D
		// (set) Token: 0x06009B07 RID: 39687 RVA: 0x00166668 File Offset: 0x00164868
		public new virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F12 RID: 24338
		[Nullable(2)]
		protected new IGmActionContext FbInstance;

		// Token: 0x04005F13 RID: 24339
		[Nullable(2)]
		protected new IGmActionContext_SetValue PocoInterface;
	}
}
