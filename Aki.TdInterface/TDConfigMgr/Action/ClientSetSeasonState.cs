using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001507 RID: 5383
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientSetSeasonState : ActionParams
	{
		// Token: 0x06007A5A RID: 31322 RVA: 0x001242EC File Offset: 0x001224EC
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

		// Token: 0x06007A5B RID: 31323 RVA: 0x00124324 File Offset: 0x00122524
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

		// Token: 0x06007A5C RID: 31324 RVA: 0x00124337 File Offset: 0x00122537
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

		// Token: 0x06007A5D RID: 31325 RVA: 0x0012434A File Offset: 0x0012254A
		public ClientSetSeasonState_SetValue ToSetValue()
		{
			return new ClientSetSeasonState_SetValue
			{
				VolumeId = this.VolumeId,
				Config = this.Config
			};
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x06007A5E RID: 31326 RVA: 0x00124369 File Offset: 0x00122569
		// (set) Token: 0x06007A5F RID: 31327 RVA: 0x00124394 File Offset: 0x00122594
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

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x06007A60 RID: 31328 RVA: 0x001243A2 File Offset: 0x001225A2
		// (set) Token: 0x06007A61 RID: 31329 RVA: 0x001243C9 File Offset: 0x001225C9
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

		// Token: 0x040046E0 RID: 18144
		[Nullable(2)]
		protected new ClientSetSeasonState FbInstance;

		// Token: 0x040046E1 RID: 18145
		[Nullable(2)]
		protected ClientSetSeasonState_SetValue PocoInterface;
	}
}
