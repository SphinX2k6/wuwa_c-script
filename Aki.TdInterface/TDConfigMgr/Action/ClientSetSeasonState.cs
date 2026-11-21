using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001662 RID: 5730
	public class ClientSetSeasonState : ActionParams
	{
		// Token: 0x0600812D RID: 33069 RVA: 0x00132FCC File Offset: 0x001311CC
		private ClientSetSeasonState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientSetSeasonState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientSetSeasonState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientSetSeasonState_SetValue());
			}
			return result;
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00133004 File Offset: 0x00131204
		public static ClientSetSeasonState Create([Nullable(2)] ClientSetSeasonState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetSeasonState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00133017 File Offset: 0x00131217
		public static ClientSetSeasonState CreateFromSetValue([Nullable(2)] ClientSetSeasonState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientSetSeasonState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x0013302A File Offset: 0x0013122A
		public ClientSetSeasonState_SetValue ToSetValue()
		{
			return new ClientSetSeasonState_SetValue
			{
				VolumeId = this.VolumeId,
				Config = this.Config
			};
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x00133049 File Offset: 0x00131249
		// (set) Token: 0x06008132 RID: 33074 RVA: 0x00133074 File Offset: 0x00131274
		public virtual int VolumeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VolumeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VolumeId;
			}
			set
			{
				this.GetOrCreatePoco().VolumeId = value;
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x06008133 RID: 33075 RVA: 0x00133082 File Offset: 0x00131282
		// (set) Token: 0x06008134 RID: 33076 RVA: 0x001330A9 File Offset: 0x001312A9
		public virtual IClientSetSeasonStateConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ClientSetSeasonState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04004A7F RID: 19071
		[Nullable(2)]
		protected new ClientSetSeasonState FbInstance;

		// Token: 0x04004A80 RID: 19072
		[Nullable(2)]
		protected ClientSetSeasonState_SetValue PocoInterface;
	}
}
