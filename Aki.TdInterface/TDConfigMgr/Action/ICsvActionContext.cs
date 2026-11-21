using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACB RID: 6859
	public class ICsvActionContext : IActionContextType
	{
		// Token: 0x060091C3 RID: 37315 RVA: 0x00155F10 File Offset: 0x00154110
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

		// Token: 0x060091C4 RID: 37316 RVA: 0x00155F48 File Offset: 0x00154148
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

		// Token: 0x060091C5 RID: 37317 RVA: 0x00155F5B File Offset: 0x0015415B
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

		// Token: 0x060091C6 RID: 37318 RVA: 0x00155F6E File Offset: 0x0015416E
		public new ICsvActionContext_SetValue ToSetValue()
		{
			return new ICsvActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x060091C7 RID: 37319 RVA: 0x00155F81 File Offset: 0x00154181
		// (set) Token: 0x060091C8 RID: 37320 RVA: 0x00155FAC File Offset: 0x001541AC
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

		// Token: 0x04005AEA RID: 23274
		[Nullable(2)]
		protected new ICsvActionContext FbInstance;

		// Token: 0x04005AEB RID: 23275
		[Nullable(2)]
		protected new ICsvActionContext_SetValue PocoInterface;
	}
}
