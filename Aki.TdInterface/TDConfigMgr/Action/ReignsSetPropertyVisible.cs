using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A1 RID: 9121
	public class ReignsSetPropertyVisible : ActionParams
	{
		// Token: 0x0600C6F6 RID: 50934 RVA: 0x001C7D80 File Offset: 0x001C5F80
		private ReignsSetPropertyVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsSetPropertyVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsSetPropertyVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsSetPropertyVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x001C7DB8 File Offset: 0x001C5FB8
		public static ReignsSetPropertyVisible Create([Nullable(2)] ReignsSetPropertyVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x001C7DCB File Offset: 0x001C5FCB
		public static ReignsSetPropertyVisible CreateFromSetValue([Nullable(2)] ReignsSetPropertyVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x001C7DDE File Offset: 0x001C5FDE
		public ReignsSetPropertyVisible_SetValue ToSetValue()
		{
			return new ReignsSetPropertyVisible_SetValue
			{
				PropertyId = this.PropertyId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600C6FA RID: 50938 RVA: 0x001C7DFD File Offset: 0x001C5FFD
		// (set) Token: 0x0600C6FB RID: 50939 RVA: 0x001C7E28 File Offset: 0x001C6028
		public virtual int PropertyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PropertyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PropertyId;
			}
			set
			{
				this.GetOrCreatePoco().PropertyId = value;
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600C6FC RID: 50940 RVA: 0x001C7E36 File Offset: 0x001C6036
		// (set) Token: 0x0600C6FD RID: 50941 RVA: 0x001C7E61 File Offset: 0x001C6061
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x04007648 RID: 30280
		[Nullable(2)]
		protected new ReignsSetPropertyVisible FbInstance;

		// Token: 0x04007649 RID: 30281
		[Nullable(2)]
		protected ReignsSetPropertyVisible_SetValue PocoInterface;
	}
}
