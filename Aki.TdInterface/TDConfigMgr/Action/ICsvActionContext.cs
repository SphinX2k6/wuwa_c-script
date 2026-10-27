using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001942 RID: 6466
	[NullableContext(1)]
	[Nullable(0)]
	public class ICsvActionContext : IActionContextType
	{
		// Token: 0x06008A97 RID: 35479 RVA: 0x001465D0 File Offset: 0x001447D0
		private ICsvActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICsvActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICsvActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICsvActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x00146608 File Offset: 0x00144808
		public static ICsvActionContext Create([Nullable(2)] ICsvActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICsvActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0014661B File Offset: 0x0014481B
		public static ICsvActionContext CreateFromSetValue([Nullable(2)] ICsvActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICsvActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x0014662E File Offset: 0x0014482E
		public new ICsvActionContext_SetValue ToSetValue()
		{
			return new ICsvActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x06008A9B RID: 35483 RVA: 0x00146641 File Offset: 0x00144841
		// (set) Token: 0x06008A9C RID: 35484 RVA: 0x0014666C File Offset: 0x0014486C
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

		// Token: 0x0400569A RID: 22170
		[Nullable(2)]
		protected new ICsvActionContext FbInstance;

		// Token: 0x0400569B RID: 22171
		[Nullable(2)]
		protected new ICsvActionContext_SetValue PocoInterface;
	}
}
