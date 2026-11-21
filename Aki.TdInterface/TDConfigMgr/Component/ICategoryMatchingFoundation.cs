using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024A RID: 586
	public class ICategoryMatchingFoundation : IItemFoundationType
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x0002A840 File Offset: 0x00028A40
		private ICategoryMatchingFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002A878 File Offset: 0x00028A78
		public static ICategoryMatchingFoundation Create([Nullable(2)] ICategoryMatchingFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002A88B File Offset: 0x00028A8B
		public static ICategoryMatchingFoundation CreateFromSetValue([Nullable(2)] ICategoryMatchingFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002A89E File Offset: 0x00028A9E
		public new ICategoryMatchingFoundation_SetValue ToSetValue()
		{
			return new ICategoryMatchingFoundation_SetValue
			{
				Type = this.Type,
				InitMatchEntity = this.InitMatchEntity,
				MatchingConfigs = this.MatchingConfigs
			};
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002A8C9 File Offset: 0x00028AC9
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		public override EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002A904 File Offset: 0x00028B04
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0002A93E File Offset: 0x00028B3E
		public virtual int? InitMatchEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitMatchEntity;
				}
				ICategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0002A94C File Offset: 0x00028B4C
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0002A9DF File Offset: 0x00028BDF
		public virtual List<ICategoryMatchingConfig> MatchingConfigs
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
					List<ICategoryMatchingConfig> matchingConfigs = this.FbInstance.MatchingConfigs;
					if (matchingConfigs != null)
					{
						this._MatchingConfigsCache = new List<ICategoryMatchingConfig>(matchingConfigs.Count);
						for (int i = 0; i < matchingConfigs.Count; i++)
						{
							this._MatchingConfigsCache.Add(ICategoryMatchingConfig.Create(matchingConfigs[i]));
						}
					}
				}
				else
				{
					ICategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000A50 RID: 2640
		[Nullable(2)]
		protected new ICategoryMatchingFoundation FbInstance;

		// Token: 0x04000A51 RID: 2641
		[Nullable(2)]
		protected new ICategoryMatchingFoundation_SetValue PocoInterface;

		// Token: 0x04000A52 RID: 2642
		private List<ICategoryMatchingConfig> _MatchingConfigsCache;

		// Token: 0x04000A53 RID: 2643
		private bool _MatchingConfigsInited;
	}
}
