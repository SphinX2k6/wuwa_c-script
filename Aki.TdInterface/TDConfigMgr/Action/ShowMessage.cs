using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246F RID: 9327
	public class ShowMessage : ActionParams
	{
		// Token: 0x0600CAF7 RID: 51959 RVA: 0x001CF2D0 File Offset: 0x001CD4D0
		private ShowMessage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowMessage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowMessage_SetValue());
			}
			return result;
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x001CF308 File Offset: 0x001CD508
		public static ShowMessage Create([Nullable(2)] ShowMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x001CF31B File Offset: 0x001CD51B
		public static ShowMessage CreateFromSetValue([Nullable(2)] ShowMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x001CF32E File Offset: 0x001CD52E
		public ShowMessage_SetValue ToSetValue()
		{
			return new ShowMessage_SetValue
			{
				Content = this.Content
			};
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x001CF341 File Offset: 0x001CD541
		// (set) Token: 0x0600CAFC RID: 51964 RVA: 0x001CF36C File Offset: 0x001CD56C
		public virtual string Content
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Content;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Content;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
			}
		}

		// Token: 0x04007847 RID: 30791
		[Nullable(2)]
		protected new ShowMessage FbInstance;

		// Token: 0x04007848 RID: 30792
		[Nullable(2)]
		protected ShowMessage_SetValue PocoInterface;
	}
}
