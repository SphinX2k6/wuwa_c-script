using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000062 RID: 98
	public class DynamicSpawnMonsterComponent : IComponentBase
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0001BDA4 File Offset: 0x00019FA4
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

		// Token: 0x06000333 RID: 819 RVA: 0x0001BDDC File Offset: 0x00019FDC
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

		// Token: 0x06000334 RID: 820 RVA: 0x0001BDEF File Offset: 0x00019FEF
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

		// Token: 0x06000335 RID: 821 RVA: 0x0001BE02 File Offset: 0x0001A002
		public new DynamicSpawnMonsterComponent_SetValue ToSetValue()
		{
			return new DynamicSpawnMonsterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Group = this.Group
			};
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001BE30 File Offset: 0x0001A030
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001BE6A File Offset: 0x0001A06A
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001BE78 File Offset: 0x0001A078
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0001BEA2 File Offset: 0x0001A0A2
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0001BF43 File Offset: 0x0001A143
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

		// Token: 0x04000208 RID: 520
		[Nullable(2)]
		protected new DynamicSpawnMonsterComponent FbInstance;

		// Token: 0x04000209 RID: 521
		[Nullable(2)]
		protected new DynamicSpawnMonsterComponent_SetValue PocoInterface;

		// Token: 0x0400020A RID: 522
		private List<IConditionSpawnMonster> _GroupCache;

		// Token: 0x0400020B RID: 523
		private bool _GroupInited;
	}
}
