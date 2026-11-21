using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E4 RID: 484
	public class IAngleWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x0002585C File Offset: 0x00023A5C
		private IAngleWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAngleWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAngleWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAngleWeight_SetValue());
			}
			return result;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00025894 File Offset: 0x00023A94
		public static IAngleWeight Create([Nullable(2)] IAngleWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAngleWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000258A7 File Offset: 0x00023AA7
		public static IAngleWeight CreateFromSetValue([Nullable(2)] IAngleWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAngleWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000258BA File Offset: 0x00023ABA
		public new IAngleWeight_SetValue ToSetValue()
		{
			return new IAngleWeight_SetValue
			{
				Type = this.Type,
				AngleWeight = this.AngleWeight
			};
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000258D9 File Offset: 0x00023AD9
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00025904 File Offset: 0x00023B04
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00025914 File Offset: 0x00023B14
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x000259A7 File Offset: 0x00023BA7
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
					IAngleWeight_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040008EA RID: 2282
		[Nullable(2)]
		protected new IAngleWeight FbInstance;

		// Token: 0x040008EB RID: 2283
		[Nullable(2)]
		protected new IAngleWeight_SetValue PocoInterface;

		// Token: 0x040008EC RID: 2284
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x040008ED RID: 2285
		private bool _AngleWeightInited;
	}
}
