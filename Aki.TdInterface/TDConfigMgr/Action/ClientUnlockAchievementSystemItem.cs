using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200150B RID: 5387
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientUnlockAchievementSystemItem : ActionParams
	{
		// Token: 0x06007A70 RID: 31344 RVA: 0x001245A8 File Offset: 0x001227A8
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

		// Token: 0x06007A71 RID: 31345 RVA: 0x001245E0 File Offset: 0x001227E0
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

		// Token: 0x06007A72 RID: 31346 RVA: 0x001245F3 File Offset: 0x001227F3
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

		// Token: 0x06007A73 RID: 31347 RVA: 0x00124606 File Offset: 0x00122806
		public ClientUnlockAchievementSystemItem_SetValue ToSetValue()
		{
			return new ClientUnlockAchievementSystemItem_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x00124619 File Offset: 0x00122819
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x00124644 File Offset: 0x00122844
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

		// Token: 0x040046ED RID: 18157
		[Nullable(2)]
		protected new ClientUnlockAchievementSystemItem FbInstance;

		// Token: 0x040046EE RID: 18158
		[Nullable(2)]
		protected ClientUnlockAchievementSystemItem_SetValue PocoInterface;
	}
}
