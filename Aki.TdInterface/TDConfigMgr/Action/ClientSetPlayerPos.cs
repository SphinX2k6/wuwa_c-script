using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001660 RID: 5728
	public class ClientSetPlayerPos : ActionParams
	{
		// Token: 0x06008125 RID: 33061 RVA: 0x00132F14 File Offset: 0x00131114
		private ClientSetPlayerPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientSetPlayerPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientSetPlayerPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientSetPlayerPos_SetValue());
			}
			return result;
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00132F4C File Offset: 0x0013114C
		public static ClientSetPlayerPos Create([Nullable(2)] ClientSetPlayerPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetPlayerPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00132F5F File Offset: 0x0013115F
		public static ClientSetPlayerPos CreateFromSetValue([Nullable(2)] ClientSetPlayerPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientSetPlayerPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00132F72 File Offset: 0x00131172
		public ClientSetPlayerPos_SetValue ToSetValue()
		{
			return new ClientSetPlayerPos_SetValue
			{
				TelePortConfig = this.TelePortConfig
			};
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x06008129 RID: 33065 RVA: 0x00132F85 File Offset: 0x00131185
		// (set) Token: 0x0600812A RID: 33066 RVA: 0x00132FAC File Offset: 0x001311AC
		public virtual IClientTeleportConfig TelePortConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TelePortConfig;
				}
				ClientSetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TelePortConfig;
			}
			set
			{
				this.GetOrCreatePoco().TelePortConfig = value;
			}
		}

		// Token: 0x04004A7C RID: 19068
		[Nullable(2)]
		protected new ClientSetPlayerPos FbInstance;

		// Token: 0x04004A7D RID: 19069
		[Nullable(2)]
		protected ClientSetPlayerPos_SetValue PocoInterface;
	}
}
