using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000336 RID: 822
	public class IDynamicTrafficReward : IDynamicEntityRewardType
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x00037680 File Offset: 0x00035880
		private IDynamicTrafficReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicTrafficReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicTrafficReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicTrafficReward_SetValue());
			}
			return result;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000376B8 File Offset: 0x000358B8
		public static IDynamicTrafficReward Create([Nullable(2)] IDynamicTrafficReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000376CB File Offset: 0x000358CB
		public static IDynamicTrafficReward CreateFromSetValue([Nullable(2)] IDynamicTrafficReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000376DE File Offset: 0x000358DE
		public new IDynamicTrafficReward_SetValue ToSetValue()
		{
			return new IDynamicTrafficReward_SetValue
			{
				Type = this.Type,
				RewardId = this.RewardId
			};
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000376FD File Offset: 0x000358FD
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00037728 File Offset: 0x00035928
		public override EDynamicEntityRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00037736 File Offset: 0x00035936
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00037761 File Offset: 0x00035961
		public virtual int RewardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardId;
			}
			set
			{
				this.GetOrCreatePoco().RewardId = value;
			}
		}

		// Token: 0x04000DBA RID: 3514
		[Nullable(2)]
		protected new IDynamicTrafficReward FbInstance;

		// Token: 0x04000DBB RID: 3515
		[Nullable(2)]
		protected new IDynamicTrafficReward_SetValue PocoInterface;
	}
}
