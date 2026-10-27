using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000062 RID: 98
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicSpawnMonsterComponent : IComponentBase
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0001B430 File Offset: 0x00019630
		private DynamicSpawnMonsterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicSpawnMonsterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicSpawnMonsterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicSpawnMonsterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001B468 File Offset: 0x00019668
		public static DynamicSpawnMonsterComponent Create([Nullable(2)] DynamicSpawnMonsterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001B47B File Offset: 0x0001967B
		public static DynamicSpawnMonsterComponent CreateFromSetValue([Nullable(2)] DynamicSpawnMonsterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001B48E File Offset: 0x0001968E
		public new DynamicSpawnMonsterComponent_SetValue ToSetValue()
		{
			return new DynamicSpawnMonsterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Group = this.Group
			};
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001B4BC File Offset: 0x000196BC
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0001B4F6 File Offset: 0x000196F6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicSpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001B504 File Offset: 0x00019704
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001B52E File Offset: 0x0001972E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001B53C File Offset: 0x0001973C
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001B5CF File Offset: 0x000197CF
		public virtual List<IConditionSpawnMonster> Group
		{
			get
			{
				if (this._GroupInited)
				{
					return this._GroupCache;
				}
				this._GroupInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionSpawnMonster> group = this.FbInstance.Group;
					if (group != null)
					{
						this._GroupCache = new List<IConditionSpawnMonster>(group.Count);
						for (int i = 0; i < group.Count; i++)
						{
							this._GroupCache.Add(IConditionSpawnMonster.Create(group[i]));
						}
					}
				}
				else
				{
					DynamicSpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._GroupCache = ((pocoInterface != null) ? pocoInterface.Group : null);
				}
				return this._GroupCache;
			}
			set
			{
				this.GetOrCreatePoco().Group = value;
				this._GroupInited = false;
			}
		}

		// Token: 0x04000203 RID: 515
		[Nullable(2)]
		protected new DynamicSpawnMonsterComponent FbInstance;

		// Token: 0x04000204 RID: 516
		[Nullable(2)]
		protected new DynamicSpawnMonsterComponent_SetValue PocoInterface;

		// Token: 0x04000205 RID: 517
		private List<IConditionSpawnMonster> _GroupCache;

		// Token: 0x04000206 RID: 518
		private bool _GroupInited;
	}
}
