using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CD RID: 1741
	public class IPullingCategoryMatchingFoundation : IPullingFoundationType
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x00064338 File Offset: 0x00062538
		private IPullingCategoryMatchingFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPullingCategoryMatchingFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPullingCategoryMatchingFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPullingCategoryMatchingFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00064370 File Offset: 0x00062570
		public static IPullingCategoryMatchingFoundation Create([Nullable(2)] IPullingCategoryMatchingFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPullingCategoryMatchingFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00064383 File Offset: 0x00062583
		public static IPullingCategoryMatchingFoundation CreateFromSetValue([Nullable(2)] IPullingCategoryMatchingFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPullingCategoryMatchingFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00064396 File Offset: 0x00062596
		public new IPullingCategoryMatchingFoundation_SetValue ToSetValue()
		{
			return new IPullingCategoryMatchingFoundation_SetValue
			{
				Type = this.Type,
				InitMatchEntity = this.InitMatchEntity,
				MatchingConfigs = this.MatchingConfigs
			};
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000643C1 File Offset: 0x000625C1
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000643EC File Offset: 0x000625EC
		public override EPullingFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000643FC File Offset: 0x000625FC
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00064436 File Offset: 0x00062636
		public virtual int? InitMatchEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitMatchEntity;
				}
				IPullingCategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitMatchEntity;
			}
			set
			{
				this.GetOrCreatePoco().InitMatchEntity = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x00064444 File Offset: 0x00062644
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x000644D7 File Offset: 0x000626D7
		public virtual List<ICategoryMatchingConfigBase> MatchingConfigs
		{
			get
			{
				if (this._MatchingConfigsInited)
				{
					return this._MatchingConfigsCache;
				}
				this._MatchingConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ICategoryMatchingConfigBase> matchingConfigs = this.FbInstance.MatchingConfigs;
					if (matchingConfigs != null)
					{
						this._MatchingConfigsCache = new List<ICategoryMatchingConfigBase>(matchingConfigs.Count);
						for (int i = 0; i < matchingConfigs.Count; i++)
						{
							this._MatchingConfigsCache.Add(ICategoryMatchingConfigBase.Create(matchingConfigs[i]));
						}
					}
				}
				else
				{
					IPullingCategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
					this._MatchingConfigsCache = ((pocoInterface != null) ? pocoInterface.MatchingConfigs : null);
				}
				return this._MatchingConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().MatchingConfigs = value;
				this._MatchingConfigsInited = false;
			}
		}

		// Token: 0x04001986 RID: 6534
		[Nullable(2)]
		protected new IPullingCategoryMatchingFoundation FbInstance;

		// Token: 0x04001987 RID: 6535
		[Nullable(2)]
		protected new IPullingCategoryMatchingFoundation_SetValue PocoInterface;

		// Token: 0x04001988 RID: 6536
		private List<ICategoryMatchingConfigBase> _MatchingConfigsCache;

		// Token: 0x04001989 RID: 6537
		private bool _MatchingConfigsInited;
	}
}
