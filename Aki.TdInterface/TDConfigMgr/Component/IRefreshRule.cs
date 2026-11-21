using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070F RID: 1807
	public class IRefreshRule
	{
		// Token: 0x0600264C RID: 9804 RVA: 0x00067438 File Offset: 0x00065638
		private IRefreshRule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshRule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshRule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshRule_SetValue());
			}
			return result;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00067470 File Offset: 0x00065670
		public static IRefreshRule Create([Nullable(2)] IRefreshRule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshRule
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00067483 File Offset: 0x00065683
		public static IRefreshRule CreateFromSetValue([Nullable(2)] IRefreshRule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshRule
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00067496 File Offset: 0x00065696
		public IRefreshRule_SetValue ToSetValue()
		{
			return new IRefreshRule_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000674A9 File Offset: 0x000656A9
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x000674D4 File Offset: 0x000656D4
		public virtual ERefreshRule Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshRule.CD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A57 RID: 6743
		[Nullable(2)]
		protected IRefreshRule FbInstance;

		// Token: 0x04001A58 RID: 6744
		[Nullable(2)]
		protected IRefreshRule_SetValue PocoInterface;
	}
}
