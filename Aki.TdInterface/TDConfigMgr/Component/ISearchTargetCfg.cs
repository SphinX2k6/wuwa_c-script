using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075D RID: 1885
	public class ISearchTargetCfg
	{
		// Token: 0x0600282C RID: 10284 RVA: 0x0006B068 File Offset: 0x00069268
		private ISearchTargetCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISearchTargetCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISearchTargetCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISearchTargetCfg_SetValue());
			}
			return result;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0006B0A0 File Offset: 0x000692A0
		public static ISearchTargetCfg Create([Nullable(2)] ISearchTargetCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISearchTargetCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0006B0B3 File Offset: 0x000692B3
		public static ISearchTargetCfg CreateFromSetValue([Nullable(2)] ISearchTargetCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISearchTargetCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0006B0C6 File Offset: 0x000692C6
		public ISearchTargetCfg_SetValue ToSetValue()
		{
			return new ISearchTargetCfg_SetValue
			{
				AngleWeight = this.AngleWeight,
				LockConditions = this.LockConditions,
				IgnoreDistanceWeight = this.IgnoreDistanceWeight
			};
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x0006B0F4 File Offset: 0x000692F4
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x0006B187 File Offset: 0x00069387
		public virtual List<IEntityAngleWeight> AngleWeight
		{
			get
			{
				if (this._AngleWeightInited)
				{
					return this._AngleWeightCache;
				}
				this._AngleWeightInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityAngleWeight> angleWeight = this.FbInstance.AngleWeight;
					if (angleWeight != null)
					{
						this._AngleWeightCache = new List<IEntityAngleWeight>(angleWeight.Count);
						for (int i = 0; i < angleWeight.Count; i++)
						{
							this._AngleWeightCache.Add(IEntityAngleWeight.Create(angleWeight[i]));
						}
					}
				}
				else
				{
					ISearchTargetCfg_SetValue pocoInterface = this.PocoInterface;
					this._AngleWeightCache = ((pocoInterface != null) ? pocoInterface.AngleWeight : null);
				}
				return this._AngleWeightCache;
			}
			set
			{
				this.GetOrCreatePoco().AngleWeight = value;
				this._AngleWeightInited = false;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x0006B19C File Offset: 0x0006939C
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x0006B22F File Offset: 0x0006942F
		public virtual List<IEntityCategoryWeight> LockConditions
		{
			get
			{
				if (this._LockConditionsInited)
				{
					return this._LockConditionsCache;
				}
				this._LockConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityCategoryWeight> lockConditions = this.FbInstance.LockConditions;
					if (lockConditions != null)
					{
						this._LockConditionsCache = new List<IEntityCategoryWeight>(lockConditions.Count);
						for (int i = 0; i < lockConditions.Count; i++)
						{
							this._LockConditionsCache.Add(IEntityCategoryWeight.Create(lockConditions[i]));
						}
					}
				}
				else
				{
					ISearchTargetCfg_SetValue pocoInterface = this.PocoInterface;
					this._LockConditionsCache = ((pocoInterface != null) ? pocoInterface.LockConditions : null);
				}
				return this._LockConditionsCache;
			}
			set
			{
				this.GetOrCreatePoco().LockConditions = value;
				this._LockConditionsInited = false;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x0006B244 File Offset: 0x00069444
		// (set) Token: 0x06002835 RID: 10293 RVA: 0x0006B27E File Offset: 0x0006947E
		public virtual bool? IgnoreDistanceWeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IgnoreDistanceWeight;
				}
				ISearchTargetCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IgnoreDistanceWeight;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreDistanceWeight = value;
			}
		}

		// Token: 0x04001B58 RID: 7000
		[Nullable(2)]
		protected ISearchTargetCfg FbInstance;

		// Token: 0x04001B59 RID: 7001
		[Nullable(2)]
		protected ISearchTargetCfg_SetValue PocoInterface;

		// Token: 0x04001B5A RID: 7002
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x04001B5B RID: 7003
		private bool _AngleWeightInited;

		// Token: 0x04001B5C RID: 7004
		private List<IEntityCategoryWeight> _LockConditionsCache;

		// Token: 0x04001B5D RID: 7005
		private bool _LockConditionsInited;
	}
}
