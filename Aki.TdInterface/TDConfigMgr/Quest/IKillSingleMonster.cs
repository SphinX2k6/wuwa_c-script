using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010FF RID: 4351
	public class IKillSingleMonster
	{
		// Token: 0x0600602A RID: 24618 RVA: 0x000E84F8 File Offset: 0x000E66F8
		private IKillSingleMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKillSingleMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKillSingleMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKillSingleMonster_SetValue());
			}
			return result;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x000E8530 File Offset: 0x000E6730
		public static IKillSingleMonster Create([Nullable(2)] IKillSingleMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKillSingleMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x000E8543 File Offset: 0x000E6743
		public static IKillSingleMonster CreateFromSetValue([Nullable(2)] IKillSingleMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKillSingleMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x000E8556 File Offset: 0x000E6756
		public IKillSingleMonster_SetValue ToSetValue()
		{
			return new IKillSingleMonster_SetValue
			{
				EntityId = this.EntityId,
				AddTime = this.AddTime
			};
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600602E RID: 24622 RVA: 0x000E8575 File Offset: 0x000E6775
		// (set) Token: 0x0600602F RID: 24623 RVA: 0x000E85A0 File Offset: 0x000E67A0
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x000E85AE File Offset: 0x000E67AE
		// (set) Token: 0x06006031 RID: 24625 RVA: 0x000E85D9 File Offset: 0x000E67D9
		public virtual int AddTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddTime;
			}
			set
			{
				this.GetOrCreatePoco().AddTime = value;
			}
		}

		// Token: 0x040039A5 RID: 14757
		[Nullable(2)]
		protected IKillSingleMonster FbInstance;

		// Token: 0x040039A6 RID: 14758
		[Nullable(2)]
		protected IKillSingleMonster_SetValue PocoInterface;
	}
}
