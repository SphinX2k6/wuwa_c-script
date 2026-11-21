using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B1 RID: 9137
	public class RemoveNpcGroupPerform : ActionParams
	{
		// Token: 0x0600C740 RID: 51008 RVA: 0x001C8534 File Offset: 0x001C6734
		private RemoveNpcGroupPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveNpcGroupPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveNpcGroupPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveNpcGroupPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x001C856C File Offset: 0x001C676C
		public static RemoveNpcGroupPerform Create([Nullable(2)] RemoveNpcGroupPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x001C857F File Offset: 0x001C677F
		public static RemoveNpcGroupPerform CreateFromSetValue([Nullable(2)] RemoveNpcGroupPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x001C8592 File Offset: 0x001C6792
		public RemoveNpcGroupPerform_SetValue ToSetValue()
		{
			return new RemoveNpcGroupPerform_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600C744 RID: 51012 RVA: 0x001C85A5 File Offset: 0x001C67A5
		// (set) Token: 0x0600C745 RID: 51013 RVA: 0x001C85D0 File Offset: 0x001C67D0
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x04007669 RID: 30313
		[Nullable(2)]
		protected new RemoveNpcGroupPerform FbInstance;

		// Token: 0x0400766A RID: 30314
		[Nullable(2)]
		protected RemoveNpcGroupPerform_SetValue PocoInterface;
	}
}
