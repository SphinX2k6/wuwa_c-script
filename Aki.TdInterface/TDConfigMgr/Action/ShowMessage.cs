using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002204 RID: 8708
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowMessage : ActionParams
	{
		// Token: 0x0600BF3B RID: 48955 RVA: 0x001B7C44 File Offset: 0x001B5E44
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

		// Token: 0x0600BF3C RID: 48956 RVA: 0x001B7C7C File Offset: 0x001B5E7C
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

		// Token: 0x0600BF3D RID: 48957 RVA: 0x001B7C8F File Offset: 0x001B5E8F
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

		// Token: 0x0600BF3E RID: 48958 RVA: 0x001B7CA2 File Offset: 0x001B5EA2
		public ShowMessage_SetValue ToSetValue()
		{
			return new ShowMessage_SetValue
			{
				Content = this.Content
			};
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600BF3F RID: 48959 RVA: 0x001B7CB5 File Offset: 0x001B5EB5
		// (set) Token: 0x0600BF40 RID: 48960 RVA: 0x001B7CE0 File Offset: 0x001B5EE0
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

		// Token: 0x040071FE RID: 29182
		[Nullable(2)]
		protected new ShowMessage FbInstance;

		// Token: 0x040071FF RID: 29183
		[Nullable(2)]
		protected ShowMessage_SetValue PocoInterface;
	}
}
