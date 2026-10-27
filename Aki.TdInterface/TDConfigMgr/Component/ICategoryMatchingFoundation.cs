using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000223 RID: 547
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingFoundation : IItemFoundationType
	{
		// Token: 0x06000966 RID: 2406 RVA: 0x00029080 File Offset: 0x00027280
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

		// Token: 0x06000967 RID: 2407 RVA: 0x000290B8 File Offset: 0x000272B8
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

		// Token: 0x06000968 RID: 2408 RVA: 0x000290CB File Offset: 0x000272CB
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

		// Token: 0x06000969 RID: 2409 RVA: 0x000290DE File Offset: 0x000272DE
		public new ICategoryMatchingFoundation_SetValue ToSetValue()
		{
			return new ICategoryMatchingFoundation_SetValue
			{
				Type = this.Type,
				InitMatchEntity = this.InitMatchEntity,
				MatchingConfigs = this.MatchingConfigs
			};
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00029109 File Offset: 0x00027309
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00029134 File Offset: 0x00027334
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00029144 File Offset: 0x00027344
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002917E File Offset: 0x0002737E
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002918C File Offset: 0x0002738C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0002921F File Offset: 0x0002741F
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

		// Token: 0x040009C6 RID: 2502
		[Nullable(2)]
		protected new ICategoryMatchingFoundation FbInstance;

		// Token: 0x040009C7 RID: 2503
		[Nullable(2)]
		protected new ICategoryMatchingFoundation_SetValue PocoInterface;

		// Token: 0x040009C8 RID: 2504
		private List<ICategoryMatchingConfig> _MatchingConfigsCache;

		// Token: 0x040009C9 RID: 2505
		private bool _MatchingConfigsInited;
	}
}
