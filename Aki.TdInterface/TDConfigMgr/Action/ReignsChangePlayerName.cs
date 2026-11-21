using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239E RID: 9118
	public class ReignsChangePlayerName : ActionParams
	{
		// Token: 0x0600C6EC RID: 50924 RVA: 0x001C7CA8 File Offset: 0x001C5EA8
		private ReignsChangePlayerName_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsChangePlayerName 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsChangePlayerName_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsChangePlayerName_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x001C7CE0 File Offset: 0x001C5EE0
		public static ReignsChangePlayerName Create([Nullable(2)] ReignsChangePlayerName instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x001C7CF3 File Offset: 0x001C5EF3
		public static ReignsChangePlayerName CreateFromSetValue([Nullable(2)] ReignsChangePlayerName_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x001C7D06 File Offset: 0x001C5F06
		public ReignsChangePlayerName_SetValue ToSetValue()
		{
			return new ReignsChangePlayerName_SetValue
			{
				PlayerNameId = this.PlayerNameId
			};
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x001C7D19 File Offset: 0x001C5F19
		// (set) Token: 0x0600C6F1 RID: 50929 RVA: 0x001C7D44 File Offset: 0x001C5F44
		public virtual string PlayerNameId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerNameId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PlayerNameId;
			}
			set
			{
				this.GetOrCreatePoco().PlayerNameId = value;
			}
		}

		// Token: 0x04007644 RID: 30276
		[Nullable(2)]
		protected new ReignsChangePlayerName FbInstance;

		// Token: 0x04007645 RID: 30277
		[Nullable(2)]
		protected ReignsChangePlayerName_SetValue PocoInterface;
	}
}
