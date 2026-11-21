using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000707 RID: 1799
	public class IRefreshContent
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x00066F98 File Offset: 0x00065198
		private IRefreshContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshContent_SetValue());
			}
			return result;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00066FD0 File Offset: 0x000651D0
		public static IRefreshContent Create([Nullable(2)] IRefreshContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00066FE3 File Offset: 0x000651E3
		public static IRefreshContent CreateFromSetValue([Nullable(2)] IRefreshContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00066FF6 File Offset: 0x000651F6
		public IRefreshContent_SetValue ToSetValue()
		{
			return new IRefreshContent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00067009 File Offset: 0x00065209
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00067034 File Offset: 0x00065234
		public virtual ERefreshContent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshContent.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A44 RID: 6724
		[Nullable(2)]
		protected IRefreshContent FbInstance;

		// Token: 0x04001A45 RID: 6725
		[Nullable(2)]
		protected IRefreshContent_SetValue PocoInterface;
	}
}
