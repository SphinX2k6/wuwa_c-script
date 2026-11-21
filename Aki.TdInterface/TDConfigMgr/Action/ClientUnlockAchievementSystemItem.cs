using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001666 RID: 5734
	public class ClientUnlockAchievementSystemItem : ActionParams
	{
		// Token: 0x06008143 RID: 33091 RVA: 0x00133288 File Offset: 0x00131488
		private ClientUnlockAchievementSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientUnlockAchievementSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientUnlockAchievementSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientUnlockAchievementSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x001332C0 File Offset: 0x001314C0
		public static ClientUnlockAchievementSystemItem Create([Nullable(2)] ClientUnlockAchievementSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientUnlockAchievementSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x001332D3 File Offset: 0x001314D3
		public static ClientUnlockAchievementSystemItem CreateFromSetValue([Nullable(2)] ClientUnlockAchievementSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientUnlockAchievementSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x001332E6 File Offset: 0x001314E6
		public ClientUnlockAchievementSystemItem_SetValue ToSetValue()
		{
			return new ClientUnlockAchievementSystemItem_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x06008147 RID: 33095 RVA: 0x001332F9 File Offset: 0x001314F9
		// (set) Token: 0x06008148 RID: 33096 RVA: 0x00133324 File Offset: 0x00131524
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04004A8C RID: 19084
		[Nullable(2)]
		protected new ClientUnlockAchievementSystemItem FbInstance;

		// Token: 0x04004A8D RID: 19085
		[Nullable(2)]
		protected ClientUnlockAchievementSystemItem_SetValue PocoInterface;
	}
}
