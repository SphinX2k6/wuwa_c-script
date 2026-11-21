using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001654 RID: 5716
	public class ClientChangeTeamPosition : ActionParams
	{
		// Token: 0x060080E9 RID: 33001 RVA: 0x00132898 File Offset: 0x00130A98
		private ClientChangeTeamPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientChangeTeamPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientChangeTeamPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientChangeTeamPosition_SetValue());
			}
			return result;
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x001328D0 File Offset: 0x00130AD0
		public static ClientChangeTeamPosition Create([Nullable(2)] ClientChangeTeamPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x001328E3 File Offset: 0x00130AE3
		public static ClientChangeTeamPosition CreateFromSetValue([Nullable(2)] ClientChangeTeamPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x001328F6 File Offset: 0x00130AF6
		public ClientChangeTeamPosition_SetValue ToSetValue()
		{
			return new ClientChangeTeamPosition_SetValue
			{
				PositionId = this.PositionId
			};
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x060080ED RID: 33005 RVA: 0x00132909 File Offset: 0x00130B09
		// (set) Token: 0x060080EE RID: 33006 RVA: 0x00132934 File Offset: 0x00130B34
		public virtual int PositionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionId;
			}
			set
			{
				this.GetOrCreatePoco().PositionId = value;
			}
		}

		// Token: 0x04004A60 RID: 19040
		[Nullable(2)]
		protected new ClientChangeTeamPosition FbInstance;

		// Token: 0x04004A61 RID: 19041
		[Nullable(2)]
		protected ClientChangeTeamPosition_SetValue PocoInterface;
	}
}
