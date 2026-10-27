using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BC RID: 1724
	[NullableContext(1)]
	[Nullable(0)]
	public class ISearchTargetCfg
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x00063FF8 File Offset: 0x000621F8
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

		// Token: 0x0600250D RID: 9485 RVA: 0x00064030 File Offset: 0x00062230
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

		// Token: 0x0600250E RID: 9486 RVA: 0x00064043 File Offset: 0x00062243
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

		// Token: 0x0600250F RID: 9487 RVA: 0x00064056 File Offset: 0x00062256
		public ISearchTargetCfg_SetValue ToSetValue()
		{
			return new ISearchTargetCfg_SetValue
			{
				AngleWeight = this.AngleWeight,
				LockConditions = this.LockConditions,
				IgnoreDistanceWeight = this.IgnoreDistanceWeight
			};
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x00064084 File Offset: 0x00062284
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x00064117 File Offset: 0x00062317
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

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x0006412C File Offset: 0x0006232C
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x000641BF File Offset: 0x000623BF
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

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000641D4 File Offset: 0x000623D4
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x0006420E File Offset: 0x0006240E
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

		// Token: 0x04001959 RID: 6489
		[Nullable(2)]
		protected ISearchTargetCfg FbInstance;

		// Token: 0x0400195A RID: 6490
		[Nullable(2)]
		protected ISearchTargetCfg_SetValue PocoInterface;

		// Token: 0x0400195B RID: 6491
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x0400195C RID: 6492
		private bool _AngleWeightInited;

		// Token: 0x0400195D RID: 6493
		private List<IEntityCategoryWeight> _LockConditionsCache;

		// Token: 0x0400195E RID: 6494
		private bool _LockConditionsInited;
	}
}
