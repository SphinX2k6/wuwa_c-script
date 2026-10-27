using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001648 RID: 5704
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableSystem : ActionParams
	{
		// Token: 0x06007C85 RID: 31877 RVA: 0x0012B5A4 File Offset: 0x001297A4
		private EnableSystem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableSystem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableSystem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableSystem_SetValue());
			}
			return result;
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x0012B5DC File Offset: 0x001297DC
		public static EnableSystem Create([Nullable(2)] EnableSystem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSystem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x0012B5EF File Offset: 0x001297EF
		public static EnableSystem CreateFromSetValue([Nullable(2)] EnableSystem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableSystem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0012B602 File Offset: 0x00129802
		public EnableSystem_SetValue ToSetValue()
		{
			return new EnableSystem_SetValue
			{
				SystemType = this.SystemType,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x0012B621 File Offset: 0x00129821
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x0012B64C File Offset: 0x0012984C
		public virtual ESystem SystemType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemType;
				}
				if (this.PocoInterface == null)
				{
					return (ESystem)0;
				}
				return this.PocoInterface.SystemType;
			}
			set
			{
				this.GetOrCreatePoco().SystemType = value;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x0012B65A File Offset: 0x0012985A
		// (set) Token: 0x06007C8C RID: 31884 RVA: 0x0012B685 File Offset: 0x00129885
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x04004C77 RID: 19575
		[Nullable(2)]
		protected new EnableSystem FbInstance;

		// Token: 0x04004C78 RID: 19576
		[Nullable(2)]
		protected EnableSystem_SetValue PocoInterface;
	}
}
