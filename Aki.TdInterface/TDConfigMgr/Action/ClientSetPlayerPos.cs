using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001505 RID: 5381
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientSetPlayerPos : ActionParams
	{
		// Token: 0x06007A52 RID: 31314 RVA: 0x00124234 File Offset: 0x00122434
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

		// Token: 0x06007A53 RID: 31315 RVA: 0x0012426C File Offset: 0x0012246C
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

		// Token: 0x06007A54 RID: 31316 RVA: 0x0012427F File Offset: 0x0012247F
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

		// Token: 0x06007A55 RID: 31317 RVA: 0x00124292 File Offset: 0x00122492
		public ClientSetPlayerPos_SetValue ToSetValue()
		{
			return new ClientSetPlayerPos_SetValue
			{
				TelePortConfig = this.TelePortConfig
			};
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x001242A5 File Offset: 0x001224A5
		// (set) Token: 0x06007A57 RID: 31319 RVA: 0x001242CC File Offset: 0x001224CC
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

		// Token: 0x040046DD RID: 18141
		[Nullable(2)]
		protected new ClientSetPlayerPos FbInstance;

		// Token: 0x040046DE RID: 18142
		[Nullable(2)]
		protected ClientSetPlayerPos_SetValue PocoInterface;
	}
}
